<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookChosen
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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        lblBookTitle = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BookChosen
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(lblBookTitle)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(869, 542)
        Button3.Name = "Button3"
        Button3.Size = New Size(79, 29)
        Button3.TabIndex = 4
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(509, 516)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 29)
        Button2.TabIndex = 3
        Button2.Text = "Borrow"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(403, 516)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 29)
        Button1.TabIndex = 2
        Button1.Text = "Read"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblBookTitle
        ' 
        lblBookTitle.AutoSize = True
        lblBookTitle.Location = New Point(621, 164)
        lblBookTitle.Name = "lblBookTitle"
        lblBookTitle.Size = New Size(53, 20)
        lblBookTitle.TabIndex = 1
        lblBookTitle.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(118, 156)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 405)
        Panel2.TabIndex = 0
        ' 
        ' BookChosen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BookChosen"
        Text = "BookChosen"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
