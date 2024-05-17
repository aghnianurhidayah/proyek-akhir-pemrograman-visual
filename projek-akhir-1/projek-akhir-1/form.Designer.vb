<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Me.btnDaftarVaksin = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpTglVak = New System.Windows.Forms.DateTimePicker()
        Me.cbJenVak = New System.Windows.Forms.ComboBox()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNik = New System.Windows.Forms.TextBox()
        Me.txtTempatLahir = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbKK = New System.Windows.Forms.ComboBox()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.back = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.btnDaftarVaksin)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dtpTglVak)
        Me.Panel1.Controls.Add(Me.cbJenVak)
        Me.Panel1.Controls.Add(Me.txtNoHp)
        Me.Panel1.Controls.Add(Me.rbPerempuan)
        Me.Panel1.Controls.Add(Me.cbProv)
        Me.Panel1.Controls.Add(Me.rbLaki)
        Me.Panel1.Controls.Add(Me.txtAlamat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(115, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 486)
        Me.Panel1.TabIndex = 13
        '
        'btnDaftarVaksin
        '
        Me.btnDaftarVaksin.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnDaftarVaksin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDaftarVaksin.FlatAppearance.BorderSize = 0
        Me.btnDaftarVaksin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftarVaksin.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftarVaksin.ForeColor = System.Drawing.Color.White
        Me.btnDaftarVaksin.Location = New System.Drawing.Point(826, 425)
        Me.btnDaftarVaksin.Name = "btnDaftarVaksin"
        Me.btnDaftarVaksin.Size = New System.Drawing.Size(187, 42)
        Me.btnDaftarVaksin.TabIndex = 42
        Me.btnDaftarVaksin.Text = "Daftar Vaksinasi"
        Me.btnDaftarVaksin.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(54, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(409, 42)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "FORM PENDAFTARAN VAKSINASI"
        '
        'dtpTglVak
        '
        Me.dtpTglVak.CalendarFont = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglVak.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglVak.Location = New System.Drawing.Point(713, 365)
        Me.dtpTglVak.Name = "dtpTglVak"
        Me.dtpTglVak.Size = New System.Drawing.Size(300, 34)
        Me.dtpTglVak.TabIndex = 40
        '
        'cbJenVak
        '
        Me.cbJenVak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenVak.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenVak.FormattingEnabled = True
        Me.cbJenVak.Items.AddRange(New Object() {"Covid-19", "Tetanus", "Hepatitis", "Influenza", "Rabies", "Polio"})
        Me.cbJenVak.Location = New System.Drawing.Point(713, 266)
        Me.cbJenVak.Name = "cbJenVak"
        Me.cbJenVak.Size = New System.Drawing.Size(300, 39)
        Me.cbJenVak.TabIndex = 38
        '
        'txtNoHp
        '
        Me.txtNoHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoHp.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoHp.HideSelection = False
        Me.txtNoHp.Location = New System.Drawing.Point(384, 365)
        Me.txtNoHp.MaxLength = 13
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(300, 37)
        Me.txtNoHp.TabIndex = 18
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.BackColor = System.Drawing.Color.White
        Me.rbPerempuan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbPerempuan.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerempuan.Location = New System.Drawing.Point(61, 304)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(145, 35)
        Me.rbPerempuan.TabIndex = 35
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = False
        '
        'cbProv
        '
        Me.cbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProv.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.Items.AddRange(New Object() {"Kalimantan Barat", "Kalimantan Selatan", "Kalimantan Tengah", "Kalimantan Timur", "Kalimantan Utara"})
        Me.cbProv.Location = New System.Drawing.Point(713, 101)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(300, 39)
        Me.cbProv.TabIndex = 36
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.BackColor = System.Drawing.Color.White
        Me.rbLaki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbLaki.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLaki.Location = New System.Drawing.Point(61, 274)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(111, 35)
        Me.rbLaki.TabIndex = 34
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = False
        '
        'txtAlamat
        '
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlamat.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.HideSelection = False
        Me.txtAlamat.Location = New System.Drawing.Point(384, 271)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(300, 37)
        Me.txtAlamat.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 31)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(707, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 31)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Kabupaten/Kota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(378, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(707, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 31)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Tanggal Vaksin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(378, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 31)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "No. Handphone"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(707, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 31)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Provinsi"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(378, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 31)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(707, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 31)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Jenis Vaksin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 31)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tanggal Lahir"
        '
        'txtNik
        '
        Me.txtNik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNik.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNik.HideSelection = False
        Me.txtNik.Location = New System.Drawing.Point(172, 245)
        Me.txtNik.MaxLength = 16
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(300, 37)
        Me.txtNik.TabIndex = 14
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTempatLahir.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempatLahir.HideSelection = False
        Me.txtTempatLahir.Location = New System.Drawing.Point(499, 246)
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(300, 37)
        Me.txtTempatLahir.TabIndex = 15
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.HideSelection = False
        Me.txtNama.Location = New System.Drawing.Point(172, 330)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(300, 37)
        Me.txtNama.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 31)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Jenis Kelamin"
        '
        'cbKK
        '
        Me.cbKK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKK.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKK.FormattingEnabled = True
        Me.cbKK.Location = New System.Drawing.Point(828, 330)
        Me.cbKK.Name = "cbKK"
        Me.cbKK.Size = New System.Drawing.Size(300, 39)
        Me.cbKK.TabIndex = 37
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.CalendarFont = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglLahir.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglLahir.Location = New System.Drawing.Point(499, 330)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(300, 34)
        Me.dtpTglLahir.TabIndex = 39
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.arrow
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(21, 361)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(53, 49)
        Me.back.TabIndex = 67
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projek_akhir_1.My.Resources.Resources.Untitled_design__3_
        Me.ClientSize = New System.Drawing.Size(1500, 896)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.cbKK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtTempatLahir)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents cbProv As System.Windows.Forms.ComboBox
    Friend WithEvents cbKK As System.Windows.Forms.ComboBox
    Friend WithEvents cbJenVak As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTglVak As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDaftarVaksin As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents back As System.Windows.Forms.Panel
    Friend WithEvents txtNoHp As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents txtTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
End Class
