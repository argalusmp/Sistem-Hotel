Public Class Register
    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()

    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text.Length > 0 And txtEmail.Text.Length > 0 And txtPassword.Text.Length > 0 Then

            Dim emailValidated = IsValidEmailFormat(txtEmail.Text)
            If emailValidated Then
                Users.AddUserDB(txtUsername.Text, txtEmail.Text, txtPassword.Text)

                Me.Close()
            Else
                MessageBox.Show("Email tidak sesuai format!")
            End If
        Else
            MessageBox.Show("Data Tidak Lengkap!")
        End If
    End Sub

    Private Sub Register_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
            Return True
        Catch
            Return False
        End Try
    End Function
End Class