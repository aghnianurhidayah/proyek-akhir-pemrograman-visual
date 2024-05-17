<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuuser
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbDaftarVak = New System.Windows.Forms.Label()
        Me.pnlDaftarVak = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbRiwayat = New System.Windows.Forms.Label()
        Me.pnlRiwayat = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbSertif = New System.Windows.Forms.Label()
        Me.pnlSertif = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
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
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "VACCINE SPHERE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbDaftarVak)
        Me.Panel1.Controls.Add(Me.pnlDaftarVak)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(155, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 374)
        Me.Panel1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 84)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Daftar Vaksin dengan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mengisi Formulir Pendaftaran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dengan data diri Anda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDaftarVak
        '
        Me.lbDaftarVak.AutoSize = True
        Me.lbDaftarVak.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDaftarVak.Location = New System.Drawing.Point(71, 220)
        Me.lbDaftarVak.Name = "lbDaftarVak"
        Me.lbDaftarVak.Size = New System.Drawing.Size(157, 36)
        Me.lbDaftarVak.TabIndex = 15
        Me.lbDaftarVak.Text = "Daftar Vaksin"
        '
        'pnlDaftarVak
        '
        Me.pnlDaftarVak.BackColor = System.Drawing.Color.White
        Me.pnlDaftarVak.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Forms_cuate
        Me.pnlDaftarVak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlDaftarVak.Location = New System.Drawing.Point(76, 39)
        Me.pnlDaftarVak.Name = "pnlDaftarVak"
        Me.pnlDaftarVak.Size = New System.Drawing.Size(143, 153)
        Me.pnlDaftarVak.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lbRiwayat)
        Me.Panel2.Controls.Add(Me.pnlRiwayat)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(490, 202)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 374)
        Me.Panel2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 56)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Lihat riwayat pendaftaran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vaksin yang telah Anda isi"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbRiwayat
        '
        Me.lbRiwayat.AutoSize = True
        Me.lbRiwayat.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRiwayat.Location = New System.Drawing.Point(31, 209)
        Me.lbRiwayat.Name = "lbRiwayat"
        Me.lbRiwayat.Size = New System.Drawing.Size(220, 72)
        Me.lbRiwayat.TabIndex = 16
        Me.lbRiwayat.Text = "Riwayat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pendaftaran Vaksin"
        Me.lbRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRiwayat
        '
        Me.pnlRiwayat.BackColor = System.Drawing.Color.White
        Me.pnlRiwayat.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.File_searching_cuate
        Me.pnlRiwayat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRiwayat.Location = New System.Drawing.Point(48, 12)
        Me.pnlRiwayat.Name = "pnlRiwayat"
        Me.pnlRiwayat.Size = New System.Drawing.Size(192, 189)
        Me.pnlRiwayat.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lbSertif)
        Me.Panel3.Controls.Add(Me.pnlSertif)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(825, 202)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 374)
        Me.Panel3.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 84)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lihat dan cetak " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sertifikat vaksin sebagai" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bukti vaksinasi"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSertif
        '
        Me.lbSertif.AutoSize = True
        Me.lbSertif.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSertif.Location = New System.Drawing.Point(50, 220)
        Me.lbSertif.Name = "lbSertif"
        Me.lbSertif.Size = New System.Drawing.Size(184, 36)
        Me.lbSertif.TabIndex = 16
        Me.lbSertif.Text = "Sertifikat Vaksin"
        Me.lbSertif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSertif
        '
        Me.pnlSertif.BackColor = System.Drawing.Color.White
        Me.pnlSertif.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Certification_pana
        Me.pnlSertif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSertif.Location = New System.Drawing.Point(48, 26)
        Me.pnlSertif.Name = "pnlSertif"
        Me.pnlSertif.Size = New System.Drawing.Size(191, 166)
        Me.pnlSertif.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 36)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Selamat Datang, "
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(286, 106)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(97, 36)
        Me.lblNama.TabIndex = 18
        Me.lblNama.Text = "{nama}"
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
        Me.btnLogout.TabIndex = 44
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'menuuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Untitled_design__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1478, 840)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(1500, 896)
        Me.Name = "menuuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbDaftarVak As System.Windows.Forms.Label
    Friend WithEvents pnlDaftarVak As System.Windows.Forms.Panel
    Friend WithEvents lbRiwayat As System.Windows.Forms.Label
    Friend WithEvents pnlRiwayat As System.Windows.Forms.Panel
    Friend WithEvents lbSertif As System.Windows.Forms.Label
    Friend WithEvents pnlSertif As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
