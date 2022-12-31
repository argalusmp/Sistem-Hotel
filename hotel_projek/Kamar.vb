Public Class Kamar
    Public Shared classKamar As Class_Kamar
    Public Shared selectedtableKamar As Integer
    Public Shared selectedtableKamarNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        classKamar = New Class_Kamar()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKamar.DataSource = classKamar.GetDataKamarDatabase()
    End Sub

    Private Sub Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtambahkamar = New Tambah_Kamar()
        formtambahkamar.Show()
    End Sub

    Private Sub DataGridKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKamar.Rows(index)

        selectedtableKamar = selectedRow.Cells(0).Value
        selectedtableKamarNama = selectedRow.Cells(2).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedKamar As List(Of String) = classKamar.GetDataKamarByIDDatabase(selectedtableKamar)

        classKamar.GSIdJenisKamar = selectedKamar(0)
        classKamar.GSNamaKamar = selectedKamar(1)
        classKamar.GSStatus = selectedKamar(2)

        Dim formEdit = New Edit_Kamar()
        formEdit.Show()
    End Sub

    Private Sub KamarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles KamarToolStripMenuItem.Click
        Dim formkamar = New Kamar()
        formkamar.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formHapus = New Hapus_Kamar()
        formHapus.Show()
    End Sub

    Private Sub JenisKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisKamarToolStripMenuItem.Click
        Dim jenisKamar = New Jenis_Kamar()
        jenisKamar.Show()
        'Me.Hide()
    End Sub

    Private Sub TamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamuToolStripMenuItem.Click
        Tamu.Show()
        'Me.Hide()
    End Sub

    Private Sub BookingKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingKamarToolStripMenuItem.Click
        Booking.Show()
        'Me.Hide()
    End Sub
End Class