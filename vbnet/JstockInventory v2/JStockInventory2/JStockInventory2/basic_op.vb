Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Imports System.DateTime
Imports System.Globalization
Imports System.Environment
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class basic_op
    Private Declare Function GetForegroundWindow Lib "user32" () As IntPtr
    Private Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As IntPtr) As Long
    Public Property jstock_app_path As String
    Public Property universal_return = 1
    Function return_mysql_date_format(ByVal full_tgl As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim ret_date As String
            ret_date = ""
            Dim ar_tgl() As String
            Dim tanggal_str As String
            Dim bulan_str As String
            Dim tahun_str As String
            If Len(full_tgl) > 1 And full_tgl.Contains("/") Then
                ar_tgl = full_tgl.Split("/")
                Dim tanggal = ar_tgl(0)
                Dim bulan = ar_tgl(1)
                Dim tahun = ar_tgl(2)

                If Val(tanggal) < 10 Then
                    If Len(tanggal.ToString) < 2 Then
                        tanggal_str = "0" + tanggal.ToString
                    Else
                        tanggal_str = tanggal.ToString
                    End If
                Else
                    tanggal_str = tanggal.ToString
                End If

                If Val(bulan) < 10 Then
                    If Len(bulan.ToString) < 2 Then
                        bulan_str = "0" + bulan.ToString
                    Else
                        bulan_str = bulan.ToString
                    End If
                Else
                    bulan_str = bulan.ToString
                End If
                tahun_str = tahun.ToString
                ret_date = tahun_str + "-" + bulan_str + "-" + tanggal_str
            Else
                Console.WriteLine("[-] no correct date format supplied")
            End If
            Return ret_date
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function


    Public Function convert_mysql_date_format_to_chinese_date_format(ByVal mysql_date_format As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim tanggal As String
            Dim bulan As String
            Dim tahun As String
            Dim ret_date As String
            Dim ar_date() As String
            Dim split_date() As String
            Dim dirty_date As String
            Dim valid_mysql_date As Boolean
            valid_mysql_date = True
            If mysql_date_format.Contains(" ") = True Then
                split_date = mysql_date_format.Split(" ")
                dirty_date = split_date(0).Trim()
            Else
                dirty_date = mysql_date_format
            End If

            If dirty_date.Contains("-") = True Then
                ar_date = dirty_date.Split("-")

            ElseIf dirty_date.Contains("/") = True Then
                ar_date = dirty_date.Split("/")
            Else
                valid_mysql_date = False
            End If
            If valid_mysql_date = True Then
                tanggal = ar_date(1)
                bulan = ar_date(0)
                tahun = ar_date(2)
            Else
                tanggal = waktu("tanggal_only")
                bulan = waktu("bulan")
                tahun = waktu("tahun")
            End If
            ret_date = tanggal + "/" + bulan + "/" + tahun
            Return ret_date
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function
    Public Function ret_current_drive_letter()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim current_drive = ""
            Dim env = Environment.GetEnvironmentVariable("windir")
            current_drive = Path.GetPathRoot(env)
            Return current_drive
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return "c:\"
        End Try
    End Function

    Public Function jstock_read_config()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim current_drive As String
            Dim app_path As String
            'Me.jstock_app_path = Directory.GetCurrentDirectory()
            'considering it fails to read config_path.txt from these lists:
            'first try will be current active dir
            'then user home dir
            'then user home dir's Desktop
            'then user home dir's my documents
            Dim tmp_str As String
            tmp_str = ""
            current_drive = ret_current_drive_letter()
            Dim current_dir = ret_current_dir()
            Dim home_dir = ret_home_dir()
            'worst scenario when there's no config_path.txt found we will user default variable at c:\jstockinventory
            Me.jstock_app_path = current_drive + "\jstockinventory\"
            If (File.Exists(current_dir + "\config_path.txt")) Then
                tmp_str = ret_file_content(current_dir + "\config_path.txt")
            ElseIf (File.Exists(home_dir + "\config_path.txt")) Then
                tmp_str = ret_file_content(home_dir + "\config_path.txt")
            ElseIf (File.Exists(home_dir + "\Desktop\config_path.txt")) Then
                tmp_str = ret_file_content(home_dir + "\Desktop\config_path.txt")
            ElseIf (File.Exists(home_dir + "\Documents\config_path.txt")) Then
                tmp_str = ret_file_content(home_dir + "\Documents\config_path.txt")
            End If
            If Len(tmp_str.Trim) > 1 Then
                Me.jstock_app_path = tmp_str
            End If
            app_path = Me.jstock_app_path
            Return app_path
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function

    Public Function ret_file_content(ByVal path_file As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path_file)
            Dim a As String
            Dim full_data As String
            Do
                a = reader.ReadLine
                If a <> Nothing Then
                    If Len(a.Trim) > 1 Then
                        full_data = full_data + a
                    End If
                End If
            Loop Until a Is Nothing
            reader.Close()
            Return full_data
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function
    Public Function ret_current_dir()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim Path = Directory.GetCurrentDirectory()
            Return Path
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function

    Public Function ret_home_dir()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            Return path
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function

    Public Function read_db_cfg()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim ret_array(4) As String
        Try

            Dim app_path As String
            app_path = jstock_read_config()

            Dim a As String
            Dim i As Integer
            Dim baris As String

            i = 1
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(app_path & "\cfg\db.txt")
            Do
                a = reader.ReadLine
                'Dim words As String() = baris.Split(New Char() {"="c})
                'data = words(0)
                If i = 1 Then
                    Dim data As String
                    baris = a.ToString()
                    Dim words As String() = baris.Split(New Char() {"="c})
                    data = words(1)
                    ret_array(0) = data

                ElseIf i = 2 Then
                    Dim data As String
                    baris = a.ToString()
                    Dim words As String() = baris.Split(New Char() {"="c})
                    data = words(1)

                    ret_array(1) = data
                ElseIf i = 3 Then
                    Dim data As String
                    baris = a.ToString()
                    Dim words As String() = baris.Split(New Char() {"="c})
                    data = words(1)
                    ret_array(2) = data
                ElseIf i = 4 Then
                    Dim data As String
                    baris = a.ToString()
                    Dim words As String() = baris.Split(New Char() {"="c})
                    data = words(1)

                    ret_array(3) = data
                End If
                i = i + 1
            Loop Until a Is Nothing
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
        Return ret_array
    End Function

    Public Function convert_to_tanggalan_bule(ByVal idate_dirty As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim ar_data() As String
            Dim tanggal_bule As String

            ar_data = idate_dirty.Split("/")
            tanggal_bule = ar_data(1) & "/" & ar_data(0) & "/" & ar_data(2)

            Return tanggal_bule
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function
    Public Sub create_file(ByVal path As String, ByVal data_to_write As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If (Len(path) < 4) And path.Contains("\") = False Then
                Console.WriteLine("[-] got path:" + path)
                MsgBox("ada kesalahan pada path data, operasi tidak dilanjutkan")
            Else
                path = path.Replace("\\", "\")
                path = path.Replace("/", "\")
                path = path.Replace("\\\", "\")
                Console.WriteLine(path)
                Dim file As System.IO.StreamWriter
                System.IO.File.WriteAllText(path, "")
                file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
                file.WriteLine(data_to_write)
                file.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub setfokus(ByVal nama_form)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim focusedWindow As System.IntPtr
            focusedWindow = GetForegroundWindow()
            If Not nama_form.Handle.Equals(focusedWindow) Then
                SetForegroundWindow(nama_form.Handle)
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Function ret_filename_from_full_path(ByVal full_path As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim pecahan_path As String() = full_path.Split(New Char() {"\"c})
            Dim part As String
            Dim final As String
            final = ""
            For Each part In pecahan_path
                final = part
            Next
            Return final
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function

    Public Function copy_file(ByVal orig_path As String, ByVal dest_path As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim ret As Integer
        ret = 0
        Dim filename_orig = ret_filename_from_full_path(orig_path)
        Dim filename_dest = ret_filename_from_full_path(dest_path)
        Try
            If filename_orig = filename_dest Then
                System.IO.File.Delete(dest_path)
            End If
            My.Computer.FileSystem.CopyFile(orig_path, dest_path)
            ret = 1
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            ret = -1
        End Try
        Return ret
    End Function

    Public Function hide_id(ByVal label_id As Label, ByVal text_id As TextBox)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            label_id.Visible = False
            text_id.Visible = False
            Return 1
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function
    'function taken from https://astawan.wordpress.com/2008/07/05/membulatkan-angka-keatas-ceiling/
    Function Ceiling(number As Double) As Long
        Ceiling = -Int(-number)
    End Function
    'function fail_valnum from https://stackoverflow.com/questions/15423114/checking-to-see-if-text-box-input-is-numeric 
    Public Function fail_valnum(ByVal KeyChar As Char) As Boolean
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim allowedChars As String

            allowedChars = "0123456789./"

            If allowedChars.IndexOf(KeyChar) = -1 And (Asc(KeyChar)) <> 8 Then
                Return True
            End If

            Return False
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function

    Public Function konfirmasi_hapus(ByVal pesan As String, ByVal caption_data As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim result As Integer = MessageBox.Show(pesan, caption_data, MessageBoxButtons.OKCancel)
            If result = DialogResult.Cancel Then
                Return 0
            ElseIf result = DialogResult.OK Then
                Return 1
            Else
                Return 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function

    Function gagal_delete()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            MsgBox("maaf data gagal dihapus !")
            Return 1
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function
    Function gagal_inputdb()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            MsgBox("maaf data gagal tersimpan di database !")
            Return 1
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function

    Function validasi_login(ByVal uname As String, ByVal pass As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim valid As Integer
        Try

            Dim found As Integer

            valid = 1
            found = uname.IndexOf("'")
            If (found > -1) Then
                valid = 0
            End If
            found = pass.IndexOf("'")
            If (found > -1) Then
                valid = 0
            End If
            If Len(uname) < 1 Then
                valid = 0
            End If
            If Len(pass) < 1 Then
                valid = 0
            End If

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

        Return valid
    End Function

    Public Function waktu(ByVal mode As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim currentTime As System.DateTime = System.DateTime.Now
            Dim retme As String
            retme = "?"

            If mode = "waktu" Then
                Dim jam As String
                Dim menit As String
                Dim detik As String
                If Len(currentTime.Hour.ToString()) < 2 Then
                    jam = "0" & currentTime.Hour.ToString()
                Else
                    jam = currentTime.Hour.ToString()
                End If

                If Len(currentTime.Minute.ToString()) < 2 Then
                    menit = "0" & currentTime.Minute.ToString()
                Else
                    menit = currentTime.Minute.ToString()
                End If

                If Len(currentTime.Second.ToString()) < 2 Then
                    detik = "0" & currentTime.Second.ToString()
                Else
                    detik = currentTime.Second.ToString()
                End If
                retme = jam & ":" & menit & ":" & detik
            ElseIf mode = "tanggal" Then
                'dd/MM/yyyy
                Dim format_tgl = "dd/MM/yyyy"
                retme = currentTime.Date.ToString(format_tgl, CultureInfo.InvariantCulture)

            ElseIf mode = "tanggal_only" Then
                Dim format_tgl = "dd"
                retme = currentTime.Date.ToString(format_tgl, CultureInfo.InvariantCulture)

            ElseIf mode = "tanggal_bule" Then
                'MM/dd/yyyy
                Dim format_tgl = "MM/dd/yyyy"
                retme = currentTime.Date.ToString(format_tgl, CultureInfo.InvariantCulture)

            ElseIf mode = "bulan" Then
                retme = currentTime.Month
            ElseIf mode = "tahun" Then
                retme = currentTime.Year

            End If
            Return retme
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function

    Public Function parse_tgl(ByVal tgl As String, ByVal mode As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim retme As String
            Dim ar_tgl() As String

            retme = ""
            ar_tgl = tgl.Split("/")
            If mode = "tanggal" Then
                retme = ar_tgl(0)
            ElseIf mode = "bulan" Then
                retme = ar_tgl(1)
            ElseIf mode = "tahun" Then
                retme = ar_tgl(2)
            End If
            Return retme
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function

    Function convert_date_without_leading_zero(ByVal full_tgl As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim tanggal = parse_tgl(full_tgl, "tanggal")
            Dim bulan = parse_tgl(full_tgl, "bulan")
            Dim tahun = parse_tgl(full_tgl, "tahun")
            tanggal = Val(tanggal).ToString
            bulan = Val(bulan).ToString
            tahun = Val(tahun).ToString
            Dim new_full_date = tanggal + "/" + bulan + "/" + tahun
            Return new_full_date
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function

    Function convert_date_with_leading_zero(ByVal full_tgl As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim tanggal = parse_tgl(full_tgl, "tanggal")
            Dim bulan = parse_tgl(full_tgl, "bulan")
            Dim tahun = parse_tgl(full_tgl, "tahun")
            Dim tanggal_str As String
            Dim bulan_str As String
            Dim tahun_str As String

            If Val(tanggal) < 10 Then
                tanggal_str = "0" + tanggal.ToString
            End If

            If Val(bulan) < 10 Then
                bulan_str = "0" + bulan.ToString
            End If

            tahun_str = tahun.ToString

            Dim new_full_date = tanggal_str + "/" + bulan_str + "/" + tahun_str
            Return new_full_date
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

    End Function



    Function return_mysql_date_format_from_raw(ByVal tanggal As String, ByVal bulan As String, ByVal tahun As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim ret_date As String
            Dim tanggal_str As String
            Dim bulan_str As String
            Dim tahun_str As String

            If Val(tanggal) < 10 Then
                If Len(bulan.ToString) < 2 Then
                    tanggal_str = "0" + tanggal.ToString
                Else
                    tanggal_str = tanggal.ToString
                End If
            Else
                tanggal_str = tanggal.ToString
            End If

            If Val(bulan) < 10 Then
                If Len(bulan.ToString) < 2 Then
                    bulan_str = "0" + bulan.ToString
                Else
                    bulan_str = bulan.ToString
                End If
            Else
                bulan_str = bulan.ToString
            End If
            tahun_str = tahun.ToString
            ret_date = tahun_str + "-" + bulan_str + "-" + tanggal_str

            Return ret_date
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function



    'function taken from http://www.beansoftware.com/ASP.NET-FAQ/Create-Thumbnail-Image.aspx
    Public Sub CreateThumbnail(ByVal ThumbnailMax As Integer, ByVal OriginalImagePath As String, ByVal ThumbnailImagePath As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim imgOriginal As Image = Image.FromFile(OriginalImagePath)
            Dim OriginalHeight As Single = imgOriginal.Height
            Dim OriginalWidth As Single = imgOriginal.Width
            Dim ThumbnailWidth As Integer
            Dim ThumbnailHeight As Integer
            If OriginalHeight > OriginalWidth Then
                ThumbnailHeight = ThumbnailMax
                ThumbnailWidth = (OriginalWidth / OriginalHeight) * ThumbnailMax
            Else
                ThumbnailWidth = ThumbnailMax
                ThumbnailHeight = (OriginalHeight / OriginalWidth) * ThumbnailMax
            End If
            Dim ThumbnailBitmap As Bitmap = New Bitmap(ThumbnailWidth, ThumbnailHeight)
            Dim ResizedImage As Graphics = Graphics.FromImage(ThumbnailBitmap)
            ResizedImage.InterpolationMode = InterpolationMode.HighQualityBicubic
            ResizedImage.CompositingQuality = CompositingQuality.HighQuality
            ResizedImage.SmoothingMode = SmoothingMode.HighQuality
            ResizedImage.DrawImage(imgOriginal, 0, 0, ThumbnailWidth, ThumbnailHeight)
            ThumbnailBitmap.Save(ThumbnailImagePath)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            'Finally
            'do nothing
        End Try
    End Sub

End Class
