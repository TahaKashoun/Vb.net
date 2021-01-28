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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Fontname = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.size = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.bold = New System.Windows.Forms.CheckBox()
        Me.underline = New System.Windows.Forms.CheckBox()
        Me.italic = New System.Windows.Forms.CheckBox()
        Me.P2 = New System.Windows.Forms.Panel()
        Me.P6 = New System.Windows.Forms.Panel()
        Me.rdtext = New System.Windows.Forms.RadioButton()
        Me.Background = New System.Windows.Forms.RadioButton()
        Me.P5 = New System.Windows.Forms.Panel()
        Me.P1 = New System.Windows.Forms.Panel()
        Me.p7 = New System.Windows.Forms.Panel()
        Me.P3 = New System.Windows.Forms.Panel()
        Me.p8 = New System.Windows.Forms.Panel()
        Me.P4 = New System.Windows.Forms.Panel()
        Me.morecolors = New System.Windows.Forms.Button()
        Me.additionalcolor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(892, 346)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 348)
        Me.Panel1.TabIndex = 1
        '
        'Fontname
        '
        Me.Fontname.AutoSize = True
        Me.Fontname.Location = New System.Drawing.Point(7, 9)
        Me.Fontname.Name = "Fontname"
        Me.Fontname.Size = New System.Drawing.Size(118, 27)
        Me.Fontname.TabIndex = 1
        Me.Fontname.Text = "Font Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(4, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 33)
        Me.ComboBox1.TabIndex = 2
        '
        'size
        '
        Me.size.AutoSize = True
        Me.size.Location = New System.Drawing.Point(194, 11)
        Me.size.Name = "size"
        Me.size.Size = New System.Drawing.Size(86, 27)
        Me.size.TabIndex = 3
        Me.size.Text = "textsize"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(177, 41)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(96, 33)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'bold
        '
        Me.bold.AutoSize = True
        Me.bold.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.bold.Location = New System.Drawing.Point(278, 41)
        Me.bold.Name = "bold"
        Me.bold.Size = New System.Drawing.Size(81, 31)
        Me.bold.TabIndex = 1
        Me.bold.Text = "Bold"
        Me.bold.UseVisualStyleBackColor = True
        '
        'underline
        '
        Me.underline.AutoSize = True
        Me.underline.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Underline)
        Me.underline.Location = New System.Drawing.Point(356, 41)
        Me.underline.Name = "underline"
        Me.underline.Size = New System.Drawing.Size(123, 31)
        Me.underline.TabIndex = 5
        Me.underline.Text = "Underline"
        Me.underline.UseVisualStyleBackColor = True
        '
        'italic
        '
        Me.italic.AutoSize = True
        Me.italic.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Italic)
        Me.italic.Location = New System.Drawing.Point(475, 43)
        Me.italic.Name = "italic"
        Me.italic.Size = New System.Drawing.Size(78, 31)
        Me.italic.TabIndex = 1
        Me.italic.Text = "Italic"
        Me.italic.UseVisualStyleBackColor = True
        '
        'P2
        '
        Me.P2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P2.Location = New System.Drawing.Point(675, 12)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(30, 30)
        Me.P2.TabIndex = 6
        '
        'P6
        '
        Me.P6.BackColor = System.Drawing.SystemColors.Desktop
        Me.P6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P6.Location = New System.Drawing.Point(675, 48)
        Me.P6.Name = "P6"
        Me.P6.Size = New System.Drawing.Size(30, 30)
        Me.P6.TabIndex = 7
        '
        'rdtext
        '
        Me.rdtext.AutoSize = True
        Me.rdtext.Checked = True
        Me.rdtext.Location = New System.Drawing.Point(550, 11)
        Me.rdtext.Name = "rdtext"
        Me.rdtext.Size = New System.Drawing.Size(73, 31)
        Me.rdtext.TabIndex = 0
        Me.rdtext.TabStop = True
        Me.rdtext.Text = "Text"
        Me.rdtext.UseVisualStyleBackColor = True
        '
        'Background
        '
        Me.Background.AutoSize = True
        Me.Background.Location = New System.Drawing.Point(550, 42)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(88, 31)
        Me.Background.TabIndex = 0
        Me.Background.Text = "Backg"
        Me.Background.UseVisualStyleBackColor = True
        '
        'P5
        '
        Me.P5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P5.Location = New System.Drawing.Point(639, 48)
        Me.P5.Name = "P5"
        Me.P5.Size = New System.Drawing.Size(30, 30)
        Me.P5.TabIndex = 9
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Yellow
        Me.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P1.Location = New System.Drawing.Point(639, 12)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(30, 30)
        Me.P1.TabIndex = 8
        '
        'p7
        '
        Me.p7.BackColor = System.Drawing.Color.Teal
        Me.p7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p7.Location = New System.Drawing.Point(708, 48)
        Me.p7.Name = "p7"
        Me.p7.Size = New System.Drawing.Size(30, 30)
        Me.p7.TabIndex = 13
        '
        'P3
        '
        Me.P3.BackColor = System.Drawing.Color.Blue
        Me.P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P3.Location = New System.Drawing.Point(708, 12)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(30, 30)
        Me.P3.TabIndex = 12
        '
        'p8
        '
        Me.p8.BackColor = System.Drawing.Color.Maroon
        Me.p8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p8.Location = New System.Drawing.Point(744, 48)
        Me.p8.Name = "p8"
        Me.p8.Size = New System.Drawing.Size(30, 30)
        Me.p8.TabIndex = 11
        '
        'P4
        '
        Me.P4.BackColor = System.Drawing.Color.Red
        Me.P4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P4.Location = New System.Drawing.Point(744, 12)
        Me.P4.Name = "P4"
        Me.P4.Size = New System.Drawing.Size(30, 30)
        Me.P4.TabIndex = 10
        '
        'morecolors
        '
        Me.morecolors.BackColor = System.Drawing.Color.Blue
        Me.morecolors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.morecolors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.morecolors.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.morecolors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.morecolors.Location = New System.Drawing.Point(780, 11)
        Me.morecolors.Name = "morecolors"
        Me.morecolors.Size = New System.Drawing.Size(111, 32)
        Me.morecolors.TabIndex = 14
        Me.morecolors.Text = "More Colors"
        Me.morecolors.UseVisualStyleBackColor = False
        '
        'additionalcolor
        '
        Me.additionalcolor.BackColor = System.Drawing.Color.Maroon
        Me.additionalcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.additionalcolor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.additionalcolor.Location = New System.Drawing.Point(780, 49)
        Me.additionalcolor.Name = "additionalcolor"
        Me.additionalcolor.Size = New System.Drawing.Size(111, 29)
        Me.additionalcolor.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(918, 475)
        Me.Controls.Add(Me.morecolors)
        Me.Controls.Add(Me.p7)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.additionalcolor)
        Me.Controls.Add(Me.p8)
        Me.Controls.Add(Me.P4)
        Me.Controls.Add(Me.P5)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.Background)
        Me.Controls.Add(Me.rdtext)
        Me.Controls.Add(Me.P6)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.italic)
        Me.Controls.Add(Me.underline)
        Me.Controls.Add(Me.bold)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.size)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Fontname)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Fontname As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents size As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents bold As System.Windows.Forms.CheckBox
    Friend WithEvents underline As System.Windows.Forms.CheckBox
    Friend WithEvents italic As System.Windows.Forms.CheckBox
    Friend WithEvents P2 As System.Windows.Forms.Panel
    Friend WithEvents P6 As System.Windows.Forms.Panel
    Friend WithEvents rdtext As System.Windows.Forms.RadioButton
    Friend WithEvents Background As System.Windows.Forms.RadioButton
    Friend WithEvents P5 As System.Windows.Forms.Panel
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents p7 As System.Windows.Forms.Panel
    Friend WithEvents P3 As System.Windows.Forms.Panel
    Friend WithEvents p8 As System.Windows.Forms.Panel
    Friend WithEvents P4 As System.Windows.Forms.Panel
    Friend WithEvents morecolors As System.Windows.Forms.Button
    Friend WithEvents additionalcolor As System.Windows.Forms.Panel

End Class
