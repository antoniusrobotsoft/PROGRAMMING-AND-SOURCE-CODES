<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_master_data_kas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_master_data_kas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_jumlah_kas = New System.Windows.Forms.TextBox()
        Me.tombol_simpan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_kas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_perubahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.text_edit_mark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker_tanggal_perubahan = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_id = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.text_edit_jumlah_kas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker_hingga = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_dari = New System.Windows.Forms.DateTimePicker()
        Me.tombol_cari = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jumlah Kas Sekarang"
        '
        'text_jumlah_kas
        '
        Me.text_jumlah_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_kas.Location = New System.Drawing.Point(159, 31)
        Me.text_jumlah_kas.Name = "text_jumlah_kas"
        Me.text_jumlah_kas.Size = New System.Drawing.Size(216, 21)
        Me.text_jumlah_kas.TabIndex = 1
        '
        'tombol_simpan
        '
        Me.tombol_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_simpan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tombol_simpan.Image = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.tombol_simpan.Location = New System.Drawing.Point(344, 71)
        Me.tombol_simpan.Name = "tombol_simpan"
        Me.tombol_simpan.Size = New System.Drawing.Size(56, 65)
        Me.tombol_simpan.TabIndex = 11
        Me.tombol_simpan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(381, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(11, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "* = harus diisi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tombol_simpan)
        Me.GroupBox1.Controls.Add(Me.text_jumlah_kas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(10, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Jumlah Kas Saat Ini"
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToResizeRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.jumlah_kas, Me.tanggal_perubahan, Me.full_date, Me.mark})
        Me.DGView.Location = New System.Drawing.Point(24, 319)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(492, 265)
        Me.DGView.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'jumlah_kas
        '
        Me.jumlah_kas.DataPropertyName = "jumlah_kas"
        Me.jumlah_kas.HeaderText = "Jumlah Kas"
        Me.jumlah_kas.Name = "jumlah_kas"
        Me.jumlah_kas.ReadOnly = True
        Me.jumlah_kas.Width = 160
        '
        'tanggal_perubahan
        '
        Me.tanggal_perubahan.HeaderText = "Tanggal Perubahan"
        Me.tanggal_perubahan.Name = "tanggal_perubahan"
        Me.tanggal_perubahan.ReadOnly = True
        Me.tanggal_perubahan.Width = 140
        '
        'full_date
        '
        Me.full_date.DataPropertyName = "full_date"
        Me.full_date.HeaderText = "Tgl"
        Me.full_date.Name = "full_date"
        Me.full_date.ReadOnly = True
        Me.full_date.Visible = False
        Me.full_date.Width = 260
        '
        'mark
        '
        Me.mark.DataPropertyName = "mark"
        Me.mark.HeaderText = "Mark"
        Me.mark.Name = "mark"
        Me.mark.ReadOnly = True
        Me.mark.Width = 140
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(10, 234)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(37, 40)
        Me.button_prev.TabIndex = 29
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(53, 236)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(39, 39)
        Me.button_next.TabIndex = 30
        Me.button_next.UseVisualStyleBackColor = True
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(98, 236)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 39)
        Me.tombol_home.TabIndex = 44
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_page)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.text_total_page)
        Me.GroupBox3.Controls.Add(Me.text_total_data)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(157, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 41)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        '
        'combo_page
        '
        Me.combo_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page.FormattingEnabled = True
        Me.combo_page.Location = New System.Drawing.Point(325, 12)
        Me.combo_page.Name = "combo_page"
        Me.combo_page.Size = New System.Drawing.Size(51, 21)
        Me.combo_page.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(284, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Page"
        '
        'text_total_page
        '
        Me.text_total_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page.Location = New System.Drawing.Point(223, 15)
        Me.text_total_page.Name = "text_total_page"
        Me.text_total_page.Size = New System.Drawing.Size(45, 20)
        Me.text_total_page.TabIndex = 40
        '
        'text_total_data
        '
        Me.text_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data.Location = New System.Drawing.Point(63, 13)
        Me.text_total_data.Name = "text_total_data"
        Me.text_total_data.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(0, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Total Data"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(97, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "         "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(155, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total  Page"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.text_edit_mark)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_tanggal_perubahan)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.text_id)
        Me.GroupBox2.Controls.Add(Me.label_id)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.text_edit_jumlah_kas)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(563, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 290)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubah Data Histori Perubahan Kas"
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button4.Image = Global.JStockInventory2.My.Resources.Resources.icon_retry
        Me.Button4.Location = New System.Drawing.Point(137, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 53)
        Me.Button4.TabIndex = 79
        Me.Button4.UseVisualStyleBackColor = True
        '
        'text_edit_mark
        '
        Me.text_edit_mark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_edit_mark.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_edit_mark.Location = New System.Drawing.Point(158, 144)
        Me.text_edit_mark.Name = "text_edit_mark"
        Me.text_edit_mark.Size = New System.Drawing.Size(160, 22)
        Me.text_edit_mark.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Mark"
        '
        'DateTimePicker_tanggal_perubahan
        '
        Me.DateTimePicker_tanggal_perubahan.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_tanggal_perubahan.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_tanggal_perubahan.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_tanggal_perubahan.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_tanggal_perubahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_tanggal_perubahan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_tanggal_perubahan.Location = New System.Drawing.Point(158, 99)
        Me.DateTimePicker_tanggal_perubahan.Name = "DateTimePicker_tanggal_perubahan"
        Me.DateTimePicker_tanggal_perubahan.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_tanggal_perubahan.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(278, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(233, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "* = harus diisi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(324, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Tanggal Perubahan"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_id.Location = New System.Drawing.Point(158, 20)
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(58, 22)
        Me.text_id.TabIndex = 24
        Me.text_id.Visible = False
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Location = New System.Drawing.Point(19, 25)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 23
        Me.label_id.Text = "ID"
        Me.label_id.Visible = False
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(311, 231)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 53)
        Me.Button8.TabIndex = 22
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(225, 231)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 53)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = True
        '
        'text_edit_jumlah_kas
        '
        Me.text_edit_jumlah_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_edit_jumlah_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_edit_jumlah_kas.Location = New System.Drawing.Point(158, 57)
        Me.text_edit_jumlah_kas.Name = "text_edit_jumlah_kas"
        Me.text_edit_jumlah_kas.Size = New System.Drawing.Size(160, 22)
        Me.text_edit_jumlah_kas.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jumlah Kas"
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_csv.Location = New System.Drawing.Point(823, 12)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 98)
        Me.tombol_csv.TabIndex = 61
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker_hingga)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker_dari)
        Me.GroupBox5.Controls.Add(Me.tombol_cari)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(443, 116)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(272, 106)
        Me.GroupBox5.TabIndex = 66
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tampilkan Histori Berdasarkan Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(6, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Hingga"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(6, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Dari"
        '
        'DateTimePicker_hingga
        '
        Me.DateTimePicker_hingga.AllowDrop = True
        Me.DateTimePicker_hingga.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_hingga.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_hingga.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_hingga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_hingga.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_hingga.Location = New System.Drawing.Point(139, 51)
        Me.DateTimePicker_hingga.Name = "DateTimePicker_hingga"
        Me.DateTimePicker_hingga.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_hingga.TabIndex = 73
        '
        'DateTimePicker_dari
        '
        Me.DateTimePicker_dari.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dari.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_dari.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_dari.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_dari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_dari.Location = New System.Drawing.Point(139, 21)
        Me.DateTimePicker_dari.Name = "DateTimePicker_dari"
        Me.DateTimePicker_dari.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_dari.TabIndex = 72
        '
        'tombol_cari
        '
        Me.tombol_cari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_cari.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tombol_cari.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.tombol_cari.Location = New System.Drawing.Point(175, 77)
        Me.tombol_cari.Name = "tombol_cari"
        Me.tombol_cari.Size = New System.Drawing.Size(78, 23)
        Me.tombol_cari.TabIndex = 20
        Me.tombol_cari.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(394, 596)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(530, 16)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "n.b:mark berguna untuk penanda saat ekspor data ke laporan keuangan"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox7.Location = New System.Drawing.Point(24, 291)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(492, 22)
        Me.TextBox7.TabIndex = 78
        Me.TextBox7.Text = "HISTORI PERUBAHAN DATA KAS"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_delete_all.Location = New System.Drawing.Point(687, 12)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 98)
        Me.tombol_delete_all.TabIndex = 79
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'form_master_data_kas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 619)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_master_data_kas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Kas Perusahaan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents text_jumlah_kas As TextBox
    Friend WithEvents tombol_simpan As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGView As DataGridView
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents tombol_home As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents text_id As TextBox
    Friend WithEvents label_id As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents text_edit_jumlah_kas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker_tanggal_perubahan As DateTimePicker
    Friend WithEvents tombol_csv As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker_hingga As DateTimePicker
    Friend WithEvents DateTimePicker_dari As DateTimePicker
    Friend WithEvents tombol_cari As Button
    Friend WithEvents text_edit_mark As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents tombol_delete_all As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_kas As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_perubahan As DataGridViewTextBoxColumn
    Friend WithEvents full_date As DataGridViewTextBoxColumn
    Friend WithEvents mark As DataGridViewTextBoxColumn
End Class
