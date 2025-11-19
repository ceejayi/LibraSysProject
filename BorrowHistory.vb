Public Class BorrowHistory
    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        UserMainPage.Show()
        Me.Hide()
    End Sub

    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click        ' Show confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Open UserMainPage
            Dim userMain As New UserMainPage()
            userMain.Show()

            ' Close current form
            Me.Close()
        End If
    End Sub
End Class