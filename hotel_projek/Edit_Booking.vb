Public Class Edit_Booking
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataName()
    End Sub


    Private Sub ReloadDataName()
        ' Contoh cara menambahkan data di cb menggunakan database
        CBNamaTamu.DataSource = Booking.dataTamu.GetDataTamuDatabase()
        CBNamaTamu.DisplayMember = "Nama"

        'CBNamaTamu.DataSource = Booking.dataBooking.getNamaTamu()
        'CBNamaTamu.DisplayMember = "nama"

        CBNamaKamar.DataSource = Booking.dataKamar.GetDataKamarDatabase()
        CBNamaKamar.DisplayMember = "Nama Kamar"

        CBNamaTamu.SelectedItem() = Booking.dataTamu.GSNama
        CBNamaKamar.SelectedItem() = Booking.dataKamar.GSNamaKamar
        DateCheckIn.Value = Booking.dataBooking.GSCheckIn
        DateCheckOut.Value = Booking.dataBooking.GSCheckOut
    End Sub

    Private Sub Edit_Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataName()
    End Sub

    Private Sub BtnEditBooking_Click(sender As Object, e As EventArgs) Handles BtnEditBooking.Click
        Booking.dataBooking.GSNamaKamar = CBNamaKamar.Text
        Booking.dataBooking.GSNamaTamu = CBNamaTamu.Text
        Booking.dataBooking.GSCheckIn = DateCheckIn.Value.ToString("dd/MM/yyyy")
        Booking.dataBooking.GSCheckOut = DateCheckOut.Value.ToString("dd/MM/yyyy")


        Booking.dataBooking.UpdateDataBookingByIDDatabase(Booking.selectedtablebooking, Booking.dataBooking.GSNamaTamu, Booking.dataBooking.GSNamaKamar, Booking.dataBooking.GSCheckIn, Booking.dataBooking.GSCheckOut)
        Me.Close()

    End Sub
End Class