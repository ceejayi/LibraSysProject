<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Button1 = New Button()
        FlowLayoutPanelGenres = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.UserMainPage
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(FlowLayoutPanelGenres)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(901, 541)
        Button3.Name = "Button3"
        Button3.Size = New Size(51, 26)
        Button3.TabIndex = 4
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(627, 196)
        Button2.Name = "Button2"
        Button2.Size = New Size(42, 36)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = SystemColors.WindowText
        TextBox1.Location = New Point(317, 202)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(297, 20)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(219, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 41)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanelGenres
        ' 
        FlowLayoutPanelGenres.AutoScroll = True
        FlowLayoutPanelGenres.BackColor = SystemColors.Control
        FlowLayoutPanelGenres.Location = New Point(42, 261)
        FlowLayoutPanelGenres.Name = "FlowLayoutPanelGenres"
        FlowLayoutPanelGenres.Size = New Size(845, 309)
        FlowLayoutPanelGenres.TabIndex = 0
        FlowLayoutPanelGenres.WrapContents = False
        ' 
        ' UserMainPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserMainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserMainPagee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanelGenres As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
