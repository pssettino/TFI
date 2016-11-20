Public Class Bodega
    Implements BE.ICrud(Of BE.Bodega)


    Private Shared _instancia As BLL.Bodega

    Public Shared Function GetInstance() As BLL.Bodega

        If _instancia Is Nothing Then

            _instancia = New BLL.Bodega

        End If

        Return _instancia
    End Function

    Public Function Add(objAdd As BE.Bodega) As Boolean Implements BE.ICrud(Of BE.Bodega).Add
        Try
            If DAL.Bodega.GetInstance().Add(objAdd) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Delete(objDel As BE.Bodega) As Boolean Implements BE.ICrud(Of BE.Bodega).Delete
        Try
            If DAL.Bodega.GetInstance().Delete(objDel) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListAll() As List(Of BE.Bodega) Implements BE.ICrud(Of BE.Bodega).ListAll
        Try
            Return DAL.Bodega.GetInstance().ListAll
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListById(objId As BE.Bodega) As BE.Bodega Implements BE.ICrud(Of BE.Bodega).ListById
        Try
            Return DAL.Bodega.GetInstance().ListById(objId)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Update(objUpd As BE.Bodega) As Boolean Implements BE.ICrud(Of BE.Bodega).Update
        Try
            If DAL.Bodega.GetInstance().Update(objUpd) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
