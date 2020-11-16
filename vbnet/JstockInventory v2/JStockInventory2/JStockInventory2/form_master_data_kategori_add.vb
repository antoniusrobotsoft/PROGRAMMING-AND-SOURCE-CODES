Imports MySql.Data.MySqlClient

Public Class form_master_data_kategori_add
    Public Property added_data As Integer
    Public basic_op As New basic_op
    Public data_obj As New data_object
     Public Property page As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call clear_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql_str As String
            If (Len(TextBox1.Text) < 1) Then
                MsgBox("nama kategori harus diisi!")
            Else
                Dim nama_kategori = TextBox1.Text
                Dim keterangan = TextBox2.Text
                Dim count_row As Integer
                count_row = 0
                count_row = data_obj.ret_similar_data_in_db("master_kategori_produk", "nama_kategori", nama_kategori)
                If count_row < 1 Then
                    sql_str = "INSERT INTO `master_kategori_produk` (`id`, `nama_kategori`, `keterangan`, `jumlah_total`) VALUES (NULL, '" + nama_kategori + "', '" + keterangan + "', '0');"
                    Try
                        added_data = 1
                        data_obj.mysql_just_exec(sql_str)
                        Console.Beep(4000, 100)
                        Me.Hide()
                        Call clear_data()
                    Catch ex As Exception
                        basic_op.gagal_inputdb()
                        Me.Hide()
                    End Try
                Else
                    Dim fail_msg = "Data nama kategori : " + nama_kategori + " sudah ada di database !"
                    MsgBox(fail_msg)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Public Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub form_master_data_kategori_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        added_data = 0
        Call clear_data()
    End Sub
End Class