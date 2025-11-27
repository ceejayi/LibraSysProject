Imports System.Data.SqlClient
Imports System.Diagnostics

Public Class CurrentlyReading

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    ' Selected book variables
    Private selectedBookPanel As Panel = Nothing
    Private selectedBookPDFPath As String = ""
    Private selectedBookTitle As String = ""
    Private selectedBookAuthor As String = ""
    Private selectedBookGenre As String = ""
    Private selectedBookDescription As String = ""
    Private selectedBookCoverPath As String = ""

    Private Sub CurrentlyReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentlyReadingg.FlowDirection = FlowDirection.LeftToRight
        currentlyReadingg.WrapContents = False
        currentlyReadingg.AutoScroll = True
        LoadCurrentlyReading()
    End Sub

    Public Sub LoadCurrentlyReading()
        currentlyReadingg.Controls.Clear()

        Dim dtBooks As New DataTable()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT b.Title, b.PicturePath, b.SoftCopyPath, b.Author, b.Genre, b.Description
                FROM BorrowedBooks bb
                INNER JOIN Books b ON bb.BookTitle = b.Title
                WHERE bb.UserID = @UserID AND bb.ReturnDate IS NULL
                ORDER BY bb.BorrowDate DESC
            ", con)
            cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dtBooks)
        End Using

        If dtBooks.Rows.Count = 0 Then
            Dim lblNoBooks As New Label()
            lblNoBooks.Text = "No currently borrowed books."
            lblNoBooks.Font = New Font("Arial", 14, FontStyle.Bold)
            lblNoBooks.AutoSize = True
            lblNoBooks.Margin = New Padding(5)
            currentlyReadingg.Controls.Add(lblNoBooks)
            Return
        End If

        For Each row As DataRow In dtBooks.Rows
            Dim title As String = row("Title").ToString()
            Dim picPath As String = row("PicturePath").ToString()
            Dim pdfPath As String = row("SoftCopyPath").ToString()
            Dim author As String = row("Author").ToString()
            Dim genre As String = row("Genre").ToString()
            Dim description As String = row("Description").ToString()

            Dim bookPanel As New Panel()
            bookPanel.Width = 120
            bookPanel.Height = 220
            bookPanel.Margin = New Padding(10, 5, 5, 5)
            bookPanel.Cursor = Cursors.Hand
            bookPanel.Tag = New With {
                .Title = title,
                .PDFPath = pdfPath,
                .Author = author,
                .Genre = genre,
                .Description = description,
                .CoverPath = picPath
            }

            ' Cover
            Dim coverPanel As New Panel()
            coverPanel.Width = 120
            coverPanel.Height = 170
            If System.IO.File.Exists(picPath) Then
                coverPanel.BackgroundImage = Image.FromFile(picPath)
                coverPanel.BackgroundImageLayout = ImageLayout.Stretch
            Else
                coverPanel.BackColor = Color.Gray
            End If
            bookPanel.Controls.Add(coverPanel)

            ' Title label
            Dim lblTitle As New Label()
            lblTitle.Text = title
            lblTitle.Top = coverPanel.Bottom + 5
            lblTitle.Width = coverPanel.Width
            lblTitle.Height = 40
            lblTitle.TextAlign = ContentAlignment.MiddleCenter
            lblTitle.AutoEllipsis = True
            bookPanel.Controls.Add(lblTitle)

            AddHandler bookPanel.Click, AddressOf BookPanel_Click
            AddHandler coverPanel.Click, AddressOf BookPanel_Click
            AddHandler lblTitle.Click, AddressOf BookPanel_Click

            currentlyReadingg.Controls.Add(bookPanel)
        Next
    End Sub

    Private Sub BookPanel_Click(sender As Object, e As EventArgs)
        Dim ctrl As Control = CType(sender, Control)
        While ctrl IsNot Nothing AndAlso ctrl.Tag Is Nothing
            ctrl = ctrl.Parent
        End While
        If ctrl Is Nothing Then Return

        If selectedBookPanel IsNot Nothing Then selectedBookPanel.BackColor = Color.Transparent

        selectedBookPanel = CType(ctrl, Panel)
        selectedBookPanel.BackColor = Color.LightBlue

        Dim bookInfo = selectedBookPanel.Tag
        selectedBookTitle = bookInfo.Title
        selectedBookPDFPath = bookInfo.PDFPath
        selectedBookAuthor = bookInfo.Author
        selectedBookGenre = bookInfo.Genre
        selectedBookDescription = bookInfo.Description
        selectedBookCoverPath = bookInfo.CoverPath
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If String.IsNullOrEmpty(selectedBookPDFPath) OrElse Not System.IO.File.Exists(selectedBookPDFPath) Then
            MessageBox.Show("Please select a book to read.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Process.Start(New ProcessStartInfo(selectedBookPDFPath) With {.UseShellExecute = True})
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If selectedBookPanel Is Nothing Then
            MessageBox.Show("Please select a book to return.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim returnForm As New ReturnForm()
        If System.IO.File.Exists(selectedBookCoverPath) Then
            returnForm.Panel2.BackgroundImage = Image.FromFile(selectedBookCoverPath)
            returnForm.Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Else
            returnForm.Panel2.BackColor = Color.Gray
        End If

        returnForm.lblTitle.Text = selectedBookTitle
        returnForm.lblAuthorGenre.Text = selectedBookAuthor & Environment.NewLine & selectedBookGenre
        returnForm.lblDescription.Text = selectedBookDescription
        returnForm.selectedBookTitle = selectedBookTitle

        returnForm.Show()
        Me.Hide()
    End Sub

    ' Navigation buttons
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AlreadyRead.Show()
        Me.Hide()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Welcome.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ServiceFeedback.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyReviews.Show()
        Me.Hide()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Refresh()
        LoadCurrentlyReading()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WantToRead.Show()
        Me.Hide()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserMainPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BorrowHistory.Show()
        Me.Hide()
    End Sub
End Class
