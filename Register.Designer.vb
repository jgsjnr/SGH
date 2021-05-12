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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(12, 137)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(50, 15)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Usuário:"
        '
        'lblPasswd
        '
        Me.lblPasswd.AutoSize = True
        Me.lblPasswd.Location = New System.Drawing.Point(12, 181)
        Me.lblPasswd.Name = "lblPasswd"
        Me.lblPasswd.Size = New System.Drawing.Size(42, 15)
        Me.lblPasswd.TabIndex = 1
        Me.lblPasswd.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 155)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(121, 23)
        Me.txtUser.TabIndex = 3
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"admin", "user"})
        Me.cmbLevel.Location = New System.Drawing.Point(12, 243)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(121, 23)
        Me.cmbLevel.TabIndex = 4
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(12, 272)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(121, 23)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Cadastrar"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 330)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Voltar"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(12, 199)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.Size = New System.Drawing.Size(121, 23)
        Me.txtPasswd.TabIndex = 7
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 301)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 23)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remover"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 124)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGH.My.Resources.Resources.admin_line
        Me.PictureBox1.Location = New System.Drawing.Point(23, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(149, 377)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPasswd)
        Me.Controls.Add(Me.lblUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
