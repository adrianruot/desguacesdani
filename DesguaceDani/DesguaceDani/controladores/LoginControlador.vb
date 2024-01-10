Module LoginControlador

    Function IniciarSesion(UsuarioNombre As String, UsuarioContrasenia As String) As String
        Dim usuario As Usuario = New Usuario(UsuarioNombre, UsuarioContrasenia)

        Return usuario.UsuarioNombre
    End Function

End Module
