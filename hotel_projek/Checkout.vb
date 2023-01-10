Public Class Checkout

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblTamu.Text = Booking.dataBooking.GSNamaTamu
        lblKamar.Text = Booking.dataBooking.GSNamaKamar
        lblLamaInap.Text = Booking.dataBooking.GetDateBookingDatabase(Booking.dataBooking.GSCheckIn, Booking.dataBooking.GSCheckOut)
        lblTotalBayar.Text = Booking.dataBooking.GSTotalBayar

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Booking.dataBooking.CheckoutDataBookingByIDDatabase(Booking.selectedtablebooking)
        Me.Close()
    End Sub
End Class