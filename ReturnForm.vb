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
        ' Load current logged-in user info from UserLogs joined to Users
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
                    MessageBox.Show("No logged-in user found in UserLogs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return
                End If
            End Using
        End Using

    End Sub

    ' Confirm return -> show ReturningClearance
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' 1. Mark the book as returned in the database
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("
                UPDATE BorrowedBooks
                SET ReturnDate=@ReturnDate, Status='Returned'
                WHERE BookTitle=@BookTitle AND UserID=@UserID AND ReturnDate IS NULL
            ", con)
                cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now)
                cmd.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
                cmd.Parameters.AddWithValue("@UserID", currentUserID)

                Try
                    con.Open()
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        MessageBox.Show("No borrowed book record found to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

        ' 2. Send return confirmation email
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("LibraSys2@gmail.com")
            mail.To.Add(currentUserEmail)
            mail.Subject = "Return Confirmation – LibraSys"

            ' Email HTML body (similar to borrowing email)
            Dim htmlBody As String =
$"
<html>
<body style='font-family: Arial; color:#333333; line-height:1.6;'>
    <h2 style='color:#1a237e;'>Return Confirmation</h2>

    <p>Hello,</p>

    <p>
        This email serves as an official confirmation that you have successfully returned a book to
        <strong>LibraSys Library System</strong>.
    </p>

    <p style='margin-top:15px;'>
        <strong>Book Title:</strong> {SelectedBookTitle}<br/>
        <strong>Returned On:</strong> {DateTime.Now:MMMM dd, yyyy hh:mm tt}
    </p>

    <p>
        Thank you for returning the book on time. We hope you enjoyed reading it!
    </p>

    <p style='margin-top:30px; font-size:13px; color:#777;'>
        — LibraSys Automated Return System
    </p>
</body>
</html>
"
            mail.IsBodyHtml = True
            mail.Body = htmlBody

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("LibraSys2@gmail.com", "lbnuohbdwibniykm") ' Replace with actual password
            smtp.EnableSsl = True
            smtp.Send(mail)

            MessageBox.Show("Book returned successfully! A confirmation email has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Book returned, but failed to send email: " & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        ' 3. Show confirmation page/form
        AlreadyRead.Show()
        Me.Hide()

    End Sub

End Class
