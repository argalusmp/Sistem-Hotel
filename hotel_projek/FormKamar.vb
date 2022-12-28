Public Class FormKamar
    Public Shared classKamar As Class_Kamar
    Public selectedtableKamar As Integer
    Public selectedtableKamarNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        classKamar = New Class_Kamar()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewKamar.DataSource = classKamar.GetDataKamarDatabase()
    End Sub

    Private Sub Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtambahkamar = New Tambah_Kamar()
        formtambahkamar.Show()
    End Sub

    Private Sub DataGridViewKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewKamar.Rows(index)

        selectedtableKamar = selectedRow.Cells(1).Value
        selectedtableKamarNama = selectedRow.Cells(2).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub KamarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles KamarToolStripMenuItem.Click
        Dim formkamar = New Kamar()
        formkamar.Show()
        Me.Close()
    End Sub
End Class