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
        Button1 = New Button()
        btnPrevBook = New Button()
        txtSummary = New TextBox()
        lblAuthor = New Label()
        lblTitle = New Label()
        picCover = New PictureBox()
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
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(880, 475)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(676, 346)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 39)
        Button1.TabIndex = 5
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnPrevBook
        ' 
        btnPrevBook.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrevBook.Location = New Point(508, 346)
        btnPrevBook.Margin = New Padding(3, 2, 3, 2)
        btnPrevBook.Name = "btnPrevBook"
        btnPrevBook.Size = New Size(163, 39)
        btnPrevBook.TabIndex = 4
        btnPrevBook.Text = "Previous"
        btnPrevBook.UseVisualStyleBackColor = True
        ' 
        ' txtSummary
        ' 
        txtSummary.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        txtSummary.Font = New Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSummary.Location = New Point(508, 208)
        txtSummary.Margin = New Padding(3, 2, 3, 2)
        txtSummary.Multiline = True
        txtSummary.Name = "txtSummary"
        txtSummary.ScrollBars = ScrollBars.Vertical
        txtSummary.Size = New Size(340, 135)
        txtSummary.TabIndex = 3
        ' 
        ' lblAuthor
        ' 
        lblAuthor.BackColor = Color.FromArgb(CByte(138), CByte(25), CByte(22))
        lblAuthor.Font = New Font("Century Schoolbook", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAuthor.ForeColor = Color.White
        lblAuthor.Location = New Point(577, 165)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(259, 22)
        lblAuthor.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.FromArgb(CByte(59), CByte(10), CByte(7))
        lblTitle.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.Control
        lblTitle.Location = New Point(589, 106)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(247, 26)
        lblTitle.TabIndex = 1
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picCover
        ' 
        picCover.Location = New Point(234, 92)
        picCover.Margin = New Padding(3, 2, 3, 2)
        picCover.Name = "picCover"
        picCover.Size = New Size(257, 320)
        picCover.TabIndex = 0
        picCover.TabStop = False
        ' 
        ' Guest
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(880, 475)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
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
