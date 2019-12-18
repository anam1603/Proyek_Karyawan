Public Class Form_lembur

    Private Sub Form_lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from lembur", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "lembur")
        DataGridView1.DataSource = (ds.Tables("lembur"))

        Call jabatan()
        Call nik()
    End Sub
    Sub jabatan()
        'da = New Odbc.OdbcDataAdapter("select id_jabatan from jabatan", conn)
        'ds = New DataSet
        'da.Fill(ds, "jabatan")

        'ComboBoxidjabat.DataSource = (ds.Tables("jabatan"))
        'ComboBoxidjabat.ValueMember = "id_jabatan"
        'ComboBoxidjabat.DisplayMember = "id_jabatan"



        strcon = "select id_jabatan from jabatan"
        cmd = New Odbc.OdbcCommand(strcon, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBoxidjabat.Items.Add(rd("id_jabatan"))
            Loop
        End If

    End Sub
    Sub nik()
        strcon = "select nik from t_karyawan"
        cmd = New Odbc.OdbcCommand(strcon, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBoxnik.Items.Add(rd("nik"))
            Loop
        End If
    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select * from lembur", conn)
        ds = New DataSet
        da.Fill(ds, "lembur")
        DataGridView1.DataSource = ds.Tables("lembur")
        DataGridView1.ReadOnly = True
    End Sub
    Sub kosongkan()
        ComboBoxnik.Text = ""
        TextBoxnamakar.Clear()
        ComboBoxidjabat.Text = ""
        DateTimePicker1.Text = ""
        TextBoxjamlem.Clear()
        TextBoxuanglem.Clear()
        TextBoxttllem.Clear()
    End Sub
    Private Sub form_edit(ByVal x As Integer)
        Try
            ComboBoxnik.Text = DataGridView1.Rows(x).Cells(1).Value
            TextBoxnamakar.Text = DataGridView1.Rows(x).Cells(2).Value
            ComboBoxidjabat.Text = DataGridView1.Rows(x).Cells(3).Value
            DateTimePicker1.Text = DataGridView1.Rows(x).Cells(4).Value
            TextBoxjamlem.Text = DataGridView1.Rows(x).Cells(5).Value
            TextBoxuanglem.Text = DataGridView1.Rows(x).Cells(6).Value
            TextBoxttllem.Text = DataGridView1.Rows(x).Cells(7).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        form_edit(e.RowIndex)
    End Sub

    Private Sub Buttonsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsave.Click
        Call konek()
        strcon = "INSERT INTO lembur " _
        + "VALUES ('','" & ComboBoxnik.Text & "'," _
        + "'" & TextBoxnamakar.Text & "'," _
        + "'" & ComboBoxidjabat.Text & "'," _
        + "'" & DateTimePicker1.Text & "'," _
        + "'" & TextBoxjamlem.Text & "'," _
        + "'" & TextBoxuanglem.Text & "'," _
        + "'" & TextBoxttllem.Text & "')"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly)
        kosongkan()
    End Sub

    Private Sub Buttonedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonedit.Click
        Call konek()
        strcon = "UPDATE gaji SET nik = '" & ComboBoxnik.Text & "'," & _
        "nama_karyawan = '" & TextBoxnamakar.Text & "'," & _
        "id_jabatan = '" & ComboBoxidjabat.Text & "'," & _
        "tgl_lembur = '" & DateTimePicker1.Text & "'," & _
        "jml_lembur = '" & TextBoxjamlem.Text & "'," & _
        "uang_lembur = '" & TextBoxuanglem.Text & "'," & _
        "ttl_uang_lembur = '" & TextBoxttllem.Text & "'," & _
        "WHERE id_lembur = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        MsgBox("Data Berhasil Diupdate", MsgBoxStyle.OkOnly)
        kosongkan()
    End Sub

    Private Sub Buttondel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondel.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM lembur WHERE id_lembur = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

            Dim cmd As New Odbc.OdbcCommand
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            conn.Close()

            Call datauser()
            MsgBox("Data Sudah Dihapus", vbInformation)
        Else
        End If
    End Sub

    Private Sub ComboBoxnik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxnik.SelectedIndexChanged
        cmd = New Odbc.OdbcCommand("SELECT nama, id_jabatan from t_karyawan WHERE nik = '" & ComboBoxnik.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBoxnamakar.Text = rd(0).ToString
            ComboBoxidjabat.Text = rd(1).ToString
        End If
    End Sub

    Private Sub TextBoxuanglem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxuanglem.TextChanged

        TextBoxttllem.Text = Val(TextBoxjamlem.Text) * Val(TextBoxuanglem.Text)

    End Sub

    Private Sub TextBoxjamlem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxjamlem.TextChanged
        TextBoxttllem.Text = Val(TextBoxjamlem.Text) * Val(TextBoxuanglem.Text)
    End Sub

    Private Sub ComboBoxidjabat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxidjabat.SelectedIndexChanged

    End Sub
End Class