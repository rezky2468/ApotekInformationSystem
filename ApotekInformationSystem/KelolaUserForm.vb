Imports System.Data.SqlClient
Public Class KelolaUserForm

    Public Sub LoadData()

        Call Koneksi()
        da = New SqlDataAdapter("SELECT * FROM Tbl_User", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_User")
        DataGridView1.DataSource = (ds.Tables("Tbl_User"))

    End Sub

    Private Sub KelolaUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Validasi agar tidak terjadi error ketika DataGridView diklik
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then

            If Not DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Length = Nothing Then

                'Tampilkan data ketika DataGridView diklik
                Label9.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
                TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value

            End If

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Tampilkan data yang diketik di kolom pencarian (search)
        Call Koneksi()
        da = New SqlDataAdapter("SELECT * FROM Tbl_User WHERE Tipe_User LIKE '%" & TextBox1.Text & "%' OR Nama_User LIKE '%" & TextBox1.Text & "%' OR Alamat LIKE '%" & TextBox1.Text & "%' OR Telepon LIKE '%" & TextBox1.Text & "%' OR Username LIKE '%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_User")
        DataGridView1.DataSource = (ds.Tables("Tbl_User"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then

            MsgBox("Data tidak boleh kosong!")

        Else

            Dim result As DialogResult = MessageBox.Show("Semua data sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Call Koneksi()
                Dim insert As New SqlCommand("INSERT INTO Tbl_User VALUES (@TipeUser, @NamaUser, @Alamat, @Telepon, @Username, @Password)", conn)
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@TipeUser", .Value = ComboBox1.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@NamaUser", .Value = TextBox2.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Alamat", .Value = TextBox3.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Telepon", .Value = TextBox4.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Username", .Value = TextBox5.Text})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Password", .Value = TextBox6.Text})
                insert.ExecuteNonQuery()
                insert.Dispose()

                MsgBox("Insert data berhasil!")
                LoadData()

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox5.Text = "" Or Label9.Text = "" Or ComboBox1.Text = "" Then

            MsgBox("Data tidak boleh kosong!")

        Else

            Dim result As DialogResult = MessageBox.Show("Semua data sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Call Koneksi()
                Dim update As New SqlCommand("UPDATE Tbl_User SET Tipe_User = @TipeUser, Nama_user = @NamaUser, Alamat = @Alamat, Telepon = @Telepon, Username = @Username, Password = @Password WHERE Id_User = @IdUser", conn)
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@IdUser", .Value = Label9.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@TipeUser", .Value = ComboBox1.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@NamaUser", .Value = TextBox2.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Alamat", .Value = TextBox3.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Telepon", .Value = TextBox4.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Username", .Value = TextBox5.Text})
                update.Parameters.Add(New SqlParameter With {.ParameterName = "@Password", .Value = TextBox6.Text})
                update.ExecuteNonQuery()
                update.Dispose()

                MsgBox("Update data berhasil!")
                LoadData()

            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label9.Text = "" Then

            MsgBox("Data tidak boleh kosong!")

        Else

            Dim result As DialogResult = MessageBox.Show("Silahkan pilih data yang ingin dihapus!", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Call Koneksi()
                Dim delete As New SqlCommand("DELETE Tbl_User WHERE Id_User = @IdUser", conn)
                delete.Parameters.Add(New SqlParameter With {.ParameterName = "@IdUser", .Value = Label9.Text})
                delete.ExecuteNonQuery()
                delete.Dispose()

                MsgBox("Hapus data berhasil!")
                LoadData()

            End If

        End If
    End Sub
End Class