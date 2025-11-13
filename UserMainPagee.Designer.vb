<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMainPagee
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
        FlowLayoutPanelGenres = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.UserMainPage2
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(FlowLayoutPanelGenres)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' FlowLayoutPanelGenres
        ' 
        FlowLayoutPanelGenres.AutoScroll = True
        FlowLayoutPanelGenres.Location = New Point(42, 261)
        FlowLayoutPanelGenres.Name = "FlowLayoutPanelGenres"
        FlowLayoutPanelGenres.Size = New Size(845, 309)
        FlowLayoutPanelGenres.TabIndex = 0
        FlowLayoutPanelGenres.WrapContents = False
        ' 
        ' UserMainPagee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserMainPagee"
        Text = "UserMainPagee"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanelGenres As FlowLayoutPanel
End Class
