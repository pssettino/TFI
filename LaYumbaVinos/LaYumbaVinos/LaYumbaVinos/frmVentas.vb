Public Class frmVentas
    Dim BitacoraBE As New BE.Bitacora
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        Dim _frmAMVenta As New frmAMVenta
        If _frmAMVenta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ListarVentas()
        End If
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuUI = Me.MdiParent
        TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
        Dim PatenteBE As New BE.Patente
        PatenteBE.Nombre = "Venta"
        PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
        If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
            MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
            Application.Exit()
        End If
        TraduccionBLL.TraducirForm(Me)

        cmbCliente.DisplayMember = "nombreCompleto"
        cmbCliente.ValueMember = "clienteId"
        cmbCliente.DataSource = BLL.Cliente.GetInstance.ListAll()
        ListarVentas()
    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
        ListarVentas()
    End Sub


    Public Function ListarVentas()
        Dim TotalImporte As Double
        dgVentas.Rows.Clear()
        Dim fechaDesde = New DateTime(dtpFechaDesde.Value.Year, dtpFechaDesde.Value.Month, dtpFechaDesde.Value.Day, 0, 0, 0)
        Dim fechaHasta = New DateTime(dtpFechaHasta.Value.Year, dtpFechaHasta.Value.Month, dtpFechaHasta.Value.Day, 23, 59, 59)
        Dim VentasBE As New BE.Venta
        Dim Ventas As New List(Of BE.Venta)

        Ventas = BLL.Venta.GetInstance.ListarVentasPorParametros(fechaDesde, fechaHasta, cmbCliente.SelectedValue)

        For Each item In Ventas
            Dim n As Integer = dgVentas.Rows.Add()
            dgVentas.Rows.Item(n).Cells("dgBtnModificarVenta").Value = TraduccionBLL.TraducirTexto("Ver Detalle")
            dgVentas.Rows.Item(n).Cells("NroVenta").Value = item.ventaId
            dgVentas.Rows.Item(n).Cells("Cliente").Value = item.cliente.NombreCompleto
            dgVentas.Rows.Item(n).Cells("Fecha_Venta").Value = item.fechaVenta
            For Each vino In item.Vinos
                TotalImporte = TotalImporte + (SeguridadBLL.DesencriptarRSA(vino.CantidadVenta) * SeguridadBLL.DesencriptarRSA(vino.PrecioVenta))
            Next
            dgVentas.Rows.Item(n).Cells("Total").Value = TotalImporte
            TotalImporte = 0
        Next
        Return Ventas
    End Function


    Private Sub btnLimpiarVenta_Click(sender As Object, e As EventArgs) Handles btnLimpiarVenta.Click
        dgVentas.Rows.Clear()
    End Sub
End Class