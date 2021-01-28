Public Class Form2
    Dim g As New Process

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Me.TextBox1.Text = "" Then
                Exit Sub
            Else
                Dim a As New Process
                a.StartInfo.FileName = Me.TextBox1.Text
                a.Start()
            End If


            


        Catch ex As Exception
            MsgBox(ex.Message
                   )
        End Try

       
    End Sub
End Class