Imports Microsoft.Reporting.WinForms

Public Class frmBitacoraReporte
    Dim SeguridadBLL As New BLL.Seguridad

    Public BitacorasBE As New List(Of BE.Bitacora)
    Public Titulo As String

    Private Sub frmBitacoraReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim parameters As ReportParameter() = New ReportParameter(0) {}
        parameters(0) = New ReportParameter("titulo", Titulo)
        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("BE", BitacorasBE))
        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub


    Public Sub New(ByVal BitacoraBEParam As List(Of BE.Bitacora), ByVal TituloParam As String)
        InitializeComponent()
        BitacorasBE = BitacoraBEParam
        For Each BitacoraBE In BitacorasBE
            BitacoraBE.Descripcion = SeguridadBLL.DesencriptarRSA(BitacoraBE.Descripcion)
            BitacoraBE.NombreUsuario = SeguridadBLL.DesencriptarRSA(BitacoraBE.Usuario.NombreUsuario)
        Next
        Titulo = TituloParam
    End Sub

   
End Class