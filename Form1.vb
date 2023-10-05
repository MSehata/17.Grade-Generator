Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCheckGrade_Click(sender As Object, e As EventArgs) Handles btnCheckGrade.Click
        Dim marks As Integer, grade As Char
        marks = Val(txtMarks.Text)

        If marks >= 80 Then
            grade = "A"
            txtGrade.Text = grade
        ElseIf marks >= 60 And marks < 80 Then
            grade = "B"
            txtGrade.Text = grade
        ElseIf marks >= 50 And marks < 60 Then
            grade = "C"
            txtGrade.Text = grade
        Else
            grade = "D"
            txtGrade.Text = grade
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub
End Class
