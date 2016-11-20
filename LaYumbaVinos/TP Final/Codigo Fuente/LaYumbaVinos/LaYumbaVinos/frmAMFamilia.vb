﻿Public Class frmAMFamilia
    Dim BitacoraBE As New BE.Bitacora
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim unaFamilia As New BE.Familia
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Private _id As String


    Public Sub New(Optional idParameter As Integer = 0)
        InitializeComponent()
        _id = idParameter
    End Sub

    Private Function Validar() As Boolean
        For Each FamiliaBE In BLL.Familia.GetInstance().ListAll
            If (SeguridadBLL.DesencriptarRSA(FamiliaBE.nombre) = txtnombre.Text And _id = 0) Then
                MsgBox(TraduccionBLL.TraducirTexto("El nombre ingresado ya esta en uso, por favor ingrese otro nombre"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Return False
            End If
        Next
        Dim valido = True
        lblNombreError.Visible = False
        If txtNombre.Text = "" Then
            valido = False
            lblNombreError.Visible = True
            lblNombreError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        lblDescripcionError.Visible = False
        If txtDescripcion.Text = "" Then
            valido = False
            lblDescripcionError.Visible = True
            lblDescripcionError.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        Return valido
    End Function


    Private Sub frmAMFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MenuUI = Me.Owner
            TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
            Dim PatenteBE As New BE.Patente
            PatenteBE.Nombre = "Familia"
            PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
            If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
                MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Application.Exit()
            End If
            TraduccionBLL.TraducirForm(Me)
            ObtenerPatentes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub ObtenerPatentes()
        dgPatentes.Rows.Clear()
        For Each PatenteBE In BLL.Patente.GetInstance().ListAll
            Dim n As Integer = dgPatentes.Rows.Add()
            dgPatentes.Rows.Item(n).Cells("patente_id").Value = PatenteBE.PatenteId
            dgPatentes.Rows.Item(n).Cells("Nombre").Value = PatenteBE.Nombre
            dgPatentes.Rows.Item(n).Cells("dgAsignarPatente").Value = False
        Next
        If _id > 0 Then
            unaFamilia.familiaId = _id
            Dim FamiliaBE = BLL.Familia.GetInstance().ListById(unaFamilia)
            txtnombre.Text = SeguridadBLL.DesencriptarRSA(FamiliaBE.nombre)
            txtdescripcion.Text = FamiliaBE.descripcion
            For Each PatenteBE In FamiliaBE.patentes
                For i = 0 To dgPatentes.Rows.Count - 1
                    If dgPatentes.Rows.Item(i).Cells("patente_id").Value = PatenteBE.PatenteId Then
                        dgPatentes.Rows.Item(i).Cells("dgAsignarPatente").Value = True
                    End If
                Next
            Next
        End If
    End Sub

    Public Sub CargarObjetos()
        Dim nombre As String = Trim(txtnombre.Text)

        unaFamilia.nombre = SeguridadBLL.EncriptarRSA(nombre)
        unaFamilia.descripcion = Trim(txtdescripcion.Text)
        unaFamilia.patentes = New List(Of BE.Patente)
        For i = 0 To dgPatentes.Rows.Count - 1
            If dgPatentes.Rows.Item(i).Cells("dgAsignarPatente").Value = True Then
                Dim PatenteBE As New BE.Patente
                PatenteBE.PatenteId = dgPatentes.Rows.Item(i).Cells("patente_id").Value
                PatenteBE.Nombre = dgPatentes.Rows.Item(i).Cells("Nombre").Value
                unaFamilia.patentes.Add(PatenteBE)
            End If
        Next
    End Sub

    Private Sub RegistrarFamilia(Optional ByVal var As Boolean = True)
        Dim nombre As String = Trim(txtnombre.Text)
        CargarObjetos()
        If _id = 0 Then
            BLL.Familia.GetInstance.Add(unaFamilia)
            MessageBox.Show(TraduccionBLL.TraducirTexto("Se Registro el Familia") & ": " & nombre, TraduccionBLL.TraducirTexto("Registrar Familia"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            RegistrarBitacora("Registro Familia: " & nombre, "Alta")
        Else
            BLL.Familia.GetInstance.Update(unaFamilia)
            MessageBox.Show(TraduccionBLL.TraducirTexto("Se Modifico el Familia") & ": " & nombre, TraduccionBLL.TraducirTexto("Modificar Familia"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            RegistrarBitacora("Modifico Familia: " & nombre, "Alta")
        End If
        If var Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then
                RegistrarFamilia(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgPatentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPatentes.CellContentClick
        Try
            If _id > 0 Then
                If (e.RowIndex >= 0 And e.ColumnIndex = 1) Then
                    dgPatentes.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    If (dgPatentes.Rows(e.RowIndex).Cells("dgAsignarPatente").Value = False And
                        BLL.Familia.GetInstance.ValidarEliminarFamiliaPatente(BLL.Familia.GetInstance.ListById(unaFamilia), New BE.Patente With {.PatenteId = dgPatentes.Rows(e.RowIndex).Cells("patente_id").Value}) = False) Then
                        MsgBox(TraduccionBLL.TraducirTexto("No se puede quitar la patente a la familia porque quedarian patentes esenciales sin asignar"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                        ObtenerPatentes()
                    Else
                        RegistrarFamilia(False)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RegistrarBitacora(evento As String, nivel As String)
        Dim SeguridadBLL As New BLL.Seguridad
        BitacoraBE.Descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.usuario = MenuUI.GetUsuario
        BitacoraBE.criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub

End Class