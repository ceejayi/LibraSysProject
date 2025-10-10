<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
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
        Button2 = New Button()
        eBookButton = New Button()
        BookPicture = New PictureBox()
        lblGenre = New Label()
        lblAuthor = New Label()
        lblDesc = New Label()
        lblTitle = New Label()
        Panel1.SuspendLayout()
        CType(BookPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BORROWING1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(eBookButton)
        Panel1.Controls.Add(BookPicture)
        Panel1.Controls.Add(lblGenre)
        Panel1.Controls.Add(lblAuthor)
        Panel1.Controls.Add(lblDesc)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 633)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(777, 475)
        Button2.Name = "Button2"
        Button2.Size = New Size(183, 39)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = False
        ' 
        ' eBookButton
        ' 
        eBookButton.BackColor = Color.Transparent
        eBookButton.FlatAppearance.BorderSize = 0
        eBookButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        eBookButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        eBookButton.FlatStyle = FlatStyle.Flat
        eBookButton.Location = New Point(581, 472)
        eBookButton.Name = "eBookButton"
        eBookButton.Size = New Size(185, 42)
        eBookButton.TabIndex = 5
        eBookButton.UseVisualStyleBackColor = False
        ' 
        ' BookPicture
        ' 
        BookPicture.Location = New Point(270, 125)
        BookPicture.Name = "BookPicture"
        BookPicture.Size = New Size(289, 424)
        BookPicture.TabIndex = 4
        BookPicture.TabStop = False
        ' 
        ' lblGenre
        ' 
        lblGenre.BackColor = Color.Transparent
        lblGenre.Location = New Point(800, 217)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(160, 34)
        lblGenre.TabIndex = 3
        lblGenre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAuthor
        ' 
        lblAuthor.BackColor = Color.Transparent
        lblAuthor.Location = New Point(581, 217)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(208, 34)
        lblAuthor.TabIndex = 2
        lblAuthor.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDesc
        ' 
        lblDesc.BackColor = Color.Transparent
        lblDesc.Location = New Point(581, 280)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(382, 170)
        lblDesc.TabIndex = 1
        lblDesc.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Location = New Point(581, 125)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(382, 61)
        lblTitle.TabIndex = 0
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Borrow
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Borrow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Borrow"
        Panel1.ResumeLayout(False)
        CType(BookPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents BookPicture As PictureBox
    Friend WithEvents eBookButton As Button
    Friend WithEvents Button2 As Button
End Class
