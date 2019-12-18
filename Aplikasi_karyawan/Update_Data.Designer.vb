<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Data))
        Me.btnupdate = New System.Windows.Forms.Button
        Me.cmbstatuskerja = New System.Windows.Forms.ComboBox
        Me.cmbstatuskaryawan = New System.Windows.Forms.ComboBox
        Me.txtpttrakhir = New System.Windows.Forms.TextBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.cmbpendidikanakhir = New System.Windows.Forms.ComboBox
        Me.cmbkewarganegaraan = New System.Windows.Forms.ComboBox
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.cmbagama = New System.Windows.Forms.ComboBox
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.txtjabatan = New System.Windows.Forms.TextBox
        Me.txtbagian = New System.Windows.Forms.TextBox
        Me.txtgaji = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.txttempatlahir = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.btnback = New System.Windows.Forms.Button
        Me.TextBoxnamagbr = New System.Windows.Forms.TextBox
        Me.LabelPath = New System.Windows.Forms.Label
        Me.ButtonPilih = New System.Windows.Forms.Button
        Me.PictureBoxGbr = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBoxGbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(517, 378)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(101, 33)
        Me.btnupdate.TabIndex = 79
        Me.btnupdate.Text = "    UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'cmbstatuskerja
        '
        Me.cmbstatuskerja.FormattingEnabled = True
        Me.cmbstatuskerja.Items.AddRange(New Object() {"KONTRAK", "TETAP"})
        Me.cmbstatuskerja.Location = New System.Drawing.Point(607, 291)
        Me.cmbstatuskerja.Name = "cmbstatuskerja"
        Me.cmbstatuskerja.Size = New System.Drawing.Size(152, 21)
        Me.cmbstatuskerja.TabIndex = 115
        '
        'cmbstatuskaryawan
        '
        Me.cmbstatuskaryawan.FormattingEnabled = True
        Me.cmbstatuskaryawan.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cmbstatuskaryawan.Location = New System.Drawing.Point(607, 249)
        Me.cmbstatuskaryawan.Name = "cmbstatuskaryawan"
        Me.cmbstatuskaryawan.Size = New System.Drawing.Size(152, 21)
        Me.cmbstatuskaryawan.TabIndex = 114
        '
        'txtpttrakhir
        '
        Me.txtpttrakhir.Location = New System.Drawing.Point(607, 84)
        Me.txtpttrakhir.Name = "txtpttrakhir"
        Me.txtpttrakhir.Size = New System.Drawing.Size(152, 20)
        Me.txtpttrakhir.TabIndex = 113
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(607, 165)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 112
        '
        'cmbpendidikanakhir
        '
        Me.cmbpendidikanakhir.FormattingEnabled = True
        Me.cmbpendidikanakhir.Items.AddRange(New Object() {"SD", "SMP", "SMA", "D1", "D2", "D3", "S1", "S2", "S3"})
        Me.cmbpendidikanakhir.Location = New System.Drawing.Point(607, 36)
        Me.cmbpendidikanakhir.Name = "cmbpendidikanakhir"
        Me.cmbpendidikanakhir.Size = New System.Drawing.Size(152, 21)
        Me.cmbpendidikanakhir.TabIndex = 111
        '
        'cmbkewarganegaraan
        '
        Me.cmbkewarganegaraan.FormattingEnabled = True
        Me.cmbkewarganegaraan.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.cmbkewarganegaraan.Location = New System.Drawing.Point(190, 241)
        Me.cmbkewarganegaraan.Name = "cmbkewarganegaraan"
        Me.cmbkewarganegaraan.Size = New System.Drawing.Size(152, 21)
        Me.cmbkewarganegaraan.TabIndex = 110
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"belum nikah", "nikah"})
        Me.cmbstatus.Location = New System.Drawing.Point(190, 208)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(152, 21)
        Me.cmbstatus.TabIndex = 109
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"islam", "katolik", "hindu", "budha", "konghucu", "ateis", "kristen"})
        Me.cmbagama.Location = New System.Drawing.Point(190, 173)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(152, 21)
        Me.cmbagama.TabIndex = 108
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(190, 365)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtalamat.Size = New System.Drawing.Size(197, 44)
        Me.txtalamat.TabIndex = 107
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(607, 125)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(152, 20)
        Me.txtjabatan.TabIndex = 106
        '
        'txtbagian
        '
        Me.txtbagian.Location = New System.Drawing.Point(607, 208)
        Me.txtbagian.Name = "txtbagian"
        Me.txtbagian.Size = New System.Drawing.Size(152, 20)
        Me.txtbagian.TabIndex = 105
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(607, 333)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(152, 20)
        Me.txtgaji.TabIndex = 104
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(190, 321)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(152, 20)
        Me.txtemail.TabIndex = 103
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(190, 279)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(152, 20)
        Me.txtnohp.TabIndex = 102
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(190, 103)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(152, 20)
        Me.txttempatlahir.TabIndex = 101
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(190, 69)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(152, 20)
        Me.txtnama.TabIndex = 100
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(466, 294)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 13)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "STATUS KERJA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(466, 252)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 13)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "STATUS KARYAWAN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(466, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "GAJI"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(466, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "BAGIAN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(466, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "TANGGAL MASUK"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(466, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "ID JABATAN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(466, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "PT TERAKHIR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(466, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "PENDIDIKAN TERAKHIR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "ALAMAT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "EMAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "NOMOR HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "KEWARGANEGARAAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "STATUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "AGAMA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "TANGGAL LAHIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "TEMPAT KELAHIRAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "NAMA"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(44, 39)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 82
        Me.label1.Text = "NIK"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 138)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 81
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(190, 36)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(152, 20)
        Me.txtnik.TabIndex = 80
        '
        'btnback
        '
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(658, 378)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(101, 33)
        Me.btnback.TabIndex = 116
        Me.btnback.Text = "    KEMBALI"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'TextBoxnamagbr
        '
        Me.TextBoxnamagbr.Location = New System.Drawing.Point(190, 435)
        Me.TextBoxnamagbr.Name = "TextBoxnamagbr"
        Me.TextBoxnamagbr.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxnamagbr.TabIndex = 125
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(187, 483)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(45, 13)
        Me.LabelPath.TabIndex = 124
        Me.LabelPath.Text = "Label19"
        '
        'ButtonPilih
        '
        Me.ButtonPilih.Image = CType(resources.GetObject("ButtonPilih.Image"), System.Drawing.Image)
        Me.ButtonPilih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPilih.Location = New System.Drawing.Point(190, 519)
        Me.ButtonPilih.Name = "ButtonPilih"
        Me.ButtonPilih.Size = New System.Drawing.Size(105, 29)
        Me.ButtonPilih.TabIndex = 123
        Me.ButtonPilih.Text = "     PILIH"
        Me.ButtonPilih.UseVisualStyleBackColor = True
        '
        'PictureBoxGbr
        '
        Me.PictureBoxGbr.Location = New System.Drawing.Point(38, 435)
        Me.PictureBoxGbr.Name = "PictureBoxGbr"
        Me.PictureBoxGbr.Size = New System.Drawing.Size(128, 186)
        Me.PictureBoxGbr.TabIndex = 122
        Me.PictureBoxGbr.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Update_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(847, 652)
        Me.Controls.Add(Me.TextBoxnamagbr)
        Me.Controls.Add(Me.LabelPath)
        Me.Controls.Add(Me.ButtonPilih)
        Me.Controls.Add(Me.PictureBoxGbr)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.cmbstatuskerja)
        Me.Controls.Add(Me.cmbstatuskaryawan)
        Me.Controls.Add(Me.txtpttrakhir)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.cmbpendidikanakhir)
        Me.Controls.Add(Me.cmbkewarganegaraan)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtbagian)
        Me.Controls.Add(Me.txtgaji)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.btnupdate)
        Me.Name = "Update_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edit_karyawan"
        CType(Me.PictureBoxGbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents cmbstatuskerja As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents txtpttrakhir As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbpendidikanakhir As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkewarganegaraan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtbagian As System.Windows.Forms.TextBox
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents TextBoxnamagbr As System.Windows.Forms.TextBox
    Friend WithEvents LabelPath As System.Windows.Forms.Label
    Friend WithEvents ButtonPilih As System.Windows.Forms.Button
    Friend WithEvents PictureBoxGbr As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
