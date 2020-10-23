Public Class about
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = "I" Then
            PictureBox1.Image = My.Resources.CLFF1
            Label1.Text = "j"

        ElseIf Label1.Text = "j" Then
            PictureBox1.Image = My.Resources.CLFF2
            Label1.Text = "P"

        ElseIf Label1.Text = "P" Then
            PictureBox1.Image = My.Resources.CLFF3
            Label1.Text = "a"

        ElseIf Label1.Text = "a" Then
            PictureBox1.Image = My.Resources.CLFF4
            Label1.Text = "o"
        ElseIf Label1.Text = "o" Then
            PictureBox1.Image = My.Resources.CLFF5
            Label1.Text = "y"
        ElseIf Label1.Text = "y" Then
            PictureBox1.Image = My.Resources.CLFF6
            Label1.Text = "e"
        ElseIf Label1.Text = "e" Then
            PictureBox1.Image = My.Resources.CLFF7
            Label1.Text = "t"
        ElseIf Label1.Text = "t" Then
            PictureBox1.Image = My.Resources.CLFF8
            Label1.Text = "I"
        End If

    End Sub
End Class