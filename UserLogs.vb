Imports System.Data.SqlClient

Public Class UserLogs
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;"

    Private Sub UserLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserLogs()
    End Sub

    Public Sub LoadUserLogs()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim query As String = "SELECT LogID, UserID, Username, LoginTime, LogoutTime FROM UserLogs ORDER BY LoginTime DESC"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                UserLogss.DataSource = dt
                UserLogss.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                UserLogss.ReadOnly = True
                UserLogss.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Catch ex As Exception
                MessageBox.Show("Failed to load user logs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Optional custom painting code
    End Sub
End Class
