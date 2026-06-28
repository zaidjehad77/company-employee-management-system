Public Class Form4
    Public Sub SetTextBoxValue(value As String)

    End Sub

    Public Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub SetLabelValues(text1 As String, text2 As String, text3 As String, text4 As Date, text5 As Date)
        Label1.Text = text1
        Label2.Text = text2
        Label3.Text = text3
        Label4.Text = text4
        Label11.Text = text5

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
