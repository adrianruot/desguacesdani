Imports System.Data.SQLite

Module LoginControlador

    Private dbName As String = "vb.db"

    Private dbPath As String = Application.StartupPath & "\" & dbName

    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Function IniciarSesion(UsuarioNombre As String, UsuarioContrasenia As String) As String


        If Not connection.State = ConnectionState.Open Then
            connection.Open()
        End If

        command.Connection = connection
        command.CommandText = "SELECT NOMBRE FROM USUARIOS"

        Dim rdr As SQLiteDataReader = command.ExecuteReader

        Using rdr
            While (rdr.Read())
                Return rdr.GetString(0)
            End While
        End Using

        connection.Close()


        Return "Nada"
    End Function

End Module
