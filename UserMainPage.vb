Imports System.Data.SqlClient

Public Class UserMainPage
    ' Connection string to your DB
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    ' Form Load
    Private Sub UserMainPagee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanelGenres.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanelGenres.WrapContents = False
        FlowLayoutPanelGenres.AutoScroll = True

        LoadNetflixStyleHomepage()
    End Sub

    ' Load Netflix-style homepage
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

                        Dim picBox As New PictureBox()
                        picBox.Width = 120
                        picBox.Height = 140
                        picBox.SizeMode = PictureBoxSizeMode.StretchImage
                        If System.IO.File.Exists(picPath) Then
                            picBox.Image = Image.FromFile(picPath)
                        Else
                            picBox.BackColor = Color.Gray
                        End If
                        bookPanel.Controls.Add(picBox)

                        Dim lblTitle As New Label()
                        lblTitle.Text = title
                        lblTitle.Top = picBox.Bottom + 5
                        lblTitle.Width = 120
                        lblTitle.TextAlign = ContentAlignment.MiddleCenter
                        lblTitle.AutoEllipsis = True
                        bookPanel.Controls.Add(lblTitle)

                        panelGenre.Controls.Add(bookPanel)
                    End While
                End Using
            End Using

            FlowLayoutPanelGenres.Controls.Add(panelGenre)
        Next
    End Sub

    '-------------------- SEARCH BUTTON FUNCTION -------------------------
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim keyword As String = TextBox1.Text.Trim()

        If keyword = "" Then
            LoadNetflixStyleHomepage()
            Return
        End If

        FlowLayoutPanelGenres.Controls.Clear()

        ' SEARCH RESULT HEADER
        Dim lblSearch As New Label()
        lblSearch.Text = "Search results for: " & keyword
        lblSearch.Font = New Font("Arial", 14, FontStyle.Bold)
        lblSearch.AutoSize = True
        lblSearch.Margin = New Padding(5)
        FlowLayoutPanelGenres.Controls.Add(lblSearch)

        ' PANEL FOR RESULTS
        Dim resultPanel As New FlowLayoutPanel()
        resultPanel.Width = FlowLayoutPanelGenres.ClientSize.Width - 25
        resultPanel.Height = 200
        resultPanel.FlowDirection = FlowDirection.LeftToRight
        resultPanel.WrapContents = False
        resultPanel.AutoScroll = True
        resultPanel.Margin = New Padding(0, 0, 0, 30)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmdSearch As New SqlCommand("SELECT Title, PicturePath FROM Books WHERE Title LIKE @keyword", con)
            cmdSearch.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Using readerBooks = cmdSearch.ExecuteReader()
                While readerBooks.Read()
                    Dim title As String = readerBooks("Title").ToString()
                    Dim picPath As String = readerBooks("PicturePath").ToString()

                    Dim bookPanel As New Panel()
                    bookPanel.Width = 120
                    bookPanel.Height = 180
                    bookPanel.Margin = New Padding(5)

                    Dim picBox As New PictureBox()
                    picBox.Width = 120
                    picBox.Height = 140
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage
                    If System.IO.File.Exists(picPath) Then
                        picBox.Image = Image.FromFile(picPath)
                    Else
                        picBox.BackColor = Color.Gray
                    End If
                    bookPanel.Controls.Add(picBox)

                    Dim lblTitle As New Label()
                    lblTitle.Text = title
                    lblTitle.Top = picBox.Bottom + 5
                    lblTitle.Width = 120
                    lblTitle.TextAlign = ContentAlignment.MiddleCenter
                    lblTitle.AutoEllipsis = True
                    bookPanel.Controls.Add(lblTitle)

                    resultPanel.Controls.Add(bookPanel)
                End While
            End Using
        End Using

        FlowLayoutPanelGenres.Controls.Add(resultPanel)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim welcomeForm As New Welcome()
            welcomeForm.Show()
            Me.Close() ' closes the current form
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open UserNavigation form
        Dim navForm As New UserNavigation()
        navForm.Show()

        ' Close current form
        Me.Close()
    End Sub



End Class
