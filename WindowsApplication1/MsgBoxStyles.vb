Public Class MsgBoxStyles
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As MsgBoxResult
        msg = MsgBox("Are u old as 21 to join", MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            MsgBox("You can join")
        ElseIf msg = MsgBoxResult.No Then
            MsgBox("You can't join")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As MsgBoxResult
        a = MsgBox("Are YOU sure", MsgBoxStyle.AbortRetryIgnore)
        If a = MsgBoxResult.Yes Then
            MsgBox("OK")
        ElseIf a = MsgBoxResult.no Then
            MsgBox("Try again")
        ElseIf a = msgboxresult.cancel Then
            MsgBox("LOL")
        End If
    End Sub
End Class