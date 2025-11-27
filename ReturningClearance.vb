Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Public Class ReturningClearance
    Public connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Public SelectedBookTitle As String = ""
    Public CurrentUserID As Integer

    Private Sub ReturningClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ==========================
        ' Placeholder setup
        ' ==========================
        TextBox1.Text = "Enter admin password..."
        TextBox1.ForeColor = Color.Gray
        TextBox1.UseSystemPasswordChar = False

        ' ==========================
        ' Checkbox for showing/hiding password
        ' ==========================
        chk.Text = "Hide Password"
        chk.Checked = False
        AddHandler chk.CheckedChanged, AddressOf chk_CheckedChanged

        ' ==========================
        ' GotFocus: remove placeholder
        ' ==========================
        AddHandler TextBox1.GotFocus, Sub()
                                          If TextBox1.Text = "Enter admin password..." Then
                                              TextBox1.Text = ""
                                              TextBox1.ForeColor = Color.Black
                                          End If
                                          ApplyPasswordMask()
                                      End Sub

        ' ==========================
        ' LostFocus: restore placeholder if empty
        ' ==========================
        AddHandler TextBox1.LostFocus, Sub()
                                           If String.IsNullOrWhiteSpace(TextBox1.Text) Then
                                               TextBox1.Text = "Enter admin password..."
                                               TextBox1.ForeColor = Color.Gray
                                           End If
                                           ApplyPasswordMask()
                                       End Sub

        ' ==========================
        ' TextChanged: update mask dynamically
        ' ==========================
        AddHandler TextBox1.TextChanged, Sub() ApplyPasswordMask()
    End Sub

    ' ==========================
    ' Toggle password masking
    ' ==========================
    Private Sub ApplyPasswordMask()
        If TextBox1.Text = "Enter admin password..." Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = chk.Checked
        End If
    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs)
        ApplyPasswordMask()
    End Sub

    ' ==========================
    ' Clear returned book
    ' ==========================
    Private Sub btnCleared_Click(sender As Object, e As EventArgs) Handles btnCleared.Click
        Dim passwordEntered As String = TextBox1.Text.Trim()
        If passwordEntered = "" OrElse passwordEntered = "Enter admin password..." Then
            MessageBox.Show("Please enter admin password to confirm.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Validate admin password
            Dim cmdAdmin As New SqlCommand("SELECT COUNT(*) FROM Admins WHERE Password=@pass", con)
            cmdAdmin.Parameters.AddWithValue("@pass", passwordEntered)
            If CInt(cmdAdmin.ExecuteScalar()) = 0 Then
                MessageBox.Show("Incorrect admin password. Return clearance failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Determine book condition based on RadioButtons
            Dim bookCondition As String = ""
            If RadioButton1.Checked Then
                bookCondition = "Damaged"
            ElseIf RadioButton2.Checked Then
                bookCondition = "Lost"
            ElseIf RadioButton3.Checked Then
                bookCondition = "Good"
            ElseIf RadioButton4.Checked Then
                bookCondition = TextBox2.Text.Trim()
            End If

            ' Update BorrowedBooks table with condition and return date
            Dim cmdBorrowed As New SqlCommand("
            UPDATE BorrowedBooks
            SET ReturnDate=@ReturnDate, Condition=@Condition
            WHERE BookTitle=@BookTitle AND UserID=@UserID AND ReturnDate IS NULL
        ", con)
            cmdBorrowed.Parameters.AddWithValue("@ReturnDate", DateTime.Now)
            cmdBorrowed.Parameters.AddWithValue("@Condition", bookCondition)
            cmdBorrowed.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
            cmdBorrowed.Parameters.AddWithValue("@UserID", CurrentUserID)
            cmdBorrowed.ExecuteNonQuery()

            ' Update Books table
            Dim bookStatus As String = "Available"
            If bookCondition = "Damaged" Or bookCondition = "Lost" Or (RadioButton4.Checked AndAlso TextBox2.Text.Trim() <> "Good") Then
                bookStatus = "Unavailable" ' cannot be borrowed
            End If

            Dim cmdBooks As New SqlCommand("
            UPDATE Books
            SET BookStatus=@BookStatus
            WHERE Title=@BookTitle
        ", con)
            cmdBooks.Parameters.AddWithValue("@BookStatus", bookStatus)
            cmdBooks.Parameters.AddWithValue("@BookTitle", SelectedBookTitle)
            cmdBooks.ExecuteNonQuery()
        End Using

        ' Refresh open forms
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is CurrentlyReading Then CType(frm, CurrentlyReading).LoadCurrentlyReading()
            If TypeOf frm Is AlreadyRead Then CType(frm, AlreadyRead).LoadAlreadyRead()
        Next

        ' Send email
        SendReturnReceiptEmail(CurrentUserID, SelectedBookTitle)

        MessageBox.Show("Book successfully returned and cleared.", "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        AlreadyRead.Show()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentlyReading.Show()
        Me.Close()
    End Sub

    ' ==========================
    ' Send email receipt
    ' ==========================
    Private Sub SendReturnReceiptEmail(userID As Integer, bookTitle As String)
        Try
            Dim email As String = GetUserEmail(userID)
            If String.IsNullOrEmpty(email) Then Return

            Dim mail As New MailMessage()
            mail.From = New MailAddress("LibraSys2@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Book Returned Successfully"
            mail.Body = $"Good day!{vbCrLf}You have successfully returned the book: {bookTitle}{vbCrLf}Return Date: {DateTime.Now:f}{vbCrLf}{vbCrLf}Thank you for using our Library System!"

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential("LibraSys2@gmail.com", "lbnuohbdwibniykm")
            smtp.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Failed to send email receipt: " & ex.Message)
        End Try
    End Sub

    ' ==========================
    ' Get user email
    ' ==========================
    Private Function GetUserEmail(userID As Integer) As String
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT Email FROM Users WHERE UserID=@UserID", con)
                cmd.Parameters.AddWithValue("@UserID", userID)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then Return result.ToString()
            End Using
        Catch
        End Try
        Return ""
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
