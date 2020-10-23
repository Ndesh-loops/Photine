Public Class dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

    End Sub

    Private Sub AddUserToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RemoveUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveUserToolStripMenuItem.Click
        ' Open the registration form for signing up a new user
        RegistrationForm.Show()

    End Sub

    Private Sub AddNormalUserToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        MsgBox("Updates Saved ")
    End Sub

    Private Sub RegistryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistryToolStripMenuItem.Click
        Registry.ShowDialog()
    End Sub

    Private Sub ResourcesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResourcesToolStripMenuItem.Click
        Resources.ShowDialog()
    End Sub

    Private Sub ProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectsToolStripMenuItem.Click
        Projects.ShowDialog()
    End Sub

    Private Sub SermonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SermonsToolStripMenuItem.Click
        Sermons.ShowDialog()
    End Sub

    Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
        Ceremonies.ShowDialog()
    End Sub

    Private Sub MinistryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinistryToolStripMenuItem.Click
        Ministry.ShowDialog()
    End Sub

    Private Sub WorkersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkersToolStripMenuItem.Click
        Workers.ShowDialog()
    End Sub

    Private Sub MonetaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonetaryToolStripMenuItem.Click
        Monetary.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        feedback.ShowDialog()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Calculator.ShowDialog()
    End Sub
End Class