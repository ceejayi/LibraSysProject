Imports System.Data.SqlClient

Public Class UserMainPage
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub UserMainPagee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanelGenres.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanelGenres.WrapContents = False
        FlowLayoutPanelGenres.AutoScroll = True

        LoadNetflixStyleHomepage()
    End Sub

    Private Sub LoadNetflixStyleHomepage()
        FlowLayoutPanelGenres.Controls.Clear()
        Dim genres As New List(Of String)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmdGenres As New SqlCommand("SELECT DISTINCT Genre FROM Books", con)
            Using reader = cmdGenres.ExecuteReader()
                While reader.Read()
                    genres.Add(reader("Genre").ToString())
                End While
            End Using
        End Using

        For Each genre In genres
            Dim lblGenre As New Label()
            lblGenre.Text = genre
            lblGenre.Font = New Font("Arial", 14, FontStyle.Bold)
            lblGenre.AutoSize = True
            lblGenre.Margin = New Padding(5)
            FlowLayoutPanelGenres.Controls.Add(lblGenre)

            Dim panelGenre As New FlowLayoutPanel()
            panelGenre.Width = FlowLayoutPanelGenres.ClientSize.Width - 25
            panelGenre.Height = 200
            panelGenre.FlowDirection = FlowDirection.LeftToRight
            panelGenre.WrapContents = False
            panelGenre.AutoScroll = True
            panelGenre.Margin = New Padding(0, 0, 0, 30)

            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmdBooks As New SqlCommand("SELECT Title, PicturePath FROM Books WHERE Genre=@genre", con)
                cmdBooks.Parameters.AddWithValue("@genre", genre)

                Using readerBooks = cmdBooks.ExecuteReader()
                    While readerBooks.Read()
                        Dim title As String = readerBooks("Title").ToString()
                        Dim picPath As String = readerBooks("PicturePath").ToString()

                        Dim bookPanel As New Panel()
                        bookPanel.Width = 120
                        bookPanel.Height = 180
                        bookPanel.Margin = New Padding(5)
                        bookPanel.Cursor = Cursors.Hand
                        bookPanel.Tag = New With {.Title = title, .Genre = genre, .PicturePath = picPath}

                        ' Panel for book cover
                        Dim coverPanel As New Panel()
                        coverPanel.Width = 120
                        coverPanel.Height = 140
                        If System.IO.File.Exists(picPath) Then
                            coverPanel.BackgroundImage = Image.FromFile(picPath)
                            coverPanel.BackgroundImageLayout = ImageLayout.Stretch
                        Else
                            coverPanel.BackColor = Color.Gray
                        End If
                        coverPanel.Cursor = Cursors.Hand
                        bookPanel.Controls.Add(coverPanel)

                        ' Title label below cover
                        Dim lblTitle As New Label()
                        lblTitle.Text = title
                        lblTitle.Top = coverPanel.Bottom + 5
                        lblTitle.Width = 120
                        lblTitle.TextAlign = ContentAlignment.MiddleCenter
                        lblTitle.AutoEllipsis = True
                        bookPanel.Controls.Add(lblTitle)

                        ' Click handlers
                        AddHandler bookPanel.Click, AddressOf BookPanel_Click
                        AddHandler coverPanel.Click, AddressOf BookPanel_Click
                        AddHandler lblTitle.Click, AddressOf BookPanel_Click

                        panelGenre.Controls.Add(bookPanel)
                    End While
                End Using
            End Using

            FlowLayoutPanelGenres.Controls.Add(panelGenre)
        Next
    End Sub

    Private Sub BookPanel_Click(sender As Object, e As EventArgs)
        Dim ctrl As Control = CType(sender, Control)

        ' Walk up the parent chain until we find a control with Tag
        While ctrl IsNot Nothing AndAlso ctrl.Tag Is Nothing
            ctrl = ctrl.Parent
        End While

        If ctrl Is Nothing Then Return ' safety check

        Dim bookInfo = ctrl.Tag

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Books WHERE Title=@title", con)
            cmd.Parameters.AddWithValue("@title", bookInfo.Title)

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

    '-------------------- SEARCH BUTTON -------------------------
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim keyword As String = TextBox1.Text.Trim()
        If keyword = "" Then
            LoadNetflixStyleHomepage()
            Return
        End If

        FlowLayoutPanelGenres.Controls.Clear()

        Dim lblSearch As New Label()
        lblSearch.Text = "Search results for: " & keyword
        lblSearch.Font = New Font("Arial", 14, FontStyle.Bold)
        lblSearch.AutoSize = True
        lblSearch.Margin = New Padding(5)
        FlowLayoutPanelGenres.Controls.Add(lblSearch)

        Dim resultPanel As New FlowLayoutPanel()
        resultPanel.Width = FlowLayoutPanelGenres.ClientSize.Width - 25
        resultPanel.Height = 200
        resultPanel.FlowDirection = FlowDirection.LeftToRight
        resultPanel.WrapContents = False
        resultPanel.AutoScroll = True
        resultPanel.Margin = New Padding(0, 0, 0, 30)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmdSearch As New SqlCommand("SELECT Title, PicturePath, Genre FROM Books WHERE Title LIKE @keyword", con)
            cmdSearch.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Using readerBooks = cmdSearch.ExecuteReader()
                While readerBooks.Read()
                    Dim title As String = readerBooks("Title").ToString()
                    Dim picPath As String = readerBooks("PicturePath").ToString()
                    Dim genre As String = readerBooks("Genre").ToString()

                    Dim bookPanel As New Panel()
                    bookPanel.Width = 120
                    bookPanel.Height = 180
                    bookPanel.Margin = New Padding(5)
                    bookPanel.Cursor = Cursors.Hand
                    bookPanel.Tag = New With {.Title = title, .Genre = genre, .PicturePath = picPath}

                    Dim coverPanel As New Panel()
                    coverPanel.Width = 120
                    coverPanel.Height = 140
                    If System.IO.File.Exists(picPath) Then
                        coverPanel.BackgroundImage = Image.FromFile(picPath)
                        coverPanel.BackgroundImageLayout = ImageLayout.Stretch
                    Else
                        coverPanel.BackColor = Color.Gray
                    End If
                    coverPanel.Cursor = Cursors.Hand
                    bookPanel.Controls.Add(coverPanel)

                    Dim lblTitle As New Label()
                    lblTitle.Text = title
                    lblTitle.Top = coverPanel.Bottom + 5
                    lblTitle.Width = 120
                    lblTitle.TextAlign = ContentAlignment.MiddleCenter
                    lblTitle.AutoEllipsis = True
                    bookPanel.Controls.Add(lblTitle)

                    AddHandler bookPanel.Click, AddressOf BookPanel_Click
                    AddHandler coverPanel.Click, AddressOf BookPanel_Click
                    AddHandler lblTitle.Click, AddressOf BookPanel_Click

                    resultPanel.Controls.Add(bookPanel)
                End While
            End Using
        End Using

        FlowLayoutPanelGenres.Controls.Add(resultPanel)
    End Sub

    ' LOGOUT BUTTON
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim welcomeForm As New Welcome()
            welcomeForm.Show()
            Me.Close()
        End If
    End Sub

    ' NAVIGATION BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim navForm As New UserNavigation()
        navForm.Show()
        Me.Close()
    End Sub
End Class
