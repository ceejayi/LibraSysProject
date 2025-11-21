Imports System.Data.SqlClient

Public Class Collection
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Public Sub Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub

    Public Sub LoadBooks()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim query As String = "SELECT BookID, Title, Author, Genre, PublishedYear, Description, PicturePath, SoftCopyPath FROM Books"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                CollectionOfBooks.DataSource = dt

                CollectionOfBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                CollectionOfBooks.ReadOnly = True
                CollectionOfBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Catch ex As Exception
                MessageBox.Show("Failed to load books: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim bm As New BookManagement()
        bm.isEditMode = False
        bm.Show()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If CollectionOfBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bm As New BookManagement()
        bm.selectedBookID = CInt(CollectionOfBooks.SelectedRows(0).Cells("BookID").Value)
        bm.isEditMode = True
        bm.Show()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If CollectionOfBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookID As Integer = CInt(CollectionOfBooks.SelectedRows(0).Cells("BookID").Value)
        Dim title As String = CollectionOfBooks.SelectedRows(0).Cells("Title").Value.ToString()

        Dim result = MessageBox.Show($"Do you want to delete '{title}'?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("DELETE FROM Books WHERE BookID=@id", con)
                cmd.Parameters.AddWithValue("@id", bookID)
                cmd.ExecuteNonQuery()
            End Using

            LoadBooks()
            MessageBox.Show("Book deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub
End Class
