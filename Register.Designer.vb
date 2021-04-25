<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPasswd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(12, 13)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(50, 15)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Usuário:"
        '
        'lblPasswd
        '
        Me.lblPasswd.AutoSize = True
        Me.lblPasswd.Location = New System.Drawing.Point(12, 57)
        Me.lblPasswd.Name = "lblPasswd"
        Me.lblPasswd.Size = New System.Drawing.Size(42, 15)
        Me.lblPasswd.TabIndex = 1
        Me.lblPasswd.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 31)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(121, 23)
        Me.txtUser.TabIndex = 3
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"admin", "user"})
        Me.cmbLevel.Location = New System.Drawing.Point(12, 119)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(121, 23)
        Me.cmbLevel.TabIndex = 4
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(12, 148)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(121, 23)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Cadastrar"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 206)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Voltar"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(12, 75)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.Size = New System.Drawing.Size(121, 23)
        Me.txtPasswd.TabIndex = 7
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 177)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 23)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remover"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(165, 243)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPasswd)
        Me.Controls.Add(Me.lblUser)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblPasswd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents btnRemove As Button
End Class
