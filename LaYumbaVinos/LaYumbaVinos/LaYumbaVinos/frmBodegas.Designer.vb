﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBodegas
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNuevaBodega = New System.Windows.Forms.Button()
        Me.dgBodegas = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBtnModificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgBtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNuevaBodega)
        Me.GroupBox2.Controls.Add(Me.dgBodegas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(794, 301)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bodegas"
        '
        'btnNuevaBodega
        '
        Me.btnNuevaBodega.Location = New System.Drawing.Point(9, 19)
        Me.btnNuevaBodega.Name = "btnNuevaBodega"
        Me.btnNuevaBodega.Size = New System.Drawing.Size(127, 27)
        Me.btnNuevaBodega.TabIndex = 99
        Me.btnNuevaBodega.Text = "&Nueva Bodega"
        Me.btnNuevaBodega.UseVisualStyleBackColor = True
        '
        'dgBodegas
        '
        Me.dgBodegas.AllowUserToAddRows = False
        Me.dgBodegas.AllowUserToDeleteRows = False
        Me.dgBodegas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBodegas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Laboratorio, Me.Cantidad, Me.dgBtnModificar, Me.dgBtnEliminar, Me.Eliminado})
        Me.dgBodegas.Location = New System.Drawing.Point(6, 57)
        Me.dgBodegas.Name = "dgBodegas"
        Me.dgBodegas.ReadOnly = True
        Me.dgBodegas.RowHeadersVisible = False
        Me.dgBodegas.Size = New System.Drawing.Size(783, 229)
        Me.dgBodegas.TabIndex = 9
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "CUIT"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Laboratorio
        '
        Me.Laboratorio.HeaderText = "Razon Social"
        Me.Laboratorio.Name = "Laboratorio"
        Me.Laboratorio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Telefono"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'dgBtnModificar
        '
        Me.dgBtnModificar.HeaderText = ""
        Me.dgBtnModificar.Name = "dgBtnModificar"
        Me.dgBtnModificar.ReadOnly = True
        Me.dgBtnModificar.Text = "Modificar"
        Me.dgBtnModificar.UseColumnTextForButtonValue = True
        '
        'dgBtnEliminar
        '
        Me.dgBtnEliminar.HeaderText = ""
        Me.dgBtnEliminar.Name = "dgBtnEliminar"
        Me.dgBtnEliminar.ReadOnly = True
        Me.dgBtnEliminar.Text = "Eliminar"
        Me.dgBtnEliminar.UseColumnTextForButtonValue = True
        '
        'Eliminado
        '
        Me.Eliminado.HeaderText = ""
        Me.Eliminado.Name = "Eliminado"
        Me.Eliminado.ReadOnly = True
        Me.Eliminado.Visible = False
        '
        'frmBodegas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 316)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmBodegas"
        Me.Text = "Bodegas"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevaBodega As System.Windows.Forms.Button
    Friend WithEvents dgBodegas As System.Windows.Forms.DataGridView
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Laboratorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBtnModificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgBtnEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class