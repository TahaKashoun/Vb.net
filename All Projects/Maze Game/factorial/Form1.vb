Public Class Form1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        a()
        ' Add any initialization after the InitializeComponent() call.

    End Sub





    Private Sub Finish_MouseEnter(sender As Object, e As EventArgs) Handles Finish.MouseEnter
        MsgBox("Well done")
        Close()
    End Sub
    Sub a()
        Dim startingpoint = Panel1.Location()
        startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingpoint)

    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        a()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Deliver The Cursor to The Finish Point")
    End Sub
End Class
