Public Class Booking

    Public Shared dataBooking As BookingBook
    Public Shared dataTamu As DataTamu

    Public Shared selectedtablebooking
    Public Shared selectedtablebookingnama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataBooking = New BookingBook
        dataTamu = New DataTamu

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewBooking.DataSource = dataBooking.GetDataBookingDatabase()
    End Sub

    Private Sub Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnAddBook_Click(sender As Object, e As EventArgs) Handles BtnAddBook.Click
        Dim tambahBooking = New Tambah_Booking
        tambahBooking.Show()
    End Sub
End Class