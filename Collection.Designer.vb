<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collection
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
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(10, 9)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(679, 320)
        Panel1.TabIndex = 0
        ' 
        ' Collection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Collection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Collection"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
End Class
