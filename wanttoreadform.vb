Public Class wanttoreadform
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnServiceFeedback.Click

    End Sub

    Private Sub btnBorrowHistory_Click(sender As Object, e As EventArgs) Handles btnBorrowHistory.Click
        BorrowHistory.Show()
        Me.Hide()
    End Sub
End Class