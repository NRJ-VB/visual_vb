Public Class voter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        age = TextBox2.Text
        If (age >= 18) Then
            MsgBox(TextBox1.Text & " you can vote")
        Else
            MsgBox("Sorry " & TextBox1.Text & " YOU are not eligble for voting")


        End If
    End Sub
End Class