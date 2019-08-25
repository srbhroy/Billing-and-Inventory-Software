Imports System.Math
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class billing
    Public Shared count As UInteger = 0
    Public Shared curr_stock As Integer = 0
    Public path As String = "|DataDirectory|\icecream_db.mdf;"
    Public conn_string As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path & "Integrated Security=True;Connect Timeout=30"
    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.flg = False Then
            Button6.Visible = False
            Button7.Visible = False
            TextBox4.Visible = False
        Else
            Button6.Visible = True
            Button7.Visible = True
            TextBox4.Visible = True
        End If
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("ITEM", 125)
        ListView1.Columns.Add("FLAVOUR", 125)
        ListView1.Columns.Add("QUANTITY", 125)
        ListView1.Columns.Add("PRICE", 125)
        ListView1.Columns.Add("TOT. AMT", 125)
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        TextBox2.Enabled = False
        ComboBox2.Enabled = False
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim limit As UInteger
        Dim mysqlconn As New SqlConnection
        mysqlconn.ConnectionString = conn_string
        Try
            mysqlconn.Open()
            Dim query As String
            query = "Select * FROM main_stock WHERE type ='" & ComboBox1.Text & "' AND flavour ='" & ComboBox2.Text & "'"
            Dim command As New SqlCommand(query, mysqlconn)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            While reader.Read
                limit = reader.GetInt32(3)
            End While
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        If (Val(TextBox2.Text) < limit) Then
            TextBox2.Text = Val(TextBox2.Text) + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox2.Text = "0" Or TextBox2.Text = "") Then
            TextBox2.Text = TextBox2.Text
        Else
            TextBox2.Text = Val(TextBox2.Text) - 1
        End If
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        'TODO: This line of code loads data into the 'Riki_da_icecreamDataSet.View' table. You can move, or remove it, as needed.
        Dim mysqlconn As New SqlConnection
        ComboBox1.Items.Clear()
        Dim sname As String
        mysqlconn.ConnectionString = conn_string
        Try
            mysqlconn.Open()
            Dim query As String
            query = "SELECT DISTINCT type FROM main_stock"
            Dim command As New SqlCommand(query, mysqlconn)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader()
            While reader.Read
                sname = reader.GetString(0)
                ComboBox1.Items.Add(sname)
            End While
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        TextBox2.Enabled = False
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox2.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim limit As UInteger
        Dim mysqlconn As New SqlConnection
        mysqlconn.ConnectionString = conn_string
        mysqlconn.Open()
        Dim query As String
        query = "SELECT * FROM main_stock WHERE type ='" & ComboBox1.Text & "' AND flavour ='" & ComboBox2.Text & "'"
        Dim command As New SqlCommand(query, mysqlconn)
        Dim reader As SqlDataReader
        reader = command.ExecuteReader
        While reader.Read
            limit = reader.GetInt32(3)
            curr_stock = reader.GetInt32(3)
        End While
        If (Val(TextBox2.Text) > limit) Then
            TextBox2.Text = "0"
        End If
        If (Val(TextBox2.Text) > 0) Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        Dim item_selected As String = ComboBox1.Text
        Dim mysqlconn As New SqlConnection
        Dim sname As String
        mysqlconn.ConnectionString = conn_string
        Try
            mysqlconn.Open()
            Dim query As String
            query = "SELECT * FROM main_stock WHERE type ='" & ComboBox1.Text & "' AND stock > '0'"
            Dim command As New SqlCommand(query, mysqlconn)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            While reader.Read
                sname = reader.GetString(2)
                ComboBox2.Items.Add(sname)
            End While
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mysqlconn As New SqlConnection
        Dim sname As Double
        mysqlconn.ConnectionString = conn_string
        mysqlconn.Open()
        Dim query As String
        query = "SELECT * FROM main_stock WHERE type ='" & ComboBox1.Text & "' AND flavour = '" & ComboBox2.Text & "' "
        Dim command As New SqlCommand(query, mysqlconn)
        Dim reader As SqlDataReader
        reader = command.ExecuteReader
        While reader.Read
            sname = reader.GetDouble(4)
        End While
        Dim item As ListViewItem
        Dim st As String() = New String(5) {}
        st(0) = ComboBox1.Text
        st(1) = ComboBox2.Text
        st(2) = TextBox2.Text
        st(3) = sname.ToString
        st(4) = (Val(TextBox2.Text) * sname).ToString
        item = New ListViewItem(st)

        ListView1.Items.Add(item)
        mysqlconn.Close()
        Try
            mysqlconn.Open()
            query = "UPDATE main_stock SET stock='" & curr_stock - Val(TextBox2.Text) & "' WHERE type ='" & ComboBox1.Text & "' AND flavour = '" & ComboBox2.Text & "' "
            Dim comm As New SqlCommand(query, mysqlconn)
            comm.ExecuteNonQuery()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        ComboBox1.Text = "--SELECT--"
        ComboBox2.Text = "--SELECT--"
        TextBox2.Text = "0"
        ComboBox2.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintDialog1.Document = PrintDocument1
        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        With PrintDocument1
            .PrinterSettings.DefaultPageSettings.Landscape = False
            .Print()
        End With
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("ITEM", 100)
        ListView1.Columns.Add("FLAVOUR", 100)
        ListView1.Columns.Add("QUANTITY", 100)
        ListView1.Columns.Add("PRICE", 100)
        ListView1.Columns.Add("TOT. AMT", 100)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim h As Integer = 0
        Dim tot As Double = 0.0
        Dim tot1 As Double = 0.0
        Dim p As New Pen(Brushes.Black, 10)
        h = 50
        e.Graphics.DrawString("                 ICE-CREAM PARLOUR", New Drawing.Font("Segoe Print", 20), Brushes.Black, 50, h)
        h += 50
        e.Graphics.DrawString("                                                  RECEIPT", New Drawing.Font("Tahoma", 15), Brushes.Black, 50, h)
        h += 80
        e.Graphics.DrawLine(p, 50, 130, 800, 130)
        e.Graphics.DrawString("Name : " & TextBox1.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 50, h)
        h += 30
        e.Graphics.DrawString("Contact Number : " & TextBox3.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 50, h)
        e.Graphics.DrawString("Date : " & Now, New Drawing.Font("Times New Roman", 12), Brushes.Black, 600, h)
        h += 100
        e.Graphics.DrawString(Environment.NewLine, New Drawing.Font("Times New Roman", 12), Brushes.Black, 50, h + 100)
        e.Graphics.DrawLine(p, 50, 270, 800, 270)
        h += 50
        e.Graphics.DrawString("Item                           Flavour                                Quantity                   Price", New Drawing.Font("Palatino Linotype", 15), Brushes.Black, 50, h)
        h += 50
        For Each itm As ListViewItem In ListView1.Items
            e.Graphics.DrawString(itm.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 50, h)
            e.Graphics.DrawString(itm.SubItems(1).Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 225, h)
            e.Graphics.DrawString(itm.SubItems(2).Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 505, h)
            e.Graphics.DrawString(itm.SubItems(3).Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 675, h)
            tot += Val(itm.SubItems(2).Text) * Val(itm.SubItems(3).Text)
            h += 30
        Next
        e.Graphics.DrawLine(p, 50, 1000, 800, 1000)
        e.Graphics.DrawString("Thank You. Please Visit Again.", New Drawing.Font("Times New Roman", 12), Brushes.Black, 50, 1030)
        e.Graphics.DrawString("TOTAL    :", New Drawing.Font("Times New Roman", 12), Brushes.Black, 505, 1030)
        e.Graphics.DrawString(tot, New Drawing.Font("Times New Roman", 12), Brushes.Black, 600, 1030)
        e.Graphics.DrawString("TAX(5 %) :", New Drawing.Font("Times New Roman", 12), Brushes.Black, 505, 1050)
        tot1 = tot
        tot1 *= 1.05
        e.Graphics.DrawString(tot1, New Drawing.Font("Times New Roman", 12), Brushes.Black, 600, 1050)
        e.Graphics.DrawString("Round Off :", New Drawing.Font("Times New Roman", 12), Brushes.Black, 505, 1070)
        tot = tot1
        Round(tot1)
        If (Abs(tot - Round(tot1)) > 0.4) Then
            e.Graphics.DrawString("+" & Abs(tot - Round(tot1)), New Drawing.Font("Times New Roman", 12), Brushes.Black, 600, 1070)
        Else
            e.Graphics.DrawString(Round(tot1) - tot, New Drawing.Font("Times New Roman", 12), Brushes.Black, 600, 1070)
        End If
        e.Graphics.DrawString("BILLED AMOUNT : " & Round(tot1), New Drawing.Font("Times New Roman", 10), Brushes.Black, 505, 1090)
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mysqlconn As New SqlConnection
        Dim stock As UInteger
        Dim query As String
        mysqlconn.ConnectionString = conn_string
        Try
            mysqlconn.Open()
            query = "SELECT * FROM main_stock WHERE type ='" & ListView1.SelectedItems.Item(0).SubItems(0).Text & "' AND flavour = '" & ListView1.SelectedItems.Item(0).SubItems(1).Text & "' "
            Dim command As New SqlCommand(query, mysqlconn)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader
            While reader.Read
                stock = reader.GetInt32(3)
            End While
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        mysqlconn.Close()
        Try
            mysqlconn.Open()
            For Each item As ListViewItem In ListView1.SelectedItems
                query = "UPDATE main_stock SET stock='" & stock + Val(item.SubItems(2).Text) & "' WHERE type ='" & item.SubItems(0).Text & "' AND flavour = '" & item.SubItems(1).Text & "' "
                Dim comm As New SqlCommand(query, mysqlconn)
                comm.ExecuteNonQuery()
                item.Remove()
            Next
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        mysqlconn.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        admin.Show()
        admin.TopMost = True
        admin.TopMost = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ListView1.Items.Count > 0 Then
            MsgBox("DELETE ALL ITEMS SELECTED.", MsgBoxStyle.Exclamation, "WARNING")
            Exit Sub
        End If
        If Application.OpenForms().OfType(Of admin).Any Then
            MsgBox("PLEASE CLOSE OTHER FORMS FIRST.", MsgBoxStyle.Exclamation, "WARNING")
        Else
            Login.flg = False
            Login.Show()
            Me.Close()
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
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox4.Text = OpenFileDialog1.FileName & ";"
            path = TextBox4.Text
            conn_string = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path & "Integrated Security=True;Connect Timeout=30"
        End If
    End Sub
End Class


