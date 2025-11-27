Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UserMainPage

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub UserMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanelGenres.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanelGenres.WrapContents = False
        FlowLayoutPanelGenres.AutoScroll = True

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Title")
        ComboBox1.Items.Add("Author")
        ComboBox1.Items.Add("Year Published")
        ComboBox1.Items.Add("Genre")
        ComboBox1.SelectedIndex = 0

        LoadNetflixStyleHomepage()
    End Sub

    ' ----------------- LOAD HOME PAGE ----------------------
    Private Sub LoadNetflixStyleHomepage()
        FlowLayoutPanelGenres.Controls.Clear()

        Dim dtBooks As New DataTable()

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT Title, PicturePath, Genre FROM Books ORDER BY Genre, Title", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dtBooks)
        End Using

        Dim genres = dtBooks.AsEnumerable().Select(Function(r) r.Field(Of String)("Genre")).Distinct().ToList()

        For Each genre In genres
            Dim lblGenre As New Label()
            lblGenre.Text = genre
            lblGenre.Font = New Font("Arial", 14, FontStyle.Bold)
            lblGenre.AutoSize = True
            lblGenre.Margin = New Padding(5)
            FlowLayoutPanelGenres.Controls.Add(lblGenre)

            Dim panelGenre As New FlowLayoutPanel()
            panelGenre.Width = FlowLayoutPanelGenres.ClientSize.Width - 25
            panelGenre.Height = 208
            panelGenre.FlowDirection = FlowDirection.LeftToRight
            panelGenre.WrapContents = False
            panelGenre.AutoScroll = True
            panelGenre.Margin = New Padding(0, 0, 0, 20)

            Dim booksInGenre = dtBooks.AsEnumerable().Where(Function(r) r.Field(Of String)("Genre") = genre)

            For Each row In booksInGenre
                Dim title As String = row.Field(Of String)("Title")
                Dim picPath As String = row.Field(Of String)("PicturePath")

                Dim bookPanel As New Panel()
                bookPanel.Width = 120
                bookPanel.Height = 180
                bookPanel.Margin = New Padding(10, 5, 5, 5)
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

                panelGenre.Controls.Add(bookPanel)
            Next

            FlowLayoutPanelGenres.Controls.Add(panelGenre)
        Next
    End Sub

    ' ----------------- WHEN BOOK IS CLICKED ----------------------
    Private Sub BookPanel_Click(sender As Object, e As EventArgs)
        Dim ctrl As Control = CType(sender, Control)

        While ctrl IsNot Nothing AndAlso ctrl.Tag Is Nothing
            ctrl = ctrl.Parent
        End While

        If ctrl Is Nothing Then Return

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

    ' ----------------- SEARCH BUTTON ----------------------
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim keyword As String = TextBox1.Text.Trim()
        Dim filter As String = ComboBox1.SelectedItem.ToString()

        FlowLayoutPanelGenres.Controls.Clear()

        If keyword = "" Then
            LoadNetflixStyleHomepage()
            Return
        End If

        Dim query As String = ""

        Select Case filter
            Case "Title"
                query = "SELECT Title, PicturePath, Genre FROM Books WHERE Title LIKE @keyword ORDER BY Genre, Title"
            Case "Author"
                query = "SELECT Title, PicturePath, Genre FROM Books WHERE Author LIKE @keyword ORDER BY Genre, Title"
            Case "Year Published"
                query = "SELECT Title, PicturePath, Genre FROM Books WHERE PublishedYear LIKE @keyword ORDER BY Genre, Title"
            Case "Genre"
                query = "SELECT Title, PicturePath, Genre FROM Books WHERE Genre LIKE @keyword ORDER BY Genre, Title"
        End Select

        Dim dtBooks As New DataTable()

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dtBooks)
        End Using

        If dtBooks.Rows.Count = 0 Then
            Dim lblNoResult As New Label()
            lblNoResult.Text = "No results found for: " & keyword
            lblNoResult.Font = New Font("Arial", 14, FontStyle.Bold)
            lblNoResult.AutoSize = True
            lblNoResult.Margin = New Padding(5)
            FlowLayoutPanelGenres.Controls.Add(lblNoResult)
            Return
        End If

        Dim genres = dtBooks.AsEnumerable().Select(Function(r) r.Field(Of String)("Genre")).Distinct().ToList()

        For Each genre In genres
            Dim lblGenre As New Label()
            lblGenre.Text = "Search results in " & genre
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

            Dim booksInGenre = dtBooks.AsEnumerable().Where(Function(r) r.Field(Of String)("Genre") = genre)

            For Each row In booksInGenre
                Dim title As String = row.Field(Of String)("Title")
                Dim picPath As String = row.Field(Of String)("PicturePath")

                Dim bookPanel As New Panel()
                bookPanel.Width = 120
                bookPanel.Height = 180
                bookPanel.Margin = New Padding(10, 5, 5, 5)
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

                panelGenre.Controls.Add(bookPanel)
            Next

            FlowLayoutPanelGenres.Controls.Add(panelGenre)
        Next
    End Sub

    ' LOGOUT
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim welcomeForm As New Welcome()
            welcomeForm.Show()
            Me.Hide()
        End If
    End Sub

    ' BORROW HISTORY
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim navForm As New BorrowHistory()
        navForm.Show()
        Me.Close()
    End Sub

End Class
