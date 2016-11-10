Public Class frmAMVenta
    Dim venta As New BE.Venta
    Dim BitacoraBE As New BE.Bitacora
    Dim TraduccionBLL As BLL.Traduccion
    Dim SeguridadBLL As New BLL.Seguridad
    Dim MenuUI As LaYumbaVinos.frmMenuPrincipal
    Private _id As String

    Public vinos As New List(Of BE.VentaVino)

    Public Sub New(Optional idParameter As Integer = 0)
        InitializeComponent()
        _id = idParameter
        venta.ventaId = _id
    End Sub


    Private Sub frmAMVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MenuUI = Me.Owner
            TraduccionBLL = New BLL.Traduccion(MenuUI.GetIdioma)
            Dim PatenteBE As New BE.Patente
            PatenteBE.Nombre = "Venta"
            PatenteBE.PatenteId = BLL.Usuario.GetInstance.ObtenerPantenteID(PatenteBE.Nombre)
            If (BLL.Usuario.GetInstance.VerificarPatente(MenuUI.GetUsuario, PatenteBE) = False) Then
                MsgBox(TraduccionBLL.TraducirTexto("Sus permisos han sido modificados, por favor inicie sesion nuevamente"), MsgBoxStyle.Critical, TraduccionBLL.TraducirTexto("Error"))
                Application.Exit()
            End If
            TraduccionBLL.TraducirForm(Me)
            MostrarDatos()
            If _id > 0 Then
                ObtenerVinosPorVenta()
            Else
                txtFechaHora.Text = DateTime.Now
                txtNroVenta.Text = BLL.Venta.GetInstance.ObtenerMaxId() + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Public Sub MostrarDatos()
        Dim SeguridadBLL As New BLL.Seguridad
        If _id = 0 Then
            Dim clientesLista As New Dictionary(Of Integer, String)
            clientesLista.Add(0, TraduccionBLL.TraducirTexto("Seleccione el cliente"))
            For Each ClienteBE In BLL.Cliente.GetInstance.ObtenerClientesDisponibles()
                clientesLista.Add(ClienteBE.ClienteId, ClienteBE.Apellido + ", " + ClienteBE.Nombre)
            Next
            cmbCliente.DisplayMember = "Value"
            cmbCliente.ValueMember = "Key"
            cmbCliente.DataSource = New BindingSource(clientesLista, Nothing)
        End If

        Dim vinoLista As New Dictionary(Of Integer, String)
        vinoLista.Add(0, TraduccionBLL.TraducirTexto("Seleccione el vino"))
        For Each VinoBE In BLL.Vino.GetInstance.ObtenerVinosDisponibles(SeguridadBLL.EncriptarRSA("0"))
            vinoLista.Add(VinoBE.VinoId, VinoBE.Descripcion)
        Next
        cmbVino.DisplayMember = "Value"
        cmbVino.ValueMember = "Key"
        cmbVino.DataSource = New BindingSource(vinoLista, Nothing)
    End Sub

    Public Sub ObtenerVinosPorVenta(Optional ByVal vinoList As List(Of BE.VentaVino) = Nothing)
        MostrarDatos()
        txtImporteTotal.Text = 0
        venta.VentaId = _id

        If (vinoList Is Nothing) Then
            Dim ventaBE = BLL.Venta.GetInstance().ListarVentaById(venta)
            If Not ventaBE Is Nothing Then
                For Each item In ventaBE.Vinos
                    Dim ventaVino As New BE.VentaVino
                    Dim n As Integer = dgVinosPorVenta.Rows.Add()
                    dgVinosPorVenta.Rows.Item(n).Cells("gvBtnEliminarVino").Value = TraduccionBLL.TraducirTexto("Quitar Vino")
                    dgVinosPorVenta.Rows.Item(n).Cells("venta_vino_id").Value = item.VentaVinoId
                    dgVinosPorVenta.Rows.Item(n).Cells("NroVino").Value = item.Vino.VinoId
                    dgVinosPorVenta.Rows.Item(n).Cells("Vino").Value = item.Vino.Descripcion
                    dgVinosPorVenta.Rows.Item(n).Cells("CantVenta").Value = SeguridadBLL.DesencriptarRSA(item.CantidadVenta)
                    dgVinosPorVenta.Rows.Item(n).Cells("PrecioVenta").Value = SeguridadBLL.DesencriptarRSA(item.PrecioVenta)
                    txtImporteTotal.Text = CDbl(txtImporteTotal.Text) + (CInt(SeguridadBLL.DesencriptarRSA(item.CantidadVenta)) * CDbl(SeguridadBLL.DesencriptarRSA(item.PrecioVenta)))
                Next
            End If
        Else
            dgVinosPorVenta.Rows.Clear()
            For Each ventaVino In vinoList

                Dim n As Integer = dgVinosPorVenta.Rows.Add()
                dgVinosPorVenta.Rows.Item(n).Cells("gvBtnEliminarVino").Value = TraduccionBLL.TraducirTexto("Quitar Vino")
                dgVinosPorVenta.Rows.Item(n).Cells("venta_vino_id").Value = ventaVino.VentaVinoId
                dgVinosPorVenta.Rows.Item(n).Cells("NroVino").Value = ventaVino.Vino.VinoId
                dgVinosPorVenta.Rows.Item(n).Cells("Vino").Value = ventaVino.Vino.Descripcion
                dgVinosPorVenta.Rows.Item(n).Cells("CantVenta").Value = SeguridadBLL.DesencriptarRSA(ventaVino.CantidadVenta)
                dgVinosPorVenta.Rows.Item(n).Cells("PrecioVenta").Value = SeguridadBLL.DesencriptarRSA(ventaVino.PrecioVenta)
                txtImporteTotal.Text = CDbl(txtImporteTotal.Text) + (CInt(SeguridadBLL.DesencriptarRSA(ventaVino.CantidadVenta)) * CDbl(SeguridadBLL.DesencriptarRSA(ventaVino.PrecioVenta)))
            Next
        End If

    End Sub

    Dim index As Integer
    Public Sub AgregarVinosPorVenta()
        ' dgVinosPorVenta.Rows.Clear()
        Dim vino As New BE.Vino

        vino.VinoId = cmbVino.SelectedValue
        vino.Descripcion = DirectCast(cmbVino.SelectedItem, System.Collections.Generic.KeyValuePair(Of Integer, String)).Value

        Dim ventaVino As New BE.VentaVino
        ventaVino.VentaVinoId = BLL.Venta.GetInstance.ObtenerMaxIdVenta_Vino
        ventaVino.Vino = vino
        ventaVino.PrecioVenta = SeguridadBLL.EncriptarRSA(txtPrecio.Text)
        ventaVino.CantidadVenta = SeguridadBLL.EncriptarRSA(txtCantidad.Text)
        ventaVino.Venta = venta
        vinos.Add(ventaVino)

        If (txtImporteTotal.Text = "") Then
            txtImporteTotal.Text = 0
        End If
        If (CInt(txtDisponible.Text) > 0 And CInt(txtDisponible.Text) >= CInt(txtCantidad.Text)) Then
            index = dgVinosPorVenta.Rows.Add()
            dgVinosPorVenta.Rows.Item(index).Cells("gvBtnEliminarVino").Value = TraduccionBLL.TraducirTexto("Quitar Vino")
            dgVinosPorVenta.Rows.Item(index).Cells("venta_vino_id").Value = 0
            dgVinosPorVenta.Rows.Item(index).Cells("NroVino").Value = ventaVino.Vino.VinoId
            dgVinosPorVenta.Rows.Item(index).Cells("Vino").Value = ventaVino.Vino.Descripcion
            dgVinosPorVenta.Rows.Item(index).Cells("CantVenta").Value = txtCantidad.Text
            dgVinosPorVenta.Rows.Item(index).Cells("PrecioVenta").Value = txtPrecio.Text
            txtImporteTotal.Text = CDbl(txtImporteTotal.Text) + (CInt(txtCantidad.Text) * CDbl(txtPrecio.Text))
            txtDisponible.Text = CInt(txtDisponible.Text) - CInt(txtCantidad.Text)
        End If
    End Sub

    Private Sub RegistrarVenta(Optional ByVal var As Boolean = True, Optional ByVal eliminar As Boolean = False)
        Dim clienteBE As New BE.Cliente
        clienteBE.clienteId = cmbCliente.SelectedValue
        clienteBE.NombreCompleto = DirectCast(cmbCliente.SelectedItem, System.Collections.Generic.KeyValuePair(Of Integer, String)).Value

        venta.cliente = clienteBE
        venta.fechaVenta = txtFechaHora.Text
        venta.activo = True
        venta.Vinos = vinos

        If _id = 0 Then
            BLL.Venta.GetInstance.RegistrarVenta(venta)
            ActualizarStock(True)
            MessageBox.Show(TraduccionBLL.TraducirTexto("Se generó una nueva venta") & ": " & txtNroVenta.Text, TraduccionBLL.TraducirTexto("Registra Venta"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            RegistrarBitacora("Registrar Venta: " & txtNroVenta.Text, "Baja")
            _id = BLL.Venta.GetInstance.ObtenerMaxId
        Else
            venta.ventaId = _id
            BLL.Venta.GetInstance.ModificarVenta(venta)
            If var = False Then
                If eliminar = False Then
                    ActualizarStock(True)
                Else
                    ActualizarStock(False)
                End If
            End If
            MessageBox.Show(TraduccionBLL.TraducirTexto("Se Modifico la venta") & ": " & txtNroVenta.Text, TraduccionBLL.TraducirTexto("Modificar Venta"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            RegistrarBitacora("Modificar Venta: " & txtNroVenta.Text, "Baja")
        End If
        txtPrecioLista.Text = ""
        txtDisponible.Text = ""
        txtDisponible.Text = SeguridadBLL.DesencriptarRSA(ObtenerVino.Cantidad)
        txtPrecioLista.Text = SeguridadBLL.DesencriptarRSA(ObtenerVino.Precio)

        If var Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Public Sub ActualizarStock(operador As Boolean)
        Dim VinoStock As New BE.Vino
        Dim cantidadStock As Integer
        If operador Then
            Dim cant = ObtenerVino.Cantidad
            If (Not cant = Nothing) Then
                cantidadStock = SeguridadBLL.DesencriptarRSA(cant) - CInt(txtCantidad.Text)
                VinoStock.VinoId = cmbVino.SelectedValue
            End If
        Else
            Dim CantidadVenta As Integer = dgVinosPorVenta.CurrentRow.Cells("CantVenta").Value
            Dim id As Integer = dgVinosPorVenta.CurrentRow.Cells("NroVino").Value
            cantidadStock = SeguridadBLL.DesencriptarRSA(ObtenerVino(id).Cantidad) + CInt(CantidadVenta)
            VinoStock.VinoId = dgVinosPorVenta.CurrentRow.Cells("NroVino").Value
        End If

        VinoStock.Cantidad = SeguridadBLL.EncriptarRSA(cantidadStock)
        BLL.Vino.GetInstance.ActualizarStock(VinoStock)
    End Sub

    Private Function ObtenerVino(Optional ByVal _vinoId As Integer = 0) As BE.Vino
        Dim VinoBE As New BE.Vino
        If _vinoId = 0 Then
            VinoBE.VinoId = cmbVino.SelectedValue
        Else
            VinoBE.VinoId = _vinoId
        End If

        VinoBE = BLL.Vino.GetInstance.ListById(VinoBE)
        Return VinoBE
    End Function

    Private Function ValidarAgregarVino() As Boolean
        Dim valido = True
        lblClienteE.Visible = False
        If cmbCliente.SelectedValue = 0 Then
            valido = False
            lblClienteE.Visible = True
            lblClienteE.Text = TraduccionBLL.TraducirTexto("Seleccione el Cliente")
        End If
        lblVinoE.Visible = False
        If cmbVino.SelectedValue = 0 Then
            valido = False
            lblVinoE.Visible = True
            lblVinoE.Text = TraduccionBLL.TraducirTexto("Seleccione el Vino")
        End If
        lblClienteE.Visible = False
        If txtPrecio.Text = "" Then
            valido = False
            lblClienteE.Visible = True
            lblClienteE.Text = TraduccionBLL.TraducirTexto("Campo requerido")
        End If
        Return valido
    End Function

    Private Function ValidarStockPrecio() As Boolean
        Dim valido = True
        Dim cantStock As Integer = SeguridadBLL.DesencriptarRSA(ObtenerVino.Cantidad)
        Dim preStock As Double = SeguridadBLL.DesencriptarRSA(ObtenerVino.Precio)
        If cantStock < CInt(txtCantidad.Text) Then
            valido = False
            MsgBox(TraduccionBLL.TraducirTexto("No hay Stock sufiente en el deposito de vinos."), MsgBoxStyle.Critical, "Error")
        End If
        If CDbl(txtPrecio.Text) < (preStock) Then
            valido = False
            MsgBox(TraduccionBLL.TraducirTexto("El Precio de venta es menor al vino que se requiere vender."), MsgBoxStyle.Critical, "Error")
        End If
        Return valido
    End Function

    Private Function ValidarVenta() As Boolean
        Dim valido = True
        lblclienteE.Visible = False
        If cmbCliente.SelectedValue = 0 Then
            valido = False
            lblclienteE.Visible = True
            lblclienteE.Text = TraduccionBLL.TraducirTexto("Seleccione el Cliente")
        End If
        If vinos.Count = 0 Then
            valido = False
            MsgBox(TraduccionBLL.TraducirTexto("Debe ingresar por lo menos un vino a la venta."), MsgBoxStyle.Critical, "Error")
        End If
        Return valido
    End Function



    Public Sub RegistrarBitacora(evento As String, nivel As String)
        Dim SeguridadBLL As New BLL.Seguridad
        BitacoraBE.Descripcion = SeguridadBLL.EncriptarRSA(evento)
        BitacoraBE.usuario = MenuUI.GetUsuario
        BitacoraBE.criticidad = nivel
        BLL.Bitacora.GetInstance.RegistrarBitacora(BitacoraBE)
    End Sub



    Private Sub btnAgregarVino_Click(sender As Object, e As EventArgs) Handles btnAgregarVino.Click
        Try
            If ValidarAgregarVino() Then
                If ValidarStockPrecio() Then
                    AgregarVinosPorVenta()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ValidarVenta() Then
                If _id > 0 Then
                    RegistrarVenta(False, False)
                Else
                    RegistrarVenta(True)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            index = 0
            If _id > 0 Then
                If ValidarVenta() = False Then
                    MsgBox(TraduccionBLL.TraducirTexto("La venta ya fue generada!"), MsgBoxStyle.Critical, "Error")
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgVinosPorVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVinosPorVenta.CellContentClick
        Try
            Dim id As String = Convert.ToString(dgVinosPorVenta.CurrentRow.Cells("NroVino").Value)
            Dim eliminado As Boolean = dgVinosPorVenta.CurrentRow.Cells("Eliminado").Value
            Dim nombreVino As String = Convert.ToString(dgVinosPorVenta.CurrentRow.Cells("Vino").Value)
            Dim result As Integer
            Dim venta_vino_id As String = Convert.ToString(dgVinosPorVenta.CurrentRow.Cells("venta_vino_id").Value)

            'Dim ventaElegida = BLL.Venta.GetInstance().ListarVentaById(venta)
            'vinos.Clear()
            'For Each item In ventaElegida.Vinos
            '    vinos.Add(item)
            'Next



            If e.ColumnIndex = 5 Then 'Nro Columna del datagriew
                result = MessageBox.Show("¿Esta seguro que desea sacar el vino: " & nombreVino & "?", "Vino por Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then

                    If vinos(e.RowIndex).VentaVinoId = venta_vino_id Then
                        vinos.RemoveAt(e.RowIndex)
                        RegistrarVenta(False, True)
                        dgVinosPorVenta.Rows.Clear()
                        ObtenerVinosPorVenta(vinos)
                    ElseIf venta_vino_id = 0 Then
                        vinos.RemoveAt(e.RowIndex)
                        dgVinosPorVenta.Rows.RemoveAt(e.RowIndex)
                    Else
                        dgVinosPorVenta.Rows.Clear()
                        ObtenerVinosPorVenta()
                    End If

                Else
                    dgVinosPorVenta.Rows.Clear()
                    ObtenerVinosPorVenta()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Try

            Dim Cont As Integer
            For i As Integer = 1 To Len(txtPrecio.Text)
                If Mid(txtPrecio.Text, i, 1) = "," Then Cont = Cont + 1
            Next
            Dim Cadena = ""
            If Cont >= 1 Then Cadena = "1234567980" Else Cadena = "1234567890,"
            If InStr(Cadena, e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbVino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVino.SelectedIndexChanged
        Try

            txtPrecioLista.Text = ""
            txtDisponible.Text = ""
            txtDisponible.Text = SeguridadBLL.DesencriptarRSA(ObtenerVino.Cantidad)
            txtPrecioLista.Text = SeguridadBLL.DesencriptarRSA(ObtenerVino.Precio)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class