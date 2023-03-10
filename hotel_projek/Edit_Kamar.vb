

Public Class Edit_Kamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxIDJenisKamar.DataSource = Kamar.classKamar.GetIDJenisKamar()
        ComboBoxIDJenisKamar.DisplayMember = "Jenis Kamar"
        ComboBoxIDJenisKamar.ValueMember = "ID Jenis Kamar"

        LblIdKamar.Text = Kamar.selectedtableKamar
        txtNamaKamar.Text = Kamar.classKamar.GSNamaKamar
        ComboBoxIDJenisKamar.SelectedItem() = Kamar.classKamar.GSIdJenisKamar

        If Kamar.classKamar.GSStatus = 0 Then
            RbtnKosong.Checked = True
        ElseIf Kamar.classKamar.GSStatus = 1 Then
            RbtnTerisi.Checked = True
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formkamar = New Kamar()
        formkamar.Show()
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Kamar.classKamar.GSIdJenisKamar = ComboBoxIDJenisKamar.SelectedValue
        Kamar.classKamar.GSNamaKamar = txtNamaKamar.Text.ToString()

        If RbtnKosong.Checked Then
            Kamar.classKamar.GSStatus = 0
        End If

        If RbtnTerisi.Checked Then
            Kamar.classKamar.GSStatus = 1
        End If

        Kamar.classKamar.UpdateDataKamarByIDDatabase(Kamar.selectedtableKamar,
                                                      Kamar.classKamar.GSIdJenisKamar,
                                                      Kamar.classKamar.GSNamaKamar,
                                                      Kamar.classKamar.GSStatus)

        'Dim formkamar = New Kamar()
        'formkamar.Show()
        Me.Close()
    End Sub

    Private Sub Edit_Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboBoxIDJenisKamar.DataSource = Kamar.classKamar.GetIDJenisKamar()
        ComboBoxIDJenisKamar.DisplayMember = "Jenis Kamar"
        ComboBoxIDJenisKamar.ValueMember = "ID Jenis Kamar"
    End Sub
End Class