<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAccess = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccess
        '
        Me.btnAccess.Location = New System.Drawing.Point(12, 103)
        Me.btnAccess.Name = "btnAccess"
        Me.btnAccess.Size = New System.Drawing.Size(100, 23)
        Me.btnAccess.TabIndex = 0
        Me.btnAccess.Text = "Acessar"
        Me.btnAccess.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 7)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 15)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuário"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 25)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 23)
        Me.txtUser.TabIndex = 2
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(12, 74)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd.Size = New System.Drawing.Size(100, 23)
        Me.txtPasswd.TabIndex = 4
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(12, 56)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(39, 15)
        Me.lblSenha.TabIndex = 3
        Me.lblSenha.Text = "Senha"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 132)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(126, 178)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnAccess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso de Usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccess As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents btnQuit As Button
End Class
