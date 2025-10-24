<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        BtnContinue = New Button()
        TxtboxPassword = New TextBox()
        TxtboxUsername = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.LOGINPAGE
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(BtnContinue)
        Panel1.Controls.Add(TxtboxPassword)
        Panel1.Controls.Add(TxtboxUsername)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 633)
        Panel1.TabIndex = 0
        ' 
        ' BtnContinue
        ' 
        BtnContinue.BackColor = Color.Transparent
        BtnContinue.FlatAppearance.BorderSize = 0
        BtnContinue.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnContinue.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnContinue.FlatStyle = FlatStyle.Flat
        BtnContinue.Location = New Point(642, 514)
        BtnContinue.Name = "BtnContinue"
        BtnContinue.Size = New Size(174, 38)
        BtnContinue.TabIndex = 2
        BtnContinue.UseVisualStyleBackColor = False
        ' 
        ' TxtboxPassword
        ' 
        TxtboxPassword.Location = New Point(562, 372)
        TxtboxPassword.Multiline = True
        TxtboxPassword.Name = "TxtboxPassword"
        TxtboxPassword.Size = New Size(341, 67)
        TxtboxPassword.TabIndex = 1
        ' 
        ' TxtboxUsername
        ' 
        TxtboxUsername.Location = New Point(562, 178)
        TxtboxUsername.Multiline = True
        TxtboxUsername.Name = "TxtboxUsername"
        TxtboxUsername.Size = New Size(341, 23)
        TxtboxUsername.TabIndex = 0
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
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
End Class
