<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_master_data_kategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_master_data_kategori))
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcari_nama_kategori = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label_id = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.text_jumlah_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.text_keterangan = New System.Windows.Forms.TextBox()
        Me.text_nama_kategori = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToResizeRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_kategori, Me.keterangan, Me.jumlah_total})
        Me.DGView.Location = New System.Drawing.Point(12, 229)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(592, 280)
        Me.DGView.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nama_kategori
        '
        Me.nama_kategori.DataPropertyName = "nama_kategori"
        Me.nama_kategori.HeaderText = "Nama Kategori"
        Me.nama_kategori.Name = "nama_kategori"
        Me.nama_kategori.ReadOnly = True
        Me.nama_kategori.Width = 168
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        Me.keterangan.Width = 260
        '
        'jumlah_total
        '
        Me.jumlah_total.DataPropertyName = "jumlah_total"
        Me.jumlah_total.HeaderText = "Stok"
        Me.jumlah_total.Name = "jumlah_total"
        Me.jumlah_total.ReadOnly = True
        Me.jumlah_total.Width = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.textcari_nama_kategori)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(21, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 78)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama Kategori"
        '
        'textcari_nama_kategori
        '
        Me.textcari_nama_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcari_nama_kategori.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textcari_nama_kategori.Location = New System.Drawing.Point(157, 34)
        Me.textcari_nama_kategori.Name = "textcari_nama_kategori"
        Me.textcari_nama_kategori.Size = New System.Drawing.Size(157, 21)
        Me.textcari_nama_kategori.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.Button3.Location = New System.Drawing.Point(332, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.text_id)
        Me.GroupBox1.Controls.Add(Me.text_jumlah_total)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.text_keterangan)
        Me.GroupBox1.Controls.Add(Me.text_nama_kategori)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(610, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 345)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Data Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(216, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "* = harus diisi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(332, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "*"
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Location = New System.Drawing.Point(6, 35)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 26
        Me.label_id.Text = "ID"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_id.Location = New System.Drawing.Point(129, 29)
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(63, 21)
        Me.text_id.TabIndex = 25
        '
        'text_jumlah_total
        '
        Me.text_jumlah_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_total.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_total.Location = New System.Drawing.Point(129, 200)
        Me.text_jumlah_total.Name = "text_jumlah_total"
        Me.text_jumlah_total.Size = New System.Drawing.Size(115, 21)
        Me.text_jumlah_total.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Jumlah Stok"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(280, 280)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(46, 55)
        Me.Button8.TabIndex = 22
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(184, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 55)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(86, 280)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 55)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = True
        '
        'text_keterangan
        '
        Me.text_keterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_keterangan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_keterangan.Location = New System.Drawing.Point(129, 109)
        Me.text_keterangan.Multiline = True
        Me.text_keterangan.Name = "text_keterangan"
        Me.text_keterangan.Size = New System.Drawing.Size(197, 69)
        Me.text_keterangan.TabIndex = 3
        '
        'text_nama_kategori
        '
        Me.text_nama_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama_kategori.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama_kategori.Location = New System.Drawing.Point(129, 70)
        Me.text_nama_kategori.Name = "text_nama_kategori"
        Me.text_nama_kategori.Size = New System.Drawing.Size(197, 21)
        Me.text_nama_kategori.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keterangan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Kategori"
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
        Me.GroupBox3.Location = New System.Drawing.Point(216, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 41)
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
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(142, 183)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 39)
        Me.tombol_home.TabIndex = 43
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(81, 183)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(39, 39)
        Me.button_next.TabIndex = 29
        Me.button_next.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(12, 183)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(37, 40)
        Me.button_prev.TabIndex = 28
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Location = New System.Drawing.Point(890, 12)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 98)
        Me.tombol_csv.TabIndex = 60
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_delete_all.Location = New System.Drawing.Point(740, 12)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 98)
        Me.tombol_delete_all.TabIndex = 63
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'form_master_data_kategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 531)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_master_data_kategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Kategori"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textcari_nama_kategori As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents text_jumlah_total As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents text_keterangan As TextBox
    Friend WithEvents text_nama_kategori As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents label_id As Label
    Friend WithEvents text_id As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_kategori As DataGridViewTextBoxColumn
    Friend WithEvents keterangan As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_total As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tombol_home As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents tombol_delete_all As Button
End Class
