Public Class frmMenuPrincipal
    Dim UsuarioBE As BE.Usuario
    Dim IdiomaBE As BE.Idioma
    Dim BitacoraBE As New BE.Bitacora
    Dim TraduccionBLL As BLL.Traduccion
    Dim PatenteBE As New BE.Patente


    Public Sub New(ByVal _usuarioBE As BE.Usuario, ByVal _idiomaBE As BE.Idioma)
        Try
            InitializeComponent()
            UsuarioBE = _usuarioBE
            IdiomaBE = _idiomaBE
            ValidarMenu()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        LaYumbaVinos.frmVentas.MdiParent = Me
        LaYumbaVinos.frmVentas.Show()
    End Sub


    Private Sub BodegasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodegasToolStripMenuItem.Click
        LaYumbaVinos.frmBodegas.MdiParent = Me
        LaYumbaVinos.frmBodegas.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        LaYumbaVinos.frmClientes.MdiParent = Me
        LaYumbaVinos.frmClientes.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        LaYumbaVinos.frmUsuarios.MdiParent = Me
        LaYumbaVinos.frmUsuarios.Show()
    End Sub

    Private Sub AdministrarFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarFamiliasToolStripMenuItem.Click
        LaYumbaVinos.frmFamilias.MdiParent = Me
        LaYumbaVinos.frmFamilias.Show()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        LaYumbaVinos.frmRestore.MdiParent = Me
        LaYumbaVinos.frmRestore.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        LaYumbaVinos.frmBackup.MdiParent = Me
        LaYumbaVinos.frmBackup.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        LaYumbaVinos.frmBitacora.MdiParent = Me
        LaYumbaVinos.frmBitacora.Show()

    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        LaYumbaVinos.frmCambiarContrasena.MdiParent = Me
        LaYumbaVinos.frmCambiarContrasena.Show()
    End Sub

    Private Sub AdministraciónDeVinosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LaYumbaVinos.frmVinos.MdiParent = Me
        LaYumbaVinos.frmVinos.Show()
    End Sub



    Public Sub ValidarMenu()

        Dim patentes = BLL.Patente.GetInstance.ListAll()
        For Each patente As BE.Patente In patentes
            If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, patente) Then
                SeguridadToolStripMenuItem.Enabled = True
                UsuariosToolStripMenuItem.Enabled = True
            End If
        Next

        SeguridadToolStripMenuItem.Enabled = True
        CambiarContraseñaToolStripMenuItem.Enabled = True
    End Sub

    Public Function GetUsuario() As BE.Usuario
        Return UsuarioBE
    End Function

    Public Function GetIdioma() As BE.Idioma
        Return IdiomaBE
    End Function

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            TraduccionBLL = New BLL.Traduccion(GetIdioma)
            TraduccionBLL.TraducirForm(Me)
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub VinosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VinosToolStripMenuItem1.Click
        LaYumbaVinos.frmVinos.MdiParent = Me
        LaYumbaVinos.frmVinos.Show()
    End Sub

    Private Sub frmMenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ReporteStockDeVinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteStockDeVinosToolStripMenuItem.Click
        LaYumbaVinos.frmVinosReporteFiltro.MdiParent = Me
        LaYumbaVinos.frmVinosReporteFiltro.Show()
    End Sub

    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        HelpProviderHG.SetShowHelp(Me, True)
    End Sub
End Class