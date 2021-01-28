Imports System.IO
Public Class Form1
    Dim path As String = "C:\Users\6AHA‍ ‍\Desktop\Activity\Activity.txt"

    Dim header As String = "===========================لقد تم اجراء الحدث التالي===================" & vbNewLine & Now.ToString("dd/MM/yyyy hh:mm") & vbNewLine


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists("C:\Users\6AHA‍ ‍\Desktop\Activity") = True Then
            Using x As New StreamReader(path)
                RichTextBox1.Text = x.ReadToEnd

            End Using
           

        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\6AHA‍ ‍\Desktop\Activity")
            RichTextBox1.Text = "EMPTY"
        End If

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If e.Name = "Activity" Then
            Exit Sub
        End If
        If Directory.Exists("C:\Users\6AHA‍ ‍\Desktop\Activity") Then
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم التغير على الملف " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\6AHA‍ ‍\Desktop\Activity")
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم التغير على الملف " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        End If

    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        If e.Name = "Activity" Then ' حتى لا يقوم بتسجيل حدث اشناء الملف الجديد
            Exit Sub
        End If
        If Directory.Exists("C:\Users\6AHA‍ ‍\Desktop\Activity") Then
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم انشاء الملف  " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\6AHA‍ ‍\Desktop\Activity")
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم انشاء الملف  " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        End If

    End Sub

    Private Sub FileSystemWatcher1_Deleted(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        If e.Name = "Activity" Then
            Exit Sub
        End If
        If Directory.Exists("C:\Users\6AHA‍ ‍\Desktop\Activity") Then
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم حذف الملف  " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\6AHA‍ ‍\Desktop\Activity")
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم حذف الملف  " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        End If


    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        If e.Name = "Activity" Then
            Exit Sub
        End If
        If Directory.Exists("C:\Users\6AHA‍ ‍\Desktop\Activity") Then
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم تغير اسم الملف  " & vbNewLine & e.OldName & vbNewLine & "الى " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Users\6AHA‍ ‍\Desktop\Activity")
            Dim a As String = (header & e.FullPath & vbNewLine & "لقد تم تغير اسم الملف  " & vbNewLine & e.OldName & vbNewLine & "الى " & vbNewLine & e.Name & vbNewLine)
            Dim n As New StreamWriter(path, True)
            n.Write(a)
            n.Close()
        End If

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then


            MsgBox("الرجاء ادخل كل الحقول")
            Exit Sub
        End If
        If TextBox1.Text = My.Settings.pass Then
            If Not TextBox2.Text.Trim() = Nothing Then
                My.Settings.pass = TextBox2.Text
                My.Settings.Save()
                TextBox1.Clear()
                TextBox2.Clear()
                MsgBox("تم التغير")
            End If
        ElseIf Not TextBox1.Text = My.Settings.pass Then
            MsgBox("الباسورد غير صحيح")

        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Using a As New StreamReader(path)
            RichTextBox1.Text = a.ReadToEnd

        End Using

    End Sub
End Class
