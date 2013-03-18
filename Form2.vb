Public Class Form2

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("In this window you have to enter the product key, you received it in your email", MsgBoxStyle.Information)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "XMUI" Then
            MsgBox("Right key", MsgBoxStyle.Information)
            My.Settings.Productverify = "on"
            Form1.Enabled = True
            Form1.WindowState = FormWindowState.Maximized
            Me.Close()
        Else
            MsgBox("Wrong key", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.WindowState = FormWindowState.Minimized
        MsgBox("And use capslock when you write the product key", MsgBoxStyle.Information)
    End Sub
End Class