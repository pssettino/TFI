'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit On
Option Strict On

Public Class Vino

    Private _vinoId As Integer
    Private _descripcion As String
    Private _bodega As Bodega
    Private _precio As String
    Private _cantidad As String
    Private _eliminado As Boolean
    Private _nombreBodega As String


    Public Property VinoId() As Integer
        Get
            Return _vinoId
        End Get
        Set(ByVal value As Integer)
            _vinoId = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Bodega() As Bodega
        Get
            Return _bodega
        End Get
        Set(ByVal value As Bodega)
            _bodega = value
        End Set
    End Property

    Public Property precio() As String
        Get
            Return _precio
        End Get
        Set(ByVal value As String)
            _precio = value
        End Set
    End Property

    Public Property eliminado() As Boolean
        Get
            Return _eliminado
        End Get
        Set(ByVal value As Boolean)
            _eliminado = value
        End Set
    End Property


    Public Property cantidad() As String
        Get
            Return _cantidad
        End Get
        Set(ByVal value As String)
            _cantidad = value
        End Set
    End Property

    Public Property NombreBodega() As String
        Get
            Return _nombreBodega
        End Get
        Set(ByVal value As String)
            _nombreBodega = value
        End Set
    End Property

End Class ' Vino