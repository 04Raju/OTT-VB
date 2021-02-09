Imports Testing1

Public Class Final
    Dim obj As New Form1


    'Sub switchPanel1(ByVal Panel As Form)
    '    Panel1.Controls.Clear()
    '    Web.TopLevel = False
    '    Panel1.Controls.Add(Web)
    '    Web.Show()

    'End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' If ComboBox3.Text = "Web Series" Then
        'ListView2.Show()
        'switchPanel1(Web)

        ' ElseIf ComboBox3.Text = "All" Then


        ' ListView1.Show()






        ' End If
    End Sub





    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Dark Mode" Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.Blue
            ComboBox1.ForeColor = Color.Blue
            ComboBox1.BackColor = Color.Black
            ' ComboBox2.ForeColor = Color.Blue
            ' ComboBox2.BackColor = Color.Black
            'ComboBox3.ForeColor = Color.Blue
            ' ComboBox3.BackColor = Color.Black
            ListView1.BackColor = Color.Black
            ListView1.ForeColor = Color.Blue
            ' ListView2.BackColor = Color.Black
            ' ListView2.ForeColor = Color.Blue

        ElseIf ComboBox1.Text = "Default Mode" Then
            Me.BackColor = Color.Silver
            Me.ForeColor = Color.Black
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            ' ComboBox2.ForeColor = Color.Black
            'ComboBox2.BackColor = Color.White
            ' ComboBox3.ForeColor = Color.Black
            ' ComboBox3.BackColor = Color.White
            ListView1.BackColor = Color.Silver
            ListView1.ForeColor = Color.Black
            'ListView2.BackColor = Color.Silver
            'ListView2.ForeColor = Color.Black



        ElseIf ComboBox1.Text = "Offline Mode" Then
            Videoply.Show()
            Me.Close()


        End If
    End Sub

    Private Sub Final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ListView2.Hide()
        Button2.Hide()



    End Sub
    Dim Re As String



    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick


        Re = ListView1.SelectedItems(0).SubItems(0).Text
        If Re = "Boyz 2" Then
            Dim obj1 As New Form1

            obj1.urls = "https://drive.google.com/file/d/1JBrl815-dgW9Siagqo9TMT1E74pZwt88/preview?pl1=1%245"

            obj1.Show()

            ' MessageBox.Show(ListView1.SelectedItems(0).SubItems(0).Text)


        ElseIf Re = "Hirkani" Then
            ' ListView1.Items(I).Selected = True
            obj.urls = "https://drive.google.com/file/d/1SkeNcn_E4fD410R00lZkcEatsH_IufUD/preview?pl1=1%245"
            obj.Show()
        ElseIf Re = "Girlz" Then
            Dim obj2 As New Form1
            obj2.urls = "https://drive.google.com/file/d/1wxrTrVgF4muk-74b0c79peJQrybbVhjl/preview?pl1=1%245"
            obj2.Show()
        ElseIf Re = "Naal" Then
            Dim obj3 As New Form1
            obj3.urls = "https://drive.google.com/file/d/1SmI_qY-KeSo6aniYjwdY4g9JP6UZMWBu/preview?pl1=1%245"
            obj3.Show()
        ElseIf Re = "Bonus" Then
            Dim obj4 As New Form1
            obj4.urls = "https://drive.google.com/file/d/1qlZRMxdfzZGiHuJNS8ZhgA1yFWqQRkZs/preview?pl1=1%245"
            obj4.Show()
        ElseIf Re = "Gol Gol Gara Gara" Then
            Dim obj5 As New Form1
            obj5.urls = "https://drive.google.com/file/d/1stXhUwcMiuWxM0jvePRXFTeQGS4i-Xk5/preview?pl1=1%245"
            obj5.Show()
        ElseIf Re = "Farzand" Then
            Dim obj6 As New Form1
            obj6.urls = "https://drive.google.com/file/d/1bg9YcxBxkAI1QrsFusKA95o4Mk-IFArK/preview?pl1=1%245"
            obj6.Show()
        ElseIf Re = "Triple seat" Then
            Dim obj7 As New Form1
            obj7.urls = "https://drive.google.com/file/d/1Ljk4URgoW6phO3P4Vwh0yZxExsBmH8W7/preview?pl1=1%245"
            obj7.Show()


        End If  ' End Of Marathi Movies


        If Re = "Street Dancer 3D" Then ' Hindi Movies  
            Dim obj7 As New Form1
            obj7.urls = "https://drive.google.com/file/d/144IsqKcne5SL57EXh9hzIiT8DfNFX3r_/preview?pl1=1%245"
            obj7.Show()
        ElseIf Re = "Now You See Me 2" Then
            Dim obj8 As New Form1
            obj8.urls = "https://drive.google.com/file/d/1gFnpq3Dqo5ltVroiPklM3a_lxEfZ90-C/preview?pl1=1%245"
            obj8.Show()
        ElseIf Re = "Kee" Then
            Dim obj9 As New Form1
            obj9.urls = "https://drive.google.com/file/d/1LP6PGOKZ4vt6dQwbhcm_I3CQkW7VSH4G/preview?pl1=1%245"
            obj9.Show()
        ElseIf Re = "Housefull 4" Then
            Dim obj0 As New Form1
            obj0.urls = "https://drive.google.com/file/d/14fYmhGEY_y4rS0sfgSMX0UTi9YXmw-Rh/preview?pl1=1%245"
            obj0.Show()
        ElseIf Re = "Fligh crew" Then
            Dim obj11 As New Form1
            obj11.urls = "https://drive.google.com/file/d/1VbFFfODbb1kFL27qDGFdAUyd4xMbh9Ay/preview?pl1=1%245"
            obj11.Show()
        ElseIf Re = "Bad Boys For Life" Then
            Dim obj12 As New Form1
            obj12.urls = "https://drive.google.com/file/d/14u6CARqBHj-GvTrewgeGCGVUe44MI7J5/preview?pl1=1%245"
            obj12.Show()
        ElseIf Re = "Bloodshot 2020" Then
            Dim obj13 As New Form1
            obj13.urls = "https://drive.google.com/file/d/1MvjtUeAmfu9VU_2mTWa_qhsu1jIWi2_e/preview?pl1=1%245"
            obj13.Show()
        ElseIf Re = "Contagion" Then
            Dim obj14 As New Form1
            obj14.urls = "https://drive.google.com/file/d/1jt0PebgX9ZVEygkT_aJNZ95HSCZN-5wf/preview?pl1=1%245"
            obj14.Show()
        ElseIf Re = "Dabangg3" Then
            Dim obj16 As New Form1
            obj16.urls = "https://drive.google.com/file/d/1TjJq1fmaY76XiheSzQejqHoUGWoywmHP/preview?pl1=1%245"
            obj16.Show()
        ElseIf Re = "Joker 2019" Then
            Dim obj16 As New Form1
            obj16.urls = "https://drive.google.com/file/d/1MzUDM8HlRNnPwfvqAod1d2-TIrY-iyez/preview?pl1=1%245"
            obj16.Show()
        ElseIf Re = "Venom" Then
            Dim obj17 As New Form1
            obj17.urls = "https://drive.google.com/file/d/10x-rtQQYp7u_WJLMyc-FOafx342CwS0h/preview?pl1=1%245"
            obj17.Show()
        ElseIf Re = "Annabala 2019" Then
            Dim obj18 As New Form1
            obj18.urls = "https://drive.google.com/file/d/18K2VuZSjvt_E4jkdbui89WJH2WZX--lK/preview?pl1=1%245"
            obj18.Show()
        ElseIf Re = "Code 8" Then
            Dim obj19 As New Form1
            obj19.urls = "https://drive.google.com/file/d/1-_OrvTbUGSsJFBbvWI18tEokC4MzR62A/preview?pl1=1%245"
            obj19.Show()
        ElseIf Re = "Jumanji 2019" Then
            Dim obj20 As New Form1
            obj20.urls = "https://drive.google.com/file/d/1J-4XuvLCGRP8TykEIBfCImpXfE0M6HUd/preview?pl1=1%245"
            obj20.Show()
        ElseIf Re = "Kanithan" Then
            Dim obj21 As New Form1
            obj21.urls = "https://drive.google.com/file/d/1HYVHi0Nf0zxX7RxPMKbMRCl8m0NCjJKV/preview?pl1=1%245"
            obj21.Show()
        ElseIf Re = "Now You See Me 1" Then
            Dim obj23 As New Form1
            obj23.urls = "https://drive.google.com/file/d/1RL1VoJFyNLrDRd5wpcZab-PkW31cblBS/preview?pl1=1%245"
            obj23.Show()
        ElseIf Re = "Ragini MMS Returns" Then
            Dim obj22 As New Form1
            obj22.urls = "https://drive.google.com/file/d/1ylJFuXqnrOLV-4vij7gx6VfIsqnl75I4/preview?pl1=1%245"
            obj22.Show()
        ElseIf Re = "Turbulence" Then
            Dim obj24 As New Form1
            obj24.urls = "https://drive.google.com/file/d/1NNcb-ZSbaForYZ1Ckyl1O_CIXbgzLam1/preview?pl1=1%245"
            obj24.Show()
        ElseIf Re = "Yeh saali Aashiqui" Then
            Dim obj25 As New Form1
            obj25.urls = "https://drive.google.com/file/d/1aJ5GkiJ4bbEEKrdPjftNoI14PV9FVXix/preview?pl1=1%245"
            obj25.Show()
        ElseIf Re = "Lion king 1994" Then
            Dim obj26 As New Form1
            obj26.urls = "https://drive.google.com/file/d/0B9f4dr0k6323SDdCdTNLX0h6eFE/preview?pl1=1%245"
            obj26.Show()

        ElseIf Re = "Bulbbul" Then
            Dim obj327 As New Form1
            obj327.urls = "https://drive.google.com/file/d/1A6ssX-Gm-BPs5j9-7yDi0mhKosX2agQy/preview?pl1=1%245"
            obj327.Show()

        ElseIf Re = "Vardi ka Dam" Then
            Dim obj328 As New Form1
            obj328.urls = "https://drive.google.com/file/d/1CFYSyoRDYoJS6yfJwEr5an2Xlt6Z3Qyt/preview?pl1=1%245"
            obj328.Show()

        ElseIf Re = "The Meg" Then
            Dim obj327 As New Form1
            obj327.urls = "https://drive.google.com/file/d/1QGmdjYVVZkO1o7t-gXHTyN2Ge-82EI4A/preview?pl1=1%245"
            obj327.Show()

        ElseIf Re = "Bhoot part 1" Then
            Dim obj427 As New Form1
            obj427.urls = "https://drive.google.com/file/d/1EoMCOSYkrFKKvNF0udMqwmxTXDq1bPPw/preview?pl1=1%245"
            obj427.Show()

        ElseIf Re = "Hacked" Then
            Dim obj427 As New Form1
            obj427.urls = "https://drive.google.com/file/d/1-6NrGqeygTnl7Emf9TjHuJT6pc-ur69N/preview?pl1=1%245"
            obj427.Show()

        End If  'End of Hindi Movies

        If Re = "Rama Rama Re" Then ' Kannada Movie Started
            Dim obj27 As New Form1
            obj27.urls = "https://drive.google.com/file/d/1CL9B0jk_IadEu8M8AixFCEOO2fXG0brX/preview?pl1=1%245"
            obj27.Show()
        ElseIf Re = "Bhagamathie" Then
            Dim obj28 As New Form1
            obj28.urls = "https://drive.google.com/file/d/1LkEzgcdqj1g8VPZD9upeAhfw27ZNxAir/preview?pl1=1%245"
            obj28.Show()
        ElseIf Re = "Male" Then
            Dim obj29 As New Form1
            obj29.urls = "https://drive.google.com/file/d/1ysf9g7VK20qYE8vw8_9WcWTuvZ7Dr997/preview?pl1=1%245"
            obj29.Show()
        ElseIf Re = "Kirik Party" Then
            Dim obj30 As New Form1
            obj30.urls = "https://drive.google.com/file/d/1EpQRTa4gXdlhVyKtL84aWKAwz-jS86kc/preview?pl1=1%245"
            obj30.Show()
        ElseIf Re = "Kotigobba2" Then
            Dim obj301 As New Form1
            obj301.urls = "https://drive.google.com/file/d/1j9XEDzdTfO5O7ozJ1XIwBO2jsKVhPHFx/preview?pl1=1%245"
            obj301.Show()


        End If ' End of Kannada Movies


        If Re = "Oh baby" Then
            Dim obj31 As New Form1
            obj31.urls = "https://drive.google.com/file/d/1S1Wx0Vw7-jtPWRHsjedQGvsfSGs1y9ul/preview?pl1=1%245"
            obj31.Show()
        ElseIf Re = "Routine love Story" Then
            Dim obj32 As New Form1
            obj32.urls = "https://drive.google.com/file/d/192bNcL48bf4uyFV_T2tkxijX0SYoAFAQ/preview?pl1=1%245"
            obj32.Show()

        ElseIf Re = "Ala Vaikunthapurramuloo" Then
            Dim obj323 As New Form1
            obj323.urls = "https://firebasestorage.googleapis.com/v0/b/light-lacing-247408.appspot.com/o/bolle%2FBhangra%20Paa%20Le%2FHDMovieshub.cc%20Ala_Vaikunthapurramloo_[2020]__700MB-480P-[Hindi_Subtitle]_Telugu_TRUE_WEB-DL_ESub.mp4.mp4?alt=media&token=a182d6a5-c6ac-4dbb-819e-a972c579e3d2"
            obj323.Show()


        End If  'End of Telugu Movies


        If Re = "Beyond Skyline" Then
            Dim objen1 As New Form1
            objen1.urls = "https://drive.google.com/file/d/1RRLNFsrRkwrHBw1OGjmGg6Hjt5JRi3cD/preview?pl1=1%245"
            objen1.Show()

        ElseIf Re = "World 4 U" Then
            Dim objen2 As New Form1
            objen2.urls = "https://drive.google.com/file/d/1a2K1-8K0yJXbjs3Yp0cfeOjslyXB_0qg/preview?pl1=1%245"
            objen2.Show()

        ElseIf Re = "Eagle Eye" Then
            Dim objen3 As New Form1
            objen3.urls = "https://drive.google.com/file/d/0B5GBX3rJpZ5QaW5JdE40U25jcEU/preview?pl1=1%245"
            objen3.Show()

        ElseIf Re = "The Social Network" Then
            Dim objen4 As New Form1
            objen4.urls = "https://drive.google.com/file/d/0B8JyUhp5w_z-THhWTG9ITkZxTWs/preview?pl1=1%245"
            objen4.Show()

        ElseIf Re = "Johnny English" Then
            Dim objen5 As New Form1
            objen5.urls = "https://drive.google.com/file/d/1cG08oo-A0It3GwmJlbjQ1dxNrFanpNuy/preview?pl1=1%245"
            objen5.Show()

        ElseIf Re = "Mr.Beans Holiday" Then
            Dim objen6 As New Form1
            objen6.urls = "https://drive.google.com/file/d/11OY-xGVtEVpQnTTDEDghxqIz7cwPUENY/preview?pl1=1%245"
            objen6.Show()

        ElseIf Re = "Jurassic Thunder" Then
            Dim objen4 As New Form1
            objen4.urls = "https://drive.google.com/file/d/1G_hhXE1MDeVXNuR1yJhhsEGXpJWjCiC2/preview?pl1=1%245"
            objen4.Show()

        ElseIf Re = "The Way Back" Then
            Dim objen5 As New Form1
            objen5.urls = "https://drive.google.com/file/d/1GeELi7olZtvcC6zg4VGUHJEnhl7kKhAv/preview?pl1=1%245"
            objen5.Show()

        ElseIf Re = "The Founder" Then
            Dim objen6 As New Form1
            objen6.urls = "https://drive.google.com/file/d/1pEjWscawpSSEqO8Ah_7QC8-SfJenTst2/preview?pl1=1%245"
            objen6.Show()

        ElseIf Re = "The Great Hack" Then
            Dim objen7 As New Form1
            objen7.urls = "https://drive.google.com/file/d/1vccSU1_7YDAHPOvJypey13ysxpEa9mLR/preview?pl1=1%245"
            objen7.Show()

        End If


        If Re = "Mr. Robot" Then   'WEb Series Mr. Robot
            ' ListView2.Show()
            Button2.Show()


        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim findItem As ListViewItem = ListView1.FindItemWithText(TextBox1.Text, False, 0, True)


        'If findItem IsNot Nothing Then
        '    ListView1.MultiSelect = False
        '    ListView1.TopItem = findItem

        '    findItem.Selected = True
        'End If

        ListView1.Focus()

        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = TextBox1.Text Then
                ListView1.Items(i).Selected = True


            End If
        Next



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' ListView2.Hide()
        Button2.Hide()

    End Sub
    Dim Re1 As String


    Private Sub ListView2_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        'Re1 = ListView2.SelectedItems(0).SubItems(0).Text
        'If Re1 = "Episode 1" Then
        '    Dim obj33 As New Form1
        '    obj33.urls = "https://drive.google.com/file/d/1S1Wx0Vw7-jtPWRHsjedQGvsfSGs1y9ul/preview?pl1=1%245"
        '    obj33.Show()
        'ElseIf Re1 = "Episode 2" Then
        '    Dim obj34 As New Form1
        '    obj34.urls = "https://drive.google.com/file/d/192bNcL48bf4uyFV_T2tkxijX0SYoAFAQ/preview?pl1=1%245"
        '    obj34.Show()

        '  End If

    End Sub

    Private Sub Final_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Videoply.Show()
        Me.Hide()




    End Sub
End Class