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
        logOut = New Button()
        CollectionOfBooks = New DataGridView()
        Panel1.SuspendLayout()
        CType(CollectionOfBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.BookCollection1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(CollectionOfBooks)
        Panel1.Controls.Add(logOut)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' logOut
        ' 
        logOut.BackColor = Color.Transparent
        logOut.FlatAppearance.BorderSize = 0
        logOut.FlatAppearance.MouseDownBackColor = Color.Transparent
        logOut.FlatAppearance.MouseOverBackColor = Color.Transparent
        logOut.FlatStyle = FlatStyle.Flat
        logOut.Location = New Point(463, 548)
        logOut.Name = "logOut"
        logOut.Size = New Size(58, 30)
        logOut.TabIndex = 0
        logOut.UseVisualStyleBackColor = False
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
    Friend WithEvents logOut As Button
    Friend WithEvents CollectionOfBooks As DataGridView
End Class
