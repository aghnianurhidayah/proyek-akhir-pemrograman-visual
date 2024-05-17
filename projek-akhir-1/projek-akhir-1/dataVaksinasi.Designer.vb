<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataVaksinasi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDataVaksin = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Panel()
        CType(Me.dgvDataVaksin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 42)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "DATA VAKSINASI"
        '
        'dgvDataVaksin
        '
        Me.dgvDataVaksin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDataVaksin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataVaksin.GridColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDataVaksin.Location = New System.Drawing.Point(179, 252)
        Me.dgvDataVaksin.Name = "dgvDataVaksin"
        Me.dgvDataVaksin.RowTemplate.Height = 28
        Me.dgvDataVaksin.Size = New System.Drawing.Size(952, 343)
        Me.dgvDataVaksin.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(80, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 56)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "VACCINE SPHERE"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.M__6_
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(40, 38)
        Me.Panel3.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtCari)
        Me.Panel2.Location = New System.Drawing.Point(856, 204)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(275, 40)
        Me.Panel2.TabIndex = 61
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCari.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCari.Location = New System.Drawing.Point(46, 8)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(224, 30)
        Me.txtCari.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(121, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 511)
        Me.Panel1.TabIndex = 63
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.arrow
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(31, 368)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(53, 49)
        Me.back.TabIndex = 64
        '
        'dataVaksinasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Untitled_design__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 750)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDataVaksin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "dataVaksinasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dataVaksinasi"
        CType(Me.dgvDataVaksin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDataVaksin As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents back As System.Windows.Forms.Panel
End Class
