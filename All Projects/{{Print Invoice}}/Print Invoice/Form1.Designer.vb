<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.invoice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datetext = New System.Windows.Forms.TextBox()
        Me.Customname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.print = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(311, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة الفـــاتـــــورة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Underline)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(443, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Powred By 6aha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(-3, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "رقم الفاتورة : "
        '
        'invoice
        '
        Me.invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.invoice.ForeColor = System.Drawing.Color.Firebrick
        Me.invoice.Location = New System.Drawing.Point(151, 93)
        Me.invoice.Name = "invoice"
        Me.invoice.Size = New System.Drawing.Size(230, 30)
        Me.invoice.TabIndex = 3
        Me.invoice.Text = "000001"
        Me.invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(408, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "التــــاريــــخ :"
        '
        'datetext
        '
        Me.datetext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datetext.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.datetext.Location = New System.Drawing.Point(532, 96)
        Me.datetext.Name = "datetext"
        Me.datetext.Size = New System.Drawing.Size(213, 30)
        Me.datetext.TabIndex = 3
        Me.datetext.Text = "01/01/0001"
        Me.datetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Customname
        '
        Me.Customname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Customname.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Customname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Customname.Location = New System.Drawing.Point(151, 166)
        Me.Customname.Name = "Customname"
        Me.Customname.Size = New System.Drawing.Size(594, 30)
        Me.Customname.TabIndex = 5
        Me.Customname.Text = "غير معروف"
        Me.Customname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(14, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "اسم العميل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(-3, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1474, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_________________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(17, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "السعر :"
        '
        'Price
        '
        Me.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Price.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Price.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Price.Location = New System.Drawing.Point(110, 267)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(130, 30)
        Me.Price.TabIndex = 5
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(14, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "الصنف :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(284, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "الكمية :"
        '
        'Quantity
        '
        Me.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Quantity.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Quantity.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Quantity.Location = New System.Drawing.Point(377, 267)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(136, 30)
        Me.Quantity.TabIndex = 5
        Me.Quantity.Text = "1"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 229)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(408, 31)
        Me.ComboBox1.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colitem, Me.colqty, Me.colprice, Me.colsubtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(1, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(910, 179)
        Me.DataGridView1.TabIndex = 8
        '
        'colitem
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colitem.DefaultCellStyle = DataGridViewCellStyle1
        Me.colitem.HeaderText = "الصنف"
        Me.colitem.Name = "colitem"
        Me.colitem.ReadOnly = True
        '
        'colqty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colqty.DefaultCellStyle = DataGridViewCellStyle2
        Me.colqty.HeaderText = "الكمية"
        Me.colqty.Name = "colqty"
        '
        'colprice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colprice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colprice.HeaderText = "السعر"
        Me.colprice.Name = "colprice"
        Me.colprice.ReadOnly = True
        '
        'colsubtotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colsubtotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.colsubtotal.HeaderText = "الاجمالي الفرعي"
        Me.colsubtotal.Name = "colsubtotal"
        Me.colsubtotal.ReadOnly = True
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.total.ForeColor = System.Drawing.Color.Yellow
        Me.total.Location = New System.Drawing.Point(586, 267)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(167, 30)
        Me.total.TabIndex = 10
        Me.total.Text = "0000000"
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(587, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "الاجمالي الكلي"
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.RoyalBlue
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Location = New System.Drawing.Point(759, 237)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(70, 60)
        Me.Add.TabIndex = 11
        Me.Add.Text = "اضافة"
        Me.Add.UseVisualStyleBackColor = False
        '
        'print
        '
        Me.print.BackColor = System.Drawing.Color.RoyalBlue
        Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print.Location = New System.Drawing.Point(835, 237)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(70, 60)
        Me.print.TabIndex = 11
        Me.print.Text = "طباعة"
        Me.print.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(923, 485)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Customname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datetext)
        Me.Controls.Add(Me.invoice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الفاتورة"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents invoice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datetext As System.Windows.Forms.TextBox
    Friend WithEvents Customname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Price As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents colitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
