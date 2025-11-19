<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookChosen
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
        Panel2 = New Panel()
        lblDescription = New Label()
        lblAuthorGenre = New Label()
        lblTitle = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BookChosen
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(lblDescription)
        Panel1.Controls.Add(lblAuthorGenre)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(119, 158)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(265, 403)
        Panel2.TabIndex = 7
        ' 
        ' lblDescription
        ' 
        lblDescription.BackColor = Color.Transparent
        lblDescription.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = SystemColors.Control
        lblDescription.Location = New Point(402, 336)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(483, 154)
        lblDescription.TabIndex = 6
        lblDescription.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAuthorGenre
        ' 
        lblAuthorGenre.BackColor = Color.Transparent
        lblAuthorGenre.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAuthorGenre.ForeColor = SystemColors.Control
        lblAuthorGenre.Location = New Point(402, 212)
        lblAuthorGenre.Name = "lblAuthorGenre"
        lblAuthorGenre.Size = New Size(483, 101)
        lblAuthorGenre.TabIndex = 5
        lblAuthorGenre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.Control
        lblTitle.Location = New Point(402, 157)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(483, 35)
        lblTitle.TabIndex = 4
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(883, 540)
        Button3.Name = "Button3"
        Button3.Size = New Size(57, 26)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(503, 510)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 36)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(402, 510)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 36)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BookChosen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BookChosen"
        Text = "BookChosen"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblAuthorGenre As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
End Class
