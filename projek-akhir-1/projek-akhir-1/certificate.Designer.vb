<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class certificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(certificate))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvSertif = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.back = New System.Windows.Forms.Panel()
        CType(Me.dgvSertif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(80, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 56)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "VACCINE SPHERE"
        '
        'dgvSertif
        '
        Me.dgvSertif.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvSertif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSertif.GridColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvSertif.Location = New System.Drawing.Point(52, 83)
        Me.dgvSertif.Name = "dgvSertif"
        Me.dgvSertif.RowTemplate.Height = 28
        Me.dgvSertif.Size = New System.Drawing.Size(874, 387)
        Me.dgvSertif.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(250, 42)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "SERTIFIKAT VAKSIN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dgvSertif)
        Me.Panel1.Location = New System.Drawing.Point(156, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 508)
        Me.Panel1.TabIndex = 31
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.arrow
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(54, 374)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(53, 49)
        Me.back.TabIndex = 66
        '
        'certificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Untitled_design__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1478, 840)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "certificate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "certificate"
        CType(Me.dgvSertif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvSertif As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents back As System.Windows.Forms.Panel
End Class
