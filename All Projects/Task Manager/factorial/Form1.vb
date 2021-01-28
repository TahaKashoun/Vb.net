Imports System.Diagnostics
Public Class Form1


    Sub getall()
        Dim n() As Process
        n = Process.GetProcesses
        For Each a In n
            ListBox1.Items.Add(a.ProcessName)
        Next

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getall()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim n As Process = Process.GetProcessesByName(ListBox1.SelectedItem)(0)
            n.Kill()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub تشغيلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تشغيلToolStripMenuItem.Click
        Dim n As New Form2
        If n.ShowDialog = Windows.Forms.DialogResult.OK Then
            getall()

        End If
    End Sub
End Class
