Public Class Booking

    Public Shared dataBooking As BookingBook
    Public Shared dataTamu As DataTamu
    Public Shared dataKamar As Class_Kamar


    Public Shared selectedtablebooking
    Public Shared selectedtablebookingnama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataBooking = New BookingBook
        dataTamu = New DataTamu
        dataKamar = New Class_Kamar


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

    Private Sub BtnEditBook_Click(sender As Object, e As EventArgs) Handles BtnEditBook.Click
        Dim selectedBooking As List(Of String) = dataBooking.GetDataBookingByIDDatabase(selectedtablebooking)

        dataBooking.GSNamaTamu = selectedBooking(1)
        dataBooking.GSNamaKamar = selectedBooking(3)
        dataBooking.GSCheckIn = selectedBooking(4)
        dataBooking.GSCheckOut = selectedBooking(5)

        Dim formEdit = New Edit_Booking()
        formEdit.Show()
    End Sub
End Class