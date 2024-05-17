Public Class menuAdmin

    Private Sub lbVerif_Click(sender As Object, e As EventArgs) Handles lbVerif.Click
        verify.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        verify.Show()
        Me.Close()
    End Sub

    Private Sub pnlVerif_Click(sender As Object, e As EventArgs) Handles pnlVerif.Click
        verify.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        verify.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        dataVaksinasi.Show()
        Me.Close()
    End Sub

    Private Sub pnlData_Click(sender As Object, e As EventArgs) Handles pnlData.Click
        dataVaksinasi.Show()
        Me.Close()
    End Sub

    Private Sub lbDataVak_Click(sender As Object, e As EventArgs) Handles lbDataVak.Click
        dataVaksinasi.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        dataVaksinasi.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        login.username = ""
        login.nama = ""
        login.nik = ""
        login.clr()
        login.Show()
        Me.Close()
    End Sub
End Class