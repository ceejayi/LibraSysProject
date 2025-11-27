<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnForm))
        Panel1 = New Panel()
        Button3 = New Button()
        btnReview = New Button()
        btnReturn = New Button()
        lblTitle = New Label()
        lblAuthorGenre = New Label()
        lblDescription = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(lblDescription)
        Panel1.Controls.Add(lblAuthorGenre)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(btnReview)
        Panel1.Controls.Add(btnReturn)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(884, 541)
        Button3.Name = "Button3"
        Button3.Size = New Size(53, 26)
        Button3.TabIndex = 3
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnReview
        ' 
        btnReview.BackColor = Color.Transparent
        btnReview.FlatAppearance.BorderSize = 0
        btnReview.FlatStyle = FlatStyle.Flat
        btnReview.Location = New Point(506, 507)
        btnReview.Name = "btnReview"
        btnReview.Size = New Size(79, 37)
        btnReview.TabIndex = 2
        btnReview.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Transparent
        btnReturn.FlatAppearance.BorderSize = 0
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Location = New Point(402, 507)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(80, 37)
        btnReturn.TabIndex = 1
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.Control
        lblTitle.Location = New Point(402, 157)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(483, 35)
        lblTitle.TabIndex = 5
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAuthorGenre
        ' 
        lblAuthorGenre.BackColor = Color.Transparent
        lblAuthorGenre.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAuthorGenre.ForeColor = SystemColors.Control
        lblAuthorGenre.Location = New Point(402, 212)
        lblAuthorGenre.Name = "lblAuthorGenre"
        lblAuthorGenre.Size = New Size(483, 101)
        lblAuthorGenre.TabIndex = 6
        lblAuthorGenre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDescription
        ' 
        lblDescription.BackColor = Color.Transparent
        lblDescription.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = SystemColors.Control
        lblDescription.Location = New Point(402, 336)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(483, 154)
        lblDescription.TabIndex = 7
        lblDescription.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Salmon
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(119, 157)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(265, 403)
        Panel2.TabIndex = 8
        ' 
        ' ReturnForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "ReturnForm"
        Text = "Return"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthorGenre As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents Panel2 As Panel
End Class
