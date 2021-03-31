<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OMSys_OrdersV2DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.OMSys_OrdersV2DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Added = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Delivered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OMSys_OrdersV2DBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_OrderID = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_DateAdded = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ProductName = New System.Windows.Forms.Label()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_MiddleName = New System.Windows.Forms.Label()
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_MiddleName = New System.Windows.Forms.TextBox()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.lbl_TotalPrice = New System.Windows.Forms.Label()
        Me.txt_TotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ContactNumber = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DateDelivered = New System.Windows.Forms.Label()
        Me.btnAddOrder1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmb_Status = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClearFields = New System.Windows.Forms.Button()
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(2415, 170)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(112, 42)
        Me.btnAddOrder.TabIndex = 3
        Me.btnAddOrder.Text = "New Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1413, 710)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1366, 600)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 96)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "OMSYS"
        '
        'OMSys_OrdersV2DBBindingSource
        '
        Me.OMSys_OrdersV2DBBindingSource.DataMember = "OMSys_OrdersV2DB"
        Me.OMSys_OrdersV2DBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OMSys_OrdersV2DBDataGridView
        '
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToAddRows = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToDeleteRows = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToResizeRows = False
        Me.OMSys_OrdersV2DBDataGridView.AutoGenerateColumns = False
        Me.OMSys_OrdersV2DBDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersHeight = 29
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OMSys_OrdersV2DBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Date_Added, Me.Customer_FirstName, Me.Customer_MiddleName, Me.Customer_LastName, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Date_Delivered})
        Me.OMSys_OrdersV2DBDataGridView.DataSource = Me.OMSys_OrdersV2DBBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OMSys_OrdersV2DBDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.OMSys_OrdersV2DBDataGridView.EnableHeadersVisualStyles = False
        Me.OMSys_OrdersV2DBDataGridView.Location = New System.Drawing.Point(13, 100)
        Me.OMSys_OrdersV2DBDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.OMSys_OrdersV2DBDataGridView.Name = "OMSys_OrdersV2DBDataGridView"
        Me.OMSys_OrdersV2DBDataGridView.ReadOnly = True
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersVisible = False
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersWidth = 51
        Me.OMSys_OrdersV2DBDataGridView.Size = New System.Drawing.Size(1668, 405)
        Me.OMSys_OrdersV2DBDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'Date_Added
        '
        Me.Date_Added.DataPropertyName = "Date_Added"
        Me.Date_Added.HeaderText = "Date Added"
        Me.Date_Added.MinimumWidth = 6
        Me.Date_Added.Name = "Date_Added"
        Me.Date_Added.ReadOnly = True
        Me.Date_Added.Width = 150
        '
        'Customer_FirstName
        '
        Me.Customer_FirstName.DataPropertyName = "Customer_FirstName"
        Me.Customer_FirstName.HeaderText = "First Name"
        Me.Customer_FirstName.MinimumWidth = 6
        Me.Customer_FirstName.Name = "Customer_FirstName"
        Me.Customer_FirstName.ReadOnly = True
        Me.Customer_FirstName.Width = 125
        '
        'Customer_MiddleName
        '
        Me.Customer_MiddleName.DataPropertyName = "Customer_MiddleName"
        Me.Customer_MiddleName.HeaderText = "Middle Name"
        Me.Customer_MiddleName.MinimumWidth = 6
        Me.Customer_MiddleName.Name = "Customer_MiddleName"
        Me.Customer_MiddleName.ReadOnly = True
        Me.Customer_MiddleName.Width = 125
        '
        'Customer_LastName
        '
        Me.Customer_LastName.DataPropertyName = "Customer_LastName"
        Me.Customer_LastName.HeaderText = "Last Name"
        Me.Customer_LastName.MinimumWidth = 6
        Me.Customer_LastName.Name = "Customer_LastName"
        Me.Customer_LastName.ReadOnly = True
        Me.Customer_LastName.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total_Price"
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Price"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 160
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contact_Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 110
        '
        'Date_Delivered
        '
        Me.Date_Delivered.DataPropertyName = "Date_Delivered"
        Me.Date_Delivered.HeaderText = "Date Delivered"
        Me.Date_Delivered.MinimumWidth = 6
        Me.Date_Delivered.Name = "Date_Delivered"
        Me.Date_Delivered.ReadOnly = True
        Me.Date_Delivered.Width = 150
        '
        'OMSys_OrdersDBBindingSource
        '
        Me.OMSys_OrdersDBBindingSource.DataMember = "OMSys_OrdersDB"
        Me.OMSys_OrdersDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSys_OrdersDBTableAdapter
        '
        Me.OMSys_OrdersDBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OMSys_OrdersDBTableAdapter = Me.OMSys_OrdersDBTableAdapter
        Me.TableAdapterManager.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OMSys_OrdersV2DBTableAdapter
        '
        Me.OMSys_OrdersV2DBTableAdapter.ClearBeforeFill = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(266, 55)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 23)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(533, 41)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 42)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.DarkCyan
        Me.btnViewAll.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(668, 41)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(112, 42)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(263, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "(ID, Customer Name, Product Name, Address or Status)"
        '
        'lbl_OrderID
        '
        Me.lbl_OrderID.AutoSize = True
        Me.lbl_OrderID.Location = New System.Drawing.Point(13, 540)
        Me.lbl_OrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_OrderID.Name = "lbl_OrderID"
        Me.lbl_OrderID.Size = New System.Drawing.Size(65, 19)
        Me.lbl_OrderID.TabIndex = 101
        Me.lbl_OrderID.Text = "Order ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_ID
        '
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "ID", True))
        Me.txt_ID.Enabled = False
        Me.txt_ID.Location = New System.Drawing.Point(97, 537)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(124, 23)
        Me.txt_ID.TabIndex = 4
        '
        'lbl_DateAdded
        '
        Me.lbl_DateAdded.AutoSize = True
        Me.lbl_DateAdded.Location = New System.Drawing.Point(241, 586)
        Me.lbl_DateAdded.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DateAdded.Name = "lbl_DateAdded"
        Me.lbl_DateAdded.Size = New System.Drawing.Size(95, 19)
        Me.lbl_DateAdded.TabIndex = 103
        Me.lbl_DateAdded.Text = "Date Added"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Date_Added", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(370, 581)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(249, 23)
        Me.DateTimePicker1.TabIndex = 6
        '
        'lbl_ProductName
        '
        Me.lbl_ProductName.AutoSize = True
        Me.lbl_ProductName.Location = New System.Drawing.Point(241, 539)
        Me.lbl_ProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ProductName.Name = "lbl_ProductName"
        Me.lbl_ProductName.Size = New System.Drawing.Size(109, 19)
        Me.lbl_ProductName.TabIndex = 105
        Me.lbl_ProductName.Text = "Product Name"
        '
        'txt_ProductName
        '
        Me.txt_ProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Product_Name", True))
        Me.txt_ProductName.Location = New System.Drawing.Point(370, 536)
        Me.txt_ProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(249, 23)
        Me.txt_ProductName.TabIndex = 5
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(654, 540)
        Me.lbl_FirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(79, 19)
        Me.lbl_FirstName.TabIndex = 107
        Me.lbl_FirstName.Text = "First Name"
        '
        'lbl_MiddleName
        '
        Me.lbl_MiddleName.AutoSize = True
        Me.lbl_MiddleName.Location = New System.Drawing.Point(654, 587)
        Me.lbl_MiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_MiddleName.Name = "lbl_MiddleName"
        Me.lbl_MiddleName.Size = New System.Drawing.Size(103, 19)
        Me.lbl_MiddleName.TabIndex = 108
        Me.lbl_MiddleName.Text = "Middle Name"
        '
        'lbl_LastName
        '
        Me.lbl_LastName.AutoSize = True
        Me.lbl_LastName.Location = New System.Drawing.Point(654, 630)
        Me.lbl_LastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(81, 19)
        Me.lbl_LastName.TabIndex = 109
        Me.lbl_LastName.Text = "Last Name"
        '
        'txt_FirstName
        '
        Me.txt_FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_FirstName", True))
        Me.txt_FirstName.Location = New System.Drawing.Point(768, 537)
        Me.txt_FirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(149, 23)
        Me.txt_FirstName.TabIndex = 9
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_MiddleName", True))
        Me.txt_MiddleName.Location = New System.Drawing.Point(768, 583)
        Me.txt_MiddleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(149, 23)
        Me.txt_MiddleName.TabIndex = 10
        '
        'txt_LastName
        '
        Me.txt_LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_LastName", True))
        Me.txt_LastName.Location = New System.Drawing.Point(768, 626)
        Me.txt_LastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(149, 23)
        Me.txt_LastName.TabIndex = 11
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Location = New System.Drawing.Point(654, 709)
        Me.lbl_Quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(70, 19)
        Me.lbl_Quantity.TabIndex = 113
        Me.lbl_Quantity.Text = "Quantity"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Quantity", True))
        Me.txt_Quantity.Location = New System.Drawing.Point(768, 707)
        Me.txt_Quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(149, 23)
        Me.txt_Quantity.TabIndex = 13
        '
        'lbl_TotalPrice
        '
        Me.lbl_TotalPrice.AutoSize = True
        Me.lbl_TotalPrice.Location = New System.Drawing.Point(654, 751)
        Me.lbl_TotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TotalPrice.Name = "lbl_TotalPrice"
        Me.lbl_TotalPrice.Size = New System.Drawing.Size(78, 19)
        Me.lbl_TotalPrice.TabIndex = 115
        Me.lbl_TotalPrice.Text = "Total Price"
        '
        'txt_TotalPrice
        '
        Me.txt_TotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Total_Price", True))
        Me.txt_TotalPrice.Enabled = False
        Me.txt_TotalPrice.Location = New System.Drawing.Point(768, 751)
        Me.txt_TotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TotalPrice.Name = "txt_TotalPrice"
        Me.txt_TotalPrice.Size = New System.Drawing.Size(149, 23)
        Me.txt_TotalPrice.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(975, 541)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Address", True))
        Me.txt_Address.Location = New System.Drawing.Point(1121, 537)
        Me.txt_Address.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(226, 23)
        Me.txt_Address.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(975, 586)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 19)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Contact Number"
        '
        'txt_ContactNumber
        '
        Me.txt_ContactNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Contact_Number", True))
        Me.txt_ContactNumber.Location = New System.Drawing.Point(1121, 582)
        Me.txt_ContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ContactNumber.Name = "txt_ContactNumber"
        Me.txt_ContactNumber.Size = New System.Drawing.Size(226, 23)
        Me.txt_ContactNumber.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Date_Delivered", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(370, 627)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(249, 23)
        Me.DateTimePicker2.TabIndex = 7
        '
        'lbl_DateDelivered
        '
        Me.lbl_DateDelivered.AutoSize = True
        Me.lbl_DateDelivered.Location = New System.Drawing.Point(241, 631)
        Me.lbl_DateDelivered.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DateDelivered.Name = "lbl_DateDelivered"
        Me.lbl_DateDelivered.Size = New System.Drawing.Size(112, 19)
        Me.lbl_DateDelivered.TabIndex = 121
        Me.lbl_DateDelivered.Text = "Date Delivered"
        '
        'btnAddOrder1
        '
        Me.btnAddOrder1.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddOrder1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder1.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder1.Location = New System.Drawing.Point(1569, 45)
        Me.btnAddOrder1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddOrder1.Name = "btnAddOrder1"
        Me.btnAddOrder1.Size = New System.Drawing.Size(112, 42)
        Me.btnAddOrder1.TabIndex = 3
        Me.btnAddOrder1.Text = "New Order"
        Me.btnAddOrder1.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(979, 709)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 42)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmb_Status
        '
        Me.cmb_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Status", True))
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Items.AddRange(New Object() {"PENDING", "PAID", "COMPLETED", "CANCELLED"})
        Me.cmb_Status.Location = New System.Drawing.Point(1121, 625)
        Me.cmb_Status.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(150, 25)
        Me.cmb_Status.TabIndex = 17
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(975, 626)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(50, 19)
        Me.lblStatus.TabIndex = 126
        Me.lblStatus.Text = "Status"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkCyan
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(1248, 708)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 42)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(241, 671)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(42, 19)
        Me.lblNotes.TabIndex = 128
        Me.lblNotes.Text = "Note"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Notes", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(370, 675)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(249, 95)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Total_Price", True))
        Me.txtPrice.Location = New System.Drawing.Point(768, 666)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(149, 23)
        Me.txtPrice.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(654, 668)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(74, 538)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 19)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(347, 537)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 19)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(731, 538)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 19)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(733, 629)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 19)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(720, 707)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 19)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(1024, 625)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 19)
        Me.Label13.TabIndex = 137
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(1034, 541)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 19)
        Me.Label14.TabIndex = 138
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1099, 584)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 19)
        Me.Label15.TabIndex = 139
        Me.Label15.Text = "*"
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.DarkCyan
        Me.btnClearFields.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.ForeColor = System.Drawing.Color.White
        Me.btnClearFields.Location = New System.Drawing.Point(1113, 709)
        Me.btnClearFields.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(112, 42)
        Me.btnClearFields.TabIndex = 140
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1695, 830)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmb_Status)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddOrder1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lbl_DateDelivered)
        Me.Controls.Add(Me.txt_ContactNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TotalPrice)
        Me.Controls.Add(Me.lbl_TotalPrice)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_MiddleName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.lbl_LastName)
        Me.Controls.Add(Me.lbl_MiddleName)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.txt_ProductName)
        Me.Controls.Add(Me.lbl_ProductName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_DateAdded)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lbl_OrderID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.OMSys_OrdersV2DBDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "btnAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMSys"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSys_OrdersDBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents TableAdapterManager As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OMSys_OrdersV2DBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersV2DBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter
    Friend WithEvents OMSys_OrdersV2DBDataGridView As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewAll As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_OrderID As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_DateAdded As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_ProductName As Label
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents txt_FirstName As TextBox
    Friend WithEvents txt_MiddleName As TextBox
    Friend WithEvents txt_LastName As TextBox
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents txt_Quantity As TextBox
    Friend WithEvents lbl_TotalPrice As Label
    Friend WithEvents txt_TotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ContactNumber As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbl_DateDelivered As Label
    Friend WithEvents btnAddOrder1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmb_Status As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblNotes As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Date_Added As DataGridViewTextBoxColumn
    Friend WithEvents Customer_FirstName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_LastName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Date_Delivered As DataGridViewTextBoxColumn
    Friend WithEvents btnClearFields As Button
End Class
