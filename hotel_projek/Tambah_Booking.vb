Public Class Tambah_Booking
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


    End Sub

    Private Sub Tambah_Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataName()
    End Sub
End Class