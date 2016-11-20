<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacoraReporte
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
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BitacoraBindingSource
        '
        Me.BitacoraBindingSource.DataSource = GetType(BE.Bitacora)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.ReportViewer1, "frmBitacoraReporte_1.htm#ReportViewer")
        Me.HelpProviderHG.SetHelpNavigator(Me.ReportViewer1, System.Windows.Forms.HelpNavigator.Topic)
        ReportDataSource1.Name = "BE"
        ReportDataSource1.Value = Me.BitacoraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LaYumbaVinos.frmBitacoraReporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.HelpProviderHG.SetShowHelp(Me.ReportViewer1, True)
        Me.ReportViewer1.Size = New System.Drawing.Size(874, 492)
        Me.ReportViewer1.TabIndex = 0
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmBitacoraReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 492)
        Me.Controls.Add(Me.ReportViewer1)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmBitacoraReporte_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "frmBitacoraReporte"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "frmBitacoraReporte"
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
