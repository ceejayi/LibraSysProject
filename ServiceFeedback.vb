Imports System.Data.SqlClient

Public Class ServiceFeedback
    Private Sub ServiceFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate rating combo box 1–5
        cmbRating.Items.Clear()
        For i As Integer = 1 To 5
            cmbRating.Items.Add(i)
        Next
        cmbRating.SelectedIndex = 4 ' Default to 5 stars
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show(DatabaseHelper.connStr)
        Dim customerName As String = TextBox1.Text.Trim()
        Dim comments As String = TextBox2.Text.Trim()
        Dim rating As Integer

        ' Validate rating
        If Not Integer.TryParse(cmbRating.SelectedItem?.ToString(), rating) OrElse rating < 1 OrElse rating > 5 Then
            MessageBox.Show("Please select a rating from 1 to 5.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate comments
        If comments = "" Then
            MessageBox.Show("Please enter your feedback.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert feedback into hosted DB
        Try
            Using conn As New SqlConnection(DatabaseHelper.connStr)
                Dim query As String = "INSERT INTO Feedback (CompanyID, CustomerName, Rating, Comments, DateSubmitted) VALUES (@CompanyID, @Name, @Rating, @Comments, GETDATE())"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CompanyID", DatabaseHelper.CompanyID)
                    cmd.Parameters.AddWithValue("@Name", If(customerName = "", DBNull.Value, customerName))
                    cmd.Parameters.AddWithValue("@Rating", rating)
                    cmd.Parameters.AddWithValue("@Comments", comments)

                    conn.Open()
                    ' <-- Replace this line:
                    ' cmd.ExecuteNonQuery()
                    ' With these two lines:
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Rows inserted: " & rowsAffected)
                End Using
            End Using

            MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close() ' Close form after submission

        Catch ex As Exception
            MessageBox.Show("Error submitting feedback: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BorrowHistory.Show()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AlreadyRead.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserMainPage.Show()
        Me.Hide()
    End Sub
End Class
