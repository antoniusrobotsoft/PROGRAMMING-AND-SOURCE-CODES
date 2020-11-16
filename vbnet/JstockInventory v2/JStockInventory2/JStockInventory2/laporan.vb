Public Class laporan
    Public basic_op As New basic_op
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        laporan_penjualan.Show()
        basic_op.setfokus(laporan_penjualan)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        laporan_pembelian.Show()
        basic_op.setfokus(laporan_pembelian)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        laporan_stok.Show()
        basic_op.setfokus(laporan_stok)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        laporan_keuangan.Show()
        basic_op.setfokus(laporan_keuangan)
    End Sub


End Class