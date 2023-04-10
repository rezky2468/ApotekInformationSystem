Imports System.Data.SqlClient
Public Class AdminNavigationForm

    Public Sub LoadData()

        Call Koneksi()
        'da = New SqlDataAdapter("SELECT Tbl_Log.Id_Log, Tbl_User.Username, CONVERT(DATETIME, Tbl_Log.Waktu, 120) AS Timestamp, Tbl_Log.Aktifitas FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User", conn)
        da = New SqlDataAdapter("SELECT Tbl_Log.Id_Log, Tbl_User.Username, CONVERT(DATETIME, Tbl_Log.Waktu, 120) AS Timestamp, Tbl_Log.Aktifitas FROM Tbl_Log INNER JOIN Tbl_User ON Tbl_Log.Id_User = Tbl_User.Id_User", conn)
        ds = New DataSet
        da.Fill(ds, "Tbl_Log")
        DataGridView1.DataSource = (ds.Tables("Tbl_Log"))

    End Sub

    Private Sub AdminNavigationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KelolaUserForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaObatForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaLaporanForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

End Class