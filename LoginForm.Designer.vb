<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        ButtonLogin = New Button()
        ButtonCancel = New Button()
        SuspendLayout()
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(120, 113)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(125, 27)
        TextBoxUsername.TabIndex = 0
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(120, 176)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(125, 27)
        TextBoxPassword.TabIndex = 1
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(500, 49)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(94, 29)
        ButtonLogin.TabIndex = 2
        ButtonLogin.Text = "Button1"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Location = New Point(353, 211)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(94, 29)
        ButtonCancel.TabIndex = 3
        ButtonCancel.Text = "Button1"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCancel)
        Controls.Add(ButtonLogin)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonCancel As Button
End Class
