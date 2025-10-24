Public Class BORROWCONFIRMATION
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Borrow.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reservation.show()
        Me.Hide()
    End Sub
End Class