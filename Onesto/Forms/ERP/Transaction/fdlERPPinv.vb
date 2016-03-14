Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class fdlERPPinv

    Private ListView1Sorter As lvColumnSorter
    Dim strConnection As String = My.Settings.ConnStr
    Dim cn As SqlConnection = New SqlConnection(strConnection)
    Dim cmd As SqlCommand
    Dim m_FrmCallerId As String

    Public Property FrmCallerId() As String
        Get
            Return m_FrmCallerId
        End Get
        Set(ByVal Value As String)
            m_FrmCallerId = Value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
        If ListView1.SelectedItems.Count > 0 Then
            ListView1_DoubleClick(sender, e)
        Else
            MessageBox.Show("Silahkan pilih Nomor Transaksi terlebih dahulu!", Me.Text)
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub fdlERPPinv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpDate.Value = FormatDateTime(Now, DateFormat.ShortDate)
        txtBillNo.Text = ""
        txtStatus.Text = ""

        clear_lvw()
    End Sub

    Sub clear_lvw()
        Try
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "yyyy/MM/dd"

            With ListView1
                .Clear()
                .View = View.Details
                .Columns.Add("Trans No.", 120)
                .Columns.Add("Tanggal", 100)
                .Columns.Add("Refno", 100)
                .Columns.Add("Supplier Id", 0)
                .Columns.Add("Nama Supplier.", 100)
                .Columns.Add("Status", 100)
                .Columns.Add("Total", 120, HorizontalAlignment.Right)
                .Columns.Add("Keterangan", 100)
                .Columns.Add("User", 100)
            End With


            cmd = New SqlCommand("sp_erp_tr_pinv_list_SEL", cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim prm1 As SqlParameter = cmd.Parameters.Add("@trans_id", SqlDbType.NVarChar, 30)
            prm1.Value = IIf(txtBillNo.Text = "", DBNull.Value, txtBillNo.Text)
            Dim prm2 As SqlParameter = cmd.Parameters.Add("@status", SqlDbType.NVarChar, 10)
            prm2.Value = IIf(txtStatus.Text = "", DBNull.Value, txtStatus.Text)
            Dim prm3 As SqlParameter = cmd.Parameters.Add("@tanggal", SqlDbType.NVarChar, 50)
            prm3.Value = dtpDate.Text

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
                lvItem.SubItems.Add(myReader.Item(5))
                lvItem.SubItems.Add(FormatNumber(myReader.Item(12), 0))
                lvItem.SubItems.Add(myReader.Item(7))
                lvItem.SubItems.Add(myReader.Item(13))

                'a.pinv_id,0v
                'a.pinv_date,1v
                'a.pinv_refno,2v
                'a.pinv_sup_id,3v
                'b.sup_name,4v
                'a.pinv_status,5v
                'a.pinv_ppnflag,6
                'a.pinv_remarks,7v
                'a.pinv_gross,8
                'a.pinv_disc,9
                'a.pinv_subtotal,10
                'a.pinv_ppn,11
                'a.pinv_total,12v
                'a.submit,13v

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

            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "dd/MM/yyyy"
        Catch ex As Exception
            MsgBox("Error Message : " + ex.Message)
            If ConnectionState.Open = True Then cn.Close()
        End Try

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

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Select Case m_FrmCallerId
            Case "frmERPPInv"
                With frmERPPInv
                    .BillNo = ListView1.SelectedItems.Item(0).SubItems.Item(0).Text
                    .m_Flag = 1
                End With
                autoRefreshERP()

        End Select
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListView1Sorter = New lvColumnSorter()
        ListView1.ListViewItemSorter = ListView1Sorter
    End Sub

    'Set autorefresh list---hendra
    Sub autoRefreshERP()
        If Application.OpenForms().OfType(Of frmERPPInv).Any Then
            Call frmERPPInv.frmERPRefresh(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStatus.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            clear_lvw()
        End If
    End Sub

    Private Sub txtFilter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillNo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            clear_lvw()
        End If
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        clear_lvw()
    End Sub

End Class