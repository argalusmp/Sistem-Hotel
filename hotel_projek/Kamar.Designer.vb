<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kamar
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.JenisKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridKamar = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuBar.SuspendLayout()
        CType(Me.DataGridKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.Pink
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisKamarToolStripMenuItem, Me.KamarToolStripMenuItem, Me.TamuToolStripMenuItem, Me.BookingKamarToolStripMenuItem, Me.CheckOutToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(800, 24)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "MenuStrip1"
        '
        'JenisKamarToolStripMenuItem
        '
        Me.JenisKamarToolStripMenuItem.Name = "JenisKamarToolStripMenuItem"
        Me.JenisKamarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.JenisKamarToolStripMenuItem.Text = "Jenis Kamar"
        '
        'KamarToolStripMenuItem
        '
        Me.KamarToolStripMenuItem.Name = "KamarToolStripMenuItem"
        Me.KamarToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.KamarToolStripMenuItem.Text = "Kamar"
        '
        'TamuToolStripMenuItem
        '
        Me.TamuToolStripMenuItem.Name = "TamuToolStripMenuItem"
        Me.TamuToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.TamuToolStripMenuItem.Text = "Tamu"
        '
        'BookingKamarToolStripMenuItem
        '
        Me.BookingKamarToolStripMenuItem.Name = "BookingKamarToolStripMenuItem"
        Me.BookingKamarToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.BookingKamarToolStripMenuItem.Text = "Booking Kamar"
        '
        'CheckOutToolStripMenuItem
        '
        Me.CheckOutToolStripMenuItem.Name = "CheckOutToolStripMenuItem"
        Me.CheckOutToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CheckOutToolStripMenuItem.Text = "CheckOut"
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Crimson
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnHapus.Location = New System.Drawing.Point(513, 19)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 30)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Orange
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEdit.Location = New System.Drawing.Point(599, 19)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 30)
        Me.BtnEdit.TabIndex = 30
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Green
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnTambah.Location = New System.Drawing.Point(684, 19)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 30)
        Me.BtnTambah.TabIndex = 31
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(279, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Hotel Tadika Mesra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(299, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Tambah Kamar"
        '
        'DataGridKamar
        '
        Me.DataGridKamar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridKamar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridKamar.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridKamar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKamar.GridColor = System.Drawing.Color.Pink
        Me.DataGridKamar.Location = New System.Drawing.Point(16, 65)
        Me.DataGridKamar.Name = "DataGridKamar"
        Me.DataGridKamar.ReadOnly = True
        Me.DataGridKamar.Size = New System.Drawing.Size(743, 275)
        Me.DataGridKamar.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridKamar)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 358)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "Kamar"
        Me.Text = "FormKamar"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.DataGridKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents JenisKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridKamar As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
