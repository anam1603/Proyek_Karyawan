Imports System.Data.Odbc
Public Class Form_Absensi
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Labeltgsekarang.Text = Format(Now, "yyyy-MM-dd")
        LabelJamsekarang.Text = Format(Now, "HH:mm:ss")
    End Sub
    Sub telat()
        Dim a, b, c As String
        a = Format(Now, "HH:mm:ss")
        b = "07:00:00"
        c = b - a
    End Sub

    Private Sub TextBoxNIK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNIK.KeyPress
        Dim jammasuk, jamkerja, tgl As String
        Dim jam_masuk, jam_kerja As DateTime
        Dim jampulang, jam_pulang As DateTime
        Dim a1, a2 As String

        If (e.KeyChar = Chr(13)) Then


            Call konek()
            strcon = "Select * from t_karyawan where nik = '" & TextBoxNIK.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                LabelNIK.Text = rd.Item("nik")
                PictureBox1.ImageLocation = rd.Item("lokasi_gambar")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                jammasuk = Format(Now, "HH:mm:ss")
                jamkerja = "07:00:00"
                jampulang = "17:00:00"
                tgl = Format(Now, "yyyy-MM-dd")
                jam_pulang = Format(Now, "HH:mm:ss")
                jam_masuk = Format(Now, "HH:mm:ss")
                jam_kerja = "07:00:00"

                a1 = Format(Now, "HH:mm:ss")
                a2 = "17:00:00"



                Dim selisih As TimeSpan = New TimeSpan
                selisih = jam_masuk - jam_kerja
                LabelInfo.Text = selisih.ToString
                Dim telat_pulang As TimeSpan = New TimeSpan
                telat_pulang = jam_pulang - jampulang

                strcon = "insert into absen(id_absen,nik,jam_masuk,jam_kerja,tgl_kerja,jam_pulang,telat_masuk,jam_lembur)values(?,?,?,?,?,?,?,?)"
                Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
                With mycomm.Parameters
                    .Add("?", OdbcType.VarChar, 20).Value = Microsoft.VisualBasic.Left(TextBoxNIK.Text, 3) & Format(Now, "yyMMdd-HHmmss")
                    .Add("?", OdbcType.VarChar, 20).Value = TextBoxNIK.Text.Trim
                    .Add("?", OdbcType.VarChar, 20).Value = jammasuk
                    .Add("?", OdbcType.VarChar, 20).Value = jamkerja
                    .Add("?", OdbcType.Date).Value = tgl
                    .Add("?", OdbcType.VarChar, 15).Value = a2
                    .Add("?", OdbcType.VarChar, 20).Value = selisih.ToString
                    .Add("?", OdbcType.VarChar, 20).Value = telat_pulang.ToString
                End With
                mycomm.ExecuteNonQuery()
                mycomm = Nothing
                MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")

            Else
                TextBoxNIK.Clear()
                PictureBox1.Hide()
            End If
            PictureBox1.Visible = True
        End If
    End Sub
    Private Sub TextBoxNIK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNIK.TextChanged

    End Sub

    Private Sub Form_Absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class