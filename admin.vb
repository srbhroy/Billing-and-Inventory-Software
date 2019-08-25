Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class admin
    Private Sub refres()
        ListView1.Clear()
        ListView1.Columns.Add("PROD_ID", 100)
        ListView1.Columns.Add("ITEM", 100)
        ListView1.Columns.Add("FLAVOUR", 100)
        ListView1.Columns.Add("QUANTITY", 100)
        ListView1.Columns.Add("PRICE", 100)
        Dim mysqlconn As New SqlConnection
        Dim item As ListViewItem
        Dim st As String() = New String(5) {}
        mysqlconn.ConnectionString = billing.conn_string
        mysqlconn.Open()
        Dim query As String
        query = "SELECT * FROM main_stock"
        Dim command As New SqlCommand(query, mysqlconn)
        Dim reader As SqlDataReader
        reader = command.ExecuteReader
        While reader.Read
            st(0) = reader.GetString(0)
            st(1) = reader.GetString(1)
            st(2) = reader.GetString(2)
            st(3) = reader.GetInt32(3).ToString
            st(4) = reader.GetDouble(4).ToString
            item = New ListViewItem(st)
            ListView1.Items.Add(item)
        End While
        mysqlconn.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim item1 As ListViewItem = ListView1.FindItemWithText(TextBox5.Text)
        If TextBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Enter values STOCK AMOUNT / PROD_ID")
        ElseIf (item1 Is Nothing) Then
            MessageBox.Show("WRONG PRIMARY KEY : PROD_ID")
            TextBox5.Text = ""
            TextBox3.Text = ""
            TextBox3.Visible = False
            TextBox5.Visible = False
            Label4.Visible = False
            Label1.Visible = False
            Button3.Enabled = False
            Exit Sub
        Else
            Dim mysqlconn As New SqlConnection
            Dim stock As UInteger
            Dim query As String
            mysqlconn.ConnectionString = billing.conn_string
            mysqlconn.Open()
            query = "SELECT * FROM main_stock WHERE prod_id ='" & TextBox5.Text & "'"
            Dim command As New SqlCommand(query, mysqlconn)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            While reader.Read
                stock = reader.GetInt32(3)
            End While
            mysqlconn.Close()
            mysqlconn.Open()
            query = "UPDATE main_stock SET stock='" & stock + Val(TextBox3.Text) & "' WHERE prod_id ='" & TextBox5.Text & "'"
            Dim comm As New SqlCommand(query, mysqlconn)
            comm.ExecuteNonQuery()
            mysqlconn.Close()
            Call refres()
        End If
        TextBox3.Visible = False
        TextBox5.Visible = False
        Label4.Visible = False
        Label1.Visible = False
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim item1 As ListViewItem = ListView1.FindItemWithText(TextBox5.Text)
        If TextBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Enter values STOCK AMOUNT / PROD_ID")
        ElseIf (item1 Is Nothing) Then
            MessageBox.Show("WRONG PRIMARY KEY : PROD_ID")
            TextBox5.Text = ""
            TextBox3.Text = ""
            TextBox3.Visible = False
            TextBox5.Visible = False
            Label1.Visible = False
            Label4.Visible = False
            Button4.Enabled = False
            Exit Sub
        Else
            Dim mysqlconn As New SqlConnection
            Dim stock As UInteger
            Dim query As String
            mysqlconn.ConnectionString = billing.conn_string
            mysqlconn.Open()
            query = "SELECT * FROM main_stock WHERE prod_id ='" & TextBox5.Text & "'"
            Dim command As New SqlCommand(query, mysqlconn)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            While reader.Read
                stock = reader.GetInt32(3)
            End While
            mysqlconn.Close()
            If stock > 0 Then
                mysqlconn.Open()
                query = "UPDATE main_stock SET stock='" & stock - Val(TextBox3.Text) & "' WHERE prod_id ='" & TextBox5.Text & "'"
                Dim comm As New SqlCommand(query, mysqlconn)
                Dim res As DialogResult
                res = MsgBox("Are you sure you want to DELETE the selected Row?", MessageBoxButtons.YesNo)
                If res = Windows.Forms.DialogResult.Yes Then
                    comm.ExecuteNonQuery()
                    mysqlconn.Close()
                    Call refres()
                Else : Exit Sub
                End If
            Else
                MsgBox("Stock Empty")
            End If
            Call refres()
        End If
        TextBox3.Visible = False
        TextBox5.Visible = False
        Label1.Visible = False
        Label4.Visible = False
        Button4.Enabled = False
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        ListView1.View = View.Details
        ListView1.GridLines = True
        Call refres()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item1 As ListViewItem = ListView1.FindItemWithText(TextBox5.Text)

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Enter values PROD_ID / TYPE / FLAVOUR / PRICE")
        ElseIf (item1 IsNot Nothing) Then
            MessageBox.Show("DUPLICATE PRIMARY KEY : PROD_ID")
            TextBox5.Text = ""
            TextBox4.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox1.Text = ""
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Button1.Enabled = False
            Exit Sub
        Else
            Dim mysqlconn As New SqlConnection
            Dim query As String
            mysqlconn.ConnectionString = billing.conn_string
            mysqlconn.Open()
            If TextBox3.Text <= "0" Or TextBox3.Text = "" Then
                query = "INSERT INTO main_stock([prod_id],[type], [flavour], [price]) values ('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "')"
            Else
                query = "INSERT INTO main_stock([prod_id],[type], [flavour],[stock], [price]) values ('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & Val(TextBox3.Text) & "','" & Val(TextBox4.Text) & "')"
            End If
            Dim comm As New SqlCommand(query, mysqlconn)
            comm.ExecuteNonQuery()
            mysqlconn.Close()
            Call refres()
        End If
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item1 As ListViewItem = ListView1.FindItemWithText(TextBox5.Text)
        If TextBox5.Text = "" Then
            MsgBox("Please Enter value PROD_ID")
        ElseIf (item1 Is Nothing) Then
            MessageBox.Show("WRONG PRIMARY KEY : PROD_ID")
            TextBox5.Text = ""
            TextBox5.Visible = False
            Label1.Visible = False
            Button2.Enabled = False
            Exit Sub
        Else
            Dim mysqlconn As New SqlConnection
            Dim query As String
            mysqlconn.ConnectionString = billing.conn_string
            mysqlconn.Open()
            query = "DELETE FROM main_stock WHERE prod_id ='" & TextBox5.Text & "'"
            Dim comm As New SqlCommand(query, mysqlconn)
            Dim res As DialogResult
            res = MsgBox("Are you sure you want to DELETE the selected Row?", MessageBoxButtons.YesNo)
            If res = Windows.Forms.DialogResult.Yes Then
                comm.ExecuteNonQuery()
                mysqlconn.Close()
                Call refres()
            Else
                TextBox1.Visible = False
                Label1.Visible = False
                Button2.Enabled = False
                Exit Sub
            End If
        End If
        TextBox5.Visible = False
        Label1.Visible = False
        Button2.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim item1 As ListViewItem = ListView1.FindItemWithText(TextBox5.Text)
        If TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please Enter values PRICE / PROD_ID")
        ElseIf (item1 Is Nothing) Then
            MessageBox.Show("WRONG PRIMARY KEY : PROD_ID")
            TextBox5.Text = ""
            TextBox4.Text = ""
            TextBox4.Visible = False
            TextBox5.Visible = False
            Label1.Visible = False
            Label5.Visible = False
            Button5.Enabled = False
            Exit Sub
        Else
            Dim mysqlconn As New SqlConnection
            Dim query As String
            mysqlconn.ConnectionString = billing.conn_string
            mysqlconn.Open()
            query = "UPDATE main_stock SET price='" & Val(TextBox4.Text) & "' WHERE prod_id ='" & TextBox5.Text & "'"
            Dim comm As New SqlCommand(query, mysqlconn)
            comm.ExecuteNonQuery()
            mysqlconn.Close()
            Call refres()
        End If
        TextBox4.Visible = False
        TextBox5.Visible = False
        Label1.Visible = False
        Label5.Visible = False
        Button5.Enabled = False
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Button1.Enabled = True

            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox5.Visible = True
            Label1.Visible = True
            Button2.Enabled = True
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox1.Visible = False

            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Button1.Enabled = False

            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox3.Visible = True
            TextBox5.Visible = True
            Label1.Visible = True
            Label4.Visible = True
            Button3.Enabled = True

            TextBox2.Visible = False
            TextBox4.Visible = False

            TextBox1.Visible = False

            Label2.Visible = False
            Label3.Visible = False

            Label5.Visible = False
            Button1.Enabled = False
            Button2.Enabled = False

            Button4.Enabled = False
            Button5.Enabled = False
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox3.Visible = True
            TextBox5.Visible = True
            Label1.Visible = True
            Label4.Visible = True
            Button4.Enabled = True

            TextBox2.Visible = False
            TextBox4.Visible = False

            TextBox1.Visible = False

            Label2.Visible = False
            Label3.Visible = False

            Label5.Visible = False
            Button1.Enabled = False
            Button2.Enabled = False

            Button3.Enabled = False
            Button5.Enabled = False
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox4.Visible = True
            TextBox5.Visible = True
            Label1.Visible = True
            Label5.Visible = True
            Button5.Enabled = True

            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox1.Visible = False


            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False

            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False

        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class