Public Class ListCheckBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ListBox1.SelectedItem
        Label1.Text = CheckedListBox1.SelectedItem
    End Sub
End Class