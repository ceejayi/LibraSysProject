Imports System.Data.SqlClient

Public Class Welcome

    ' When Welcome is shown, update last user's logout
    Private Sub Welcome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LogoutCurrentUser()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmQRScanner.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Update logout in DB
    Private Sub LogoutCurrentUser()
        If Globals.CurrentUserID = 0 Then Return

        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
            Using cmd As New SqlCommand("UPDATE UserLogs SET LogoutTime=@LogoutTime WHERE UserID=@UserID AND LogoutTime IS NULL", con)
                cmd.Parameters.AddWithValue("@LogoutTime", DateTime.Now)
                cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID)
                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Failed to log logout time: " & ex.Message)
                End Try
            End Using
        End Using
        Globals.CurrentUserID = 0
    End Sub

End Class
