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
        Panel1 = New Panel()
        btnBack = New Button()
        btnScan = New Button()
        pbCamera = New PictureBox()
        Panel1.SuspendLayout()
        CType(pbCamera, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.UserQRLogin1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnScan)
        Panel1.Controls.Add(pbCamera)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Location = New Point(200, 382)
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
        btnScan.Location = New Point(95, 382)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(81, 36)
        btnScan.TabIndex = 1
        btnScan.UseVisualStyleBackColor = False
        ' 
        ' pbCamera
        ' 
        pbCamera.Location = New Point(380, 115)
        pbCamera.Name = "pbCamera"
        pbCamera.Size = New Size(535, 404)
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
        Text = "FrmQRScanner"
        Panel1.ResumeLayout(False)
        CType(pbCamera, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents pbCamera As PictureBox
End Class
