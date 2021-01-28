Public Class Form1
    Dim dice1, dice2 As Integer
    Dim random As New Random
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
        Else
            dice1 = random.Next(1, 7)
            dice2 = random.Next(1, 7)
            If dice1 = 1 Then
                PictureBox1.Image = My.Resources._1
            ElseIf dice1 = 2 Then
                PictureBox1.Image = My.Resources._2
            ElseIf dice1 = 3 Then
                PictureBox1.Image = My.Resources._3
            ElseIf dice1 = 4 Then
                PictureBox1.Image = My.Resources._4
            ElseIf dice1 = 5 Then
                PictureBox1.Image = My.Resources._5
            ElseIf dice1 = 6 Then
                PictureBox1.Image = My.Resources._6
            End If
            If dice2 = 1 Then
                PictureBox2.Image = My.Resources._1
            ElseIf dice2 = 2 Then
                PictureBox2.Image = My.Resources._2
            ElseIf dice2 = 3 Then
                PictureBox2.Image = My.Resources._3
            ElseIf dice2 = 4 Then
                PictureBox2.Image = My.Resources._4
            ElseIf dice2 = 5 Then
                PictureBox2.Image = My.Resources._5
            ElseIf dice2 = 6 Then
                PictureBox2.Image = My.Resources._6
            End If
        End If
    End Sub
End Class
