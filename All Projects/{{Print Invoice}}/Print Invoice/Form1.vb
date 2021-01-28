Imports System.Text.RegularExpressions
Public Class Form1
    'this projet isn't finshed !!!
    Dim context As New ContextMenu
    Sub showprice()
        Price.Text = ComboBox1.SelectedValue.ToString
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.DefaultCellStyle.ForeColor = Color.Navy

        Next
        DataGridView1.Columns(1).DefaultCellStyle.ForeColor = Color.Red
        DataGridView1.Columns(3).DefaultCellStyle.ForeColor = Color.Green
        datetext.Text = Now.ToString("yyyy/MM/dd")
        Customname.Focus()
        Customname.Select()
        Customname.SelectAll()
        Dim itemsdata As New Dictionary(Of Integer, String)

        itemsdata.Add(1120, "Dell Labtop ")
        itemsdata.Add(455, "Canon Camera")
        itemsdata.Add(300, "intel Core i7")
        itemsdata.Add(400, "GTX 1060TI")
        ComboBox1.DataSource = New BindingSource(itemsdata, Nothing)
        ComboBox1.DisplayMember = "value"
        ComboBox1.ValueMember = "key"
        showprice()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox("Cooded By 6aha")
    End Sub

    Private Sub datetext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datetext.KeyPress, total.KeyPress, Price.KeyPress
        e.Handled = True
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub datetext_MouseDown(sender As Object, e As MouseEventArgs) Handles datetext.MouseDown, Quantity.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            datetext.ContextMenu = New ContextMenu
        End If
    End Sub

    Private Sub total_MouseDown(sender As Object, e As MouseEventArgs) Handles total.MouseDown, Price.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            total.ContextMenu = context
        End If
    End Sub


    Private Sub Customname_KeyDown(sender As Object, e As KeyEventArgs) Handles Customname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Quantity.Focus()
            Quantity.SelectAll()
        End If
    End Sub

    Private Sub Quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            Add.PerformClick()
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub Quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Quantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 48 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Quantity_TextChanged(sender As Object, e As EventArgs) Handles Quantity.TextChanged
        If Quantity.Text.Trim() = "" Or Quantity.Text = "0" Then Quantity.Text = "1"


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        showprice()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim item As String = ComboBox1.Text
            Dim qty As Integer = Quantity.Text
            Dim price1 As Integer = Price.Text
            Dim subtototla As Integer = qty * price1
            DataGridView1.Rows.Add(item, qty, price1, subtototla)
        Else
            MessageBox.Show("Please Select an Intem")
        End If
    End Sub
    Dim oldqty As Integer
    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        If Not DataGridView1.CurrentRow Is Nothing Then
            oldqty = DataGridView1.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim newqty As String = DataGridView1.CurrentRow.Cells(1).Value
        If Val(newqty) = oldqty Then
            Exit Sub
        End If
        If Not Regex.IsMatch(newqty.ToString(), "^\d+$") Then
            DataGridView1.CurrentRow.Cells(1).Value = oldqty
        Else
            Dim p As Integer = DataGridView1.CurrentRow.Cells(2).Value
            Dim q As Integer = Val(newqty)
            DataGridView1.CurrentRow.Cells(3).Value = p * q
            Dim newtotal As Integer = 0
            For Each r As DataGridViewRow In DataGridView1.Rows
                newtotal += r.Cells(3).Value
            Next
            total.Text = newtotal
        End If
    End Sub
    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        'this project isn't finished
        PrintPreviewDialog1.Size = Me.Size
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        If PrintPreviewDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim margin As Integer = 40
        Dim currenttop As Integer = 7
        Dim marginbetween = 7
        Dim fnt As New Font("Arial", 28, FontStyle.Bold)
        Dim strno As String = "#no " & invoice.Text
        Dim strdate As String = "التاريخ  " & datetext.Text
        Dim strname As String = "مطلوب من السيد " & Customname.Text
        Dim fontsizeno As SizeF = e.Graphics.MeasureString(strno, fnt)
        Dim g As SizeF = e.Graphics.MeasureString(strname, fnt)
        Dim b As SizeF = e.Graphics.MeasureString(strdate, fnt)
        e.Graphics.DrawImage(My.Resources.pic, margin, margin, 200, 200)

        e.Graphics.DrawString(strno, fnt, Brushes.Red, (e.PageBounds.Width - fontsizeno.Width) / 2, margin)
        currenttop += fontsizeno.Height + marginbetween
        e.Graphics.DrawString(strdate, fnt, Brushes.Black, e.PageBounds.Width - b.Width - margin, currenttop)
        currenttop += b.Width + margin
        e.Graphics.DrawString(strname, fnt, Brushes.Navy, e.PageBounds.Width - g.Width - margin, currenttop - 100)
    End Sub
End Class
