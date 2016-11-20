Public Class Vino
    Dim DigitoVerificadorHorizontalBLL As New BLL.DVH
    Dim DigitoVerificadorVerticalBLL As New BLL.DVV
    Dim dvhBE As BE.DVH
    Dim dvvBE As BE.DVV


    Private Sub New()

    End Sub

    Private Shared _instancia As BLL.Vino

    Public Shared Function GetInstance() As BLL.Vino
        If _instancia Is Nothing Then
            _instancia = New Vino
        End If

        Return _instancia
    End Function
    Public Function Add(objAdd As BE.Vino) As Boolean
        Try
            If DAL.Vino.GetInstance().Add(objAdd) Then
                Dim id = DAL.Vino.GetInstance.ObtenerMaxId()
                GenerarDV(id)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Delete(objDel As BE.Vino) As Boolean
        Try
            If DAL.Vino.GetInstance().Delete(objDel) Then
                Dim id = objDel.VinoId
                GenerarDV(id)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListAll() As List(Of BE.Vino)
        Try
            Return DAL.Vino.GetInstance.ListAll
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerVinosDisponibles(cantidad As String) As List(Of BE.Vino)
        Try
            Return DAL.Vino.GetInstance.ObtenerVinosDisponibles(cantidad)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListById(objId As BE.Vino) As BE.Vino
        Try
            Return DAL.Vino.GetInstance().ListById(objId)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Update(objUpd As BE.Vino) As Boolean
        Try
            If DAL.Vino.GetInstance().Update(objUpd) Then
                Dim id = objUpd.VinoId
                GenerarDV(id)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarStock(objUpd As BE.Vino) As Boolean
        Try
            If DAL.Vino.GetInstance().ActualizarStock(objUpd) Then
                Dim id = objUpd.VinoId
                GenerarDV(id)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerVinoPorDescripcion(strDescripcion As String) As List(Of BE.Vino)
        Try
            Return DAL.Vino.GetInstance.ObtenerVinoPorDescripcion(strDescripcion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerVinoPorBodega(bodega As BE.Bodega) As List(Of BE.Vino)
        Try
            Return DAL.Vino.GetInstance.ObtenerVinosPorBodega(bodega)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ObtenerVinoPorParametros(descripcion As String, bodega As BE.Bodega) As List(Of BE.Vino)
        Try
            Return DAL.Vino.GetInstance.ObtenerVinoPorParametros(descripcion, bodega)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function VerificarExistencia(vino As BE.Vino) As Boolean
        Try
            Return DAL.Vino.GetInstance().VerificarExistencia(vino)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GenerarDV(Optional ByVal Id As Integer = 0)
        Dim vino As New BE.Vino
        vino.VinoId = Id
        If Id > 0 Then
            Dim vinoBE = DAL.Vino.GetInstance.ListById(vino)
            dvhBE = New BE.DVH("Vino")
            dvhBE.AgregarRestriccion("vino_id", vinoBE.VinoId)
            DigitoVerificadorHorizontalBLL.GenerarDVH(dvhBE)
        End If
        dvvBE = New BE.DVV("Vino")
        DigitoVerificadorVerticalBLL.GenerarDVV(dvvBE)
    End Sub

End Class
