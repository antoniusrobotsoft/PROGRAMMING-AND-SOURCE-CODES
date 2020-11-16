Imports MySql.Data.MySqlClient
Public Class form_master_data_merek_add
    Public Property added_data As Integer
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Public con_mysql As New MySqlConnection()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(TextBox1.Text) < 1 Then
                MsgBox("Merek harus diisi !")
            Else
                Dim merek = TextBox1.Text
                Dim ket = TextBox2.Text
                Dim count_row As Integer
                count_row = 0
                count_row = data_obj.ret_similar_data_in_db("master_merek", "merek", merek)
                If count_row < 1 Then
                    Dim sql_str = "INSERT INTO `master_merek` (`id`, `merek`, `ket`,`jumlah_total`) VALUES (NULL, '" + merek + "', '" + ket + "', '0');"
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
                    Dim fail_msg = "Data merek : " + merek + " sudah ada di database !"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call clear_data()
    End Sub

    Private Sub form_master_data_merek_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clear_data()
    End Sub
End Class