Imports System.Data.SqlClient

Public Class AdminWelcome

    Dim connString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Private Const SlideSpeed As Integer = 50
    Private NavbarVisible As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Dim targetLeft = If(NavbarVisible, 0, -Panel3.Width)
        Dim distance = targetLeft - Panel3.Left

        If Math.Abs(distance) > SlideSpeed Then
            Panel3.Left += SlideSpeed * Math.Sign(distance)
        Else
            Panel3.Left = targetLeft
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles PanelMain.MouseEnter
        NavbarVisible = True
        Timer1.Enabled = True
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs)
        Dim cursorPos = PointToClient(Cursor.Position)

        If Panel3.Bounds.Contains(cursorPos) Or
       Button1.Bounds.Contains(cursorPos) Or Button2.Bounds.Contains(cursorPos) Or
       Button3.Bounds.Contains(cursorPos) Or Button4.Bounds.Contains(cursorPos) Or
       Button5.Bounds.Contains(cursorPos) Then
            Return
        End If

        NavbarVisible = False
        Timer1.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("Sign Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have signed out successfully.", "Signed Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Welcome.Show()
            Hide()
        Else
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub

    Private Sub AdminWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Transaction.Show
        Hide
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ArchivesAndList.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserList.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Maintenance.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Welcome.Show()
        Me.Hide()
    End Sub
End Class
