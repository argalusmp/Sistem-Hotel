Public Class Hapus_JenisKamar


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Lblharga.Text = Jenis_Kamar.dataHotel.GSHarga_PerMalam
        LblConsole.Text = Jenis_Kamar.dataHotel.GSJenisKamar
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Jenis_Kamar.dataHotel.DeleteDataJenisKamarByIdDatabase(Jenis_Kamar.selectedtablejeniskamar)
        Me.Close()
    End Sub
End Class