<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(171, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(334, 291)
        Me.DataGridView1.TabIndex = 32
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SpringGreen
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(16, 384)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 35)
        Me.btnupdate.TabIndex = 31
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Tomato
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(12, 254)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(110, 35)
        Me.search.TabIndex = 30
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnew.BackColor = System.Drawing.Color.Chartreuse
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Black
        Me.btnnew.Location = New System.Drawing.Point(12, 193)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(105, 35)
        Me.btnnew.TabIndex = 29
        Me.btnnew.Text = "VIEW"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(16, 326)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(106, 35)
        Me.btndelete.TabIndex = 28
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Blue
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(12, 128)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(106, 35)
        Me.btnsave.TabIndex = 27
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(171, 61)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(334, 35)
        Me.TextBox1.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cyan
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "CATEGORY NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "CATEGORIES"
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(545, 442)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "category"
        Me.Text = "category"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents search As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
