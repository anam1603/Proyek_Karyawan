<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Jabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Jabatan))
        Me.Buttonsimpan = New System.Windows.Forms.Button
        Me.Buttonhapus = New System.Windows.Forms.Button
        Me.Buttonupdate = New System.Windows.Forms.Button
        Me.Buttonkeluar = New System.Windows.Forms.Button
        Me.TextBoxjabatan = New System.Windows.Forms.TextBox
        Me.TextBoxgapok = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Image = CType(resources.GetObject("Buttonsimpan.Image"), System.Drawing.Image)
        Me.Buttonsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonsimpan.Location = New System.Drawing.Point(158, 193)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(88, 36)
        Me.Buttonsimpan.TabIndex = 0
        Me.Buttonsimpan.Text = "     SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Image = CType(resources.GetObject("Buttonhapus.Image"), System.Drawing.Image)
        Me.Buttonhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonhapus.Location = New System.Drawing.Point(411, 193)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(88, 36)
        Me.Buttonhapus.TabIndex = 1
        Me.Buttonhapus.Text = "     HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonupdate
        '
        Me.Buttonupdate.Image = CType(resources.GetObject("Buttonupdate.Image"), System.Drawing.Image)
        Me.Buttonupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonupdate.Location = New System.Drawing.Point(288, 193)
        Me.Buttonupdate.Name = "Buttonupdate"
        Me.Buttonupdate.Size = New System.Drawing.Size(88, 36)
        Me.Buttonupdate.TabIndex = 2
        Me.Buttonupdate.Text = "   EDIT"
        Me.Buttonupdate.UseVisualStyleBackColor = True
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Image = CType(resources.GetObject("Buttonkeluar.Image"), System.Drawing.Image)
        Me.Buttonkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonkeluar.Location = New System.Drawing.Point(526, 193)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(88, 36)
        Me.Buttonkeluar.TabIndex = 3
        Me.Buttonkeluar.Text = "     KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'TextBoxjabatan
        '
        Me.TextBoxjabatan.Location = New System.Drawing.Point(163, 73)
        Me.TextBoxjabatan.Name = "TextBoxjabatan"
        Me.TextBoxjabatan.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxjabatan.TabIndex = 4
        '
        'TextBoxgapok
        '
        Me.TextBoxgapok.Location = New System.Drawing.Point(163, 129)
        Me.TextBoxgapok.Name = "TextBoxgapok"
        Me.TextBoxgapok.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxgapok.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NAMA JABATAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "GAJI POKOK"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 251)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(690, 199)
        Me.DataGridView1.TabIndex = 8
        '
        'Form_Jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(823, 486)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxgapok)
        Me.Controls.Add(Me.TextBoxjabatan)
        Me.Controls.Add(Me.Buttonkeluar)
        Me.Controls.Add(Me.Buttonupdate)
        Me.Controls.Add(Me.Buttonhapus)
        Me.Controls.Add(Me.Buttonsimpan)
        Me.Name = "Form_Jabatan"
        Me.Text = "Form_Jabatan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buttonsimpan As System.Windows.Forms.Button
    Friend WithEvents Buttonhapus As System.Windows.Forms.Button
    Friend WithEvents Buttonupdate As System.Windows.Forms.Button
    Friend WithEvents Buttonkeluar As System.Windows.Forms.Button
    Friend WithEvents TextBoxjabatan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxgapok As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
