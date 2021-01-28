Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each fnt As FontFamily In FontFamily.Families
            ComboBox1.Items.Add(fnt.Name)
        Next
        ComboBox1.SelectedItem = "Arial"
    End Sub
    Sub setfont()
        Dim strfont = "Arial"
        Dim fntsytle As FontStyle = FontStyle.Regular
        If ComboBox1.SelectedIndex > -1 Then strfont = ComboBox1.SelectedIndex.ToString()
        If bold.Checked Then fntsytle = fntsytle Or FontStyle.Bold
        If italic.Checked Then fntsytle = fntsytle Or FontStyle.Italic
        If underline.Checked = True Then fntsytle = fntsytle Or FontStyle.Underline
        Dim myfont As New Font(strfont, NumericUpDown1.Value, fntsytle)
        RichTextBox1.SelectionFont = myfont
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, underline.CheckedChanged, NumericUpDown1.ValueChanged, italic.CheckedChanged, bold.CheckedChanged
        setfont()
    End Sub

    Private Sub P1_Click(sender As Object, e As EventArgs) Handles P1.Click, p8.Click, p7.Click, P6.Click, P5.Click, P4.Click, P3.Click, P2.Click, additionalcolor.Click
        If rdtext.Checked Then
            RichTextBox1.SelectionColor = sender.BackColor
        Else
            RichTextBox1.SelectionBackColor = sender.BackColor
        End If

    End Sub

    Private Sub morecolors_Click(sender As Object, e As EventArgs) Handles morecolors.Click
        Dim a As New ColorDialog
        If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
            additionalcolor.BackColor = a.Color
        End If
    End Sub
End Class
