Public Class AlreadyRead
    Private Sub btnBorrowHistory_Click(sender As Object, e As EventArgs) Handles btnBorrowHistory.Click
        BorrowHistory.Show()
        Me.Hide()
    End Sub
End Class