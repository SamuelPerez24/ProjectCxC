Imports System.Data.SqlClient
Imports System.Data

Module m_ConexionBD

#Region "Variables"

    'Ruta de la base de datos SQL.
    Public Ruta As String = "Server=localhost; Initial Catalog = ProyectoFinalCC;" & _
    "Integrated Security=SSPI;"
    '------------------------------------------------------------------------>Data Source=localhost
#Region "Solo para Cargo"
    Public Cargo As String
#End Region

    'Instancia de conexion hacia la base de datos SQL.
    Public Conexion As New SqlConnection(Ruta)
    'Instancia de DataSet.
    Public DS As DataSet = New DataSet()
    'Declaracion de la variable del Adaptador.
    Public Adap As SqlDataAdapter


#End Region
    'Funcion para conectar a la base de datos SQL.
    Public Sub Conectar()
        If Not Conexion.State = ConnectionState.Open Then
            Conexion.Open()
        End If
    End Sub
    'Funcion para desconertar la base de datos SQL.
    Public Sub Desconectar()
        Conexion.Close()
    End Sub
    'Consulta Funcion Insert
    Public Function InsertQuery(Sql As String) As Boolean
        'Se abre la conexion si no esta abierta.
        If Not Conexion.State = ConnectionState.Open Then
            Conexion.Open()
        End If
        'Comando
        Dim Comando As New SqlCommand(Sql, Conexion)
        'Variable para almacenar resultado de la devuelta de SQL.
        Dim Conteo As Integer = Comando.ExecuteNonQuery()
        'Se cierra la conexion.
        Desconectar()

        'Condicion de la variable donde SQL almacena el resultado.
        If Conteo > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Consulta Funcion Delete
    Public Function DeleteQuery(Tabla As String, Condicion As String) As Boolean
        'Se abre la conexion si no esta abierta.
        If Not Conexion.State = ConnectionState.Open Then
            Conexion.Open()
        End If

        'Declaro variable para la Consulta.
        Dim Sql As String = "DELETE FROM" & Tabla & "WHERE" & Condicion
        'Comando
        Dim Comando As New SqlCommand(Sql, Conexion)
        'Variable para almacenar resultado de la devuelta de SQL.
        Dim Conteo As Integer = Comando.ExecuteNonQuery()
        'Se cierra la conexion.
        Desconectar()

        'Condicion de la variable donde SQL almacena el resultado.
        If Conteo > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Consulta Funcion Update
    Public Function UpdateQuery(Tabla As String, Campos As String, Condicion As String) As Boolean
        'Se abre la conexion si no esta abierta.
        If Not Conexion.State = ConnectionState.Open Then
            Conexion.Open()
        End If
        'Declaro variable para la Consulta.
        Dim Sql As String = "UPDATE" & Tabla & "SET" & Campos & "WHERE" & Condicion
        'Comando.
        Dim Comando As New SqlCommand(Sql, Conexion)
        'Variable para almacenar resultado de la devuelta de SQL.
        Dim Conteo As Integer = Comando.ExecuteNonQuery()
        'Se cierra la conexion.
        Desconectar()

        'Condicion de la variable donde SQL almacena el resultado.
        If Conteo > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Consulta Metodo Select
    Public Sub SelectQuery(Sql As String, Tabla As String)
        'Se abre la conexion si no esta abierta.
        If Not Conexion.State = ConnectionState.Open Then
            Conexion.Open()
        End If

        'Primero limpio el dataset.
        DS.Clear()
        'Declaro el Adaptador
        Adap = New SqlDataAdapter(Sql, Conexion)
        'Comando builder
        Dim Comando As New SqlCommandBuilder(Adap)
        'Rellena el adaptador con los datos del DataSet mas la tabla.
        Adap.Fill(DS, Tabla)
    End Sub
End Module
