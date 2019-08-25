<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class billing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billing))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Riki_da_icecreamDataSet = New Icecream_proj.riki_da_icecreamDataSet()
        Me.ViewTableAdapter = New Icecream_proj.riki_da_icecreamDataSetTableAdapters.ViewTableAdapter()
        Me.ViewTableAdapter1 = New Icecream_proj.riki_da_icecreamDataSetTableAdapters.ViewTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Riki_da_icecreamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(38, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 3, 60, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 638)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lavender
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(222, 549)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 52)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(33, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Quantity             :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(30, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Flavour                :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(33, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Type                    :"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.PeachPuff
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(222, 163)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(376, 30)
        Me.TextBox3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contact Number :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Customer Name :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(222, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 30)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(222, 363)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 30)
        Me.TextBox2.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lavender
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(222, 434)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(234, 52)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(509, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "-"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(454, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(222, 296)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(322, 33)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.Text = "--Select--"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 25
        Me.ComboBox1.Location = New System.Drawing.Point(222, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(322, 33)
        Me.ComboBox1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Lavender
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1030, 24)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(182, 54)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Admin"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lavender
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1569, 867)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 52)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Print Bill"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(965, 105)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(392, 713)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(1330, 24)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(183, 54)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "SIGN OUT"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGreen
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(12, 839)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(230, 46)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Change Database File"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(260, 852)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(792, 22)
        Me.TextBox4.TabIndex = 18
        '
        'ViewBindingSource
        '
        Me.ViewBindingSource.DataMember = "View"
        Me.ViewBindingSource.DataSource = Me.Riki_da_icecreamDataSet
        '
        'Riki_da_icecreamDataSet
        '
        Me.Riki_da_icecreamDataSet.DataSetName = "riki_da_icecreamDataSet"
        Me.Riki_da_icecreamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewTableAdapter
        '
        Me.ViewTableAdapter.ClearBeforeFill = True
        '
        'ViewTableAdapter1
        '
        Me.ViewTableAdapter1.ClearBeforeFill = True
        '
        'billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1575, 931)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "billing"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILLING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Riki_da_icecreamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Riki_da_icecreamDataSet As riki_da_icecreamDataSet
    Friend WithEvents ViewBindingSource As BindingSource
    Friend WithEvents ViewTableAdapter As riki_da_icecreamDataSetTableAdapters.ViewTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ViewTableAdapter1 As riki_da_icecreamDataSetTableAdapters.ViewTableAdapter
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox4 As TextBox
End Class
