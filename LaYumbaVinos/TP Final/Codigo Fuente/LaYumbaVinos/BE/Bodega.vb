'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
''Pablo Settino
''Bodega.vb
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Explicit On
Option Strict On

Public Class Bodega

    Private _bodegaId As Integer
    Private _razonSocial As String
    Private _telefono As String
    Private _cuit As String
    Private _provincia As Provincia

    Private _eliminado As Boolean
    Public Property Eliminado() As Boolean
        Get
            Return _eliminado
        End Get
        Set(ByVal value As Boolean)
            _eliminado = value
        End Set
    End Property



    Public Property Provincia() As Provincia
        Get
            Return _provincia
        End Get
        Set(ByVal value As Provincia)
            _provincia = value
        End Set
    End Property

    Private _localidad As Localidad
    Public Property Localidad() As Localidad
        Get
            Return _localidad
        End Get
        Set(ByVal value As Localidad)
            _localidad = value
        End Set
    End Property



    Public Property BodegaId() As Integer
        Get
            Return _bodegaId
        End Get
        Set(ByVal value As Integer)
            _bodegaId = value
        End Set
    End Property

    Public Property RazonSocial() As String
        Get
            Return _razonSocial
        End Get
        Set(ByVal value As String)
            _razonSocial = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property Cuit() As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            _cuit = value
        End Set
    End Property

End Class