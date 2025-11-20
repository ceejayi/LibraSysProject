Public Class BookChosen

    Public Shared bookTitle As String
    Public Shared bookAuthor As String
    Public Shared bookGenre As String
    Public Shared bookDescription As String
    Public Shared bookCoverPath As String
    Public Shared bookFile As String

    Private Sub BookChosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = bookTitle
        lblTitle.ForeColor = Color.Black
        lblTitle.Font = New Font("Times New Roman", lblTitle.Font.Size, lblTitle.Font.Style)

        lblAuthorGenre.Text = bookAuthor & vbCrLf & bookGenre
        lblAuthorGenre.ForeColor = Color.Black
        lblAuthorGenre.Font = New Font("Times New Roman", lblAuthorGenre.Font.Size, lblAuthorGenre.Font.Style)

        lblDescription.Text = bookDescription
        lblDescription.ForeColor = Color.Black
        lblDescription.Font = New Font("Times New Roman", lblDescription.Font.Size, lblDescription.Font.Style)

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
            Dim psi As New ProcessStartInfo()
            psi.FileName = bookFile
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Soft copy not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearanceForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserMainPage.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
