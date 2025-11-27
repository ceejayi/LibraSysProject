Imports System
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Microsoft.Data.SqlClient
Imports ZXing
Imports ZXing.Windows.Compatibility

Public Class FrmQRScanner
    Inherits Form

    ' Camera objects
    Private VideoDevices As FilterInfoCollection
    Private VideoSource As VideoCaptureDevice
    Private Scanning As Boolean = False
    Private QRDetected As Boolean = False

    ' Controls (assume Designer-generated; remove duplicates)
    ' pbCamera, btnScan, btnBack, btnLogin, btnClear, txtUsername, txtPassword

    ' Form Load
    Private Sub FrmQRScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            VideoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If VideoDevices.Count = 0 Then
                MessageBox.Show("No camera found!")
                Me.Close()
                Exit Sub
            End If

            VideoSource = New VideoCaptureDevice(VideoDevices(0).MonikerString)
            AddHandler VideoSource.NewFrame, AddressOf Video_NewFrame

            StartCamera()
            AddHandler Application.ApplicationExit, AddressOf OnAppExit
        Catch ex As Exception
            MessageBox.Show("Error initializing camera: " & ex.Message)
        End Try
    End Sub

    ' Start camera
    Private Sub StartCamera()
        If VideoSource IsNot Nothing AndAlso Not VideoSource.IsRunning Then
            VideoSource.Start()
        End If
        Scanning = True
        QRDetected = False
        ClearLastQRCode()
    End Sub

    ' Scan button
    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        StartCamera()
    End Sub

    ' Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ClearLastQRCode()
        QRDetected = False
        Scanning = True
        LogoutCurrentUser()
        Welcome.Show()
        Me.Hide()
    End Sub

    ' Clear password button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Text = ""
    End Sub

    ' Login button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
            Using cmd As New SqlCommand("SELECT UserID FROM Users WHERE UserName=@UserName AND Password=@Password", con)
                cmd.Parameters.AddWithValue("@UserName", username)
                cmd.Parameters.AddWithValue("@Password", password)
                Try
                    con.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        LoginUser(username)
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Video new frame
    Private Sub Video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        If Not Scanning Or QRDetected Then Return

        Dim frame As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)

        ' Show on PictureBox
        pbCamera.BeginInvoke(Sub()
                                 Try
                                     If pbCamera.Image IsNot Nothing Then
                                         pbCamera.Image.Dispose()
                                     End If
                                     pbCamera.Image = CType(frame.Clone(), Bitmap)
                                 Catch
                                 End Try
                             End Sub)

        ' Process QR
        ThreadPool.QueueUserWorkItem(Sub()
                                         Try
                                             Dim reader As New BarcodeReader()
                                             Dim result = reader.Decode(frame)
                                             frame.Dispose()

                                             If result IsNot Nothing Then
                                                 QRDetected = True
                                                 Scanning = False
                                                 Me.BeginInvoke(Sub() ProcessQR(result.Text))
                                             End If
                                         Catch ex As Exception
                                             frame.Dispose()
                                             Me.BeginInvoke(Sub()
                                                                MessageBox.Show("QR processing error: " & ex.Message)
                                                                QRDetected = False
                                                                Scanning = True
                                                            End Sub)
                                         End Try
                                     End Sub)
    End Sub

    ' Process QR
    Private Sub ProcessQR(qrText As String)
        Dim username As String = ""
        Dim lines() As String = qrText.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each line As String In lines
            If line.StartsWith("USERNAME:") Then
                username = line.Replace("USERNAME:", "").Trim()
                Exit For
            End If
        Next

        If ValidateUser(username) Then
            LoginUser(username)
        Else
            MessageBox.Show("Invalid QR code. Scanner reset.", "Error")
            QRDetected = False
            Scanning = True
        End If
    End Sub

    ' Validate user
    Private Function ValidateUser(username As String) As Boolean
        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
            Using cmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@UserName", con)
                cmd.Parameters.AddWithValue("@UserName", username)
                Try
                    con.Open()
                    Return CInt(cmd.ExecuteScalar()) > 0
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Login user
    Private Sub LoginUser(username As String)
        Globals.CurrentUserID = GetUserIDByUsername(username)

        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
            Using cmdLog As New SqlCommand("INSERT INTO UserLogs(UserID, LoginTime) VALUES(@UserID, @LoginTime)", con)
                cmdLog.Parameters.AddWithValue("@UserID", Globals.CurrentUserID)
                cmdLog.Parameters.AddWithValue("@LoginTime", DateTime.Now)
                Try
                    con.Open()
                    cmdLog.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Failed to log user login: " & ex.Message)
                End Try
            End Using
        End Using

        MessageBox.Show($"Welcome to LibraSys, {username}!", "Login Successful")
        Dim userPage As New UserMainPage()
        userPage.Show()
        Me.Hide()
    End Sub

    ' Get UserID
    Private Function GetUserIDByUsername(username As String) As Integer
        Dim userID As Integer = 0
        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
            Using cmd As New SqlCommand("SELECT UserID FROM Users WHERE UserName=@UserName", con)
                cmd.Parameters.AddWithValue("@UserName", username)
                Try
                    con.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then userID = Convert.ToInt32(result)
                Catch ex As Exception
                    MessageBox.Show("Error fetching UserID: " & ex.Message)
                End Try
            End Using
        End Using
        Return userID
    End Function

    ' Clear PictureBox
    Private Sub ClearLastQRCode()
        Try
            If pbCamera.Image IsNot Nothing Then
                pbCamera.Image.Dispose()
                pbCamera.Image = Nothing
            End If
        Catch
        End Try
    End Sub

    ' Stop camera
    Private Sub FrmQRScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            LogoutCurrentUser()
            If VideoSource IsNot Nothing AndAlso VideoSource.IsRunning Then
                RemoveHandler VideoSource.NewFrame, AddressOf Video_NewFrame
                VideoSource.SignalToStop()
                VideoSource.WaitForStop()
            End If
        Catch ex As Exception
            MessageBox.Show("Error stopping camera: " & ex.Message)
        End Try
    End Sub

    ' Logout user
    Private Sub LogoutCurrentUser()
        If Globals.CurrentUserID = 0 Then Return
        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
            Using cmd As New SqlCommand("
                UPDATE UserLogs
                SET LogoutTime=@LogoutTime
                WHERE UserLogID = (
                    SELECT TOP 1 UserLogID
                    FROM UserLogs
                    WHERE UserID=@UserID AND LogoutTime IS NULL
                    ORDER BY LoginTime DESC
                )", con)
                cmd.Parameters.AddWithValue("@LogoutTime", DateTime.Now)
                cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID)
                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Failed to log logout time: " & ex.Message)
                End Try
            End Using
        End Using
        Globals.CurrentUserID = 0
    End Sub

    ' Auto logout
    Private Sub OnAppExit(sender As Object, e As EventArgs)
        LogoutCurrentUser()
    End Sub

    Private Sub pbCamera_Click(sender As Object, e As EventArgs) Handles pbCamera.Click

    End Sub
End Class
