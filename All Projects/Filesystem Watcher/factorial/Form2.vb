Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = SystemInformation.WorkingArea.Width - Me.Width
        Me.Top = SystemInformation.WorkingArea.Height - Me.Top
        TopMost = True
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.pass Then
            Hide()
            Form1.Show()
        Else
            MsgBox("الباسورد غير صحيح")
        End If
    End Sub

    
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()

        End If
    End Sub
End Class