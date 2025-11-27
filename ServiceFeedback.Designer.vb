<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceFeedback
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
        Panel2 = New Panel()
        btnSubmit = New Button()
        TextBox2 = New TextBox()
        lblComments = New Label()
        cmbRating = New ComboBox()
        lblRating = New Label()
        TextBox1 = New TextBox()
        lblName = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.ServiceFeedback
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 609)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Salmon
        Panel2.Controls.Add(btnSubmit)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(lblComments)
        Panel2.Controls.Add(cmbRating)
        Panel2.Controls.Add(lblRating)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(lblName)
        Panel2.Location = New Point(324, 124)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(593, 444)
        Panel2.TabIndex = 0
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.White
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Red
        btnSubmit.Location = New Point(485, 395)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 29)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(216, 139)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(344, 211)
        TextBox2.TabIndex = 5
        ' 
        ' lblComments
        ' 
        lblComments.AutoSize = True
        lblComments.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblComments.Location = New Point(82, 142)
        lblComments.Name = "lblComments"
        lblComments.Size = New Size(120, 23)
        lblComments.TabIndex = 4
        lblComments.Text = "Your Feedback"
        ' 
        ' cmbRating
        ' 
        cmbRating.FormattingEnabled = True
        cmbRating.Items.AddRange(New Object() {"1,2,3,4,5"})
        cmbRating.Location = New Point(216, 76)
        cmbRating.Name = "cmbRating"
        cmbRating.Size = New Size(151, 28)
        cmbRating.TabIndex = 3
        ' 
        ' lblRating
        ' 
        lblRating.AutoSize = True
        lblRating.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRating.Location = New Point(99, 79)
        lblRating.Name = "lblRating"
        lblRating.Size = New Size(99, 23)
        lblRating.TabIndex = 2
        lblRating.Text = "Rating (1-5)"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(216, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(344, 27)
        TextBox1.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(35, 26)
        lblName.Name = "lblName"
        lblName.Size = New Size(173, 23)
        lblName.TabIndex = 0
        lblName.Text = "Your Name (optional)"
        ' 
        ' ServiceFeedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 633)
        Controls.Add(Panel1)
        Name = "ServiceFeedback"
        Text = "ServiceFeedback"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblComments As Label
End Class
