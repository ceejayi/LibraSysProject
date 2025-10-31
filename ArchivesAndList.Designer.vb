<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchivesAndList
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
        bttnBack = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.ARCHIVESANDLIST1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(bttnBack)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1258, 791)
        Panel1.TabIndex = 0
        ' 
        ' bttnBack
        ' 
        bttnBack.BackColor = Color.Transparent
        bttnBack.FlatAppearance.BorderSize = 0
        bttnBack.FlatStyle = FlatStyle.Flat
        bttnBack.Location = New Point(184, 705)
        bttnBack.Margin = New Padding(4, 4, 4, 4)
        bttnBack.Name = "bttnBack"
        bttnBack.Size = New Size(118, 36)
        bttnBack.TabIndex = 0
        bttnBack.UseVisualStyleBackColor = False
        ' 
        ' ArchivesAndList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 791)
        Controls.Add(Panel1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "ArchivesAndList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ArchivesAndList"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttnBack As Button
End Class
