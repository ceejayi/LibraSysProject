<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WantToRead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WantToRead))
        Panel1 = New Panel()
        btnBorrowHistory = New Button()
        btnMyReviews = New Button()
        btnServiceFeedback = New Button()
        btnCurrentlyReading = New Button()
        btnWanttoRead = New Button()
        btnAlreadyRead = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnAlreadyRead)
        Panel1.Controls.Add(btnWanttoRead)
        Panel1.Controls.Add(btnCurrentlyReading)
        Panel1.Controls.Add(btnServiceFeedback)
        Panel1.Controls.Add(btnMyReviews)
        Panel1.Controls.Add(btnBorrowHistory)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' btnBorrowHistory
        ' 
        btnBorrowHistory.BackColor = Color.Transparent
        btnBorrowHistory.FlatAppearance.BorderSize = 0
        btnBorrowHistory.FlatStyle = FlatStyle.Flat
        btnBorrowHistory.Location = New Point(72, 182)
        btnBorrowHistory.Name = "btnBorrowHistory"
        btnBorrowHistory.Size = New Size(221, 29)
        btnBorrowHistory.TabIndex = 0
        btnBorrowHistory.UseVisualStyleBackColor = False
        ' 
        ' btnMyReviews
        ' 
        btnMyReviews.BackColor = Color.Transparent
        btnMyReviews.FlatAppearance.BorderSize = 0
        btnMyReviews.FlatStyle = FlatStyle.Flat
        btnMyReviews.Location = New Point(71, 223)
        btnMyReviews.Name = "btnMyReviews"
        btnMyReviews.Size = New Size(222, 29)
        btnMyReviews.TabIndex = 1
        btnMyReviews.UseVisualStyleBackColor = False
        ' 
        ' btnServiceFeedback
        ' 
        btnServiceFeedback.BackColor = Color.Transparent
        btnServiceFeedback.FlatAppearance.BorderSize = 0
        btnServiceFeedback.FlatStyle = FlatStyle.Flat
        btnServiceFeedback.Location = New Point(71, 265)
        btnServiceFeedback.Name = "btnServiceFeedback"
        btnServiceFeedback.Size = New Size(222, 29)
        btnServiceFeedback.TabIndex = 2
        btnServiceFeedback.UseVisualStyleBackColor = False
        ' 
        ' btnCurrentlyReading
        ' 
        btnCurrentlyReading.BackColor = Color.Transparent
        btnCurrentlyReading.FlatAppearance.BorderSize = 0
        btnCurrentlyReading.FlatStyle = FlatStyle.Flat
        btnCurrentlyReading.Location = New Point(72, 371)
        btnCurrentlyReading.Name = "btnCurrentlyReading"
        btnCurrentlyReading.Size = New Size(221, 29)
        btnCurrentlyReading.TabIndex = 3
        btnCurrentlyReading.UseVisualStyleBackColor = False
        ' 
        ' btnWanttoRead
        ' 
        btnWanttoRead.BackColor = Color.Transparent
        btnWanttoRead.FlatAppearance.BorderSize = 0
        btnWanttoRead.FlatStyle = FlatStyle.Flat
        btnWanttoRead.Location = New Point(72, 418)
        btnWanttoRead.Name = "btnWanttoRead"
        btnWanttoRead.Size = New Size(221, 29)
        btnWanttoRead.TabIndex = 4
        btnWanttoRead.UseVisualStyleBackColor = False
        ' 
        ' btnAlreadyRead
        ' 
        btnAlreadyRead.BackColor = Color.Transparent
        btnAlreadyRead.FlatAppearance.BorderSize = 0
        btnAlreadyRead.FlatStyle = FlatStyle.Flat
        btnAlreadyRead.Location = New Point(73, 475)
        btnAlreadyRead.Name = "btnAlreadyRead"
        btnAlreadyRead.Size = New Size(220, 29)
        btnAlreadyRead.TabIndex = 5
        btnAlreadyRead.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(70, 533)
        Button1.Name = "Button1"
        Button1.Size = New Size(63, 29)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' wanttoreadform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "wanttoreadform"
        Text = "wanttoreadform"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAlreadyRead As Button
    Friend WithEvents btnWanttoRead As Button
    Friend WithEvents btnCurrentlyReading As Button
    Friend WithEvents btnServiceFeedback As Button
    Friend WithEvents btnMyReviews As Button
    Friend WithEvents btnBorrowHistory As Button
    Friend WithEvents Button1 As Button
End Class
