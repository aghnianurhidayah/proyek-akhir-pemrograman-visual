Public Class landing

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        regis.Show()
        Me.Hide()
    End Sub

    Private Sub lblBeranda_Click(sender As Object, e As EventArgs) Handles lbBeranda.Click
        Me.Show()
    End Sub

    Private Sub lblTentang_Click(sender As Object, e As EventArgs) Handles lbTentang.Click
        tentang.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        detailsUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub
End Class
