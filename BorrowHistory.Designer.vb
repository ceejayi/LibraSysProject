<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowHistory
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
        alreadyRead = New Button()
        wantToRead = New Button()
        currentlyReading = New Button()
        serviceFeedback = New Button()
        myReviews = New Button()
        brrowHistory = New Button()
        browse = New Button()
        logOut = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BorrowHistory
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(alreadyRead)
        Panel1.Controls.Add(wantToRead)
        Panel1.Controls.Add(currentlyReading)
        Panel1.Controls.Add(serviceFeedback)
        Panel1.Controls.Add(myReviews)
        Panel1.Controls.Add(brrowHistory)
        Panel1.Controls.Add(browse)
        Panel1.Controls.Add(logOut)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' alreadyRead
        ' 
        alreadyRead.Location = New Point(73, 470)
        alreadyRead.Name = "alreadyRead"
        alreadyRead.Size = New Size(220, 29)
        alreadyRead.TabIndex = 8
        alreadyRead.Text = "alreadyRead"
        alreadyRead.UseVisualStyleBackColor = True
        ' 
        ' wantToRead
        ' 
        wantToRead.Location = New Point(73, 422)
        wantToRead.Name = "wantToRead"
        wantToRead.Size = New Size(220, 29)
        wantToRead.TabIndex = 7
        wantToRead.Text = "wantToRead"
        wantToRead.UseVisualStyleBackColor = True
        ' 
        ' currentlyReading
        ' 
        currentlyReading.Location = New Point(73, 373)
        currentlyReading.Name = "currentlyReading"
        currentlyReading.Size = New Size(220, 29)
        currentlyReading.TabIndex = 6
        currentlyReading.Text = "currentlyReading"
        currentlyReading.UseVisualStyleBackColor = True
        ' 
        ' serviceFeedback
        ' 
        serviceFeedback.Location = New Point(73, 264)
        serviceFeedback.Name = "serviceFeedback"
        serviceFeedback.Size = New Size(220, 29)
        serviceFeedback.TabIndex = 5
        serviceFeedback.Text = "serviceFeedback"
        serviceFeedback.UseVisualStyleBackColor = True
        ' 
        ' myReviews
        ' 
        myReviews.Location = New Point(73, 222)
        myReviews.Name = "myReviews"
        myReviews.Size = New Size(220, 29)
        myReviews.TabIndex = 4
        myReviews.Text = "myReviews"
        myReviews.UseVisualStyleBackColor = True
        ' 
        ' brrowHistory
        ' 
        brrowHistory.Location = New Point(72, 180)
        brrowHistory.Name = "brrowHistory"
        brrowHistory.Size = New Size(220, 29)
        brrowHistory.TabIndex = 3
        brrowHistory.Text = "borrowHistory"
        brrowHistory.UseVisualStyleBackColor = True
        ' 
        ' browse
        ' 
        browse.Location = New Point(233, 533)
        browse.Name = "browse"
        browse.Size = New Size(59, 29)
        browse.TabIndex = 2
        browse.Text = "browse"
        browse.UseVisualStyleBackColor = True
        ' 
        ' logOut
        ' 
        logOut.Location = New Point(72, 533)
        logOut.Name = "logOut"
        logOut.Size = New Size(59, 29)
        logOut.TabIndex = 1
        logOut.Text = "logOut"
        logOut.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.ForeColor = SystemColors.ControlText
        Panel2.Location = New Point(335, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(569, 429)
        Panel2.TabIndex = 0
        ' 
        ' BorrowHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "BorrowHistory"
        Text = "BorrowHistory"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents alreadyRead As Button
    Friend WithEvents wantToRead As Button
    Friend WithEvents currentlyReading As Button
    Friend WithEvents serviceFeedback As Button
    Friend WithEvents myReviews As Button
    Friend WithEvents brrowHistory As Button
    Friend WithEvents browse As Button
    Friend WithEvents logOut As Button
    Friend WithEvents Panel2 As Panel
End Class
