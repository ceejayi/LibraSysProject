<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQRGenerator
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
        Panel1 = New Panel()
        txtPassword = New TextBox()
        pbQRCode = New PictureBox()
        userID = New TextBox()
        Button4 = New Button()
        btnSave = New Button()
        btnGenerate = New Button()
        btnClear = New Button()
        contact = New TextBox()
        userName = New TextBox()
        userType = New TextBox()
        fullName = New TextBox()
        Panel1.SuspendLayout()
        CType(pbQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.QRManagement
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(pbQRCode)
        Panel1.Controls.Add(userID)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(contact)
        Panel1.Controls.Add(userName)
        Panel1.Controls.Add(userType)
        Panel1.Controls.Add(fullName)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(214, 420)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(330, 27)
        txtPassword.TabIndex = 10
        ' 
        ' pbQRCode
        ' 
        pbQRCode.Location = New Point(631, 189)
        pbQRCode.Name = "pbQRCode"
        pbQRCode.Size = New Size(285, 270)
        pbQRCode.TabIndex = 9
        pbQRCode.TabStop = False
        ' 
        ' userID
        ' 
        userID.Location = New Point(214, 256)
        userID.Name = "userID"
        userID.Size = New Size(330, 27)
        userID.TabIndex = 8
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(897, 539)
        Button4.Name = "Button4"
        Button4.Size = New Size(59, 33)
        Button4.TabIndex = 7
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Transparent
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(789, 508)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(81, 33)
        btnSave.TabIndex = 6
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.Transparent
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnGenerate.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Location = New Point(675, 508)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(81, 33)
        btnGenerate.TabIndex = 5
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Transparent
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(357, 548)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(59, 33)
        btnClear.TabIndex = 4
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' contact
        ' 
        contact.Location = New Point(214, 464)
        contact.Name = "contact"
        contact.Size = New Size(330, 27)
        contact.TabIndex = 3
        ' 
        ' userName
        ' 
        userName.Location = New Point(214, 359)
        userName.Name = "userName"
        userName.Size = New Size(330, 27)
        userName.TabIndex = 2
        ' 
        ' userType
        ' 
        userType.Location = New Point(214, 309)
        userType.Name = "userType"
        userType.Size = New Size(330, 27)
        userType.TabIndex = 2
        ' 
        ' fullName
        ' 
        fullName.Location = New Point(214, 205)
        fullName.Name = "fullName"
        fullName.Size = New Size(330, 27)
        fullName.TabIndex = 0
        ' 
        ' FrmQRGenerator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "FrmQRGenerator"
        Text = "FrmQRGenerator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents contact As TextBox
    Friend WithEvents userName As TextBox
    Friend WithEvents userType As TextBox
    Friend WithEvents fullName As TextBox
    Friend WithEvents pbQRCode As PictureBox
    Friend WithEvents userID As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
