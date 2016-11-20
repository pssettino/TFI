<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.btnCarpeta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblruta = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.nudValor = New System.Windows.Forms.NumericUpDown()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.GroupBox.SuspendLayout()
        CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCarpeta
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCarpeta, "frmBackup_1.htm#btnCarpeta")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCarpeta, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCarpeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCarpeta.Location = New System.Drawing.Point(373, 27)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.HelpProviderHG.SetShowHelp(Me.btnCarpeta, True)
        Me.btnCarpeta.Size = New System.Drawing.Size(29, 23)
        Me.btnCarpeta.TabIndex = 14
        Me.btnCarpeta.Text = "..."
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCancelar, "frmBackup_1.htm#btnCancelar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCancelar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelar.Location = New System.Drawing.Point(275, 116)
        Me.btnCancelar.Name = "btnCancelar"
        Me.HelpProviderHG.SetShowHelp(Me.btnCancelar, True)
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "&Cancelar"
        '
        'txtruta
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtruta, "frmBackup_1.htm#lblruta")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtruta, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtruta.Location = New System.Drawing.Point(79, 29)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.txtruta, True)
        Me.txtruta.Size = New System.Drawing.Size(288, 20)
        Me.txtruta.TabIndex = 8
        '
        'btnAceptar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAceptar, "frmBackup_1.htm#btnAceptar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAceptar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAceptar.Location = New System.Drawing.Point(142, 116)
        Me.btnAceptar.Name = "btnAceptar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAceptar, True)
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "&Aceptar"
        '
        'lblruta
        '
        Me.lblruta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblruta.Location = New System.Drawing.Point(18, 29)
        Me.lblruta.Name = "lblruta"
        Me.lblruta.Size = New System.Drawing.Size(45, 17)
        Me.lblruta.TabIndex = 11
        Me.lblruta.Text = "Ruta"
        Me.lblruta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCantidad
        '
        Me.lblCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCantidad.Location = New System.Drawing.Point(6, 75)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(68, 31)
        Me.lblCantidad.TabIndex = 12
        Me.lblCantidad.Text = "Cantidad de partes"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.nudValor)
        Me.GroupBox.Controls.Add(Me.btnCarpeta)
        Me.GroupBox.Controls.Add(Me.btnCancelar)
        Me.GroupBox.Controls.Add(Me.txtruta)
        Me.GroupBox.Controls.Add(Me.btnAceptar)
        Me.GroupBox.Controls.Add(Me.lblruta)
        Me.GroupBox.Controls.Add(Me.lblCantidad)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(432, 162)
        Me.GroupBox.TabIndex = 18
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Backup"
        '
        'nudValor
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.nudValor, "frmBackup_1.htm#nudValor")
        Me.HelpProviderHG.SetHelpNavigator(Me.nudValor, System.Windows.Forms.HelpNavigator.Topic)
        Me.nudValor.Location = New System.Drawing.Point(79, 75)
        Me.nudValor.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudValor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudValor.Name = "nudValor"
        Me.nudValor.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.nudValor, True)
        Me.nudValor.Size = New System.Drawing.Size(77, 20)
        Me.nudValor.TabIndex = 17
        Me.nudValor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(456, 185)
        Me.Controls.Add(Me.GroupBox)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmBackup_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.Name = "frmBackup"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Backup"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCarpeta As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblruta As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents nudValor As System.Windows.Forms.NumericUpDown
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
