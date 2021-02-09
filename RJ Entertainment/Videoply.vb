Imports System.Net

Public Class Videoply

    Public Function isconnection() As Boolean
        Dim objurl As New System.Uri("https://www.google.com")
        Dim objwebreq As System.Net.WebRequest
        objwebreq = System.Net.WebRequest.Create(objurl)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objwebreq.GetResponse
            objResp.Close()
            objResp = Nothing
            Return True


        Catch ex As Exception
            objResp = Nothing
            objwebreq = Nothing
            Return False
        End Try

    End Function
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton2.Checked = False

        Me.BackColor = Color.Black
        Me.ForeColor = Color.LimeGreen
        ListBox1.BackColor = Color.Gray
        ListBox1.ForeColor = Color.LawnGreen
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If isconnection() = True Then
            Final.Show()
            Me.Hide()

            RadioButton1.Checked = True
        Else
            RadioButton1.Checked = True
            MessageBox.Show("No Internet Connection")

        End If


        ' Videoer.Show()
        ' Final.Show()



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Checked = False
        Me.BackColor = Color.Silver
        SplitContainer1.Panel1.BackColor = Color.Silver
        Me.ForeColor = Color.Black
        ListBox1.BackColor = Color.Silver
        ListBox1.ForeColor = Color.Black

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Videoply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Hide()
        'RadioButton2.Checked = False

    End Sub

    Dim paths As String()
    Dim filenames As String()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Show()
        If (OpenFileDialog2.ShowDialog = DialogResult.OK) Then
            filenames = OpenFileDialog2.SafeFileNames
            paths = OpenFileDialog2.FileNames
            For i As Integer = 0 To filenames.Length - 1
                ListBox1.Items.Add(filenames(i))

            Next
        End If

        Button4.Location = New Point(-3, 550)
        Button5.Location = New Point(-3, 600)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = paths(ListBox1.SelectedIndex)
        ' ListBox1.Hide()

        Button4.Location = New Point(-3, 360)
        Button5.Location = New Point(-3, 430)

    End Sub

    Private Sub AxWindowsMediaPlayer1_DoubleClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_DoubleClickEvent) Handles AxWindowsMediaPlayer1.DoubleClickEvent
        AxWindowsMediaPlayer1.fullScreen = True


    End Sub

    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent
        AxWindowsMediaPlayer1.Ctlcontrols.pause()


    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton2.Checked = False
        ListBox1.Show()

        Button4.Location = New Point(-3, 550)
        Button5.Location = New Point(-3, 600)


    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        RadioButton2.Checked = False
        Me.BackColor = Color.Black
        SplitContainer1.Panel1.BackColor = Color.Black
        Me.ForeColor = Color.LimeGreen
        ListBox1.BackColor = Color.Gray
        ListBox1.ForeColor = Color.LawnGreen
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Videoply is up to Date :) ")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Videoply_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()

    End Sub
End Class