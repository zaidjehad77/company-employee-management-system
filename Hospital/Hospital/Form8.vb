Public Class Form8
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "1234**" Then
            Dim form5 As New Form5()
            form5.Show()
            Me.Hide()
        ElseIf TextBox1.Text = "12345**" Then
            Dim form5 As New Form5()
            form5.Show()
            Me.Hide()
        End If
    End Sub
End Class