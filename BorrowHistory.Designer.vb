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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        logOut = New Button()
        Button8 = New Button()
        borrowHistoryy = New DataGridView()
        Panel1.SuspendLayout()
        CType(borrowHistoryy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BorrowHistory1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(borrowHistoryy)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(logOut)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(74, 180)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 29)
        Button1.TabIndex = 0
        Button1.Text = "Borrow History"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(73, 222)
        Button2.Name = "Button2"
        Button2.Size = New Size(220, 29)
        Button2.TabIndex = 1
        Button2.Text = "My Reviews"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(73, 262)
        Button3.Name = "Button3"
        Button3.Size = New Size(220, 29)
        Button3.TabIndex = 2
        Button3.Text = "Service Feedback"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(74, 372)
        Button4.Name = "Button4"
        Button4.Size = New Size(220, 29)
        Button4.TabIndex = 3
        Button4.Text = "CurrentlyReading"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(74, 418)
        Button5.Name = "Button5"
        Button5.Size = New Size(220, 29)
        Button5.TabIndex = 4
        Button5.Text = "Want To Read"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(74, 468)
        Button6.Name = "Button6"
        Button6.Size = New Size(220, 29)
        Button6.TabIndex = 5
        Button6.Text = "Already Read"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' logOut
        ' 
        logOut.Location = New Point(74, 532)
        logOut.Name = "logOut"
        logOut.Size = New Size(56, 29)
        logOut.TabIndex = 6
        logOut.Text = "LogOut"
        logOut.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(230, 532)
        Button8.Name = "Button8"
        Button8.Size = New Size(64, 29)
        Button8.TabIndex = 7
        Button8.Text = "Browse"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' borrowHistoryy
        ' 
        borrowHistoryy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowHistoryy.Location = New Point(342, 132)
        borrowHistoryy.Name = "borrowHistoryy"
        borrowHistoryy.RowHeadersWidth = 51
        borrowHistoryy.Size = New Size(559, 429)
        borrowHistoryy.TabIndex = 8
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
        CType(borrowHistoryy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents logOut As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents borrowHistoryy As DataGridView
End Class
