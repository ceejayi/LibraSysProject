<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlreadyRead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlreadyRead))
        btnBorrowHistory = New Button()
        SuspendLayout()
        ' 
        ' btnBorrowHistory
        ' 
        btnBorrowHistory.BackColor = Color.Transparent
        btnBorrowHistory.FlatAppearance.BorderSize = 0
        btnBorrowHistory.FlatStyle = FlatStyle.Flat
        btnBorrowHistory.Location = New Point(76, 190)
        btnBorrowHistory.Name = "btnBorrowHistory"
        btnBorrowHistory.Size = New Size(225, 29)
        btnBorrowHistory.TabIndex = 0
        btnBorrowHistory.UseVisualStyleBackColor = False
        ' 
        ' AlreadyRead
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 633)
        Controls.Add(btnBorrowHistory)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AlreadyRead"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AlreadyRead"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBorrowHistory As Button
End Class
