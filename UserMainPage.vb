Public Class UserMainPage
    Private Const SlideSpeed As Integer = 50

    ' Nag-track kung kailangan bang mag-slide in
    Private NavbarVisible As Boolean = False

    ' Timer tick para sa smooth animation
    ' Timer tick para sa smooth animation
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim targetLeft As Integer

        If NavbarVisible Then
            targetLeft = 0 ' fully visible
        Else
            targetLeft = -Panel3.Width ' fully hidden
        End If

        ' Compute distance to target
        Dim distance As Integer = targetLeft - Panel3.Left

        ' Gumalaw ng fixed step (SlideSpeed) kada tick
        If Math.Abs(distance) > SlideSpeed Then
            Panel3.Left += SlideSpeed * Math.Sign(distance)
        Else
            Panel3.Left = targetLeft
            Timer1.Enabled = False ' reached target
        End If
    End Sub



    ' Trigger slide-in kapag hinover ang hover area
    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        NavbarVisible = True
        Timer1.Enabled = True
    End Sub

    ' Slide-out kapag lumabas sa navbar
    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        ' Kunin ang cursor position relative sa form
        Dim cursorPos = Me.PointToClient(Cursor.Position)

        ' Huwag mag-slide out kung naka-hover sa buttons 1–5 o sa Panel3 mismo
        If Panel3.Bounds.Contains(cursorPos) Or
       Button1.Bounds.Contains(cursorPos) Or Button2.Bounds.Contains(cursorPos) _
       Or Button3.Bounds.Contains(cursorPos) Or Button4.Bounds.Contains(cursorPos) _
       Or Button5.Bounds.Contains(cursorPos) Then
            Return ' stay visible
        End If

        ' Otherwise, slide out
        NavbarVisible = False
        Timer1.Enabled = True
    End Sub



    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        FlowLayoutPanel1.WrapContents = False

    End Sub
End Class
