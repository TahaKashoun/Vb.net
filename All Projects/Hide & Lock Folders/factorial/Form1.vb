Imports System.IO
Imports System.Security.AccessControl
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = Nothing Then
            MsgBox("الرجاء اختيار ملف")

        End If
        File.SetAttributes(TextBox1.Text, FileAttributes.Hidden)
        MsgBox("تم اخفاء الملف")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n As New FolderBrowserDialog
        If n.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = n.SelectedPath
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = Nothing Then
            MsgBox("الرجاء اختيار مجلد")
            Exit Sub

        End If
        Dim x As FileSystemSecurity = File.GetAccessControl(TextBox1.Text)
        Dim n As New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny)
        x.AddAccessRule(n)
        File.SetAccessControl(TextBox1.Text, x)
        MsgBox("تم القفل")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        Dim x As FileSystemSecurity = File.GetAccessControl(TextBox1.Text)
        Dim n As New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny)
        x.RemoveAccessRule(n)
        File.SetAccessControl(TextBox1.Text, x)
        MsgBox("تم الغاء القفل")

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        File.SetAttributes(TextBox1.Text, FileAttributes.Normal)
    End Sub
End Class
