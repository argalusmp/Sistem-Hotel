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

    Private Sub TxtNamaTamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaTamu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
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