Public Class Edit_Tamu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNIK.Text = Tamu.DataTamu.GSNIK
        TxtNamaTamu.Text = Tamu.DataTamu.GSNama
        RtbAlamat.Text = Tamu.DataTamu.GSAlamat

        If String.Compare(Tamu.DataTamu.GSJenisKelamin, "Perempuan") = 0 Then
            RbPerempuan.Checked = True
        ElseIf String.Compare(Tamu.DataTamu.GSJenisKelamin, "Laki-laki") = 0 Then
            RbLaki.Checked = True
        End If
    End Sub

    Private Sub RbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RbPerempuan.CheckedChanged
        Tamu.DataTamu.GSJenisKelamin = "Perempuan"
    End Sub

    Private Sub RbLaki_CheckedChanged(sender As Object, e As EventArgs) Handles RbLaki.CheckedChanged
        Tamu.DataTamu.GSJenisKelamin = "Laki-laki"
    End Sub

    Private Sub BtnEditTamu_Click(sender As Object, e As EventArgs) Handles BtnEditTamu.Click
        Tamu.DataTamu.GSNIK = TxtNIK.Text.ToString()
        Tamu.DataTamu.GSNama = TxtNamaTamu.Text.ToString()
        Tamu.DataTamu.GSAlamat = RtbAlamat.Text.ToString()

        If RbPerempuan.Checked Then
            Tamu.DataTamu.GSJenisKelamin = True
        ElseIf RbLaki.Checked Then
            Tamu.DataTamu.GSJenisKelamin = True
        End If

        Tamu.DataTamu.UpdateDataTamuByIDDatabase(Tamu.selectedTableTamu,
                                                 Tamu.DataTamu.GSNIK,
                                                 Tamu.DataTamu.GSNama,
                                                 Tamu.DataTamu.GSAlamat,
                                                 Tamu.DataTamu.GSJenisKelamin)
        'Tamu.Show()
        Me.Close()

    End Sub
End Class