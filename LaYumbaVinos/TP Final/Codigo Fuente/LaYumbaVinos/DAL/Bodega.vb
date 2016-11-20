Public Class Bodega
    Implements BE.ICrud(Of BE.Bodega)
    Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}


    Private Shared _instancia As DAL.Bodega

    Public Shared Function GetInstance() As DAL.Bodega

        If _instancia Is Nothing Then

            _instancia = New DAL.Bodega

        End If

        Return _instancia
    End Function

    Public Function Add(objAdd As BE.Bodega) As Boolean Implements BE.ICrud(Of BE.Bodega).Add
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim cuit As New SqlClient.SqlParameter
        Dim razonSocial As New SqlClient.SqlParameter
        Dim telefono As New SqlClient.SqlParameter
        Dim provincia As New SqlClient.SqlParameter
        Dim localidad As New SqlClient.SqlParameter

      

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_InsertarBodega"

        cuit.DbType = DbType.Int32
        cuit.ParameterName = "@cuit"
        cuit.Value = objAdd.cuit

        razonSocial.DbType = DbType.String
        razonSocial.ParameterName = "@razonSocial"
        razonSocial.Value = objAdd.razonSocial


        telefono.DbType = DbType.String
        telefono.ParameterName = "@telefono"
        telefono.Value = objAdd.telefono

        provincia.DbType = DbType.Int32
        provincia.ParameterName = "@provincia_fk"
        provincia.Value = objAdd.Provincia.ProvinciaId

        localidad.DbType = DbType.Int32
        localidad.ParameterName = "@localidad_fk"
        localidad.Value = objAdd.Localidad.LocalidadId

        comm.Parameters.Add(cuit)
        comm.Parameters.Add(razonSocial)
        comm.Parameters.Add(telefono)
        comm.Parameters.Add(provincia)
        comm.Parameters.Add(localidad)

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

    Public Function Delete(objDel As BE.Bodega) As Boolean Implements BE.ICrud(Of BE.Bodega).Delete
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim BodegaId As New SqlClient.SqlParameter
        Dim eliminado As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_EliminarBodega"

        BodegaId.DbType = DbType.Int32
        BodegaId.ParameterName = "@bodegaId"
        BodegaId.Value = objDel.BodegaId

       
        eliminado.DbType = DbType.Boolean
        eliminado.ParameterName = "@eliminado"
        eliminado.Value = objDel.Eliminado

        comm.Parameters.Add(BodegaId)
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

    Public Function ListAll() As List(Of BE.Bodega) Implements BE.ICrud(Of BE.Bodega).ListAll
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerBodegas"
        Dim bodegas As New List(Of BE.Bodega)

        Try
            sqlDa.SelectCommand = comm

            sqlDa.Fill(ds)

            For Each fila As DataRow In ds.Tables(0).Rows
                Dim BodegaBE As New BE.Bodega
                ' Dim LocalidadBE As New BE.Localidad
                'Dim ProvinciaBE As New BE.Provincia

                BodegaBE.BodegaId = CInt(fila("bodega_Id"))
                BodegaBE.cuit = fila("cuit")
                BodegaBE.razonSocial = CStr(fila("razon_social"))
                BodegaBE.telefono = CStr(fila("telefono"))

                bodegas.Add(BodegaBE)
            Next

        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return bodegas
    End Function

    Public Function ListById(objId As BE.Bodega) As BE.Bodega Implements BE.ICrud(Of BE.Bodega).ListById
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDa As New SqlClient.SqlDataAdapter
        Dim returnValue As Boolean = False
        Dim bodegaId As New SqlClient.SqlParameter
        Dim ds As New DataSet

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ObtenerBodegaPorID"

        bodegaId.DbType = DbType.Int32
        bodegaId.ParameterName = "@bodega_Id"
        bodegaId.Value = objId.BodegaId

        comm.Parameters.Add(bodegaId)
        Dim bodegas As New BE.Bodega

        Try
            sqlDa.SelectCommand = comm

            sqlDa.SelectCommand.Connection.Open()

            sqlDa.Fill(ds)

            For Each fila As DataRow In ds.Tables(0).Rows
                Dim BodegaBE As New BE.Bodega
                Dim LocalidadBE As New BE.Localidad
                Dim ProvinciaBE As New BE.Provincia

                BodegaBE.BodegaId = CInt(fila("bodega_Id"))
                BodegaBE.cuit = fila("cuit")
                BodegaBE.razonSocial = CStr(fila("razon_social"))
                BodegaBE.telefono = CStr(fila("telefono"))

                ProvinciaBE.ProvinciaId = CInt(fila("provincia_fk"))
                ProvinciaBE = Provincia.GetInstance.ListById(ProvinciaBE)
                LocalidadBE.LocalidadId = CInt(fila("localidad_fk"))
                LocalidadBE = Localidad.GetInstance.ListById(LocalidadBE)
                BodegaBE.Provincia = ProvinciaBE
                BodegaBE.Localidad = LocalidadBE
                bodegas = BodegaBE
            Next

        Catch ex As Exception
            Throw ex
        Finally
            sqlDa.SelectCommand.Connection.Close()
        End Try

        Return bodegas
    End Function

    Public Function Update(objUpd As BE.Bodega) As Boolean Implements BE.ICrud(Of BE.Bodega).Update
        Dim comm As New SqlClient.SqlCommand
        Dim sqlDA As New SqlClient.SqlDataAdapter

        Dim returnValue As Boolean = False

        Dim bodegaId As New SqlClient.SqlParameter
        Dim cuit As New SqlClient.SqlParameter
        Dim razonSocial As New SqlClient.SqlParameter
        Dim telefono As New SqlClient.SqlParameter
        Dim provincia As New SqlClient.SqlParameter
        Dim localidad As New SqlClient.SqlParameter

        comm.Connection = SqlConn
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SP_ModificarBodega"

        bodegaId.DbType = DbType.Int32
        bodegaId.ParameterName = "@bodegaId"
        bodegaId.Value = objUpd.BodegaId

        cuit.DbType = DbType.Int32
        cuit.ParameterName = "@cuit"
        cuit.Value = objUpd.cuit

        razonSocial.DbType = DbType.String
        razonSocial.ParameterName = "@razonSocial"
        razonSocial.Value = objUpd.razonSocial


        telefono.DbType = DbType.String
        telefono.ParameterName = "@telefono"
        telefono.Value = objUpd.Telefono

        provincia.DbType = DbType.Int32
        provincia.ParameterName = "@provincia_fk"
        provincia.Value = objUpd.Provincia.ProvinciaId

        localidad.DbType = DbType.Int32
        localidad.ParameterName = "@localidad_fk"
        localidad.Value = objUpd.Localidad.LocalidadId


        comm.Parameters.Add(bodegaId)
        comm.Parameters.Add(cuit)
        comm.Parameters.Add(razonSocial)
        comm.Parameters.Add(telefono)
        comm.Parameters.Add(provincia)
        comm.Parameters.Add(localidad)
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

  
    Function ObtenerMaxId() As Integer
        Dim SqlComm As New SqlClient.SqlCommand

        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable

        sqlConn.Open()
        SqlComm.CommandText = String.Format("SELECT MAX(bodega_id) as MaxId FROM Bodega ")
        SqlComm.Connection = sqlConn
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        sqlConn.Close()

        Return dt.Rows(0).Item(0)
    End Function
 
End Class
