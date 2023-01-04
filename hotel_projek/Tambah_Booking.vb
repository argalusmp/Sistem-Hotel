﻿Public Class Tambah_Booking
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


        'CBNamaTamu.DataSource = Booking.dataBooking.getNamaTamu()
        'CBNamaTamu.DisplayMember = "nama"

        CBNamaKamar.DataSource = Booking.dataKamar.GetDataKamarDatabase()
        CBNamaKamar.DisplayMember = "Nama Kamar"
        CBNamaKamar.ValueMember = "ID Kamar"


    End Sub

    Private Sub Tambah_Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataName()
    End Sub

    Private Sub BtnTambahBooking_Click(sender As Object, e As EventArgs) Handles BtnTambahBooking.Click


        Booking.dataBooking.GSNamaKamar = CBNamaKamar.SelectedValue
        Booking.dataBooking.GSNamaTamu = CBNamaTamu.SelectedValue
        Booking.dataBooking.GSCheckIn = DateCheckIn.Value.ToString("dd/MM/yyyy")
        Booking.dataBooking.GSCheckOut = DateCheckOut.Value.ToString("dd/MM/yyyy")


        Booking.dataBooking.AddDataBookingDatabase(Booking.dataBooking.GSNamaTamu, Booking.dataBooking.GSNamaKamar, Booking.dataBooking.GSCheckIn, Booking.dataBooking.GSCheckOut)

        Me.Hide()
    End Sub
End Class