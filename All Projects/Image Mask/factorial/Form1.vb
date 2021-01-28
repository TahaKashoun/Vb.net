Public Class Form1

    Dim c As New Color

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New ColorDialog
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            Button1.BackColor = a.Color
            c = a.Color

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As New Bitmap(PictureBox2.Image.Width, PictureBox2.Image.Height)
        Dim a As Graphics = Graphics.FromImage(n)
        Dim rec As New Rectangle(0, 0, n.Width, n.Height)
        Dim k As New TextureBrush(PictureBox2.Image)
        a.FillRectangle(k, rec)
        Dim aa As New SolidBrush(Color.FromArgb(90, c.R, c.G, c.B))
        a.FillRectangle(aa, rec)
        PictureBox2.Image = n
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.agriculture_clouds_countryside_cropland_405342
        PictureBox2.Image = My.Resources.agriculture_clouds_countryside_cropland_405342
    End Sub
End Class
