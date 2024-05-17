Imports MySql.Data.MySqlClient

Public Class certificate
    Public nama As String
    Public nik As String
    Public tglLhr As String
    Public idSertif As String
    Public jenVak As String
    Public tglVak As String

    Sub grid()
        dgvSertif.Columns(0).HeaderText = "ID Form"
        dgvSertif.Columns(1).HeaderText = "NIK"
        dgvSertif.Columns(2).HeaderText = "Nama Lengkap"
        dgvSertif.Columns(3).HeaderText = "Tanggal Lahir"
        dgvSertif.Columns(4).HeaderText = "Tanggal Vaksin"
        dgvSertif.Columns(5).HeaderText = "Jenis Vaksin"
    End Sub

    Sub ReloadData()
        Dim query As String = "SELECT id_form, nik, nama, ttl_lahir, tgl_vaksin, jenis_vaksin FROM vaccine_form WHERE user ='" & login.username & "' and status = 'Selesai'"
        CMD = New MySqlCommand(query, CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet()
        DS.Clear()
        DA.Fill(DS, "vaccine_form")
        dgvSertif.DataSource = DS.Tables("vaccine_form")
        dgvSertif.Refresh()
    End Sub

    Private Sub certificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ReloadData()
        grid()

        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("A4", 827, 1169)
        PrintDocument1.DefaultPageSettings.Landscape = True
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    Private Sub dgvSertif_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSertif.CellClick
        If dgvSertif.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvSertif.SelectedRows(0)
            CMD = New MySqlCommand("Select id_form, nik, nama, ttl_lahir, tgl_vaksin, jenis_vaksin from vaccine_form where id_form = '" & row.Cells(0).Value.ToString() & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            idSertif = RD("id_form").ToString()
            nik = RD("nik").ToString()
            nama = RD("nama").ToString()
            tglLhr = RD("ttl_lahir").ToShortDateString()
            tglLhr = RD("ttl_lahir").ToShortDateString()
            tglVak = RD("tgl_vaksin").ToShortDateString()
            jenVak = RD("jenis_vaksin").ToString()
            If MessageBox.Show("Apakah anda ingin mencetak sertifikat?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.PrintPreviewDialog1.ShowDialog()
            End If
            RD.Close()
        End If
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        koneksi()
        Dim hitam As SolidBrush = New SolidBrush(Color.Black)
        Dim putih As SolidBrush = New SolidBrush(Color.White)
        Dim hijau As SolidBrush = New SolidBrush(Color.FromArgb(51, 104, 98))
        Dim poppins1 As Font = New Font("Poppins", 18, FontStyle.Regular)
        Dim poppins2 As Font = New Font("Poppins", 24, FontStyle.Bold)
        Dim poppins3 As Font = New Font("Poppins", 24)
        Dim poppins4 As Font = New Font("Poppins", 45, FontStyle.Bold)
        Dim row As DataGridViewRow = dgvSertif.SelectedRows(0)

        Dim newImage As Image = Image.FromFile("C:\Users\MSI\Downloads\sertifback.jpg")
        e.Graphics.DrawImage(newImage, e.PageBounds)
        e.Graphics.DrawString("VACCINE SPHERE", poppins2, hijau, 44, 38)
        e.Graphics.DrawString("SERTIFIKAT VAKSINASI", poppins4, hijau, 210, 150)
        e.Graphics.DrawString("Sertifikat ini diberikan kepada:", poppins3, hitam, 335, 257)
        e.Graphics.DrawString(nama, poppins3, putih, 430, 342)
        e.Graphics.DrawString("NIK", poppins3, putih, 230, 412)
        e.Graphics.DrawString(nik, poppins3, putih, 230, 460)
        e.Graphics.DrawString("Tanggal Lahir", poppins3, putih, 629, 412)
        e.Graphics.DrawString(tglLhr, poppins3, putih, 629, 460)
        e.Graphics.DrawString("ID Sertifikat: " + idSertif, poppins1, hitam, 480, 535)
        e.Graphics.DrawString("Telah melaksanakan vaksinasi " + jenVak + " pada tanggal: ", poppins3, hitam, 110, 595)
        e.Graphics.DrawString(tglVak, poppins3, hitam, 475, 640)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        menuuser.Show()
        Me.Close()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        menuuser.Show()
        Me.Close()
    End Sub

End Class