<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.btnborrrow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnoverdue = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btncategories = New System.Windows.Forms.Button()
        Me.btnudermgt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnborrower = New System.Windows.Forms.Button()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnborrrow
        '
        Me.btnborrrow.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnborrrow.ForeColor = System.Drawing.Color.Red
        Me.btnborrrow.Location = New System.Drawing.Point(-5, 124)
        Me.btnborrrow.Name = "btnborrrow"
        Me.btnborrrow.Size = New System.Drawing.Size(198, 40)
        Me.btnborrrow.TabIndex = 12
        Me.btnborrrow.Text = "BORRROW"
        Me.btnborrrow.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(44, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 31)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Library Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnborrrow)
        Me.GroupBox4.Controls.Add(Me.PictureBox9)
        Me.GroupBox4.Controls.Add(Me.PictureBox8)
        Me.GroupBox4.Controls.Add(Me.PictureBox7)
        Me.GroupBox4.Controls.Add(Me.btnoverdue)
        Me.GroupBox4.Controls.Add(Me.btnreturn)
        Me.GroupBox4.Location = New System.Drawing.Point(43, 299)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 189)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TRANSACTION"
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(403, 19)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(197, 99)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(199, 19)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(198, 99)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(7, 19)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(186, 99)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'btnoverdue
        '
        Me.btnoverdue.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnoverdue.ForeColor = System.Drawing.Color.Red
        Me.btnoverdue.Location = New System.Drawing.Point(403, 124)
        Me.btnoverdue.Name = "btnoverdue"
        Me.btnoverdue.Size = New System.Drawing.Size(197, 40)
        Me.btnoverdue.TabIndex = 8
        Me.btnoverdue.Text = "OVERDUE"
        Me.btnoverdue.UseVisualStyleBackColor = False
        '
        'btnreturn
        '
        Me.btnreturn.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnreturn.ForeColor = System.Drawing.Color.Red
        Me.btnreturn.Location = New System.Drawing.Point(199, 124)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(198, 40)
        Me.btnreturn.TabIndex = 7
        Me.btnreturn.Text = "RETURNS"
        Me.btnreturn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox6)
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Location = New System.Drawing.Point(665, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 389)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "REPORTS"
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(27, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(219, 118)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(38, 207)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(219, 117)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button9.ForeColor = System.Drawing.Color.Red
        Me.Button9.Location = New System.Drawing.Point(38, 330)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(219, 40)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "LOG OUT"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Location = New System.Drawing.Point(27, 142)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(219, 40)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "LIST OF BOOK"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.btncategories)
        Me.GroupBox2.Controls.Add(Me.btnudermgt)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 175)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UTILITIES"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(147, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(144, 104)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 104)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'btncategories
        '
        Me.btncategories.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btncategories.ForeColor = System.Drawing.Color.Red
        Me.btncategories.Location = New System.Drawing.Point(147, 129)
        Me.btncategories.Name = "btncategories"
        Me.btncategories.Size = New System.Drawing.Size(143, 40)
        Me.btncategories.TabIndex = 7
        Me.btncategories.Text = "CATELOGORIES"
        Me.btncategories.UseVisualStyleBackColor = False
        '
        'btnudermgt
        '
        Me.btnudermgt.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnudermgt.ForeColor = System.Drawing.Color.Red
        Me.btnudermgt.Location = New System.Drawing.Point(0, 129)
        Me.btnudermgt.Name = "btnudermgt"
        Me.btnudermgt.Size = New System.Drawing.Size(132, 40)
        Me.btnudermgt.TabIndex = 6
        Me.btnudermgt.Text = "USER MANAGER"
        Me.btnudermgt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnborrower)
        Me.GroupBox1.Controls.Add(Me.btnbook)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 175)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA MANAGEMENT"
        '
        'btnborrower
        '
        Me.btnborrower.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnborrower.ForeColor = System.Drawing.Color.Red
        Me.btnborrower.Location = New System.Drawing.Point(145, 129)
        Me.btnborrower.Name = "btnborrower"
        Me.btnborrower.Size = New System.Drawing.Size(132, 40)
        Me.btnborrower.TabIndex = 6
        Me.btnborrower.Text = "BORROWER"
        Me.btnborrower.UseVisualStyleBackColor = False
        '
        'btnbook
        '
        Me.btnbook.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnbook.ForeColor = System.Drawing.Color.Red
        Me.btnbook.Location = New System.Drawing.Point(7, 129)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(132, 40)
        Me.btnbook.TabIndex = 5
        Me.btnbook.Text = "BOOKS"
        Me.btnbook.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(145, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(133, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(581, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Label2"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(984, 513)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnborrrow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnoverdue As Button
    Friend WithEvents btnreturn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btncategories As Button
    Friend WithEvents btnudermgt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnborrower As Button
    Friend WithEvents btnbook As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class
