Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Limit_Click(sender As Object, e As EventArgs) Handles Limit.Click

        Limit_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub Usage_Click(sender As Object, e As EventArgs) Handles Usage.Click

        Usage_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub Options_Click(sender As Object, e As EventArgs) Handles Options.Click

        Options_Screen.Show()
        Me.Hide()

    End Sub
End Class
