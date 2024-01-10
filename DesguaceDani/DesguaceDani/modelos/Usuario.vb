Imports System.Runtime.CompilerServices

Public Class Usuario

    Public Property UsuarioNombre As String

    Public Property UsuarioContrasenia As String

    Sub New(UsuarioNombre As String, UsuarioContrasenia As String)
        Me.UsuarioNombre = UsuarioNombre
        Me.UsuarioContrasenia = UsuarioContrasenia
    End Sub

End Class
