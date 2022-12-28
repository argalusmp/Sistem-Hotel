Public Class Booking

    Public Shared dataBooking As BookingBook
    Public Shared selectedtablebooking
    Public Shared selectedtablebookingnama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataBooking = New BookingBook

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewBooking.DataSource = dataBooking.GetDataBookingDatabase()
    End Sub

    Private Sub Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class