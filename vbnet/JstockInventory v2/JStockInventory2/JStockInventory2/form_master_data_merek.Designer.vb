<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_master_data_merek
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_master_data_merek))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_jumlah_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_id = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.text_ket = New System.Windows.Forms.TextBox()
        Me.text_merek = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcari_merek = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.text_jumlah_total)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.text_id)
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.text_ket)
        Me.GroupBox1.Controls.Add(Me.text_merek)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(622, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 319)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(227, 222)
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
        Me.Label8.Location = New System.Drawing.Point(324, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "*"
        '
        'text_jumlah_total
        '
        Me.text_jumlah_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_total.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_total.Location = New System.Drawing.Point(125, 183)
        Me.text_jumlah_total.Name = "text_jumlah_total"
        Me.text_jumlah_total.Size = New System.Drawing.Size(141, 22)
        Me.text_jumlah_total.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Jumlah Stok"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_id.Location = New System.Drawing.Point(125, 22)
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(58, 22)
        Me.text_id.TabIndex = 24
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Location = New System.Drawing.Point(19, 25)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 23
        Me.label_id.Text = "ID"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(308, 258)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 55)
        Me.Button8.TabIndex = 22
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(209, 258)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 55)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(107, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 55)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = True
        '
        'text_ket
        '
        Me.text_ket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_ket.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_ket.Location = New System.Drawing.Point(125, 94)
        Me.text_ket.Multiline = True
        Me.text_ket.Name = "text_ket"
        Me.text_ket.Size = New System.Drawing.Size(212, 70)
        Me.text_ket.TabIndex = 3
        '
        'text_merek
        '
        Me.text_merek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_merek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_merek.Location = New System.Drawing.Point(125, 57)
        Me.text_merek.Name = "text_merek"
        Me.text_merek.Size = New System.Drawing.Size(193, 22)
        Me.text_merek.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keterangan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merek"
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToDeleteRows = False
        Me.DGView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.merek, Me.ket, Me.jumlah_total})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGView.Location = New System.Drawing.Point(12, 195)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGView.Size = New System.Drawing.Size(604, 244)
        Me.DGView.TabIndex = 23
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'merek
        '
        Me.merek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.merek.DataPropertyName = "merek"
        Me.merek.HeaderText = "Merek"
        Me.merek.Name = "merek"
        Me.merek.ReadOnly = True
        Me.merek.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.merek.Width = 160
        '
        'ket
        '
        Me.ket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ket.DataPropertyName = "ket"
        Me.ket.HeaderText = "Keterangan"
        Me.ket.Name = "ket"
        Me.ket.ReadOnly = True
        Me.ket.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ket.Width = 255
        '
        'jumlah_total
        '
        Me.jumlah_total.DataPropertyName = "jumlah_total"
        Me.jumlah_total.HeaderText = "Stok"
        Me.jumlah_total.Name = "jumlah_total"
        Me.jumlah_total.ReadOnly = True
        Me.jumlah_total.Width = 140
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.textcari_merek)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 78)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(11, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Merek"
        '
        'textcari_merek
        '
        Me.textcari_merek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcari_merek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textcari_merek.Location = New System.Drawing.Point(81, 34)
        Me.textcari_merek.Name = "textcari_merek"
        Me.textcari_merek.Size = New System.Drawing.Size(157, 22)
        Me.textcari_merek.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.Button3.Location = New System.Drawing.Point(260, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
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
        Me.GroupBox3.Location = New System.Drawing.Point(225, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 41)
        Me.GroupBox3.TabIndex = 42
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
        Me.text_total_page.Location = New System.Drawing.Point(226, 13)
        Me.text_total_page.Name = "text_total_page"
        Me.text_total_page.Size = New System.Drawing.Size(52, 20)
        Me.text_total_page.TabIndex = 40
        '
        'text_total_data
        '
        Me.text_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data.Location = New System.Drawing.Point(61, 13)
        Me.text_total_data.Name = "text_total_data"
        Me.text_total_data.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(0, 20)
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
        Me.Label13.Location = New System.Drawing.Point(158, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total  Page"
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(163, 144)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 42)
        Me.tombol_home.TabIndex = 45
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(82, 144)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(46, 43)
        Me.button_next.TabIndex = 25
        Me.button_next.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(12, 145)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(46, 42)
        Me.button_prev.TabIndex = 24
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Location = New System.Drawing.Point(882, 10)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 98)
        Me.tombol_csv.TabIndex = 60
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_delete_all.Location = New System.Drawing.Point(729, 10)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 98)
        Me.tombol_delete_all.TabIndex = 63
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'form_master_data_merek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 448)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_master_data_merek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Merek"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents text_ket As TextBox
    Friend WithEvents text_merek As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents DGView As DataGridView
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textcari_merek As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents text_id As TextBox
    Friend WithEvents label_id As Label
    Friend WithEvents text_jumlah_total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents merek As DataGridViewTextBoxColumn
    Friend WithEvents ket As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_total As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tombol_home As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents tombol_delete_all As Button
End Class
