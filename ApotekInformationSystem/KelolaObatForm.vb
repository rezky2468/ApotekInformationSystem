Imports System.Data.SqlClient
Public Class KelolaObatForm

    Public Sub LoadData()

        Call Koneksi()
        da = New SqlDataAdapter("SELECT * FROM Tbl_Obat", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Obat")
        DataGridView1.DataSource = (ds.Tables("Tbl_Obat"))

    End Sub

    Private Sub KelolaObatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Validasi agar tidak terjadi error ketika DataGridView diklik
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then

            If Not DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Length = Nothing Then

                ' Assuming you have a DateTimePicker control named dateTimePicker1
                Dim dateString As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                Dim dateValue As DateTime
                If DateTime.TryParse(dateString, dateValue) Then
                    DateTimePicker1.Value = dateValue
                End If

                'Tampilkan data ketika DataGridView diklik
                Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
                TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

            End If

        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data tidak boleh kosong!")
        Else

            Dim result As DialogResult = MessageBox.Show("Semua data sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Call Koneksi()
                Dim insert As New SqlCommand("INSERT INTO Tbl_Obat VALUES (@KodeObat, @NamaObat, @Expired, @Jumlah, @Harga)", conn)
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@KodeObat", .Value = TextBox1.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@NamaObat", .Value = TextBox2.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Expired", .Value = DateTimePicker1.Value})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Jumlah", .Value = TextBox3.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Harga", .Value = TextBox4.Text})
                insert.ExecuteNonQuery()
                insert.Dispose()

                MsgBox("Insert data berhasil!")
                LoadData()

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data tidak boleh kosong!")
        Else

            Dim result As DialogResult = MessageBox.Show("Semua data sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Call Koneksi()
                Dim update As New SqlCommand("UPDATE Tbl_Obat SET Kode_Obat = @KodeObat, Nama_Obat = @NamaObat, Expired_Date = @Expired, Jumlah = @Jumlah, Harga = @Harga WHERE Id_Obat = @IdObat", conn)
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@IdObat", .Value = Label8.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@KodeObat", .Value = TextBox1.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@NamaObat", .Value = TextBox2.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Expired", .Value = DateTimePicker1.Value.ToString("dd/MM/yyyy")})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Jumlah", .Value = TextBox3.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Harga", .Value = TextBox4.Text})
                update.ExecuteNonQuery()
                update.Dispose()

                MsgBox("Update data berhasil!")
                LoadData()

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Pilih data yang ingin dihapus!")
        Else

            Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Call Koneksi()
                Dim delete As New SqlCommand("DELETE Tbl_Obat WHERE Id_Obat = @IdObat", conn)
                delete.Parameters.Add(New SqlParameter With {.ParameterName = "@IdObat", .Value = Label8.Text})
                delete.ExecuteNonQuery()
                delete.Dispose()

                MsgBox("Delete data berhasil!")
                LoadData()

            End If
        End If
    End Sub
End Class