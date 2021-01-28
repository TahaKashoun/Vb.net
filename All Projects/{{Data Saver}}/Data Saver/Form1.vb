Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim() = "" Or TextBox2.Text.Trim() = "" Or TextBox3.Text.Trim() = "" Then
            MsgBox("You Have Missed Something ")
        Else
            Dim srcheck As New StreamReader("Data.txt")
            Dim strcheck As String = srcheck.ReadToEnd()
            srcheck.Close()
            If strcheck.Contains(TextBox1.Text & " ; ") Then
                MsgBox("Please Chenge ID")
            Else
                Dim strwriter As New StreamWriter("data.txt", True)
                Dim strperson As String = TextBox1.Text & " ; " & TextBox2.Text & " ; " & TextBox3.Text
                strwriter.WriteLine(strperson)
                MsgBox("Added !!!")
                TextBox1.Focus()
            End If
        End If
        ''''Filed
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
