<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturningClearance
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
        TextBox1 = New TextBox()
        btnCleared = New Button()
        Button2 = New Button()
        chk = New CheckBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 534)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(307, 27)
        TextBox1.TabIndex = 0
        ' 
        ' btnCleared
        ' 
        btnCleared.BackColor = Color.Transparent
        btnCleared.FlatAppearance.BorderSize = 0
        btnCleared.FlatStyle = FlatStyle.Flat
        btnCleared.Location = New Point(457, 525)
        btnCleared.Name = "btnCleared"
        btnCleared.Size = New Size(92, 43)
        btnCleared.TabIndex = 1
        btnCleared.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(919, 549)
        Button2.Name = "Button2"
        Button2.Size = New Size(58, 19)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' chk
        ' 
        chk.AutoSize = True
        chk.BackColor = Color.Transparent
        chk.FlatAppearance.BorderColor = Color.White
        chk.FlatAppearance.BorderSize = 0
        chk.FlatAppearance.CheckedBackColor = Color.Transparent
        chk.FlatAppearance.MouseDownBackColor = Color.Transparent
        chk.FlatAppearance.MouseOverBackColor = Color.Transparent
        chk.FlatStyle = FlatStyle.Flat
        chk.Location = New Point(132, 575)
        chk.Name = "chk"
        chk.Size = New Size(59, 24)
        chk.TabIndex = 5
        chk.Text = "Hide"
        chk.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(161, 261)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(17, 16)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(161, 325)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(17, 16)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(161, 388)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(17, 16)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(161, 453)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(17, 16)
        RadioButton4.TabIndex = 9
        RadioButton4.TabStop = True
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(364, 445)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(365, 27)
        TextBox2.TabIndex = 10
        ' 
        ' ReturningClearance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.ReturningClearance1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 633)
        Controls.Add(TextBox2)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(chk)
        Controls.Add(Button2)
        Controls.Add(btnCleared)
        Controls.Add(TextBox1)
        Name = "ReturningClearance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReturningClearance"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCleared As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents chk As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox2 As TextBox
End Class
