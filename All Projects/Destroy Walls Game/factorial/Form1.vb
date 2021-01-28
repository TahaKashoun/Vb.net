Public Class Form1

    Dim ballspeed = 20
    Dim start As Boolean = False
    Dim ballup As Boolean
    Dim ballright As Boolean
    Dim win As Integer = 5
    Dim blocks As Integer = 15
    Dim pics(blocks) As PictureBox
    Dim blockleft As Integer = 16
    Sub check()
        For i = 0 To 15
            If Ball.Top + Ball.Height >= pics(i).Top And Ball.Top <= pics(i).Top + pics(i).Height And Ball.Left + Ball.Width >= pics(i).Left And Ball.Left <= pics(i).Left + pics(i).Width Then
                If pics(i).Visible = True Then
                    pics(i).Visible = False
                    ballup = True
                    blockleft -= 1
                    Label1.Text = "الحواجز المتبيقية " & blockleft
                    If blockleft = 0 Then
                        MsgBox("لـــــــقــــد فـــــزت")
                        Timer2.Stop()
                        End
                    End If
                End If
            End If
        Next
    End Sub
    Sub pic_load()
        pics(0) = PictureBox0
        pics(1) = PictureBox1
        pics(2) = PictureBox2
        pics(3) = PictureBox3
        pics(4) = PictureBox4
        pics(5) = PictureBox5
        pics(6) = PictureBox6
        pics(7) = PictureBox7
        pics(8) = PictureBox8
        pics(9) = PictureBox9
        pics(10) = PictureBox10
        pics(11) = PictureBox11
        pics(12) = PictureBox12
        pics(13) = PictureBox13
        pics(14) = PictureBox14
        pics(15) = PictureBox15

    End Sub
  
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        start = True
        Timer2.Start()
     
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Racket.Top = Me.Bottom - (Me.Bottom / 8)

        Ball.Location = New Point(Racket.Location.X + (Racket.Width / 2) - (Ball.Width / 2), Racket.Location.Y - Ball.Height)

        pic_load()



    End Sub
   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Racket.Left = Cursor.Position.X - Racket.Width / 2
        If start = False Then
            Ball.Left = Racket.Location.X + Racket.Width / 2 - Ball.Width / 2
        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ballup = False Then

            Ball.Location = New Point(Ball.Location.X, Ball.Location.Y - ballspeed)
        Else
            Ball.Location = New Point(Ball.Location.X, Ball.Location.Y + ballspeed)
        End If


        If ballright = False Then

            Ball.Location = New Point(Ball.Location.X - ballspeed, Ball.Location.Y)
        Else
            Ball.Location = New Point(Ball.Location.X + ballspeed, Ball.Location.Y)
        End If

        If Ball.Top < Me.Top Then
            ballup = True

        End If
        If Ball.Bottom >= Me.Bottom Then
            Timer2.Stop()
            MsgBox("لقد خسرت")
            reset()
        End If
        If Ball.Right > Me.Right Then
            ballright = False
        End If
        If Ball.Left < Me.Left Then
            ballright = True
        End If
        If Ball.Top + Ball.Height >= Racket.Top And Ball.Top <= Racket.Top + Racket.Height And Ball.Left + Ball.Width >= Racket.Left And Ball.Left <= Racket.Left + Racket.Width Then
         
            
            ballup = False
        End If
        check()
    End Sub
    
End Class
