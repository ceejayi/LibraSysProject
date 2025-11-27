<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClearanceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClearanceForm))
        Panel1 = New Panel()
        chk = New CheckBox()
        Button2 = New Button()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(chk)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
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
        chk.Location = New Point(127, 554)
        chk.Name = "chk"
        chk.Size = New Size(59, 24)
        chk.TabIndex = 4
        chk.Text = "Hide"
        chk.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(895, 525)
        Button2.Name = "Button2"
        Button2.Size = New Size(61, 27)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.Salmon
        Panel2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(127, 220)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(752, 258)
        Panel2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(127, 515)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(302, 21)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(448, 507)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 36)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ClearanceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "ClearanceForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClearanceForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents chk As CheckBox
End Class
