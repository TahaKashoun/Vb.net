Public Class Form1

   
    
    Dim mydic As New Dictionary(Of String, Decimal)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mydic.Add("HP", 3.99)
        mydic.Add("Dell", 4.3)
        mydic.Add("Lenovo", 2.2)
        add()
    End Sub
    Sub add()
        ListBox1.Items.Clear()
        Dim n As KeyValuePair(Of String, Decimal)
        For Each n In mydic
            Dim mystring As String = String.Format("{0}: ${1}", n.Key, n.Value)
            ListBox1.Items.Add(mystring)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If mydic.ContainsKey(TextBox1.Text) Then
                mydic(TextBox1.Text) = TextBox2.Text
            Else
                mydic.Add(TextBox1.Text, TextBox2.Text)
            End If
            add()
        End If
    End Sub
End Class
