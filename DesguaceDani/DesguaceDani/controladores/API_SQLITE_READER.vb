Imports System.Data.SQLite

Module API_SQLITE_READER
    REM Este modulo que he creado para mi mismo tiene
    REM como fin el de poder escribir menos veces la cantidad
    REM de conexiones que debería usar cada vez que me conecto
    REM a la base de datos

    Private dbName As String = "vb.db"

    Private dbPath As String = Application.StartupPath & "\" & dbName

    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Sub COMPROBAR_CONEXION()
        If Not connection.State = ConnectionState.Open Then
            connection.Open()
        End If
    End Sub

    Sub COMANDO_CONEXION(textCmd As String)
        command.Connection = connection
        command.CommandText = textCmd
    End Sub

    Function EJECUTAR() As SQLiteDataReader
        Try

            Return command.ExecuteReader

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Function

    Sub CERRAR()
        connection.Close()
    End Sub

End Module
