Public Class BookChosen

    Public Shared bookTitle As String
    Public Shared bookAuthor As String
    Public Shared bookGenre As String
    Public Shared bookDescription As String
    Public Shared bookCoverPath As String
    Public Shared bookFile As String

    Private Sub BookChosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = bookTitle
        lblAuthorGenre.Text = bookAuthor & vbCrLf & bookGenre
        lblDescription.Text = bookDescription

        ' Load book cover into Panel2
        If System.IO.File.Exists(bookCoverPath) Then
            Panel2.BackgroundImage = Image.FromFile(bookCoverPath)
            Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Panel2.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists(bookFile) Then
            Process.Start(bookFile)
        Else
            MessageBox.Show("Soft copy not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim backForm As New UserMainPage()
        backForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserMainPage.Show()
        Me.Close()
    End Sub
End Class
