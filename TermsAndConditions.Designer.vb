<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TermsAndConditions
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
        Label1 = New Label()
        termsandcondi = New Label()
        userpass = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.TermsAndConditions
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(termsandcondi)
        Panel1.Controls.Add(userpass)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(129, 511)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 35)
        Label1.TabIndex = 7
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' termsandcondi
        ' 
        termsandcondi.BackColor = Color.Transparent
        termsandcondi.Font = New Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        termsandcondi.ForeColor = SystemColors.Control
        termsandcondi.Location = New Point(129, 221)
        termsandcondi.Name = "termsandcondi"
        termsandcondi.Size = New Size(747, 211)
        termsandcondi.TabIndex = 6
        termsandcondi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' userpass
        ' 
        userpass.Location = New Point(129, 458)
        userpass.Name = "userpass"
        userpass.Size = New Size(299, 27)
        userpass.TabIndex = 0
        ' 
        ' TermsAndConditions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "TermsAndConditions"
        Text = "TermsAndConditions"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents userpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents termsandcondi As Label
End Class
