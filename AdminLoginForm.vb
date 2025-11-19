Imports System.Data.SqlClient

Public Class AdminLoginForm
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Always hide password characters
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM Admins WHERE Username=@username AND Password=@password"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login successful!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        ' Open AdminWelcome form
                        Dim welcomeForm As New AdminDashboard()
                        welcomeForm.Show()

                        ' Hide the login form
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            TextBox1.Text = ""
            TextBox2.Text = ""

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    ' Optional unused event handlers can be removed
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
    End Sub
End Class
