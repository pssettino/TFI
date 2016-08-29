Public Class frmLogin

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim _frmMenuPrincipal As New frmMenuPrincipal
        _frmMenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class