<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_JenisKamar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtJenisKamar = New System.Windows.Forms.TextBox()
        Me.TxtHargaPerMalam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Kamar"
        '
        'TxtJenisKamar
        '
        Me.TxtJenisKamar.Location = New System.Drawing.Point(314, 110)
        Me.TxtJenisKamar.Name = "TxtJenisKamar"
        Me.TxtJenisKamar.Size = New System.Drawing.Size(200, 22)
        Me.TxtJenisKamar.TabIndex = 1
        '
        'TxtHargaPerMalam
        '
        Me.TxtHargaPerMalam.Location = New System.Drawing.Point(314, 175)
        Me.TxtHargaPerMalam.Name = "TxtHargaPerMalam"
        Me.TxtHargaPerMalam.Size = New System.Drawing.Size(200, 22)
        Me.TxtHargaPerMalam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga / malam"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(314, 277)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(135, 31)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Tambah_JenisKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtHargaPerMalam)
        Me.Controls.Add(Me.TxtJenisKamar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah_JenisKamar"
        Me.Text = "Tambah_JenisKamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtJenisKamar As TextBox
    Friend WithEvents TxtHargaPerMalam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTambah As Button
End Class
