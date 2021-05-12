<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.bntRegister = New System.Windows.Forms.Button()
        Me.lblAuthText = New System.Windows.Forms.Label()
        Me.lblAuth = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(0, 310)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(207, 40)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'bntRegister
        '
        Me.bntRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.bntRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.bntRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntRegister.Location = New System.Drawing.Point(46, 146)
        Me.bntRegister.Name = "bntRegister"
        Me.bntRegister.Size = New System.Drawing.Size(240, 40)
        Me.bntRegister.TabIndex = 7
        Me.bntRegister.Text = "Cadastrar usuário"
        Me.bntRegister.UseVisualStyleBackColor = True
        '
        'lblAuthText
        '
        Me.lblAuthText.AutoSize = True
        Me.lblAuthText.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAuthText.Location = New System.Drawing.Point(24, 238)
        Me.lblAuthText.Name = "lblAuthText"
        Me.lblAuthText.Size = New System.Drawing.Size(109, 15)
        Me.lblAuthText.TabIndex = 8
        Me.lblAuthText.Text = "Autenticado como:"
        '
        'lblAuth
        '
        Me.lblAuth.AutoSize = True
        Me.lblAuth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAuth.Location = New System.Drawing.Point(158, 238)
        Me.lblAuth.Name = "lblAuth"
        Me.lblAuth.Size = New System.Drawing.Size(0, 15)
        Me.lblAuth.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(46, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cadastrar paciente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Location = New System.Drawing.Point(46, 238)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(240, 40)
        Me.btnMain.TabIndex = 11
        Me.btnMain.Text = "Acessar dados"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Controls.Add(Me.lblAuthText)
        Me.Panel1.Controls.Add(Me.lblAuth)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(339, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 350)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(42, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 60)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MENU"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGH.My.Resources.Resources.menu_5_line
        Me.PictureBox1.Location = New System.Drawing.Point(55, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 93)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SGH.My.Resources.Resources.admin_line
        Me.PictureBox2.Location = New System.Drawing.Point(123, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 93)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(46, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Novo laudo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 350)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bntRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents bntRegister As Button
    Friend WithEvents lblAuthText As Label
    Friend WithEvents lblAuth As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
