Imports System.Text
Imports System.Security.Cryptography
Imports System.Security
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Conexion
    Dim passPhrase As String = "LaYumbaVinosPassPhrase"
    Dim saltValue As String = "LaYumbaVinosSaltValue"
    Dim passwordIterations As Integer = 2
    Dim initVector As String = "@1B2c3D4e5F6g7H8"
    Dim keySize As Integer = 256



    Private Sub New()

    End Sub

    Private Shared _instancia As DAL.Conexion

    Public Shared Function GetInstance() As DAL.Conexion

        If _instancia Is Nothing Then

            _instancia = New DAL.Conexion

        End If

        Return _instancia
    End Function

    Public Shared Function getConexionLaYumba() As String
        Dim DataSource As String
        Try
            DataSource = Conexion.GetInstance.DesencriptarRSA(File.ReadAllText("AccederServidorSQL.txt"))
            Return "Data Source=" + DataSource + ";Initial Catalog=layumbavinos;Integrated Security=True"
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function getConexionMaster() As String
        Dim DataSource As String = Conexion.GetInstance.DesencriptarRSA(File.ReadAllText("AccederServidorSQL.txt"))
        Return "Data Source=" + DataSource + ";Initial Catalog=master;Integrated Security=True"
    End Function



    Public Function DesencriptarRSA(ByVal Cadena As String) As String
        Dim cipherText = ""
        If Cadena <> "" Then
            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)
            Dim cipherTextBytes As Byte() = Convert.FromBase64String(Cadena)
            Dim password As New Rfc2898DeriveBytes(passPhrase, saltValueBytes, passwordIterations)
            Dim keyBytes As Byte() = password.GetBytes(CInt(keySize / 8))
            Dim symmetricKey As New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC
            Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)
            Dim memoryStream As New MemoryStream(cipherTextBytes)
            Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            cipherText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
        End If
        Return cipherText
    End Function

End Class
