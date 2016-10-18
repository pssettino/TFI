Public Class frmAMBodega
    Dim BitacoraBE As New BE.Bitacora
    Dim ProvinciaBLL As New BLL.Provincia
    Dim LocalidadBLL As New BLL.Localidad
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim unaBodega As New BE.Bodega
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Private _id As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(Optional idParameter As Integer = 0)
        InitializeComponent()
        _id = idParameter
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Validar() Then
            Dim cuit As Integer = Integer.Parse(Trim(txtCuit.Text))
            Dim razonSocial As String = Trim(txtRazonSocial.Text)
            Dim provinciaSel As Integer = cmbProvincia.SelectedValue
            Dim localidadSel As Integer = cmbLocalidad.SelectedValue
            Dim telefono As Integer = Integer.Parse(Trim(txtTelefono.Text))
            Dim provinciaBE As New BE.Provincia
            Dim localidadBE As New BE.Localidad

            unaBodega.Cuit = cuit
            unaBodega.RazonSocial = razonSocial
            unaBodega.Telefono = telefono
            provinciaBE.ProvinciaId = provinciaSel
            localidadBE.LocalidadId = localidadSel
            unaBodega.Provincia = provinciaBE
            unaBodega.Localidad = localidadBE
            
            If _id = 0 Then
                BLL.Bodega.GetInstance.Add(unaBodega)
                MessageBox.Show(TraduccionBLL.TraducirTexto("Se Registro la bodega") & ": " & razonSocial, TraduccionBLL.TraducirTexto("Registrar bodega"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                RegistrarBitacora("Registro bodega: " & razonSocial, "Alta")
            Else
                unaBodega.BodegaId = _id
                BLL.Bodega.GetInstance.Update(unaBodega)
                MessageBox.Show(TraduccionBLL.TraducirTexto("Se Modifico el bodega") & ": " & razonSocial, TraduccionBLL.TraducirTexto("Modificar bodega"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                RegistrarBitacora("Modifico bodega: " & razonSocial, "Alta")
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAMBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuUI = Me.Owner
        TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
        Dim PatenteBE As New BE.Patente
        PatenteBE.Nombre = "Bodega"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
            MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
            Application.Exit()
        End If
        TraduccionBLL.TraducirForm(Me)

        If _id = 0 Then
            cmbProvincia.DataSource = ProvinciaBLL.ListAll
            cmbProvincia.ValueMember = "provinciaId"
            cmbProvincia.DisplayMember = "descripcion"

            cmbLocalidad.DataSource = LocalidadBLL.ListAll
            cmbLocalidad.ValueMember = "localidadId"
            cmbLocalidad.DisplayMember = "descripcion"
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim valido = True
        lblCuitError.Visible = False
        If txtCuit.Text = "" Then
            valido = False
            lblCuitError.Visible = True
            lblCuitError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblRazonSocialError.Visible = False
        If txtRazonSocial.Text = "" Then
            valido = False
            lblRazonSocialError.Visible = True
            lblRazonSocialError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblTelefonoError.Visible = False
        If txtTelefono.Text = "" Then
            valido = False
            lblTelefonoError.Visible = True
            lblTelefonoError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblProvinciaError.Visible = False
        If cmbProvincia.SelectedValue = 0 Then
            valido = False
            lblProvinciaError.Visible = True
            lblProvinciaError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblLocalidadError.Visible = False
        If cmbLocalidad.SelectedValue = 0 Then
            valido = False
            lblLocalidadError.Visible = True
            lblLocalidadError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        
        Return valido
    End Function

    Public Sub RegistrarBitacora(evento As String, nivel As String)
        Dim SeguridadBLL As New BLL.Seguridad
        BitacoraBE.Descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.usuario = MenuUI.GetUsuario
        BitacoraBE.criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub
End Class