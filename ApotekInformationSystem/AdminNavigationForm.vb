Imports System.Data.SqlClient
Public Class AdminNavigationForm

    Public Sub KelolaUser()
        KelolaUserForm.TopLevel = False
        KelolaUserForm.FormBorderStyle = FormBorderStyle.None
        KelolaUserForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(KelolaUserForm)
        KelolaUserForm.Show()
    End Sub
    Public Sub KelolaObat()
        KelolaObatForm.TopLevel = False
        KelolaObatForm.FormBorderStyle = FormBorderStyle.None
        KelolaObatForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(KelolaObatForm)
        KelolaObatForm.Show()
    End Sub

    Public Sub KelolaLaporan()
        KelolaLaporanForm.TopLevel = False
        KelolaLaporanForm.FormBorderStyle = FormBorderStyle.None
        KelolaLaporanForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(KelolaLaporanForm)
        KelolaLaporanForm.Show()
    End Sub

    Public Sub KelolaResep()
        KelolaResepForm.TopLevel = False
        KelolaResepForm.FormBorderStyle = FormBorderStyle.None
        KelolaResepForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(KelolaResepForm)
        KelolaResepForm.Show()
    End Sub

    Public Sub KelolaTransaksi()
        KelolaTransaksiForm.TopLevel = False
        KelolaTransaksiForm.FormBorderStyle = FormBorderStyle.None
        KelolaTransaksiForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(KelolaTransaksiForm)
        KelolaTransaksiForm.Show()
    End Sub

    Public Sub LoadData()

        Call Koneksi()
        'da = New SqlDataAdapter("SELECT Tbl_Log.Id_Log, Tbl_User.Username, CONVERT(DATETIME, Tbl_Log.Waktu, 120) AS Timestamp, Tbl_Log.Aktifitas FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User", conn)
        da = New SqlDataAdapter("SELECT Tbl_Log.Id_Log, Tbl_User.Username, Tbl_Log.Waktu, Tbl_Log.Aktifitas 
                            FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Log")
        DataGridView1.DataSource = (ds.Tables("Tbl_Log"))

    End Sub

    Private Sub AdminNavigationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'KelolaUserForm.Show()
        Call KelolaUser()
        KelolaObatForm.Close()
        KelolaLaporanForm.Close()
        Panel5.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'KelolaObatForm.Show()
        Call KelolaObat()
        KelolaUserForm.Close()
        KelolaLaporanForm.Close()
        Panel5.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'KelolaLaporanForm.Show()
        Call KelolaLaporan()
        KelolaUserForm.Close()
        KelolaObatForm.Close()
        Panel5.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Pesan konfirmasi sebelum logout
        Dim result As DialogResult = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            LoginForm.Show()
            Close()
        End If

        'Masukkan data ke Tbl_Log
        Dim insert As New SqlCommand("INSERT INTO Tbl_Log VALUES (@Waktu, @Aktifitas, @Id_User)", conn)
        insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Waktu", .Value = DateTime.Now})
        insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Aktifitas", .Value = "Logout"})
        insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Id_User", .Value = ToolStripLabel1.Text})
        insert.ExecuteNonQuery()
        insert.Dispose()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call KelolaLaporan()
        KelolaUserForm.Close()
        KelolaObatForm.Close()
        KelolaLaporanForm.Close()
        Panel5.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class