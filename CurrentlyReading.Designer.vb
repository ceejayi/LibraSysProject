<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentlyReading
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        currentlyReadingg = New FlowLayoutPanel()
        btnRead = New Button()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(76, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 29)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(75, 237)
        Button2.Name = "Button2"
        Button2.Size = New Size(224, 29)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(74, 275)
        Button3.Name = "Button3"
        Button3.Size = New Size(225, 29)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(76, 441)
        Button4.Name = "Button4"
        Button4.Size = New Size(223, 22)
        Button4.TabIndex = 3
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(74, 489)
        Button5.Name = "Button5"
        Button5.Size = New Size(225, 29)
        Button5.TabIndex = 4
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(76, 558)
        Button6.Name = "Button6"
        Button6.Size = New Size(56, 29)
        Button6.TabIndex = 5
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(237, 557)
        Button7.Name = "Button7"
        Button7.Size = New Size(62, 30)
        Button7.TabIndex = 6
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(74, 386)
        Button8.Name = "Button8"
        Button8.Size = New Size(225, 29)
        Button8.TabIndex = 7
        Button8.UseVisualStyleBackColor = False
        ' 
        ' currentlyReadingg
        ' 
        currentlyReadingg.AutoScroll = True
        currentlyReadingg.BackColor = Color.MistyRose
        currentlyReadingg.Location = New Point(353, 143)
        currentlyReadingg.Name = "currentlyReadingg"
        currentlyReadingg.Size = New Size(572, 309)
        currentlyReadingg.TabIndex = 8
        currentlyReadingg.WrapContents = False
        ' 
        ' btnRead
        ' 
        btnRead.BackColor = Color.Transparent
        btnRead.FlatAppearance.BorderSize = 0
        btnRead.FlatStyle = FlatStyle.Flat
        btnRead.Location = New Point(498, 548)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(62, 30)
        btnRead.TabIndex = 9
        btnRead.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Transparent
        btnReturn.FlatAppearance.BorderSize = 0
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Location = New Point(710, 548)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(62, 30)
        btnReturn.TabIndex = 10
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' CurrentlyReading
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.CurrentlyReading
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 633)
        Controls.Add(btnReturn)
        Controls.Add(btnRead)
        Controls.Add(currentlyReadingg)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "CurrentlyReading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CurrentlyReading"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents currentlyReadingg As FlowLayoutPanel
    Friend WithEvents btnRead As Button
    Friend WithEvents btnReturn As Button
End Class
