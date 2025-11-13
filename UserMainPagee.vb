Imports System.Data.SqlClient

Public Class UserMainPagee
    ' Connection string to your DB
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    ' Form Load
    Private Sub UserMainPagee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure main panel stacks genres vertically
        FlowLayoutPanelGenres.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanelGenres.WrapContents = False
        FlowLayoutPanelGenres.AutoScroll = True

        LoadNetflixStyleHomepage()

    End Sub

    ' Load Netflix-style homepage
    Private Sub LoadNetflixStyleHomepage()
        FlowLayoutPanelGenres.Controls.Clear() ' Clear previous content

        Dim genres As New List(Of String)

        ' Step 1: Get distinct genres from DB
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmdGenres As New SqlCommand("SELECT DISTINCT Genre FROM Books", con)
            Using reader = cmdGenres.ExecuteReader()
                While reader.Read()
                    genres.Add(reader("Genre").ToString())
                End While
            End Using
        End Using

        ' Step 2: For each genre, create horizontal scrollable panel
        For Each genre In genres
            ' Genre Label
            Dim lblGenre As New Label()
            lblGenre.Text = genre
            lblGenre.Font = New Font("Arial", 14, FontStyle.Bold)
            lblGenre.AutoSize = True
            lblGenre.Margin = New Padding(5)
            FlowLayoutPanelGenres.Controls.Add(lblGenre)

            ' Horizontal panel for books
            Dim panelGenre As New FlowLayoutPanel()
            panelGenre.Width = FlowLayoutPanelGenres.ClientSize.Width - 25
            panelGenre.Height = 200
            panelGenre.FlowDirection = FlowDirection.LeftToRight
            panelGenre.WrapContents = False
            panelGenre.AutoScroll = True
            panelGenre.Margin = New Padding(0, 0, 0, 30)

            ' Step 3: Get books of this genre
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmdBooks As New SqlCommand("SELECT Title, PicturePath FROM Books WHERE Genre=@genre", con)
                cmdBooks.Parameters.AddWithValue("@genre", genre)

                Using readerBooks = cmdBooks.ExecuteReader()
                    While readerBooks.Read()
                        Dim title As String = readerBooks("Title").ToString()
                        Dim picPath As String = readerBooks("PicturePath").ToString()

                        ' Book Panel
                        Dim bookPanel As New Panel()
                        bookPanel.Width = 120
                        bookPanel.Height = 180
                        bookPanel.Margin = New Padding(5)

                        ' PictureBox for book cover
                        Dim picBox As New PictureBox()
                        picBox.Width = 120
                        picBox.Height = 140
                        picBox.SizeMode = PictureBoxSizeMode.StretchImage
                        If System.IO.File.Exists(picPath) Then
                            picBox.Image = Image.FromFile(picPath)
                        Else
                            picBox.BackColor = Color.Gray ' placeholder if file missing
                        End If
                        bookPanel.Controls.Add(picBox)

                        ' Label for title
                        Dim lblTitle As New Label()
                        lblTitle.Text = title
                        lblTitle.Top = picBox.Bottom + 5
                        lblTitle.Width = 120
                        lblTitle.TextAlign = ContentAlignment.MiddleCenter
                        lblTitle.AutoEllipsis = True
                        bookPanel.Controls.Add(lblTitle)

                        ' Add book panel to horizontal genre panel
                        panelGenre.Controls.Add(bookPanel)
                    End While
                End Using
            End Using

            ' Add horizontal genre panel to main vertical panel
            FlowLayoutPanelGenres.Controls.Add(panelGenre)
        Next
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlowLayoutPanelGenres_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanelGenres.Paint

    End Sub
End Class
