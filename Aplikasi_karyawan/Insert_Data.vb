Imports System.Data.Odbc
Public Class Insert_Data
    Private PathFile As String = Nothing
    Sub kosongkan()
        txtnik.Clear()
        txtnama.Clear()
        txttempatlahir.Clear()
        DateTimePicker1.Text = ""
        cmbagama.Text = ""
        cmbstatus.Text = ""
        cmbkewarganegaraan.Text = ""
        txtnohp.Clear()
        txtemail.Clear()
        txtalamat.Clear()
        cmbpendidikanakhir.Text = ""
        txtpttrakhir.Clear()
        txtjabatan.Clear()
        DateTimePicker2.Text = ""
        txtbagian.Clear()
        txtgaji.Clear()
        cmbstatuskaryawan.Text = ""
        cmbstatuskerja.Text = ""

    End Sub
    Private Sub BTNSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Call konek()
        'strcon = "INSERT INTO t_karyawan " _
        '+ "VALUES ('" & txtnik.Text & "'," _
        '+ "'" & txtnama.Text & "'," _
        '+ "'" & txttempatlahir.Text & "'," _
        '+ "'" & DateTimePicker1.Text & "'," _
        '+ "'" & cmbagama.Text & "'," _
        '+ "'" & cmbstatus.Text & "'," _
        '+ "'" & cmbkewarganegaraan.Text & "'," _
        '+ "'" & txtnohp.Text & "'," _
        '+ "'" & txtemail.Text & "'," _
        '+ "'" & txtalamat.Text & "'," _
        '+ "'" & cmbpendidikanakhir.Text & "'," _
        '+ "'" & txtpttrakhir.Text & "'," _
        '+ "'" & txtjabatan.Text & "'," _
        '+ "'" & DateTimePicker2.Text & "'," _
        '+ "'" & txtbagian.Text & "'," _
        '+ "'" & cmbstatuskaryawan.Text & "'," _
        '+ "'" & cmbstatuskerja.Text & "'," _
        '+ "'" & txtgaji.Text & "')"
        'MsgBox(strcon)
        'Dim cmd As New Odbc.OdbcCommand
        'cmd.Connection = conn
        'cmd.CommandText = strcon
        'cmd.ExecuteNonQuery()
        'conn.Close()
        'MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly)
        'kosongkan()

        Try
            strcon = "Insert into t_karyawan(nik,nama,tempat_lahir,tgl_lahir,agama,status,kewarganegaraan,no_hp,email,alamat,pendidikan_terakhir,pt_terakhir,jabatan,tgl_masuk,bagian,status_karyawan,status_kerja,gaji,nama_gambar,lokasi_gambar)values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
            With mycomm.Parameters
                .Add("?", OdbcType.VarChar, 15).Value = txtnik.Text.Trim
                .Add("?", OdbcType.VarChar, 30).Value = txtnama.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txttempatlahir.Text.Trim
                .Add("?", OdbcType.Date).Value = DateTimePicker1.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbagama.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatus.Text.Trim
                .Add("?", OdbcType.VarChar, 3).Value = cmbkewarganegaraan.Text.Trim
                .Add("?", OdbcType.VarChar, 13).Value = txtnohp.Text.Trim
                .Add("?", OdbcType.VarChar, 25).Value = txtemail.Text.Trim
                .Add("?", OdbcType.VarChar, 35).Value = txtalamat.Text.Trim
                .Add("?", OdbcType.VarChar, 4).Value = cmbpendidikanakhir.Text.Trim
                .Add("?", OdbcType.VarChar, 40).Value = txtpttrakhir.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtjabatan.Text.Trim
                .Add("?", OdbcType.Date).Value = DateTimePicker2.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtbagian.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatuskaryawan.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatuskerja.Text.Trim
                .Add("?", OdbcType.VarChar, 10).Value = txtgaji.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = TextBoxnamagbr.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = LabelPath.Text.Trim
            End With

            mycomm.ExecuteNonQuery()
            mycomm = Nothing
            MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        da.Fill(ds, "t_karyawan")
        Form1.DataGridView1.DataSource = ds.Tables("t_karyawan")
        Form1.DataGridView1.ReadOnly = True
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        Form1.Show()
        Call datauser()
    End Sub

    Private Sub Insert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPilih.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg| JPEG Files(*.jpeg)|*.jpeg| GIF Files(*.gif)|*.gif| PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxGbr.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBoxGbr.Image = New Bitmap(OpenFileDialog1.FileName)
            ButtonPilih.Enabled = True
            PathFile = OpenFileDialog1.FileName
            TextBoxnamagbr.Text = PathFile.Substring(PathFile.LastIndexOf("/") + 1)
            LabelPath.Text = OpenFileDialog1.FileName
            PictureBoxGbr.Image = Image.FromFile(LabelPath.Text)
        End If
        PictureBoxGbr.Visible = True
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class