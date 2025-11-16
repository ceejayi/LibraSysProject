Public Class UserNavigation

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    ' LOGOUT BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Open UserMainPage
            Dim userMain As New UserMainPage()
            userMain.Show()

            ' Close current form
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserMainPage.Show()
        Me.Close()
    End Sub
End Class
