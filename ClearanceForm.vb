Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net

Public Class ClearanceForm
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Private currentUserID As Integer
    Private currentUserRole As String
    Private currentUserEmail As String
    Private selectedBookTitle As String = BookChosen.bookTitle

    Private Sub ClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load current logged-in user info
        currentUserID = LoginForm.loggedUserID
        currentUserRole = LoginForm.loggedUserRole
        currentUserEmail = LoginForm.loggedUserEmail

        ' Add Terms and Conditions dynamically to Panel2
        Dim lblTerms As New Label()
        lblTerms.Text = "TERMS AND CONDITIONS:" & vbCrLf &
                        "1. Students may borrow a maximum of 3 books at a time." & vbCrLf &
                        "2. Faculty/Professors may borrow a maximum of 5 books at a time." & vbCrLf &
                        "3. Books must be returned within 1 week. Late returns incur a penalty of 20 pesos/day." & vbCrLf &
                        "4. Damaged books may incur additional penalties depending on the severity." & vbCrLf &
                        "5. Borrowing requires your account password confirmation." & vbCrLf &
                        "6. By clicking Borrow, you acknowledge these terms."
        lblTerms.Font = New Font("Arial", 12)
        lblTerms.AutoSize = True
        lblTerms.MaximumSize = New Size(Panel2.Width - 10, 0)
        Panel2.Controls.Add(lblTerms)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim passwordEntered As String = TextBox1.Text.Trim()

        If passwordEntered = "" Then
            MessageBox.Show("Please enter your password to confirm.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Validate password
            Dim cmdPass As New SqlCommand("SELECT Password FROM Users WHERE UserID=@uid", con)
            cmdPass.Parameters.AddWithValue("@uid", currentUserID)
            Dim dbPassword = cmdPass.ExecuteScalar()

            If dbPassword Is Nothing OrElse dbPassword.ToString() <> passwordEntered Then
                MessageBox.Show("Incorrect password. Borrowing failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check borrowed books count
            Dim cmdCount As New SqlCommand("SELECT COUNT(*) FROM BorrowedBooks WHERE UserID=@uid AND ReturnDate IS NULL", con)
            cmdCount.Parameters.AddWithValue("@uid", currentUserID)
            Dim borrowedCount As Integer = CInt(cmdCount.ExecuteScalar())
            Dim maxAllowed As Integer = If(currentUserRole.ToLower() = "student", 3, 5)

            If borrowedCount >= maxAllowed Then
                MessageBox.Show($"You have reached the maximum borrow limit ({maxAllowed} books).", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Insert borrow record
            Dim cmdInsert As New SqlCommand("INSERT INTO BorrowedBooks(UserID, BookTitle, BorrowDate, ReturnDate) VALUES(@uid, @title, @borrowDate, NULL)", con)
            cmdInsert.Parameters.AddWithValue("@uid", currentUserID)
            cmdInsert.Parameters.AddWithValue("@title", selectedBookTitle)
            cmdInsert.Parameters.AddWithValue("@borrowDate", DateTime.Now)
            cmdInsert.ExecuteNonQuery()
        End Using

        ' --- Send email via Gmail SMTP ---
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("unsoncarljoshua@gmail.com") ' Replace with your Gmail
            mail.To.Add(currentUserEmail)
            mail.Subject = "LibraSys Borrow Confirmation"
            mail.Body = $"Hello,{Environment.NewLine}{Environment.NewLine}" &
                        $"You have successfully borrowed the book: {selectedBookTitle}.{Environment.NewLine}" &
                        $"Borrow Date: {DateTime.Now:dd/MM/yyyy HH:mm}{Environment.NewLine}" &
                        $"Please return within 1 week to avoid penalties.{Environment.NewLine}{Environment.NewLine}" &
                        $"Thank you, LibraSys"

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("unsoncarljoshua@gmail.com", "zquw uqsh wzit nzzz") ' <- Use Gmail App Password here
            smtp.EnableSsl = True
            smtp.Send(mail)

            MessageBox.Show("Borrowed successfully! A confirmation email has been sent.", "Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Borrowed successfully, but failed to send email: " & ex.Message, "Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        ' Return to main page
        UserMainPage.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Back to user main page
        UserMainPage.Show()
        Me.Close()
    End Sub
End Class
