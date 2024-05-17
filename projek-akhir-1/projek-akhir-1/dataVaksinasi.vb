Imports MySql.Data.MySqlClient

Public Class dataVaksinasi

    Sub ReloadData()
        Dim query As String = "SELECT id_form, nik, nama, tempat_lahir, alamat, no_hp, ttl_lahir, tgl_vaksin, provinsi, kab_kota, jenis_vaksin, jenis_kelamin, tgl_aju, status FROM vaccine_form WHERE status = 'Selesai' OR status = 'Tolak'"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "vaccine_form")
        dgvDataVaksin.DataSource = DS.Tables("vaccine_form")
        dgvDataVaksin.Refresh()
    End Sub

    Public id_form As String

    Sub aturGrid()
        dgvDataVaksin.Columns(0).HeaderText = "ID Form"
        dgvDataVaksin.Columns(1).HeaderText = "NIK"
        dgvDataVaksin.Columns(2).HeaderText = "Nama Lengkap"
        dgvDataVaksin.Columns(3).HeaderText = "Tempat Lahir"
        dgvDataVaksin.Columns(4).HeaderText = "Alamat"
        dgvDataVaksin.Columns(5).HeaderText = "No Handphone"
        dgvDataVaksin.Columns(6).HeaderText = "Tanggal Lahir"
        dgvDataVaksin.Columns(7).HeaderText = "Tanggal Vaksin"
        dgvDataVaksin.Columns(8).HeaderText = "Provinsi"
        dgvDataVaksin.Columns(9).HeaderText = "Kabupaten/Kota"
        dgvDataVaksin.Columns(10).HeaderText = "Jenis Vaksin"
        dgvDataVaksin.Columns(11).HeaderText = "Jenis Kelamin"
        dgvDataVaksin.Columns(12).HeaderText = "Tanggal Pengajuan"
        dgvDataVaksin.Columns(12).HeaderText = "Status"
    End Sub

    Private Sub dataVaksinasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ReloadData()
        aturGrid()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        menuAdmin.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvDataVaksin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataVaksin.CellContentClick

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text
        Dim query As String = "SELECT * FROM vaccine_form WHERE nama LIKE '%" & keyword & "%' AND status = 'Selesai' OR status = 'Tolak'"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DA.Fill(DS, "vaccine_form")
        dgvDataVaksin.DataSource = DS.Tables("vaccine_form")
    End Sub
End Class