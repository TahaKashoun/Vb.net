Imports QRCoder
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New QRCodeGenerator
        Dim data = a.CreateQrCode(TextBox1.Text, QRCodeGenerator.ECCLevel.Q)
        Dim c As New QRCode(data)
        PictureBox1.Image = c.GetGraphic(6)
    End Sub
End Class
