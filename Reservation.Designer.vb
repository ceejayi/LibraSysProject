<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        bttnaccepted = New Button()
        bttnrejected = New Button()
        bttnback = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.RESERVATION
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(bttnaccepted)
        Panel1.Controls.Add(bttnrejected)
        Panel1.Controls.Add(bttnback)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1258, 791)
        Panel1.TabIndex = 0
        ' 
        ' bttnaccepted
        ' 
        bttnaccepted.BackColor = Color.Transparent
        bttnaccepted.FlatAppearance.BorderSize = 0
        bttnaccepted.FlatStyle = FlatStyle.Flat
        bttnaccepted.Location = New Point(520, 636)
        bttnaccepted.Name = "bttnaccepted"
        bttnaccepted.Size = New Size(175, 50)
        bttnaccepted.TabIndex = 2
        bttnaccepted.UseVisualStyleBackColor = False
        ' 
        ' bttnrejected
        ' 
        bttnrejected.BackColor = Color.Transparent
        bttnrejected.FlatAppearance.BorderSize = 0
        bttnrejected.FlatStyle = FlatStyle.Flat
        bttnrejected.Location = New Point(748, 636)
        bttnrejected.Name = "bttnrejected"
        bttnrejected.Size = New Size(161, 50)
        bttnrejected.TabIndex = 1
        bttnrejected.UseVisualStyleBackColor = False
        ' 
        ' bttnback
        ' 
        bttnback.BackColor = Color.Transparent
        bttnback.FlatAppearance.BorderSize = 0
        bttnback.FlatStyle = FlatStyle.Flat
        bttnback.ForeColor = Color.Transparent
        bttnback.Location = New Point(1108, 690)
        bttnback.Margin = New Padding(4)
        bttnback.Name = "bttnback"
        bttnback.Size = New Size(118, 36)
        bttnback.TabIndex = 0
        bttnback.UseVisualStyleBackColor = False
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 791)
        Controls.Add(Panel1)
        Margin = New Padding(4)
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttnback As Button
    Friend WithEvents bttnaccepted As Button
    Friend WithEvents bttnrejected As Button
End Class
