Imports System.Data.SqlClient

Public Class LoginForm

    ' Shared variables to hold logged-in user info
    Public Shared loggedUserID As Integer
    Public Shared loggedUserRole As String
    Public Shared loggedUserEmail As String

    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;Connect Timeout=60;"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear fields on load
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""

        ' Optional: Test database connection
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                MessageBox.Show("Database Connection OK")
            Catch ex As Exception
                MessageBox.Show("Database connection failed: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username As String = TextBoxUsername.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT UserID, Role, Email, Password FROM Users WHERE Username=@username", con)
                cmd.Parameters.AddWithValue("@username", username)

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim dbPassword As String = If(IsDBNull(reader("Password")), "", reader("Password").ToString())
                        If dbPassword = password Then
                            ' Successful login
                            loggedUserID = Convert.ToInt32(reader("UserID"))
                            loggedUserRole = reader("Role").ToString()
                            loggedUserEmail = reader("Email").ToString()

                            ' Try opening the main page
                            Try
                                Dim mainPage As New UserMainPage()
                                mainPage.Show()
                                Me.Hide()
                            Catch ex As Exception
                                MessageBox.Show("Failed to open UserMainPage: " & ex.Message, "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Else
                            MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Username not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Login process failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

End Class
