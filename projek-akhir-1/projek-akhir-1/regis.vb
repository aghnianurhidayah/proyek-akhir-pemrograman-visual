Imports MySql.Data.MySqlClient

Public Class regis

    Private Sub txtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNik.KeyPress
        txtNik.MaxLength = 16
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        txtNoTelp.MaxLength = 12
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function checkNIK()
        CMD = New MySqlCommand("Select * from regis_form where nik ='" & txtNik.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            MessageBox.Show("NIK sudah terdaftar!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RD.Close()
            Return False
        Else
            RD.Close()
            Return True
        End If
    End Function

    Function checkUsername()
        CMD = New MySqlCommand("Select * from regis_form where username ='" & txtUsername.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            MessageBox.Show("Username sudah terdaftar!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RD.Close()
            Return False
        Else
            RD.Close()
            Return True
        End If
    End Function

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        koneksi()
        If String.IsNullOrWhiteSpace(txtNik.Text) OrElse
             String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
             String.IsNullOrWhiteSpace(txtNama.Text) OrElse
             String.IsNullOrWhiteSpace(txtNoTelp.Text) OrElse
             String.IsNullOrWhiteSpace(dtpTglLahir.Text) OrElse
             String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
             String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("Tidak boleh ada data yang kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If checkNIK() Then
                If checkUsername() Then
                    Dim nik As String = txtNik.Text
                    Dim email As String = txtEmail.Text
                    Dim nama As String = txtNama.Text
                    Dim no_telp As String = txtNoTelp.Text
                    Dim username As String = txtUsername.Text
                    Dim tgl_lahir As String = dtpTglLahir.Value.ToString("yyyy-MM-dd")
                    Dim password As String = txtPass.Text

                    Dim query As String = "INSERT INTO regis_form (nik, email, nama, no_telp, tgl_lahir, username, password) VALUES ('" & nik & "', '" & email & "', '" & nama & "', '" & no_telp & "', '" & tgl_lahir & "', '" & username & "', '" & password & "')"

                    Try
                        Using cmd As New MySqlCommand(query, CONN)
                            cmd.Parameters.AddWithValue("@nik", nik)
                            cmd.Parameters.AddWithValue("@email", email)
                            cmd.Parameters.AddWithValue("@nama", nama)
                            cmd.Parameters.AddWithValue("@no_telp", no_telp)
                            cmd.Parameters.AddWithValue("@tgl_lahir", tgl_lahir)
                            cmd.Parameters.AddWithValue("@username", username)
                            cmd.Parameters.AddWithValue("@password", password)

                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Berhasil melakukan pendaftaran")
                        login.Show()
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    Finally
                        CONN.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub lbLogin_Click(sender As Object, e As EventArgs) Handles lbLogin.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub lbBeranda_Click(sender As Object, e As EventArgs) Handles lbBeranda.Click
        landing.Show()
        Me.Close()
    End Sub

    Private Sub regis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub lbTentang_Click(sender As Object, e As EventArgs) Handles lbTentang.Click
        tentang.Show()
        Me.Close()
    End Sub
End Class