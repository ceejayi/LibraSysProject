<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQRScanner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQRScanner))
        Panel1 = New Panel()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnClear = New Button()
        btnEnter = New Button()
        btnBack = New Button()
        btnScan = New Button()
        pbCamera = New PictureBox()
        Panel1.SuspendLayout()
        CType(pbCamera, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnEnter)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnScan)
        Panel1.Controls.Add(pbCamera)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.Window
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Location = New Point(126, 365)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(209, 20)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Location = New Point(126, 419)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(209, 20)
        txtPassword.TabIndex = 5
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Transparent
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(253, 471)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(69, 29)
        btnClear.TabIndex = 4
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.Transparent
        btnEnter.FlatAppearance.BorderSize = 0
        btnEnter.FlatStyle = FlatStyle.Flat
        btnEnter.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnter.ForeColor = Color.White
        btnEnter.Location = New Point(148, 471)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(69, 29)
        btnEnter.TabIndex = 3
        btnEnter.Text = "ENTER"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Location = New Point(658, 530)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(81, 36)
        btnBack.TabIndex = 2
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnScan
        ' 
        btnScan.BackColor = Color.Transparent
        btnScan.FlatAppearance.BorderSize = 0
        btnScan.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnScan.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnScan.FlatStyle = FlatStyle.Flat
        btnScan.Location = New Point(555, 530)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(81, 36)
        btnScan.TabIndex = 1
        btnScan.UseVisualStyleBackColor = False
        ' 
        ' pbCamera
        ' 
        pbCamera.Location = New Point(371, 107)
        pbCamera.Name = "pbCamera"
        pbCamera.Size = New Size(552, 371)
        pbCamera.TabIndex = 0
        pbCamera.TabStop = False
        ' 
        ' FrmQRScanner
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "FrmQRScanner"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmQRScanner"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbCamera, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents pbCamera As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtUsername As TextBox
End Class
