'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''BE
''Pablo Settino
''Provincia.vb
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Explicit On
Option Strict On

Public Class Provincia

    Private _provinciaId As Integer
    Private _descripcion As String

    Public Property ProvinciaId() As Integer
        Get
            Return _provinciaId
        End Get
        Set(ByVal value As Integer)
            _provinciaId = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

End Class