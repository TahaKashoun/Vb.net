Public Class Form1
    Dim n As Boolean = False
   
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label4.Click, Label3.Click, Label2.Click, Label5.Click

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox5.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox5.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Clear()
        TextBox5.AppendText("" & vbNewLine)
        TextBox5.AppendText(vbTab + Label1.Text & " : " & TextBox1.Text & vbNewLine)
        TextBox5.AppendText("" & vbNewLine)
        TextBox5.AppendText(vbTab & Label2.Text & " : " & TextBox2.Text + vbNewLine)
        TextBox5.AppendText("" & vbNewLine)
        TextBox5.AppendText(vbTab & Label3.Text & " : " & TextBox3.Text + vbNewLine)
        TextBox5.AppendText("" & vbNewLine)
        TextBox5.AppendText(vbTab & Label4.Text & " : " & TextBox4.Text + vbNewLine)
        TextBox5.AppendText("=================================================" & vbNewLine)
        TextBox5.AppendText(vbTab & Today & vbTab & TimeOfDay & vbNewLine)
        TextBox5.AppendText("=================================================" & vbNewLine)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim issave As New SaveFileDialog
        issave.Filter = "Text Files  | *.txt"
        issave.FilterIndex = 2
        issave.RestoreDirectory = True
        If issave.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(issave.FileName, TextBox5.Text)
        End If
        MsgBox("All Saved!!!")
       
    End Sub
  
    Sub changecolor()
        Randomize()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim x As Integer
        a = Int(Rnd() * 255) + 1
        b = Int(Rnd() * 255) + 1
        c = Int(Rnd() * 255) + 1
        x = Int(Rnd() * 255) + 1
        Button2.ForeColor = Color.FromArgb(a, b, c, x)
        Button1.ForeColor = Button2.ForeColor
    End Sub
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
  
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End



    End Sub
  
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        changecolor()
        
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave, TextBox2.Leave, TextBox4.Leave

        If Not TextBox1.Text = "" Then
            Label6.Visible = True
        End If
        If Not TextBox2.Text = "" Then
            Label8.Visible = True
        End If
        If Not TextBox3.Text = "" Then
            Label7.Visible = True
        End If
        If Not TextBox4.Text = "" Then
            Label9.Visible = True
        End If
    End Sub

    'Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
    '    Label8.Visible = True
    'End Sub

    'Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
    '    Label7.Visible = True
    'End Sub

    'Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
    '    Label9.Visible = True
    'End Sub

   
   







  



    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        If n = True Then
            Label10.Visible = True
            n = False
            Exit Sub
        End If
        If Label10.Visible = True And Label11.Visible = False Then
            Label11.Visible = True
        ElseIf Label11.Visible = True And Label12.Visible = False Then
            Label12.Visible = True
        ElseIf Label12.Visible = True And Label13.Visible = False Then

            Label13.Visible = True
        ElseIf Label13.Visible = True And Label14.Visible = False Then
            Label14.Visible = True
        ElseIf Label14.Visible = True And Label15.Visible = False Then
            Label15.Visible = True
        ElseIf Label15.Visible = True And Label16.Visible = False Then
            Label16.Visible = True
        ElseIf Label16.Visible = True And Label17.Visible = False Then
            Label17.Visible = True
        ElseIf Label17.Visible = True And Label18.Visible = False Then
            Label18.Visible = True
        Else
            Label10.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            n = True
        End If


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label18.Click

    End Sub
End Class
