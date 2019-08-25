Imports System.Math
Public Class Login
    Public Shared flg As Boolean = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.DimGray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "user" And TextBox2.Text = "12345" Then
            billing.Show()
            Me.Close()
        ElseIf TextBox1.Text = "admin" And TextBox2.Text = "12345" Then
            flg = 1
            billing.Show()
            Me.Close()
        Else
            MsgBox("Incorrect UserID / Password.", MsgBoxStyle.Exclamation, "WARNING")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
