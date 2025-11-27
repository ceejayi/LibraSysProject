Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net

Public Class ReturnForm

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Private currentUserID As Integer
    Private currentUserEmail As String
    Private selectedBookTitle As String = BookChosen.bookTitle

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                    MessageBox.Show("No logged-in user found in UserLogs.")
                    Me.Close()
                    Return
                End If
            End Using
        End Using

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Dim borrowDate As DateTime
        Dim returnDate As DateTime = DateTime.Now
        Dim dueDate As DateTime
        Dim penaltyPerDay As Decimal = 20D
        Dim penaltyAmount As Decimal = 0D

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' 1. GET BORROW DATE
            Dim cmdGet As New SqlCommand("
                SELECT BorrowDate
                FROM BorrowedBooks
                WHERE BookTitle=@BookTitle AND UserID=@UserID AND ReturnDate IS NULL
            ", con)

            cmdGet.Parameters.AddWithValue("@BookTitle", selectedBookTitle)
            cmdGet.Parameters.AddWithValue("@UserID", currentUserID)

            Dim result = cmdGet.ExecuteScalar()

            If result Is Nothing Then
                MessageBox.Show("No borrowed record found for this book.")
                Return
            Else
                borrowDate = CDate(result)
            End If

            ' 2. COMPUTE PENALTY
            dueDate = borrowDate.AddDays(7)

            If returnDate > dueDate Then
                Dim lateDays As Integer = (returnDate - dueDate).Days
                penaltyAmount = lateDays * penaltyPerDay
            End If

            ' 3. UPDATE BorrowedBooks WITH ReturnDate + Penalty
            Dim cmdUpdate As New SqlCommand("
                UPDATE BorrowedBooks
                SET ReturnDate=@ReturnDate, Penalty=@Penalty, Status='Returned'
                WHERE BookTitle=@BookTitle AND UserID=@UserID AND ReturnDate IS NULL
            ", con)

            cmdUpdate.Parameters.AddWithValue("@ReturnDate", returnDate)
            cmdUpdate.Parameters.AddWithValue("@Penalty", penaltyAmount)
            cmdUpdate.Parameters.AddWithValue("@BookTitle", selectedBookTitle)
            cmdUpdate.Parameters.AddWithValue("@UserID", currentUserID)

            cmdUpdate.ExecuteNonQuery()

            ' 4. SET BOOK AS AVAILABLE
            Dim cmdBook As New SqlCommand("
                UPDATE Books SET BookStatus='Available'
                WHERE Title=@BookTitle
            ", con)
            cmdBook.Parameters.AddWithValue("@BookTitle", selectedBookTitle)
            cmdBook.ExecuteNonQuery()

        End Using

        ' 5. SEND RETURN EMAIL WITH PENALTY
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("LibraSys2@gmail.com")
            mail.To.Add(currentUserEmail)
            mail.Subject = "Return Receipt – LibraSys"

            Dim htmlBody As String =
$"
<html>
<body style='font-family: Arial; color:#333;'>
    <h2>Book Return Receipt</h2>

    <p>You have successfully returned the following book:</p>

    <p>
        <strong>Title:</strong> {selectedBookTitle}<br/>
        <strong>Borrowed Date:</strong> {borrowDate:MMMM dd, yyyy}<br/>
        <strong>Due Date:</strong> {dueDate:MMMM dd, yyyy}<br/>
        <strong>Returned Date:</strong> {returnDate:MMMM dd, yyyy}<br/>
        <strong>Penalty:</strong> ₱{penaltyAmount}
    </p>

    <p>Thank you for using LibraSys!</p>
</body>
</html>
"

            mail.IsBodyHtml = True
            mail.Body = htmlBody

            Dim smtp As New SmtpClient("smtp.gmail.com", 587)
            smtp.Credentials = New NetworkCredential("LibraSys2@gmail.com", "lbnuohbdwibniykm")
            smtp.EnableSsl = True
            smtp.Send(mail)

        Catch ex As Exception
            MessageBox.Show("Book returned, but email failed: " & ex.Message)
        End Try

        MessageBox.Show("Book successfully returned!" & vbCrLf &
                        $"Penalty: ₱{penaltyAmount}", "Success")

        AlreadyRead.Show()
        Me.Hide()

    End Sub

End Class
