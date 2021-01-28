Public Class Form1
    Dim isback As Boolean
    Dim nextpath As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fd As New FolderBrowserDialog()
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = fd.SelectedPath
            ListView1.Items.Clear()
            On Error Resume Next
            For Each i In My.Computer.FileSystem.GetDirectories(fd.SelectedPath)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count - 1)
            Next
            For Each i In My.Computer.FileSystem.GetFiles(fd.SelectedPath)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count - 2)
            Next
        End If
    End Sub

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        If My.Computer.FileSystem.DirectoryExists(nextpath) Then
            ListView1.Items.Clear()
            TextBox1.Text = nextpath
            On Error Resume Next
            For Each i In My.Computer.FileSystem.GetDirectories(nextpath)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count - 1)
            Next
            For Each i In My.Computer.FileSystem.GetFiles(nextpath)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count - 2)
            Next
        Else
            MsgBox("That's not a folder")
        End If
        
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        nextpath = TextBox1.Text + "\" + e.Item.Text


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Folder Browser"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String = TextBox1.Text
        Dim y As Integer = x.LastIndexOf("\")
        If y > 2 Then
            x = TextBox1.Text.Substring(0, y)
            TextBox1.Text = x
            ListView1.Items.Clear()
            On Error Resume Next
            For Each i In My.Computer.FileSystem.GetDirectories(x)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count - 1)
            Next
            For Each i In My.Computer.FileSystem.GetFiles(x)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count - 2)
            Next
        End If
        isback = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
