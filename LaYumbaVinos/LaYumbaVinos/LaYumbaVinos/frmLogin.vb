Imports System.IO

Public Class frmLogin
    Dim UsuarioBLL As New BLL.Usuario
    Dim SeguridadBLL As New BLL.Seguridad
    Dim IdiomaBLL As New BLL.Idioma
    Dim DVH_BLL As New BLL.DVH
    Dim BitacoraBE As New BE.Bitacora
    Dim UsuarioBE As New BE.Usuario
    Dim IdiomaBE As New BE.Idioma
    Dim TraduccionBLL As BLL.Traduccion

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            LogIn()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub LogIn()
        If Validar() Then
            UsuarioBE.NombreUsuario = SeguridadBLL.EncriptarRSA(Trim(txtUsuario.Text))
            UsuarioBE = BLL.Usuario.GetInstance.ValidarContraseña(UsuarioBE)
            If UsuarioBE.UsuarioId = 0 Then
                RegistrarBitacora("Ingreso Incorrecto: " & txtUsuario.Text, "Media")
                txtContraseña.Text = ""
                MsgBox(TraduccionBLL.TraducirTexto("Ingreso incorrecto a la apliacion, por favor intentelo de nuevo!"), MsgBoxStyle.Critical, "Error")
            Else
                If UsuarioBE.Eliminado = True Then
                    MsgBox(TraduccionBLL.TraducirTexto("El usuario se encuentra eliminado. Contacte al Administrador."), MsgBoxStyle.Critical, "Error")
                    txtUsuario.Text = ""
                    txtContraseña.Text = ""
                    txtUsuario.Focus()
                Else
                    If UsuarioBE.Bloqueado = True Then
                        MsgBox(TraduccionBLL.TraducirTexto("El usuario se encuentra bloqueado. Contacte al Administrador."), MsgBoxStyle.Critical, "Error")
                        txtUsuario.Text = ""
                        txtContraseña.Text = ""
                        txtUsuario.Focus()
                    Else
                        If UsuarioBE.Contraseña = SeguridadBLL.EncriptarMD5(Trim(txtContraseña.Text)) Then
                            If UsuarioBE.Eliminado = False Then
                                If (DVH_BLL.VerificarDVH(UsuarioBE) = False) Then
                                    Dim PatenteBE As New BE.Patente
                                    PatenteBE.Nombre = "RecalcularDV"
                                    PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
                                    If UsuarioBLL.VerificarPatente(UsuarioBE, PatenteBE) Then
                                        If MsgBox(TraduccionBLL.TraducirTexto("Error al verificar la integridad de la Base de Datos. ¿Desea Recalcular los Digitos Verificadores? "), MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                                            DVH_BLL.RecalcularDVH()
                                        Else
                                            Application.Exit()
                                        End If
                                    Else
                                        MsgBox(TraduccionBLL.TraducirTexto("Error al verificar la integridad de la Base de Datos. Por favor a contacte al Administrador del sistema."), MsgBoxStyle.Critical, "Error")
                                        Application.Exit()
                                    End If
                                End If
                                UsuarioBE.Cci = 0
                                BLL.Usuario.GetInstance.Update(UsuarioBE)
                                RegistrarBitacora("LogIn", "Baja")
                                txtUsuario.Text = ""
                                txtContraseña.Text = ""
                                IdiomaBE.IdiomaId = cmbIdioma.SelectedValue
                                Dim MenuUI As New frmMenuPrincipal(UsuarioBE, IdiomaBE)
                                MenuUI.Show()
                                Me.Hide()
                            End If
                        Else
                            UsuarioBE.Cci = UsuarioBE.Cci + 1
                            BLL.Usuario.GetInstance.Update(UsuarioBE)
                            If UsuarioBE.Cci >= 3 Then
                                If UsuarioBLL.ValidarEliminarUsuario(UsuarioBE) Then
                                    UsuarioBE.Bloqueado = True
                                    BLL.Usuario.GetInstance.BloquearDesbloquearUsuario(UsuarioBE)
                                    MsgBox(TraduccionBLL.TraducirTexto("Contraseña incorrecta. El usuario ha sido bloqueado!"), MsgBoxStyle.Critical, "Error")
                                    RegistrarBitacora("Se bloqueo el usuario:" & txtUsuario.Text, "Alta")
                                Else
                                    UsuarioBE.Contraseña = SeguridadBLL.EncriptarMD5(Trim(SeguridadBLL.AutoGenerarContraseña(UsuarioBE, True)))
                                    UsuarioBE.Cci = 0
                                    BLL.Usuario.GetInstance.Update(UsuarioBE)
                                    RegistrarBitacora("Modifico Usuario (restablecio la contraseña): " & txtUsuario.Text, "Alta")
                                    MsgBox(TraduccionBLL.TraducirTexto("Contraseña incorrecta, Como el usuario contiene patentes esenciales se restableció la contraseña!"), MsgBoxStyle.Critical, "Error")
                                    RegistrarBitacora("Ingreso incorrecto contraseña:" & txtUsuario.Text, "Media")
                                End If
                            Else
                                MsgBox(TraduccionBLL.TraducirTexto("Contraseña incorrecta"), MsgBoxStyle.Critical, "Error")
                                RegistrarBitacora("Ingreso incorrecto contraseña:" & txtUsuario.Text, "Media")
                                txtContraseña.Text = ""
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim valido = True
        If txtUsuario.Text = "" Then
            valido = False
            MsgBox(TraduccionBLL.TraducirTexto("Ingrese el Nombre de Usuario"))
        End If
        If txtContraseña.Text = "" Then
            valido = False
            MsgBox(TraduccionBLL.TraducirTexto("Ingrese la Contraseña"))
        End If
        Return valido
    End Function

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim returnValue As Boolean = False

        Try
            If (File.Exists("AccederServidorSQL.txt") = True) Then
                If (SeguridadBLL.ValidarServidor(File.ReadAllText("AccederServidorSQL.txt")) = False) Then
                    returnValue = True
                End If
            Else
                returnValue = True
            End If
            If returnValue Then
                If frmServidor.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    Application.Exit()
                End If
            End If

            ObtenerIdioma()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RegistrarBitacora(evento As String, nivel As String)
        Dim SeguridadBLL As New BLL.Seguridad
        BitacoraBE.Descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.Usuario = UsuarioBE
        BitacoraBE.Criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub

    Public Sub ObtenerIdioma()
        Dim IdiomaBLL As New BLL.Idioma
        cmbIdioma.Items.Clear()
        Dim Idioma = IdiomaBLL.ObtenerIdiomas()
        cmbIdioma.DataSource = Idioma
        cmbIdioma.DisplayMember = "Nombre"
        cmbIdioma.ValueMember = "IdiomaId"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub
End Class