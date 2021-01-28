Public Class Form1

    Dim score As Integer = 0
    Dim rnd As New Random
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 30
        PictureBox2.Top -= 30
        PictureBox3.Top -= 30
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 And PictureBox2.Location.Y < -60 And PictureBox3.Location.Y < -60 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Game Over !!!")

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click

        score += 1
        Label1.Text = score
        Dim x As Integer = rnd.Next(30, 200)

        sender.location = New Point(x, 400)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        If ComboBox1.Text = "Fast" Then
            Timer1.Interval = 200
        ElseIf ComboBox1.Text = "Normal" Then
            Timer1.Interval = 400
        ElseIf ComboBox1.Text = "Slow" Then
            Timer1.Interval = 600
        End If
        PictureBox1.Location = New Point(81, 487)
        PictureBox2.Location = New Point(154, 487)
        PictureBox3.Location = New Point(13, 487)
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
End Class
