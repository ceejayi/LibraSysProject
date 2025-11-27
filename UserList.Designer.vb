<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserList
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
        editBtn = New Button()
        deleteBtn = New Button()
        AddBtn = New Button()
        ListOfUser = New DataGridView()
        BackBtn = New Button()
        Panel1.SuspendLayout()
        CType(ListOfUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.UserList
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(BackBtn)
        Panel1.Controls.Add(editBtn)
        Panel1.Controls.Add(deleteBtn)
        Panel1.Controls.Add(AddBtn)
        Panel1.Controls.Add(ListOfUser)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' editBtn
        ' 
        editBtn.BackColor = Color.Transparent
        editBtn.FlatAppearance.BorderSize = 0
        editBtn.FlatStyle = FlatStyle.Flat
        editBtn.Location = New Point(552, 548)
        editBtn.Name = "editBtn"
        editBtn.Size = New Size(57, 29)
        editBtn.TabIndex = 5
        editBtn.UseVisualStyleBackColor = False
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.Transparent
        deleteBtn.FlatAppearance.BorderSize = 0
        deleteBtn.FlatStyle = FlatStyle.Flat
        deleteBtn.Location = New Point(464, 548)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(57, 29)
        deleteBtn.TabIndex = 4
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = Color.Transparent
        AddBtn.FlatAppearance.BorderSize = 0
        AddBtn.FlatStyle = FlatStyle.Flat
        AddBtn.Location = New Point(375, 548)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(58, 29)
        AddBtn.TabIndex = 3
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' ListOfUser
        ' 
        ListOfUser.BackgroundColor = Color.Tomato
        ListOfUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListOfUser.GridColor = Color.Coral
        ListOfUser.Location = New Point(36, 173)
        ListOfUser.Name = "ListOfUser"
        ListOfUser.RowHeadersWidth = 51
        ListOfUser.Size = New Size(910, 333)
        ListOfUser.TabIndex = 2
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Transparent
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Location = New Point(889, 548)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(57, 29)
        BackBtn.TabIndex = 6
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' UserList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserList"
        Panel1.ResumeLayout(False)
        CType(ListOfUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListOfUser As DataGridView
    Friend WithEvents AddBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents BackBtn As Button
End Class
