'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
''Pablo Settino
''Bitacora.vb
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit On
Option Strict On

Public Class Bitacora
    Private _bicatoraId As Integer
    Private _usuario As Usuario
    Private _nombreUsuario As String
    Private _fechaHora As DateTime
    Private _descripcion As String
    Private _criticidad As String
    Private _dvh As Integer

    Public Property Dvh() As Integer
        Get
            Return _dvh
        End Get
        Set(ByVal value As Integer)
            _dvh = value
        End Set
    End Property

    Public Property BitacoraId() As Integer
        Get
            Return _bicatoraId
        End Get
        Set(ByVal value As Integer)
            _bicatoraId = value
        End Set
    End Property

    Public Property NombreUsuario() As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal Value As String)
            _nombreUsuario = Value
        End Set
    End Property
    Public Property FechaHora() As Date
        Get
            Return _fechaHora
        End Get
        Set(ByVal Value As Date)
            _fechaHora = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            _descripcion = Value
        End Set
    End Property

    Public Property Usuario() As Usuario
        Get
            Return _usuario
        End Get
        Set(ByVal Value As Usuario)
            _usuario = Value
        End Set
    End Property

    Public Property Criticidad() As String
        Get
            Return _criticidad
        End Get
        Set(ByVal value As String)
            _criticidad = value
        End Set
    End Property
 

End Class