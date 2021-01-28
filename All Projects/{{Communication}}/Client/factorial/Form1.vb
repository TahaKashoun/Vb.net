Public Class Form1

    Dim client As Class1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        client = New Class1("192.168.0.120", 64555)
        If client.client.Connected Then Button2.Text = "CONNECTED"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If client.client.Connected Then
            client.send(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class
