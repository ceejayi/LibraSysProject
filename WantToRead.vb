Public Class WantToRead
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnServiceFeedback.Click
        ServiceFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub btnBorrowHistory_Click(sender As Object, e As EventArgs) Handles btnBorrowHistory.Click
        BorrowHistory.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyReviews_Click(sender As Object, e As EventArgs) Handles btnMyReviews.Click
        MyReviews.Show()
        Me.Hide()
    End Sub

    Private Sub btnCurrentlyReading_Click(sender As Object, e As EventArgs) Handles btnCurrentlyReading.Click
        CurrentlyReading.Show()
        Me.Hide()
    End Sub

    Private Sub btnWanttoRead_Click(sender As Object, e As EventArgs) Handles btnWanttoRead.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlreadyRead_Click(sender As Object, e As EventArgs) Handles btnAlreadyRead.Click
        AlreadyRead.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        UserMainPage.Show()
        Me.Hide()
    End Sub
End Class