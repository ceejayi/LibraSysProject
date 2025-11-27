Imports System.Data.SqlClient

Public Class UserManagement
    Public connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"
    Public isEditMode As Boolean = False
    Public SelectedUserID As Integer = 0

    ' ----------------- FORM LOAD -----------------
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize Role ComboBox
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Student")
        ComboBox1.Items.Add("Faculty")
        ComboBox1.Items.Add("Admin")

        If isEditMode Then
            LoadUserData()
        End If
    End Sub

    ' ----------------- LOAD USER DATA -----------------
    Private Sub LoadUserData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT * FROM Users WHERE UserID=@id", con)
                cmd.Parameters.AddWithValue("@id", SelectedUserID)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        TextBox1.Text = reader("FullName").ToString()
                        TextBox2.Text = reader("Username").ToString()
                        TextBox3.Text = reader("Password").ToString()
                        ComboBox1.SelectedItem = reader("Role").ToString()
                        TextBox5.Text = reader("Email").ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to load user data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ----------------- CLEAR BUTTON -----------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox5.Clear()
        isEditMode = False
        SelectedUserID = 0
    End Sub

    ' ----------------- SAVE BUTTON -----------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Or
           String.IsNullOrWhiteSpace(TextBox3.Text) Or ComboBox1.SelectedItem Is Nothing Or
           String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As SqlCommand

                If isEditMode Then
                    cmd = New SqlCommand("UPDATE Users SET FullName=@FullName, Username=@Username, Password=@Password, Role=@Role, Email=@Email WHERE UserID=@id", con)
                    cmd.Parameters.AddWithValue("@id", SelectedUserID)
                Else
                    cmd = New SqlCommand("INSERT INTO Users (FullName, Username, Password, Role, Email) VALUES (@FullName, @Username, @Password, @Role, @Email)", con)
                End If

                cmd.Parameters.AddWithValue("@FullName", TextBox1.Text.Trim())
                cmd.Parameters.AddWithValue("@Username", TextBox2.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text.Trim())
                cmd.Parameters.AddWithValue("@Role", ComboBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim())

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Failed to save user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        UserList.LoadUsers()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
