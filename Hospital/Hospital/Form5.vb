Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DomainUpDown1.Text = "2020001" Then
            Label1.Text = "Ghazal Almidana"
            Label3.Text = "Manager, IT"
            Label4.Text = "IT Department"
        ElseIf DomainUpDown1.Text = "2110169" Then
            Label1.Text = "Tala Badwan"
            Label3.Text = "Manager"
            Label4.Text = "English Department"
        ElseIf DomainUpDown1.Text = "2020028" Then
            Label1.Text = "Rahaf Tobah"
            Label3.Text = "Supervisor"
            Label4.Text = "English Department"
        ElseIf DomainUpDown1.Text = "2110100" Then
            Label1.Text = "Christina abu sada"
            Label3.Text = "Employee"
            Label4.Text = "Finance Department"
        ElseIf DomainUpDown1.Text = "2110302" Then
            Label1.Text = "Sima abd"
            Label3.Text = "Employee"
            Label4.Text = "HR Department"
        ElseIf DomainUpDown1.Text = "2120222" Then
            Label1.Text = "Sarah Ahmed"
            Label3.Text = "Supervisor"
            Label4.Text = "Marketing Department"
        ElseIf DomainUpDown1.Text = "2020099" Then
            Label1.Text = "Ttina M"
            Label3.Text = "Employee"
            Label4.Text = "Marketing Department"
        Else
            MessageBox.Show("You need to choose Employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub
End Class

