<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblSubLogo = New System.Windows.Forms.Label()
        Me.tmrInicial = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLogo.Location = New System.Drawing.Point(191, 154)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(239, 128)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "SGH"
        '
        'lblSubLogo
        '
        Me.lblSubLogo.AutoSize = True
        Me.lblSubLogo.Location = New System.Drawing.Point(181, 282)
        Me.lblSubLogo.Name = "lblSubLogo"
        Me.lblSubLogo.Size = New System.Drawing.Size(259, 15)
        Me.lblSubLogo.TabIndex = 1
        Me.lblSubLogo.Text = "Sistema de Gerenciamento Hospitalar Facilitado"
        '
        'tmrInicial
        '
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(611, 450)
        Me.Controls.Add(Me.lblSubLogo)
        Me.Controls.Add(Me.lblLogo)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogo As Label
    Friend WithEvents lblSubLogo As Label
    Friend WithEvents tmrInicial As Timer
End Class
