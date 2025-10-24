Public Class AdminLogin
    Private ReadOnly placeholderUsername As String = "Enter username"
    Private ReadOnly placeholderPassword As String = "Enter password"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxPassword.Multiline = False
        TxtboxUsername.Multiline = False

        SetUsernamePlaceholder()
        SetPasswordPlaceholder()

        TxtboxPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub SetUsernamePlaceholder()
        TxtboxUsername.Text = placeholderUsername
        TxtboxUsername.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TxtboxUsername.Enter
        If TxtboxUsername.Text = placeholderUsername Then
            TxtboxUsername.Text = ""
            TxtboxUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TxtboxUsername.Leave
        If String.IsNullOrWhiteSpace(TxtboxUsername.Text) Then
            SetUsernamePlaceholder()
        End If
    End Sub

    Private Sub SetPasswordPlaceholder()
        TxtboxPassword.Text = placeholderPassword
        TxtboxPassword.ForeColor = Color.Gray
        TxtboxPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TxtboxPassword.Enter
        If TxtboxPassword.Text = placeholderPassword Then
            TxtboxPassword.Text = ""
            TxtboxPassword.ForeColor = Color.Black
            TxtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TxtboxPassword.Leave
        If String.IsNullOrWhiteSpace(TxtboxPassword.Text) Then
            SetPasswordPlaceholder()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnContinue.Click
        Dim username As String = TxtboxUsername.Text.Trim()
        Dim password As String = TxtboxPassword.Text.Trim()

        If username = placeholderUsername Then username = ""
        If password = placeholderPassword Then password = ""

        If username.ToLower() = "adminrei" AndAlso password = "1234" Then
            MessageBox.Show("Login successful! Welcome to LibraSys.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtboxUsername.Text = ""
            TxtboxPassword.Text = ""

            AdminWelcome.Show()
        ElseIf username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtboxUsername.Text = ""
            TxtboxPassword.Text = ""
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class