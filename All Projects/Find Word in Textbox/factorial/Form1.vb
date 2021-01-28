Public Class Form1

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        Dim index As Integer = 0
        Label3.Text = result
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionBackColor = Color.Transparent
        While index < RichTextBox1.Text.LastIndexOf(TextBox1.Text)
            RichTextBox1.Find(TextBox1.Text, index, RichTextBox1.Text.Length, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Brown
            index = RichTextBox1.Text.IndexOf(TextBox1.Text, index) + 1
            result += 1
            Label3.Text = result
        End While

    End Sub

    
End Class
