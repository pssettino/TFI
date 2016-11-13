Imports System.IO

Public Class frmRestore

    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Dim UsuarioBLL As New BLL.Usuario
    Dim BackupBLL As New BLL.Backup
    Dim SeguridadBLL As New BLL.Seguridad
    Dim BitacoraBE As New BE.Bitacora
    Dim TraduccionBLL As BLL.Traduccion

    Private Sub frmRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MenuUI = Me.MdiParent
            TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
            Dim PatenteBE As New BE.Patente
            PatenteBE.Nombre = "Restore"
            PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
            If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
                MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Application.Exit()
            End If
            TraduccionBLL.TraducirForm(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then
                Dim BackupBE As New BE.Backup
                BackupBE.Archivo = lstArchivo.SelectedItem.ToString
                BackupBLL.ImportarRar(BackupBE)
                MsgBox(TraduccionBLL.TraducirTexto("El restore fue hecho con exito"), MsgBoxStyle.DefaultButton1, TraduccionBLL.TraducirTexto("Restore"))
                RegistrarBitacora("Se hizo un restore del sistema", "Alta")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtRuta_TextChanged(sender As Object, e As EventArgs) Handles txtRuta.TextChanged
        Try
            If Directory.Exists(txtRuta.Text) Then
                Dim LfilesInDir As New List(Of String)
                For Each File In Directory.EnumerateFiles(txtRuta.Text)
                    Dim sinExt = File.Substring(0, File.Length - 4)
                    If sinExt.EndsWith(".dbk") Then LfilesInDir.Add(sinExt)
                Next
                LfilesInDir.Sort()
                lstArchivo.DataSource = Nothing
                lstArchivo.Items.Clear()
                lstArchivo.DataSource = LfilesInDir.Distinct().ToArray()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCarpeta_Click(sender As Object, e As EventArgs) Handles btnCarpeta.Click
        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txtRuta.Text = FolderBrowserDialog1.SelectedPath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function Validar() As Boolean
        Dim valido = True
        If txtRuta.Text = "" Then
            valido = False
            MsgBox("Campo requerido")
        End If
        Return valido
    End Function

    Public Sub RegistrarBitacora(evento As String, nivel As String)
        BitacoraBE.descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.usuario = MenuUI.GetUsuario
        BitacoraBE.criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub

End Class