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
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_psw = New System.Windows.Forms.TextBox()
        Me.lbl_psw = New System.Windows.Forms.Label()
        Me.bttn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.lbl_data.Location = New System.Drawing.Point(201, 44)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(207, 30)
        Me.lbl_data.TabIndex = 0
        Me.lbl_data.Text = "Ingrese su Usuario"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(118, 127)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(71, 23)
        Me.lbl_user.TabIndex = 1
        Me.lbl_user.Text = "Usuario:"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(227, 124)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(258, 30)
        Me.txt_user.TabIndex = 2
        '
        'txt_psw
        '
        Me.txt_psw.Location = New System.Drawing.Point(227, 174)
        Me.txt_psw.Name = "txt_psw"
        Me.txt_psw.Size = New System.Drawing.Size(258, 30)
        Me.txt_psw.TabIndex = 4
        '
        'lbl_psw
        '
        Me.lbl_psw.AutoSize = True
        Me.lbl_psw.Location = New System.Drawing.Point(118, 177)
        Me.lbl_psw.Name = "lbl_psw"
        Me.lbl_psw.Size = New System.Drawing.Size(95, 23)
        Me.lbl_psw.TabIndex = 3
        Me.lbl_psw.Text = "Contraseña:"
        '
        'bttn_login
        '
        Me.bttn_login.Location = New System.Drawing.Point(295, 245)
        Me.bttn_login.Name = "bttn_login"
        Me.bttn_login.Size = New System.Drawing.Size(140, 40)
        Me.bttn_login.TabIndex = 5
        Me.bttn_login.Text = "Entrar"
        Me.bttn_login.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 436)
        Me.Controls.Add(Me.bttn_login)
        Me.Controls.Add(Me.txt_psw)
        Me.Controls.Add(Me.lbl_psw)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_data)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_psw As TextBox
    Friend WithEvents lbl_psw As Label
    Friend WithEvents bttn_login As Button
End Class
