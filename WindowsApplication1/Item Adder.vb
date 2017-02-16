Public Class Item_Adder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = " "
    End Sub
End Class