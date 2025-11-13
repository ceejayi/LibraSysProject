<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Panel1 = New Panel()
        bttnBack = New Button()
        BtnContinue = New Button()
        TxtboxPassword = New TextBox()
        TxtboxUsername = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(bttnBack)
        Panel1.Controls.Add(BtnContinue)
        Panel1.Controls.Add(TxtboxPassword)
        Panel1.Controls.Add(TxtboxUsername)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(988, 622)
        Panel1.TabIndex = 0
        ' 
        ' bttnBack
        ' 
        bttnBack.BackColor = Color.Transparent
        bttnBack.FlatAppearance.BorderSize = 0
        bttnBack.FlatStyle = FlatStyle.Flat
        bttnBack.Location = New Point(892, 628)
        bttnBack.Margin = New Padding(2)
        bttnBack.Name = "bttnBack"
        bttnBack.Size = New Size(121, 48)
        bttnBack.TabIndex = 3
        bttnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnContinue
        ' 
        BtnContinue.BackColor = Color.Transparent
        BtnContinue.FlatAppearance.BorderSize = 0
        BtnContinue.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnContinue.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnContinue.FlatStyle = FlatStyle.Flat
        BtnContinue.Location = New Point(711, 498)
        BtnContinue.Margin = New Padding(4)
        BtnContinue.Name = "BtnContinue"
        BtnContinue.Size = New Size(126, 48)
        BtnContinue.TabIndex = 2
        BtnContinue.Text = "'"
        BtnContinue.UseVisualStyleBackColor = False
        ' 
        ' TxtboxPassword
        ' 
        TxtboxPassword.BackColor = Color.Wheat
        TxtboxPassword.BorderStyle = BorderStyle.None
        TxtboxPassword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TxtboxPassword.Location = New Point(556, 486)
        TxtboxPassword.Margin = New Padding(4)
        TxtboxPassword.MaximumSize = New Size(600, 80)
        TxtboxPassword.Multiline = True
        TxtboxPassword.Name = "TxtboxPassword"
        TxtboxPassword.Size = New Size(105, 41)
        TxtboxPassword.TabIndex = 1
        ' 
        ' TxtboxUsername
        ' 
        TxtboxUsername.BackColor = Color.Wheat
        TxtboxUsername.BorderStyle = BorderStyle.None
        TxtboxUsername.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtboxUsername.Location = New Point(540, 158)
        TxtboxUsername.Margin = New Padding(4)
        TxtboxUsername.Multiline = True
        TxtboxUsername.Name = "TxtboxUsername"
        TxtboxUsername.Size = New Size(297, 73)
        TxtboxUsername.TabIndex = 0
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(988, 622)
        Controls.Add(Panel1)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AdminLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtboxPassword As TextBox
    Friend WithEvents TxtboxUsername As TextBox
    Friend WithEvents BtnContinue As Button
    Friend WithEvents bttnBack As Button
End Class
