Imports MySql.Data.MySqlClient


Public Class login
    Public username As String
    Public nama As String
    Public nik As String

    Private Function checkNull()
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub lblBeranda_Click(sender As Object, e As EventArgs) Handles lblBeranda.Click
        landing.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbDaftar.Click
        regis.Show()
        Me.Close()
    End Sub

    Sub clr()
        txtUsername.Clear()
        txtPass.Clear()
    End Sub

    Private Function verify()
        koneksi()
        If txtUsername.Text = "admin" And txtPass.Text = "admin123" Then
            menuAdmin.Show()
            Return True
        Else
            CMD = New MySqlCommand("Select * from regis_form where username ='" & txtUsername.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If txtUsername.Text = RD("username").ToString() And txtPass.Text = RD("password").ToString() Then
                    username = RD("username").ToString()
                    nama = RD("nama").ToString()
                    nik = RD("nik").ToString()
                    menuuser.Show()
                    RD.Close()
                    Return True
                Else
                    MessageBox.Show("Username dan Password tidak sesuai!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    RD.Close()
                End If
            Else
                RD.Close()
                MessageBox.Show("Username tidak terdaftar! Silahkan lakukan pendaftaran akun.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                clr()
            End If
        End If
        Return False
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If checkNull() Then
            If verify() Then
                Me.Hide()
                MessageBox.Show("Berhasil Login!", "Login Successfully!",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                clr()
            End If
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub cbPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbPass.CheckedChanged
        If cbPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub lbTentang_Click(sender As Object, e As EventArgs) Handles lbTentang.Click
        tentang.Show()
        Me.Close()
    End Sub
End Class