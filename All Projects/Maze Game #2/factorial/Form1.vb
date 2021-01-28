Public Class Form1
    Sub returntostart()
        Dim a As New Point(30, 39)
        Cursor.Position = a
        play.Location = a
    End Sub
   
    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles play.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Maximize For The Best Experience", MsgBoxStyle.Information, "Maze")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        play.Location = Control.MousePosition
        play.Top = play.Top - 20
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter, PictureBox9.MouseEnter, PictureBox8.MouseEnter, PictureBox7.MouseEnter, PictureBox6.MouseEnter, PictureBox5.MouseEnter, PictureBox4.MouseEnter, PictureBox3.MouseEnter, PictureBox1.MouseEnter
        returntostart()
    End Sub

    Private Sub Finish_MouseEnter(sender As Object, e As EventArgs) Handles Finish.MouseEnter
        Dim a As New Point(30, 39)
        Cursor.Position = a
        play.Location = a
        MsgBox("Well Done !")

        End
    End Sub
End Class
