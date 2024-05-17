Imports MySql.Data.MySqlClient

Public Class detailsAdmin

    Private Sub detailsAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnVerif_Click(sender As Object, e As EventArgs) Handles btnVerif.Click
        MessageBox.Show("Apakah anda yakin ingin verifikasi formulir ini?")
        If MessageBox.Show("Apakah Anda yakin ingin verifikasi form?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim ubah As String = "UPDATE vaccine_form SET status = 'Selesai' WHERE id_form = '" & verify.id_form & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            verify.ReloadData()
            MessageBox.Show("Form berhasil diverifikasi!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnTolak_Click(sender As Object, e As EventArgs) Handles btnTolak.Click
        If MessageBox.Show("Apakah Anda yakin ingin menolak form?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim hapus As String = "UPDATE vaccine_form SET status = 'Tolak' WHERE id_form = '" & verify.id_form & "'"
            CMD = New MySqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            verify.ReloadData()
            MessageBox.Show("Form berhasil ditolak!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class