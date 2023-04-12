Imports System.Data.SqlClient
Public Class KelolaTransaksiForm

    Public Sub BuatTabel() 'Membuat tabel di DataGridView1
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("tipeResep", "Tipe Resep")
        DataGridView1.Columns.Add("nomorTransaksi", "No Transaksi")
        DataGridView1.Columns.Add("tanggalResep", "Tanggal Resep")
        DataGridView1.Columns.Add("namaPasien", "nama Pasien")
        DataGridView1.Columns.Add("namaDokter", "Nama Dokter")
        DataGridView1.Columns.Add("namaObat", "Nama Obat")
        DataGridView1.Columns.Add("harga", "Harga")
        DataGridView1.Columns.Add("quantity", "Quantity")
    End Sub

    Public Sub ComboBoxNomorResep() 'Menampilkan daftar Member
        Call Koneksi()
        cmd = New SqlCommand("SELECT Id_Resep, No_Resep FROM Tbl_Resep", conn)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader)
        NoResepComboBox.DataSource = dt
        NoResepComboBox.ValueMember = "Id_Resep"
        NoResepComboBox.DisplayMember = "No_Resep"
        cmd.Dispose()
    End Sub

    Public Sub ComboBoxNamaObat() 'Menampilkan daftar Member
        Call Koneksi()
        cmd = New SqlCommand("SELECT Id_Obat, Nama_Obat FROM Tbl_Obat", conn)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader)
        NamaObatComboBox.DataSource = dt
        NamaObatComboBox.ValueMember = "Id_Obat"
        NamaObatComboBox.DisplayMember = "Nama_Obat"
        cmd.Dispose()
    End Sub

    Public Sub LoadData()
        Call BuatTabel()
        Call ComboBoxNomorResep()
        Call ComboBoxNamaObat()
    End Sub

    Private Sub KelolaTransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        TipeResepComboBox.SelectedIndex = 0
        NoResepComboBox.SelectedIndex = 0
        NamaObatComboBox.SelectedIndex = 0
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ((TipeResepComboBox.SelectedItem.ToString() = "Non-Resep") And (TextBox6.Text = "")) Or
            ((TipeResepComboBox.SelectedItem.ToString() = "Ber-Resep") And (NoResepComboBox.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "")) Then

            'Jika data kosong
            MsgBox("Data tidak boleh kosong!")

        Else 'Jika data tidak kosong

            'Lakukan pengulangan (for) untuk mengecek apakah nomor transaksi sudah ada
            Dim test As Boolean = False
            For Each row In DataGridView1.Rows
                If NamaObatComboBox.SelectedItem.ToString = row.Cells("namaObat").Value Then
                    test = True
                    Exit For
                End If
            Next

            If test = False Then 'Jika menu belum dimasukkan

                'Ambil data carbo, protein, dan price sesuai menu yang dipilih
                'Dim qty As Integer = Convert.ToInt32(TextBox2.Text)
                'Dim carbo, protein, price As New Integer
                'Dim read As New SqlCommand("SELECT * FROM MsMenu WHERE MenuID = @MenuID", conn)
                'read.Parameters.Add(New SqlParameter With {.ParameterName = "@MenuID", .Value = menuID})
                'dr = read.ExecuteReader
                'dr.Read()
                'If dr.HasRows Then
                '    carbo = dr!Carbo
                '    protein = dr!Protein
                '    price = dr!Price
                'End If
                'dr.Close()
                'read.Dispose()

                'Tambahkan menu ke DataGridView2
                DataGridView1.Rows.Add(New String() {TipeResepComboBox.Text, NoResepComboBox.Text, DateTimePicker1.Value, TextBox2.Text, TextBox3.Text, NamaObatComboBox.SelectedItem.ToString, TextBox5.Text, TextBox6.Text})

                'Dim totalCarbo As Integer
                'Dim totalProtein As Integer
                'Dim totalPrice As Integer

                'Lakukan pengulangan (for) untuk menjumlahkan TotalCarbo, TotalProtein, dan TotalPrice dari menu yang sudah ditambahkan
                'For j As Integer = 0 To DataGridView1.Rows.Count - 1
                '    totalCarbo += DataGridView1.Rows(j).Cells(2).Value
                '    totalProtein += DataGridView1.Rows(j).Cells(3).Value
                '    totalPrice += DataGridView1.Rows(j).Cells(5).Value
                'Next

                'Tampilkan datanya ke label
                'carboLabel.Text = totalCarbo.ToString()
                'proteinLabel.Text = totalProtein.ToString()
                'priceLabel.Text = String.Format("{0:n}", totalPrice) 'Format khusus agar jumlah uang lebih mudah dibaca

                'TextBox1.Text = ""
                'TextBox2.Text = ""
                'PictureBox1.Image = Nothing

            Else 'Jika resep sudah dimasukkan, tambahkan jumlah 'Qty' nya

                'Ambil posisi atau index resep yang sudah dimasukkan
                Dim rowIndex As Integer = -1
                For Each rows In DataGridView1.Rows
                    If rows.Cells("namaObat").Value.ToString.Equals(NamaObatComboBox.SelectedItem.ToString) Then
                        rowIndex = rows.Index
                        Exit For
                    End If
                Next

                'Ambil data carbo, protein, dan price sesuai menu yang dipilih
                'Dim qty As Integer = DataGridView1.Rows(rowIndex).Cells("quantity").Value + Convert.ToInt32(TextBox6.Text)
                Dim carbo, protein, price As New Integer
                'Dim read As New SqlCommand("SELECT * FROM MsMenu WHERE MenuID = @MenuID", conn)
                'read.Parameters.Add(New SqlParameter With {.ParameterName = "@MenuID", .Value = menuID})
                'dr = read.ExecuteReader
                'dr.Read()
                'If dr.HasRows Then
                '    'carbo = dr!Carbo
                '    'protein = dr!Protein
                price = DataGridView1.Rows(0).Cells("harga").Value
                'End If
                'dr.Close()
                'read.Dispose()

                'Hapus data yang duplikat, lalu ganti dengan yang baru
                DataGridView1.Rows(rowIndex).Selected = True
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
                DataGridView1.Rows.Add(New String() {TipeResepComboBox.Text, NoResepComboBox.Text, DateTimePicker1.Value, TextBox2.Text, TextBox3.Text, NamaObatComboBox.SelectedItem.ToString, TextBox5.Text, TextBox6.Text})

                Dim totalCarbo As Integer
                Dim totalProtein As Integer
                Dim totalPrice As Integer

                'Lakukan pengulangan (for) untuk menjumlahkan TotalPrice dari resep yang sudah ditambahkan
                For j As Integer = 0 To DataGridView1.Rows.Count - 1
                    totalPrice += DataGridView1.Rows(j).Cells("harga").Value
                Next

                'Tampilkan datanya ke label
                'carboLabel.Text = totalCarbo.ToString()
                'proteinLabel.Text = totalProtein.ToString()
                totalBayarLabel.Text = String.Format("{0:n}", totalPrice) 'Format khusus agar jumlah uang lebih mudah dibaca

                MsgBox("Jumlah resep sudah berubah")

                'TextBox1.Text = ""
                'TextBox2.Text = ""
                'PictureBox1.Image = Nothing

            End If

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'Dim result As DialogResult = MessageBox.Show("Semua data sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo)

        'If result = DialogResult.Yes Then

        '    'Validasi jika data kosong
        '    If DataGridView1.Rows.Count <= 1 Or DataGridView1.Rows(0).Cells(0).Value = "" Or ComboBox1.SelectedIndex <= -1 Then

        '        MsgBox("Anda belum memilih menu")

        '    Else

        '        'Call GenerateOrderHeaderID()
        '        Call Koneksi()

        '        'Masukkan data ke tabel OrderHeader
        '        Dim insertOrderHeader As New SqlCommand("INSERT INTO OrderHeader VALUES (@NomorTransaksi, @TanggalTransaksi, @TotalBayar, @IdUser, @IdObat, @IdResep)", conn)
        '        insertOrderHeader.Parameters.Add(New SqlParameter With {.ParameterName = "@NomorTransaksi", .Value = TextBox1.Text})
        '        insertOrderHeader.Parameters.Add(New SqlParameter With {.ParameterName = "@TanggalTransaksi", .Value = DateTimePicker1.Value})
        '        insertOrderHeader.Parameters.Add(New SqlParameter With {.ParameterName = "@TotalBayar", .Value = totalBayarLabel.Text})
        '        insertOrderHeader.Parameters.Add(New SqlParameter With {.ParameterName = "@IdUser", .Value = thisDate})
        '        insertOrderHeader.Parameters.Add(New SqlParameter With {.ParameterName = "@IdObat", .Value = ""})
        '        insertOrderHeader.Parameters.Add(New SqlParameter With {.ParameterName = "@IdResep", .Value = ""})
        '        insertOrderHeader.ExecuteNonQuery()
        '        insertOrderHeader.Dispose()

        '        Dim name As String
        '        Dim menuID As Integer
        '        Dim qty As Integer
        '        Dim totalCarbo As Integer
        '        Dim totalProtein As Integer
        '        Dim totalPrice As Integer

        '        'Lakukan pengulangan (for) untuk memasukkan semua baris yang ada pada DataGridView2 ke database
        '        For row As Integer = 0 To DataGridView2.Rows.Count - 2

        '            name = DataGridView2.Rows(row).Cells(0).Value
        '            qty = DataGridView2.Rows(row).Cells(1).Value
        '            totalCarbo = DataGridView2.Rows(row).Cells(2).Value
        '            totalProtein = DataGridView2.Rows(row).Cells(3).Value
        '            totalPrice = DataGridView2.Rows(row).Cells(5).Value

        '            'Mengambil MenuID berdasarkan nama yang ada di TextBox1
        '            Dim read As New SqlCommand("SELECT * FROM MsMenu WHERE Name = @Name", conn)
        '            read.Parameters.Add(New SqlParameter With {.ParameterName = "@Name", .Value = name})
        '            dr = read.ExecuteReader
        '            dr.Read()
        '            If dr.HasRows Then
        '                menuID = dr!MenuID
        '            End If
        '            dr.Close()
        '            read.Dispose()

        '            'Memasukkan data ke tabel OrderDetail
        '            Dim insert As New SqlCommand("INSERT INTO OrderDetail VALUES (@OrderHeaderID, @MenuID, @Qty, @TotalPrice, @TotalCarbo, @TotalProtein, @Status)", conn)
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@OrderHeaderID", .Value = orderHeaderID})
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@MenuID", .Value = menuID})
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Qty", .Value = qty})
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@TotalPrice", .Value = totalPrice})
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@TotalCarbo", .Value = totalCarbo})
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@TotalProtein", .Value = totalProtein})
        '            insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Status", .Value = "pending"})
        '            insert.ExecuteNonQuery()
        '            insert.Dispose()

        '        Next

        '        MsgBox("Order berhasil")
        '        LoadData()

        '    End If

        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipeResepComboBox.SelectedIndexChanged
        If (TipeResepComboBox.SelectedItem.ToString() = "Non-Resep") Then
            NoResepComboBox.Enabled = False
            DateTimePicker1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox5.Enabled = False
        Else
            NoResepComboBox.Enabled = True
            DateTimePicker1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            NamaObatComboBox.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
        End If
    End Sub

    Private Sub NoResepComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NoResepComboBox.SelectedIndexChanged
        Dim noResep As String = NoResepComboBox.SelectedItem.ToString()
        Call Koneksi()
        cmd = New SqlCommand("SELECT * FROM Tbl_Resep WHERE No_Resep = '" & noResep & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then

            'Mengambil data
            Dim tanggalResep As Date = dr!Tgl_Resep
            Dim idUser As String = dr!Id_User
            Dim namaUser As String = dr!Nama_User

            DateTimePicker1.Value = tanggalResep

            dr.Close()
            cmd.Dispose()

            'Masukkan data ke Tbl_Log
            'Dim insert As New SqlCommand("INSERT INTO Tbl_Log (aktifitas, Id_User) VALUES (@Aktifitas, @Id_User)", conn)
            'Dim insert As New SqlCommand("INSERT INTO Tbl_Log VALUES (@Waktu, @Aktifitas, @Id_User)", conn)
            'insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Waktu", .Value = DateTime.Now})
            'insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Aktifitas", .Value = "Login"})
            'insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Id_User", .Value = idUser})
            'insert.ExecuteNonQuery()
            'insert.Dispose()

        End If
    End Sub
End Class