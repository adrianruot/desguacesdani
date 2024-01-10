Imports System.Drawing.Text

Public Class Main

    Friend pfc As PrivateFontCollection
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Esta parte del codigo es necesaria para poder establecer el tamaño de la ventana usando como base el tamaño del monitor
        REM Si bien es cierto que lo puedo establecer por defecto en el form de la ventana prefiero hacerlo desde aquí para que quede
        REM más bonito

        Me.Width = My.Computer.Screen.Bounds.Width / 2
        Me.Height = My.Computer.Screen.Bounds.Height / 2
        Me.Left = My.Computer.Screen.Bounds.Width / 4
        Me.Top = My.Computer.Screen.Bounds.Height / 4

        pfc = New PrivateFontCollection()

        pfc.AddFontFile("Vascan.ttf")

        LabelDesguaceDaniTitulo.Font = New Font(pfc.Families(0), 36, FontStyle.Bold)

        UsuarioLabel.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)

        ContraseniaLabel.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
    End Sub

    Private Sub LimpiarButton_Click(sender As Object, e As EventArgs) Handles LimpiarButton.Click
        UsuarioTextField.Text = ""
        ContraseniaField.Text = ""
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsuarioTextField.Text = "" Or ContraseniaField.Text = "" Then
            MsgBox("No estan escritos todos los formularios")
        Else
            MsgBox(LoginControlador.IniciarSesion(UsuarioTextField.Text, ContraseniaField.Text))
        End If


    End Sub
End Class
