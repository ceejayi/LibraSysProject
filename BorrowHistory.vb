Imports System.Data.SqlClient

Public Class BorrowHistory

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    ' Logged-in user ID from QR login
    Private LoggedInUserID As Integer

    Private Sub BorrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the currently logged-in user ID from Globals
        LoggedInUserID = Globals.CurrentUserID

        ' If no user is logged in, warn and close form
        If LoggedInUserID = 0 Then
            MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadBorrowHistory()
    End Sub

    Private Sub LoadBorrowHistory()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                ' Updated query to display currently borrowed books by logged-in user
                Dim query As String =
                    "SELECT BorrowID AS [Borrow Number], BookTitle AS [Book Title], BorrowDate AS [Borrowed On], 
                            DATEADD(day, 7, BorrowDate) AS [Due Date], 
                            CASE WHEN ReturnDate IS NULL THEN 'Not Returned' ELSE 'Returned' END AS [Status]
                     FROM BorrowedBooks
                     WHERE UserID = @UserID
                     ORDER BY BorrowDate DESC"

                Using cmd As New SqlCommand(query, con)
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
                End Using

            Catch ex As Exception
                MessageBox.Show("Failed to load borrow history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Nothing yet
    End Sub

    Private Sub borrowHistoryy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles borrowHistoryy.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyReviews.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ServiceFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CurrentlyReading.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WantToRead.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AlreadyRead.Show()
        Me.Hide()
    End Sub

    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserMainPage.Show()
        Me.Hide()
    End Sub
End Class
