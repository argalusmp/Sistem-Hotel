Imports Mysqlx.XDevAPI.Relational

Public Class Tambah_Kamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxIDJenisKamar.DataSource = Kamar.classKamar.GetIDJenisKamar()
        ComboBoxIDJenisKamar.DisplayMember = "Jenis Kamar"
        ComboBoxIDJenisKamar.ValueMember = "ID Jenis Kamar"

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formkamar = New Kamar()
        formkamar.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        Kamar.classKamar.GSIdJenisKamar = ComboBoxIDJenisKamar.SelectedValue
        Kamar.classKamar.GSNamaKamar = txtNamaKamar.Text.ToString()


        If RbtnKosong.Checked Then
            Kamar.classKamar.GSStatus = 0
        End If

        If RbtnTerisi.Checked Then
            Kamar.classKamar.GSStatus = 1
        End If


        Kamar.classKamar.AddDataKamarDatabase(Kamar.classKamar.GSIdJenisKamar,
                                              Kamar.classKamar.GSNamaKamar,
                                              Kamar.classKamar.GSStatus)

        Me.Close()
    End Sub

    Private Sub txtIDKamar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Tulis ID dalam format angka (contoh: 404)")
        End If
    End Sub


    Private Sub txtNamaKamar_Leave(sender As Object, e As EventArgs) Handles txtNamaKamar.Leave
        If txtNamaKamar.Text.Length < 1 Then
            txtNamaKamar.Select()
            MessageBox.Show("Nama Kamar Tidak Boleh Kosong!")
        End If

        If txtNamaKamar.Text.Length > 50 Then
            txtNamaKamar.Select()
            MessageBox.Show("Maksimum Value Nama Kamar 50 Karakter!")
        End If
    End Sub


    Private Sub Tambah_Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboBoxIDJenisKamar.DataSource = Kamar.classKamar.GetIDJenisKamar()
        ComboBoxIDJenisKamar.DisplayMember = "Jenis Kamar"
        ComboBoxIDJenisKamar.ValueMember = "ID Jenis Kamar"
    End Sub
End Class