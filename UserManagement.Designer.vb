<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        TextBox5 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.UserManagement
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(TextBox5)
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
        btnSave.BackColor = Color.Transparent
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(511, 475)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(82, 29)
        btnSave.TabIndex = 13
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Transparent
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(414, 475)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(80, 29)
        btnClear.TabIndex = 12
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(268, 396)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(326, 27)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(268, 327)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(326, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(268, 294)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(326, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(268, 261)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 27)
        TextBox1.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Student,Faculty"})
        ComboBox1.Location = New Point(267, 360)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(326, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' UserManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 613)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserManagement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
