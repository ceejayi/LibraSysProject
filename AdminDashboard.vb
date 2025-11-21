Public Class AdminDashboard
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmQRGenerator.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Collection.Show()
        Me.Hide()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class