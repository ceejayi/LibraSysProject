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
        CollectionOfBooks = New DataGridView()
        AddBtn = New Button()
        deleteBtn = New Button()
        editBtn = New Button()
        backBtn = New Button()
        Panel1.SuspendLayout()
        CType(CollectionOfBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BookCollection3
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(backBtn)
        Panel1.Controls.Add(editBtn)
        Panel1.Controls.Add(deleteBtn)
        Panel1.Controls.Add(AddBtn)
        Panel1.Controls.Add(CollectionOfBooks)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' CollectionOfBooks
        ' 
        CollectionOfBooks.BackgroundColor = SystemColors.Window
        CollectionOfBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CollectionOfBooks.Location = New Point(37, 174)
        CollectionOfBooks.Name = "CollectionOfBooks"
        CollectionOfBooks.RowHeadersWidth = 51
        CollectionOfBooks.Size = New Size(910, 333)
        CollectionOfBooks.TabIndex = 1
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(374, 548)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(58, 29)
        AddBtn.TabIndex = 2
        AddBtn.Text = "Button1"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Location = New Point(463, 548)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(57, 29)
        deleteBtn.TabIndex = 3
        deleteBtn.Text = "Button2"
        deleteBtn.UseVisualStyleBackColor = True
        ' 
        ' editBtn
        ' 
        editBtn.Location = New Point(552, 548)
        editBtn.Name = "editBtn"
        editBtn.Size = New Size(57, 29)
        editBtn.TabIndex = 4
        editBtn.Text = "Button3"
        editBtn.UseVisualStyleBackColor = True
        ' 
        ' backBtn
        ' 
        backBtn.Location = New Point(890, 548)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(57, 29)
        backBtn.TabIndex = 5
        backBtn.Text = "Button4"
        backBtn.UseVisualStyleBackColor = True
        ' 
        ' Collection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Collection"
        Text = "Collection"
        Panel1.ResumeLayout(False)
        CType(CollectionOfBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CollectionOfBooks As DataGridView
    Friend WithEvents backBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents AddBtn As Button
End Class
