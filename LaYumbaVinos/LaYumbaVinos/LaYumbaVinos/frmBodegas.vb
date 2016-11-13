Public Class frmBodegas
    Dim BitacoraBE As New BE.Bitacora
    Dim unaBodega As New BE.Bodega
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim ProvinciaBLL As New BLL.Provincia
    Dim LocalidadBLL As New BLL.Localidad

    Private Sub btnNuevaBodega_Click(sender As Object, e As EventArgs) Handles btnNuevaBodega.Click
        Dim _frmAMBodega As New frmAMBodega
        If _frmAMBodega.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ObtenerBodegas()
        End If
    End Sub

    Private Sub frmBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MenuUI = Me.MdiParent
            TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
            Dim PatenteBE As New BE.Patente
            PatenteBE.Nombre = "Bodega"
            PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
            If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
                MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Application.Exit()
            End If
            TraduccionBLL.TraducirForm(Me)
            ObtenerBodegas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ObtenerBodegas()
        dgBodegas.Rows.Clear()
        For Each BodegaBE In BLL.Bodega.GetInstance.ListAll()
            Dim n As Integer = dgBodegas.Rows.Add()
            dgBodegas.Rows.Item(n).Cells("id").Value = BodegaBE.BodegaId
            dgBodegas.Rows.Item(n).Cells("cuit").Value = BodegaBE.Cuit
            dgBodegas.Rows.Item(n).Cells("RazonSocial").Value = BodegaBE.RazonSocial
            dgBodegas.Rows.Item(n).Cells("Telefono").Value = BodegaBE.Telefono
            dgBodegas.Rows.Item(n).Cells("Eliminado").Value = BodegaBE.Eliminado
            Dim dgBtnEliminar = New DataGridViewButtonCell()
            If BodegaBE.Eliminado = True Then
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Activar")
            Else
                dgBtnEliminar.Value = TraduccionBLL.TraducirTexto("Eliminar")
            End If
            dgBodegas.Rows.Item(n).Cells("dgBtnEliminar") = dgBtnEliminar
        Next
    End Sub

    Private Sub dgBodegas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBodegas.CellContentClick
        Try
            Dim id As String = Convert.ToString(dgBodegas.CurrentRow.Cells("id").Value)
            Dim eliminado As Boolean = dgBodegas.CurrentRow.Cells("Eliminado").Value
            Dim RazonSocialBodega As String = Convert.ToString(dgBodegas.CurrentRow.Cells("RazonSocial").Value)
            Dim Nombre As String
            Dim Descr As String
            Dim result As Integer

            'MODIFICAR
            If e.ColumnIndex = 4 Then 'Nro Columna del datagriew
                Dim BodegaModificar As New frmAMBodega(id)
                Dim SeguridadBLL As New BLL.Seguridad
                Dim ProvinciaBLL As New BLL.Provincia
                Dim LocalidadBLL As New BLL.Localidad
                BodegaModificar.txtCuit.Focus()

                unaBodega.BodegaId = id
                unaBodega = BLL.Bodega.GetInstance().ListById(unaBodega)

                BodegaModificar.cmbProvincia.DataSource = ProvinciaBLL.ListAll
                BodegaModificar.cmbProvincia.ValueMember = "provinciaId"
                BodegaModificar.cmbProvincia.DisplayMember = "descripcion"

                BodegaModificar.cmbProvincia.SelectedItem = unaBodega.Provincia.ProvinciaId

                BodegaModificar.cmbLocalidad.DataSource = LocalidadBLL.ListAll
                BodegaModificar.cmbLocalidad.ValueMember = "localidadId"
                BodegaModificar.cmbLocalidad.DisplayMember = "descripcion"

                BodegaModificar.cmbLocalidad.SelectedItem = unaBodega.Localidad.LocalidadId

                BodegaModificar.txtCuit.Text = unaBodega.Cuit
                BodegaModificar.txtRazonSocial.Text = unaBodega.RazonSocial
                BodegaModificar.txtTelefono.Text = unaBodega.Telefono
                If BodegaModificar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ObtenerBodegas()
                End If
            End If
            'ELIMINAR
            If e.ColumnIndex = 5 Then 'Nro Columna del datagriew
                If eliminado = True Then
                    eliminado = False
                    Descr = "Activar"
                    Nombre = "Se activo la Bodega: " & RazonSocialBodega
                Else
                    eliminado = True
                    Descr = "Eliminar"
                    Nombre = "Elimino Bodega: " & RazonSocialBodega
                End If
                result = MessageBox.Show(TraduccionBLL.TraducirTexto("¿Esta seguro que desea " & Descr & " la Bodega") & ": " & RazonSocialBodega & "?", TraduccionBLL.TraducirTexto(Descr & " Bodega"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    unaBodega.BodegaId = id
                    unaBodega.Eliminado = eliminado
                    BLL.Bodega.GetInstance.Delete(unaBodega)
                    RegistrarBitacora(Nombre, "Alta")
                End If
            End If
            ObtenerBodegas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RegistrarBitacora(evento As String, nivel As String)
        Dim SeguridadBLL As New BLL.Seguridad
        BitacoraBE.descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.usuario = MenuUI.GetUsuario
        BitacoraBE.criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub

End Class