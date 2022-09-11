Public Class Limit_Screen
    Private Sub Set_Click(sender As Object, e As EventArgs) Handles Set_Button.Click

    End Sub

    Private Sub Return_Click(sender As Object, e As EventArgs) Handles Return_Button.Click

        Main_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub City_SelectedIndexChanged(sender As Object, e As EventArgs) Handles City.SelectedIndexChanged

        calc_price()

    End Sub

    Private Sub calc_price()



    End Sub

End Class