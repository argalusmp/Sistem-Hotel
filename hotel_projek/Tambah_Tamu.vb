Public Class Tambah_Tamu
    Private Sub TxtNamaTamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaTamu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub



    Private Sub RbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RbPerempuan.CheckedChanged
        Tamu.DataTamu.GSJenisKelamin = "Perempuan"
    End Sub

    Private Sub RbLaki_CheckedChanged(sender As Object, e As EventArgs) Handles RbLaki.CheckedChanged
        Tamu.DataTamu.GSJenisKelamin = "Laki-laki"
    End Sub

    Private Sub BtnTambahTamu_Click(sender As Object, e As EventArgs) Handles BtnTambahTamu.Click
        Tamu.DataTamu.GSNIK = TxtNIK.Text.ToString()
        Tamu.DataTamu.GSNama = TxtNamaTamu.Text.ToString()
        Tamu.DataTamu.GSAlamat = RtbAlamat.Text.ToString()

        If RbPerempuan.Checked Then
            Tamu.DataTamu.GSJenisKelamin = "Perempuan"
        ElseIf RbLaki.Checked Then
            Tamu.DataTamu.GSJenisKelamin = "Laki-laki"
        End If

        Tamu.DataTamu.AddDataTamuDatabase(Tamu.DataTamu.GSNIK, Tamu.DataTamu.GSNama, Tamu.DataTamu.GSAlamat, Tamu.DataTamu.GSJenisKelamin)

        Me.Close()
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

End Class