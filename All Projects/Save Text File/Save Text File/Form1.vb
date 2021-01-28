Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.FileName = TextBox1.Text & ".txt"
        SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Try
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim x As StreamWriter
                Dim a As String = SaveFileDialog1.FileName
                If Path.GetExtension(SaveFileDialog1.FileName).ToLower <> ".txt" Then
                    a &= ".txt"
                    End
                End If
                Dim xx As New StreamWriter(SaveFileDialog1.FileName)
                xx.WriteLine(TextBox2.Text)
                xx.Close()
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
