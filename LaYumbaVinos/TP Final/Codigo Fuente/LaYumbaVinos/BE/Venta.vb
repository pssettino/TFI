'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
''Pablo Settino
''Venta.vb
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit On
Option Strict On
Public Class Venta
    Private _ventaId As Integer
    Private _fechaVenta As Date
    Private _activo As Boolean
    Private _dvh As Integer
    Private _vinos As List(Of VentaVino)
    Private _cliente As Cliente
    Private _eliminado As Boolean
    Private _totalImporte As Double
    Private _clienteRpt As String



    Public Property TotalImporte() As Double
        Get
            Return _totalImporte
        End Get
        Set(ByVal value As Double)
            _totalImporte = value
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

    Public Property FechaVenta() As Date
        Get
            Return _fechaVenta
        End Get
        Set(ByVal value As Date)
            _fechaVenta = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property Dvh() As Integer
        Get
            Return _dvh
        End Get
        Set(ByVal value As Integer)
            _dvh = value
        End Set
    End Property

    Public Property Vinos() As List(Of VentaVino)
        Get
            Return _vinos
        End Get
        Set(ByVal value As List(Of VentaVino))
            _vinos = value
        End Set
    End Property

    Public Property Cliente() As Cliente
        Get
            Return _cliente
        End Get
        Set(ByVal value As Cliente)
            _cliente = value
        End Set
    End Property


    Public Property Eliminado() As Boolean
        Get
            Return _eliminado
        End Get
        Set(ByVal value As Boolean)
            _eliminado = value
        End Set
    End Property

    Public Property ClienteRpt() As String
        Get
            Return _clienteRpt
        End Get
        Set(ByVal value As String)
            _clienteRpt = value
        End Set
    End Property

End Class