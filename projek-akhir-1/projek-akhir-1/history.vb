Imports MySql.Data.MySqlClient
Public Class history

    Public id_form As String
    Public jenis_kelamin As String
    Public status As String

    Sub aturGrid()
        dgvRiwayat.Columns(0).HeaderText = "ID Form"
        dgvRiwayat.Columns(1).HeaderText = "NIK"
        dgvRiwayat.Columns(2).HeaderText = "Nama Lengkap"
        dgvRiwayat.Columns(3).HeaderText = "Jenis Vaksin"
        dgvRiwayat.Columns(4).HeaderText = "Tanggal Pengajuan"
        dgvRiwayat.Columns(5).HeaderText = "Tanggal Vaksinasi"
        dgvRiwayat.Columns(6).HeaderText = "Status"
    End Sub

    Public Sub ReloadData()
        Dim query As String = "SELECT id_form, nik, nama, jenis_vaksin, tgl_aju, tgl_vaksin, status FROM vaccine_form WHERE user = '" & login.username & "'"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "vaccine_form")
        dgvRiwayat.DataSource = DS.Tables("vaccine_form")
        dgvRiwayat.Refresh()
    End Sub

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ReloadData()
        aturGrid()
    End Sub

    Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
        If dgvRiwayat.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvRiwayat.SelectedRows(0)
            CMD = New MySqlCommand("Select * from vaccine_form where id_form = '" & row.Cells(0).Value.ToString() & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            id_form = RD("id_form").ToString()
            jenis_kelamin = RD("jenis_kelamin").ToString()
            status = RD("status").ToString()
            detailsUser.txtNik.Text = RD("nik").ToString()
            detailsUser.txtNama.Text = RD("nama").ToString()
            detailsUser.txtTempatLahir.Text = RD("tempat_lahir").ToString()
            detailsUser.dtpTglLahir.Value = Convert.ToDateTime(RD("ttl_lahir"))
            detailsUser.txtNoHp.Text = RD("no_hp").ToString()
            detailsUser.txtAlamat.Text = RD("alamat").ToString()
            detailsUser.cbProvinsi.Text = RD("provinsi").ToString()
            detailsUser.cbKK.Text = RD("kab_kota").ToString()
            detailsUser.cbJenVak.Text = RD("jenis_vaksin").ToString()
            detailsUser.dtpTglVaksin.Value = Convert.ToDateTime(RD("tgl_vaksin"))
            detailsUser.txtTglAju.Text = Convert.ToDateTime(RD("tgl_aju"))
            RD.Close()
            detailsUser.Show()
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        menuuser.Show()
        Me.Close()
    End Sub

End Class