Imports System.Data.SqlClient
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode
Imports ZXing.Windows.Compatibility

Public Class FrmQRGenerator

    Private Sub FrmQRGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserIDFromDB()
        userID.ReadOnly = True ' Make UserID read-only

        ' Initialize ComboBox1 for user roles
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Student")
        ComboBox1.Items.Add("Faculty")
    End Sub

    '===============================
    ' Load the latest UserID from DB
    '===============================
    Private Sub LoadUserIDFromDB()
        Dim con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("SELECT ISNULL(MAX(UserID), 0) + 1 FROM Users", con)

        Try
            con.Open()
            Dim result = cmd.ExecuteScalar()
            userID.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading User ID: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    '==============================
    ' Generate QR Code
    '==============================
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Validation
        If fullName.Text = "" Or ComboBox1.SelectedItem Is Nothing Or userName.Text = "" Or txtPassword.Text = "" Or contact.Text = "" Then
            MessageBox.Show("Please fill all required fields.")
            Exit Sub
        End If

        ' QR content including password
        Dim qrContent As String =
            $"USER ID: {userID.Text}{Environment.NewLine}" &
            $"FULL NAME: {fullName.Text}{Environment.NewLine}" &
            $"USER TYPE: {ComboBox1.SelectedItem.ToString()}{Environment.NewLine}" &
            $"USERNAME: {userName.Text}{Environment.NewLine}" &
            $"PASSWORD: {txtPassword.Text}{Environment.NewLine}" &
            $"CONTACT: {contact.Text}"

        ' Create QR writer
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.QR_CODE

        writer.Options = New QrCodeEncodingOptions With {
            .Height = pbQRCode.Height,
            .Width = pbQRCode.Width,
            .Margin = 1
        }

        ' Generate bitmap
        Dim qrBitmap = writer.Write(qrContent)

        ' Display in PictureBox
        pbQRCode.Image = qrBitmap

        ' Save automatically
        Dim folder As String = "C:\Users\unson\source\repos\LibraSysProject\Resources\QROutput"
        If Not IO.Directory.Exists(folder) Then IO.Directory.CreateDirectory(folder)

        Dim savePath = $"{folder}\QR_{userID.Text}.png"
        qrBitmap.Save(savePath)

        MessageBox.Show("QR Code Generated Successfully!")
    End Sub

    '==============================
    ' Clear button
    '==============================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all textboxes
        fullName.Clear()
        ComboBox1.SelectedIndex = -1
        userName.Clear()
        txtPassword.Clear()
        contact.Clear()
        ' Clear QR PictureBox
        pbQRCode.Image = Nothing
        ' Reload next user ID
        LoadUserIDFromDB()
    End Sub

    '==============================
    ' Save button
    '==============================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If fullName.Text = "" Or ComboBox1.SelectedItem Is Nothing Or userName.Text = "" Or txtPassword.Text = "" Or contact.Text = "" Or pbQRCode.Image Is Nothing Then
            MessageBox.Show("Please generate QR code first and fill all fields.")
            Exit Sub
        End If

        ' Save QR and user info to database
        Dim con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("INSERT INTO Users (FullName, UserName, Password, Role, Email, QRCodeImagePath, DateCreated) VALUES (@FullName, @UserName, @Password, @Role, @Email, @QRCodeImagePath, @DateCreated)", con)

        Try
            Dim folder As String = "C:\QR_Output"
            If Not IO.Directory.Exists(folder) Then IO.Directory.CreateDirectory(folder)
            Dim qrPath As String = $"{folder}\QR_{userID.Text}.png"

            ' Save image locally
            pbQRCode.Image.Save(qrPath)

            ' Add parameters
            cmd.Parameters.AddWithValue("@FullName", fullName.Text)
            cmd.Parameters.AddWithValue("@UserName", userName.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Role", ComboBox1.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Email", contact.Text)
            cmd.Parameters.AddWithValue("@QRCodeImagePath", qrPath)
            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now)

            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("User and QR code saved successfully!")

            ' Clear fields for next entry
            btnClear.PerformClick()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub
End Class
