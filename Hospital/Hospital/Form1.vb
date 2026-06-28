Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    ' Event handler for Button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the name is valid
        If IsValidName(TextBox1.Text) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
            ResetForm()
        Else
            MessageBox.Show("Invalid name. Please enter a name with letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TextBox1.Clear()
            TextBox1.Focus()
        End If

        ' Check if the Pass is valid


    End Sub


    ' Function to validate the name
    Private Function IsValidName(ByVal name As String) As Boolean
        ' Regex to match only letters (both uppercase and lowercase)
        Dim regex As New Regex("^[A-Za-z]+$")

        ' Check if the name matches the regex
        Return regex.IsMatch(name)
    End Function




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
    Private Sub ResetForm()
        TextBox1.Clear()
        TextBox1.Focus()
        Button1.Enabled = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
