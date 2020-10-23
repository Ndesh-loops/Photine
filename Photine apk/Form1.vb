Imports MySql.Data.MySqlClient
Public Class RegistrationForm
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim firstname As String
    Dim surname As String
    Dim password As String
    Dim username As String
    Dim usernumber As String
    Dim id As String
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




    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()



        Call Populate_ListView()


    End Sub
    Public Sub Populate_ListView()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        sql = "select * from users"
        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader
        UsersListView.Clear()
        n = 0
        Do While reader.Read
            UsersListView.Items.Add(n)
            UsersListView.Items(n).SubItems.Add(reader("firstname"))
            UsersListView.Items(n).SubItems.Add(reader("lastname"))
            UsersListView.Items(n).SubItems.Add(reader("username"))


            n += 1
        Loop
        ' We have set listview properties
        UsersListView.View = View.Details
        UsersListView.GridLines = True
        UsersListView.FullRowSelect = True
        UsersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        'set column headers
        UsersListView.Columns.Add("SN")

        UsersListView.Columns.Add("First Name")
        UsersListView.Columns.Add("Sur Name")
        UsersListView.Columns.Add("User Name")

        reader.Close()
    End Sub
    Private Sub Reset()
        FirstNameTextBox.Text = ""
        SurNameTextBox.Text = ""
        UserNameTextBox.Text = ""
        CreatePasswordTextBox.Text = ""
        ConfirmTextBox.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim valid As Boolean
        If Not CreatePasswordTextBox.Text.Equals(ConfirmTextBox.Text) Then
            MessageBox.Show("Passwords do not match")


        ElseIf validation() Then


            sql = "insert into users(firstname,lastname,username,password) values(@firstname,@lastname,@username,@password)"

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
                Call Populate_ListView()



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("All fields have to be filled")
        End If
    End Sub
    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged
        Dim sql As String
        Dim SearchValue As String
        SearchValue = UserNameTextBox.Text
        sql = "select * from users WHERE username= '" & SearchValue & "'"
        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            MessageBox.Show("Username already exists")
            SignUpButton.Enabled = False
        Else
            SignUpButton.Enabled = True
        End If
        reader.Close()


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

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles SignUpButton.MouseHover
        SignUpButton.BackColor = Color.Green
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles SignUpButton.MouseLeave
        SignUpButton.BackColor = Color.Blue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Salmon
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles FirstNameTextBox.MouseHover

    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles FirstNameTextBox.MouseLeave

    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles SurNameTextBox.TextChanged

    End Sub

    Private Sub TextBox3_MouseEnter(sender As Object, e As EventArgs) Handles SurNameTextBox.MouseEnter

    End Sub

    Private Sub TextBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles SurNameTextBox.MouseClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles UserNameTextBox.MouseEnter

    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles UserNameTextBox.MouseLeave

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles CreatePasswordTextBox.TextChanged

    End Sub

    Private Sub TextBox4_MouseEnter(sender As Object, e As EventArgs) Handles CreatePasswordTextBox.MouseEnter

    End Sub

    Private Sub TextBox4_MouseLeave(sender As Object, e As EventArgs) Handles CreatePasswordTextBox.MouseLeave

    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles UserNameTextBox.MouseClick
        UserNameTextBox.Text = ""
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ResetButton.Click
        Call Reset()

    End Sub

    Private Sub ResetButton_MouseEnter(sender As Object, e As EventArgs) Handles ResetButton.MouseEnter
        ResetButton.ForeColor = Color.White
    End Sub

    Private Sub ResetButton_MouseLeave(sender As Object, e As EventArgs) Handles ResetButton.MouseLeave
        ResetButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub Populating()
        firstname = FirstNameTextBox.Text
        surname = SurNameTextBox.Text
        username = UserNameTextBox.Text
        password = CreatePasswordTextBox.Text

    End Sub

    Private Sub UpdateButton_MouseEnter(sender As Object, e As EventArgs) Handles UpdateButton.MouseEnter
        UpdateButton.ForeColor = Color.White
    End Sub

    Private Sub UpdateButton_MouseLeave(sender As Object, e As EventArgs) Handles UpdateButton.MouseLeave
        UpdateButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub DeleteButton_MouseEnter(sender As Object, e As EventArgs) Handles DeleteButton.MouseEnter
        DeleteButton.ForeColor = Color.White
    End Sub

    Private Sub DeleteButton_MouseLeave(sender As Object, e As EventArgs) Handles DeleteButton.MouseLeave
        DeleteButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

    End Sub
End Class
