Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numEmployees As Integer = TextBox1.Text
        Dim salaryPerEmployee As Decimal = TextBox2.Text
        Dim totalSalaries As Decimal = 0

        ' Use a For loop to calculate total salary expenses
        For i As Integer = 1 To numEmployees
            totalSalaries += salaryPerEmployee
        Next

        ' Display the total salary expenses
        Label4.Text = totalSalaries.ToString("F2")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class