Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net

Public Class ClearanceForm
    PUblic connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Private currentUserID As Integer
    Private currentUserRole As String
    Private currentUserEmail As String
    Private selectedBookTitle As String = BookChosen.bookTitle

    Private Sub ClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load current logged-in user info from UserLogs joined to Users
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT TOP 1 u.UserID, u.Role, u.Email
                FROM UserLogs ul
                INNER JOIN Users u ON ul.UserID = u.UserID
                ORDER BY ul.LogID DESC
            ", con)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    currentUserID = CInt(reader("UserID"))
                    currentUserRole = reader("Role").ToString()
                    currentUserEmail = reader("Email").ToString()
                Else
                    MessageBox.Show("No logged-in user found in UserLogs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return
                End If
            End Using
        End Using

        ' Placeholder setup
        TextBox1.Text = "Enter your password..."
        TextBox1.ForeColor = Color.Gray
        TextBox1.UseSystemPasswordChar = False ' Disable password char for placeholder

        ' Configure checkbox
        chk.Text = "Hide Password"
        chk.Checked = False
        AddHandler chk.CheckedChanged, AddressOf chk_CheckedChanged

        ' GotFocus
        AddHandler TextBox1.GotFocus, Sub()
                                          If TextBox1.Text = "Enter your password..." Then
                                              TextBox1.Text = ""
                                              TextBox1.ForeColor = Color.Black
                                          End If
                                          ApplyPasswordMask()
                                      End Sub

        ' LostFocus
        AddHandler TextBox1.LostFocus, Sub()
                                           If TextBox1.Text = "" Then
                                               TextBox1.Text = "Enter your password..."
                                               TextBox1.ForeColor = Color.Gray
                                           End If
                                           ApplyPasswordMask()
                                       End Sub

        ' TextChanged (for typing)
        AddHandler TextBox1.TextChanged, Sub()
                                             ApplyPasswordMask()
                                         End Sub

        ' Add Terms and Conditions dynamically to Panel2
        Dim lblTerms As New Label()
        lblTerms.Text = "TERMS AND CONDITIONS:" & vbCrLf &
                        "1. Students may borrow a maximum of 3 books at a time." & vbCrLf &
                        "2. Faculty/Professors may borrow a maximum of 5 books at a time." & vbCrLf &
                        "3. Books must be returned within 1 week. Late returns incur a penalty of 20 pesos/day." & vbCrLf &
                        "4. Damaged books may incur additional penalties depending on the severity." & vbCrLf &
                        "5. Borrowing requires admin password confirmation." & vbCrLf &
                        "6. By clicking Borrow, you acknowledge these terms."
        lblTerms.Font = New Font("Arial", 12)
        lblTerms.AutoSize = True
        lblTerms.MaximumSize = New Size(Panel2.Width - 10, 0)
        Panel2.Controls.Add(lblTerms)
    End Sub

    ' Centralized password masking logic
    Private Sub ApplyPasswordMask()
        If TextBox1.Text = "Enter your password..." Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = chk.Checked
        End If
    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs)
        ApplyPasswordMask()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim passwordEntered As String = TextBox1.Text.Trim()

        If passwordEntered = "" OrElse passwordEntered = "Enter your password..." Then
            MessageBox.Show("Please enter admin password to confirm.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Validate admin password
            Dim cmdAdmin As New SqlCommand("SELECT COUNT(*) FROM Admins WHERE Password=@pass", con)
            cmdAdmin.Parameters.AddWithValue("@pass", passwordEntered)
            If CInt(cmdAdmin.ExecuteScalar()) = 0 Then
                MessageBox.Show("Incorrect admin password. Borrowing failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check book availability
            Dim cmdBook As New SqlCommand("SELECT BookStatus FROM Books WHERE Title=@title", con)
            cmdBook.Parameters.AddWithValue("@title", selectedBookTitle)
            Dim bookStatus As Object = cmdBook.ExecuteScalar()
            If bookStatus Is Nothing Then
                MessageBox.Show("Book not found in the library.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            ElseIf bookStatus.ToString().ToLower() <> "available" Then
                MessageBox.Show("This book is currently unavailable and cannot be borrowed.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            ' Check borrowed books count for user
            Dim cmdCount As New SqlCommand("SELECT COUNT(*) FROM BorrowedBooks WHERE UserID=@uid AND ReturnDate IS NULL", con)
            cmdCount.Parameters.AddWithValue("@uid", currentUserID)
            Dim borrowedCount As Integer = CInt(cmdCount.ExecuteScalar())
            Dim maxAllowed As Integer = If(currentUserRole.Trim().ToLower() = "student", 3, 5)
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

            ' Update BookStatus to 'Borrowed'
            Dim cmdUpdate As New SqlCommand("UPDATE Books SET BookStatus='Borrowed' WHERE Title=@title", con)
            cmdUpdate.Parameters.AddWithValue("@title", selectedBookTitle)
            cmdUpdate.ExecuteNonQuery()
        End Using

        ' Send email
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("LibraSys2@gmail.com")
            mail.To.Add(currentUserEmail)
            mail.Subject = "Borrowing Confirmation – LibraSys"

            ' ------------------------
            ' Locate book cover image
            ' ------------------------
            Dim coverPath As String = $"C:\Users\LENOVO\source\repos\LibraSysProject\Resources\{selectedBookTitle}.jpg"
            Dim hasImage As Boolean = IO.File.Exists(coverPath)

            Dim htmlBody As String =
$"
<html>
<body style='font-family: Arial; color:#333333; line-height:1.6;'>
    <h2 style='color:#1a237e;'>Borrowing Confirmation</h2>

    <p>Hello,</p>

    <p>
        This email serves as an official confirmation that you have successfully borrowed a book from 
        <strong>LibraSys Library System</strong>.
    </p>

    <p style='margin-top:15px;'>
        <strong>Book Title:</strong> {selectedBookTitle}<br/>
        <strong>Borrowed On:</strong> {DateTime.Now:MMMM dd, yyyy hh:mm tt}<br/>
        <strong>Return On or Before:</strong> {DateTime.Now.AddDays(7):MMMM dd, yyyy}
    </p>

    <p>
        Kindly return the book on time to avoid penalties. Late returns incur a fee of 
        <strong>₱20 per day</strong>.
    </p>

    {(If(hasImage, "<h4>Book Cover:</h4><img src='cid:BookCover' style='width:200px; border-radius:8px;'/>", ""))}

    <br/><br/>
    <p>
        Thank you for using <strong>LibraSys</strong>. Should you have any concerns,
        feel free to reach out to the library staff.
    </p>

    <p style='margin-top:30px; font-size:13px; color:#777;'>
        — LibraSys Automated Borrowing System
    </p>
</body>
</html>
"

            mail.IsBodyHtml = True

            ' -------------------------
            ' Include book cover (inline + attachment)
            ' -------------------------
            If hasImage Then
                Dim inlineImage As New LinkedResource(coverPath)
                inlineImage.ContentId = "BookCover"

                Dim view As AlternateView =
            AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")
                view.LinkedResources.Add(inlineImage)
                mail.AlternateViews.Add(view)

                ' Also attach the image file itself
                mail.Attachments.Add(New Attachment(coverPath))
            Else
                mail.Body = htmlBody
            End If

            ' -------------------------
            ' SMTP CLIENT SETTINGS
            ' -------------------------
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("LibraSys2@gmail.com", "lbnuohbdwibniykm")
            smtp.EnableSsl = True

            smtp.Send(mail)

            MessageBox.Show("Borrowed successfully! A confirmation email has been sent.",
                    "Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Borrowed successfully, but failed to send email: " & ex.Message,
                    "Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


        UserMainPage.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserMainPage.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
