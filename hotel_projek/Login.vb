Public Class Login

    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Users = New Users()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim plainUsername As String = txtUsername.Text
        Dim plainEmail As String = txtEmail.Text
        Dim plainPassword As String = txtPassword.Text

        Dim data_user As New List(Of String)
        data_user = Users.CheckAuthDB(plainUsername, plainEmail, plainPassword)

        If data_user.Count > 0 Then
            Users.GSUsername = data_user(0)
            Dim form_menu = New Menu()
            form_menu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Data user tidak ditemukan!")
        End If

        If txtUsername.Text Is Nothing Then
            MessageBox.Show("Username wajib diisi!")
        End If
    End Sub

    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub

End Class