Public Class Jenis_Kamar

    Public Shared dataHotel As DataJenisHotel
    Public Shared selectedtablejeniskamar
    Public Shared selectedtablejeniskamarnama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataHotel = New DataJenisHotel

        ReloadDataTableDatabase()
    End Sub


    Private Sub ReloadDataTableDatabase()
        DataGridViewJenisKamar.DataSource = dataHotel.GetDataJenisKamarDatabase()
    End Sub

    Private Sub Jenis_Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim tambahJenisKamar = New Tambah_JenisKamar
        tambahJenisKamar.Show()
    End Sub

    Private Sub DataGridViewJenisKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisKamar.Rows(index)

        selectedtablejeniskamar = selectedRow.Cells(0).Value
        selectedtablejeniskamarnama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedJenisKamar As List(Of String) = Jenis_Kamar.dataHotel.GetDataJenisKamarByIDDatabase(selectedtablejeniskamar)

        Jenis_Kamar.dataHotel.GSJenisKamar = selectedJenisKamar(1)
        Jenis_Kamar.dataHotel.GSHarga_PerMalam = selectedJenisKamar(2)


        Dim formUpdate = New Edit_JenisKamar()
        formUpdate.Show()

        Me.Hide()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim selectedJenisKamar As List(Of String) = Jenis_Kamar.dataHotel.GetDataJenisKamarByIDDatabase(selectedtablejeniskamar)

        Jenis_Kamar.dataHotel.GSJenisKamar = selectedJenisKamar(1)
        Jenis_Kamar.dataHotel.GSHarga_PerMalam = selectedJenisKamar(2)
        Dim formHapus = New Hapus_JenisKamar
        formHapus.Show()
    End Sub
End Class