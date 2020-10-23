Imports MySql.Data.MySqlClient

Public Class feedback
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim comment As String
    Dim name As String
    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()

    End Sub
    Public Sub Connect()
        Dim ConString As String
        ConString = "server=localhost;uid=root;pwd=;database=photine"

        Try
            con.ConnectionString = ConString
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim cmd As MySqlCommand

        sql = "insert into feedback(name,comment) values(@name,@comment)"
        cmd = New MySqlCommand(sql, con)

        comment = TextBox1.Text
        name = TextBox2.Text
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@comment", comment)


        Try

            cmd.ExecuteNonQuery()

            MsgBox("Feedback sent")

            TextBox1.Clear()
            TextBox2.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)


        End Try

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.ForestGreen
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class