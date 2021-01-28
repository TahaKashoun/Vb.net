Public Class Form1
    Dim task As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskmgr", Nothing)
    Dim ex As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", Nothing)
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If task = 0 Then
            Button1.Text = "تعطيل"
        ElseIf task = 1 Then
            Button1.Text = "تمكين"
        End If
        If ex = 0 Then
            Button2.Text = "تعطيل"
        ElseIf ex = 1 Then
            Button2.Text = "تمكين"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If task = 0 Then
            Button1.Text = "تمكين"
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1)
            task = 1
        Else
            Button1.Text = "تعطيل"
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0)
            task = 0
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ex = 0 Then
            Button2.Text = "تمكين"
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1)
            ex = 1
        Else
            Button2.Text = "تعطيل"
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0)
            ex = 0
        End If
    End Sub


End Class
