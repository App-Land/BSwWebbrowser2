Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Homepage = "Google" Then
            WebBrowser1.Navigate("www.google.com")
        End If
        If My.Settings.Homepage = "Yahoo" Then
            WebBrowser1.Navigate("www.yahoo.com")
        End If
        If My.Settings.Productverify = "off" Then
            Me.Enabled = False
            MsgBox("Before you can use the product you have to enter the product key", MsgBoxStyle.Information)
            Form2.Show()
        End If

        If My.Settings.Productverify = "on" Then
            MsgBox("Welcome", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form3.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripProgressBar1.Value = 100
        ToolStripStatusLabel1.Text = "Done"
    End Sub

    Private Sub WebBrowser1_FileDownload(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.FileDownload
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = ""
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString
        Dim url As Uri = New Uri(TextBox1.Text)
        If url.HostNameType = UriHostNameType.Dns Then
            Dim icons = "http://" & url.Host & "/favicon.ico"
            Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icons)
            Dim res As System.Net.HttpWebResponse = req.GetResponse()
            Dim stream As System.IO.Stream = res.GetResponseStream()
            Dim fav = Image.FromStream(stream)
            Me.PictureBox1.Image = fav
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        My.Settings.Savesite = (TextBox1.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WebBrowser1.Navigate(My.Settings.Savesite)
    End Sub
End Class
