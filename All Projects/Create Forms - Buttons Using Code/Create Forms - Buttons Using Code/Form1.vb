Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form
        Dim button As New Button
        Dim txt As New TextBox

        frm.Show()
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Text = "Primary Form"

        frm.Controls.Add(txt)
        txt.Location = New Point(30, 50)

        button.Text = "Go Back to Previous Form"
        button.Location = New Point(30, (txt.Top + txt.Left + 10))
    End Sub
End Class
