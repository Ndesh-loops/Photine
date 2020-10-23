Imports MySql.Data.MySqlClient
Public Class sign_in
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim password As String
    Dim username As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
    Public Sub Connect()
        Dim ConString As String
        ConString = "server=localhost;uid=root;pwd=;database=photine"

        Try
            con.ConnectionString = ConString
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim pass As String

        username = UserNameTextBox.Text.Trim()
        password = PasswordTextBox.Text.Trim()
        sql = "select password from normalusers WHERE username=@username"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@username", username)

        Try

            pass = cmd.ExecuteScalar()

            If password = pass And PasswordTextBox.Text IsNot "" Then
                MessageBox.Show("Login succesful")

                dashboard.Show()
                Me.Hide()

            Else
                MsgBox("Please ensure that all the details are entered and are correctly filled.You must be registered to login")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Green
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.LightGray
    End Sub





    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.LightGray
    End Sub

    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connect()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Please contact the super admin or ask another user to log you in.")
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.Aquamarine
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.LightGray
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        AdminLogIn.Show()
    End Sub
End Class