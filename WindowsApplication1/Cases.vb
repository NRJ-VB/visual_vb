Public Class Cases
    Private Sub Cases_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim day As Integer
        Print("Enter any number b/w 1-7")
        day = TextBox1.Text
        Select Case day
            Case 1
                MsgBox("Monday")
            Case 2
                MsgBox("Tuesday")
            Case 3
                MsgBox("Wednesday")
            Case 4
                MsgBox("Thursday")
            Case 5
                MsgBox("Friday")
            Case 6
                MsgBox("Saturday")
            Case 7
                MsgBox("Sunday")
            Case Else
                MsgBox("Wrong Number")

        End Select
    End Sub
End Class