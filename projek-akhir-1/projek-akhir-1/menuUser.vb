Imports MySql.Data.MySqlClient

Public Class menuuser

    Function checkSertif()
        koneksi()
        CMD = New MySqlCommand("Select * from vaccine_form where user = '" & login.username & "' and status = 'Selesai'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Return True
        Else
            MessageBox.Show("Belum ada sertifikat!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Show()
            Return False
        End If
        RD.Close()
    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbDaftarVak.Click
        form.Show()
        Me.Close()
    End Sub

    Private Sub menuuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = login.nama
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        form.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        If checkSertif() Then
            certificate.Show()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        login.username = ""
        login.nama = ""
        login.nik = ""
        login.clr()
        login.Show()
        Me.Close()
    End Sub

    Private Sub pnlDaftarVak_Click(sender As Object, e As EventArgs) Handles pnlDaftarVak.Click
        form.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        form.Show()
        Me.Close()
    End Sub

    Private Sub pnlRiwayat_Click(sender As Object, e As EventArgs) Handles pnlRiwayat.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub lbRiwayat_Click(sender As Object, e As EventArgs) Handles lbRiwayat.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub pnlSertif_Click(sender As Object, e As EventArgs) Handles pnlSertif.Click
        If checkSertif() Then
            certificate.Show()
        End If
    End Sub

    Private Sub lbSertif_Click(sender As Object, e As EventArgs) Handles lbSertif.Click
        If checkSertif() Then
            certificate.Show()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If checkSertif() Then
            certificate.Show()
        End If
    End Sub

End Class