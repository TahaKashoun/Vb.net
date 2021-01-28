Public Class Form1

   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
    Dim a As Integer = 1
    Private Sub btn_click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click

        Dim btn As Button = sender
        If btn.Text = "" Then
            If a Mod 2 > 0 Then
                btn.Text = "X"
                btn.ForeColor = Color.Green
                Label1.Text = " O Turn"
                getthewiinner()
            Else
                btn.Text = "O"
                btn.ForeColor = Color.Blue
                Label1.Text = "X Turn"
                getthewiinner()
            End If
            a += 1
        End If
    End Sub
    Dim win As Boolean = False
    Private Function getthewiinner()
        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button2.Text) AndAlso Button1.Text.Equals(Button3.Text) Then
            win = True
            winEffect(Button1, Button2, Button3)
        End If
        If Not Button4.Text.Equals("") AndAlso Button4.Text.Equals(Button5.Text) AndAlso Button4.Text.Equals(Button6.Text) Then
            win = True
            winEffect(Button4, Button5, Button6)
        End If
        If Not Button7.Text.Equals("") AndAlso Button7.Text.Equals(Button8.Text) AndAlso Button7.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button7, Button8, Button9)
        End If
        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button4.Text) AndAlso Button1.Text.Equals(Button7.Text) Then
            win = True
            winEffect(Button1, Button4, Button7)
        End If
        If Not Button2.Text.Equals("") AndAlso Button2.Text.Equals(Button5.Text) AndAlso Button2.Text.Equals(Button8.Text) Then
            win = True
            winEffect(Button2, Button5, Button8)
        End If
        If Not Button3.Text.Equals("") AndAlso Button3.Text.Equals(Button6.Text) AndAlso Button3.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button3, Button9, Button6)
        End If
        If Not Button3.Text.Equals("") AndAlso Button3.Text.Equals(Button5.Text) AndAlso Button3.Text.Equals(Button7.Text) Then
            win = True
            winEffect(Button3, Button5, Button7)
           
        End If
        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button5.Text) AndAlso Button1.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button9, Button1, Button5)
        End If
        If allbuttonstextlength() = 9 AndAlso win = False Then
            Label1.Text = "Draw"
        End If
    End Function
    Function allbuttonstextlength()
        Dim x As Integer = 0
        For Each c As Control In Panel2.Controls
            If c.GetType() Is GetType(Button) Then
                x += c.Text.Length
            End If

        Next
        Return x
    End Function
    Sub winEffect(ByVal b1 As Button, ByVal b2 As Button, ByVal b3 As Button)
        b1.BackColor = Color.Red
        b2.BackColor = Color.Red
        b3.BackColor = Color.Red

        b1.ForeColor = Color.White
        b2.ForeColor = Color.White
        b3.ForeColor = Color.White
        Label1.Text = b1.Text + " Is The Winner"


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        win = False
        Label1.Text = "Play"
        For Each c As Control In Panel2.Controls
            If c.GetType() Is GetType(Button) Then
                c.Text = ""
                c.BackColor = Color.White
            End If
        Next
       
    End Sub
End Class
