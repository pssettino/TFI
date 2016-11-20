'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
''Pablo Settino
''Traduccion.vb
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit On
Option Strict On

Public Class Traduccion

    Private _traduccion_id As Integer
    Private _idioma As Idioma
    Private _texto As String
    Private _traduccion As String

    Public Property TraduccionId() As Integer
        Get
            Return _traduccion_id
        End Get
        Set(ByVal value As Integer)
            _traduccion_id = value
        End Set
    End Property

    Public Property Idioma() As Idioma
        Get
            Return _idioma
        End Get
        Set(ByVal Value As Idioma)
            _idioma = Value
        End Set
    End Property

    Public Property Texto() As String
        Get
            Return _texto
        End Get
        Set(ByVal value As String)
            _texto = value
        End Set
    End Property

    Public Property Traduccion() As String
        Get
            Return _traduccion
        End Get
        Set(ByVal value As String)
            _traduccion = value
        End Set
    End Property


End Class