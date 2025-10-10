<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMainPage
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
        components = New ComponentModel.Container()
        PanelMain = New Panel()
        Panel3 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PanelMain.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.AutoScroll = True
        PanelMain.BackgroundImage = My.Resources.Resources.MAINPAGE2
        PanelMain.BackgroundImageLayout = ImageLayout.Stretch
        PanelMain.BorderStyle = BorderStyle.FixedSingle
        PanelMain.Controls.Add(Panel3)
        PanelMain.Controls.Add(Panel2)
        PanelMain.Controls.Add(Panel1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.ImeMode = ImeMode.Off
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1006, 633)
        PanelMain.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.USERNAVBAR2
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.ForeColor = Color.DarkKhaki
        Panel3.Location = New Point(-200, 73)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(188, 559)
        Panel3.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(37, 361)
        Button5.Name = "Button5"
        Button5.Size = New Size(114, 34)
        Button5.TabIndex = 6
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(37, 288)
        Button4.Name = "Button4"
        Button4.Size = New Size(114, 34)
        Button4.TabIndex = 5
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(37, 223)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 34)
        Button3.TabIndex = 4
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(37, 160)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 34)
        Button2.TabIndex = 3
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.Location = New Point(37, 96)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 34)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Location = New Point(145, 250)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(820, 335)
        Panel2.TabIndex = 2
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(PictureBox2)
        FlowLayoutPanel1.Controls.Add(PictureBox3)
        FlowLayoutPanel1.Controls.Add(PictureBox4)
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Margin = New Padding(10)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(820, 343)
        FlowLayoutPanel1.TabIndex = 0
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._1__The_winter_s_tale__Author__William_Shakespeare
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(35, 70)
        PictureBox1.Margin = New Padding(35, 70, 5, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 250)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources._91
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(427, 70)
        PictureBox3.Margin = New Padding(35, 70, 5, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(156, 250)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Location = New Point(0, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 562)
        Panel1.TabIndex = 1
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources._6_The_history_of_Herodotus__Author__Herodotus1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(231, 70)
        PictureBox2.Margin = New Padding(35, 70, 5, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(156, 250)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources._121
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(623, 70)
        PictureBox4.Margin = New Padding(35, 70, 5, 10)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(156, 250)
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' UserMainPage
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(PanelMain)
        Name = "UserMainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserMainPage"
        PanelMain.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
