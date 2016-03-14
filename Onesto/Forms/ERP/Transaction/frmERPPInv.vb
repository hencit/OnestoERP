Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frmERPPInv
    Dim strConnection As String = My.Settings.ConnStr
    Dim cn As SqlConnection = New SqlConnection(strConnection)
    Dim cmd As SqlCommand
    Dim flag As Integer
    Dim flag_detail As Integer

    Private Sub frmERPPInv_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flag = 0 Then
            If MsgBox("Data belum tersimpan, Anda yakin mau menutup form ini?", vbYesNo + vbCritical, Me.Text) = vbNo Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmERPPInv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        flag = 0

        cbType.Items.Add("Item")
        cbType.SelectedIndex = 0

        clear_obj()
        clear_objD()
        clear_lvw()
        lock_obj(False)
        lock_objD(False)
    End Sub

    Public Property m_Flag() As Integer
        Get
            Return flag
        End Get
        Set(ByVal Value As Integer)
            flag = Value
        End Set
    End Property

    Public Property m_Flag_detail() As Integer
        Get
            Return flag_detail
        End Get
        Set(ByVal Value As Integer)
            flag_detail = Value
        End Set
    End Property

    Public Property BillNo() As String
        Get
            Return txtPInvNo.Text
        End Get
        Set(ByVal Value As String)
            txtPInvNo.Text = Value
        End Set
    End Property

    Public Property SuppCode() As String
        Get
            Return txtSupCode.Text
        End Get
        Set(ByVal Value As String)
            txtSupCode.Text = Value
        End Set
    End Property

    Public Property SuppName() As String
        Get
            Return txtSupName.Text
        End Get
        Set(ByVal Value As String)
            txtSupName.Text = Value
        End Set
    End Property

    Public Property TableCode() As String
        Get
            Return txtRefNo.Text
        End Get
        Set(ByVal Value As String)
            txtRefNo.Text = Value
        End Set
    End Property

    Public Property I_Code() As String
        Get
            Return txtItem.Text
        End Get
        Set(ByVal Value As String)
            txtItem.Text = Value
        End Set
    End Property

    Public Property Deskripsi() As String
        Get
            Return txtDeskripsi.Text
        End Get
        Set(ByVal Value As String)
            txtDeskripsi.Text = Value
        End Set
    End Property

    Public Property Type() As Integer
        Get
            Return cbType.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            cbType.SelectedIndex = Value
        End Set
    End Property

    Public Property Qty() As String
        Get
            Return txtQty.Text
        End Get
        Set(ByVal Value As String)
            txtQty.Text = Value
        End Set
    End Property

    Public Property Satuan() As String
        Get
            Return txtSatuan.Text
        End Get
        Set(ByVal Value As String)
            txtSatuan.Text = Value
        End Set
    End Property

    Public Property HargaSatuan() As String
        Get
            Return txtHargaSatuan.Text
        End Get
        Set(ByVal Value As String)
            txtHargaSatuan.Text = Value
        End Set
    End Property

    Public Property Disc() As String
        Get
            Return txtDisc.Text
        End Get
        Set(ByVal Value As String)
            txtDisc.Text = Value
        End Set
    End Property

    Public Property m_SubTotalDtl() As String
        Get
            Return txtSubtotalDtl.Text
        End Get
        Set(ByVal Value As String)
            txtSubtotalDtl.Text = Value
        End Set
    End Property

    Sub clear_obj()
        flag = 0
        txtPInvNo.Text = ""
        txtRefNo.Text = ""
        dtpDate.Value = FormatDateTime(Now, DateFormat.ShortDate)
        txtStatus.Text = ""
        txtCatatan.Text = ""
        txtSupCode.Text = ""
        txtSupName.Text = ""

        cbPpn.Checked = False
        txtTotalGross.Text = FormatNumber(0)
        txtTotalDisc.Text = FormatNumber(0)
        txtTotalSub.Text = FormatNumber(0)
        txtTotalPPN.Text = FormatNumber(0)
        txtTotalGrand.Text = FormatNumber(0)
    End Sub

    Sub clear_objD()
        flag_detail = 0
        txtItem.Text = ""
        txtDeskripsi.Text = ""
        txtQty.Text = "0"
        txtSatuan.Text = ""
        txtHargaSatuan.Text = FormatNumber(0, 0)
        txtDisc.Text = "0"
        txtSubtotalDtl.Text = FormatNumber(0, 0)
    End Sub

    Sub lock_obj(ByVal isLock As Boolean)
        'txtBillNo.ReadOnly = isLock
        txtCatatan.ReadOnly = isLock
        dtpDate.Enabled = Not isLock
        txtRefNo.ReadOnly = isLock

        cbPpn.Enabled = isLock
        btnEdit.Enabled = isLock
        btnAdd.Enabled = isLock
        btnSave.Enabled = Not isLock
        btnCancel.Enabled = Not isLock

        If flag = 0 Then
            'txtBillNo.ReadOnly = False
            btnVoid.Enabled = False
            btnReceipt.Enabled = False
        Else
            'txtBillNo.ReadOnly = True
            btnVoid.Enabled = Not isLock
            btnReceipt.Enabled = Not isLock
        End If

    End Sub

    Sub lock_objD(ByVal isLock As Boolean)
        btnMenu.Enabled = Not isLock
        txtDeskripsi.ReadOnly = isLock
        txtQty.ReadOnly = isLock
        txtDisc.ReadOnly = isLock
        btnSaveDtl.Enabled = Not isLock
        btnDeleteDtl.Enabled = Not isLock
        btnAddDtl.Enabled = Not isLock

        If txtStatus.Text = "PAID" Then
            btnSaveDtl.Enabled = False
            btnDeleteDtl.Enabled = False
            btnAddDtl.Enabled = False
        End If
    End Sub

    Sub clear_lvw()
        Try
            With ListView1
                .Clear()
                .View = View.Details
                .Columns.Add("pos_dtl_id", 0)
                .Columns.Add("Type", 50)
                .Columns.Add("Kode", 0)
                .Columns.Add("Deskripsi", 300)
                .Columns.Add("Qty", 75)
                .Columns.Add("Satuan", 100)
                .Columns.Add("Harga Satuan", 150, HorizontalAlignment.Right)
                .Columns.Add("Discount", 100, HorizontalAlignment.Right)
                .Columns.Add("Subtotal", 200, HorizontalAlignment.Right)
            End With

            If flag <> 0 Then
                cmd = New SqlCommand("sp_erp_tr_pinv_dtl_SEL", cn)
                cmd.CommandType = CommandType.StoredProcedure

                Dim prm1 As SqlParameter = cmd.Parameters.Add("@trans_no", SqlDbType.NVarChar, 30)
                prm1.Value = txtPInvNo.Text

                cn.Open()

                Dim myReader As SqlDataReader = cmd.ExecuteReader()

                Dim lvItem As ListViewItem
                Dim i As Integer, intCurrRow As Integer

                While myReader.Read
                    lvItem = New ListViewItem(CStr(myReader.Item(0))) 'pos_dtl_id
                    lvItem.Tag = intCurrRow 'ID

                    For i = 1 To 3
                        If myReader.Item(i) Is System.DBNull.Value Then
                            lvItem.SubItems.Add("")
                        Else
                            lvItem.SubItems.Add(myReader.Item(i))
                        End If
                    Next

                    If CDec(myReader.Item(4)) Mod 1 = 0 Then
                        lvItem.SubItems.Add(FormatNumber(myReader.Item(4), 0)) 'qty tanpa koma
                    Else
                        lvItem.SubItems.Add(FormatNumber(myReader.Item(4), 3)) 'qty dgn koma
                    End If

                    lvItem.SubItems.Add(myReader.Item(5)) 'satuan
                    lvItem.SubItems.Add(FormatNumber(myReader.Item(6), 0)) 'unit price
                    lvItem.SubItems.Add(myReader.Item(7)) 'disc
                    lvItem.SubItems.Add(FormatNumber(myReader.Item(8), 0)) 'subtotal

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

                lblJumlahBaris.Text = "Total Items : " + CStr(ListView1.Items.Count)
            End If
        Catch ex As Exception
            MsgBox("Error Message : " + ex.Message)
            If ConnectionState.Open = True Then cn.Close()
        End Try

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        With ListView1.SelectedItems.Item(0)
            flag_detail = .SubItems.Item(0).Text

            'If .SubItems.Item(1).Text = "M" Then
            '    cbType.SelectedIndex = 0
            'Else
            '    cbType.SelectedIndex = 1
            'End If

            txtItem.Text = .SubItems.Item(2).Text
            txtDeskripsi.Text = .SubItems.Item(3).Text
            txtQty.Text = .SubItems.Item(4).Text
            txtSatuan.Text = .SubItems.Item(5).Text
            txtHargaSatuan.Text = FormatNumber(.SubItems.Item(6).Text, 0)
            txtDisc.Text = .SubItems.Item(7).Text
            txtSubtotalDtl.Text = FormatNumber(.SubItems.Item(8).Text, 0)

            If btnSaveDtl.Enabled = True Then
                btnMenu.Enabled = False
            End If

            'a.pos_dtl_id,0
            'a.line_type,1
            'a.code,2
            'a.deskripsi,3
            'a.qty,4
            'ISNULL(b.satuan,'') as satuan,5
            'a.unit_price,6
            'a.disc,7
            'a.subtotal,8
        End With
    End Sub

    Sub view_record()
        Try
            cmd = New SqlCommand("sp_erp_tr_pinv_SEL", cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim prm2 As SqlParameter = cmd.Parameters.Add("@trans_id", SqlDbType.NVarChar, 30)
            prm2.Value = txtPInvNo.Text

            cn.Open()

            Dim myReader As SqlDataReader = cmd.ExecuteReader()

            While myReader.Read
                flag = 1
                dtpDate.Text = myReader.GetDateTime(1)
                txtRefNo.Text = myReader.GetString(2)
                txtSupCode.Text = myReader.GetString(3)
                txtSupName.Text = myReader.GetString(4)
                txtStatus.Text = myReader.GetString(5)
                cbPpn.Checked = myReader.GetBoolean(6)
                txtCatatan.Text = myReader.GetString(7)
                txtTotalGross.Text = FormatNumber(myReader.GetDecimal(8), 0)
                txtTotalDisc.Text = FormatNumber(myReader.GetDecimal(9), 0)
                txtTotalSub.Text = FormatNumber(myReader.GetDecimal(10), 0)
                txtTotalPPN.Text = FormatNumber(myReader.GetDecimal(11), 0)
                txtTotalGrand.Text = FormatNumber(myReader.GetDecimal(12), 0)


            End While
            '            a.pinv_id,0
            'a.pinv_date,1
            'a.pinv_refno,2
            'a.pinv_sup_id,3
            'b.sup_name,4
            'a.pinv_status,5
            'a.pinv_ppnflag,6
            'a.pinv_remarks,7
            'a.pinv_gross,8
            'a.pinv_disc,9
            'a.pinv_subtotal,10
            'a.pinv_ppn,11
            'a.pinv_total,12
            myReader.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If ConnectionState.Open = True Then cn.Close()
        End Try

    End Sub

    Sub saveHeader()
        If txtPInvNo.Text = "" Then
            txtPInvNo.Text = GetSysNumber("PINV")
        End If

        Try
            cmd = New SqlCommand(IIf(flag = 0, "sp_erp_tr_pinv_INS", "sp_erp_tr_pinv_UPD"), cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim prm0 As SqlParameter = cmd.Parameters.Add("@trans_id", SqlDbType.NVarChar, 30)
            prm0.Value = txtPInvNo.Text
            Dim prm1 As SqlParameter = cmd.Parameters.Add("@trans_date", SqlDbType.DateTime)
            prm1.Value = dtpDate.Value
            Dim prm2 As SqlParameter = cmd.Parameters.Add("@trans_refno", SqlDbType.NVarChar, 30)
            prm2.Value = txtRefNo.Text
            Dim prm3 As SqlParameter = cmd.Parameters.Add("@trans_s_id", SqlDbType.NVarChar, 30)
            prm3.Value = txtSupCode.Text
            Dim prm3a As SqlParameter = cmd.Parameters.Add("@trans_status", SqlDbType.NVarChar, 10)
            prm3a.Value = txtStatus.Text
            Dim prm3b As SqlParameter = cmd.Parameters.Add("@trans_ppnflag", SqlDbType.Bit)
            prm3b.Value = cbPpn.Checked
            Dim prm3c As SqlParameter = cmd.Parameters.Add("@trans_remarks", SqlDbType.NVarChar, 100)
            prm3c.Value = txtCatatan.Text
            Dim prm4 As SqlParameter = cmd.Parameters.Add("@trans_gross", SqlDbType.Decimal)
            prm4.Value = CDec(txtTotalGross.Text)
            Dim prm5 As SqlParameter = cmd.Parameters.Add("@trans_disc", SqlDbType.Decimal)
            prm5.Value = CDec(txtTotalDisc.Text)
            Dim prm6 As SqlParameter = cmd.Parameters.Add("@trans_sub", SqlDbType.Decimal)
            prm6.Value = CDec(txtTotalSub.Text)
            Dim prm7 As SqlParameter = cmd.Parameters.Add("@trans_ppn", SqlDbType.Decimal)
            prm7.Value = CDec(txtTotalPPN.Text)
            Dim prm8 As SqlParameter = cmd.Parameters.Add("@trans_total", SqlDbType.Decimal)
            prm8.Value = CDec(txtTotalGrand.Text)
            Dim prm22 As SqlParameter = cmd.Parameters.Add("@user_code", SqlDbType.NVarChar, 50)
            prm22.Value = My.Settings.UserName

            '           @trans_no nvarchar(30),
            '@trans_date smalldatetime,
            '@trans_refno nvarchar(30),
            '@trans_id int,
            '@trans_status nvarchar(10),
            '@trans_ppnflag bit,
            '@trans_remarks nvarchar(100),
            '@trans_gross decimal(18,0),
            '@trans_disc decimal(18,0),
            '@trans_sub decimal(18,0),
            '@trans_ppn decimal(18,0),
            '@trans_total decimal(18,0),
            '@user_code nvarchar(50)ype.Decimal)



            If flag = 0 Then
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                flag = 1
                txtPInvNo.ReadOnly = True
            Else
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
            End If

            view_record()
        Catch ex As Exception
            MsgBox("Error Message saveHeader(): " + ex.Message)
            If ConnectionState.Open = 1 Then cn.Close()
            clear_objD()
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        flag = 0
        clear_obj()
        clear_objD()
        clear_lvw()
        lock_obj(False)
        lock_objD(False)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lock_obj(True)
        lock_objD(True)
        clear_objD()
        flag_detail = 0
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            saveHeader()

            lock_obj(True)
            lock_objD(True)

        Catch ex As Exception
            MsgBox("Error Message: " + ex.Message)
            If ConnectionState.Open = 1 Then cn.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        clear_objD()
        lock_obj(False)
        lock_objD(False)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click

        If flag <> 0 Then
            If MsgBox("Anda yakin untuk membatalkan transaksi ini?", vbYesNo + vbCritical, Me.Text) = vbYes Then
                cmd = New SqlCommand("sp_erp_tr_pinv_VOID", cn)
                cmd.CommandType = CommandType.StoredProcedure

                Dim prm0 As SqlParameter = cmd.Parameters.Add("@trans_id", SqlDbType.NVarChar, 30)
                prm0.Value = txtPInvNo.Text
                Dim prm2 As SqlParameter = cmd.Parameters.Add("@user_code", SqlDbType.NVarChar, 50)
                prm2.Value = My.Settings.UserName

                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()


                clear_obj()
                btnAdd_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnSaveDtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDtl.Click
        Try

            If txtItem.Text = "" Then
                MsgBox("Silahkan pilih terlebih dahulu!", vbCritical + vbOKOnly, Me.Text)
                btnMenu.Focus()
                Exit Sub
            End If

            cmd = New SqlCommand(IIf(flag_detail = 0, "sp_erp_tr_pinv_dtl_INS", "sp_erp_tr_pinv_dtl_UPD"), cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim m_disc_value, m_ppn_value, m_unit_price, m_gross, m_after_disc, m_sub_total As Decimal

            m_gross = CDec(txtQty.Text) * CDec(txtHargaSatuan.Text)
            m_disc_value = m_gross * CInt(txtDisc.Text) / 100
            m_after_disc = m_gross - m_disc_value
            m_ppn_value = IIf(cbPpn.Checked = False, 0, CDec(txtHargaSatuan.Text) * 0.1)
            m_unit_price = CDec(txtHargaSatuan.Text) - m_ppn_value


            Dim prm1 As SqlParameter = cmd.Parameters.Add("@trans_no", SqlDbType.NVarChar, 30)
            prm1.Value = txtPInvNo.Text
            Dim prm2 As SqlParameter = cmd.Parameters.Add("@line_type", SqlDbType.NVarChar, 10)
            prm2.Value = cbType.Text
            Dim prm3 As SqlParameter = cmd.Parameters.Add("@code", SqlDbType.NVarChar, 30)
            prm3.Value = txtItem.Text
            Dim prm4 As SqlParameter = cmd.Parameters.Add("@deskripsi", SqlDbType.NVarChar, 50)
            prm4.Value = txtDeskripsi.Text
            Dim prm5 As SqlParameter = cmd.Parameters.Add("@qty", SqlDbType.Decimal)
            prm5.Value = CDec(txtQty.Text)
            Dim prm6 As SqlParameter = cmd.Parameters.Add("@value", SqlDbType.Decimal)
            prm6.Value = CDec(txtHargaSatuan.Text)
            Dim prm7 As SqlParameter = cmd.Parameters.Add("@disc", SqlDbType.Decimal)
            prm7.Value = CInt(txtDisc.Text)
            Dim prm8 As SqlParameter = cmd.Parameters.Add("@disc_value", SqlDbType.Decimal)
            prm8.Value = m_disc_value
            Dim prm9 As SqlParameter = cmd.Parameters.Add("@unit_price", SqlDbType.Decimal)
            prm9.Value = m_unit_price
            Dim prm10 As SqlParameter = cmd.Parameters.Add("@ppn_value", SqlDbType.Decimal)
            prm10.Value = m_ppn_value
            Dim prm11 As SqlParameter = cmd.Parameters.Add("@subtotal", SqlDbType.Decimal)
            prm11.Value = CDec(txtSubtotalDtl.Text)
            Dim prm12 As SqlParameter = cmd.Parameters.Add("@pinv_dtl_id", SqlDbType.Decimal)
            prm12.Value = flag_detail
            Dim prm22 As SqlParameter = cmd.Parameters.Add("@user_code", SqlDbType.NVarChar, 50)
            prm22.Value = My.Settings.UserName

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            clear_lvw()
            clear_objD()
            view_record()
            btnMenu.Enabled = True
            btnMenu.Focus()
        Catch ex As Exception
            MsgBox("Error Message : " + ex.Message)
            If ConnectionState.Open = True Then cn.Close()
        End Try
    End Sub

    Private Sub btnDeleteD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDtl.Click
        If flag_detail = 0 Then Exit Sub
        If MsgBox("Anda yakin menghapus baris ini?", vbYesNo + vbCritical, Me.Text) = vbYes Then
            Try
                cmd = New SqlCommand("sp_tr_pos_dtl_DEL", cn)
                cmd.CommandType = CommandType.StoredProcedure

                Dim prm1 As SqlParameter = cmd.Parameters.Add("@bill_no", SqlDbType.NVarChar, 20)
                prm1.Value = txtPInvNo.Text

                Dim prm2 As SqlParameter = cmd.Parameters.Add("@pos_dtl_id", SqlDbType.Int)
                prm2.Value = flag_detail

                cn.Open()
                cmd.ExecuteReader()
                cn.Close()

                clear_lvw()
                clear_objD()
                view_record()

                btnMenu.Enabled = True
                btnMenu.Focus()
            Catch ex As Exception
                MsgBox("Error Message : " + ex.Message)
                If ConnectionState.Open = True Then cn.Close()
            End Try
        End If
    End Sub

    Private Sub btnAddD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDtl.Click
        btnMenu.Enabled = True
        clear_objD()
        btnMenu.Focus()
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If txtSupCode.Text = "" Then
            MsgBox("Silahkan pilih supplier dahulu!", vbCritical + vbOKOnly, Me.Text)
            btnSup.Focus()
            Exit Sub
        End If

        saveHeader()

        Dim NewFormDialog As New fdlERPitem
        NewFormDialog.FrmCallerId = Me.Name
        NewFormDialog.ShowDialog()
    End Sub

    Private Sub btnTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NewFormDialog As New fdlTable
        NewFormDialog.FrmCallerId = Me.Name
        NewFormDialog.TableCode = txtRefNo.Text
        NewFormDialog.ShowDialog()
    End Sub

    Private Sub btnPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPInv.Click
        Dim NewFormDialog As New fdlERPPinv
        NewFormDialog.FrmCallerId = Me.Name
        NewFormDialog.ShowDialog()
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        view_record()
        clear_lvw()
        lock_obj(False)
        lock_objD(False)
    End Sub

    'Autorefresh---Hendra
    Public Sub frmERPRefresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnFilter_Click(sender, e)
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If

        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.,").IndexOf(e.KeyChar) = -1) Then
            e.Handled = True
        End If



    End Sub

    Private Sub txtDisc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisc.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If

        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtHargaSatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaSatuan.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If



    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        Try
            If txtQty.Text = "" Then
                txtQty.Text = "1"
            End If
            If CDec(txtQty.Text) < 0 Then
                txtQty.Text = CStr(CDec(txtQty.Text) * -1)
            End If
            get_SubtotalDtl()
        Catch ex As Exception
            txtQty.Text = "1"
            get_SubtotalDtl()
        End Try

    End Sub

    Private Sub txtHargaSatuan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHargaSatuan.LostFocus
        If txtHargaSatuan.Text = "" Then
            txtHargaSatuan.Text = "1"
        End If
        If CInt(txtHargaSatuan.Text) < 0 Then
            txtHargaSatuan.Text = CStr(CInt(txtHargaSatuan.Text) * -1)
        End If
        get_SubtotalDtl()
    End Sub

    Private Sub txtDisc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc.LostFocus
        Try
            If txtDisc.Text = "" Then
                txtDisc.Text = "0"
            End If
            If CDec(txtDisc.Text) < 0 Then
                txtDisc.Text = CStr(CDec(txtDisc.Text) * -1)
            End If
            get_SubtotalDtl()
        Catch ex As Exception
            txtDisc.Text = "0"
            get_SubtotalDtl()
        End Try
    End Sub

    Private Sub txtTotalAddDisc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTotalAddDiscPerc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub get_SubtotalDtl()
        txtSubtotalDtl.Text = FormatNumber(CStr((CDec(txtQty.Text) * CInt(txtHargaSatuan.Text)) - ((CDec(txtQty.Text) * CInt(txtHargaSatuan.Text)) * (CInt(txtDisc.Text) / 100))), 0)
    End Sub


    Private Sub cbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
        If btnAddDtl.Enabled = False Then Exit Sub

        If cbType.SelectedItem.ToString = "M" Then
            txtHargaSatuan.ReadOnly = True
        ElseIf cbType.SelectedItem.ToString = "J" Then
            txtHargaSatuan.ReadOnly = False
        End If
    End Sub

    Private Sub btnSaveHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveHeader.Click
        saveHeader()
    End Sub

    'AutosaveHeader
    Public Sub frmPOSAutosaveHeader(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnSaveHeader_Click(sender, e)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceipt.Click

        With fdlSettle
            .billNo = txtPInvNo.Text
            .MdiParent = frmMenu
            .Show()
            .BringToFront()
        End With
    End Sub

    Sub tableRelease(ByVal TableCode As String)
        Try
            cmd = New SqlCommand("sp_mt_table_RELEASE", cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim prm1 As SqlParameter = cmd.Parameters.Add("@table_code", SqlDbType.NVarChar, 20)
            prm1.Value = TableCode

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox("Error Message tableRelease() : " + ex.Message)
            If ConnectionState.Open = True Then cn.Close()
        End Try
    End Sub

    Private Sub btnMenu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnMenu.KeyPress
        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                btnMenu_click(sender, e)
            End If
        End If

    End Sub

    Private Sub txtDeskripsi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeskripsi.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSatuan.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSubtotalDtl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubtotalDtl.KeyPress
        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                Me.SelectNextControl(tb, True, True, False, True)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSaveDtl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSaveDtl.KeyPress
        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar.Equals(Chr(Keys.Return)) Then
                btnSaveDtl_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        Dim NewFormDialog As New fdlERPSup
        NewFormDialog.FrmCallerId = Me.Name
        NewFormDialog.ShowDialog()
    End Sub
End Class