namespace AppCommon.Transport.TransportCustomer
{
    partial class CustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.tbPhoneCriteria = new System.Windows.Forms.TextBox();
            this.lblPhoneCriteria = new System.Windows.Forms.Label();
            this.tbCompanyCriteria = new System.Windows.Forms.TextBox();
            this.tbNameCriteria = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCompanyCriteria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpCustomersList = new System.Windows.Forms.GroupBox();
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblIDCardNumber = new System.Windows.Forms.Label();
            this.tbIDCardNumber = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.grpOpenOrders = new System.Windows.Forms.GroupBox();
            this.lblTotalPaymentCurrency = new System.Windows.Forms.Label();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.tbOrdersCount = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.dgvOpenOrders = new System.Windows.Forms.DataGridView();
            this.OpenOrderIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenOrderTotalQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenOrderTotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenOrderCreatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCloseOrders = new System.Windows.Forms.Button();
            this.cboQuarter = new System.Windows.Forms.ComboBox();
            this.grpClosedOrders = new System.Windows.Forms.GroupBox();
            this.dgvClosedOrders = new System.Windows.Forms.DataGridView();
            this.ClosedOrderIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedOrderTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedOrderTotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedOrderCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedOrderClosedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpOpenOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenOrders)).BeginInit();
            this.grpClosedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpSearch);
            this.splitContainer1.Panel1.Controls.Add(this.grpCustomersList);
            this.splitContainer1.Panel1MinSize = 275;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpCustomerInfo);
            this.splitContainer1.Panel2.Controls.Add(this.lblSeparator);
            this.splitContainer1.Panel2.Controls.Add(this.grpOpenOrders);
            this.splitContainer1.Panel2.Controls.Add(this.cboQuarter);
            this.splitContainer1.Panel2.Controls.Add(this.grpClosedOrders);
            this.splitContainer1.Panel2.Controls.Add(this.lblQuarter);
            this.splitContainer1.Panel2.Controls.Add(this.lblMonth);
            this.splitContainer1.Panel2.Controls.Add(this.cboYear);
            this.splitContainer1.Panel2.Controls.Add(this.cboMonth);
            this.splitContainer1.Panel2.Controls.Add(this.lblYear);
            this.splitContainer1.Panel2MinSize = 600;
            this.splitContainer1.Size = new System.Drawing.Size(1002, 625);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 28;
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.tbPhoneCriteria);
            this.grpSearch.Controls.Add(this.lblPhoneCriteria);
            this.grpSearch.Controls.Add(this.tbCompanyCriteria);
            this.grpSearch.Controls.Add(this.tbNameCriteria);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblCompanyCriteria);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Location = new System.Drawing.Point(6, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(303, 142);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm";
            // 
            // tbPhoneCriteria
            // 
            this.tbPhoneCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneCriteria.Location = new System.Drawing.Point(82, 76);
            this.tbPhoneCriteria.Name = "tbPhoneCriteria";
            this.tbPhoneCriteria.Size = new System.Drawing.Size(215, 22);
            this.tbPhoneCriteria.TabIndex = 21;
            // 
            // lblPhoneCriteria
            // 
            this.lblPhoneCriteria.AutoSize = true;
            this.lblPhoneCriteria.Location = new System.Drawing.Point(6, 79);
            this.lblPhoneCriteria.Name = "lblPhoneCriteria";
            this.lblPhoneCriteria.Size = new System.Drawing.Size(70, 16);
            this.lblPhoneCriteria.TabIndex = 20;
            this.lblPhoneCriteria.Text = "Điện thoại:";
            // 
            // tbCompanyCriteria
            // 
            this.tbCompanyCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompanyCriteria.Location = new System.Drawing.Point(82, 48);
            this.tbCompanyCriteria.Name = "tbCompanyCriteria";
            this.tbCompanyCriteria.Size = new System.Drawing.Size(215, 22);
            this.tbCompanyCriteria.TabIndex = 19;
            // 
            // tbNameCriteria
            // 
            this.tbNameCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameCriteria.Location = new System.Drawing.Point(82, 21);
            this.tbNameCriteria.Name = "tbNameCriteria";
            this.tbNameCriteria.Size = new System.Drawing.Size(215, 22);
            this.tbNameCriteria.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(222, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCompanyCriteria
            // 
            this.lblCompanyCriteria.AutoSize = true;
            this.lblCompanyCriteria.Location = new System.Drawing.Point(6, 51);
            this.lblCompanyCriteria.Name = "lblCompanyCriteria";
            this.lblCompanyCriteria.Size = new System.Drawing.Size(56, 16);
            this.lblCompanyCriteria.TabIndex = 15;
            this.lblCompanyCriteria.Text = "Công ty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên:";
            // 
            // grpCustomersList
            // 
            this.grpCustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomersList.Controls.Add(this.dgvCustomersList);
            this.grpCustomersList.Location = new System.Drawing.Point(6, 152);
            this.grpCustomersList.Name = "grpCustomersList";
            this.grpCustomersList.Size = new System.Drawing.Size(303, 470);
            this.grpCustomersList.TabIndex = 2;
            this.grpCustomersList.TabStop = false;
            this.grpCustomersList.Text = "Khách hàng";
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AllowUserToResizeRows = false;
            this.dgvCustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.CompanyColumn});
            this.dgvCustomersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomersList.Location = new System.Drawing.Point(3, 18);
            this.dgvCustomersList.MultiSelect = false;
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersVisible = false;
            this.dgvCustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersList.Size = new System.Drawing.Size(297, 449);
            this.dgvCustomersList.TabIndex = 0;
            this.dgvCustomersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomersList_DataBindingComplete);
            this.dgvCustomersList.SelectionChanged += new System.EventHandler(this.dgvCustomersList_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "name";
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.DataPropertyName = "company";
            this.CompanyColumn.HeaderText = "Công ty";
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.ReadOnly = true;
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerInfo.Controls.Add(this.lblIDCardNumber);
            this.grpCustomerInfo.Controls.Add(this.tbIDCardNumber);
            this.grpCustomerInfo.Controls.Add(this.tbAddress2);
            this.grpCustomerInfo.Controls.Add(this.lblAddress2);
            this.grpCustomerInfo.Controls.Add(this.tbAddress1);
            this.grpCustomerInfo.Controls.Add(this.lblCompany);
            this.grpCustomerInfo.Controls.Add(this.lblName);
            this.grpCustomerInfo.Controls.Add(this.lblAddress1);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Controls.Add(this.lblMobile);
            this.grpCustomerInfo.Controls.Add(this.tbCompany);
            this.grpCustomerInfo.Controls.Add(this.tbMobile);
            this.grpCustomerInfo.Controls.Add(this.tbName);
            this.grpCustomerInfo.Controls.Add(this.tbPhone);
            this.grpCustomerInfo.Location = new System.Drawing.Point(3, 4);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(677, 181);
            this.grpCustomerInfo.TabIndex = 3;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin chi tiết";
            // 
            // lblIDCardNumber
            // 
            this.lblIDCardNumber.AutoSize = true;
            this.lblIDCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCardNumber.Location = new System.Drawing.Point(7, 141);
            this.lblIDCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCardNumber.Name = "lblIDCardNumber";
            this.lblIDCardNumber.Size = new System.Drawing.Size(51, 16);
            this.lblIDCardNumber.TabIndex = 8;
            this.lblIDCardNumber.Text = "CMND:";
            // 
            // tbIDCardNumber
            // 
            this.tbIDCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIDCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDCardNumber.Location = new System.Drawing.Point(113, 138);
            this.tbIDCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDCardNumber.MaxLength = 9;
            this.tbIDCardNumber.Name = "tbIDCardNumber";
            this.tbIDCardNumber.Size = new System.Drawing.Size(250, 22);
            this.tbIDCardNumber.TabIndex = 7;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress2.Location = new System.Drawing.Point(113, 78);
            this.tbAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(557, 22);
            this.tbAddress2.TabIndex = 4;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(7, 81);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(61, 16);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Địa chỉ 2:";
            // 
            // tbAddress1
            // 
            this.tbAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress1.Location = new System.Drawing.Point(113, 48);
            this.tbAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(557, 22);
            this.tbAddress1.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(7, 21);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(81, 16);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Tên công ty:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 112);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Người đại diện:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(7, 51);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(61, 16);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Địa chỉ 1:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(381, 21);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(381, 112);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(58, 16);
            this.lblMobile.TabIndex = 0;
            this.lblMobile.Text = "Di động:";
            // 
            // tbCompany
            // 
            this.tbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompany.Location = new System.Drawing.Point(113, 18);
            this.tbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(250, 22);
            this.tbCompany.TabIndex = 1;
            // 
            // tbMobile
            // 
            this.tbMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMobile.Location = new System.Drawing.Point(481, 109);
            this.tbMobile.Margin = new System.Windows.Forms.Padding(4);
            this.tbMobile.MaxLength = 20;
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(189, 22);
            this.tbMobile.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(113, 108);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(481, 18);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(189, 22);
            this.tbPhone.TabIndex = 2;
            // 
            // lblSeparator
            // 
            this.lblSeparator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.Location = new System.Drawing.Point(220, 598);
            this.lblSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(12, 16);
            this.lblSeparator.TabIndex = 27;
            this.lblSeparator.Text = "/";
            // 
            // grpOpenOrders
            // 
            this.grpOpenOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOpenOrders.Controls.Add(this.lblTotalPaymentCurrency);
            this.grpOpenOrders.Controls.Add(this.lblOrdersCount);
            this.grpOpenOrders.Controls.Add(this.tbOrdersCount);
            this.grpOpenOrders.Controls.Add(this.lblTotalPayment);
            this.grpOpenOrders.Controls.Add(this.tbTotalPayment);
            this.grpOpenOrders.Controls.Add(this.dgvOpenOrders);
            this.grpOpenOrders.Controls.Add(this.btnCloseOrders);
            this.grpOpenOrders.Location = new System.Drawing.Point(3, 190);
            this.grpOpenOrders.Name = "grpOpenOrders";
            this.grpOpenOrders.Size = new System.Drawing.Size(677, 261);
            this.grpOpenOrders.TabIndex = 4;
            this.grpOpenOrders.TabStop = false;
            this.grpOpenOrders.Text = "Chưa quyết toán";
            // 
            // lblTotalPaymentCurrency
            // 
            this.lblTotalPaymentCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPaymentCurrency.AutoSize = true;
            this.lblTotalPaymentCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentCurrency.Location = new System.Drawing.Point(494, 229);
            this.lblTotalPaymentCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaymentCurrency.Name = "lblTotalPaymentCurrency";
            this.lblTotalPaymentCurrency.Size = new System.Drawing.Size(46, 20);
            this.lblTotalPaymentCurrency.TabIndex = 7;
            this.lblTotalPaymentCurrency.Text = "VNĐ";
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersCount.Location = new System.Drawing.Point(7, 232);
            this.lblOrdersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(113, 16);
            this.lblOrdersCount.TabIndex = 5;
            this.lblOrdersCount.Text = "Tổng số hóa đơn:";
            // 
            // tbOrdersCount
            // 
            this.tbOrdersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrdersCount.Location = new System.Drawing.Point(128, 229);
            this.tbOrdersCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrdersCount.Name = "tbOrdersCount";
            this.tbOrdersCount.ReadOnly = true;
            this.tbOrdersCount.Size = new System.Drawing.Size(44, 22);
            this.tbOrdersCount.TabIndex = 2;
            this.tbOrdersCount.Text = "0";
            this.tbOrdersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(189, 229);
            this.lblTotalPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(89, 20);
            this.lblTotalPayment.TabIndex = 2;
            this.lblTotalPayment.Text = "Tổng tiền:";
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTotalPayment.BackColor = System.Drawing.Color.Red;
            this.tbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPayment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbTotalPayment.Location = new System.Drawing.Point(286, 226);
            this.tbTotalPayment.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.ReadOnly = true;
            this.tbTotalPayment.Size = new System.Drawing.Size(200, 26);
            this.tbTotalPayment.TabIndex = 3;
            this.tbTotalPayment.Text = "0";
            this.tbTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvOpenOrders
            // 
            this.dgvOpenOrders.AllowUserToAddRows = false;
            this.dgvOpenOrders.AllowUserToDeleteRows = false;
            this.dgvOpenOrders.AllowUserToResizeRows = false;
            this.dgvOpenOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OpenOrderIDColumn,
            this.OpenOrderTotalQuantityColumn,
            this.OpenOrderTotalCostColumn,
            this.OpenOrderCreatedDateColumn,
            this.DeliveryStatusColumn});
            this.dgvOpenOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOpenOrders.Location = new System.Drawing.Point(3, 18);
            this.dgvOpenOrders.Name = "dgvOpenOrders";
            this.dgvOpenOrders.ReadOnly = true;
            this.dgvOpenOrders.RowHeadersVisible = false;
            this.dgvOpenOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpenOrders.Size = new System.Drawing.Size(671, 199);
            this.dgvOpenOrders.TabIndex = 1;
            this.dgvOpenOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOpenOrders_CellFormatting);
            // 
            // OpenOrderIDColumn
            // 
            this.OpenOrderIDColumn.DataPropertyName = "id";
            this.OpenOrderIDColumn.HeaderText = "Mã hóa đơn";
            this.OpenOrderIDColumn.Name = "OpenOrderIDColumn";
            this.OpenOrderIDColumn.ReadOnly = true;
            // 
            // OpenOrderTotalQuantityColumn
            // 
            this.OpenOrderTotalQuantityColumn.DataPropertyName = "total_quantity";
            this.OpenOrderTotalQuantityColumn.HeaderText = "Tổng số hàng";
            this.OpenOrderTotalQuantityColumn.Name = "OpenOrderTotalQuantityColumn";
            this.OpenOrderTotalQuantityColumn.ReadOnly = true;
            // 
            // OpenOrderTotalCostColumn
            // 
            this.OpenOrderTotalCostColumn.DataPropertyName = "total_cost";
            this.OpenOrderTotalCostColumn.HeaderText = "Tổng tiền";
            this.OpenOrderTotalCostColumn.Name = "OpenOrderTotalCostColumn";
            this.OpenOrderTotalCostColumn.ReadOnly = true;
            // 
            // OpenOrderCreatedDateColumn
            // 
            this.OpenOrderCreatedDateColumn.DataPropertyName = "created_date";
            dataGridViewCellStyle1.Format = "dd\\/MM\\/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.OpenOrderCreatedDateColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.OpenOrderCreatedDateColumn.HeaderText = "Ngày lập";
            this.OpenOrderCreatedDateColumn.Name = "OpenOrderCreatedDateColumn";
            this.OpenOrderCreatedDateColumn.ReadOnly = true;
            // 
            // DeliveryStatusColumn
            // 
            this.DeliveryStatusColumn.DataPropertyName = "order_status";
            this.DeliveryStatusColumn.HeaderText = "Trạng thái";
            this.DeliveryStatusColumn.Name = "DeliveryStatusColumn";
            this.DeliveryStatusColumn.ReadOnly = true;
            // 
            // btnCloseOrders
            // 
            this.btnCloseOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseOrders.Location = new System.Drawing.Point(583, 224);
            this.btnCloseOrders.Name = "btnCloseOrders";
            this.btnCloseOrders.Size = new System.Drawing.Size(87, 31);
            this.btnCloseOrders.TabIndex = 3;
            this.btnCloseOrders.Text = "Quyết toán";
            this.btnCloseOrders.UseVisualStyleBackColor = true;
            this.btnCloseOrders.Click += new System.EventHandler(this.btnCloseOrders_Click);
            // 
            // cboQuarter
            // 
            this.cboQuarter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuarter.FormattingEnabled = true;
            this.cboQuarter.Location = new System.Drawing.Point(92, 595);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Size = new System.Drawing.Size(121, 24);
            this.cboQuarter.TabIndex = 26;
            // 
            // grpClosedOrders
            // 
            this.grpClosedOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClosedOrders.Controls.Add(this.dgvClosedOrders);
            this.grpClosedOrders.Location = new System.Drawing.Point(3, 457);
            this.grpClosedOrders.Name = "grpClosedOrders";
            this.grpClosedOrders.Size = new System.Drawing.Size(677, 132);
            this.grpClosedOrders.TabIndex = 5;
            this.grpClosedOrders.TabStop = false;
            this.grpClosedOrders.Text = "Đã quyết toán";
            // 
            // dgvClosedOrders
            // 
            this.dgvClosedOrders.AllowUserToAddRows = false;
            this.dgvClosedOrders.AllowUserToDeleteRows = false;
            this.dgvClosedOrders.AllowUserToResizeRows = false;
            this.dgvClosedOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClosedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClosedOrderIDColumn,
            this.ClosedOrderTotalQuantity,
            this.ClosedOrderTotalCostColumn,
            this.ClosedOrderCreatedDate,
            this.ClosedOrderClosedDate});
            this.dgvClosedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClosedOrders.Location = new System.Drawing.Point(3, 18);
            this.dgvClosedOrders.Name = "dgvClosedOrders";
            this.dgvClosedOrders.ReadOnly = true;
            this.dgvClosedOrders.RowHeadersVisible = false;
            this.dgvClosedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClosedOrders.Size = new System.Drawing.Size(671, 111);
            this.dgvClosedOrders.TabIndex = 1;
            this.dgvClosedOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClosedOrders_CellFormatting);
            // 
            // ClosedOrderIDColumn
            // 
            this.ClosedOrderIDColumn.DataPropertyName = "id";
            this.ClosedOrderIDColumn.HeaderText = "Mã hóa đơn";
            this.ClosedOrderIDColumn.Name = "ClosedOrderIDColumn";
            this.ClosedOrderIDColumn.ReadOnly = true;
            // 
            // ClosedOrderTotalQuantity
            // 
            this.ClosedOrderTotalQuantity.DataPropertyName = "total_quantity";
            this.ClosedOrderTotalQuantity.HeaderText = "Tổng số hàng";
            this.ClosedOrderTotalQuantity.Name = "ClosedOrderTotalQuantity";
            this.ClosedOrderTotalQuantity.ReadOnly = true;
            // 
            // ClosedOrderTotalCostColumn
            // 
            this.ClosedOrderTotalCostColumn.DataPropertyName = "total_cost";
            this.ClosedOrderTotalCostColumn.HeaderText = "Tổng tiền";
            this.ClosedOrderTotalCostColumn.Name = "ClosedOrderTotalCostColumn";
            this.ClosedOrderTotalCostColumn.ReadOnly = true;
            // 
            // ClosedOrderCreatedDate
            // 
            this.ClosedOrderCreatedDate.DataPropertyName = "created_date";
            dataGridViewCellStyle2.Format = "dd\\/MM\\/yyyy";
            this.ClosedOrderCreatedDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClosedOrderCreatedDate.HeaderText = "Ngày lập";
            this.ClosedOrderCreatedDate.Name = "ClosedOrderCreatedDate";
            this.ClosedOrderCreatedDate.ReadOnly = true;
            // 
            // ClosedOrderClosedDate
            // 
            this.ClosedOrderClosedDate.DataPropertyName = "closed_date";
            dataGridViewCellStyle3.Format = "dd\\/MM\\/yyyy";
            this.ClosedOrderClosedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClosedOrderClosedDate.HeaderText = "Ngày đóng";
            this.ClosedOrderClosedDate.Name = "ClosedOrderClosedDate";
            this.ClosedOrderClosedDate.ReadOnly = true;
            // 
            // lblQuarter
            // 
            this.lblQuarter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarter.Location = new System.Drawing.Point(45, 598);
            this.lblQuarter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(35, 16);
            this.lblQuarter.TabIndex = 25;
            this.lblQuarter.Text = "Quý:";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(229, 598);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(50, 16);
            this.lblMonth.TabIndex = 21;
            this.lblMonth.Text = "Tháng:";
            // 
            // cboYear
            // 
            this.cboYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(508, 595);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 24);
            this.cboYear.TabIndex = 24;
            // 
            // cboMonth
            // 
            this.cboMonth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(286, 595);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 24);
            this.cboMonth.TabIndex = 22;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(451, 598);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 16);
            this.lblYear.TabIndex = 23;
            this.lblYear.Text = "Năm:";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 636);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerView";
            this.ShowIcon = false;
            this.Text = "Thông tin khách hàng";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpCustomersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpOpenOrders.ResumeLayout(false);
            this.grpOpenOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenOrders)).EndInit();
            this.grpClosedOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.GroupBox grpCustomersList;
        private System.Windows.Forms.DataGridView dgvCustomersList;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox tbPhoneCriteria;
        private System.Windows.Forms.Label lblPhoneCriteria;
        private System.Windows.Forms.TextBox tbCompanyCriteria;
        private System.Windows.Forms.TextBox tbNameCriteria;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCompanyCriteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblIDCardNumber;
        private System.Windows.Forms.TextBox tbIDCardNumber;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.GroupBox grpOpenOrders;
        private System.Windows.Forms.GroupBox grpClosedOrders;
        private System.Windows.Forms.DataGridView dgvOpenOrders;
        private System.Windows.Forms.DataGridView dgvClosedOrders;
        private System.Windows.Forms.Button btnCloseOrders;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboQuarter;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.TextBox tbTotalPayment;
        private System.Windows.Forms.Label lblOrdersCount;
        private System.Windows.Forms.TextBox tbOrdersCount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTotalPaymentCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedOrderIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedOrderTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedOrderTotalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedOrderCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedOrderClosedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenOrderIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenOrderTotalQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenOrderTotalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenOrderCreatedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStatusColumn;
    }
}