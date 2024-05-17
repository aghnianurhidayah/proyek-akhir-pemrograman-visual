<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdmin
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbVerif = New System.Windows.Forms.Label()
        Me.pnlVerif = New System.Windows.Forms.Panel()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbDataVak = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "VACCINE SPHERE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lbVerif)
        Me.Panel2.Controls.Add(Me.pnlVerif)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(319, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 408)
        Me.Panel2.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 84)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Verifikasi formulir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pendaftaran user " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "untuk cetak sertifikat"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbVerif
        '
        Me.lbVerif.AutoSize = True
        Me.lbVerif.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVerif.Location = New System.Drawing.Point(41, 216)
        Me.lbVerif.Name = "lbVerif"
        Me.lbVerif.Size = New System.Drawing.Size(220, 72)
        Me.lbVerif.TabIndex = 16
        Me.lbVerif.Text = "Verifikasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pendaftaran Vaksin"
        Me.lbVerif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlVerif
        '
        Me.pnlVerif.BackColor = System.Drawing.Color.White
        Me.pnlVerif.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Confirmed_cuate
        Me.pnlVerif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlVerif.Location = New System.Drawing.Point(67, 26)
        Me.pnlVerif.Name = "pnlVerif"
        Me.pnlVerif.Size = New System.Drawing.Size(160, 173)
        Me.pnlVerif.TabIndex = 16
        '
        'pnlData
        '
        Me.pnlData.BackColor = System.Drawing.Color.White
        Me.pnlData.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.File_searching_cuate
        Me.pnlData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlData.Location = New System.Drawing.Point(57, 26)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(193, 186)
        Me.pnlData.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lbDataVak)
        Me.Panel3.Controls.Add(Me.pnlData)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(691, 200)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 408)
        Me.Panel3.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 56)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lihat seluruh data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "formulir vaksinasi"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDataVak
        '
        Me.lbDataVak.AutoSize = True
        Me.lbDataVak.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataVak.Location = New System.Drawing.Point(83, 242)
        Me.lbDataVak.Name = "lbDataVak"
        Me.lbDataVak.Size = New System.Drawing.Size(141, 36)
        Me.lbDataVak.TabIndex = 16
        Me.lbDataVak.Text = "Data Vaksin"
        Me.lbDataVak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(971, 60)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(187, 42)
        Me.btnLogout.TabIndex = 43
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'menuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Untitled_design__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 790)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuAdmin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbVerif As System.Windows.Forms.Label
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbDataVak As System.Windows.Forms.Label
    Friend WithEvents pnlVerif As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
