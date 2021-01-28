Public Class Form1

    Public count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '2,5
        Checkbutton(Button1, Button2)
        Checkbutton(Button1, Button5)
        sloved()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '3,1,6
        Checkbutton(Button2, Button3)
        Checkbutton(Button2, Button1)
        Checkbutton(Button2, Button6)
        sloved()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '2,4,7
        Checkbutton(Button3, Button2)
        Checkbutton(Button3, Button4)
        Checkbutton(Button3, Button7)
        sloved()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '3,8
        Checkbutton(Button4, Button3)
        Checkbutton(Button4, Button8)
        sloved()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '1,6,9
        Checkbutton(Button5, Button1)
        Checkbutton(Button5, Button6)
        Checkbutton(Button5, Button9)
        sloved()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '5,7,10,2
        Checkbutton(Button6, Button5)
        Checkbutton(Button6, Button7)
        Checkbutton(Button6, Button10)
        Checkbutton(Button6, Button2)
        sloved()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '6,8,11,3
        Checkbutton(Button7, Button6)
        Checkbutton(Button7, Button8)
        Checkbutton(Button7, Button3)
        Checkbutton(Button7, Button11)
        sloved()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '7,12,4
        Checkbutton(Button8, Button7)
        Checkbutton(Button8, Button12)
        Checkbutton(Button8, Button4)
        sloved()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '5,10,13
        Checkbutton(Button9, Button5)
        Checkbutton(Button9, Button10)
        Checkbutton(Button9, Button13)
        sloved()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '6,9,11,14
        Checkbutton(Button10, Button6)
        Checkbutton(Button10, Button9)
        Checkbutton(Button10, Button11)
        Checkbutton(Button10, Button14)
        sloved()
    End Sub

    Private Sub Button11xd_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '7,10,12,15
        Checkbutton(Button11, Button7)
        Checkbutton(Button11, Button10)
        Checkbutton(Button11, Button15)
        Checkbutton(Button11, Button12)
        sloved()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '8,11,16
        Checkbutton(Button12, Button8)
        Checkbutton(Button12, Button11)
        Checkbutton(Button12, Button16)
        sloved()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '9,14
        Checkbutton(Button13, Button9)
        Checkbutton(Button13, Button14)
        sloved()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '10,13,15
        Checkbutton(Button14, Button10)
        Checkbutton(Button14, Button13)
        Checkbutton(Button14, Button15)
        sloved()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '11,14,16
        Checkbutton(Button15, Button11)
        Checkbutton(Button15, Button14)
        Checkbutton(Button15, Button16)
        sloved()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '12,15
        Checkbutton(Button16, Button12)
        Checkbutton(Button16, Button15)
        sloved()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim x = MsgBox("Do you want to close", vbYesNo, vbQuestion)
        If x = MsgBoxResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        random()
    End Sub
    Sub Checkbutton(ByRef but1 As Button, ByRef but2 As Button)
        If but2.Text = "" Then
            but2.Text = but1.Text
            but1.Text = ""
        End If
   
    End Sub
    Sub sloved()
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And _
                  Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "9" And Button10.Text = "10" _
                  And Button11.Text = "11" And Button12.Text = "12" And Button13.Text = "13" And Button14.Text = "14" _
                  And Button15.Text = "15" And Button16.Text = "" Then
            MsgBox("Well Done !!! , You did it in " & count & " Clicks")

        End If
        count = count + 1
        Me.Text = "Shuffle : " & count & " Clicks"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
    Sub random()
        Dim a(15), i, j, rn As Integer
        Dim flag As Boolean = False
        i = 1
        a(j) = 1
        Do While i <= 15
            Randomize()
            rn = CInt(Int((15 * Rnd()) + 1))
            For j = 1 To i
                If (a(j) = rn) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = rn
                i = i + 1
            End If


        Loop
        Button1.Text = a(1)
        Button2.Text = a(2)
        Button3.Text = a(3)
        Button4.Text = a(4)
        Button5.Text = a(5)
        Button6.Text = a(6)
        Button7.Text = a(7)
        Button8.Text = a(8)
        Button9.Text = a(9)
        Button10.Text = a(10)
        Button11.Text = a(11)
        Button12.Text = a(12)
        Button14.Text = a(14)
        Button13.Text = a(13)
        Button15.Text = a(15)
        Button16.Text = ""

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        random()
    End Sub
End Class
