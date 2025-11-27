Imports System.Data.SqlClient

Public Class ReturningClearance
    Public SelectedBookTitle As String = ""
    Public CurrentUserID As Integer
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub ReturningClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Enter admin password..."
        TextBox1.ForeColor = Color.Gray
        TextBox1.UseSystemPasswordChar = False
    End Sub


    Private Sub btnCleared_Click(sender As Object, e As EventArgs) Handles btnCleared.Click
        ' Validate password first
        Dim passwordEntered As String = TextBox1.Text.Trim()

        If passwordEntered = "" OrElse passwordEntered = "Enter admin password..." Then
            MessageBox.Show("Please enter admin password to confirm.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm if password matches Admins table
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmdAdmin As New SqlCommand("SELECT COUNT(*) FROM Admins WHERE Password=@pass", con)
            cmdAdmin.Parameters.AddWithValue("@pass", passwordEntered)

            If CInt(cmdAdmin.ExecuteScalar()) = 0 Then
                MessageBox.Show("Incorrect admin password. Return clearance failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

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

        ' Refresh forms immediately without restarting system
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is CurrentlyReading Then CType(frm, CurrentlyReading).LoadCurrentlyReading()
            If TypeOf frm Is AlreadyRead Then CType(frm, AlreadyRead).LoadAlreadyRead()
        Next

        MessageBox.Show("Book successfully returned and cleared.", "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        AlreadyRead.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentlyReading.Show()
        Me.Close()
    End Sub
End Class
