<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.DataGridViewBooking = New System.Windows.Forms.DataGridView()
        Me.BtnAddBook = New System.Windows.Forms.Button()
        Me.BtnRemoveBook = New System.Windows.Forms.Button()
        Me.BtnEditBook = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBooking
        '
        Me.DataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBooking.Location = New System.Drawing.Point(44, 10)
        Me.DataGridViewBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewBooking.Name = "DataGridViewBooking"
        Me.DataGridViewBooking.RowHeadersWidth = 51
        Me.DataGridViewBooking.RowTemplate.Height = 24
        Me.DataGridViewBooking.Size = New System.Drawing.Size(889, 241)
        Me.DataGridViewBooking.TabIndex = 0
        '
        'BtnAddBook
        '
        Me.BtnAddBook.Location = New System.Drawing.Point(157, 285)
        Me.BtnAddBook.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddBook.Name = "BtnAddBook"
        Me.BtnAddBook.Size = New System.Drawing.Size(112, 28)
        Me.BtnAddBook.TabIndex = 1
        Me.BtnAddBook.Text = "Tambah Booking"
        Me.BtnAddBook.UseVisualStyleBackColor = True
        '
        'BtnRemoveBook
        '
        Me.BtnRemoveBook.Location = New System.Drawing.Point(355, 285)
        Me.BtnRemoveBook.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemoveBook.Name = "BtnRemoveBook"
        Me.BtnRemoveBook.Size = New System.Drawing.Size(68, 28)
        Me.BtnRemoveBook.TabIndex = 2
        Me.BtnRemoveBook.Text = "Remove"
        Me.BtnRemoveBook.UseVisualStyleBackColor = True
        '
        'BtnEditBook
        '
        Me.BtnEditBook.Location = New System.Drawing.Point(274, 285)
        Me.BtnEditBook.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditBook.Name = "BtnEditBook"
        Me.BtnEditBook.Size = New System.Drawing.Size(68, 28)
        Me.BtnEditBook.TabIndex = 3
        Me.BtnEditBook.Text = "Edit"
        Me.BtnEditBook.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 366)
        Me.Controls.Add(Me.BtnEditBook)
        Me.Controls.Add(Me.BtnRemoveBook)
        Me.Controls.Add(Me.BtnAddBook)
        Me.Controls.Add(Me.DataGridViewBooking)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Booking"
        Me.Text = "Booking"
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewBooking As DataGridView
    Friend WithEvents BtnAddBook As Button
    Friend WithEvents BtnRemoveBook As Button
    Friend WithEvents BtnEditBook As Button
End Class
