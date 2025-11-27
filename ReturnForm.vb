Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net

Public Class ReturnForm
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Public SelectedBookTitle As String = ""
    Public SelectedBookAuthor As String = ""
    Public SelectedBookGenre As String = ""
    Public SelectedBookDescription As String = ""
    Public SelectedBookCoverPath As String = ""
    Private currentUserID As Integer
    Private currentUserEmail As String

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackgroundImage = If(System.IO.File.Exists(SelectedBookCoverPath), Image.FromFile(SelectedBookCoverPath), Nothing)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        lblTitle.Text = SelectedBookTitle
        lblAuthorGenre.Text = SelectedBookAuthor & Environment.NewLine & SelectedBookGenre
        lblDescription.Text = SelectedBookDescription

        ' Load current logged-in user info
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT TOP 1 u.UserID, u.Email
                FROM UserLogs ul
                INNER JOIN Users u ON ul.UserID = u.UserID
                ORDER BY ul.LogID DESC
            ", con)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    currentUserID = CInt(reader("UserID"))
                    currentUserEmail = reader("Email").ToString()
                Else
                    MessageBox.Show("No logged-in user found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return
                End If
            End Using
        End Using
    End Sub

    ' Confirm return -> show ReturningClearance
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim clearance As New ReturningClearance() With {.selectedBookTitle = SelectedBookTitle, .currentUserID = currentUserID}
        clearance.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CurrentlyReading.Show()
        Me.Hide()
    End Sub
End Class
