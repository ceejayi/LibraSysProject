Imports System.Data.SqlClient

Public Class BookManagement
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Public isEditMode As Boolean = False
    Public selectedBookID As Integer = 0

    Private Sub BookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditMode Then
            LoadBookInfo()
        End If
    End Sub

    Private Sub LoadBookInfo()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Books WHERE BookID=@id", con)
            cmd.Parameters.AddWithValue("@id", selectedBookID)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                TextBox1.Text = reader("Title").ToString()
                TextBox2.Text = reader("Author").ToString()
                TextBox3.Text = reader("Genre").ToString()
                TextBox4.Text = reader("PublishedYear").ToString()
                TextBox5.Text = reader("Description").ToString()
                TextBox6.Text = reader("PicturePath").ToString()
                TextBox7.Text = reader("SoftCopyPath").ToString()
            End If
        End Using
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using con As New SqlConnection(connectionString)
            con.Open()

            Dim query As String

            If isEditMode Then
                query = "UPDATE Books SET Title=@title, Author=@author,
                         Genre=@genre, PublishedYear=@year, Description=@desc,
                         PicturePath=@pic, SoftCopyPath=@soft WHERE BookID=@id"
            Else
                query = "INSERT INTO Books (Title, Author, Genre, PublishedYear, Description, PicturePath, SoftCopyPath)
                         VALUES(@title, @author,
                         @genre, @year, @desc, @pic, @soft)"
            End If

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@title", TextBox1.Text)
            cmd.Parameters.AddWithValue("@author", TextBox2.Text)
            cmd.Parameters.AddWithValue("@genre", TextBox3.Text)
            cmd.Parameters.AddWithValue("@year", TextBox4.Text)
            cmd.Parameters.AddWithValue("@desc", TextBox5.Text)
            cmd.Parameters.AddWithValue("@pic", TextBox6.Text)
            cmd.Parameters.AddWithValue("@soft", TextBox7.Text)

            If isEditMode Then
                cmd.Parameters.AddWithValue("@id", selectedBookID)
            End If

            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Collection.LoadBooks()
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
End Class
