﻿Imports Microsoft.Reporting.WinForms

Public Class frmVinosReporte
   Dim SeguridadBLL As New BLL.Seguridad

    Public VinosBE As New List(Of BE.Vino)
    Public Titulo As String

    Public Sub New(ByVal VinosBEParam As List(Of BE.Vino), ByVal TituloParam As String)
        InitializeComponent()
        VinosBE = VinosBEParam
        For Each VinoBE In VinosBE
            VinoBE.Cantidad = SeguridadBLL.DesencriptarRSA(VinoBE.Cantidad)
            VinoBE.Precio = SeguridadBLL.DesencriptarRSA(VinoBE.Precio)
            VinoBE.NombreBodega = VinoBE.Bodega.RazonSocial
        Next
        Titulo = TituloParam
    End Sub
    Private Sub frmVinosReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim parameters As ReportParameter() = New ReportParameter(0) {}
        parameters(0) = New ReportParameter("titulo", Titulo)
        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Vino", VinosBE))
        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class