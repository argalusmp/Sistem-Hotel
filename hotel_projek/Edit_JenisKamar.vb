Public Class Edit_JenisKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtHargaPerMalam.Text = Jenis_Kamar.dataHotel.GSHarga_PerMalam
        TxtJenisKamar.Text = Jenis_Kamar.dataHotel.GSJenisKamar
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Jenis_Kamar.dataHotel.GSJenisKamar = TxtJenisKamar.Text.ToString()
        Jenis_Kamar.dataHotel.GSHarga_PerMalam = Double.Parse(TxtHargaPerMalam.Text)

        Jenis_Kamar.dataHotel.UpdateDataJenisKamarByIDDatabase(
                                                        Jenis_Kamar.selectedtablejeniskamar,
                                                        Jenis_Kamar.dataHotel.GSJenisKamar,
                                                        Jenis_Kamar.dataHotel.GSHarga_PerMalam)
        Jenis_Kamar.Show()
        Me.Close()
    End Sub
End Class