Public Class Menu
    Private Sub btnTamu_Click(sender As Object, e As EventArgs) Handles btnTamu.Click
        Tamu.Show()
        Me.Hide()
    End Sub

    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click
        Kamar.Show()
        Me.Hide()
    End Sub

    Private Sub btnJenisKamar_Click(sender As Object, e As EventArgs) Handles btnJenisKamar.Click
        Jenis_Kamar.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Booking.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) 
        'checkout.show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class