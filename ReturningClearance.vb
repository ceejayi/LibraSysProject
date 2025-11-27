Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net

Public Class ReturningClearance

    Public SelectedBookTitle As String = ""
    Public CurrentUserID As Integer

    Private connectionString As String =
        "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub btnCleared_Click(sender As Object, e As EventArgs) Handles btnCleared.Click
        Using con As New SqlConnection(connectionString)
            con.Open()

            ' ===========================
            ' 1. Update BorrowedBooks
            ' ===========================
            Dim cmd1 As New SqlCommand("
                UPDATE BorrowedBooks
                SET ReturnDate = @ReturnDate
                WHERE BookTitle = @BookTitle
                AND UserID = @UserID
                AND ReturnDate IS NULL
            ", con)

            cmd1.Parameters.AddWithValue("@ReturnDate", DateTime.Now)
            cmd1.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
            cmd1.Parameters.AddWithValue("@UserID", CurrentUserID)
            cmd1.ExecuteNonQuery()


            ' ===========================
            ' 2. Update Books status
            ' ===========================
            Dim cmd2 As New SqlCommand("
                UPDATE Books
                SET BookStatus = 'Available'
                WHERE Title = @BookTitle
            ", con)

            cmd2.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
            cmd2.ExecuteNonQuery()

        End Using


        ' ===========================
        ' 3. SEND RETURN RECEIPT EMAIL
        ' ===========================
        SendReturnReceiptEmail(CurrentUserID, SelectedBookTitle)


        ' Refresh CurrentlyReading form
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is CurrentlyReading Then
                CType(frm, CurrentlyReading).LoadCurrentlyReading()
            End If
        Next

        ' Redirect to AlreadyRead
        AlreadyRead.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentlyReading.Show()
        Me.Close()
    End Sub


    ' ========================================================
    ' EMAIL SENDING FUNCTION FOR RETURN RECEIPT
    ' ========================================================
    Private Sub SendReturnReceiptEmail(userID As Integer, bookTitle As String)
        Try
            ' Get email of the user
            Dim email As String = GetUserEmail(userID)
            If String.IsNullOrEmpty(email) Then Return

            Dim mail As New MailMessage()
            mail.From = New MailAddress("yourlibrary@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Book Returned Successfully"
            mail.Body =
                "Good day!" & vbCrLf &
                "You have successfully returned the book: " & bookTitle & vbCrLf &
                "Return Date: " & DateTime.Now.ToString("f") & vbCrLf & vbCrLf &
                "Thank you for using our Library System!"

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential("LibraSys2@gmail.com", "lbnuohbdwibniykm")

            smtp.Send(mail)

        Catch ex As Exception
            MessageBox.Show("Failed to send email receipt: " & ex.Message)
        End Try
    End Sub


    ' ========================================================
    ' GET EMAIL OF USER
    ' ========================================================
    Private Function GetUserEmail(userID As Integer) As String
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim cmd As New SqlCommand("
                    SELECT Email FROM Users WHERE UserID = @UserID
                ", con)

                cmd.Parameters.AddWithValue("@UserID", userID)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Return result.ToString()
                End If

            End Using
        Catch
        End Try

        Return ""
    End Function

End Class
