Imports MySql.Data.MySqlClient
Public Class usersform
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim firstname As String
    Dim surname As String
    Dim password As String
    Dim username As String
    Private Sub usersform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connect()

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
    Private Function validation() As Boolean
        If FirstNameTextBox.Text = "" Then
            Return False
        ElseIf SurNameTextBox.Text = "" Then
            Return False
        ElseIf UserNameTextBox.Text = "" Then
            Return False
        ElseIf CreatePasswordTextBox.Text = "" Then
            Return False
        ElseIf ConfirmTextBox.Text = "" Then
            Return False

        End If

        Return True
    End Function


    Private Sub SaveButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim valid As Boolean
        If Not CreatePasswordTextBox.Text.Equals(ConfirmTextBox.Text) Then
            MessageBox.Show("Passwords do not match")


        ElseIf validation() Then


            sql = "insert into normalusers(firstname,lastname,username,password) values(@firstname,@lastname,@username,@password)"

            cmd = New MySqlCommand(sql, con)

            firstname = FirstNameTextBox.Text
            surname = SurNameTextBox.Text
            username = UserNameTextBox.Text
            password = CreatePasswordTextBox.Text

            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@lastname", surname)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)




            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("succesful sign-up")
                Call Reset()




            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("All fields have to be filled")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CreatePasswordTextBox.UseSystemPasswordChar = True Then
            CreatePasswordTextBox.UseSystemPasswordChar = False

        Else
            CreatePasswordTextBox.UseSystemPasswordChar = True


        End If
        If ConfirmTextBox.UseSystemPasswordChar = True Then
            ConfirmTextBox.UseSystemPasswordChar = False
        Else
            ConfirmTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class