Imports System.Windows.Forms

Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(2)
        If ProgressBar2.Value >= ProgressBar2.Maximum Then
            Timer1.Stop()
            Welcome.Show() ' Ilabas ang main 
        End If
    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
