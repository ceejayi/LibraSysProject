<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest
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
        picCover = New PictureBox()
        lblTitle = New Label()
        lblAuthor = New Label()
        txtSummary = New TextBox()
        btnPrevBook = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(picCover, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.GUESTMODE
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnPrevBook)
        Panel1.Controls.Add(txtSummary)
        Panel1.Controls.Add(lblAuthor)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(picCover)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 633)
        Panel1.TabIndex = 0
        ' 
        ' picCover
        ' 
        picCover.Location = New Point(268, 123)
        picCover.Name = "picCover"
        picCover.Size = New Size(294, 427)
        picCover.TabIndex = 0
        picCover.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.FromArgb(CByte(59), CByte(10), CByte(7))
        lblTitle.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.Control
        lblTitle.Location = New Point(673, 141)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(282, 35)
        lblTitle.TabIndex = 1
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAuthor
        ' 
        lblAuthor.BackColor = Color.FromArgb(CByte(138), CByte(25), CByte(22))
        lblAuthor.Font = New Font("Century Schoolbook", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAuthor.ForeColor = Color.White
        lblAuthor.Location = New Point(659, 220)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(296, 30)
        lblAuthor.TabIndex = 2
        ' 
        ' txtSummary
        ' 
        txtSummary.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        txtSummary.Font = New Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSummary.Location = New Point(580, 277)
        txtSummary.Multiline = True
        txtSummary.Name = "txtSummary"
        txtSummary.ScrollBars = ScrollBars.Vertical
        txtSummary.Size = New Size(388, 179)
        txtSummary.TabIndex = 3
        ' 
        ' btnPrevBook
        ' 
        btnPrevBook.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrevBook.Location = New Point(580, 462)
        btnPrevBook.Name = "btnPrevBook"
        btnPrevBook.Size = New Size(186, 52)
        btnPrevBook.TabIndex = 4
        btnPrevBook.Text = "Previous"
        btnPrevBook.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(772, 462)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 52)
        Button1.TabIndex = 5
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Guest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "Guest"
        Text = "Guest"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picCover, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picCover As PictureBox
    Friend WithEvents txtSummary As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPrevBook As Button
End Class
