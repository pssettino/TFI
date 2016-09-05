Public Class Vino
    Implements BE.ICrud(Of BE.Vino)

    Private Shared _instancia As DAL.Vino

    Public Shared Function GetInstance() As DAL.Vino

        If _instancia Is Nothing Then

            _instancia = New DAL.Vino

        End If

        Return _instancia
    End Function

    Public Function Add(objAdd As BE.Vino) As Boolean Implements BE.ICrud(Of BE.Vino).Add
        Return Nothing
    End Function

    Public Function Delete(objDel As BE.Vino) As Boolean Implements BE.ICrud(Of BE.Vino).Delete
        Return Nothing
    End Function

    Public Function ListAll() As List(Of BE.Vino) Implements BE.ICrud(Of BE.Vino).ListAll
        Return Nothing
    End Function

    Public Function ListById(objId As BE.Vino) As BE.Vino Implements BE.ICrud(Of BE.Vino).ListById
        Return Nothing
    End Function

    Public Function Update(objUpd As BE.Vino) As Boolean Implements BE.ICrud(Of BE.Vino).Update
        Return Nothing
    End Function
End Class
