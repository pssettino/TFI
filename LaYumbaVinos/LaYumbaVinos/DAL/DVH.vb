﻿'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''DAL
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit On
Option Strict On

Public Class DVH
    Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}

    Structure Tabla
        Public nombre As String
        Public primary_keys As String()
    End Structure

    Public Function GetDigito(ByVal DigitoVerificadorHorizontal As BE.DVH) As String
        Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}

        Dim SqlComm As New SqlClient.SqlCommand With {.Connection = SqlConn}

        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable

        SqlConn.Open()
        Dim query = "SELECT dvh FROM " + DigitoVerificadorHorizontal.ObtenerTabla.ToString + " WHERE 1 = 1"
        For Each restriccion In DigitoVerificadorHorizontal.ObtenerRestricciones
            query = query + " AND " + restriccion.campo.ToString + " = " + restriccion.identificador.ToString
        Next
        SqlComm.CommandText = query
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        SqlConn.Close()

        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Function GetRegistro(ByVal DigitoVerificadorHorizontal As BE.DVH) As DataRow
        Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}

        Dim SqlComm As New SqlClient.SqlCommand With {.Connection = SqlConn}

        Dim dr As SqlClient.SqlDataReader
        Dim dt As New DataTable

        SqlConn.Open()
        Dim query = "SELECT * FROM " + DigitoVerificadorHorizontal.ObtenerTabla.ToString + " WHERE 1 = 1"
        For Each restriccion In DigitoVerificadorHorizontal.ObtenerRestricciones
            query = query + " AND " + restriccion.campo.ToString + " = " + restriccion.identificador.ToString
        Next
        SqlComm.CommandText = query
        dr = SqlComm.ExecuteReader()
        dt.Load(dr)
        SqlConn.Close()

        Return dt.Rows(0)
    End Function

    Public Function GetTablas() As DataSet
        Try


            Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}
            
            Dim SqlComm As New SqlClient.SqlCommand With {.Connection = SqlConn}

            Dim dr As SqlClient.SqlDataReader
            Dim ds As New DataSet

            Dim tablas As New List(Of Tabla)
            tablas.Add(New Tabla With {.nombre = "Usuario", .primary_keys = {"usuario_id"}})
            tablas.Add(New Tabla With {.nombre = "Bitacora", .primary_keys = {"bitacora_id"}})
            tablas.Add(New Tabla With {.nombre = "Familia", .primary_keys = {"familia_id"}})
            tablas.Add(New Tabla With {.nombre = "Venta", .primary_keys = {"venta_id"}})
            tablas.Add(New Tabla With {.nombre = "Venta_Vino", .primary_keys = {"venta_vino_id", "venta_id", "vino_id"}})
            tablas.Add(New Tabla With {.nombre = "Vino", .primary_keys = {"vino_id"}})
            tablas.Add(New Tabla With {.nombre = "Cliente", .primary_keys = {"cliente_id"}})

            SqlConn.Open()
            Dim query = ""
            For Each tabla In tablas
                query = "SELECT * FROM " + tabla.nombre
                SqlComm.CommandText = query
                dr = SqlComm.ExecuteReader()
                Dim dt As New DataTable With {.TableName = tabla.nombre}
                dt.Load(dr)
                Dim primaryKey(tabla.primary_keys.Count - 1) As DataColumn
                Dim contador = 0
                For Each primary_key In tabla.primary_keys
                    primaryKey(contador) = dt.Columns(primary_key)
                    contador = contador + 1
                Next
                dt.PrimaryKey = primaryKey
                ds.Tables.Add(dt)
            Next
            SqlConn.Close()

            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub SetDigito(ByVal DigitoVerificadorHorizontal As BE.DVH, ByVal dvh As String)
        Dim SqlConn As New SqlClient.SqlConnection With {.ConnectionString = Conexion.getConexionLaYumba}

        Dim SqlComm As New SqlClient.SqlCommand With {.Connection = SqlConn}

        SqlConn.Open()
        Dim query = "UPDATE " + DigitoVerificadorHorizontal.ObtenerTabla.ToString + " SET dvh = '" + dvh.ToString + "' WHERE 1 = 1"
        For Each restriccion In DigitoVerificadorHorizontal.ObtenerRestricciones
            query = query + " AND " + restriccion.campo.ToString + " = " + restriccion.identificador.ToString
        Next
        SqlComm.CommandText = query
        SqlComm.ExecuteNonQuery()
        SqlConn.Close()
    End Sub

End Class ' DVH