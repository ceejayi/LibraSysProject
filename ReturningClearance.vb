Imports System.Data.SqlClient

Public Class ReturningClearance
    Public SelectedBookTitle As String = ""
    Public CurrentUserID As Integer
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub btnCleared_Click(sender As Object, e As EventArgs) Handles btnCleared.Click
        Using con As New SqlConnection(connectionString)
            con.Open()

            ' 1. Update BorrowedBooks ReturnDate
            Dim cmd1 As New SqlCommand("
                UPDATE BorrowedBooks
                SET ReturnDate=@ReturnDate
                WHERE BookTitle=@BookTitle AND UserID=@UserID AND ReturnDate IS NULL
            ", con)
            cmd1.Parameters.AddWithValue("@ReturnDate", DateTime.Now)
            cmd1.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
            cmd1.Parameters.AddWithValue("@UserID", CurrentUserID)
            cmd1.ExecuteNonQuery()

            ' 2. Update Books status
            Dim cmd2 As New SqlCommand("
                UPDATE Books
                SET BookStatus='Available'
                WHERE Title=@BookTitle
            ", con)
            cmd2.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
            cmd2.ExecuteNonQuery()
        End Using

        ' Refresh forms immediately
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is CurrentlyReading Then CType(frm, CurrentlyReading).LoadCurrentlyReading()
            If TypeOf frm Is AlreadyRead Then CType(frm, AlreadyRead).LoadAlreadyRead()
        Next

        AlreadyRead.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentlyReading.Show()
        Me.Close()
    End Sub

    Private Sub ReturningClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
