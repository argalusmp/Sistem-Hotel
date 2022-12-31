<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Kamar
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.RbtnKosong = New System.Windows.Forms.RadioButton()
        Me.RbtnTerisi = New System.Windows.Forms.RadioButton()
        Me.txtNamaKamar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxIDJenisKamar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(299, 329)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 268)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(299, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = ":"
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Green
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnTambah.Location = New System.Drawing.Point(835, 434)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(100, 37)
        Me.BtnTambah.TabIndex = 42
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'RbtnKosong
        '
        Me.RbtnKosong.AutoSize = True
        Me.RbtnKosong.Location = New System.Drawing.Point(392, 381)
        Me.RbtnKosong.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtnKosong.Name = "RbtnKosong"
        Me.RbtnKosong.Size = New System.Drawing.Size(74, 20)
        Me.RbtnKosong.TabIndex = 41
        Me.RbtnKosong.TabStop = True
        Me.RbtnKosong.Text = "Kosong"
        Me.RbtnKosong.UseVisualStyleBackColor = True
        '
        'RbtnTerisi
        '
        Me.RbtnTerisi.AutoSize = True
        Me.RbtnTerisi.Location = New System.Drawing.Point(392, 329)
        Me.RbtnTerisi.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtnTerisi.Name = "RbtnTerisi"
        Me.RbtnTerisi.Size = New System.Drawing.Size(62, 20)
        Me.RbtnTerisi.TabIndex = 40
        Me.RbtnTerisi.TabStop = True
        Me.RbtnTerisi.Text = "Terisi"
        Me.RbtnTerisi.UseVisualStyleBackColor = True
        '
        'txtNamaKamar
        '
        Me.txtNamaKamar.Location = New System.Drawing.Point(392, 264)
        Me.txtNamaKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaKamar.Name = "txtNamaKamar"
        Me.txtNamaKamar.Size = New System.Drawing.Size(541, 22)
        Me.txtNamaKamar.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 329)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 268)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Nama Kamar"
        '
        'ComboBoxIDJenisKamar
        '
        Me.ComboBoxIDJenisKamar.FormattingEnabled = True
        Me.ComboBoxIDJenisKamar.Location = New System.Drawing.Point(392, 203)
        Me.ComboBoxIDJenisKamar.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxIDJenisKamar.Name = "ComboBoxIDJenisKamar"
        Me.ComboBoxIDJenisKamar.Size = New System.Drawing.Size(300, 24)
        Me.ComboBoxIDJenisKamar.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ID Jenis Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(440, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 29)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Hotel Tadika Mesra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(467, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Tambah Kamar"
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Pink
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(40, 22)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(100, 33)
        Me.BtnBack.TabIndex = 32
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Tambah_Kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 628)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.RbtnKosong)
        Me.Controls.Add(Me.RbtnTerisi)
        Me.Controls.Add(Me.txtNamaKamar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxIDJenisKamar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "Tambah_Kamar"
        Me.Text = "Tambah_Kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents RbtnKosong As RadioButton
    Friend WithEvents RbtnTerisi As RadioButton
    Friend WithEvents txtNamaKamar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxIDJenisKamar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBack As Button
End Class
