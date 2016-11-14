Public Class frmVinosReporteFiltro
    Dim BitacoraBE As New BE.Bitacora
    Dim VinoBE As New BE.Vino
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim BodegaBLL As New BLL.Bodega

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarVinos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VinosReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
            ObtenerBodegas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Try
            dgVinos.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim vinosReporte As New LaYumbaVinos.frmVinosReporte(ListarVinos(), "Reporte de Vinos ")
            vinosReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ListarVinos() As List(Of BE.Vino)
        dgVinos.Rows.Clear()
        Dim BodegaBE As New BE.Bodega
        BodegaBE.BodegaId = cmbBodega.SelectedValue
        Dim vinos As New List(Of BE.Vino)

        vinos = BLL.Vino.GetInstance.ObtenerVinoPorParametros(Trim(txtDescripcion.Text), BodegaBE)
        For Each vino In vinos
            Dim n As Integer = dgVinos.Rows.Add()
            dgVinos.Rows.Item(n).Cells("id").Value = vino.VinoId
            dgVinos.Rows.Item(n).Cells("descripcion").Value = vino.Descripcion
            dgVinos.Rows.Item(n).Cells("bodega").Value = vino.Bodega.RazonSocial
            dgVinos.Rows.Item(n).Cells("cantidad").Value = SeguridadBLL.DesencriptarRSA(vino.Cantidad)
            dgVinos.Rows.Item(n).Cells("precio").Value = SeguridadBLL.DesencriptarRSA(vino.Precio)
            dgVinos.Rows.Item(n).Cells("eliminado").Value = IIf(vino.Eliminado, "SI", "NO")
        Next
        Return vinos
    End Function

    Public Sub ObtenerBodegas()
        Dim myList As New Dictionary(Of Integer, String)
        myList.Add(0, TraduccionBLL.TraducirTexto("Todos las bodegas"))
        For Each bodegaBE In BodegaBLL.ListAll
            myList.Add(bodegaBE.BodegaId, bodegaBE.RazonSocial)
        Next
        cmbBodega.DisplayMember = "Value"
        cmbBodega.ValueMember = "Key"
        cmbBodega.DataSource = New BindingSource(myList, Nothing)
    End Sub
End Class