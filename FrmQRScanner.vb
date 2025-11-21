Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Windows.Compatibility
Imports System.Data.SqlClient
Imports System.Threading

Public Class FrmQRScanner
    Inherits Form

    ' Camera objects
    Private VideoDevices As FilterInfoCollection
    Private VideoSource As VideoCaptureDevice
    Private Scanning As Boolean = False
    Private QRDetected As Boolean = False

    ' Designer controls: PictureBox pbCamera, Button btnScan, Button btnBack

    ' Form Load: initialize camera devices
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

            ' Start camera automatically
            StartCamera()
        Catch ex As Exception
            MessageBox.Show("Error initializing camera: " & ex.Message)
        End Try
    End Sub

    ' Start camera safely
    Private Sub StartCamera()
        If VideoSource IsNot Nothing AndAlso Not VideoSource.IsRunning Then
            VideoSource.Start()
        End If
        Scanning = True
        QRDetected = False
        ' Clear last QR image
        ClearLastQRCode()
    End Sub

    ' Scan button click
    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        StartCamera()
    End Sub

    ' New frame event
    Private Sub Video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        If Not Scanning Or QRDetected Then Return

        Dim frame As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)

        ' Display on PictureBox
        pbCamera.BeginInvoke(Sub()
                                 Try
                                     If pbCamera.Image IsNot Nothing Then
                                         Dim oldImage As Image = pbCamera.Image
                                         pbCamera.Image = Nothing
                                         oldImage.Dispose()
                                     End If
                                     pbCamera.Image = CType(frame.Clone(), Bitmap)
                                 Catch
                                     ' Ignore disposal errors
                                 End Try
                             End Sub)

        ' Process QR asynchronously
        ThreadPool.QueueUserWorkItem(Sub()
                                         Try
                                             Dim reader As New BarcodeReader()
                                             Dim result = reader.Decode(frame)
                                             frame.Dispose()

                                             If result IsNot Nothing Then
                                                 QRDetected = True
                                                 Scanning = False

                                                 Me.BeginInvoke(Sub()
                                                                    ' Parse username
                                                                    Dim username As String = ""
                                                                    Dim lines() As String = result.Text.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                                                                    For Each line As String In lines
                                                                        If line.StartsWith("USERNAME:") Then
                                                                            username = line.Replace("USERNAME:", "").Trim()
                                                                            Exit For
                                                                        End If
                                                                    Next

                                                                    ' Verify user in DB
                                                                    Dim isValidUser As Boolean = False
                                                                    Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
                                                                        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@UserName", con)
                                                                            cmd.Parameters.AddWithValue("@UserName", username)
                                                                            Try
                                                                                con.Open()
                                                                                If CInt(cmd.ExecuteScalar()) > 0 Then isValidUser = True
                                                                            Catch ex As Exception
                                                                                MessageBox.Show("Database error: " & ex.Message)
                                                                            End Try
                                                                        End Using
                                                                    End Using

                                                                    ' Handle valid or invalid QR
                                                                    If isValidUser Then
                                                                        MessageBox.Show($"Welcome to LibraSys, {username}!", "Login Successful")

                                                                        ' --- Insert into UserLogs ---
                                                                        Using con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=LibraSysDB;Trusted_Connection=True;")
                                                                            Using cmdLog As New SqlCommand("INSERT INTO UserLogs(UserID, LoginTime) VALUES((SELECT UserID FROM Users WHERE UserName=@UserName), @LoginTime)", con)
                                                                                cmdLog.Parameters.AddWithValue("@UserName", username)
                                                                                cmdLog.Parameters.AddWithValue("@LoginTime", DateTime.Now)
                                                                                Try
                                                                                    con.Open()
                                                                                    cmdLog.ExecuteNonQuery()
                                                                                Catch ex As Exception
                                                                                    MessageBox.Show("Failed to log user login: " & ex.Message)
                                                                                End Try
                                                                            End Using
                                                                        End Using
                                                                        ' -----------------------------

                                                                        ' Clear last scanned QR immediately
                                                                        ClearLastQRCode()

                                                                        ' Open UserMainPage
                                                                        Dim userPage As New UserMainPage()
                                                                        userPage.Show()
                                                                        Me.Hide()
                                                                    Else
                                                                        MessageBox.Show("Invalid QR code. Scanner reset.", "Error")
                                                                        ' Reset flags and allow scanning again
                                                                        QRDetected = False
                                                                        Scanning = True
                                                                    End If
                                                                End Sub)
                                             End If
                                         Catch ex As Exception
                                             frame.Dispose()
                                             Me.BeginInvoke(Sub()
                                                                MessageBox.Show("QR processing error: " & ex.Message)
                                                                ' Reset flags for next scan
                                                                QRDetected = False
                                                                Scanning = True
                                                            End Sub)
                                         End Try
                                     End Sub)
    End Sub

    ' Stop camera when closing form
    Private Sub FrmQRScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If VideoSource IsNot Nothing AndAlso VideoSource.IsRunning Then
                RemoveHandler VideoSource.NewFrame, AddressOf Video_NewFrame
                VideoSource.SignalToStop()
                VideoSource.WaitForStop()
            End If
        Catch ex As Exception
            MessageBox.Show("Error stopping camera: " & ex.Message)
        End Try
    End Sub

    ' Back button resets scanner and clears last QR
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ClearLastQRCode()
        QRDetected = False
        Scanning = True
        Welcome.Show()
        Me.Hide()
    End Sub

    ' Helper: safely clear last QR image
    Private Sub ClearLastQRCode()
        Try
            If pbCamera.Image IsNot Nothing Then
                Dim oldImage As Image = pbCamera.Image
                pbCamera.Image = Nothing
                oldImage.Dispose()
            End If
        Catch
            ' Ignore disposal errors
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
