Public Class frmMenuPrincipal

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        Dim _frmVentas As New frmVentas
        _frmVentas.Show()

    End Sub

    Private Sub VinosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VinosToolStripMenuItem1.Click
        Dim _frmVinos As New frmVinos
        _frmVinos.Show()

    End Sub

    Private Sub BodegasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodegasToolStripMenuItem.Click
        Dim _frmBodegas As New frmBodegas
        _frmBodegas.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim _frmClientes As New frmClientes
        _frmClientes.Show()

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim _frmUsuarios As New frmUsuarios
        _frmUsuarios.Show()

    End Sub

    Private Sub AdministrarFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarFamiliasToolStripMenuItem.Click
        Dim _frmFamilias As New frmFamilias
        _frmFamilias.Show()

    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Dim _frmRestore As New frmRestore
        _frmRestore.Show()

    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        Dim _frmBackup As New frmBackup
        _frmBackup.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        Dim _frmBitacora As New frmBitacora
        _frmBitacora.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        Dim _frmCambiarCotrasena As New frmCambiarContrasena
        _frmCambiarCotrasena.Show()
    End Sub
End Class