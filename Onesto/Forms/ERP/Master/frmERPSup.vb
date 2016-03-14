Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmERPSup
    Private ListView1Sorter As lvColumnSorter
    Dim strConnection As String = My.Settings.ConnStr
    Dim cn As SqlConnection = New SqlConnection(strConnection)
    Dim cmd As SqlCommand
    Dim flag As Integer

    Private Sub frmERPSup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flag = 0 Then
            If MsgBox("Data belum tersimpan, Anda yakin mau menutup form ini?", vbYesNo + vbCritical, Me.Text) = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmERPSup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clear_obj()
        lock_obj(True)
        clear_lvw()

        If ListView1.Items.Count > 0 Then
            ListView1.Items.Item(0).Selected = True
            ListView1_Click(sender, e)
        End If
    End Sub
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If flag = 0 And btnAdd.Enabled = False Then lock_obj(True)
        With ListView1.SelectedItems.Item(0)
            flag = 1
            txtKodeSup.Text = .SubItems.Item(0).Text
            txtNamaSup.Text = .SubItems.Item(1).Text
            txtAlamatSup.Text = .SubItems.Item(2).Text
            txtTelpSup.Text = .SubItems.Item(3).Text
            txtKontakSup.Text = .SubItems.Item(4).Text

        End With
    End Sub
    Sub clear_lvw()
        With ListView1
            .Clear()
            .View = View.Details
            .Columns.Add("Kode Supplier", 100)
            .Columns.Add("Nama Supplier", 150)
            .Columns.Add("Alamat Supplier", 150)
            .Columns.Add("Telp Supplier", 150)
            .Columns.Add("Kontak Person", 150)
        End With

        cmd = New SqlCommand("select sup_id,sup_name,sup_addr,sup_telp,sup_cp from erp_mt_sup where active = 1", cn)

        cn.Open()

        Dim myReader As SqlDataReader = cmd.ExecuteReader()

        Dim lvItem As ListViewItem
        Dim intCurrRow As Integer

        While myReader.Read
            lvItem = New ListViewItem(CStr(myReader.Item(0)))
            lvItem.Tag = intCurrRow 'ID

            lvItem.SubItems.Add(myReader.Item(1))
            lvItem.SubItems.Add(myReader.Item(2))
            lvItem.SubItems.Add(myReader.Item(3))
            lvItem.SubItems.Add(myReader.Item(4))

            If intCurrRow Mod 2 = 0 Then
                lvItem.BackColor = Color.Lavender
            Else
                lvItem.BackColor = Color.White
            End If
            lvItem.UseItemStyleForSubItems = True

            ListView1.Items.Add(lvItem)
            intCurrRow += 1
        End While

        myReader.Close()
        cn.Close()
    End Sub

    Sub clear_obj()
        flag = 0
        txtKodeSup.Text = ""
        txtNamaSup.Text = ""
        txtAlamatSup.Text = ""
        txtTelpSup.Text = ""
        txtKontakSup.Text = ""
    End Sub

    Sub lock_obj(ByVal isLock As Boolean)
        txtKodeSup.ReadOnly = isLock
        txtNamaSup.ReadOnly = isLock
        txtAlamatSup.ReadOnly = isLock
        txtTelpSup.ReadOnly = isLock
        txtKontakSup.ReadOnly = isLock

        btnEdit.Enabled = isLock
        btnAdd.Enabled = isLock
        btnSave.Enabled = Not isLock
        btnCancel.Enabled = Not isLock

        If flag = 0 Then
            txtKodeSup.ReadOnly = isLock
            btnDelete.Enabled = False
        Else
            txtKodeSup.ReadOnly = True
            btnDelete.Enabled = Not isLock
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        clear_obj()
        clear_lvw()
        lock_obj(False)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lock_obj(False)
        If flag <> 0 Then txtKodeSup.ReadOnly = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lock_obj(True)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKodeSup.Text = "" Then
            MsgBox("Kode receipt tidak boleh kosong!", vbCritical + vbOKOnly, Me.Text)
            txtKodeSup.Focus()
            Exit Sub
        End If

        If txtNamaSup.Text = "" Then
            MsgBox("Nama receipt tidak boleh kosong!", vbCritical + vbOKOnly, Me.Text)
            txtNamaSup.Focus()
            Exit Sub
        End If

        Try
            cmd = New SqlCommand(IIf(flag = 0, "sp_erp_mt_sup_INS", "sp_erp_mt_sup_UPD"), cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim prm2 As SqlParameter = cmd.Parameters.Add("@sup_id", SqlDbType.Int)
            prm2.Value = txtKodeSup.Text
            Dim prm3 As SqlParameter = cmd.Parameters.Add("@sup_name", SqlDbType.NVarChar, 50)
            prm3.Value = txtNamaSup.Text
            Dim prm4 As SqlParameter = cmd.Parameters.Add("@sup_addr", SqlDbType.NVarChar, 100)
            prm4.Value = txtAlamatSup.Text
            Dim prm5 As SqlParameter = cmd.Parameters.Add("@sup_telp", SqlDbType.NVarChar, 50)
            prm5.Value = txtTelpSup.Text
            Dim prm6 As SqlParameter = cmd.Parameters.Add("@sup_cp", SqlDbType.NVarChar, 50)
            prm6.Value = txtKontakSup.Text
            Dim prm10 As SqlParameter = cmd.Parameters.Add("@user_code", SqlDbType.NVarChar, 50)
            prm10.Value = My.Settings.UserName

            cn.Open()
            cmd.ExecuteReader()
            cn.Close()

            clear_lvw()
            lock_obj(True)
            flag = 1
        Catch ex As Exception
            If ConnectionState.Open = True Then cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If flag <> 0 Then
            If MsgBox("Anda yakin menghapus?", vbYesNo + vbCritical, Me.Text) = vbYes Then
                'Dim temp As String = "UPDATE erp_mt_sup SET active = 0, submit = '" + My.Settings.UserName + "' WHERE sup_id = " + txtKodeSup.Text
                'MsgBox(temp)
                'Exit Sub

                Try
                    cmd = New SqlCommand("UPDATE erp_mt_sup SET active = 0, timelog = GETDATE(), submit = '" + My.Settings.UserName + "' WHERE sup_id = " + txtKodeSup.Text, cn)

                    cn.Open()
                    cmd.ExecuteReader()
                    cn.Close()

                    clear_obj()
                    btnAdd_Click(sender, e)
                Catch ex As Exception
                    MsgBox("Error Message : " + ex.Message)
                    If ConnectionState.Open = True Then cn.Close()
                End Try
            End If
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListView1Sorter = New lvColumnSorter()
        ListView1.ListViewItemSorter = ListView1Sorter
    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        If (e.Column = ListView1Sorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (ListView1Sorter.Order = Windows.Forms.SortOrder.Ascending) Then
                ListView1Sorter.Order = Windows.Forms.SortOrder.Descending
            Else
                ListView1Sorter.Order = Windows.Forms.SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            ListView1Sorter.SortColumn = e.Column
            ListView1Sorter.Order = Windows.Forms.SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        ListView1.Sort()
    End Sub

End Class