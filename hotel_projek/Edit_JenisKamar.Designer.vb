<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_JenisKamar
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
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtHargaPerMalam = New System.Windows.Forms.TextBox()
        Me.TxtJenisKamar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUbah.Location = New System.Drawing.Point(435, 242)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(97, 40)
        Me.BtnUbah.TabIndex = 9
        Me.BtnUbah.Text = "Edit"
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Harga / malam"
        '
        'TxtHargaPerMalam
        '
        Me.TxtHargaPerMalam.Location = New System.Drawing.Point(203, 174)
        Me.TxtHargaPerMalam.Name = "TxtHargaPerMalam"
        Me.TxtHargaPerMalam.Size = New System.Drawing.Size(329, 22)
        Me.TxtHargaPerMalam.TabIndex = 7
        '
        'TxtJenisKamar
        '
        Me.TxtJenisKamar.Location = New System.Drawing.Point(203, 109)
        Me.TxtJenisKamar.Name = "TxtJenisKamar"
        Me.TxtJenisKamar.Size = New System.Drawing.Size(329, 22)
        Me.TxtJenisKamar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jenis Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Form Edit Jenis Kamar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Edit_JenisKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 309)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtHargaPerMalam)
        Me.Controls.Add(Me.TxtJenisKamar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_JenisKamar"
        Me.Text = "Edit_JenisKamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUbah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtHargaPerMalam As TextBox
    Friend WithEvents TxtJenisKamar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
