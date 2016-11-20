Imports System.IO

Public Class frmServidor
    Dim SeguridadBLL As New BLL.Seguridad

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then
                File.WriteAllText("AccederServidorSQL.txt", SeguridadBLL.EncriptarRSA(txtServidor.Text))
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Function Validar() As Boolean
        Dim valido = True
        lblServidorError.Visible = False
        If txtServidor.Text = "" Then
            valido = False
            lblServidorError.Visible = True
            lblServidorError.Text = "Campo requerido"
        ElseIf (SeguridadBLL.ValidarServidor(txtServidor.Text)) = False Then
            valido = False
            lblServidorError.Visible = True
            lblServidorError.Text = "Servidor SQL incorrecto"
        End If
        Return valido
    End Function

End Class