<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_csv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_csv))
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.path_csv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_csv.Location = New System.Drawing.Point(416, 122)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 96)
        Me.tombol_csv.TabIndex = 61
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Browse)
        Me.GroupBox1.Controls.Add(Me.path_csv)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tombol_csv)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 263)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'Browse
        '
        Me.Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Browse.Location = New System.Drawing.Point(442, 61)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 64
        Me.Browse.Text = "browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'path_csv
        '
        Me.path_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.path_csv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_csv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.path_csv.Location = New System.Drawing.Point(139, 63)
        Me.path_csv.Name = "path_csv"
        Me.path_csv.Size = New System.Drawing.Size(287, 21)
        Me.path_csv.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Path untuk csv"
        '
        'form_csv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 300)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_csv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ekspor Data ke CSV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tombol_csv As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents path_csv As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
