Public Class MyProgressBar
    Inherits ProgressBar

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Palitan lang ang Color.Green → Color.Maroon
        e.Graphics.Clear(Me.BackColor)
        Using brush As New SolidBrush(Color.Maroon)
            e.Graphics.FillRectangle(brush, 0, 0, CInt(Me.Width * (Me.Value / Me.Maximum)), Me.Height)
        End Using

        ' Optional: border
        e.Graphics.DrawRectangle(Pens.Black, 0, 0, Me.Width - 1, Me.Height - 1)


        'CEEJ TRY'
    End Sub
End Class
