<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Tamu
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNamaTamu = New System.Windows.Forms.Label()
        Me.BtnHapusTamu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Menghapus Data Tamu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apakah Anda ingin menhapus data ini?"
        '
        'LblNamaTamu
        '
        Me.LblNamaTamu.AutoSize = True
        Me.LblNamaTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaTamu.ForeColor = System.Drawing.Color.Black
        Me.LblNamaTamu.Location = New System.Drawing.Point(219, 154)
        Me.LblNamaTamu.Name = "LblNamaTamu"
        Me.LblNamaTamu.Size = New System.Drawing.Size(109, 20)
        Me.LblNamaTamu.TabIndex = 2
        Me.LblNamaTamu.Text = "Nama Tamu"
        '
        'BtnHapusTamu
        '
        Me.BtnHapusTamu.BackColor = System.Drawing.Color.Red
        Me.BtnHapusTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusTamu.ForeColor = System.Drawing.Color.White
        Me.BtnHapusTamu.Location = New System.Drawing.Point(213, 215)
        Me.BtnHapusTamu.Name = "BtnHapusTamu"
        Me.BtnHapusTamu.Size = New System.Drawing.Size(114, 33)
        Me.BtnHapusTamu.TabIndex = 3
        Me.BtnHapusTamu.Text = "Hapus"
        Me.BtnHapusTamu.UseVisualStyleBackColor = False
        '
        'Hapus_Tamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 282)
        Me.Controls.Add(Me.BtnHapusTamu)
        Me.Controls.Add(Me.LblNamaTamu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Tamu"
        Me.Text = "Hapus_Tamu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNamaTamu As Label
    Friend WithEvents BtnHapusTamu As Button
End Class
