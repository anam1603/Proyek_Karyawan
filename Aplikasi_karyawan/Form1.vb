Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = (ds.Tables("t_karyawan"))
        Me.ContextMenuStrip = ContextMenuStrip1
    End Sub
    Sub datauser()
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * t_karyawan", conn)
        ds = New DataSet
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = ds.Tables("t_karyawan")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub form_edit(ByVal x As Integer)
        Try
            Update_Data.txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
            Update_Data.txtnama.Text = DataGridView1.Rows(x).Cells(1).Value
            Update_Data.txttempatlahir.Text = DataGridView1.Rows(x).Cells(2).Value
            Update_Data.DateTimePicker1.Text = DataGridView1.Rows(x).Cells(3).Value
            Update_Data.cmbagama.Text = DataGridView1.Rows(x).Cells(4).Value
            Update_Data.cmbstatus.Text = DataGridView1.Rows(x).Cells(5).Value
            Update_Data.cmbkewarganegaraan.Text = DataGridView1.Rows(x).Cells(6).Value
            Update_Data.txtnohp.Text = DataGridView1.Rows(x).Cells(7).Value
            Update_Data.txtemail.Text = DataGridView1.Rows(x).Cells(8).Value
            Update_Data.txtalamat.Text = DataGridView1.Rows(x).Cells(9).Value
            Update_Data.cmbpendidikanakhir.Text = DataGridView1.Rows(x).Cells(10).Value
            Update_Data.txtpttrakhir.Text = DataGridView1.Rows(x).Cells(11).Value
            Update_Data.txtjabatan.Text = DataGridView1.Rows(x).Cells(12).Value
            Update_Data.DateTimePicker2.Text = DataGridView1.Rows(x).Cells(13).Value
            Update_Data.txtbagian.Text = DataGridView1.Rows(x).Cells(14).Value
            Update_Data.cmbstatuskaryawan.Text = DataGridView1.Rows(x).Cells(15).Value
            Update_Data.cmbstatuskerja.Text = DataGridView1.Rows(x).Cells(16).Value
            Update_Data.txtgaji.Text = DataGridView1.Rows(x).Cells(17).Value
            Update_Data.TextBoxnamagbr.Text = DataGridView1.Rows(x).Cells(18).Value
            Update_Data.LabelPath.Text = DataGridView1.Rows(x).Cells(19).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        form_edit(e.RowIndex)
        Me.Visible = False
        Update_Data.Show()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Me.Visible = False
        Insert_Data.Show()
    End Sub

    Private Sub Menu1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu1ToolStripMenuItem.Click

        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM t_karyawan WHERE nik = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

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

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
