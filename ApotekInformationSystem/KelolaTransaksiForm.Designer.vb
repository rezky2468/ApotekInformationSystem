<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaTransaksiForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.totalBayarLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.kembaliLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.uangTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TipeResepComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NamaObatComboBox = New System.Windows.Forms.ComboBox()
        Me.NoResepComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type Resep"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Resep"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tgl Resep"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Pasien"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(412, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(412, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nama Dokter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(412, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nama Obat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(412, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(412, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Quantity"
        '
        'totalBayarLabel
        '
        Me.totalBayarLabel.BackColor = System.Drawing.SystemColors.Info
        Me.totalBayarLabel.Location = New System.Drawing.Point(96, 388)
        Me.totalBayarLabel.Name = "totalBayarLabel"
        Me.totalBayarLabel.Size = New System.Drawing.Size(37, 13)
        Me.totalBayarLabel.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 428)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Kembali"
        '
        'kembaliLabel
        '
        Me.kembaliLabel.BackColor = System.Drawing.SystemColors.Info
        Me.kembaliLabel.Location = New System.Drawing.Point(96, 428)
        Me.kembaliLabel.Name = "kembaliLabel"
        Me.kembaliLabel.Size = New System.Drawing.Size(31, 13)
        Me.kembaliLabel.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Tambahkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(488, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Kosongkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Bayar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(501, 404)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(582, 404)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(488, 61)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 20)
        Me.TextBox3.TabIndex = 22
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(488, 113)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(169, 20)
        Me.TextBox5.TabIndex = 24
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(488, 139)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(169, 20)
        Me.TextBox6.TabIndex = 25
        '
        'uangTextBox
        '
        Me.uangTextBox.Location = New System.Drawing.Point(93, 404)
        Me.uangTextBox.Name = "uangTextBox"
        Me.uangTextBox.Size = New System.Drawing.Size(146, 20)
        Me.uangTextBox.TabIndex = 26
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1175, 189)
        Me.DataGridView1.TabIndex = 27
        '
        'TipeResepComboBox
        '
        Me.TipeResepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipeResepComboBox.FormattingEnabled = True
        Me.TipeResepComboBox.Items.AddRange(New Object() {"Ber-Resep", "Non-Resep"})
        Me.TipeResepComboBox.Location = New System.Drawing.Point(88, 60)
        Me.TipeResepComboBox.Name = "TipeResepComboBox"
        Me.TipeResepComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipeResepComboBox.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, 113)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 29
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(457, 35)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 30
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 388)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Total Bayar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1199, 25)
        Me.ToolStrip1.TabIndex = 32
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'NamaObatComboBox
        '
        Me.NamaObatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NamaObatComboBox.FormattingEnabled = True
        Me.NamaObatComboBox.Location = New System.Drawing.Point(488, 86)
        Me.NamaObatComboBox.Name = "NamaObatComboBox"
        Me.NamaObatComboBox.Size = New System.Drawing.Size(169, 21)
        Me.NamaObatComboBox.TabIndex = 33
        '
        'NoResepComboBox
        '
        Me.NoResepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NoResepComboBox.FormattingEnabled = True
        Me.NoResepComboBox.Location = New System.Drawing.Point(88, 87)
        Me.NoResepComboBox.Name = "NoResepComboBox"
        Me.NoResepComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NoResepComboBox.TabIndex = 34
        '
        'KelolaTransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 474)
        Me.Controls.Add(Me.NoResepComboBox)
        Me.Controls.Add(Me.NamaObatComboBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TipeResepComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.uangTextBox)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kembaliLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.totalBayarLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KelolaTransaksiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KelolaTransaksiForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents totalBayarLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents kembaliLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents uangTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TipeResepComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents NamaObatComboBox As ComboBox
    Friend WithEvents NoResepComboBox As ComboBox
End Class
