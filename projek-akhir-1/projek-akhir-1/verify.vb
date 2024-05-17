Imports MySql.Data.MySqlClient

Public Class verify
    Public id_form As String

    Sub ReloadData()
        Dim query As String = "SELECT id_form, nik, nama, tempat_lahir, alamat, no_hp, ttl_lahir, tgl_vaksin, provinsi, kab_kota, jenis_vaksin, jenis_kelamin, tgl_aju FROM vaccine_form WHERE status = 'Proses'"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "vaccine_form")
        dgvVerif.DataSource = DS.Tables("vaccine_form")
        dgvVerif.Refresh()
    End Sub

    Sub aturGrid()
        dgvVerif.Columns(0).HeaderText = "ID Form"
        dgvVerif.Columns(1).HeaderText = "NIK"
        dgvVerif.Columns(2).HeaderText = "Nama Lengkap"
        dgvVerif.Columns(3).HeaderText = "Tempat Lahir"
        dgvVerif.Columns(4).HeaderText = "Alamat"
        dgvVerif.Columns(5).HeaderText = "No Handphone"
        dgvVerif.Columns(6).HeaderText = "Tanggal Lahir"
        dgvVerif.Columns(7).HeaderText = "Tanggal Vaksin"
        dgvVerif.Columns(8).HeaderText = "Provinsi"
        dgvVerif.Columns(9).HeaderText = "Kabupaten/Kota"
        dgvVerif.Columns(10).HeaderText = "Jenis Vaksin"
        dgvVerif.Columns(11).HeaderText = "Jenis Kelamin"
        dgvVerif.Columns(12).HeaderText = "Tanggal Pengajuan"
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text
        Dim query As String = "SELECT * FROM vaccine_form WHERE nama LIKE '%" & keyword & "%' AND status = 'Proses'"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "vaccine_form")
        dgvVerif.DataSource = DS.Tables("vaccine_form")
    End Sub

    Private Sub verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ReloadData()
        aturGrid()
    End Sub

    Private Sub dgvVerif_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVerif.CellClick
        If dgvVerif.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvVerif.SelectedRows(0)
            CMD = New MySqlCommand("Select * from vaccine_form where id_form = '" & row.Cells(0).Value.ToString() & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            id_form = RD("id_form").ToString()
            detailsAdmin.lbNik.Text = RD("nik").ToString()
            detailsAdmin.lbNama.Text = RD("nama").ToString()
            detailsAdmin.lbTempatLahir.Text = RD("tempat_lahir").ToString()
            detailsAdmin.lbAlamat.Text = RD("alamat").ToString()
            detailsAdmin.lbNoHp.Text = RD("no_hp").ToString()
            detailsAdmin.lbTanggalLahir.Text = RD("ttl_lahir").ToShortDateString()
            detailsAdmin.lbTglVak.Text = RD("tgl_vaksin").ToShortDateString()
            detailsAdmin.lbProvinsi.Text = RD("provinsi").ToString()
            detailsAdmin.lbKK.Text = RD("kab_kota").ToString()
            detailsAdmin.lbJenVak.Text = RD("jenis_vaksin").ToString()
            detailsAdmin.lbJenkel.Text = RD("jenis_kelamin").ToString()
            detailsAdmin.lbTglAju.Text = RD("tgl_aju").ToShortDateString()
            RD.Close()
            detailsAdmin.Show()
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        menuAdmin.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class