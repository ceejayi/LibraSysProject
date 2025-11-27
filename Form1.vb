Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Book Title")
        ComboBox1.Items.Add("Author")
        ComboBox1.Items.Add("Year Published")
        ComboBox1.Items.Add("Genre")
        ComboBox1.Items.Add("ISBN")          ' optional
        ComboBox1.Items.Add("Book Condition") ' optional

        ComboBox1.SelectedIndex = 0 ' default selection

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ' You can write filtering logic here later
        ' Example:
        ' If ComboBox1.Text = "Author" Then
        '     FilterByAuthor()
        ' End If

    End Sub
End Class
