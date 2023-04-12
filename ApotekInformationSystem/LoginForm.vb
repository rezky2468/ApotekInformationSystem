Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = "kasir123"
        TextBox2.Text = "123"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data tidak boleh kosong!")
            TextBox1.Select()
        Else
            Call Koneksi()
            cmd = New SqlCommand("SELECT * FROM Tbl_User WHERE Username = '" & TextBox1.Text & "' AND Password = '" & TextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                MsgBox("Berhasil Login")
                Hide() 'Sembunyikan form login

                'Mengambil data yang ada di MsEmployee
                Dim tipeUser As String = dr!Tipe_User
                Dim idUser As String = dr!Id_User
                Dim namaUser As String = dr!Nama_User

                dr.Close()
                cmd.Dispose()

                'Masukkan data ke Tbl_Log
                'Dim insert As New SqlCommand("INSERT INTO Tbl_Log (aktifitas, Id_User) VALUES (@Aktifitas, @Id_User)", conn)
                Dim insert As New SqlCommand("INSERT INTO Tbl_Log VALUES (@Waktu, @Aktifitas, @Id_User)", conn)
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Waktu", .Value = DateTime.Now})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Aktifitas", .Value = "Login"})
                insert.Parameters.Add(New SqlParameter With {.ParameterName = "@Id_User", .Value = idUser})
                insert.ExecuteNonQuery()
                insert.Dispose()

                'Validasi role/level lalu memasukan data EmployeeID ke ToolStripLabel
                If tipeUser.ToLower = "admin" Then 'Jika admin
                    AdminNavigationForm.Show()
                ElseIf tipeUser.ToLower = "apoteker" Then 'Jika apoteker
                    KelolaResepForm.Show()
                ElseIf tipeUser.ToLower = "kasir" Then 'Jika kasir
                    KelolaTransaksiForm.Show()
                End If

                AdminNavigationForm.ToolStripLabel1.Text = idUser
                AdminNavigationForm.ToolStripLabel4.Text = tipeUser

            Else
                MsgBox("Data tidak valid!")
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
