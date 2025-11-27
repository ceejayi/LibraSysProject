<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReviewForm))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(160, 227)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(450, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(160, 279)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(159, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(160, 377)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.ScrollBars = ScrollBars.Vertical
        TextBox4.Size = New Size(450, 66)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(160, 465)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.ScrollBars = ScrollBars.Vertical
        TextBox5.Size = New Size(450, 66)
        TextBox5.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(425, 557)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 29)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(527, 557)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 29)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1,2,3,4,5"})
        ComboBox1.Location = New Point(160, 330)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(159, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' ReviewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(641, 613)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ReviewForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReviewForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
