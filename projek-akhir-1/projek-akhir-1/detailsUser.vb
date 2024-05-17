Imports MySql.Data.MySqlClient

Public Class detailsUser

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

    Private Sub detailsUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If history.jenis_kelamin = "Laki-Laki" Then
            rbLaki.Checked = True
        ElseIf history.jenis_kelamin = "Perempuan" Then
            rbPerempuan.Checked = True
        End If
    End Sub

    Private Sub dtpTglLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglLahir.ValueChanged
        If dtpTglLahir.Value > DateTime.Now.Date Then
            MessageBox.Show("Tanggal lahir tidak boleh lebih dari tanggal hari ini.", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTglLahir.Value = DateTime.Now.Date
        End If
    End Sub

    Private Sub dtpTglVak_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglVaksin.ValueChanged
        If dtpTglVaksin.Value < DateTime.Today Then
            MessageBox.Show("Tanggal tidak boleh sebelum hari ini.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTglVaksin.Value = DateTime.Today
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrWhiteSpace(txtNik.Text) OrElse
           String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtTempatLahir.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoHp.Text) OrElse
           String.IsNullOrWhiteSpace(dtpTglLahir.Text) OrElse
           String.IsNullOrWhiteSpace(dtpTglVaksin.Text) OrElse
           (Not rbLaki.Checked AndAlso Not rbPerempuan.Checked) Then
            MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If history.status = "Selesai" Or history.status = "Tolak" Then
            txtNik.ReadOnly = True
            txtNama.ReadOnly = True
            rbLaki.Enabled = False
            rbPerempuan.Enabled = False
            txtTempatLahir.ReadOnly = True
            txtNoHp.ReadOnly = True
            txtAlamat.ReadOnly = True
            cbProvinsi.Enabled = False
            cbKK.Enabled = False
            cbJenVak.Enabled = False
            MessageBox.Show("Form sudah diverifikasi tidak bisa diubah!", "Warning",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim provinsi As String = ""

            If cbProvinsi.SelectedItem IsNot Nothing Then
                provinsi &= cbProvinsi.SelectedItem.ToString
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

            If MessageBox.Show("Apakah Anda yakin ingin mengubah form?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim ubah As String = "update vaccine_form set nik = '" & txtNik.Text & "', nama = '" & txtNama.Text & "', jenis_kelamin = '" & jenis_kelamin & "', tempat_lahir = '" & txtTempatLahir.Text & "', ttl_lahir = '" & dtpTglLahir.Value.ToString("yyyy-MM-dd") & "', no_hp = '" & txtNoHp.Text & "', alamat = '" & txtAlamat.Text & "', provinsi = '" & cbProvinsi.Text & "', kab_kota = '" & cbKK.Text & "', jenis_vaksin = '" & cbJenVak.Text & "', tgl_vaksin = '" & dtpTglVaksin.Value.ToString("yyyy-MM-dd") & "' where id_form = '" & history.id_form & "'"
                CMD = New MySqlCommand(ubah, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Form berhasil diubah!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                history.ReloadData()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If history.status = "Selesai" Or history.status = "Tolak" Then
            MessageBox.Show("Form sudah diverifikasi tidak bisa dihapus!", "Warning",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Apakah Anda yakin ingin membatalkan form?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "delete from vaccine_form where id_form = '" & history.id_form & "'"
                CMD = New MySqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Form berhasil dibatalkan!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                history.ReloadData()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cbProvinsi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvinsi.SelectedIndexChanged
        cbKK.SelectedIndex = -1
        If cbProvinsi.SelectedIndex = 0 Then
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
        ElseIf cbProvinsi.SelectedIndex = 1 Then
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
        ElseIf cbProvinsi.SelectedIndex = 2 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Barito Selatan")
            cbKK.Items.Add("Kab. Barito Timur")
            cbKK.Items.Add("Kab. Barito Utara")
            cbKK.Items.Add("Kab. Gunung Mas")
            cbKK.Items.Add("Kab. Kapuas")
            cbKK.Items.Add("Kab. Katingan")
            cbKK.Items.Add("Kab. Kotawaringin Barat")
            cbKK.Items.Add("Kota Palangkaraya")
        ElseIf cbProvinsi.SelectedIndex = 3 Then
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
        ElseIf cbProvinsi.SelectedIndex = 4 Then
            cbKK.Items.Clear()
            cbKK.Items.Add("Kab. Bulungan")
            cbKK.Items.Add("Kab. Malinau")
            cbKK.Items.Add("Kab. Nunukan")
            cbKK.Items.Add("Kab. Tana Tidung")
            cbKK.Items.Add("Kota Tarakan")
        End If
    End Sub
End Class
