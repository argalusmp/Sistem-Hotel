Public Class Hapus_Booking
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaTamu.Text = Booking.dataBooking.GSNamaTamu
    End Sub

    Private Sub BtnHapusBooking_Click(sender As Object, e As EventArgs) Handles BtnHapusBooking.Click
        Booking.dataBooking.DeleteDataBookingByIDDatabase(Booking.selectedtablebooking)
        Me.Close()
    End Sub
End Class