Imports System.Data.SqlClient

Public Class UserList
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Private selectedUserID As Integer = -1

    ' ----------------- LOAD FORM -----------------
    Private Sub UserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    ' ----------------- LOAD USERS -----------------
    Public Sub LoadUsers()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim query As String = "SELECT UserID, FullName, Username, Password, Role, Email FROM Users"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                ListOfUser.DataSource = dt

                ListOfUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                ListOfUser.ReadOnly = True
                ListOfUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Catch ex As Exception
                MessageBox.Show("Failed to load users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ----------------- ADD USER -----------------
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim frm As New FrmQRGenerator()
        frm.Show()
    End Sub

    ' ----------------- EDIT USER -----------------
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If ListOfUser.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        selectedUserID = CInt(ListOfUser.SelectedRows(0).Cells("UserID").Value)

        Dim um As New UserManagement()
        ' Load selected user data
        um.TextBox1.Text = ListOfUser.SelectedRows(0).Cells("FullName").Value.ToString()
        um.TextBox2.Text = ListOfUser.SelectedRows(0).Cells("Username").Value.ToString()
        um.TextBox3.Text = ListOfUser.SelectedRows(0).Cells("Password").Value.ToString()
        um.TextBox4.Text = ListOfUser.SelectedRows(0).Cells("Role").Value.ToString()
        um.TextBox5.Text = ListOfUser.SelectedRows(0).Cells("Email").Value.ToString()
        um.SelectedUserID = selectedUserID
        um.isEditMode = True
        um.Show()
    End Sub

    ' ----------------- DELETE USER -----------------
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If ListOfUser.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        selectedUserID = CInt(ListOfUser.SelectedRows(0).Cells("UserID").Value)
        Dim fullName As String = ListOfUser.SelectedRows(0).Cells("FullName").Value.ToString()

        Dim result = MessageBox.Show($"Do you want to delete '{fullName}'?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Delete related logs first to avoid foreign key conflict
                Dim cmdLogs As New SqlCommand("DELETE FROM UserLogs WHERE UserID=@id", con)
                cmdLogs.Parameters.AddWithValue("@id", selectedUserID)
                cmdLogs.ExecuteNonQuery()

                ' Delete the user
                Dim cmd As New SqlCommand("DELETE FROM Users WHERE UserID=@id", con)
                cmd.Parameters.AddWithValue("@id", selectedUserID)
                cmd.ExecuteNonQuery()
            End Using

            LoadUsers()
            MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ----------------- BACK BUTTON -----------------
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Optional custom painting
    End Sub
End Class
