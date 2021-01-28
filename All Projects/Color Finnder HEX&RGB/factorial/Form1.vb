Public Class Form1

    Dim b As New Bitmap(1, 1)
    Dim a As Graphics = Graphics.FromImage(b)
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Timer1.Enabled = CheckBox1.Checked


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a.CopyFromScreen(Cursor.Position, Point.Empty, b.Size)
        PictureBox1.BackColor = b.GetPixel(0, 0)
        TextBox5.Text = b.GetPixel(0, 0).R & "," & b.GetPixel(0, 0).G & "," & b.GetPixel(0, 0).B
        TextBox4.Text = ColorTranslator.ToHtml(b.GetPixel(0, 0))
        TextBox1.Text = b.GetPixel(0, 0).R
        TextBox2.Text = b.GetPixel(0, 0).G
        TextBox3.Text = b.GetPixel(0, 0).B
    End Sub
End Class
