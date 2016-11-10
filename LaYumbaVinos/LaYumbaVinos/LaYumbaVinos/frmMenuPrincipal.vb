Public Class frmMenuPrincipal
    Dim UsuarioBE As BE.Usuario
    Dim IdiomaBE As BE.Idioma
    Dim BitacoraBE As New BE.Bitacora
    Dim TraduccionBLL As BLL.Traduccion
    Dim PatenteBE As New BE.Patente


    Public Sub New(ByVal _usuarioBE As BE.Usuario, ByVal _idiomaBE As BE.Idioma)
        InitializeComponent()
        UsuarioBE = _usuarioBE
        IdiomaBE = _idiomaBE
        ValidarMenu()
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

    Private Sub AdministraciónDeVinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeVinosToolStripMenuItem.Click
        LaYumbaVinos.frmVinos.MdiParent = Me
        LaYumbaVinos.frmVinos.Show()
    End Sub



    Public Sub ValidarMenu()

        PatenteBE.Nombre = "Usuario"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            SeguridadToolStripMenuItem.Enabled = True
            UsuariosToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Familia"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            SeguridadToolStripMenuItem.Enabled = True
            AdministrarFamiliasToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Backup"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            SeguridadToolStripMenuItem.Enabled = True
            BackupToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Restore"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            SeguridadToolStripMenuItem.Enabled = True
            RestoreToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Bitacora"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            SeguridadToolStripMenuItem.Enabled = True
            BitacoraToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Venta"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            VentasToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Cliente"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            ClientesToolStripMenuItem.Enabled = True
        End If

        PatenteBE.Nombre = "Vino"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If BLL.Usuario.GetInstance.VerificarPatente(UsuarioBE, PatenteBE) Then
            VinosToolStripMenuItem.Enabled = True
            ReporteStockDeVinosToolStripMenuItem.Enabled = True
        End If

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
        TraduccionBLL = New BLL.Traduccion(GetIdioma)
        TraduccionBLL.TraducirForm(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class