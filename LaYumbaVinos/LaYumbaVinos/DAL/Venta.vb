'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''DAL
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class Venta
    Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}


    Private Shared _instancia As DAL.Venta

    Public Shared Function GetInstance() As DAL.Venta

        If _instancia Is Nothing Then

            _instancia = New DAL.Venta

        End If

        Return _instancia
    End Function

    Public Function RegistrarVenta(objAdd As BE.Venta) As Boolean
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim fechaVenta As New SqlClient.SqlParameter
        Dim dvh As New SqlClient.SqlParameter
        Dim clienteId As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_InsertarVenta"

        fechaVenta.DbType = DbType.DateTime
        fechaVenta.ParameterName = "@fecha_venta"
        fechaVenta.Value = objAdd.fechaVenta

        clienteId.DbType = DbType.Int32
        clienteId.ParameterName = "@cliente_fk"
        clienteId.Value = objAdd.cliente.clienteId

        dvh.DbType = DbType.Int16
        dvh.ParameterName = "@dvh"
        dvh.Value = 0

        comm.Parameters.Add(fechaVenta)
        comm.Parameters.Add(clienteId)
        comm.Parameters.Add(dvh)

        Try
            sqlDA.InsertCommand = comm

            sqlDA.InsertCommand.Connection.Open()

            If sqlDA.InsertCommand.ExecuteNonQuery > 0 Then
                sqlDA.InsertCommand.Connection.Close()
                Dim maxId As Integer = ObtenerMaxId()
                For Each item As BE.VentaVino In objAdd.Vinos
                    returnValue = RegistrarVentaVinos(item, maxId)
                    If returnValue = False Then
                        Exit For
                    End If
                Next
                returnValue = True
            End If

        Catch ex As Exception
            Throw ex
        Finally
            sqlDA.InsertCommand.Connection.Close()
        End Try

        Return returnValue
    End Function


    Public Function ModificarVenta(objUpd As BE.Venta) As Boolean
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim ventaId As New SqlClient.SqlParameter
        Dim clienteId As New SqlClient.SqlParameter
        Dim dvh As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ModificarVenta"

        ventaId.DbType = DbType.Int32
        ventaId.ParameterName = "@venta_id"
        ventaId.Value = objUpd.ventaId

        clienteId.DbType = DbType.Int32
        clienteId.ParameterName = "@cliente_id"
        clienteId.Value = objUpd.cliente.clienteId

        dvh.DbType = DbType.Int16
        dvh.ParameterName = "@dvh"
        dvh.Value = 0

        comm.Parameters.Add(ventaId)
        comm.Parameters.Add(clienteId)

        Try
            sqlDA.UpdateCommand = comm

            sqlDA.UpdateCommand.Connection.Open()

            If sqlDA.UpdateCommand.ExecuteNonQuery > 0 Then
                sqlDA.UpdateCommand.Connection.Close()
                If QuitarVentaVino(objUpd) Then
                    For Each item As BE.VentaVino In objUpd.Vinos
                        returnValue = RegistrarVentaVinos(item, objUpd.ventaId)
                        If returnValue = False Then
                            Exit For
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            sqlDA.UpdateCommand.Connection.Close()
        End Try

        Return returnValue
    End Function

    Function QuitarVentaVino(unaVenta As BE.Venta) As Boolean
        Dim SqlComm As New SqlClient.SqlCommand
        SqlConn.Open()
        SqlComm.CommandText = String.Format("delete from Venta_Vino  where venta_fk = " & unaVenta.VentaId)
        SqlComm.Connection = SqlConn
        SqlComm.ExecuteNonQuery()
        SqlConn.Close()
        Return True
    End Function



    Public Function ListarVentasPorParametros(fechaDesde As DateTime, fechaHasta As DateTime, cliente_fk As Integer) As List(Of BE.Venta)
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim ds As New DataSet

        Dim fecha_desde As New SqlClient.SqlParameter
        Dim fecha_hasta As New SqlClient.SqlParameter
        Dim clienteFk As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ListarVentasPorParametros"

        fecha_desde.DbType = DbType.DateTime
        fecha_desde.ParameterName = "@fecha_desde"
        fecha_desde.Value = fechaDesde

        fecha_hasta.DbType = DbType.DateTime
        fecha_hasta.ParameterName = "@fecha_hasta"
        fecha_hasta.Value = fechaHasta

        clienteFk.DbType = DbType.Int16
        clienteFk.ParameterName = "@cliente_fk"
        clienteFk.Value = cliente_fk

        comm.Parameters.Add(fecha_desde)
        comm.Parameters.Add(fecha_hasta)
        comm.Parameters.Add(clienteFk)

        Dim ventas As New List(Of BE.Venta)
        Try
            sqlDa.SelectCommand = comm

            sqlDa.SelectCommand.Connection.Open()

            sqlDa.Fill(ds)

            For Each fila As DataRow In ds.Tables(0).Rows
                Dim VentaBE As New BE.Venta
                Dim ClienteBE As New BE.Cliente

                VentaBE.ventaId = CInt(fila("venta_id"))
                VentaBE.fechaVenta = CDate(fila("fecha_venta"))
                ClienteBE.ClienteId = CInt(fila("cliente_id"))
                ClienteBE.Nombre = CStr(fila("nombre"))
                ClienteBE.Apellido = CStr(fila("apellido"))
                VentaBE.cliente = ClienteBE
                Dim VinoBE As New List(Of BE.VentaVino)
                For Each item In ObtenerVinosPorVenta(VentaBE.ventaId).Rows
                    Dim Vino As New BE.VentaVino
                    Dim ventaVino As New BE.Venta
                    ventaVino.VentaId = item("venta_fk")
                    Vino.Venta = ventaVino
                    Vino.VentaVinoId = item("venta_Vino_id")
                    Vino.CantidadVenta = item("cantidad_venta")
                    Vino.PrecioVenta = item("precio_venta")
                    VinoBE.Add(Vino)
                Next
                VentaBE.Vinos = VinoBE
                ventas.Add(VentaBE)
            Next

        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try
        Return ventas
    End Function


    Public Function RegistrarVentaVinos(vino As BE.VentaVino, ventaId As Integer) As Boolean
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim _ventaId As New SqlClient.SqlParameter
        Dim vinoId As New SqlClient.SqlParameter
        Dim cantidadVenta As New SqlClient.SqlParameter
        Dim precioVenta As New SqlClient.SqlParameter


        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_InsertarVentaVino"

        _ventaId.DbType = DbType.Int32
        _ventaId.ParameterName = "@venta_id"
        _ventaId.Value = ventaId

        vinoId.DbType = DbType.Int16
        vinoId.ParameterName = "@vino_id"
        vinoId.Value = vino.Vino.VinoId

        cantidadVenta.DbType = DbType.String
        cantidadVenta.ParameterName = "@cantidad_venta"
        cantidadVenta.Value = vino.CantidadVenta

        precioVenta.DbType = DbType.String
        precioVenta.ParameterName = "@precio_venta"
        precioVenta.Value = vino.PrecioVenta


        comm.Parameters.Add(_ventaId)
        comm.Parameters.Add(vinoId)
        comm.Parameters.Add(cantidadVenta)
        comm.Parameters.Add(precioVenta)

        Try
            sqlDA.InsertCommand = comm

            If sqlDA.InsertCommand.Connection.State = ConnectionState.Closed Then
                sqlDA.InsertCommand.Connection.Open()
            End If

            If sqlDA.InsertCommand.ExecuteNonQuery > 0 Then
                sqlDA.InsertCommand.Connection.Close()
                returnValue = True
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return returnValue
    End Function


    Public Function ListarVentaById(unaVenta As BE.Venta) As BE.Venta

        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim ds As New DataSet

        Dim _ventaId As New SqlClient.SqlParameter


        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ListarVentasById"

        _ventaId.DbType = DbType.Int32
        _ventaId.ParameterName = "@venta_id"
        _ventaId.Value = unaVenta.ventaId


        comm.Parameters.Add(_ventaId)

        Dim ventas As New List(Of BE.Venta)
        Try
            sqlDa.SelectCommand = comm

            sqlDa.SelectCommand.Connection.Open()
            sqlDa.Fill(ds)
            sqlDa.SelectCommand.Connection.Close()

            For Each fila As DataRow In ds.Tables(0).Rows
                Dim VentaBE As New BE.Venta
                Dim ClienteBE As New BE.Cliente

                VentaBE.ventaId = CInt(fila("venta_id"))
                VentaBE.fechaVenta = CDate(fila("fecha_venta"))
                ClienteBE.clienteId = CInt(fila("cliente_id"))
                ClienteBE.Nombre = CStr(fila("nombre"))
                ClienteBE.Apellido = CStr(fila("apellido"))
                VentaBE.cliente = DAL.Cliente.GetInstance.ListById(ClienteBE)
                VentaBE.Vinos = ListarVentaVinosByVentaId(VentaBE)
                ventas.Add(VentaBE)
            Next

        Catch ex As Exception
            Throw ex
        End Try
        Return ventas(0)
    End Function




    Public Function ListarVentaVinosByVentaId(venta As BE.Venta) As List(Of BE.VentaVino)

        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim ds As New DataSet

        Dim _ventaId As New SqlClient.SqlParameter


        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ListarVentasVinosByVentaId"

        _ventaId.DbType = DbType.Int32
        _ventaId.ParameterName = "@venta_id"
        _ventaId.Value = venta.ventaId


        comm.Parameters.Add(_ventaId)

        Dim VentaVinos As New List(Of BE.VentaVino)
        Try
            sqlDa.SelectCommand = comm

            sqlDa.SelectCommand.Connection.Open()
            sqlDa.Fill(ds)
            sqlDa.SelectCommand.Connection.Close()
            For Each fila As DataRow In ds.Tables(0).Rows
                Dim VentaVinoBE As New BE.VentaVino
                Dim VinoBE As New BE.Vino

                VentaVinoBE.Venta = venta
                VentaVinoBE.VentaVinoId = CInt(fila("venta_vino_id"))
                VentaVinoBE.CantidadVenta = fila("cantidad_venta")
                VentaVinoBE.PrecioVenta = fila("precio_venta")
                VinoBE.VinoId = CInt(fila("vino_id"))
                VentaVinoBE.Vino = DAL.Vino.GetInstance.ListById(VinoBE)
                VentaVinos.Add(VentaVinoBE)
            Next

        Catch ex As Exception
            Throw ex
        End Try
        Return VentaVinos
    End Function



    Public Function EliminarVentaVinosByVentaId(ventaId As Integer) As Boolean
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim _ventaId As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_EliminarVentaVinosByVentaId"

        _ventaId.DbType = DbType.Int16
        _ventaId.ParameterName = "@venta_id"
        _ventaId.Value = ventaId
        comm.Parameters.Add(_ventaId)
        Try
            sqlDA.DeleteCommand = comm
            sqlDA.DeleteCommand.Connection.Open()
            If sqlDA.DeleteCommand.ExecuteNonQuery > 0 Then
                sqlDA.DeleteCommand.Connection.Close()
                returnValue = True
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return returnValue
    End Function


    Function ObtenerMaxId() As Integer
        Dim SqlComm As New SqlClient.SqlCommand
        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable

        sqlConn.Open()
        SqlComm.CommandText = String.Format("SELECT isnull(MAX(venta_id),0) as MaxId FROM Venta ")
        SqlComm.Connection = sqlConn
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        sqlConn.Close()

        Return dt.Rows(0).Item(0)
    End Function

    Function ObtenerMaxIdVenta_Vino() As Integer
        Dim SqlComm As New SqlClient.SqlCommand
        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable

        SqlConn.Open()
        SqlComm.CommandText = String.Format("SELECT isnull(MAX(venta_vino_id),0) as MaxId FROM Venta_Vino ")
        SqlComm.Connection = SqlConn
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        SqlConn.Close()

        Return dt.Rows(0).Item(0)
    End Function

    Private Function ObtenerVinosPorVenta(_VentaId As Integer) As Object
        Dim SqlComm As New SqlClient.SqlCommand
        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable
        SqlComm.CommandText = String.Format("SELECT * FROM Venta_Vino where venta_fk = " & _VentaId)
        SqlComm.Connection = SqlConn
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        Return dt
    End Function

End Class ' Venta