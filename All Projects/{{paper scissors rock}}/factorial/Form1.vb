Public Class Form1
    Dim wins As Integer
    Dim losses As Integer
    Dim ties As Integer
    Dim a As String = "The Player Wins"
    Dim b As String = "The Player losses"
    Dim c As String = "Draw"
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = False
        Dim rnd As New Random
        Dim comp As Integer
        comp = rnd.Next(3) + 1
        If comp = 1 Then
            PictureBox1.Visible = True
            Label7.Text = "The Player Wins"
            wins += 1
        ElseIf comp = 2 Then
            PictureBox2.Visible = True
            Label7.Text = "Draw"
            ties += 1
        ElseIf comp = 3 Then
            PictureBox3.Visible = True
            Label7.Text = "The Player Losses"
            losses += 1
        End If
        Label4.Text = wins
        Label5.Text = losses
        Label6.Text = ties
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = True
        Dim rnd As New Random
        Dim comp As Integer
        comp = rnd.Next(3) + 1
        If comp = 1 Then
            PictureBox2.Visible = True
            Label7.Text = "The Player Wins"
            wins += 1
        ElseIf comp = 2 Then
            PictureBox3.Visible = True
            Label7.Text = "Draw"
            ties += 1
        ElseIf comp = 3 Then
            PictureBox1.Visible = True
            Label7.Text = "The Player Losses"
            losses += 1
        End If
        Label4.Text = wins
        Label5.Text = losses
        Label6.Text = ties
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        Dim rnd As New Random
        Dim comp As Integer
        comp = rnd.Next(3) + 1
        If comp = 1 Then
            PictureBox3.Visible = True
            Label7.Text = "The Player Wins"
            wins += 1
        ElseIf comp = 2 Then
            PictureBox1.Visible = True
            Label7.Text = "Draw"
            ties += 1
        ElseIf comp = 3 Then
            PictureBox2.Visible = True
            Label7.Text = "The Player Losses"
            losses += 1
        End If
        Label4.Text = wins
        Label5.Text = losses
        Label6.Text = ties
    End Sub
End Class
