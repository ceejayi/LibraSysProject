Imports System.Data.SqlClient

Public Class AlreadyRead
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub AlreadyRead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alreadyReadd.FlowDirection = FlowDirection.LeftToRight
        alreadyReadd.WrapContents = False
        alreadyReadd.AutoScroll = True
        LoadAlreadyRead()
    End Sub

    Public Sub LoadAlreadyRead()
        alreadyReadd.Controls.Clear()
        Dim dtBooks As New DataTable()

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT b.Title, b.PicturePath, b.Author, b.Genre, b.Description,
                       bb.BorrowDate, bb.ReturnDate
                FROM BorrowedBooks bb
                INNER JOIN Books b ON bb.BookTitle = b.Title
                WHERE bb.UserID=@UserID AND bb.ReturnDate IS NOT NULL
                ORDER BY bb.ReturnDate DESC
            ", con)
            cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dtBooks)
        End Using

        If dtBooks.Rows.Count = 0 Then
            Dim lblNoBooks As New Label() With {
                .Text = "No returned books yet.",
                .Font = New Font("Arial", 14, FontStyle.Bold),
                .AutoSize = True,
                .Margin = New Padding(5)
            }
            alreadyReadd.Controls.Add(lblNoBooks)
            Return
        End If

        For Each row As DataRow In dtBooks.Rows
            Dim title = row("Title").ToString()
            Dim picPath = row("PicturePath").ToString()
            Dim author = row("Author").ToString()
            Dim genre = row("Genre").ToString()
            Dim description = row("Description").ToString()
            Dim borrowDate As Date = Convert.ToDateTime(row("BorrowDate"))
            Dim returnDate As Date = Convert.ToDateTime(row("ReturnDate"))

            Dim bookPanel As New Panel() With {
                .Width = 120,
                .Height = 220,
                .Margin = New Padding(10, 5, 5, 5),
                .Cursor = Cursors.Hand,
                .Tag = New With {
                    .Title = title,
                    .Author = author,
                    .Genre = genre,
                    .Description = description,
                    .CoverPath = picPath,
                    .BorrowDate = borrowDate,
                    .ReturnDate = returnDate
                }
            }

            Dim coverPanel As New Panel() With {.Width = 120, .Height = 170}
            If System.IO.File.Exists(picPath) Then
                coverPanel.BackgroundImage = Image.FromFile(picPath)
                coverPanel.BackgroundImageLayout = ImageLayout.Stretch
            Else
                coverPanel.BackColor = Color.Gray
            End If
            bookPanel.Controls.Add(coverPanel)

            Dim lblTitle As New Label() With {
                .Text = title,
                .Top = coverPanel.Bottom + 5,
                .Width = coverPanel.Width,
                .Height = 40,
                .TextAlign = ContentAlignment.MiddleCenter,
                .AutoEllipsis = True
            }
            bookPanel.Controls.Add(lblTitle)

            AddHandler bookPanel.Click, AddressOf BookPanel_Click
            AddHandler coverPanel.Click, AddressOf BookPanel_Click
            AddHandler lblTitle.Click, AddressOf BookPanel_Click

            alreadyReadd.Controls.Add(bookPanel)
        Next
    End Sub

    Private Sub BookPanel_Click(sender As Object, e As EventArgs)
        Dim ctrl As Control = CType(sender, Control)
        While ctrl IsNot Nothing AndAlso ctrl.Tag Is Nothing
            ctrl = ctrl.Parent
        End While
        If ctrl Is Nothing Then Return

        Dim bookInfo = ctrl.Tag

        MessageBox.Show($"{bookInfo.Title}" & vbCrLf &
                        $"Author: {bookInfo.Author}" & vbCrLf &
                        $"Genre: {bookInfo.Genre}" & vbCrLf &
                        $"Borrowed On: {bookInfo.BorrowDate:MMMM dd, yyyy}" & vbCrLf &
                        $"Returned On: {bookInfo.ReturnDate:MMMM dd, yyyy}",
                        "Returned Book Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WantToRead.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CurrentlyReading.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BorrowHistory.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyReviews.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ServiceFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserMainPage.Show()
        Me.Hide()
    End Sub
End Class
