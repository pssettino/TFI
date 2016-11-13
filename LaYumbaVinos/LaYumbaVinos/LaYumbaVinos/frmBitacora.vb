Public Class frmBitacora

    Dim SeguridadBLL As New BLL.Seguridad
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Dim TraduccionBLL As BLL.Traduccion

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            dgBitacora.Rows.Clear()
            ListarBitacoras()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ListarBitacoras()
        Dim fechaDesde = New DateTime(dtpFechaDesde.Value.Year, dtpFechaDesde.Value.Month, dtpFechaDesde.Value.Day, 0, 0, 0)
        Dim fechaHasta = New DateTime(dtpFechaHasta.Value.Year, dtpFechaHasta.Value.Month, dtpFechaHasta.Value.Day, 23, 59, 59)
        Dim BitacorasBE As New BE.Bitacora
        Dim bitacoras As New List(Of BE.Bitacora)

        bitacoras = BLL.Bitacora.GetInstance.ListarBitacoraPorParametros(cmbUsuario.SelectedValue, fechaDesde, fechaHasta, cmbCriticidad.SelectedValue)
        For Each BitacorasBE In bitacoras
            Dim n As Integer = dgBitacora.Rows.Add()
            dgBitacora.Rows.Item(n).Cells("Id").Value = BitacorasBE.BitacoraId
            dgBitacora.Rows.Item(n).Cells("Usuario").Value = SeguridadBLL.DesencriptarRSA(BitacorasBE.usuario.NombreUsuario)
            dgBitacora.Rows.Item(n).Cells("Descripcion").Value = SeguridadBLL.DesencriptarRSA(BitacorasBE.Descripcion)
            dgBitacora.Rows.Item(n).Cells("Fecha_Hora").Value = BitacorasBE.FechaHora.ToString("yyyy/MM/dd HH:mm:ss")
            dgBitacora.Rows.Item(n).Cells("Criticidad").Value = BitacorasBE.criticidad
        Next
        Return bitacoras
    End Function


    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Try
            dgBitacora.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MenuUI = Me.MdiParent
            TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
            Dim PatenteBE As New BE.Patente
            PatenteBE.Nombre = "Bitacora"
            PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
            If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
                MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Application.Exit()
            End If
            TraduccionBLL.TraducirForm(Me)
            MuestraCamposBitacora()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub MuestraCamposBitacora()
        cmbUsuario.Items.Clear()

        Dim myList As New Dictionary(Of Integer, String)
        myList.Add(0, TraduccionBLL.TraducirTexto("Todos los Usuarios"))
        For Each UsuarioBE In BLL.Usuario.GetInstance.ListAll()
            myList.Add(UsuarioBE.UsuarioId, SeguridadBLL.DesencriptarRSA(UsuarioBE.NombreUsuario))
        Next
        cmbUsuario.DisplayMember = "Value"
        cmbUsuario.ValueMember = "Key"
        cmbUsuario.DataSource = New BindingSource(myList, Nothing)

        Dim myListNivel As New Dictionary(Of String, String)
        myListNivel.Add("Todos los niveles", TraduccionBLL.TraducirTexto("Todos los niveles"))
        myListNivel.Add("Alta", "Alta")
        myListNivel.Add("Media", "Media")
        myListNivel.Add("Baja", "Baja")
        cmbCriticidad.DisplayMember = "Value"
        cmbCriticidad.ValueMember = "Key"

        cmbCriticidad.DataSource = New BindingSource(myListNivel, Nothing)

    End Sub


End Class