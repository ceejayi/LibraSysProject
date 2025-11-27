Imports System.Data.SqlClient

Public Class CurrentlyReading

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub CurrentlyReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure FlowLayoutPanel
        currentlyReadingg.FlowDirection = FlowDirection.LeftToRight
        currentlyReadingg.WrapContents = False
        currentlyReadingg.AutoScroll = True

        LoadCurrentlyReading()
    End Sub

    ' Load borrowed books that have not been returned yet
    Private Sub LoadCurrentlyReading()
        currentlyReadingg.Controls.Clear()

        Dim dtBooks As New DataTable()

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT b.Title, b.PicturePath 
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

        ' Add each book as a panel with image
        For Each row As DataRow In dtBooks.Rows
            Dim title As String = row("Title").ToString()
            Dim picPath As String = row("PicturePath").ToString()

            Dim bookPanel As New Panel()
            bookPanel.Width = 120
            bookPanel.Height = 180
            bookPanel.Margin = New Padding(10, 5, 5, 5)
            bookPanel.Cursor = Cursors.Hand
            bookPanel.Tag = title ' store title for click event

            Dim coverPanel As New Panel()
            coverPanel.Width = 140
            coverPanel.Height = 170
            If System.IO.File.Exists(picPath) Then
                coverPanel.BackgroundImage = Image.FromFile(picPath)
                coverPanel.BackgroundImageLayout = ImageLayout.Stretch
            Else
                coverPanel.BackColor = Color.Gray
            End If
            bookPanel.Controls.Add(coverPanel)

            Dim lblTitle As New Label()
            lblTitle.Text = title
            lblTitle.Top = coverPanel.Bottom + 5
            lblTitle.Width = coverPanel.Width  ' match width ng cover
            lblTitle.Height = 40               ' sapat para makita ang title
            lblTitle.TextAlign = ContentAlignment.MiddleCenter
            lblTitle.AutoEllipsis = True
            bookPanel.Controls.Add(lblTitle)

            ' Adjust bookPanel height para kasya ang cover at label
            bookPanel.Width = coverPanel.Width
            bookPanel.Height = coverPanel.Height + lblTitle.Height + 10


            AddHandler bookPanel.Click, AddressOf BookPanel_Click
            AddHandler coverPanel.Click, AddressOf BookPanel_Click
            AddHandler lblTitle.Click, AddressOf BookPanel_Click

            currentlyReadingg.Controls.Add(bookPanel)
        Next
    End Sub

    ' Open BookChosen form when a book is clicked
    Private Sub BookPanel_Click(sender As Object, e As EventArgs)
        Dim ctrl As Control = CType(sender, Control)
        While ctrl IsNot Nothing AndAlso ctrl.Tag Is Nothing
            ctrl = ctrl.Parent
        End While
        If ctrl Is Nothing Then Return

        Dim bookTitle As String = ctrl.Tag.ToString()

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Books WHERE Title=@title", con)
            cmd.Parameters.AddWithValue("@title", bookTitle)

            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    BookChosen.bookTitle = reader("Title").ToString()
                    BookChosen.bookAuthor = reader("Author").ToString()
                    BookChosen.bookGenre = reader("Genre").ToString()
                    BookChosen.bookDescription = reader("Description").ToString()
                    BookChosen.bookCoverPath = reader("PicturePath").ToString()
                    BookChosen.bookFile = reader("SoftCopyPath").ToString()
                End If
            End Using
        End Using

        Dim chosen As New BookChosen()
        chosen.Show()
        Me.Hide()
    End Sub

    ' ---------------- NAVIGATION BUTTONS ----------------
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

    Private Sub currentlyReadingg_Paint(sender As Object, e As PaintEventArgs) Handles currentlyReadingg.Paint

    End Sub
End Class
