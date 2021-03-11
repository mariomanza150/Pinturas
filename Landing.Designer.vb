<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
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
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.bttn_enter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.lbl_welcome.Location = New System.Drawing.Point(37, 105)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(146, 33)
        Me.lbl_welcome.TabIndex = 0
        Me.lbl_welcome.Text = "¡Bienvenido!"
        '
        'bttn_enter
        '
        Me.bttn_enter.Location = New System.Drawing.Point(278, 95)
        Me.bttn_enter.Name = "bttn_enter"
        Me.bttn_enter.Size = New System.Drawing.Size(140, 60)
        Me.bttn_enter.TabIndex = 1
        Me.bttn_enter.Text = "Entrar"
        Me.bttn_enter.UseVisualStyleBackColor = True
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 257)
        Me.Controls.Add(Me.bttn_enter)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Landing"
        Me.Text = "Museo del Arte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_welcome As Label
    Friend WithEvents bttn_enter As Button
End Class
