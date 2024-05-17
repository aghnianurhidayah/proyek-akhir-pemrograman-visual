Imports MySql.Data.MySqlClient

Public Class form

    Sub clr()
        txtNik.Clear()
        txtNama.Clear()
        txtTempatLahir.Clear()
        txtAlamat.Clear()
        txtNoHp.Clear()
        dtpTglLahir.Value = DateTime.Today()
        dtpTglVak.Value = DateTime.Today()
        cbProv.SelectedIndex = -1
        cbKK.SelectedIndex = -1
        cbJenVak.SelectedIndex = -1
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        txtNik.Focus()
    End Sub

    Private Sub txtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNik.KeyPress
        txtNik.MaxLength = 16
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHp.KeyPress
        txtNoHp.MaxLength = 12
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDaftarVaksin_Click(sender As Object, e As EventArgs) Handles btnDaftarVaksin.Click
        koneksi()
        If String.IsNullOrWhiteSpace(txtNik.Text) OrElse
           String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtTempatLahir.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoHp.Text) OrElse
           String.IsNullOrWhiteSpace(dtpTglLahir.Text) OrElse
           String.IsNullOrWhiteSpace(dtpTglVak.Text) OrElse
           cbProv.SelectedIndex = -1 OrElse
           cbKK.SelectedIndex = -1 OrElse
           cbJenVak.SelectedIndex = -1 OrElse
           (Not rbLaki.Checked AndAlso Not rbPerempuan.Checked) Then
            MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nik As String = txtNik.Text
        Dim nama As String = txtNama.Text
        Dim tempat_lahir As String = txtTempatLahir.Text
        Dim alamat As String = txtAlamat.Text
        Dim no_hp As String = txtNoHp.Text
        Dim ttl_lahir As String = dtpTglLahir.Value.ToString("yyyy-MM-dd")
        Dim tgl_vaksin As String = dtpTglVak.Value.ToString("yyyy-MM-dd")
        Dim provinsi As String = ""

        If cbProv.SelectedItem IsNot Nothing Then
            provinsi &= cbProv.SelectedItem.ToString
        End If

        Dim kab_kota As String = ""

        If cbKK.SelectedItem IsNot Nothing Then
            kab_kota &= cbKK.SelectedItem.ToString
        End If

        Dim jenis_vaksin As String = ""

        If cbJenVak.SelectedItem IsNot Nothing Then
            jenis_vaksin &= cbJenVak.SelectedItem.ToString
        End If

        Dim jenis_kelamin As String = ""

        If rbLaki.Checked Then
            jenis_kelamin = "Laki-Laki"
        End If

        If rbPerempuan.Checked Then
            jenis_kelamin = "Perempuan"
        End If

        Dim tgl_aju As String = DateTime.Now.ToString("yyyy-MM-dd")

        CMD = New MySqlCommand("Select * from vaccine_form where nik ='" & nik & "' and jenis_vaksin ='" & cbJenVak.Text & "' and status = 'Selesai'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()
            Dim query As String = "INSERT INTO vaccine_form VALUES ('','" & nik & "', '" & nama & "', '" & tempat_lahir & "', '" & alamat & "', '" & no_hp & "', '" & ttl_lahir & "', '" & tgl_vaksin & "', '" & provinsi & "', '" & kab_kota & "', '" & jenis_vaksin & "', '" & jenis_kelamin & "', '" & tgl_aju & "' , 'Proses', '" & login.username & "')"

            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

            CONN.Close()
            MessageBox.Show("Berhasil melakukan pendaftaran!")
            clr()
        Else
            RD.Close()
            MessageBox.Show("Jenis vaksin sudah terdaftar!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dtpTglLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglLahir.ValueChanged
        If dtpTglLahir.Value > DateTime.Now.Date Then
            MessageBox.Show("Tanggal lahir tidak boleh lebih dari tanggal hari ini.", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTglLahir.Value = DateTime.Now.Date
        End If
    End Sub

    Private Sub dtpTglVak_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglVak.ValueChanged
        If dtpTglVak.Value < DateTime.Today Then
            MessageBox.Show("Tanggal tidak boleh sebelum hari ini.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTglVak.Value = DateTime.Today
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        menuuser.Show()
        Me.Close()
    End Sub

    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub cbProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProv.SelectedIndexChanged
        cbKK.SelectedIndex = -1
        If cbProv.SelectedIndex = 0 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Bengkayang")
            cbKK.Items.Add("Kab. Kapuas Hulu")
            cbKK.Items.Add("Kab. Kayong Utara")
            cbKK.Items.Add("Kab. Ketapang")
            cbKK.Items.Add("Kab. Kubu Raya")
            cbKK.Items.Add("Kab. Landak")
            cbKK.Items.Add("Kab. Melawi")
            cbKK.Items.Add("Kab. Mempawah")
            cbKK.Items.Add("Kab. Sambas")
            cbKK.Items.Add("Kab. Sanggau")
            cbKK.Items.Add("Kab. Sekadau")
            cbKK.Items.Add("Kab. Sintang")
            cbKK.Items.Add("Kab. Pontianak")
            cbKK.Items.Add("Kab. Singkawang")
        ElseIf cbProv.SelectedIndex = 1 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Balangan")
            cbKK.Items.Add("Kab. Banjar")
            cbKK.Items.Add("Kab. Barito Kuala")
            cbKK.Items.Add("Kab. Hulu Sungai Selatan")
            cbKK.Items.Add("Kab. Hulu Sungai Tengah")
            cbKK.Items.Add("Kab. Hulu Sungai Utara")
            cbKK.Items.Add("Kab. Kotabaru")
            cbKK.Items.Add("Kab. Tabalong")
            cbKK.Items.Add("Kab. Tanah Bumbu")
            cbKK.Items.Add("Kab. Tanah Laut")
            cbKK.Items.Add("Kab. Tapin")
            cbKK.Items.Add("Kota Banjarbaru")
            cbKK.Items.Add("Kota Banjarmasin")
        ElseIf cbProv.SelectedIndex = 2 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Barito Selatan")
            cbKK.Items.Add("Kab. Barito Timur")
            cbKK.Items.Add("Kab. Barito Utara")
            cbKK.Items.Add("Kab. Gunung Mas")
            cbKK.Items.Add("Kab. Kapuas")
            cbKK.Items.Add("Kab. Katingan")
            cbKK.Items.Add("Kab. Kotawaringin Barat")
            cbKK.Items.Add("Kota Palangkaraya")
        ElseIf cbProv.SelectedIndex = 3 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Berau")
            cbKK.Items.Add("Kab. Kutai Barat")
            cbKK.Items.Add("Kab. Kutai Kartanegara")
            cbKK.Items.Add("Kab. Kutai Timur")
            cbKK.Items.Add("Kab. Mahakam Ulu")
            cbKK.Items.Add("Kab. Paser")
            cbKK.Items.Add("Kab. Penajam Paser Utara")
            cbKK.Items.Add("Kota Balikpapan")
            cbKK.Items.Add("Kota Bontang")
            cbKK.Items.Add("Kota Samarinda")
        ElseIf cbProv.SelectedIndex = 4 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Bulungan")
            cbKK.Items.Add("Kab. Malinau")
            cbKK.Items.Add("Kab. Nunukan")
            cbKK.Items.Add("Kab. Tana Tidung")
            cbKK.Items.Add("Kota Tarakan")
        End If
    End Sub
End Class