<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Tamu
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
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNamaTamu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RbPerempuan = New System.Windows.Forms.RadioButton()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.BtnTambahTamu = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(175, 83)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(300, 22)
        Me.TxtNIK.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Form Tambah Informasi Tamu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'TxtNamaTamu
        '
        Me.TxtNamaTamu.Location = New System.Drawing.Point(175, 137)
        Me.TxtNamaTamu.Name = "TxtNamaTamu"
        Me.TxtNamaTamu.Size = New System.Drawing.Size(300, 22)
        Me.TxtNamaTamu.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Alamat"
        '
        'RbPerempuan
        '
        Me.RbPerempuan.AutoSize = True
        Me.RbPerempuan.Location = New System.Drawing.Point(12, 30)
        Me.RbPerempuan.Name = "RbPerempuan"
        Me.RbPerempuan.Size = New System.Drawing.Size(98, 20)
        Me.RbPerempuan.TabIndex = 7
        Me.RbPerempuan.TabStop = True
        Me.RbPerempuan.Text = "Perempuan"
        Me.RbPerempuan.UseVisualStyleBackColor = True
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Location = New System.Drawing.Point(12, 56)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(78, 20)
        Me.RbLaki.TabIndex = 8
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki-laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPerempuan)
        Me.GroupBox1.Controls.Add(Me.RbLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'RtbAlamat
        '
        Me.RtbAlamat.Location = New System.Drawing.Point(175, 330)
        Me.RtbAlamat.Name = "RtbAlamat"
        Me.RtbAlamat.Size = New System.Drawing.Size(300, 96)
        Me.RtbAlamat.TabIndex = 10
        Me.RtbAlamat.Text = ""
        '
        'BtnTambahTamu
        '
        Me.BtnTambahTamu.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnTambahTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahTamu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTambahTamu.Location = New System.Drawing.Point(354, 454)
        Me.BtnTambahTamu.Name = "BtnTambahTamu"
        Me.BtnTambahTamu.Size = New System.Drawing.Size(121, 39)
        Me.BtnTambahTamu.TabIndex = 11
        Me.BtnTambahTamu.Text = "Tambah "
        Me.BtnTambahTamu.UseVisualStyleBackColor = False
        '
        'Tambah_Tamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 520)
        Me.Controls.Add(Me.BtnTambahTamu)
        Me.Controls.Add(Me.RtbAlamat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNamaTamu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNIK)
        Me.Name = "Tambah_Tamu"
        Me.Text = "Tambah_Tamu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNamaTamu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RbPerempuan As RadioButton
    Friend WithEvents RbLaki As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RtbAlamat As RichTextBox
    Friend WithEvents BtnTambahTamu As Button
End Class
