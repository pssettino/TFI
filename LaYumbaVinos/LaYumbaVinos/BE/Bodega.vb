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