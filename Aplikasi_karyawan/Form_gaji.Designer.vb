<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_gaji
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_gaji))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxnoslip = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxnamajabat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxgapok = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxtunjang = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxlembur = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxbpjskes = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxbpjsket = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxpotlain = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBoxnorek = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBoxnamarek = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBoxbank = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxtotal = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxidjabat = New System.Windows.Forms.ComboBox
        Me.TextBoxnik = New System.Windows.Forms.TextBox
        Me.Buttonkeluar = New System.Windows.Forms.Button
        Me.Buttonupdate = New System.Windows.Forms.Button
        Me.Buttonhapus = New System.Windows.Forms.Button
        Me.Buttonsimpan = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMOR SLIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIK"
        '
        'TextBoxnoslip
        '
        Me.TextBoxnoslip.Location = New System.Drawing.Point(164, 68)
        Me.TextBoxnoslip.Name = "TextBoxnoslip"
        Me.TextBoxnoslip.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxnoslip.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "TGL GAJIAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "ID JABATAN"
        '
        'TextBoxnamajabat
        '
        Me.TextBoxnamajabat.Location = New System.Drawing.Point(164, 204)
        Me.TextBoxnamajabat.Name = "TextBoxnamajabat"
        Me.TextBoxnamajabat.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxnamajabat.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "NAMA JABATAN"
        '
        'TextBoxgapok
        '
        Me.TextBoxgapok.Location = New System.Drawing.Point(454, 64)
        Me.TextBoxgapok.Name = "TextBoxgapok"
        Me.TextBoxgapok.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxgapok.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "GAJI POKOK"
        '
        'TextBoxtunjang
        '
        Me.TextBoxtunjang.Location = New System.Drawing.Point(454, 102)
        Me.TextBoxtunjang.Name = "TextBoxtunjang"
        Me.TextBoxtunjang.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxtunjang.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(351, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "TUNJANGAN"
        '
        'TextBoxlembur
        '
        Me.TextBoxlembur.Location = New System.Drawing.Point(454, 136)
        Me.TextBoxlembur.Name = "TextBoxlembur"
        Me.TextBoxlembur.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxlembur.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "LEMBUR"
        '
        'TextBoxbpjskes
        '
        Me.TextBoxbpjskes.Location = New System.Drawing.Point(454, 169)
        Me.TextBoxbpjskes.Name = "TextBoxbpjskes"
        Me.TextBoxbpjskes.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxbpjskes.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "POT BPJS KES"
        '
        'TextBoxbpjsket
        '
        Me.TextBoxbpjsket.Location = New System.Drawing.Point(454, 204)
        Me.TextBoxbpjsket.Name = "TextBoxbpjsket"
        Me.TextBoxbpjsket.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxbpjsket.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "POT BPJS KET"
        '
        'TextBoxpotlain
        '
        Me.TextBoxpotlain.Location = New System.Drawing.Point(731, 69)
        Me.TextBoxpotlain.Name = "TextBoxpotlain"
        Me.TextBoxpotlain.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxpotlain.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(629, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "POT LAIN"
        '
        'TextBoxnorek
        '
        Me.TextBoxnorek.Location = New System.Drawing.Point(731, 103)
        Me.TextBoxnorek.Name = "TextBoxnorek"
        Me.TextBoxnorek.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxnorek.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(629, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "NO REKENING"
        '
        'TextBoxnamarek
        '
        Me.TextBoxnamarek.Location = New System.Drawing.Point(731, 137)
        Me.TextBoxnamarek.Name = "TextBoxnamarek"
        Me.TextBoxnamarek.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxnamarek.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(629, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "NAMA REKENING"
        '
        'TextBoxbank
        '
        Me.TextBoxbank.Location = New System.Drawing.Point(731, 170)
        Me.TextBoxbank.Name = "TextBoxbank"
        Me.TextBoxbank.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxbank.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(629, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "NAMA BANK"
        '
        'TextBoxtotal
        '
        Me.TextBoxtotal.Location = New System.Drawing.Point(731, 204)
        Me.TextBoxtotal.Name = "TextBoxtotal"
        Me.TextBoxtotal.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxtotal.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(629, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "TOTAL GAJI"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 342)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(839, 186)
        Me.DataGridView1.TabIndex = 47
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(164, 136)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 20)
        Me.DateTimePicker1.TabIndex = 48
        '
        'ComboBoxidjabat
        '
        Me.ComboBoxidjabat.FormattingEnabled = True
        Me.ComboBoxidjabat.Location = New System.Drawing.Point(164, 170)
        Me.ComboBoxidjabat.Name = "ComboBoxidjabat"
        Me.ComboBoxidjabat.Size = New System.Drawing.Size(135, 21)
        Me.ComboBoxidjabat.TabIndex = 50
        '
        'TextBoxnik
        '
        Me.TextBoxnik.Location = New System.Drawing.Point(164, 103)
        Me.TextBoxnik.Name = "TextBoxnik"
        Me.TextBoxnik.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxnik.TabIndex = 51
        '
        'Buttonkeluar
        '
        Me.Buttonkeluar.Image = CType(resources.GetObject("Buttonkeluar.Image"), System.Drawing.Image)
        Me.Buttonkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonkeluar.Location = New System.Drawing.Point(574, 284)
        Me.Buttonkeluar.Name = "Buttonkeluar"
        Me.Buttonkeluar.Size = New System.Drawing.Size(88, 36)
        Me.Buttonkeluar.TabIndex = 55
        Me.Buttonkeluar.Text = "     KELUAR"
        Me.Buttonkeluar.UseVisualStyleBackColor = True
        '
        'Buttonupdate
        '
        Me.Buttonupdate.Image = CType(resources.GetObject("Buttonupdate.Image"), System.Drawing.Image)
        Me.Buttonupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonupdate.Location = New System.Drawing.Point(294, 284)
        Me.Buttonupdate.Name = "Buttonupdate"
        Me.Buttonupdate.Size = New System.Drawing.Size(88, 36)
        Me.Buttonupdate.TabIndex = 54
        Me.Buttonupdate.Text = "   EDIT"
        Me.Buttonupdate.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Image = CType(resources.GetObject("Buttonhapus.Image"), System.Drawing.Image)
        Me.Buttonhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonhapus.Location = New System.Drawing.Point(433, 284)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(88, 36)
        Me.Buttonhapus.TabIndex = 53
        Me.Buttonhapus.Text = "     HAPUS"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.Image = CType(resources.GetObject("Buttonsimpan.Image"), System.Drawing.Image)
        Me.Buttonsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buttonsimpan.Location = New System.Drawing.Point(164, 284)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(88, 36)
        Me.Buttonsimpan.TabIndex = 52
        Me.Buttonsimpan.Text = "     SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'Form_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(966, 565)
        Me.Controls.Add(Me.Buttonkeluar)
        Me.Controls.Add(Me.Buttonupdate)
        Me.Controls.Add(Me.Buttonhapus)
        Me.Controls.Add(Me.Buttonsimpan)
        Me.Controls.Add(Me.TextBoxnik)
        Me.Controls.Add(Me.ComboBoxidjabat)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxtotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBoxbank)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBoxnamarek)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBoxnorek)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxpotlain)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxbpjsket)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxbpjskes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxlembur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxtunjang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxgapok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxnamajabat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxnoslip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_gaji"
        Me.Text = "Form_gaji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnoslip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnamajabat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxgapok As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxtunjang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxlembur As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxbpjskes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxbpjsket As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxpotlain As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnorek As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnamarek As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxbank As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxidjabat As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxnik As System.Windows.Forms.TextBox
    Friend WithEvents Buttonkeluar As System.Windows.Forms.Button
    Friend WithEvents Buttonupdate As System.Windows.Forms.Button
    Friend WithEvents Buttonhapus As System.Windows.Forms.Button
    Friend WithEvents Buttonsimpan As System.Windows.Forms.Button
End Class
