﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblApellidoNombre = New System.Windows.Forms.Label()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.txtBuscarApeNom = New System.Windows.Forms.TextBox()
        Me.txtBuscarDni = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgModificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblApellidoNombre)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.txtBuscarApeNom)
        Me.GroupBox1.Controls.Add(Me.txtBuscarDni)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'lblApellidoNombre
        '
        Me.lblApellidoNombre.AutoSize = True
        Me.lblApellidoNombre.Location = New System.Drawing.Point(380, 27)
        Me.lblApellidoNombre.Name = "lblApellidoNombre"
        Me.lblApellidoNombre.Size = New System.Drawing.Size(92, 13)
        Me.lblApellidoNombre.TabIndex = 99
        Me.lblApellidoNombre.Text = "Apellido y Nombre"
        Me.lblApellidoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Location = New System.Drawing.Point(14, 27)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(26, 13)
        Me.lbldni.TabIndex = 100
        Me.lbldni.Text = "DNI"
        Me.lbldni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBuscarApeNom
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtBuscarApeNom, "frmClientes_1.htm#lblApellidoNombre")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtBuscarApeNom, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtBuscarApeNom.Location = New System.Drawing.Point(514, 24)
        Me.txtBuscarApeNom.MaxLength = 255
        Me.txtBuscarApeNom.Name = "txtBuscarApeNom"
        Me.HelpProviderHG.SetShowHelp(Me.txtBuscarApeNom, True)
        Me.txtBuscarApeNom.Size = New System.Drawing.Size(267, 20)
        Me.txtBuscarApeNom.TabIndex = 98
        '
        'txtBuscarDni
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtBuscarDni, "frmClientes_1.htm#lbldni")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtBuscarDni, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtBuscarDni.Location = New System.Drawing.Point(46, 24)
        Me.txtBuscarDni.MaxLength = 8
        Me.txtBuscarDni.Name = "txtBuscarDni"
        Me.HelpProviderHG.SetShowHelp(Me.txtBuscarDni, True)
        Me.txtBuscarDni.Size = New System.Drawing.Size(306, 20)
        Me.txtBuscarDni.TabIndex = 97
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNuevoCliente)
        Me.GroupBox2.Controls.Add(Me.dgClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(789, 326)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes"
        '
        'btnNuevoCliente
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnNuevoCliente, "frmClientes_1.htm#btnNuevoCliente")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnNuevoCliente, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnNuevoCliente.Location = New System.Drawing.Point(7, 28)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.HelpProviderHG.SetShowHelp(Me.btnNuevoCliente, True)
        Me.btnNuevoCliente.Size = New System.Drawing.Size(127, 27)
        Me.btnNuevoCliente.TabIndex = 102
        Me.btnNuevoCliente.Text = "&Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.DNI, Me.nombreCompleto, Me.Telefono, Me.Email, Me.dgModificar, Me.dgEliminar, Me.eliminado})
        Me.HelpProviderHG.SetHelpKeyword(Me.dgClientes, "frmClientes_1.htm#dgClientes")
        Me.HelpProviderHG.SetHelpNavigator(Me.dgClientes, System.Windows.Forms.HelpNavigator.Topic)
        Me.dgClientes.Location = New System.Drawing.Point(6, 61)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.RowHeadersVisible = False
        Me.HelpProviderHG.SetShowHelp(Me.dgClientes, True)
        Me.dgClientes.Size = New System.Drawing.Size(774, 247)
        Me.dgClientes.TabIndex = 101
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'nombreCompleto
        '
        Me.nombreCompleto.HeaderText = "Apellido y Nombre"
        Me.nombreCompleto.Name = "nombreCompleto"
        Me.nombreCompleto.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'dgModificar
        '
        Me.dgModificar.HeaderText = ""
        Me.dgModificar.Name = "dgModificar"
        Me.dgModificar.ReadOnly = True
        Me.dgModificar.Text = "Modificar"
        Me.dgModificar.ToolTipText = "Modificar"
        Me.dgModificar.UseColumnTextForButtonValue = True
        '
        'dgEliminar
        '
        Me.dgEliminar.HeaderText = ""
        Me.dgEliminar.Name = "dgEliminar"
        Me.dgEliminar.ReadOnly = True
        Me.dgEliminar.Text = "Eliminar"
        Me.dgEliminar.ToolTipText = "Eliminar"
        Me.dgEliminar.UseColumnTextForButtonValue = True
        '
        'eliminado
        '
        Me.eliminado.HeaderText = ""
        Me.eliminado.Name = "eliminado"
        Me.eliminado.ReadOnly = True
        Me.eliminado.Visible = False
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(813, 441)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmClientes_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents lblApellidoNombre As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents txtBuscarApeNom As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarDni As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgModificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
