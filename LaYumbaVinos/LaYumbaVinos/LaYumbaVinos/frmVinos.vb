Public Class frmVinos
    Dim BitacoraBE As New BE.Bitacora
    Dim unVino As New BE.Vino
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim BodegaBLL As New BLL.Bodega

    Private Sub btnNuevoVino_Click(sender As Object, e As EventArgs) Handles btnNuevoVino.Click
        Dim _frmAMVino As New frmAMVino
        If _frmAMVino.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ObtenerVinos()
        End If
    End Sub

    Private Sub frmVinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuUI = Me.MdiParent
        TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
        Dim PatenteBE As New BE.Patente
        PatenteBE.Nombre = "Vino"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
            MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
            Application.Exit()
        End If
        TraduccionBLL.TraducirForm(Me)
        ObtenerVinos()


        Dim myList As New Dictionary(Of Integer, String)
        myList.Add(0, TraduccionBLL.TraducirTexto("Todas las Bodegas"))
        For Each BodegaBE In BodegaBLL.ListAll
            myList.Add(BodegaBE.BodegaId, BodegaBE.RazonSocial)
        Next
        cmbVinos.DisplayMember = "Value"
        cmbVinos.ValueMember = "Key"
        cmbVinos.DataSource = New BindingSource(myList, Nothing)
    End Sub

    Private Sub ObtenerVinos()
        dgVinos.Rows.Clear()
        For Each VinoBE In BLL.Vino.GetInstance.ListAll()
            Dim n As Integer = dgVinos.Rows.Add()
            dgVinos.Rows.Item(n).Cells("id").Value = VinoBE.VinoId
            dgVinos.Rows.Item(n).Cells("descripcion").Value = VinoBE.Descripcion
            dgVinos.Rows.Item(n).Cells("bodega").Value = VinoBE.Bodega.RazonSocial
            dgVinos.Rows.Item(n).Cells("cantidad").Value = SeguridadBLL.DesencriptarRSA(VinoBE.Cantidad)
            dgVinos.Rows.Item(n).Cells("precio").Value = SeguridadBLL.DesencriptarRSA(VinoBE.Precio)
            dgVinos.Rows.Item(n).Cells("eliminado").Value = VinoBE.Eliminado
            Dim dgBtnEliminar = New DataGridViewButtonCell()
            If VinoBE.Eliminado = True Then
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Activar")
            Else
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Eliminar")
            End If
            dgVinos.Rows.Item(n).Cells("dgBtnEliminar") = dgBtnEliminar
        Next
    End Sub

    Private Sub dgVinos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVinos.CellContentClick
        Dim id As String = Convert.ToString(dgVinos.CurrentRow.Cells("id").Value)
        Dim eliminado As Boolean = dgVinos.CurrentRow.Cells("Eliminado").Value
        Dim NombreVino As String = Convert.ToString(dgVinos.CurrentRow.Cells("Descripcion").Value)
        Dim Nombre As String
        Dim Descr As String
        Dim result As Integer

        'MODIFICAR
        If e.ColumnIndex = 6 Then 'Nro Columna del datagriew
            Dim VinoModificar As New frmAMVino(id)
            Dim SeguridadBLL As New BLL.Seguridad
            Dim BodegaBLL As New BLL.Bodega
            VinoModificar.txtDescripcion.Focus()

            unVino.VinoId = id
            unVino = BLL.Vino.GetInstance().ListById(unVino)

            VinoModificar.cmbBodega.DataSource = BodegaBLL.ListAll
            VinoModificar.cmbBodega.ValueMember = "bodegaId"
            VinoModificar.cmbBodega.DisplayMember = "razonSocial"

            VinoModificar.cmbBodega.SelectedItem = unVino.Bodega.BodegaId

            VinoModificar.txtDescripcion.Text = unVino.Descripcion
            VinoModificar.cmbBodega.Text = unVino.Bodega.RazonSocial
            VinoModificar.txtCantidad.Text = SeguridadBLL.DesencriptarRSA(unVino.Cantidad)
            VinoModificar.txtPrecio.Text = SeguridadBLL.DesencriptarRSA(unVino.Precio)

            If VinoModificar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ObtenerVinos()
            End If
        End If
        'ELIMINAR
        If e.ColumnIndex = 7 Then 'Nro Columna del datagriew
            If eliminado = True Then
                eliminado = False
                Descr = "Activar"
                Nombre = "Se activo el Vino: " & NombreVino
            Else
                eliminado = True
                Descr = "Eliminar"
                Nombre = "Elimino Vino: " & NombreVino
            End If
            result = MessageBox.Show(TraduccionBLL.TraducirTexto("¿Esta seguro que desea " & Descr & " el Vino") & ": " & NombreVino & "?", TraduccionBLL.TraducirTexto(Descr & " Vino"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                unVino.VinoId = id
                unVino.Eliminado = eliminado
                BLL.Vino.GetInstance.Delete(unVino)
                RegistrarBitacora(Nombre, "Alta")
            End If
        End If
        ObtenerVinos()
    End Sub

    Public Sub RegistrarBitacora(evento As String, nivel As String)
        Dim SeguridadBLL As New BLL.Seguridad
        BitacoraBE.descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.usuario = MenuUI.GetUsuario
        BitacoraBE.criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        dgVinos.Rows.Clear()
        For Each VinoBE In BLL.Vino.GetInstance.ObtenerVinoPorDescripcion(Trim(txtDescripcion.Text))
            Dim n As Integer = dgVinos.Rows.Add()
            dgVinos.Rows.Item(n).Cells("id").Value = VinoBE.VinoId
            dgVinos.Rows.Item(n).Cells("descripcion").Value = VinoBE.Descripcion
            dgVinos.Rows.Item(n).Cells("bodega").Value = VinoBE.Bodega.RazonSocial
            dgVinos.Rows.Item(n).Cells("cantidad").Value = SeguridadBLL.DesencriptarRSA(VinoBE.Cantidad)
            dgVinos.Rows.Item(n).Cells("precio").Value = SeguridadBLL.DesencriptarRSA(VinoBE.Precio)
            dgVinos.Rows.Item(n).Cells("eliminado").Value = VinoBE.Eliminado

            Dim dgBtnEliminar = New DataGridViewButtonCell()
            If VinoBE.Eliminado = True Then
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Activar")
            Else
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Eliminar")
            End If
            dgVinos.Rows.Item(n).Cells("dgBtnEliminar") = dgBtnEliminar
        Next
    End Sub

    Private Sub cmbVinos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVinos.SelectedIndexChanged
        dgVinos.Rows.Clear()
        Dim BodegaBE As New BE.Bodega
        BodegaBE.BodegaId = cmbVinos.SelectedValue
        For Each VinoBE In BLL.Vino.GetInstance.ObtenerVinoPorBodega(BodegaBE)
            Dim n As Integer = dgVinos.Rows.Add()
            dgVinos.Rows.Item(n).Cells("id").Value = VinoBE.VinoId
            dgVinos.Rows.Item(n).Cells("descripcion").Value = VinoBE.Descripcion
            dgVinos.Rows.Item(n).Cells("bodega").Value = VinoBE.Bodega.RazonSocial
            dgVinos.Rows.Item(n).Cells("cantidad").Value = SeguridadBLL.DesencriptarRSA(VinoBE.Cantidad)
            dgVinos.Rows.Item(n).Cells("precio").Value = SeguridadBLL.DesencriptarRSA(VinoBE.Precio)
            dgVinos.Rows.Item(n).Cells("eliminado").Value = VinoBE.Eliminado

            Dim dgBtnEliminar = New DataGridViewButtonCell()
            If VinoBE.Eliminado = True Then
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Activar")
            Else
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Eliminar")
            End If
            dgVinos.Rows.Item(n).Cells("dgBtnEliminar") = dgBtnEliminar
        Next
    End Sub
End Class