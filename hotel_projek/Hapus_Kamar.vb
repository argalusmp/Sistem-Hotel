Public Class Hapus_Kamar
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Kamar.classKamar.DeleteDataKamarByIDDatabase(Kamar.selectedtableKamar)
        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim formkamar = New Kamar()
        formkamar.Show()
        Me.Close()
    End Sub
End Class