namespace AppCommon.Transport.TransportOrder
{
    partial class RegularOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularOrderView));
            this.ctnRegularOrder = new System.Windows.Forms.SplitContainer();
            this.grpOrdersList = new System.Windows.Forms.GroupBox();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearchCriteria = new System.Windows.Forms.GroupBox();
            this.cboDeliveryStatusCriteria = new System.Windows.Forms.ComboBox();
            this.chkUseCreatedDateRangeCriteria = new System.Windows.Forms.CheckBox();
            this.dtpCreatedDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryStatusCriteria = new System.Windows.Forms.Label();
            this.dtpCreatedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateToCriteria = new System.Windows.Forms.Label();
            this.lblCreatedDateCriteria = new System.Windows.Forms.Label();
            this.tbRecipientMobileNumberCriteria = new System.Windows.Forms.TextBox();
            this.lblMobileNumberCriteria = new System.Windows.Forms.Label();
            this.tbRecipientPhoneNumberCriteria = new System.Windows.Forms.TextBox();
            this.tbRecipientNameCriteria = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPhoneNumberCriteria = new System.Windows.Forms.Label();
            this.lblNameCriteria = new System.Windows.Forms.Label();
            this.ucItemsList = new AppCommon.Transport.Order.ItemsListUC();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPaymentStatusText = new System.Windows.Forms.Label();
            this.pnlDeliveryStatus = new System.Windows.Forms.Panel();
            this.rbtnDeliveryStatus_Closed = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Delivered = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Arrived = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Delivering = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Waiting = new System.Windows.Forms.RadioButton();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblTotalCostCurrency = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.tbItemsQuantity = new System.Windows.Forms.TextBox();
            this.lblItemsQuantity = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblDeliveryStatus = new System.Windows.Forms.Label();
            this.ctnCustomersInfo = new System.Windows.Forms.SplitContainer();
            this.grpSenderInfo = new System.Windows.Forms.GroupBox();
            this.btnSenderBrowse = new System.Windows.Forms.Button();
            this.tbSenderPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSenderIDCardNo = new System.Windows.Forms.TextBox();
            this.tbSenderAddress = new System.Windows.Forms.TextBox();
            this.tbSenderName = new System.Windows.Forms.TextBox();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblSenderIDCardNo = new System.Windows.Forms.Label();
            this.lblSenderPhoneNumber = new System.Windows.Forms.Label();
            this.grpRecipientInfo = new System.Windows.Forms.GroupBox();
            this.btnRecipientBrowse = new System.Windows.Forms.Button();
            this.tbRecipientPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbRecipientIDCardNo = new System.Windows.Forms.TextBox();
            this.tbRecipientAddress = new System.Windows.Forms.TextBox();
            this.tbRecipientName = new System.Windows.Forms.TextBox();
            this.lblRecipientAddress = new System.Windows.Forms.Label();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.lblRecipientIDCardNo = new System.Windows.Forms.Label();
            this.lblRecipientPhoneNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctnRegularOrder)).BeginInit();
            this.ctnRegularOrder.Panel1.SuspendLayout();
            this.ctnRegularOrder.Panel2.SuspendLayout();
            this.ctnRegularOrder.SuspendLayout();
            this.grpOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            this.grpSearchCriteria.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            this.pnlDeliveryStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctnCustomersInfo)).BeginInit();
            this.ctnCustomersInfo.Panel1.SuspendLayout();
            this.ctnCustomersInfo.Panel2.SuspendLayout();
            this.ctnCustomersInfo.SuspendLayout();
            this.grpSenderInfo.SuspendLayout();
            this.grpRecipientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctnRegularOrder
            // 
            this.ctnRegularOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctnRegularOrder.Location = new System.Drawing.Point(0, 4);
            this.ctnRegularOrder.Name = "ctnRegularOrder";
            // 
            // ctnRegularOrder.Panel1
            // 
            this.ctnRegularOrder.Panel1.Controls.Add(this.grpOrdersList);
            this.ctnRegularOrder.Panel1.Controls.Add(this.grpSearchCriteria);
            this.ctnRegularOrder.Panel1MinSize = 370;
            // 
            // ctnRegularOrder.Panel2
            // 
            this.ctnRegularOrder.Panel2.Controls.Add(this.ucItemsList);
            this.ctnRegularOrder.Panel2.Controls.Add(this.grpOrderInfo);
            this.ctnRegularOrder.Panel2.Controls.Add(this.ctnCustomersInfo);
            this.ctnRegularOrder.Panel2MinSize = 610;
            this.ctnRegularOrder.Size = new System.Drawing.Size(1008, 726);
            this.ctnRegularOrder.SplitterDistance = 376;
            this.ctnRegularOrder.TabIndex = 26;
            // 
            // grpOrdersList
            // 
            this.grpOrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrdersList.Controls.Add(this.dgvOrdersList);
            this.grpOrdersList.Location = new System.Drawing.Point(0, 195);
            this.grpOrdersList.Name = "grpOrdersList";
            this.grpOrdersList.Size = new System.Drawing.Size(376, 531);
            this.grpOrdersList.TabIndex = 2;
            this.grpOrdersList.TabStop = false;
            this.grpOrdersList.Text = "Hóa đơn";
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AllowUserToAddRows = false;
            this.dgvOrdersList.AllowUserToDeleteRows = false;
            this.dgvOrdersList.AllowUserToResizeRows = false;
            this.dgvOrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.CreatedDateColumn,
            this.DeliveryStatusColumn,
            this.PaymentStatusColumn});
            this.dgvOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersList.Location = new System.Drawing.Point(3, 18);
            this.dgvOrdersList.MultiSelect = false;
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.ReadOnly = true;
            this.dgvOrdersList.RowHeadersVisible = false;
            this.dgvOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersList.Size = new System.Drawing.Size(370, 510);
            this.dgvOrdersList.TabIndex = 1;
            this.dgvOrdersList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdersList_CellFormatting);
            this.dgvOrdersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrdersList_DataBindingComplete);
            this.dgvOrdersList.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOrdersList_RowValidating);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "Mã số";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Width = 52;
            // 
            // CreatedDateColumn
            // 
            this.CreatedDateColumn.DataPropertyName = "created_date";
            this.CreatedDateColumn.HeaderText = "Ngày tạo";
            this.CreatedDateColumn.Name = "CreatedDateColumn";
            this.CreatedDateColumn.ReadOnly = true;
            this.CreatedDateColumn.Width = 81;
            // 
            // DeliveryStatusColumn
            // 
            this.DeliveryStatusColumn.DataPropertyName = "order_status";
            this.DeliveryStatusColumn.HeaderText = "Tình trạng chuyển phát";
            this.DeliveryStatusColumn.Name = "DeliveryStatusColumn";
            this.DeliveryStatusColumn.ReadOnly = true;
            this.DeliveryStatusColumn.Width = 129;
            // 
            // PaymentStatusColumn
            // 
            this.PaymentStatusColumn.DataPropertyName = "payment_status";
            this.PaymentStatusColumn.HeaderText = "Tình trạng thanh toán";
            this.PaymentStatusColumn.Name = "PaymentStatusColumn";
            this.PaymentStatusColumn.ReadOnly = true;
            this.PaymentStatusColumn.Width = 119;
            // 
            // grpSearchCriteria
            // 
            this.grpSearchCriteria.Controls.Add(this.cboDeliveryStatusCriteria);
            this.grpSearchCriteria.Controls.Add(this.chkUseCreatedDateRangeCriteria);
            this.grpSearchCriteria.Controls.Add(this.dtpCreatedDateTo);
            this.grpSearchCriteria.Controls.Add(this.lblDeliveryStatusCriteria);
            this.grpSearchCriteria.Controls.Add(this.dtpCreatedDateFrom);
            this.grpSearchCriteria.Controls.Add(this.lblDateToCriteria);
            this.grpSearchCriteria.Controls.Add(this.lblCreatedDateCriteria);
            this.grpSearchCriteria.Controls.Add(this.tbRecipientMobileNumberCriteria);
            this.grpSearchCriteria.Controls.Add(this.lblMobileNumberCriteria);
            this.grpSearchCriteria.Controls.Add(this.tbRecipientPhoneNumberCriteria);
            this.grpSearchCriteria.Controls.Add(this.tbRecipientNameCriteria);
            this.grpSearchCriteria.Controls.Add(this.btnSearch);
            this.grpSearchCriteria.Controls.Add(this.lblPhoneNumberCriteria);
            this.grpSearchCriteria.Controls.Add(this.lblNameCriteria);
            this.grpSearchCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchCriteria.Location = new System.Drawing.Point(0, 0);
            this.grpSearchCriteria.Name = "grpSearchCriteria";
            this.grpSearchCriteria.Size = new System.Drawing.Size(376, 195);
            this.grpSearchCriteria.TabIndex = 1;
            this.grpSearchCriteria.TabStop = false;
            this.grpSearchCriteria.Text = "Tìm kiếm";
            // 
            // cboDeliveryStatusCriteria
            // 
            this.cboDeliveryStatusCriteria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboDeliveryStatusCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryStatusCriteria.FormattingEnabled = true;
            this.cboDeliveryStatusCriteria.Location = new System.Drawing.Point(85, 136);
            this.cboDeliveryStatusCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeliveryStatusCriteria.Name = "cboDeliveryStatusCriteria";
            this.cboDeliveryStatusCriteria.Size = new System.Drawing.Size(172, 24);
            this.cboDeliveryStatusCriteria.TabIndex = 7;
            // 
            // chkUseCreatedDateRangeCriteria
            // 
            this.chkUseCreatedDateRangeCriteria.AutoSize = true;
            this.chkUseCreatedDateRangeCriteria.Location = new System.Drawing.Point(350, 111);
            this.chkUseCreatedDateRangeCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseCreatedDateRangeCriteria.Name = "chkUseCreatedDateRangeCriteria";
            this.chkUseCreatedDateRangeCriteria.Size = new System.Drawing.Size(15, 14);
            this.chkUseCreatedDateRangeCriteria.TabIndex = 6;
            this.chkUseCreatedDateRangeCriteria.UseVisualStyleBackColor = true;
            this.chkUseCreatedDateRangeCriteria.CheckedChanged += new System.EventHandler(this.chkUseCreatedDateRangeCriteria_CheckedChanged);
            // 
            // dtpCreatedDateTo
            // 
            this.dtpCreatedDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDateTo.Location = new System.Drawing.Point(237, 106);
            this.dtpCreatedDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedDateTo.Name = "dtpCreatedDateTo";
            this.dtpCreatedDateTo.Size = new System.Drawing.Size(105, 22);
            this.dtpCreatedDateTo.TabIndex = 5;
            // 
            // lblDeliveryStatusCriteria
            // 
            this.lblDeliveryStatusCriteria.AutoSize = true;
            this.lblDeliveryStatusCriteria.Location = new System.Drawing.Point(7, 139);
            this.lblDeliveryStatusCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryStatusCriteria.Name = "lblDeliveryStatusCriteria";
            this.lblDeliveryStatusCriteria.Size = new System.Drawing.Size(70, 16);
            this.lblDeliveryStatusCriteria.TabIndex = 22;
            this.lblDeliveryStatusCriteria.Text = "Tình trạng:";
            // 
            // dtpCreatedDateFrom
            // 
            this.dtpCreatedDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDateFrom.Location = new System.Drawing.Point(85, 106);
            this.dtpCreatedDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedDateFrom.Name = "dtpCreatedDateFrom";
            this.dtpCreatedDateFrom.Size = new System.Drawing.Size(105, 22);
            this.dtpCreatedDateFrom.TabIndex = 4;
            // 
            // lblDateToCriteria
            // 
            this.lblDateToCriteria.AutoSize = true;
            this.lblDateToCriteria.Location = new System.Drawing.Point(198, 109);
            this.lblDateToCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateToCriteria.Name = "lblDateToCriteria";
            this.lblDateToCriteria.Size = new System.Drawing.Size(31, 16);
            this.lblDateToCriteria.TabIndex = 23;
            this.lblDateToCriteria.Text = "đến";
            // 
            // lblCreatedDateCriteria
            // 
            this.lblCreatedDateCriteria.AutoSize = true;
            this.lblCreatedDateCriteria.Location = new System.Drawing.Point(7, 109);
            this.lblCreatedDateCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedDateCriteria.Name = "lblCreatedDateCriteria";
            this.lblCreatedDateCriteria.Size = new System.Drawing.Size(66, 16);
            this.lblCreatedDateCriteria.TabIndex = 24;
            this.lblCreatedDateCriteria.Text = "Ngày lập:";
            // 
            // tbRecipientMobileNumberCriteria
            // 
            this.tbRecipientMobileNumberCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientMobileNumberCriteria.Location = new System.Drawing.Point(85, 77);
            this.tbRecipientMobileNumberCriteria.Name = "tbRecipientMobileNumberCriteria";
            this.tbRecipientMobileNumberCriteria.Size = new System.Drawing.Size(280, 22);
            this.tbRecipientMobileNumberCriteria.TabIndex = 3;
            // 
            // lblMobileNumberCriteria
            // 
            this.lblMobileNumberCriteria.AutoSize = true;
            this.lblMobileNumberCriteria.Location = new System.Drawing.Point(7, 80);
            this.lblMobileNumberCriteria.Name = "lblMobileNumberCriteria";
            this.lblMobileNumberCriteria.Size = new System.Drawing.Size(58, 16);
            this.lblMobileNumberCriteria.TabIndex = 20;
            this.lblMobileNumberCriteria.Text = "Di động:";
            // 
            // tbRecipientPhoneNumberCriteria
            // 
            this.tbRecipientPhoneNumberCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientPhoneNumberCriteria.Location = new System.Drawing.Point(85, 49);
            this.tbRecipientPhoneNumberCriteria.Name = "tbRecipientPhoneNumberCriteria";
            this.tbRecipientPhoneNumberCriteria.Size = new System.Drawing.Size(280, 22);
            this.tbRecipientPhoneNumberCriteria.TabIndex = 2;
            // 
            // tbRecipientNameCriteria
            // 
            this.tbRecipientNameCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientNameCriteria.Location = new System.Drawing.Point(85, 21);
            this.tbRecipientNameCriteria.Name = "tbRecipientNameCriteria";
            this.tbRecipientNameCriteria.Size = new System.Drawing.Size(280, 22);
            this.tbRecipientNameCriteria.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(6, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPhoneNumberCriteria
            // 
            this.lblPhoneNumberCriteria.AutoSize = true;
            this.lblPhoneNumberCriteria.Location = new System.Drawing.Point(7, 52);
            this.lblPhoneNumberCriteria.Name = "lblPhoneNumberCriteria";
            this.lblPhoneNumberCriteria.Size = new System.Drawing.Size(70, 16);
            this.lblPhoneNumberCriteria.TabIndex = 15;
            this.lblPhoneNumberCriteria.Text = "Điện thoại:";
            // 
            // lblNameCriteria
            // 
            this.lblNameCriteria.AutoSize = true;
            this.lblNameCriteria.Location = new System.Drawing.Point(7, 24);
            this.lblNameCriteria.Name = "lblNameCriteria";
            this.lblNameCriteria.Size = new System.Drawing.Size(35, 16);
            this.lblNameCriteria.TabIndex = 13;
            this.lblNameCriteria.Text = "Tên:";
            // 
            // ucItemsList
            // 
            this.ucItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucItemsList.Location = new System.Drawing.Point(0, 315);
            this.ucItemsList.Margin = new System.Windows.Forms.Padding(2);
            this.ucItemsList.Name = "ucItemsList";
            this.ucItemsList.OrderID = "";
            this.ucItemsList.OrderItems = ((System.Collections.ObjectModel.Collection<DBManagement.OrderItem>)(resources.GetObject("ucItemsList.OrderItems")));
            this.ucItemsList.Size = new System.Drawing.Size(628, 411);
            this.ucItemsList.TabIndex = 3;
            this.ucItemsList.Validating += new System.ComponentModel.CancelEventHandler(this.ucItemsList_Validating);
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.cboDestination);
            this.grpOrderInfo.Controls.Add(this.lblDestination);
            this.grpOrderInfo.Controls.Add(this.lblPaymentStatusText);
            this.grpOrderInfo.Controls.Add(this.pnlDeliveryStatus);
            this.grpOrderInfo.Controls.Add(this.btnChangeStatus);
            this.grpOrderInfo.Controls.Add(this.lblTotalCostCurrency);
            this.grpOrderInfo.Controls.Add(this.tbTotalCost);
            this.grpOrderInfo.Controls.Add(this.lblTotalCost);
            this.grpOrderInfo.Controls.Add(this.tbItemsQuantity);
            this.grpOrderInfo.Controls.Add(this.lblItemsQuantity);
            this.grpOrderInfo.Controls.Add(this.lblPaymentStatus);
            this.grpOrderInfo.Controls.Add(this.lblDeliveryStatus);
            this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOrderInfo.Location = new System.Drawing.Point(0, 142);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(628, 168);
            this.grpOrderInfo.TabIndex = 2;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Chi tiết hóa đơn";
            // 
            // cboDestination
            // 
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(110, 21);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(178, 24);
            this.cboDestination.TabIndex = 1;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(7, 24);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(58, 16);
            this.lblDestination.TabIndex = 29;
            this.lblDestination.Text = "Nơi đến:";
            // 
            // lblPaymentStatusText
            // 
            this.lblPaymentStatusText.AutoSize = true;
            this.lblPaymentStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatusText.Location = new System.Drawing.Point(107, 82);
            this.lblPaymentStatusText.Name = "lblPaymentStatusText";
            this.lblPaymentStatusText.Size = new System.Drawing.Size(135, 16);
            this.lblPaymentStatusText.TabIndex = 0;
            this.lblPaymentStatusText.Text = "<Payment_Status>";
            // 
            // pnlDeliveryStatus
            // 
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Closed);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Delivered);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Arrived);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Delivering);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Waiting);
            this.pnlDeliveryStatus.Location = new System.Drawing.Point(110, 51);
            this.pnlDeliveryStatus.Name = "pnlDeliveryStatus";
            this.pnlDeliveryStatus.Size = new System.Drawing.Size(496, 22);
            this.pnlDeliveryStatus.TabIndex = 2;
            // 
            // rbtnDeliveryStatus_Closed
            // 
            this.rbtnDeliveryStatus_Closed.AutoSize = true;
            this.rbtnDeliveryStatus_Closed.Enabled = false;
            this.rbtnDeliveryStatus_Closed.Location = new System.Drawing.Point(400, 1);
            this.rbtnDeliveryStatus_Closed.Name = "rbtnDeliveryStatus_Closed";
            this.rbtnDeliveryStatus_Closed.Size = new System.Drawing.Size(94, 20);
            this.rbtnDeliveryStatus_Closed.TabIndex = 5;
            this.rbtnDeliveryStatus_Closed.TabStop = true;
            this.rbtnDeliveryStatus_Closed.Text = "Hoàn thành";
            this.rbtnDeliveryStatus_Closed.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Delivered
            // 
            this.rbtnDeliveryStatus_Delivered.AutoSize = true;
            this.rbtnDeliveryStatus_Delivered.Location = new System.Drawing.Point(320, 1);
            this.rbtnDeliveryStatus_Delivered.Name = "rbtnDeliveryStatus_Delivered";
            this.rbtnDeliveryStatus_Delivered.Size = new System.Drawing.Size(73, 20);
            this.rbtnDeliveryStatus_Delivered.TabIndex = 4;
            this.rbtnDeliveryStatus_Delivered.TabStop = true;
            this.rbtnDeliveryStatus_Delivered.Text = "Đã giao";
            this.rbtnDeliveryStatus_Delivered.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Arrived
            // 
            this.rbtnDeliveryStatus_Arrived.AutoSize = true;
            this.rbtnDeliveryStatus_Arrived.Location = new System.Drawing.Point(227, 1);
            this.rbtnDeliveryStatus_Arrived.Name = "rbtnDeliveryStatus_Arrived";
            this.rbtnDeliveryStatus_Arrived.Size = new System.Drawing.Size(60, 20);
            this.rbtnDeliveryStatus_Arrived.TabIndex = 3;
            this.rbtnDeliveryStatus_Arrived.TabStop = true;
            this.rbtnDeliveryStatus_Arrived.Text = "Đã tới";
            this.rbtnDeliveryStatus_Arrived.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Delivering
            // 
            this.rbtnDeliveryStatus_Delivering.AutoSize = true;
            this.rbtnDeliveryStatus_Delivering.Location = new System.Drawing.Point(104, 1);
            this.rbtnDeliveryStatus_Delivering.Name = "rbtnDeliveryStatus_Delivering";
            this.rbtnDeliveryStatus_Delivering.Size = new System.Drawing.Size(104, 20);
            this.rbtnDeliveryStatus_Delivering.TabIndex = 2;
            this.rbtnDeliveryStatus_Delivering.TabStop = true;
            this.rbtnDeliveryStatus_Delivering.Text = "Đang chuyển";
            this.rbtnDeliveryStatus_Delivering.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Waiting
            // 
            this.rbtnDeliveryStatus_Waiting.AutoSize = true;
            this.rbtnDeliveryStatus_Waiting.Location = new System.Drawing.Point(3, 1);
            this.rbtnDeliveryStatus_Waiting.Name = "rbtnDeliveryStatus_Waiting";
            this.rbtnDeliveryStatus_Waiting.Size = new System.Drawing.Size(83, 20);
            this.rbtnDeliveryStatus_Waiting.TabIndex = 1;
            this.rbtnDeliveryStatus_Waiting.TabStop = true;
            this.rbtnDeliveryStatus_Waiting.Text = "Đang chờ";
            this.rbtnDeliveryStatus_Waiting.UseVisualStyleBackColor = true;
            this.rbtnDeliveryStatus_Waiting.CheckedChanged += new System.EventHandler(this.rbtnDeliveryStatus_Waiting_CheckedChanged);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(480, 78);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(126, 24);
            this.btnChangeStatus.TabIndex = 3;
            this.btnChangeStatus.Text = "Thay đổi trạng thái";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // lblTotalCostCurrency
            // 
            this.lblTotalCostCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCostCurrency.AutoSize = true;
            this.lblTotalCostCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostCurrency.Location = new System.Drawing.Point(566, 140);
            this.lblTotalCostCurrency.Name = "lblTotalCostCurrency";
            this.lblTotalCostCurrency.Size = new System.Drawing.Size(40, 16);
            this.lblTotalCostCurrency.TabIndex = 8;
            this.lblTotalCostCurrency.Text = "VND";
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalCost.Enabled = false;
            this.tbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCost.Location = new System.Drawing.Point(110, 137);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(450, 22);
            this.tbTotalCost.TabIndex = 5;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(7, 140);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(77, 16);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Tổng tiền:";
            // 
            // tbItemsQuantity
            // 
            this.tbItemsQuantity.Enabled = false;
            this.tbItemsQuantity.Location = new System.Drawing.Point(110, 109);
            this.tbItemsQuantity.Name = "tbItemsQuantity";
            this.tbItemsQuantity.ReadOnly = true;
            this.tbItemsQuantity.Size = new System.Drawing.Size(90, 22);
            this.tbItemsQuantity.TabIndex = 4;
            // 
            // lblItemsQuantity
            // 
            this.lblItemsQuantity.AutoSize = true;
            this.lblItemsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsQuantity.Location = new System.Drawing.Point(7, 112);
            this.lblItemsQuantity.Name = "lblItemsQuantity";
            this.lblItemsQuantity.Size = new System.Drawing.Size(97, 16);
            this.lblItemsQuantity.TabIndex = 2;
            this.lblItemsQuantity.Text = "Số lượng hàng:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(7, 82);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(78, 16);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "Thanh toán:";
            // 
            // lblDeliveryStatus
            // 
            this.lblDeliveryStatus.AutoSize = true;
            this.lblDeliveryStatus.Location = new System.Drawing.Point(7, 54);
            this.lblDeliveryStatus.Name = "lblDeliveryStatus";
            this.lblDeliveryStatus.Size = new System.Drawing.Size(71, 16);
            this.lblDeliveryStatus.TabIndex = 0;
            this.lblDeliveryStatus.Text = "Trạng thái:";
            // 
            // ctnCustomersInfo
            // 
            this.ctnCustomersInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctnCustomersInfo.Location = new System.Drawing.Point(0, 0);
            this.ctnCustomersInfo.Name = "ctnCustomersInfo";
            // 
            // ctnCustomersInfo.Panel1
            // 
            this.ctnCustomersInfo.Panel1.Controls.Add(this.grpSenderInfo);
            this.ctnCustomersInfo.Panel1MinSize = 250;
            // 
            // ctnCustomersInfo.Panel2
            // 
            this.ctnCustomersInfo.Panel2.Controls.Add(this.grpRecipientInfo);
            this.ctnCustomersInfo.Panel2MinSize = 250;
            this.ctnCustomersInfo.Size = new System.Drawing.Size(628, 142);
            this.ctnCustomersInfo.SplitterDistance = 312;
            this.ctnCustomersInfo.TabIndex = 1;
            // 
            // grpSenderInfo
            // 
            this.grpSenderInfo.Controls.Add(this.btnSenderBrowse);
            this.grpSenderInfo.Controls.Add(this.tbSenderPhoneNumber);
            this.grpSenderInfo.Controls.Add(this.tbSenderIDCardNo);
            this.grpSenderInfo.Controls.Add(this.tbSenderAddress);
            this.grpSenderInfo.Controls.Add(this.tbSenderName);
            this.grpSenderInfo.Controls.Add(this.lblSenderAddress);
            this.grpSenderInfo.Controls.Add(this.lblSenderName);
            this.grpSenderInfo.Controls.Add(this.lblSenderIDCardNo);
            this.grpSenderInfo.Controls.Add(this.lblSenderPhoneNumber);
            this.grpSenderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSenderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSenderInfo.Location = new System.Drawing.Point(0, 0);
            this.grpSenderInfo.Name = "grpSenderInfo";
            this.grpSenderInfo.Size = new System.Drawing.Size(312, 142);
            this.grpSenderInfo.TabIndex = 1;
            this.grpSenderInfo.TabStop = false;
            this.grpSenderInfo.Text = "Thông tin người gửi:";
            // 
            // btnSenderBrowse
            // 
            this.btnSenderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSenderBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenderBrowse.Location = new System.Drawing.Point(246, 45);
            this.btnSenderBrowse.Name = "btnSenderBrowse";
            this.btnSenderBrowse.Size = new System.Drawing.Size(60, 40);
            this.btnSenderBrowse.TabIndex = 5;
            this.btnSenderBrowse.Text = "Chọn";
            this.btnSenderBrowse.UseVisualStyleBackColor = true;
            this.btnSenderBrowse.Click += new System.EventHandler(this.btnSenderBrowse_Click);
            // 
            // tbSenderPhoneNumber
            // 
            this.tbSenderPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderPhoneNumber.Enabled = false;
            this.tbSenderPhoneNumber.Location = new System.Drawing.Point(82, 54);
            this.tbSenderPhoneNumber.Name = "tbSenderPhoneNumber";
            this.tbSenderPhoneNumber.Size = new System.Drawing.Size(158, 22);
            this.tbSenderPhoneNumber.TabIndex = 2;
            // 
            // tbSenderIDCardNo
            // 
            this.tbSenderIDCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderIDCardNo.Enabled = false;
            this.tbSenderIDCardNo.Location = new System.Drawing.Point(82, 83);
            this.tbSenderIDCardNo.Name = "tbSenderIDCardNo";
            this.tbSenderIDCardNo.Size = new System.Drawing.Size(158, 22);
            this.tbSenderIDCardNo.TabIndex = 3;
            // 
            // tbSenderAddress
            // 
            this.tbSenderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderAddress.Enabled = false;
            this.tbSenderAddress.Location = new System.Drawing.Point(82, 112);
            this.tbSenderAddress.Name = "tbSenderAddress";
            this.tbSenderAddress.Size = new System.Drawing.Size(224, 22);
            this.tbSenderAddress.TabIndex = 4;
            // 
            // tbSenderName
            // 
            this.tbSenderName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderName.Enabled = false;
            this.tbSenderName.Location = new System.Drawing.Point(82, 25);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(158, 22);
            this.tbSenderName.TabIndex = 1;
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.AutoSize = true;
            this.lblSenderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAddress.Location = new System.Drawing.Point(6, 115);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(51, 16);
            this.lblSenderAddress.TabIndex = 0;
            this.lblSenderAddress.Text = "Địa chỉ:";
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.Location = new System.Drawing.Point(6, 28);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(50, 16);
            this.lblSenderName.TabIndex = 0;
            this.lblSenderName.Text = "Họ tên:";
            // 
            // lblSenderIDCardNo
            // 
            this.lblSenderIDCardNo.AutoSize = true;
            this.lblSenderIDCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderIDCardNo.Location = new System.Drawing.Point(6, 86);
            this.lblSenderIDCardNo.Name = "lblSenderIDCardNo";
            this.lblSenderIDCardNo.Size = new System.Drawing.Size(51, 16);
            this.lblSenderIDCardNo.TabIndex = 0;
            this.lblSenderIDCardNo.Text = "CMND:";
            // 
            // lblSenderPhoneNumber
            // 
            this.lblSenderPhoneNumber.AutoSize = true;
            this.lblSenderPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderPhoneNumber.Location = new System.Drawing.Point(6, 57);
            this.lblSenderPhoneNumber.Name = "lblSenderPhoneNumber";
            this.lblSenderPhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.lblSenderPhoneNumber.TabIndex = 0;
            this.lblSenderPhoneNumber.Text = "Điện thoại:";
            // 
            // grpRecipientInfo
            // 
            this.grpRecipientInfo.Controls.Add(this.btnRecipientBrowse);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientPhoneNumber);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientIDCardNo);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientAddress);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientName);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientAddress);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientName);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientIDCardNo);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientPhoneNumber);
            this.grpRecipientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecipientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipientInfo.Location = new System.Drawing.Point(0, 0);
            this.grpRecipientInfo.Name = "grpRecipientInfo";
            this.grpRecipientInfo.Size = new System.Drawing.Size(312, 142);
            this.grpRecipientInfo.TabIndex = 2;
            this.grpRecipientInfo.TabStop = false;
            this.grpRecipientInfo.Text = "Thông tin người nhận:";
            // 
            // btnRecipientBrowse
            // 
            this.btnRecipientBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecipientBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipientBrowse.Location = new System.Drawing.Point(246, 45);
            this.btnRecipientBrowse.Name = "btnRecipientBrowse";
            this.btnRecipientBrowse.Size = new System.Drawing.Size(60, 40);
            this.btnRecipientBrowse.TabIndex = 5;
            this.btnRecipientBrowse.Text = "Chọn";
            this.btnRecipientBrowse.UseVisualStyleBackColor = true;
            this.btnRecipientBrowse.Click += new System.EventHandler(this.btnRecipientBrowse_Click);
            // 
            // tbRecipientPhoneNumber
            // 
            this.tbRecipientPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientPhoneNumber.Enabled = false;
            this.tbRecipientPhoneNumber.Location = new System.Drawing.Point(82, 54);
            this.tbRecipientPhoneNumber.Name = "tbRecipientPhoneNumber";
            this.tbRecipientPhoneNumber.Size = new System.Drawing.Size(158, 22);
            this.tbRecipientPhoneNumber.TabIndex = 2;
            // 
            // tbRecipientIDCardNo
            // 
            this.tbRecipientIDCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientIDCardNo.Enabled = false;
            this.tbRecipientIDCardNo.Location = new System.Drawing.Point(82, 83);
            this.tbRecipientIDCardNo.Name = "tbRecipientIDCardNo";
            this.tbRecipientIDCardNo.Size = new System.Drawing.Size(158, 22);
            this.tbRecipientIDCardNo.TabIndex = 3;
            // 
            // tbRecipientAddress
            // 
            this.tbRecipientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientAddress.Enabled = false;
            this.tbRecipientAddress.Location = new System.Drawing.Point(82, 112);
            this.tbRecipientAddress.Name = "tbRecipientAddress";
            this.tbRecipientAddress.Size = new System.Drawing.Size(224, 22);
            this.tbRecipientAddress.TabIndex = 4;
            // 
            // tbRecipientName
            // 
            this.tbRecipientName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientName.Enabled = false;
            this.tbRecipientName.Location = new System.Drawing.Point(82, 25);
            this.tbRecipientName.Name = "tbRecipientName";
            this.tbRecipientName.Size = new System.Drawing.Size(158, 22);
            this.tbRecipientName.TabIndex = 1;
            // 
            // lblRecipientAddress
            // 
            this.lblRecipientAddress.AutoSize = true;
            this.lblRecipientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientAddress.Location = new System.Drawing.Point(6, 115);
            this.lblRecipientAddress.Name = "lblRecipientAddress";
            this.lblRecipientAddress.Size = new System.Drawing.Size(51, 16);
            this.lblRecipientAddress.TabIndex = 0;
            this.lblRecipientAddress.Text = "Địa chỉ:";
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.AutoSize = true;
            this.lblRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientName.Location = new System.Drawing.Point(6, 28);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(50, 16);
            this.lblRecipientName.TabIndex = 0;
            this.lblRecipientName.Text = "Họ tên:";
            // 
            // lblRecipientIDCardNo
            // 
            this.lblRecipientIDCardNo.AutoSize = true;
            this.lblRecipientIDCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientIDCardNo.Location = new System.Drawing.Point(6, 86);
            this.lblRecipientIDCardNo.Name = "lblRecipientIDCardNo";
            this.lblRecipientIDCardNo.Size = new System.Drawing.Size(51, 16);
            this.lblRecipientIDCardNo.TabIndex = 0;
            this.lblRecipientIDCardNo.Text = "CMND:";
            // 
            // lblRecipientPhoneNumber
            // 
            this.lblRecipientPhoneNumber.AutoSize = true;
            this.lblRecipientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientPhoneNumber.Location = new System.Drawing.Point(6, 57);
            this.lblRecipientPhoneNumber.Name = "lblRecipientPhoneNumber";
            this.lblRecipientPhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.lblRecipientPhoneNumber.TabIndex = 0;
            this.lblRecipientPhoneNumber.Text = "Điện thoại:";
            // 
            // RegularOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.ctnRegularOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegularOrderView";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.Text = "Hóa đơn sĩ";
            this.ctnRegularOrder.Panel1.ResumeLayout(false);
            this.ctnRegularOrder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctnRegularOrder)).EndInit();
            this.ctnRegularOrder.ResumeLayout(false);
            this.grpOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            this.grpSearchCriteria.ResumeLayout(false);
            this.grpSearchCriteria.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.pnlDeliveryStatus.ResumeLayout(false);
            this.pnlDeliveryStatus.PerformLayout();
            this.ctnCustomersInfo.Panel1.ResumeLayout(false);
            this.ctnCustomersInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctnCustomersInfo)).EndInit();
            this.ctnCustomersInfo.ResumeLayout(false);
            this.grpSenderInfo.ResumeLayout(false);
            this.grpSenderInfo.PerformLayout();
            this.grpRecipientInfo.ResumeLayout(false);
            this.grpRecipientInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrdersList;
        private System.Windows.Forms.GroupBox grpSearchCriteria;
        private System.Windows.Forms.TextBox tbRecipientMobileNumberCriteria;
        private System.Windows.Forms.Label lblMobileNumberCriteria;
        private System.Windows.Forms.TextBox tbRecipientPhoneNumberCriteria;
        private System.Windows.Forms.TextBox tbRecipientNameCriteria;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPhoneNumberCriteria;
        private System.Windows.Forms.Label lblNameCriteria;
        private System.Windows.Forms.DataGridView dgvOrdersList;
        private Order.ItemsListUC ucItemsList;
        private System.Windows.Forms.GroupBox grpRecipientInfo;
        private System.Windows.Forms.Button btnRecipientBrowse;
        private System.Windows.Forms.TextBox tbRecipientPhoneNumber;
        private System.Windows.Forms.TextBox tbRecipientIDCardNo;
        private System.Windows.Forms.TextBox tbRecipientAddress;
        private System.Windows.Forms.TextBox tbRecipientName;
        private System.Windows.Forms.Label lblRecipientAddress;
        private System.Windows.Forms.Label lblRecipientName;
        private System.Windows.Forms.Label lblRecipientIDCardNo;
        private System.Windows.Forms.Label lblRecipientPhoneNumber;
        private System.Windows.Forms.GroupBox grpSenderInfo;
        private System.Windows.Forms.Button btnSenderBrowse;
        private System.Windows.Forms.TextBox tbSenderPhoneNumber;
        private System.Windows.Forms.TextBox tbSenderIDCardNo;
        private System.Windows.Forms.TextBox tbSenderAddress;
        private System.Windows.Forms.TextBox tbSenderName;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblSenderIDCardNo;
        private System.Windows.Forms.Label lblSenderPhoneNumber;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.TextBox tbItemsQuantity;
        private System.Windows.Forms.Label lblItemsQuantity;
        private System.Windows.Forms.Label lblTotalCostCurrency;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblDeliveryStatus;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.SplitContainer ctnCustomersInfo;
        private System.Windows.Forms.SplitContainer ctnRegularOrder;
        private System.Windows.Forms.Panel pnlDeliveryStatus;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Closed;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Delivered;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Arrived;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Delivering;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Waiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatusColumn;
        private System.Windows.Forms.Label lblPaymentStatusText;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cboDeliveryStatusCriteria;
        private System.Windows.Forms.CheckBox chkUseCreatedDateRangeCriteria;
        private System.Windows.Forms.DateTimePicker dtpCreatedDateTo;
        private System.Windows.Forms.Label lblDeliveryStatusCriteria;
        private System.Windows.Forms.DateTimePicker dtpCreatedDateFrom;
        private System.Windows.Forms.Label lblDateToCriteria;
        private System.Windows.Forms.Label lblCreatedDateCriteria;
    }
}