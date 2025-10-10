Imports System.Data.SqlClient

Public Class UserMainPage

    Dim connString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Private Const SlideSpeed As Integer = 50
    Private NavbarVisible As Boolean = False

    ' Timer tick for smooth animation
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim targetLeft As Integer = If(NavbarVisible, 0, -Panel3.Width)
        Dim distance As Integer = targetLeft - Panel3.Left

        If Math.Abs(distance) > SlideSpeed Then
            Panel3.Left += SlideSpeed * Math.Sign(distance)
        Else
            Panel3.Left = targetLeft
            Timer1.Enabled = False
        End If
    End Sub

    ' Slide-in on hover
    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        NavbarVisible = True
        Timer1.Enabled = True
    End Sub

    ' Slide-out when mouse leaves
    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Dim cursorPos = Me.PointToClient(Cursor.Position)

        If Panel3.Bounds.Contains(cursorPos) Or
           Button1.Bounds.Contains(cursorPos) Or Button2.Bounds.Contains(cursorPos) Or
           Button3.Bounds.Contains(cursorPos) Or Button4.Bounds.Contains(cursorPos) Or
           Button5.Bounds.Contains(cursorPos) Then
            Return
        End If

        NavbarVisible = False
        Timer1.Enabled = True
    End Sub

    ' FlowLayoutPanel settings
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        FlowLayoutPanel1.WrapContents = False
    End Sub

    ' Form Load
    Private Sub UserMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign BookIDs to PictureBoxes
        PictureBox1.Tag = 1
        PictureBox2.Tag = 2
        PictureBox3.Tag = 3
        PictureBox4.Tag = 4

        ' Attach click event handler to all picture boxes
        For Each pb As PictureBox In {PictureBox1, PictureBox2, PictureBox3, PictureBox4}
            AddHandler pb.Click, AddressOf BookPicture_Click
        Next
    End Sub

    ' PictureBox Click Handler
    Private Sub BookPicture_Click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        Dim bookID As Integer = CInt(pb.Tag)

        ' Variables for book details
        Dim title, author, genre, desc, picturePath, softCopyPath As String
        Dim year As Integer

        Try
            Using conn As New SqlConnection(connString)
                Dim cmd As New SqlCommand("SELECT Title, Author, Genre, PublishedYear, Description, PicturePath, SoftCopyPath FROM dbo.Books WHERE BookID=@BookID", conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        title = reader("Title").ToString()
                        author = reader("Author").ToString()
                        genre = reader("Genre").ToString()
                        year = CInt(reader("PublishedYear"))
                        desc = reader("Description").ToString()
                        picturePath = reader("PicturePath").ToString()
                        softCopyPath = If(reader("SoftCopyPath") Is DBNull.Value, "", reader("SoftCopyPath").ToString())
                    End If
                End Using
            End Using

            ' Open Borrow form
            Dim borrowForm As New Borrow()
            borrowForm.BookTitle = title
            borrowForm.BookAuthor = author
            borrowForm.BookGenre = genre
            borrowForm.BookYear = year
            borrowForm.BookDesc = desc
            borrowForm.BookPicturePath = picturePath
            borrowForm.BookSoftCopyPath = softCopyPath
            borrowForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error retrieving book details: " & ex.Message)
        End Try
    End Sub
End Class
