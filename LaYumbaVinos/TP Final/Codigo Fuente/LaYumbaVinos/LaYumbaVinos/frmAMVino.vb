Public Class frmAMVino
    Dim BitacoraBE As New BE.Bitacora
    Dim BodegaBLL As New BLL.Bodega
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim unVino As New BE.Vino
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
        Try
            If Validar() Then
                Dim descripcion As String = Trim(txtDescripcion.Text)
                Dim bodegaSel As Integer = cmbBodega.SelectedValue
                Dim bodegaBE As New BE.Bodega

                unVino.Descripcion = descripcion

                bodegaBE.BodegaId = bodegaSel
                unVino.Bodega = bodegaBE

                unVino.Cantidad = SeguridadBLL.EncriptarRSA(Trim(txtCantidad.Text))
                unVino.Precio = SeguridadBLL.EncriptarRSA(Trim(txtPrecio.Text))

                If _id = 0 Then
                    BLL.Vino.GetInstance.Add(unVino)
                    MessageBox.Show(TraduccionBLL.TraducirTexto("Se Registro el Vino") & ": " & descripcion, TraduccionBLL.TraducirTexto("Registrar Vino"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RegistrarBitacora("Registro Vino: " & descripcion, "Alta")
                Else
                    unVino.VinoId = _id
                    BLL.Vino.GetInstance.Update(unVino)
                    MessageBox.Show(TraduccionBLL.TraducirTexto("Se Modifico el Vino") & ": " & descripcion, TraduccionBLL.TraducirTexto("Modificar Vino"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RegistrarBitacora("Modifico Vino: " & descripcion, "Alta")
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAMVino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MenuUI = Me.Owner
            TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
            Dim PatenteBE As New BE.Patente
            PatenteBE.Nombre = "Vino"
            PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
            If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
                MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Application.Exit()
            End If
            TraduccionBLL.TraducirForm(Me)

            If _id = 0 Then
                cmbBodega.DataSource = BodegaBLL.ListAll
                cmbBodega.ValueMember = "bodegaId"
                cmbBodega.DisplayMember = "razonSocial"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim valido = True
        lblDescripcionError.Visible = False
        If txtDescripcion.Text = "" Then
            valido = False
            lblDescripcionError.Visible = True
            lblDescripcionError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblBodegaError.Visible = False
        If cmbBodega.SelectedValue = 0 Then
            valido = False
            lblBodegaError.Visible = True
            lblBodegaError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblPrecioError.Visible = False
        If txtprecio.Text = "" Then
            valido = False
            lblPrecioError.Visible = True
            lblPrecioError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
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

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Try
            Dim Cont As Integer
            For i As Integer = 1 To Len(txtPrecio.Text)
                If Mid(txtPrecio.Text, i, 1) = "," Then Cont = Cont + 1
            Next
            Dim Cadena = ""
            If Cont >= 1 Then Cadena = "1234567980" Else Cadena = "1234567890,"
            If InStr(Cadena, e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class