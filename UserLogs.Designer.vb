<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogs
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
        UserLogss = New DataGridView()
        BackBtn = New Button()
        Panel1.SuspendLayout()
        CType(UserLogss, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.UserLogs
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(BackBtn)
        Panel1.Controls.Add(UserLogss)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' UserLogss
        ' 
        UserLogss.BackgroundColor = Color.Tomato
        UserLogss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserLogss.GridColor = Color.Coral
        UserLogss.Location = New Point(36, 172)
        UserLogss.Name = "UserLogss"
        UserLogss.RowHeadersWidth = 51
        UserLogss.Size = New Size(910, 333)
        UserLogss.TabIndex = 3
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Transparent
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Location = New Point(889, 549)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(57, 29)
        BackBtn.TabIndex = 7
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' UserLogs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserLogs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserLogs"
        Panel1.ResumeLayout(False)
        CType(UserLogss, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserLogss As DataGridView
    Friend WithEvents BackBtn As Button
End Class
