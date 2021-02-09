Public Class Form1

    Public Property urls As String
    Public Property Stringpass As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, WebBrowser1.Resize
        WebBrowser1.Navigate(urls)


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ''WebBrowser1.Navigate("https://docs.google.com/file/d/0B5GBX3rJpZ5QaW5JdE40U25jcEU/preview?pli=1%243")
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Final.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Maximized




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Videoply.Close()
        Me.Close()
        Final.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class