<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelDesguaceDaniTitulo = New System.Windows.Forms.Label()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.ContraseniaLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextField = New System.Windows.Forms.TextBox()
        Me.ContraseniaField = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.LimpiarButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelDesguaceDaniTitulo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseniaLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseniaField, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioTextField, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LoginButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LimpiarButton, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1564, 1079)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelDesguaceDaniTitulo
        '
        Me.LabelDesguaceDaniTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDesguaceDaniTitulo.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LabelDesguaceDaniTitulo, 2)
        Me.LabelDesguaceDaniTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesguaceDaniTitulo.Location = New System.Drawing.Point(3, 0)
        Me.LabelDesguaceDaniTitulo.Name = "LabelDesguaceDaniTitulo"
        Me.LabelDesguaceDaniTitulo.Size = New System.Drawing.Size(1558, 239)
        Me.LabelDesguaceDaniTitulo.TabIndex = 0
        Me.LabelDesguaceDaniTitulo.Text = "Desguace Dani"
        Me.LabelDesguaceDaniTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(681, 453)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(98, 25)
        Me.UsuarioLabel.TabIndex = 1
        Me.UsuarioLabel.Text = "Usuario: "
        '
        'ContraseniaLabel
        '
        Me.ContraseniaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContraseniaLabel.AutoSize = True
        Me.ContraseniaLabel.Location = New System.Drawing.Point(644, 597)
        Me.ContraseniaLabel.Name = "ContraseniaLabel"
        Me.ContraseniaLabel.Size = New System.Drawing.Size(135, 25)
        Me.ContraseniaLabel.TabIndex = 2
        Me.ContraseniaLabel.Text = "Contraseña: "
        '
        'UsuarioTextField
        '
        Me.UsuarioTextField.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UsuarioTextField.Location = New System.Drawing.Point(785, 444)
        Me.UsuarioTextField.Name = "UsuarioTextField"
        Me.UsuarioTextField.Size = New System.Drawing.Size(300, 31)
        Me.UsuarioTextField.TabIndex = 3
        '
        'ContraseniaField
        '
        Me.ContraseniaField.Location = New System.Drawing.Point(785, 600)
        Me.ContraseniaField.Multiline = True
        Me.ContraseniaField.Name = "ContraseniaField"
        Me.ContraseniaField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseniaField.Size = New System.Drawing.Size(300, 31)
        Me.ContraseniaField.TabIndex = 4
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginButton.Location = New System.Drawing.Point(649, 839)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(130, 81)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'LimpiarButton
        '
        Me.LimpiarButton.Location = New System.Drawing.Point(785, 839)
        Me.LimpiarButton.Name = "LimpiarButton"
        Me.LimpiarButton.Size = New System.Drawing.Size(132, 81)
        Me.LimpiarButton.TabIndex = 6
        Me.LimpiarButton.Text = "Limpiar"
        Me.LimpiarButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1568, 1079)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1574, 1088)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Desguaces Dani"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelDesguaceDaniTitulo As Label
    Friend WithEvents UsuarioLabel As Label
    Friend WithEvents ContraseniaLabel As Label
    Friend WithEvents ContraseniaField As TextBox
    Friend WithEvents UsuarioTextField As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents LimpiarButton As Button
End Class
