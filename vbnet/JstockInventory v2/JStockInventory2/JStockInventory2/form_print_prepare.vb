Public Class form_print_prepare
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public Property current_file As String
    Private Sub form_print_prepare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim app_path As String
            app_path = basic_op.jstock_read_config()
            basic_op.jstock_app_path = app_path
            Dim uri = app_path + "\print\" + Me.current_file.Trim()
            uri = uri.Replace("/", "\")
            uri = uri.Replace("\\", "\")
            uri = uri.Replace("\\\", "\")
            uri = uri.Trim
            Me.WebBrowser1.Navigate(uri)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class