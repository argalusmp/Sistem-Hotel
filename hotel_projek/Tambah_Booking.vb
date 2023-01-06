Public Class Tambah_Booking
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataName()
        DateCheckIn.Format = DateTimePickerFormat.Custom
        DateCheckIn.CustomFormat = "yyyy-MM-dd"
        DateCheckOut.Format = DateTimePickerFormat.Custom
        DateCheckOut.CustomFormat = "yyyy-MM-dd"

    End Sub


    Private Sub ReloadDataName()
        ' Contoh cara menambahkan data di cb menggunakan database
        CBNamaTamu.DataSource = Booking.dataTamu.GetDataTamuDatabase()
        CBNamaTamu.DisplayMember = "Nama"
        CBNamaTamu.ValueMember = "ID Tamu"



        CBNamaKamar.DataSource = Booking.dataKamar.GetDataKamarDatabase()
        CBNamaKamar.DisplayMember = "Nama Kamar"
        CBNamaKamar.ValueMember = "ID Kamar"



        'CBNamaTamu.DataSource = Booking.dataBooking.getNamaTamu()
        'CBNamaTamu.DisplayMember = "nama"

    End Sub

    Private Sub Tambah_Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataName()
    End Sub

    Private Sub BtnTambahBooking_Click(sender As Object, e As EventArgs) Handles BtnTambahBooking.Click

        Booking.dataBooking.GSNamaKamar = CBNamaKamar.SelectedValue
        Booking.dataBooking.GSNamaTamu = CBNamaTamu.SelectedValue

        'Booking.dataBooking.GSNamaKamar = CBNamaKamar.Text
        'Booking.dataBooking.GSNamaTamu = CBNamaTamu.Text
        Booking.dataBooking.GSCheckIn = DateCheckIn.Value.ToString("yyyy-MM-dd")
        Booking.dataBooking.GSCheckOut = DateCheckOut.Value.ToString("yyyy-MM-dd")


        Booking.dataBooking.AddDataBookingDatabase(Booking.dataBooking.GSNamaTamu, Booking.dataBooking.GSNamaKamar, Booking.dataBooking.GSCheckIn, Booking.dataBooking.GSCheckOut)

        Me.Hide()
    End Sub

    Private Sub CBNamaTamu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaTamu.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CBNamaKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaKamar.SelectedIndexChanged

    End Sub

    Private Sub DateCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles DateCheckIn.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles DateCheckOut.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class