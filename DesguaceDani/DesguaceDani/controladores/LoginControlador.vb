Imports System.Data.SQLite

Module LoginControlador

    Function IniciarSesion(UsuarioNombre As String, UsuarioContrasenia As String) As String
        API_SQLITE_READER.COMPROBAR_CONEXION()
        API_SQLITE_READER.COMANDO_CONEXION("SELECT NOMBRE FROM USUARIOS")

        Dim rdr As SQLiteDataReader = API_SQLITE_READER.EJECUTAR()

        Using rdr
            While (rdr.Read())
                Return rdr.GetString(0)
            End While
        End Using
        API_SQLITE_READER.CERRAR()
        Return "Nada"
    End Function

End Module
