Imports System.Data.SqlClient

Public Class ReturnForm
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Public SelectedBookTitle As String = ""
    Public SelectedBookAuthor As String = ""
    Public SelectedBookGenre As String = ""
    Public SelectedBookDescription As String = ""
    Public SelectedBookCoverPath As String = ""
    Private currentUserID As Integer

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackgroundImage = If(System.IO.File.Exists(SelectedBookCoverPath), Image.FromFile(SelectedBookCoverPath), Nothing)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        lblTitle.Text = SelectedBookTitle
        lblAuthorGenre.Text = SelectedBookAuthor & Environment.NewLine & SelectedBookGenre
        lblDescription.Text = SelectedBookDescription

        ' Load current logged-in user
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT TOP 1 UserID
                FROM UserLogs
                ORDER BY LogID DESC
            ", con)
            currentUserID = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim clearance As New ReturningClearance() With {
            .SelectedBookTitle = SelectedBookTitle,
            .CurrentUserID = currentUserID
        }
        clearance.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CurrentlyReading.Show()
        Me.Hide()
    End Sub
End Class
