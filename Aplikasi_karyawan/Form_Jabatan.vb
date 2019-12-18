Public Class Form_Jabatan

    Private Sub Form_Jabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        TextBoxjabatan.Focus()
        da = New Odbc.OdbcDataAdapter("select * from jabatan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jabatan")
        DataGridView1.DataSource = (ds.Tables("jabatan"))

    End Sub
    Sub kosongkan()
        TextBoxjabatan.Clear()
        TextBoxgapok.Clear()
    End Sub
    Sub datauser()

        da = New Odbc.OdbcDataAdapter("select * from jabatan", conn)
        ds = New DataSet
        da.Fill(ds, "jabatan")
        DataGridView1.DataSource = ds.Tables("jabatan")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Buttonsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsimpan.Click
        Call konek()
        If TextBoxjabatan.Text = "" Or TextBoxgapok.Text = "" Then
            MsgBox("Data Harus Diisi", MsgBoxStyle.OkOnly)
        Else
            strcon = "select * from jabatan WHERE nama_jabatan = '" & TextBoxjabatan.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                strcon = "INSERT INTO jabatan " _
                + "VALUES ('','" & TextBoxjabatan.Text & "'," _
                + "'" & TextBoxgapok.Text & "')"
                cmd = New Odbc.OdbcCommand(strcon, conn)
                cmd.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Call kosongkan()
                Call datauser()
            Else
                MsgBox("Data Sudah Ada", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Call kosongkan()
            End If
        End If

    End Sub

    Private Sub Buttonhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhapus.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM jabatan WHERE id_jabatan = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

            Dim cmd As New Odbc.OdbcCommand
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            conn.Close()

            Call datauser()
            MsgBox("Data Sudah Dihapus", vbInformation)
            Call kosongkan()
        Else
        End If
    End Sub

    Private Sub Buttonupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonupdate.Click
        Call konek()
        Dim id As String
        id = DataGridView1.CurrentRow.Cells(0).Value.ToString
        strcon = "UPDATE jabatan SET nama_jabatan='" & TextBoxjabatan.Text & "'," & _
                "gaji_pokok = '" & TextBoxgapok.Text & "'" & _
                "WHERE id_jabatan ='" & id & "'"

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        Call datauser()
        MsgBox("Data Sudah Diupdate", MsgBoxStyle.Information)
        Call kosongkan()
    End Sub
    Private Sub form_edit(ByVal x As Integer)
        Try
            TextBoxjabatan.Text = DataGridView1.Rows(x).Cells(1).Value
            TextBoxgapok.Text = DataGridView1.Rows(x).Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        form_edit(e.RowIndex)
    End Sub
    

    Private Sub TextBoxjabatan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxjabatan.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class