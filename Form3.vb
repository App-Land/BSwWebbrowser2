Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Homepage = "Google" Then
            CheckBox1.Checked = True
            CheckBox2.Checked = False
        End If
        If My.Settings.Homepage = "Yahoo" Then
            CheckBox2.Checked = True
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        My.Settings.Homepage = "Google"
        Me.Close()
        Form1.WebBrowser1.Navigate("www.google.com")
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        My.Settings.Homepage = "Yahoo"
        Me.Close()
        Form1.WebBrowser1.Navigate("www.yahoo.com")
    End Sub
End Class