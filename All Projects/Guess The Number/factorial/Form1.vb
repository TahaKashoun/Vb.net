Public Class Form1

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count, number As Integer
        count = 1
        Dim correct As Boolean = False
        Dim guess As String
        Randomize()
        number = Int(Rnd() * 100) + 1
        Do While count < 10 And correct = False
            guess = InputBox("Choose a number", "Attempt " & count)
            If Val(guess) = number Then
                correct = True
                MsgBox("That's Correct " & "The Number is " & number)
                Exit Do
            Else
                If Val(guess) < number Then
                    MsgBox("Too Low !", MsgBoxStyle.Exclamation, "Attempt " & count)
                Else
                    MsgBox("Too High !", MsgBoxStyle.Exclamation, "Attempt " & count)
                End If
                count += 1
                If count = 10 Then MsgBox("Run out of attempts")
            End If

        Loop

    End Sub
End Class
