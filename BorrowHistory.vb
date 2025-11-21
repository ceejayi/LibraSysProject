Imports System.Data.SqlClient

Public Class BorrowHistory

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    ' Logged-in user ID
    Private LoggedInUserID As Integer

    Private Sub BorrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the currently logged-in user ID safely
        LoggedInUserID = LoginForm.loggedUserID
        LoadBorrowHistory()
    End Sub

    Private Sub LoadBorrowHistory()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                Dim query As String =
                    "SELECT BorrowID AS [Borrow Number], BookTitle AS [Book Title]
                     FROM BorrowedBooks
                     WHERE UserID = @UserID"

                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the data to the DataGridView
                borrowHistoryy.DataSource = dt
                borrowHistoryy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                borrowHistoryy.ReadOnly = True
                borrowHistoryy.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                ' Optional: Show a message if no records are found
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("You have no borrowed books.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to load borrow history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Nothing yet
    End Sub

End Class
