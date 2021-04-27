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
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 415)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(333, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Sair"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'bntRegister
        '
        Me.bntRegister.Location = New System.Drawing.Point(12, 109)
        Me.bntRegister.Name = "bntRegister"
        Me.bntRegister.Size = New System.Drawing.Size(333, 23)
        Me.bntRegister.TabIndex = 7
        Me.bntRegister.Text = "Cadastrar usuário"
        Me.bntRegister.UseVisualStyleBackColor = True
        '
        'lblAuthText
        '
        Me.lblAuthText.AutoSize = True
        Me.lblAuthText.Location = New System.Drawing.Point(12, 59)
        Me.lblAuthText.Name = "lblAuthText"
        Me.lblAuthText.Size = New System.Drawing.Size(109, 15)
        Me.lblAuthText.TabIndex = 8
        Me.lblAuthText.Text = "Autenticado como:"
        '
        'lblAuth
        '
        Me.lblAuth.AutoSize = True
        Me.lblAuth.Location = New System.Drawing.Point(146, 59)
        Me.lblAuth.Name = "lblAuth"
        Me.lblAuth.Size = New System.Drawing.Size(0, 15)
        Me.lblAuth.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(333, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cadastrar Paciente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(12, 267)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(333, 23)
        Me.btnMain.TabIndex = 11
        Me.btnMain.Text = "Acessar dados"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 450)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAuth)
        Me.Controls.Add(Me.lblAuthText)
        Me.Controls.Add(Me.bntRegister)
        Me.Controls.Add(Me.btnQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents bntRegister As Button
    Friend WithEvents lblAuthText As Label
    Friend WithEvents lblAuth As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMain As Button
End Class
