<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookManagement
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
        btnSave = New Button()
        btnClear = New Button()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BookManagement
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(617, 589)
        Panel1.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(513, 500)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(81, 29)
        btnSave.TabIndex = 7
        btnSave.Text = "Button2"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(415, 500)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 29)
        btnClear.TabIndex = 6
        btnClear.Text = "Button1"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(268, 458)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(326, 27)
        TextBox7.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(268, 421)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(326, 27)
        TextBox6.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(268, 381)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(326, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(268, 346)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(326, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(268, 312)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(326, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(268, 279)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(326, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(268, 246)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 27)
        TextBox1.TabIndex = 0
        ' 
        ' BookManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 613)
        Controls.Add(Panel1)
        Name = "BookManagement"
        Text = "BookManagement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
