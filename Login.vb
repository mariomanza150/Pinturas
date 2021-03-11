Public Class Login
    Private Sub bttn_login_Click(sender As Object, e As EventArgs) Handles bttn_login.Click
        If txt_user.Text.Equals("A") And txt_psw.Text.Equals("B") Then
            Visualizer.Show()
            Me.Close()
        Else
            MsgBox("¡Datos Incorrectos!")
        End If
    End Sub
End Class