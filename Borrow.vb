Imports System.IO
Imports System.Drawing
Imports System.Diagnostics

Public Class Borrow
    Inherits Form

    Public Property BookTitle As String
    Public Property BookAuthor As String
    Public Property BookGenre As String
    Public Property BookYear As Integer
    Public Property BookDesc As String
    Public Property BookPicturePath As String
    Public Property BookSoftCopyPath As String

    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblTitle.Text = BookTitle
            lblAuthor.Text = BookAuthor
            lblGenre.Text = BookGenre
            lblDesc.Text = BookDesc

            ' Load book picture if path exists
            If Not String.IsNullOrEmpty(BookPicturePath) AndAlso File.Exists(BookPicturePath) Then
                BookPicture.Image = Image.FromFile(BookPicturePath)
                BookPicture.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                BookPicture.Image = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading Borrow form: " & ex.Message)
        End Try
    End Sub

    ' eBook Button Click
    Private Sub eBookButton_Click(sender As Object, e As EventArgs) Handles eBookButton.Click
        Try
            If String.IsNullOrEmpty(BookSoftCopyPath) OrElse Not File.Exists(BookSoftCopyPath) Then
                MessageBox.Show("No eBook file found for this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Open PDF in default browser
            Process.Start(New ProcessStartInfo With {
                .FileName = BookSoftCopyPath,
                .UseShellExecute = True
            })
        Catch ex As Exception
            MessageBox.Show("Error opening eBook: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Nothing here
    End Sub
End Class
