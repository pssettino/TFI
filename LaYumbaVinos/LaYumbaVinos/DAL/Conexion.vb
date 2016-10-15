Imports System.IO
Public Class Conexion
    Public Shared Function getConexionLaYumba() As String
        Dim DataSource As String
        Try
            DataSource = File.ReadAllText("AccederServidorSQL.txt")
            Return "Data Source=" & DataSource & ";Initial Catalog=layumbavinos;Integrated Security=True"
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function getConexionMaster() As String
        Dim DataSource As String = File.ReadAllText("AccederServidorSQL.txt")
        Return "Data Source=" & DataSource & ";Initial Catalog=master;Integrated Security=True"
    End Function

End Class
