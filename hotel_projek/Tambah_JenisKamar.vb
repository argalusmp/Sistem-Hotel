Public Class Tambah_JenisKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Jenis_Kamar.dataHotel.GSJenisKamar = TxtJenisKamar.Text
        Jenis_Kamar.dataHotel.GSHarga_PerMalam = TxtHargaPerMalam.Text

        Jenis_Kamar.dataHotel.AddDataJenisKamarDatabase(Jenis_Kamar.dataHotel.GSJenisKamar, Jenis_Kamar.dataHotel.GSHarga_PerMalam)

        Me.Hide()

    End Sub
End Class