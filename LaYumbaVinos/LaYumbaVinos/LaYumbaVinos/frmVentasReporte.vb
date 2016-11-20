Imports Microsoft.Reporting.WinForms

Public Class frmVentasReporte
    Dim SeguridadBLL As New BLL.Seguridad

    Public VentasVinoBE As New List(Of BE.VentaVino)
    Public VentasBE As New List(Of BE.Venta)

    Public Titulo As String

    Public TotalImporte As Double
    Public Sub New(ByVal VentasBEParam As List(Of BE.Venta), ByVal TituloParam As String)
        InitializeComponent()
        VentasBE = VentasBEParam
        For Each VentaBE In VentasBE
            VentaBE.Cliente.NombreCompleto = VentaBE.Cliente.Apellido + ", " + VentaBE.Cliente.Nombre
            VentaBE.ClienteRpt = VentaBE.Cliente.NombreCompleto
            For Each itemVino In VentaBE.Vinos
                itemVino.VentaId = itemVino.Venta.VentaId
                itemVino.CantidadVenta = SeguridadBLL.DesencriptarRSA(itemVino.CantidadVenta)
                itemVino.PrecioVenta = SeguridadBLL.DesencriptarRSA(itemVino.PrecioVenta)
                
                itemVino.Vino = BLL.Vino.GetInstance.ListById(itemVino.Vino)
                itemVino.VinoRpt = itemVino.Vino.Descripcion
                TotalImporte = TotalImporte + (itemVino.CantidadVenta * itemVino.PrecioVenta)
                VentasVinoBE.Add(itemVino)
            Next
            VentaBE.TotalImporte = TotalImporte
            TotalImporte = 0
        Next
        Titulo = TituloParam
    End Sub
    Private Sub frmVentasReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim parameters As ReportParameter() = New ReportParameter(0) {}
        parameters(0) = New ReportParameter("titulo", Titulo)
        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Venta", VentasBE))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("VentaVino", VentasVinoBE))
        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class