Imports MySql.Data.MySqlClient

Public Class form_delete_all
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public Property con_mysql As New MySqlConnection
    Public Property cmd_mysql As New MySqlCommand
    Public Property table_name As String
    Public Property additional_condition As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.table_name = ""
        Me.additional_condition = ""
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Integer
        If Len(Me.additional_condition) > 1 Then
            If Me.additional_condition = "pembelian" Then
                data_obj.mysql_del_cond("op_stok_masuk", "mark", "pembelian")
            ElseIf Me.additional_condition = "penjualan" Then
                data_obj.mysql_del_cond("op_stok_keluar", "mark", "penjualan")
            Else
                Me.table_name = ""
                Me.additional_condition = ""
                Me.Hide()
            End If
        Else
            res = data_obj.mysql_truncate(Me.table_name)
            If res = 1 Then
                MsgBox("Seluruh data pada tabel " + Me.table_name)
            Else
                MsgBox("Gagal mengosongkan tabel " + Me.table_name)
            End If
        End If
        Me.table_name = ""
        Me.additional_condition = ""
    End Sub

    Private Sub form_delete_all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.additional_condition = "pembelian" Then
            teks_konfirmasi.Text = "Apakah Anda yakin ingin mengosongkan tabel pembelian ? "
        ElseIf Me.additional_condition = "penjualan" Then
            teks_konfirmasi.Text = "Apakah Anda yakin ingin mengosongkan tabel penjualan ? "
        Else
            teks_konfirmasi.Text = "Apakah Anda yakin ingin mengosongkan tabel " + Me.table_name + " ? "
        End If
    End Sub
End Class