<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_JenisKamar
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
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblConsole = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblharga = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(217, 299)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(281, 44)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Hapus"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblConsole
        '
        Me.LblConsole.AutoSize = True
        Me.LblConsole.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsole.Location = New System.Drawing.Point(203, 180)
        Me.LblConsole.Name = "LblConsole"
        Me.LblConsole.Size = New System.Drawing.Size(72, 26)
        Me.LblConsole.TabIndex = 4
        Me.LblConsole.Text = "label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Kamu Ingin Menghapus Jenis Kamar Ini?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "per malam"
        '
        'Lblharga
        '
        Me.Lblharga.AutoSize = True
        Me.Lblharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblharga.Location = New System.Drawing.Point(383, 188)
        Me.Lblharga.Name = "Lblharga"
        Me.Lblharga.Size = New System.Drawing.Size(64, 22)
        Me.Lblharga.TabIndex = 7
        Me.Lblharga.Text = "label2"
        '
        'Hapus_JenisKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblharga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblConsole)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_JenisKamar"
        Me.Text = "Hapus_JenisKamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblConsole As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblharga As Label
End Class
