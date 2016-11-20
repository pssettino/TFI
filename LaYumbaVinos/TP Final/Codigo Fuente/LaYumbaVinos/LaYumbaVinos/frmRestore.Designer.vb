<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestore
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.btnCarpeta = New System.Windows.Forms.Button()
        Me.lstArchivo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.btnCarpeta)
        Me.GroupBox.Controls.Add(Me.lstArchivo)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.txtRuta)
        Me.GroupBox.Controls.Add(Me.btnCancelar)
        Me.GroupBox.Controls.Add(Me.btnAceptar)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(497, 243)
        Me.GroupBox.TabIndex = 19
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Restaurar"
        '
        'btnCarpeta
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCarpeta, "frmRestore_1.htm#btnCarpeta")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCarpeta, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCarpeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCarpeta.Location = New System.Drawing.Point(450, 19)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.HelpProviderHG.SetShowHelp(Me.btnCarpeta, True)
        Me.btnCarpeta.Size = New System.Drawing.Size(33, 20)
        Me.btnCarpeta.TabIndex = 30
        Me.btnCarpeta.Text = "..."
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'lstArchivo
        '
        Me.lstArchivo.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.lstArchivo, "frmRestore_1.htm#lstArchivo")
        Me.HelpProviderHG.SetHelpNavigator(Me.lstArchivo, System.Windows.Forms.HelpNavigator.Topic)
        Me.lstArchivo.Location = New System.Drawing.Point(57, 54)
        Me.lstArchivo.Name = "lstArchivo"
        Me.HelpProviderHG.SetShowHelp(Me.lstArchivo, True)
        Me.lstArchivo.Size = New System.Drawing.Size(426, 134)
        Me.lstArchivo.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ruta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.txtRuta, "frmRestore_1.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtRuta, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtRuta.Location = New System.Drawing.Point(57, 19)
        Me.txtRuta.Name = "txtRuta"
        Me.HelpProviderHG.SetShowHelp(Me.txtRuta, True)
        Me.txtRuta.Size = New System.Drawing.Size(387, 20)
        Me.txtRuta.TabIndex = 23
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCancelar, "frmRestore_1.htm#btnCancelar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCancelar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelar.Location = New System.Drawing.Point(356, 198)
        Me.btnCancelar.Name = "btnCancelar"
        Me.HelpProviderHG.SetShowHelp(Me.btnCancelar, True)
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAceptar, "frmRestore_1.htm#btnAceptar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAceptar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAceptar.Location = New System.Drawing.Point(223, 198)
        Me.btnAceptar.Name = "btnAceptar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAceptar, True)
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(515, 263)
        Me.Controls.Add(Me.GroupBox)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmRestore_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.Name = "frmRestore"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restaurar"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnCarpeta As System.Windows.Forms.Button
    Friend WithEvents lstArchivo As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
