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
        CBNamaTamu.ValueMember = "ID Tamu"

        CBNamaKamar.DataSource = Booking.dataKamar.GetDataKamarDatabase()
        CBNamaKamar.DisplayMember = "Nama Kamar"
        CBNamaKamar.ValueMember = "ID Kamar"

        CBNamaTamu.SelectedValue() = Booking.dataBooking.GSNamaTamu
        CBNamaKamar.SelectedValue() = Booking.dataBooking.GSNamaKamar
        DateCheckIn.Value = Booking.dataBooking.GSCheckIn
        DateCheckOut.Value = Booking.dataBooking.GSCheckOut

    End Sub

    Private Sub Edit_Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataName()
    End Sub

    Private Sub BtnEditBooking_Click(sender As Object, e As EventArgs) Handles BtnEditBooking.Click
        Booking.dataBooking.GSNamaKamar = CBNamaKamar.SelectedValue().ToString()
        Booking.dataBooking.GSNamaTamu = CBNamaTamu.SelectedValue().ToString()
        Booking.dataBooking.GSCheckIn = DateCheckIn.Value
        Booking.dataBooking.GSCheckOut = DateCheckOut.Value
        MessageBox.Show("edit")

        MessageBox.Show("ID Kamar : " + Booking.dataBooking.GSNamaKamar)

        Booking.dataBooking.UpdateDataBookingByIDDatabase(Booking.selectedtablebooking, Booking.dataBooking.GSNamaTamu, Booking.dataBooking.GSNamaKamar, Booking.dataBooking.GSCheckIn, Booking.dataBooking.GSCheckOut)
        Me.Close()

    End Sub
End Class