'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
''Pablo Settino
''VentaVino.vb
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class VentaVino

    Private _venta As BE.Venta
    Private _vino As BE.Vino
    Private _cantidadVenta As String
    Private _precioVenta As String
    Private _ventaVinoId As Integer
    Private _ventaId As Integer

    Private _vinoRpt As String
    Public Property VinoRpt() As String
        Get
            Return _vinoRpt
        End Get
        Set(ByVal value As String)
            _vinoRpt = value
        End Set
    End Property


    Public Property VentaVinoId() As Integer
        Get
            Return _ventaVinoId
        End Get
        Set(ByVal value As Integer)
            _ventaVinoId = value
        End Set
    End Property


    Public Property Venta() As BE.Venta
        Get
            Return _venta
        End Get
        Set(ByVal value As BE.Venta)
            _venta = value
        End Set
    End Property

    Public Property Vino() As BE.Vino
        Get
            Return _vino
        End Get
        Set(ByVal value As BE.Vino)
            _vino = value
        End Set
    End Property

    Public Property CantidadVenta() As String
        Get
            Return _cantidadVenta
        End Get
        Set(ByVal value As String)
            _cantidadVenta = value
        End Set
    End Property


    Public Property PrecioVenta() As String
        Get
            Return _precioVenta
        End Get
        Set(ByVal value As String)
            _precioVenta = value
        End Set
    End Property
    Public Property VentaId() As Integer
        Get
            Return _ventaId
        End Get
        Set(ByVal value As Integer)
            _ventaId = value
        End Set
    End Property

End Class
