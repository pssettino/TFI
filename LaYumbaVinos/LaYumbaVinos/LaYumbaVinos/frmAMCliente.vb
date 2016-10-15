Public Class frmAMCliente
    Dim BitacoraBE As New BE.Bitacora
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim unCliente As New BE.Cliente
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Private _id As String

    Public Sub New(Optional idParameter As Integer = 0)
        InitializeComponent()
        _id = idParameter
    End Sub
    Private Sub frmAMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuUI = Me.Owner
        TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
        Dim PatenteBE As New BE.Patente
        PatenteBE.Nombre = "Cliente"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
            MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
            Application.Exit()
        End If
        TraduccionBLL.TraducirForm(Me)

        If _id = 0 Then
            Dim localidad = BLL.Localidad.GetInstance.ListAll
            cmbLocalidad.DataSource = localidad
            cmbLocalidad.DisplayMember = "descripcion"
            cmbLocalidad.ValueMember = "localidadId"
            Dim provincia = BLL.Provincia.GetInstance.ListAll
            cmbProvincia.DataSource = provincia
            cmbProvincia.DisplayMember = "descripcion"
            cmbProvincia.ValueMember = "provinciaId"
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Validar() Then
            Dim dni As String = Trim(txtDni.Text)
            Dim localidadBE As New BE.Localidad
            Dim provinciaBE As New BE.Provincia

            unCliente.Dni = dni

            provinciaBE.ProvinciaId = cmbProvincia.SelectedValue
            localidadBE.LocalidadId = cmbLocalidad.SelectedValue
            localidadBE.Provincia = provinciaBE
            unCliente.Localidad = localidadBE
            unCliente.Apellido = Trim(txtApellido.Text)
            unCliente.Nombre = Trim(txtNombre.Text)
            unCliente.Email = Trim(txtEmail.Text)
            unCliente.Telefono = Trim(txtTelefono.Text)
            unCliente.Direccion = Trim(txtDireccion.Text)


            If _id = 0 Then
                BLL.Cliente.GetInstance.Add(unCliente)
                MessageBox.Show(TraduccionBLL.TraducirTexto("Se Registro el Cliente") & ": " & dni, TraduccionBLL.TraducirTexto("Registrar Cliente"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                RegistrarBitacora("Registro Cliente: " & dni, "Alta")
            Else
                unCliente.ClienteId = _id
                BLL.Cliente.GetInstance.Update(unCliente)
                MessageBox.Show(TraduccionBLL.TraducirTexto("Se Modifico el Cliente") & ": " & dni, TraduccionBLL.TraducirTexto("Modificar Cliente"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                RegistrarBitacora("Modifico Cliente: " & dni, "Alta")
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub



    Private Function Validar() As Boolean
        Dim valido = True
        lblapellidoError.Visible = False
        If txtapellido.Text = "" Then
            valido = False
            lblapellidoError.Visible = True
            lblapellidoError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblEmailError.Visible = False
        If txtemail.Text = "" Then
            valido = False
            lblEmailError.Visible = True
            lblEmailError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        Else
            If SeguridadBLL.ValidarEmail(txtemail.Text) = False Then
                valido = False
                lblEmailError.Visible = True
                lblEmailError.Text = TraduccionBLL.TraducirTexto("Mail incorrecto")
            End If
        End If
        lbldnierror.Visible = False
        If txtdni.Text = "" Then
            valido = False
            lbldnierror.Visible = True
            lbldnierror.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        Else
            If SeguridadBLL.ValidarDNI(txtdni.Text) = False Then
                valido = False
                lbldnierror.Visible = True
                lbldnierror.Text = TraduccionBLL.TraducirTexto("DNI incorrecto")
            Else
                If BLL.Cliente.GetInstance.VerificarExistencia(txtdni.Text) And _id = 0 Then
                    valido = False
                    lbldnierror.Visible = True
                    lbldnierror.Text = TraduccionBLL.TraducirTexto("Cliente Existente")
                End If
            End If
        End If
        Lblnombreerror.Visible = False
        If txtnombre.Text = "" Then
            valido = False
            Lblnombreerror.Visible = True
            Lblnombreerror.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblTelefonoError.Visible = False
        If txttelefono.Text = "" Then
            valido = False
            lblTelefonoError.Visible = True
            lblTelefonoError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
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

    Public Sub SoloNumeros(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        SoloNumeros(sender, e)
    End Sub

    
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(sender, e)
    End Sub
End Class