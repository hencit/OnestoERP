<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmERPPInv
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmERPPInv))
        Me.lblJumlahBaris = New System.Windows.Forms.Label()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.btnSaveHeader = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalSub = New System.Windows.Forms.TextBox()
        Me.txtTotalDisc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalGrand = New System.Windows.Forms.TextBox()
        Me.txtTotalGross = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubtotalDtl = New System.Windows.Forms.TextBox()
        Me.PPN = New System.Windows.Forms.Label()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnPInv = New System.Windows.Forms.Button()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnAddDtl = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnDeleteDtl = New System.Windows.Forms.Button()
        Me.btnSaveDtl = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPInvNo = New System.Windows.Forms.TextBox()
        Me.btnSup = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSupCode = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSupName = New System.Windows.Forms.TextBox()
        Me.cbPpn = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalPPN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblJumlahBaris
        '
        Me.lblJumlahBaris.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahBaris.AutoSize = True
        Me.lblJumlahBaris.Location = New System.Drawing.Point(14, 409)
        Me.lblJumlahBaris.Name = "lblJumlahBaris"
        Me.lblJumlahBaris.Size = New System.Drawing.Size(65, 13)
        Me.lblJumlahBaris.TabIndex = 386
        Me.lblJumlahBaris.Text = "Total Items :"
        '
        'btnReceipt
        '
        Me.btnReceipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReceipt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.Location = New System.Drawing.Point(491, 579)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(83, 26)
        Me.btnReceipt.TabIndex = 356
        Me.btnReceipt.Text = "Bayar"
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 487)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 383
        Me.Label3.Text = "Catatan"
        '
        'txtCatatan
        '
        Me.txtCatatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCatatan.Location = New System.Drawing.Point(15, 503)
        Me.txtCatatan.MaxLength = 100
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(323, 60)
        Me.txtCatatan.TabIndex = 348
        '
        'btnSaveHeader
        '
        Me.btnSaveHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveHeader.ImageIndex = 0
        Me.btnSaveHeader.Location = New System.Drawing.Point(50, 580)
        Me.btnSaveHeader.Name = "btnSaveHeader"
        Me.btnSaveHeader.Size = New System.Drawing.Size(29, 25)
        Me.btnSaveHeader.TabIndex = 382
        Me.btnSaveHeader.Text = "..."
        Me.btnSaveHeader.UseVisualStyleBackColor = True
        Me.btnSaveHeader.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(696, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 381
        Me.Label5.Text = "Subtotal"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(696, 443)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 380
        Me.Label12.Text = "Discount"
        '
        'txtTotalSub
        '
        Me.txtTotalSub.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalSub.Location = New System.Drawing.Point(802, 469)
        Me.txtTotalSub.Name = "txtTotalSub"
        Me.txtTotalSub.ReadOnly = True
        Me.txtTotalSub.Size = New System.Drawing.Size(140, 20)
        Me.txtTotalSub.TabIndex = 352
        Me.txtTotalSub.TabStop = False
        Me.txtTotalSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDisc
        '
        Me.txtTotalDisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDisc.Location = New System.Drawing.Point(802, 443)
        Me.txtTotalDisc.Name = "txtTotalDisc"
        Me.txtTotalDisc.ReadOnly = True
        Me.txtTotalDisc.Size = New System.Drawing.Size(140, 20)
        Me.txtTotalDisc.TabIndex = 350
        Me.txtTotalDisc.TabStop = False
        Me.txtTotalDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(696, 525)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 379
        Me.Label13.Text = "Grand Total"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(696, 418)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 377
        Me.Label15.Text = "Gross Total"
        '
        'txtTotalGrand
        '
        Me.txtTotalGrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGrand.Location = New System.Drawing.Point(802, 522)
        Me.txtTotalGrand.Name = "txtTotalGrand"
        Me.txtTotalGrand.ReadOnly = True
        Me.txtTotalGrand.Size = New System.Drawing.Size(140, 20)
        Me.txtTotalGrand.TabIndex = 354
        Me.txtTotalGrand.TabStop = False
        Me.txtTotalGrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalGross
        '
        Me.txtTotalGross.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGross.Location = New System.Drawing.Point(802, 418)
        Me.txtTotalGross.Name = "txtTotalGross"
        Me.txtTotalGross.ReadOnly = True
        Me.txtTotalGross.Size = New System.Drawing.Size(140, 20)
        Me.txtTotalGross.TabIndex = 349
        Me.txtTotalGross.TabStop = False
        Me.txtTotalGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(646, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 376
        Me.Label11.Text = "Subtotal"
        '
        'txtSubtotalDtl
        '
        Me.txtSubtotalDtl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotalDtl.Location = New System.Drawing.Point(649, 139)
        Me.txtSubtotalDtl.MaxLength = 20
        Me.txtSubtotalDtl.Name = "txtSubtotalDtl"
        Me.txtSubtotalDtl.Size = New System.Drawing.Size(183, 20)
        Me.txtSubtotalDtl.TabIndex = 344
        '
        'PPN
        '
        Me.PPN.AutoSize = True
        Me.PPN.Location = New System.Drawing.Point(590, 123)
        Me.PPN.Name = "PPN"
        Me.PPN.Size = New System.Drawing.Size(39, 13)
        Me.PPN.TabIndex = 375
        Me.PPN.Text = "Disc %"
        '
        'txtDisc
        '
        Me.txtDisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDisc.Location = New System.Drawing.Point(593, 139)
        Me.txtDisc.MaxLength = 3
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(50, 20)
        Me.txtDisc.TabIndex = 343
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 374
        Me.Label9.Text = "Harga Satuan"
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHargaSatuan.Location = New System.Drawing.Point(487, 140)
        Me.txtHargaSatuan.MaxLength = 20
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaSatuan.TabIndex = 342
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 373
        Me.Label8.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSatuan.Location = New System.Drawing.Point(419, 140)
        Me.txtSatuan.MaxLength = 50
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.ReadOnly = True
        Me.txtSatuan.Size = New System.Drawing.Size(62, 20)
        Me.txtSatuan.TabIndex = 341
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 372
        Me.Label7.Text = "Qty"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Box.png")
        Me.ImageList1.Images.SetKeyName(1, "add.png")
        Me.ImageList1.Images.SetKeyName(2, "Checkmark.png")
        Me.ImageList1.Images.SetKeyName(3, "Remove.png")
        '
        'txtQty
        '
        Me.txtQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQty.Location = New System.Drawing.Point(362, 140)
        Me.txtQty.MaxLength = 10
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(51, 20)
        Me.txtQty.TabIndex = 340
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 371
        Me.Label4.Text = "Tipe"
        '
        'cbType
        '
        Me.cbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Enabled = False
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(21, 100)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(71, 21)
        Me.cbType.TabIndex = 370
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.Location = New System.Drawing.Point(840, 6)
        Me.txtStatus.MaxLength = 10
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(102, 20)
        Me.txtStatus.TabIndex = 336
        Me.txtStatus.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(785, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 368
        Me.Label1.Text = "Tanggal P. Inv"
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ImageIndex = 0
        Me.btnFilter.Location = New System.Drawing.Point(15, 580)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(29, 25)
        Me.btnFilter.TabIndex = 367
        Me.btnFilter.Text = "..."
        Me.btnFilter.UseVisualStyleBackColor = True
        Me.btnFilter.Visible = False
        '
        'btnPInv
        '
        Me.btnPInv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPInv.ImageIndex = 0
        Me.btnPInv.Location = New System.Drawing.Point(205, 6)
        Me.btnPInv.Name = "btnPInv"
        Me.btnPInv.Size = New System.Drawing.Size(29, 25)
        Me.btnPInv.TabIndex = 331
        Me.btnPInv.Text = "..."
        Me.btnPInv.UseVisualStyleBackColor = True
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(94, 67)
        Me.txtRefNo.MaxLength = 30
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(102, 20)
        Me.txtRefNo.TabIndex = 334
        Me.txtRefNo.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(15, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 13)
        Me.Label27.TabIndex = 366
        Me.Label27.Text = "No Referensi"
        '
        'btnAddDtl
        '
        Me.btnAddDtl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDtl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDtl.ImageIndex = 1
        Me.btnAddDtl.ImageList = Me.ImageList1
        Me.btnAddDtl.Location = New System.Drawing.Point(913, 135)
        Me.btnAddDtl.Name = "btnAddDtl"
        Me.btnAddDtl.Size = New System.Drawing.Size(29, 25)
        Me.btnAddDtl.TabIndex = 347
        Me.btnAddDtl.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(50, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 365
        Me.Label19.Text = "Deskripsi"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(590, 531)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 364
        Me.Label18.Text = "Item"
        Me.Label18.Visible = False
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeskripsi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeskripsi.Location = New System.Drawing.Point(53, 140)
        Me.txtDeskripsi.MaxLength = 255
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(303, 20)
        Me.txtDeskripsi.TabIndex = 339
        '
        'txtItem
        '
        Me.txtItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItem.Location = New System.Drawing.Point(593, 547)
        Me.txtItem.MaxLength = 50
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(80, 20)
        Me.txtItem.TabIndex = 362
        Me.txtItem.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ImageIndex = 0
        Me.btnMenu.ImageList = Me.ImageList1
        Me.btnMenu.Location = New System.Drawing.Point(14, 137)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(29, 25)
        Me.btnMenu.TabIndex = 338
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnDeleteDtl
        '
        Me.btnDeleteDtl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteDtl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDtl.ImageIndex = 3
        Me.btnDeleteDtl.ImageList = Me.ImageList1
        Me.btnDeleteDtl.Location = New System.Drawing.Point(880, 135)
        Me.btnDeleteDtl.Name = "btnDeleteDtl"
        Me.btnDeleteDtl.Size = New System.Drawing.Size(29, 25)
        Me.btnDeleteDtl.TabIndex = 346
        Me.btnDeleteDtl.UseVisualStyleBackColor = True
        '
        'btnSaveDtl
        '
        Me.btnSaveDtl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveDtl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDtl.ImageIndex = 2
        Me.btnSaveDtl.ImageList = Me.ImageList1
        Me.btnSaveDtl.Location = New System.Drawing.Point(845, 135)
        Me.btnSaveDtl.Name = "btnSaveDtl"
        Me.btnSaveDtl.Size = New System.Drawing.Size(29, 25)
        Me.btnSaveDtl.TabIndex = 345
        Me.btnSaveDtl.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 363
        Me.Label6.Text = "P. Inv No."
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(850, 579)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 26)
        Me.btnCancel.TabIndex = 360
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(580, 579)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 26)
        Me.btnEdit.TabIndex = 357
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(670, 579)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 26)
        Me.btnAdd.TabIndex = 358
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Location = New System.Drawing.Point(402, 579)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(83, 26)
        Me.btnVoid.TabIndex = 355
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(760, 579)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 26)
        Me.btnSave.TabIndex = 359
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(15, 168)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(927, 238)
        Me.ListView1.TabIndex = 361
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(94, 37)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(102, 20)
        Me.dtpDate.TabIndex = 333
        '
        'txtPInvNo
        '
        Me.txtPInvNo.Location = New System.Drawing.Point(94, 9)
        Me.txtPInvNo.MaxLength = 30
        Me.txtPInvNo.Name = "txtPInvNo"
        Me.txtPInvNo.ReadOnly = True
        Me.txtPInvNo.Size = New System.Drawing.Size(102, 20)
        Me.txtPInvNo.TabIndex = 330
        '
        'btnSup
        '
        Me.btnSup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSup.ImageIndex = 0
        Me.btnSup.Location = New System.Drawing.Point(563, 9)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(29, 25)
        Me.btnSup.TabIndex = 391
        Me.btnSup.Text = "..."
        Me.btnSup.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(360, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 392
        Me.Label16.Text = "Kode Supplier"
        '
        'txtSupCode
        '
        Me.txtSupCode.Location = New System.Drawing.Point(450, 12)
        Me.txtSupCode.MaxLength = 20
        Me.txtSupCode.Name = "txtSupCode"
        Me.txtSupCode.ReadOnly = True
        Me.txtSupCode.Size = New System.Drawing.Size(102, 20)
        Me.txtSupCode.TabIndex = 390
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(360, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 394
        Me.Label22.Text = "Nama Supplier"
        '
        'txtSupName
        '
        Me.txtSupName.Location = New System.Drawing.Point(450, 41)
        Me.txtSupName.MaxLength = 50
        Me.txtSupName.Multiline = True
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.ReadOnly = True
        Me.txtSupName.Size = New System.Drawing.Size(193, 20)
        Me.txtSupName.TabIndex = 393
        '
        'cbPpn
        '
        Me.cbPpn.AutoSize = True
        Me.cbPpn.Location = New System.Drawing.Point(788, 37)
        Me.cbPpn.Name = "cbPpn"
        Me.cbPpn.Size = New System.Drawing.Size(48, 17)
        Me.cbPpn.TabIndex = 395
        Me.cbPpn.Text = "PPN"
        Me.cbPpn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(696, 496)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 397
        Me.Label10.Text = "PPN"
        '
        'txtTotalPPN
        '
        Me.txtTotalPPN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPPN.Location = New System.Drawing.Point(801, 496)
        Me.txtTotalPPN.Name = "txtTotalPPN"
        Me.txtTotalPPN.ReadOnly = True
        Me.txtTotalPPN.Size = New System.Drawing.Size(140, 20)
        Me.txtTotalPPN.TabIndex = 396
        Me.txtTotalPPN.TabStop = False
        Me.txtTotalPPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmERPPInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 611)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalPPN)
        Me.Controls.Add(Me.cbPpn)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtSupName)
        Me.Controls.Add(Me.btnSup)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSupCode)
        Me.Controls.Add(Me.lblJumlahBaris)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.btnSaveHeader)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalSub)
        Me.Controls.Add(Me.txtTotalDisc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotalGrand)
        Me.Controls.Add(Me.txtTotalGross)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSubtotalDtl)
        Me.Controls.Add(Me.PPN)
        Me.Controls.Add(Me.txtDisc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHargaSatuan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnPInv)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.btnAddDtl)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnDeleteDtl)
        Me.Controls.Add(Me.btnSaveDtl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtPInvNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmERPPInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmERPPInv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJumlahBaris As System.Windows.Forms.Label
    Friend WithEvents btnReceipt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveHeader As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSub As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalGrand As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalGross As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotalDtl As System.Windows.Forms.TextBox
    Friend WithEvents PPN As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHargaSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnPInv As System.Windows.Forms.Button
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnAddDtl As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDtl As System.Windows.Forms.Button
    Friend WithEvents btnSaveDtl As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPInvNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSupCode As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSupName As System.Windows.Forms.TextBox
    Friend WithEvents cbPpn As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPPN As System.Windows.Forms.TextBox
End Class
