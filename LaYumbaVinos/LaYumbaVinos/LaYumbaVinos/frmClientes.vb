Public Class frmClientes

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim _frmAMCliente As New frmAMCliente
        _frmAMCliente.Show()
    End Sub
End Class