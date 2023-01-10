Public Class Booking

    Public Shared dataBooking As BookingBook
    Public Shared dataTamu As DataTamu
    Public Shared dataKamar As Class_Kamar


    Public Shared selectedtablebooking As Integer
    Public Shared selectedtablebookingnama
    Public Shared selectedtablebookingidkamar

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

        dataBooking.GSNamaTamu = selectedBooking(0)
        dataBooking.GSNamaKamar = selectedBooking(2)
        dataBooking.GSCheckIn = selectedBooking(4)
        dataBooking.GSCheckOut = selectedBooking(5)

        Dim formEdit = New Edit_Booking()
        formEdit.Show()
    End Sub

    Private Sub DataGridViewBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBooking.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBooking.Rows(index)

        selectedtablebooking = selectedRow.Cells(0).Value
        selectedtablebookingnama = selectedRow.Cells(2).Value
        selectedtablebookingidkamar = selectedRow.Cells(3).Value
    End Sub

    Private Sub BtnRemoveBook_Click(sender As Object, e As EventArgs) Handles BtnRemoveBook.Click
        Dim selectedBooking As List(Of String) = Booking.dataBooking.GetDataBookingByIDDatabase(selectedtablebooking)

        Booking.dataBooking.GSNamaTamu = selectedBooking(1)
        Booking.dataBooking.GSNamaKamar = selectedBooking(3)

        Dim formHapus = New Hapus_Booking()
        formHapus.Show()
    End Sub
End Class