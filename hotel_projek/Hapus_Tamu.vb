Public Class Hapus_Tamu

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaTamu.Text = Tamu.DataTamu.GSNama
    End Sub

    Private Sub BtnHapusTamu_Click(sender As Object, e As EventArgs) Handles BtnHapusTamu.Click
        Tamu.DataTamu.DeleteDataTamuByIDDatabase(Tamu.selectedTableTamu)
        Me.Close()
    End Sub
End Class