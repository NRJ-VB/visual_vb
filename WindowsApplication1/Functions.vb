Public Class Functions
    Private Sub Functions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim digits() As Integer = {1, 2, 3, 4}
        Dim result() As Integer = New Integer() {}
        For i = 0 To 3
            MsgBox("Original elements are", digits(i))
        Next
        result = xyz(digits)
        For i = 0 To 3
            MsgBox("Modified Elements are :{0}", result(i))
        Next
    End Sub
    Public Function xyz(ByRef myarray() As Integer) As Integer()
        Dim ret() As Integer = New Integer() {}
        For i = 0 To 3
            ret(i) = myarray(i) + 100
        Next
        Return ret
    End Function
End Class