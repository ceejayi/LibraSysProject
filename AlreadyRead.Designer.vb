<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlreadyRead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlreadyRead))
        btnBorrowHistory = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        alreadyReadd = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' btnBorrowHistory
        ' 
        btnBorrowHistory.BackColor = Color.Transparent
        btnBorrowHistory.FlatAppearance.BorderSize = 0
        btnBorrowHistory.FlatStyle = FlatStyle.Flat
        btnBorrowHistory.Location = New Point(76, 190)
        btnBorrowHistory.Name = "btnBorrowHistory"
        btnBorrowHistory.Size = New Size(225, 29)
        btnBorrowHistory.TabIndex = 0
        btnBorrowHistory.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(76, 190)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 29)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(76, 236)
        Button2.Name = "Button2"
        Button2.Size = New Size(225, 29)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(75, 277)
        Button3.Name = "Button3"
        Button3.Size = New Size(225, 29)
        Button3.TabIndex = 3
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(75, 386)
        Button4.Name = "Button4"
        Button4.Size = New Size(225, 29)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(75, 439)
        Button5.Name = "Button5"
        Button5.Size = New Size(225, 29)
        Button5.TabIndex = 5
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(76, 486)
        Button6.Name = "Button6"
        Button6.Size = New Size(224, 29)
        Button6.TabIndex = 6
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(77, 561)
        Button7.Name = "Button7"
        Button7.Size = New Size(52, 29)
        Button7.TabIndex = 7
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(237, 561)
        Button8.Name = "Button8"
        Button8.Size = New Size(63, 19)
        Button8.TabIndex = 8
        Button8.UseVisualStyleBackColor = False
        ' 
        ' alreadyReadd
        ' 
        alreadyReadd.AutoScroll = True
        alreadyReadd.BackColor = Color.MistyRose
        alreadyReadd.Location = New Point(350, 190)
        alreadyReadd.Name = "alreadyReadd"
        alreadyReadd.Size = New Size(572, 335)
        alreadyReadd.TabIndex = 9
        alreadyReadd.WrapContents = False
        ' 
        ' AlreadyRead
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 633)
        Controls.Add(alreadyReadd)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnBorrowHistory)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AlreadyRead"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AlreadyRead"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBorrowHistory As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents alreadyReadd As FlowLayoutPanel
End Class
