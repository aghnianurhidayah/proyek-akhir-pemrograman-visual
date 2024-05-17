<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvRiwayat = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "VACCINE SPHERE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvRiwayat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(121, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 526)
        Me.Panel1.TabIndex = 13
        '
        'dgvRiwayat
        '
        Me.dgvRiwayat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayat.GridColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvRiwayat.Location = New System.Drawing.Point(62, 90)
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.RowTemplate.Height = 28
        Me.dgvRiwayat.Size = New System.Drawing.Size(952, 387)
        Me.dgvRiwayat.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 42)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "RIWAYAT PENDAFTARAN VAKSINASI"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.arrow
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(32, 369)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(53, 49)
        Me.back.TabIndex = 67
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Untitled_design__3_
        Me.ClientSize = New System.Drawing.Size(1500, 896)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "history"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvRiwayat As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.Panel
End Class
