Public Class Tamu
    Public Shared DataTamu As DataTamu
    Public Shared selectedTableTamu
    Public Shared selectedTableTamuNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataTamu = New DataTamu
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewTamu.DataSource = DataTamu.GetDataTamuDatabase()
    End Sub

    Private Sub Tamu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTamu.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewTamu.Rows(index)

        selectedTableTamu = selectedRow.Cells(0).Value
        selectedTableTamuNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah_tamu = New Tambah_Tamu()
        tambah_tamu.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedTamu As List(Of String) = Tamu.DataTamu.GetDataTamuByIDDatabase(selectedTableTamu)

        Tamu.DataTamu.GSNIK = selectedTamu(1)
        Tamu.DataTamu.GSNama = selectedTamu(2)
        Tamu.DataTamu.GSAlamat = selectedTamu(3)
        Tamu.DataTamu.GSJenisKelamin = selectedTamu(4)

        Dim formEdit = New Edit_Tamu()
        formEdit.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim selectedTamu As List(Of String) = Tamu.DataTamu.GetDataTamuByIDDatabase(selectedTableTamu)

        Tamu.DataTamu.GSNama = selectedTamu(2)

        Dim formHapus = New Hapus_Tamu()
        formHapus.Show()
    End Sub
End Class