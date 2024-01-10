Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Esta parte del codigo es necesaria para poder establecer el tamaño de la ventana usando como base el tamaño del monitor
        REM Si bien es cierto que lo puedo establecer por defecto en el form de la ventana prefiero hacerlo desde aquí para que quede
        REM más bonito

        Me.Width = My.Computer.Screen.Bounds.Width / 2
        Me.Height = My.Computer.Screen.Bounds.Height / 2
        Me.Left = My.Computer.Screen.Bounds.Width / 4
        Me.Top = My.Computer.Screen.Bounds.Height / 4
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
