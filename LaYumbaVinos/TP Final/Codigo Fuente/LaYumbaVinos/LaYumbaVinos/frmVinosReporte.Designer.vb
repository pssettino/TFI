<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVinosReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVinosReporte))
        Me.VinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaVinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.VinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaVinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VinoBindingSource
        '
        Me.VinoBindingSource.DataSource = GetType(BE.Vino)
        '
        'ReportViewer1
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.ReportViewer1, "frmVinosReporte_1.htm#ReportViewer")
        Me.HelpProviderHG.SetHelpNavigator(Me.ReportViewer1, System.Windows.Forms.HelpNavigator.Topic)
        ReportDataSource1.Name = "Vino"
        ReportDataSource1.Value = Me.VinoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LaYumbaVinos.frmVinosReporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.HelpProviderHG.SetShowHelp(Me.ReportViewer1, True)
        Me.ReportViewer1.Size = New System.Drawing.Size(850, 502)
        Me.ReportViewer1.TabIndex = 0
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataSource = GetType(BE.Venta)
        '
        'VentaVinoBindingSource
        '
        Me.VentaVinoBindingSource.DataSource = GetType(BE.VentaVino)
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmVinosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 503)
        Me.Controls.Add(Me.ReportViewer1)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmVinosReporte_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVinosReporte"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Reporte de Ventas"
        CType(Me.VinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaVinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaVinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
