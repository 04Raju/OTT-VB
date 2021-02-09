Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Private iPrograssBarValue As Integer = 0

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ApplicationTitle.Text = "RTS Entertainment..."

        Version.Text = System.String.Format(Version.Text,
                                            My.Application.Info.Version.Major,
                                            My.Application.Info.Version.Minor)
        Version.Text &= Space(1)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        ' Copyright.Text &= vbNewLine & " CopyRight Act 2020-2021"

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000
        ProgressBar1.Value = 0

        Timer1.Enabled = True
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        iPrograssBarValue += 1
        Select Case iPrograssBarValue
            Case 1, 3, 5, 7, 9
                ProgressBar1.ForeColor = Color.Blue
                ProgressBar1.Value = (iPrograssBarValue * 100)
            Case 2, 4, 6, 8, 10
            Case 13
                Timer1.Stop()
                Timer1.Enabled = False
                Videoply.Show()

                Me.Hide()
        End Select


    End Sub


End Class
