Public Class Welcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load As New Loading()
        load.ShowDialog() ' Lalabas ang loading form bilang modal
    End Sub

End Class