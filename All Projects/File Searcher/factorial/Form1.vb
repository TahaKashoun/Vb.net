Public Class Form1
    Sub getfiles(path As String)
        Try
            For Each iteam As String In My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchTopLevelOnly, "*." & TextBox2.Text)
                Me.Invoke(Sub()


                              ListBox1.Items.Add(iteam)

                          End Sub)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As New FolderBrowserDialog
        If n.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = n.SelectedPath

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        getfiles(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

        BackgroundWorker1.RunWorkerAsync()

    End Sub
End Class
