Public Class Vino
    Implements BE.ICrud(Of BE.Vino)

    Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}

    Private Shared _instancia As DAL.Vino

    Public Shared Function GetInstance() As DAL.Vino

        If _instancia Is Nothing Then

            _instancia = New DAL.Vino

        End If

        Return _instancia
    End Function
    Public Function Add(objAdd As BE.Vino) As Boolean Implements BE.ICrud(Of BE.Vino).Add
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim descripcion As New SqlClient.SqlParameter
        Dim bodegaId As New SqlClient.SqlParameter
        Dim precio As New SqlClient.SqlParameter
        Dim cantidad As New SqlClient.SqlParameter



        comm.Connection = sqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_InsertarVino"

        descripcion.DbType = DbType.String
        descripcion.ParameterName = "@descripcion"
        descripcion.Value = objAdd.descripcion

        bodegaId.DbType = DbType.Int32
        bodegaId.ParameterName = "@bodega_id"
        bodegaId.Value = objAdd.Bodega.BodegaId

        precio.DbType = DbType.String
        precio.ParameterName = "@precio"
        precio.Value = objAdd.precio

        cantidad.DbType = DbType.String
        cantidad.ParameterName = "@cantidad"
        cantidad.Value = objAdd.cantidad
         
        comm.Parameters.Add(descripcion)
        comm.Parameters.Add(bodegaId)
        comm.Parameters.Add(precio)
        comm.Parameters.Add(cantidad)


        Try
            sqlDA.InsertCommand = comm

            sqlDA.InsertCommand.Connection.Open()

            If sqlDA.InsertCommand.ExecuteNonQuery > 0 Then
                returnValue = True
            End If

        Catch ex As Exception
            Throw ex
        Finally
            sqlDA.InsertCommand.Connection.Close()
        End Try

        Return returnValue
    End Function

    Public Function Delete(objDel As BE.Vino) As Boolean Implements BE.ICrud(Of BE.Vino).Delete

        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim vinoId As New SqlClient.SqlParameter
        Dim eliminado As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_EliminarVino"

        vinoId.DbType = DbType.Int32
        vinoId.ParameterName = "@vino_Id"
        vinoId.Value = objDel.VinoId

        eliminado.DbType = DbType.Boolean
        eliminado.ParameterName = "@eliminado"
        eliminado.Value = objDel.eliminado

        comm.Parameters.Add(vinoId)
        comm.Parameters.Add(eliminado)

        Try
            sqlDA.DeleteCommand = comm

            sqlDA.DeleteCommand.Connection.Open()

            If sqlDA.DeleteCommand.ExecuteNonQuery > 0 Then
                returnValue = True
            End If

        Catch ex As Exception
            Throw ex
        Finally
            sqlDA.DeleteCommand.Connection.Close()
        End Try

        Return returnValue
    End Function

    Public Function ListAll() As List(Of BE.Vino) Implements BE.ICrud(Of BE.Vino).ListAll
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerVinos"
        Dim vinos = Nothing
        Try
            vinos = SetearListaDeVinos(comm, sqlDa, ds)
        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return vinos

    End Function

    Public Function ListById(objId As BE.Vino) As BE.Vino Implements BE.ICrud(Of BE.Vino).ListById
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim vinoId As New SqlClient.SqlParameter
        Dim ds As New DataSet
        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "SP_ObtenerVinosPorID"

        vinoId.DbType = DbType.Int32
        vinoId.ParameterName = "@vino_id"
        vinoId.Value = objId.VinoId

        comm.Parameters.Add(vinoId)
        Dim vinos As New List(Of BE.Vino)
        Try
            vinos = SetearListaDeVinos(comm, sqlDa, ds)
        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        If vinos.Count = 0 Then
            Return New BE.Vino
        Else

            Return vinos(0)
        End If

        
    End Function

    Public Function Update(objUpd As BE.Vino) As Boolean Implements BE.ICrud(Of BE.Vino).Update
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim vinoId As New SqlClient.SqlParameter
        Dim descripcion As New SqlClient.SqlParameter
        Dim bodegaId As New SqlClient.SqlParameter
        Dim precio As New SqlClient.SqlParameter
        Dim cantidad As New SqlClient.SqlParameter


        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ModificarVino"

        vinoId.DbType = DbType.Int32
        vinoId.ParameterName = "@vino_id"
        vinoId.Value = objUpd.VinoId

        descripcion.DbType = DbType.String
        descripcion.ParameterName = "@descripcion"
        descripcion.Value = objUpd.descripcion

        bodegaId.DbType = DbType.Int32
        bodegaId.ParameterName = "@bodega_id"
        bodegaId.Value = objUpd.Bodega.BodegaId

        precio.DbType = DbType.String
        precio.ParameterName = "@precio"
        precio.Value = objUpd.precio

        cantidad.DbType = DbType.String
        cantidad.ParameterName = "@cantidad"
        cantidad.Value = objUpd.cantidad

        comm.Parameters.Add(vinoId)
        comm.Parameters.Add(descripcion)
        comm.Parameters.Add(bodegaId)
        comm.Parameters.Add(precio)
        comm.Parameters.Add(cantidad)


        Try
            sqlDA.UpdateCommand = comm

            sqlDA.UpdateCommand.Connection.Open()

            If sqlDA.UpdateCommand.ExecuteNonQuery > 0 Then
                returnValue = True
            End If

        Catch ex As Exception
            Throw ex
        Finally
            sqlDA.UpdateCommand.Connection.Close()
        End Try

        Return returnValue
    End Function

    Public Function VerificarExistencia(vino As BE.Vino) As Boolean
        Dim returnValue As Boolean = False
        Dim comm As New SqlClient.SqlCommand
        Dim descripcion As New SqlClient.SqlParameter
        Dim reader As SqlClient.SqlDataReader

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_VerificarVino"

        descripcion.DbType = DbType.String
        descripcion.ParameterName = "@descripcion"
        descripcion.Value = vino.descripcion

        comm.Parameters.Add(descripcion)

        Try
            SqlConn.Open()
            reader = comm.ExecuteReader()

            If reader.HasRows Then
                returnValue = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            reader = Nothing
            SqlConn.Close()
        End Try
        Return returnValue
    End Function
    Function ObtenerMaxId() As Integer
        Dim SqlComm As New SqlClient.SqlCommand

        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable

        sqlConn.Open()
        SqlComm.CommandText = String.Format("SELECT MAX(vino_id) as MaxId FROM Vino ")
        SqlComm.Connection = sqlConn
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        sqlConn.Close()

        Return dt.Rows(0).Item(0)
    End Function

    Function ObtenerVinoPorDescripcion(strDescripcion As String) As List(Of BE.Vino)
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim descripcion As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerVinosPorDescripcion"

        descripcion.DbType = DbType.String
        descripcion.ParameterName = "@descripcion"
        descripcion.Value = strDescripcion

        comm.Parameters.Add(descripcion)

            Dim vinos = Nothing
        Try
            vinos = SetearListaDeVinos(comm, sqlDa, ds)
        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return vinos

    End Function

    Function ObtenerVinosPorBodega(bodega As BE.Bodega) As List(Of BE.Vino)
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim bodegaId As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerVinosPorBodega"

        bodegaId.DbType = DbType.Int16
        bodegaId.ParameterName = "@bodega_id"
        bodegaId.Value = bodega.BodegaId

        comm.Parameters.Add(bodegaId)

            Dim vinos = Nothing
        Try
            vinos = SetearListaDeVinos(comm, sqlDa, ds)
        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return vinos
    End Function

    Function ObtenerVinosDisponibles(cantidad As String) As List(Of BE.Vino)
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim _cantidad As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerVinosDisponibles"

        _cantidad.DbType = DbType.String
        _cantidad.ParameterName = "@cantidad"
        _cantidad.Value = cantidad

        comm.Parameters.Add(_cantidad)
        
        Dim vinos = Nothing
        Try
            vinos = SetearListaDeVinos(comm, sqlDa, ds)
        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return vinos
    End Function

    Function ActualizarStock(vino As BE.Vino) As Boolean
        Dim SqlComm As New SqlClient.SqlCommand
        SqlConn.Open()
        SqlComm.CommandText = String.Format("UPDATE [dbo].[Vino]  SET [cantidad] = '" & vino.cantidad & "'  WHERE [vino_id] = " & vino.VinoId)
        SqlComm.Connection = SqlConn
        SqlComm.ExecuteNonQuery()
        SqlConn.Close()
        Return True
    End Function

    Function ObtenerVinoPorParametros(descripcion As String, bodega As BE.Bodega, check As Boolean) As List(Of BE.Vino)
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim _descripcion As New SqlClient.SqlParameter
        Dim bodegaId As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerVinoPorParametros"

        _descripcion.DbType = DbType.String
        _descripcion.ParameterName = "@descripcion"
        _descripcion.Value = descripcion

        bodegaId.DbType = DbType.Int16
        bodegaId.ParameterName = "@bodega_id"
        bodegaId.Value = bodega.BodegaId


        comm.Parameters.Add(_descripcion)
        comm.Parameters.Add(bodegaId)
        Dim vinos = Nothing
        Try
            vinos = SetearListaDeVinos(comm, sqlDa, ds)
        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return vinos
    End Function


    Private Function SetearListaDeVinos(comm As SqlClient.SqlCommand, sqlDa As SqlClient.SqlDataAdapter, ds As DataSet) As List(Of BE.Vino)
        Dim vinoList As New List(Of BE.Vino)
        sqlDa.SelectCommand = comm

        sqlDa.Fill(ds)

        For Each fila As DataRow In ds.Tables(0).Rows
            Dim vinoBE As New BE.Vino
            Dim bodegaBE As New BE.Bodega
            vinoBE.VinoId = CInt(fila("vino_id"))
            vinoBE.descripcion = CStr(fila("descripcion"))
            bodegaBE.cuit = CStr(fila("cuit"))
            bodegaBE.razonSocial = CStr(fila("razon_social"))
            vinoBE.Bodega = bodegaBE
            vinoBE.eliminado = CBool(fila("eliminado"))
            vinoBE.precio = CStr(fila("precio"))
            vinoBE.cantidad = CStr(fila("cantidad"))

            vinoList.Add(vinoBE)
        Next
        Return vinoList
    End Function
End Class
