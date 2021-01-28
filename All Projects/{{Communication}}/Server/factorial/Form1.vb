Public Class Form1

    Private server As Class1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        server.islisenting = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server = New Class1
        TextBox1.Text = ":: SERVER STARTED ::" & vbCrLf
        ' AddHandler server.messagereceived 
        AddHandler server.messagereceived, AddressOf onlinereceived
    End Sub
    Private Delegate Sub updatetextdelegate(tb As TextBox, txt As String)
    Sub updatetext(tb As TextBox, txt As String)
        If tb.InvokeRequired Then
            tb.Invoke(New updatetextdelegate(AddressOf updatetext), New Object() {tb, txt})
        Else
            If txt IsNot Nothing Then tb.AppendText(txt & vbCrLf)
        End If
    End Sub
    Sub onlinereceived(sender As Class1, txt As String)
        updatetext(TextBox1, txt)
    End Sub

    
End Class
