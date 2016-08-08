namespace AppCommon.Transport.TransportOrder
{
    partial class IrregularOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrregularOrderView));
            this.ctnIrregularOrder = new System.Windows.Forms.SplitContainer();
            this.grpOrdersList = new System.Windows.Forms.GroupBox();
            this.cboDeliveryStatusCriteria = new System.Windows.Forms.ComboBox();
            this.chkUseCreatedDateRangeCriteria = new System.Windows.Forms.CheckBox();
            this.dtpCreatedDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryStatusCriteria = new System.Windows.Forms.Label();
            this.dtpCreatedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tbRecipientPhoneCriteria = new System.Windows.Forms.TextBox();
            this.tbRecipientIDCardNoCriteria = new System.Windows.Forms.TextBox();
            this.lblDateToCriteria = new System.Windows.Forms.Label();
            this.tbRecipientNameCriteria = new System.Windows.Forms.TextBox();
            this.lblCreatedDateCriteria = new System.Windows.Forms.Label();
            this.lblPhoneNumberCriteria = new System.Windows.Forms.Label();
            this.lblIDCardNoCriteria = new System.Windows.Forms.Label();
            this.lblRecipientNameCriteria = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucItemsList = new AppCommon.Transport.Order.ItemsListUC();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.pnlPaymentStatus = new System.Windows.Forms.Panel();
            this.rbtnPaymentStatus_Unpaid = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentStatus_Paid = new System.Windows.Forms.RadioButton();
            this.pnlDeliveryStatus = new System.Windows.Forms.Panel();
            this.rbtnDeliveryStatus_Waiting = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Delivering = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Arrived = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Delivered = new System.Windows.Forms.RadioButton();
            this.rbtnDeliveryStatus_Closed = new System.Windows.Forms.RadioButton();
            this.lblClosedDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblCreatedDateText = new System.Windows.Forms.Label();
            this.lblClosedDateText = new System.Windows.Forms.Label();
            this.lblCreatedByText = new System.Windows.Forms.Label();
            this.lblOrderIdText = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTotalCostCurrency = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.tbItemsQuantity = new System.Windows.Forms.TextBox();
            this.lblItemsQuantity = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblDeliveryStatus = new System.Windows.Forms.Label();
            this.ctnCustomersInfo = new System.Windows.Forms.SplitContainer();
            this.grpSenderInfo = new System.Windows.Forms.GroupBox();
            this.tbSenderAddress = new System.Windows.Forms.TextBox();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.tbSenderPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSenderIDCardNo = new System.Windows.Forms.TextBox();
            this.tbSenderName = new System.Windows.Forms.TextBox();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblSenderIDCardNo = new System.Windows.Forms.Label();
            this.lblSenderPhoneNumber = new System.Windows.Forms.Label();
            this.grpRecipientInfo = new System.Windows.Forms.GroupBox();
            this.tbRecipientAddress = new System.Windows.Forms.TextBox();
            this.lblRecipientAddress = new System.Windows.Forms.Label();
            this.tbRecipientPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbRecipientIDCardNo = new System.Windows.Forms.TextBox();
            this.tbRecipientName = new System.Windows.Forms.TextBox();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.lblRecipientIDCardNo = new System.Windows.Forms.Label();
            this.lblRecipientPhoneNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctnIrregularOrder)).BeginInit();
            this.ctnIrregularOrder.Panel1.SuspendLayout();
            this.ctnIrregularOrder.Panel2.SuspendLayout();
            this.ctnIrregularOrder.SuspendLayout();
            this.grpOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            this.grpOrderInfo.SuspendLayout();
            this.pnlPaymentStatus.SuspendLayout();
            this.pnlDeliveryStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctnCustomersInfo)).BeginInit();
            this.ctnCustomersInfo.Panel1.SuspendLayout();
            this.ctnCustomersInfo.Panel2.SuspendLayout();
            this.ctnCustomersInfo.SuspendLayout();
            this.grpSenderInfo.SuspendLayout();
            this.grpRecipientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctnIrregularOrder
            // 
            this.ctnIrregularOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctnIrregularOrder.Location = new System.Drawing.Point(0, 4);
            this.ctnIrregularOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ctnIrregularOrder.Name = "ctnIrregularOrder";
            // 
            // ctnIrregularOrder.Panel1
            // 
            this.ctnIrregularOrder.Panel1.Controls.Add(this.grpOrdersList);
            this.ctnIrregularOrder.Panel1MinSize = 410;
            // 
            // ctnIrregularOrder.Panel2
            // 
            this.ctnIrregularOrder.Panel2.Controls.Add(this.ucItemsList);
            this.ctnIrregularOrder.Panel2.Controls.Add(this.grpOrderInfo);
            this.ctnIrregularOrder.Panel2.Controls.Add(this.ctnCustomersInfo);
            this.ctnIrregularOrder.Panel2MinSize = 590;
            this.ctnIrregularOrder.Size = new System.Drawing.Size(1008, 686);
            this.ctnIrregularOrder.SplitterDistance = 410;
            this.ctnIrregularOrder.TabIndex = 1;
            // 
            // grpOrdersList
            // 
            this.grpOrdersList.Controls.Add(this.cboDeliveryStatusCriteria);
            this.grpOrdersList.Controls.Add(this.chkUseCreatedDateRangeCriteria);
            this.grpOrdersList.Controls.Add(this.dtpCreatedDateTo);
            this.grpOrdersList.Controls.Add(this.lblDeliveryStatusCriteria);
            this.grpOrdersList.Controls.Add(this.dtpCreatedDateFrom);
            this.grpOrdersList.Controls.Add(this.tbRecipientPhoneCriteria);
            this.grpOrdersList.Controls.Add(this.tbRecipientIDCardNoCriteria);
            this.grpOrdersList.Controls.Add(this.lblDateToCriteria);
            this.grpOrdersList.Controls.Add(this.tbRecipientNameCriteria);
            this.grpOrdersList.Controls.Add(this.lblCreatedDateCriteria);
            this.grpOrdersList.Controls.Add(this.lblPhoneNumberCriteria);
            this.grpOrdersList.Controls.Add(this.lblIDCardNoCriteria);
            this.grpOrdersList.Controls.Add(this.lblRecipientNameCriteria);
            this.grpOrdersList.Controls.Add(this.btnSearch);
            this.grpOrdersList.Controls.Add(this.dgvOrdersList);
            this.grpOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrdersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrdersList.Location = new System.Drawing.Point(0, 0);
            this.grpOrdersList.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrdersList.Name = "grpOrdersList";
            this.grpOrdersList.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrdersList.Size = new System.Drawing.Size(410, 686);
            this.grpOrdersList.TabIndex = 1;
            this.grpOrdersList.TabStop = false;
            this.grpOrdersList.Text = "Danh sách hóa đơn:";
            // 
            // cboDeliveryStatusCriteria
            // 
            this.cboDeliveryStatusCriteria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboDeliveryStatusCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryStatusCriteria.FormattingEnabled = true;
            this.cboDeliveryStatusCriteria.Location = new System.Drawing.Point(100, 143);
            this.cboDeliveryStatusCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeliveryStatusCriteria.Name = "cboDeliveryStatusCriteria";
            this.cboDeliveryStatusCriteria.Size = new System.Drawing.Size(172, 24);
            this.cboDeliveryStatusCriteria.TabIndex = 7;
            // 
            // chkUseCreatedDateRangeCriteria
            // 
            this.chkUseCreatedDateRangeCriteria.AutoSize = true;
            this.chkUseCreatedDateRangeCriteria.Location = new System.Drawing.Point(385, 118);
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
            this.dtpCreatedDateTo.Location = new System.Drawing.Point(262, 113);
            this.dtpCreatedDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedDateTo.Name = "dtpCreatedDateTo";
            this.dtpCreatedDateTo.Size = new System.Drawing.Size(115, 22);
            this.dtpCreatedDateTo.TabIndex = 5;
            // 
            // lblDeliveryStatusCriteria
            // 
            this.lblDeliveryStatusCriteria.AutoSize = true;
            this.lblDeliveryStatusCriteria.Location = new System.Drawing.Point(13, 146);
            this.lblDeliveryStatusCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryStatusCriteria.Name = "lblDeliveryStatusCriteria";
            this.lblDeliveryStatusCriteria.Size = new System.Drawing.Size(70, 16);
            this.lblDeliveryStatusCriteria.TabIndex = 0;
            this.lblDeliveryStatusCriteria.Text = "Tình trạng:";
            // 
            // dtpCreatedDateFrom
            // 
            this.dtpCreatedDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDateFrom.Location = new System.Drawing.Point(100, 113);
            this.dtpCreatedDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedDateFrom.Name = "dtpCreatedDateFrom";
            this.dtpCreatedDateFrom.Size = new System.Drawing.Size(115, 22);
            this.dtpCreatedDateFrom.TabIndex = 4;
            // 
            // tbRecipientPhoneCriteria
            // 
            this.tbRecipientPhoneCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientPhoneCriteria.Location = new System.Drawing.Point(100, 83);
            this.tbRecipientPhoneCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipientPhoneCriteria.MaxLength = 20;
            this.tbRecipientPhoneCriteria.Name = "tbRecipientPhoneCriteria";
            this.tbRecipientPhoneCriteria.Size = new System.Drawing.Size(302, 22);
            this.tbRecipientPhoneCriteria.TabIndex = 3;
            // 
            // tbRecipientIDCardNoCriteria
            // 
            this.tbRecipientIDCardNoCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientIDCardNoCriteria.Location = new System.Drawing.Point(100, 53);
            this.tbRecipientIDCardNoCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipientIDCardNoCriteria.MaxLength = 9;
            this.tbRecipientIDCardNoCriteria.Name = "tbRecipientIDCardNoCriteria";
            this.tbRecipientIDCardNoCriteria.Size = new System.Drawing.Size(302, 22);
            this.tbRecipientIDCardNoCriteria.TabIndex = 2;
            // 
            // lblDateToCriteria
            // 
            this.lblDateToCriteria.AutoSize = true;
            this.lblDateToCriteria.Location = new System.Drawing.Point(223, 116);
            this.lblDateToCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateToCriteria.Name = "lblDateToCriteria";
            this.lblDateToCriteria.Size = new System.Drawing.Size(31, 16);
            this.lblDateToCriteria.TabIndex = 1;
            this.lblDateToCriteria.Text = "đến";
            // 
            // tbRecipientNameCriteria
            // 
            this.tbRecipientNameCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientNameCriteria.Location = new System.Drawing.Point(100, 23);
            this.tbRecipientNameCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipientNameCriteria.Name = "tbRecipientNameCriteria";
            this.tbRecipientNameCriteria.Size = new System.Drawing.Size(302, 22);
            this.tbRecipientNameCriteria.TabIndex = 1;
            // 
            // lblCreatedDateCriteria
            // 
            this.lblCreatedDateCriteria.AutoSize = true;
            this.lblCreatedDateCriteria.Location = new System.Drawing.Point(13, 116);
            this.lblCreatedDateCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedDateCriteria.Name = "lblCreatedDateCriteria";
            this.lblCreatedDateCriteria.Size = new System.Drawing.Size(66, 16);
            this.lblCreatedDateCriteria.TabIndex = 1;
            this.lblCreatedDateCriteria.Text = "Ngày lập:";
            // 
            // lblPhoneNumberCriteria
            // 
            this.lblPhoneNumberCriteria.AutoSize = true;
            this.lblPhoneNumberCriteria.Location = new System.Drawing.Point(13, 86);
            this.lblPhoneNumberCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumberCriteria.Name = "lblPhoneNumberCriteria";
            this.lblPhoneNumberCriteria.Size = new System.Drawing.Size(70, 16);
            this.lblPhoneNumberCriteria.TabIndex = 1;
            this.lblPhoneNumberCriteria.Text = "Điện thoại:";
            // 
            // lblIDCardNoCriteria
            // 
            this.lblIDCardNoCriteria.AutoSize = true;
            this.lblIDCardNoCriteria.Location = new System.Drawing.Point(13, 56);
            this.lblIDCardNoCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCardNoCriteria.Name = "lblIDCardNoCriteria";
            this.lblIDCardNoCriteria.Size = new System.Drawing.Size(51, 16);
            this.lblIDCardNoCriteria.TabIndex = 1;
            this.lblIDCardNoCriteria.Text = "CMND:";
            // 
            // lblRecipientNameCriteria
            // 
            this.lblRecipientNameCriteria.AutoSize = true;
            this.lblRecipientNameCriteria.Location = new System.Drawing.Point(13, 26);
            this.lblRecipientNameCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipientNameCriteria.Name = "lblRecipientNameCriteria";
            this.lblRecipientNameCriteria.Size = new System.Drawing.Size(79, 16);
            this.lblRecipientNameCriteria.TabIndex = 1;
            this.lblRecipientNameCriteria.Text = "Người nhận:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 175);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AllowUserToAddRows = false;
            this.dgvOrdersList.AllowUserToDeleteRows = false;
            this.dgvOrdersList.AllowUserToResizeRows = false;
            this.dgvOrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.RecipientNameColumn,
            this.DeliveryStatusColumn,
            this.PaymentStatusColumn});
            this.dgvOrdersList.Location = new System.Drawing.Point(4, 207);
            this.dgvOrdersList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdersList.MultiSelect = false;
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.ReadOnly = true;
            this.dgvOrdersList.RowHeadersVisible = false;
            this.dgvOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersList.Size = new System.Drawing.Size(402, 476);
            this.dgvOrdersList.TabIndex = 9;
            this.dgvOrdersList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdersList_CellFormatting);
            this.dgvOrdersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrdersList_DataBindingComplete);
            this.dgvOrdersList.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOrdersList_RowValidating);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.FillWeight = 50F;
            this.IDColumn.HeaderText = "Mã số";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // RecipientNameColumn
            // 
            this.RecipientNameColumn.DataPropertyName = "recipient_name";
            this.RecipientNameColumn.HeaderText = "Người nhận";
            this.RecipientNameColumn.Name = "RecipientNameColumn";
            this.RecipientNameColumn.ReadOnly = true;
            // 
            // DeliveryStatusColumn
            // 
            this.DeliveryStatusColumn.DataPropertyName = "order_status";
            this.DeliveryStatusColumn.FillWeight = 73.85786F;
            this.DeliveryStatusColumn.HeaderText = "Tình trạng chuyển phát";
            this.DeliveryStatusColumn.Name = "DeliveryStatusColumn";
            this.DeliveryStatusColumn.ReadOnly = true;
            // 
            // PaymentStatusColumn
            // 
            this.PaymentStatusColumn.DataPropertyName = "payment_status";
            this.PaymentStatusColumn.FillWeight = 73.85786F;
            this.PaymentStatusColumn.HeaderText = "Tình trạng thanh toán";
            this.PaymentStatusColumn.Name = "PaymentStatusColumn";
            this.PaymentStatusColumn.ReadOnly = true;
            // 
            // ucItemsList
            // 
            this.ucItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucItemsList.Location = new System.Drawing.Point(0, 363);
            this.ucItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.ucItemsList.Name = "ucItemsList";
            this.ucItemsList.OrderID = null;
            this.ucItemsList.OrderItems = ((System.Collections.ObjectModel.Collection<DBManagement.OrderItem>)(resources.GetObject("ucItemsList.OrderItems")));
            this.ucItemsList.Size = new System.Drawing.Size(594, 323);
            this.ucItemsList.TabIndex = 3;
            this.ucItemsList.Validating += new System.ComponentModel.CancelEventHandler(this.ucItemsList_Validating);
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.cboTour);
            this.grpOrderInfo.Controls.Add(this.btnChangeStatus);
            this.grpOrderInfo.Controls.Add(this.pnlPaymentStatus);
            this.grpOrderInfo.Controls.Add(this.pnlDeliveryStatus);
            this.grpOrderInfo.Controls.Add(this.lblClosedDate);
            this.grpOrderInfo.Controls.Add(this.lblCreatedBy);
            this.grpOrderInfo.Controls.Add(this.lblCreatedDate);
            this.grpOrderInfo.Controls.Add(this.lblCreatedDateText);
            this.grpOrderInfo.Controls.Add(this.lblClosedDateText);
            this.grpOrderInfo.Controls.Add(this.lblCreatedByText);
            this.grpOrderInfo.Controls.Add(this.lblOrderIdText);
            this.grpOrderInfo.Controls.Add(this.lblOrderId);
            this.grpOrderInfo.Controls.Add(this.lblDestination);
            this.grpOrderInfo.Controls.Add(this.lblTotalCostCurrency);
            this.grpOrderInfo.Controls.Add(this.tbTotalCost);
            this.grpOrderInfo.Controls.Add(this.lblTotalCost);
            this.grpOrderInfo.Controls.Add(this.tbItemsQuantity);
            this.grpOrderInfo.Controls.Add(this.lblItemsQuantity);
            this.grpOrderInfo.Controls.Add(this.lblPaymentStatus);
            this.grpOrderInfo.Controls.Add(this.lblDeliveryStatus);
            this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(0, 148);
            this.grpOrderInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrderInfo.Size = new System.Drawing.Size(594, 208);
            this.grpOrderInfo.TabIndex = 2;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Chi tiết hóa đơn";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(113, 70);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(178, 24);
            this.cboTour.TabIndex = 1;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(459, 119);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(126, 24);
            this.btnChangeStatus.TabIndex = 4;
            this.btnChangeStatus.Text = "Thay đổi trạng thái";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // pnlPaymentStatus
            // 
            this.pnlPaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaymentStatus.Controls.Add(this.rbtnPaymentStatus_Unpaid);
            this.pnlPaymentStatus.Controls.Add(this.rbtnPaymentStatus_Paid);
            this.pnlPaymentStatus.Location = new System.Drawing.Point(113, 122);
            this.pnlPaymentStatus.Name = "pnlPaymentStatus";
            this.pnlPaymentStatus.Size = new System.Drawing.Size(315, 22);
            this.pnlPaymentStatus.TabIndex = 3;
            // 
            // rbtnPaymentStatus_Unpaid
            // 
            this.rbtnPaymentStatus_Unpaid.AutoSize = true;
            this.rbtnPaymentStatus_Unpaid.Location = new System.Drawing.Point(4, 1);
            this.rbtnPaymentStatus_Unpaid.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPaymentStatus_Unpaid.Name = "rbtnPaymentStatus_Unpaid";
            this.rbtnPaymentStatus_Unpaid.Size = new System.Drawing.Size(121, 20);
            this.rbtnPaymentStatus_Unpaid.TabIndex = 1;
            this.rbtnPaymentStatus_Unpaid.TabStop = true;
            this.rbtnPaymentStatus_Unpaid.Text = "Chưa thanh toán";
            this.rbtnPaymentStatus_Unpaid.UseVisualStyleBackColor = true;
            // 
            // rbtnPaymentStatus_Paid
            // 
            this.rbtnPaymentStatus_Paid.AutoSize = true;
            this.rbtnPaymentStatus_Paid.Location = new System.Drawing.Point(200, 1);
            this.rbtnPaymentStatus_Paid.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPaymentStatus_Paid.Name = "rbtnPaymentStatus_Paid";
            this.rbtnPaymentStatus_Paid.Size = new System.Drawing.Size(107, 20);
            this.rbtnPaymentStatus_Paid.TabIndex = 2;
            this.rbtnPaymentStatus_Paid.TabStop = true;
            this.rbtnPaymentStatus_Paid.Text = "Đã thanh toán";
            this.rbtnPaymentStatus_Paid.UseVisualStyleBackColor = true;
            // 
            // pnlDeliveryStatus
            // 
            this.pnlDeliveryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Waiting);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Delivering);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Arrived);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Delivered);
            this.pnlDeliveryStatus.Controls.Add(this.rbtnDeliveryStatus_Closed);
            this.pnlDeliveryStatus.Location = new System.Drawing.Point(113, 96);
            this.pnlDeliveryStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDeliveryStatus.Name = "pnlDeliveryStatus";
            this.pnlDeliveryStatus.Size = new System.Drawing.Size(472, 22);
            this.pnlDeliveryStatus.TabIndex = 2;
            // 
            // rbtnDeliveryStatus_Waiting
            // 
            this.rbtnDeliveryStatus_Waiting.AutoSize = true;
            this.rbtnDeliveryStatus_Waiting.Location = new System.Drawing.Point(4, 1);
            this.rbtnDeliveryStatus_Waiting.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDeliveryStatus_Waiting.Name = "rbtnDeliveryStatus_Waiting";
            this.rbtnDeliveryStatus_Waiting.Size = new System.Drawing.Size(83, 20);
            this.rbtnDeliveryStatus_Waiting.TabIndex = 1;
            this.rbtnDeliveryStatus_Waiting.TabStop = true;
            this.rbtnDeliveryStatus_Waiting.Text = "Đang chờ";
            this.rbtnDeliveryStatus_Waiting.UseVisualStyleBackColor = true;
            this.rbtnDeliveryStatus_Waiting.CheckedChanged += new System.EventHandler(this.rbtnDeliveryStatus_Waiting_CheckedChanged);
            // 
            // rbtnDeliveryStatus_Delivering
            // 
            this.rbtnDeliveryStatus_Delivering.AutoSize = true;
            this.rbtnDeliveryStatus_Delivering.Location = new System.Drawing.Point(90, 1);
            this.rbtnDeliveryStatus_Delivering.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDeliveryStatus_Delivering.Name = "rbtnDeliveryStatus_Delivering";
            this.rbtnDeliveryStatus_Delivering.Size = new System.Drawing.Size(104, 20);
            this.rbtnDeliveryStatus_Delivering.TabIndex = 2;
            this.rbtnDeliveryStatus_Delivering.TabStop = true;
            this.rbtnDeliveryStatus_Delivering.Text = "Đang chuyển";
            this.rbtnDeliveryStatus_Delivering.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Arrived
            // 
            this.rbtnDeliveryStatus_Arrived.AutoSize = true;
            this.rbtnDeliveryStatus_Arrived.Location = new System.Drawing.Point(200, 1);
            this.rbtnDeliveryStatus_Arrived.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDeliveryStatus_Arrived.Name = "rbtnDeliveryStatus_Arrived";
            this.rbtnDeliveryStatus_Arrived.Size = new System.Drawing.Size(60, 20);
            this.rbtnDeliveryStatus_Arrived.TabIndex = 3;
            this.rbtnDeliveryStatus_Arrived.TabStop = true;
            this.rbtnDeliveryStatus_Arrived.Text = "Đã tới";
            this.rbtnDeliveryStatus_Arrived.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Delivered
            // 
            this.rbtnDeliveryStatus_Delivered.AutoSize = true;
            this.rbtnDeliveryStatus_Delivered.Location = new System.Drawing.Point(279, 1);
            this.rbtnDeliveryStatus_Delivered.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDeliveryStatus_Delivered.Name = "rbtnDeliveryStatus_Delivered";
            this.rbtnDeliveryStatus_Delivered.Size = new System.Drawing.Size(73, 20);
            this.rbtnDeliveryStatus_Delivered.TabIndex = 4;
            this.rbtnDeliveryStatus_Delivered.TabStop = true;
            this.rbtnDeliveryStatus_Delivered.Text = "Đã giao";
            this.rbtnDeliveryStatus_Delivered.UseVisualStyleBackColor = true;
            // 
            // rbtnDeliveryStatus_Closed
            // 
            this.rbtnDeliveryStatus_Closed.AutoSize = true;
            this.rbtnDeliveryStatus_Closed.Enabled = false;
            this.rbtnDeliveryStatus_Closed.Location = new System.Drawing.Point(361, 1);
            this.rbtnDeliveryStatus_Closed.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDeliveryStatus_Closed.Name = "rbtnDeliveryStatus_Closed";
            this.rbtnDeliveryStatus_Closed.Size = new System.Drawing.Size(94, 20);
            this.rbtnDeliveryStatus_Closed.TabIndex = 5;
            this.rbtnDeliveryStatus_Closed.TabStop = true;
            this.rbtnDeliveryStatus_Closed.Text = "Hoàn thành";
            this.rbtnDeliveryStatus_Closed.UseVisualStyleBackColor = true;
            // 
            // lblClosedDate
            // 
            this.lblClosedDate.AutoSize = true;
            this.lblClosedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosedDate.Location = new System.Drawing.Point(306, 47);
            this.lblClosedDate.Name = "lblClosedDate";
            this.lblClosedDate.Size = new System.Drawing.Size(78, 16);
            this.lblClosedDate.TabIndex = 18;
            this.lblClosedDate.Text = "Ngày đóng:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(306, 21);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(69, 16);
            this.lblCreatedBy.TabIndex = 19;
            this.lblCreatedBy.Text = "Người lập:";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.Location = new System.Drawing.Point(8, 47);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(66, 16);
            this.lblCreatedDate.TabIndex = 20;
            this.lblCreatedDate.Text = "Ngày lập:";
            // 
            // lblCreatedDateText
            // 
            this.lblCreatedDateText.AutoSize = true;
            this.lblCreatedDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDateText.Location = new System.Drawing.Point(110, 47);
            this.lblCreatedDateText.Name = "lblCreatedDateText";
            this.lblCreatedDateText.Size = new System.Drawing.Size(120, 16);
            this.lblCreatedDateText.TabIndex = 0;
            this.lblCreatedDateText.Text = "<Created_Date>";
            // 
            // lblClosedDateText
            // 
            this.lblClosedDateText.AutoSize = true;
            this.lblClosedDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosedDateText.Location = new System.Drawing.Point(402, 47);
            this.lblClosedDateText.Name = "lblClosedDateText";
            this.lblClosedDateText.Size = new System.Drawing.Size(114, 16);
            this.lblClosedDateText.TabIndex = 0;
            this.lblClosedDateText.Text = "<Closed_Date>";
            // 
            // lblCreatedByText
            // 
            this.lblCreatedByText.AutoSize = true;
            this.lblCreatedByText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByText.Location = new System.Drawing.Point(402, 21);
            this.lblCreatedByText.Name = "lblCreatedByText";
            this.lblCreatedByText.Size = new System.Drawing.Size(105, 16);
            this.lblCreatedByText.TabIndex = 0;
            this.lblCreatedByText.Text = "<Created_By>";
            // 
            // lblOrderIdText
            // 
            this.lblOrderIdText.AutoSize = true;
            this.lblOrderIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIdText.Location = new System.Drawing.Point(110, 21);
            this.lblOrderIdText.Name = "lblOrderIdText";
            this.lblOrderIdText.Size = new System.Drawing.Size(84, 16);
            this.lblOrderIdText.TabIndex = 0;
            this.lblOrderIdText.Text = "<Order_Id>";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(8, 21);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(48, 16);
            this.lblOrderId.TabIndex = 25;
            this.lblOrderId.Text = "Mã số:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(8, 73);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(58, 16);
            this.lblDestination.TabIndex = 16;
            this.lblDestination.Text = "Nơi đến:";
            // 
            // lblTotalCostCurrency
            // 
            this.lblTotalCostCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCostCurrency.AutoSize = true;
            this.lblTotalCostCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostCurrency.Location = new System.Drawing.Point(545, 180);
            this.lblTotalCostCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.tbTotalCost.Location = new System.Drawing.Point(113, 177);
            this.tbTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(424, 22);
            this.tbTotalCost.TabIndex = 6;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(8, 180);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(77, 16);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Tổng tiền:";
            // 
            // tbItemsQuantity
            // 
            this.tbItemsQuantity.Enabled = false;
            this.tbItemsQuantity.Location = new System.Drawing.Point(113, 148);
            this.tbItemsQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbItemsQuantity.Name = "tbItemsQuantity";
            this.tbItemsQuantity.ReadOnly = true;
            this.tbItemsQuantity.Size = new System.Drawing.Size(87, 22);
            this.tbItemsQuantity.TabIndex = 5;
            // 
            // lblItemsQuantity
            // 
            this.lblItemsQuantity.AutoSize = true;
            this.lblItemsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsQuantity.Location = new System.Drawing.Point(8, 151);
            this.lblItemsQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsQuantity.Name = "lblItemsQuantity";
            this.lblItemsQuantity.Size = new System.Drawing.Size(97, 16);
            this.lblItemsQuantity.TabIndex = 2;
            this.lblItemsQuantity.Text = "Số lượng hàng:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(8, 125);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(78, 16);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "Thanh toán:";
            // 
            // lblDeliveryStatus
            // 
            this.lblDeliveryStatus.AutoSize = true;
            this.lblDeliveryStatus.Location = new System.Drawing.Point(8, 99);
            this.lblDeliveryStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.ctnCustomersInfo.Size = new System.Drawing.Size(594, 148);
            this.ctnCustomersInfo.SplitterDistance = 295;
            this.ctnCustomersInfo.TabIndex = 1;
            // 
            // grpSenderInfo
            // 
            this.grpSenderInfo.Controls.Add(this.tbSenderAddress);
            this.grpSenderInfo.Controls.Add(this.lblSenderAddress);
            this.grpSenderInfo.Controls.Add(this.tbSenderPhoneNumber);
            this.grpSenderInfo.Controls.Add(this.tbSenderIDCardNo);
            this.grpSenderInfo.Controls.Add(this.tbSenderName);
            this.grpSenderInfo.Controls.Add(this.lblSenderName);
            this.grpSenderInfo.Controls.Add(this.lblSenderIDCardNo);
            this.grpSenderInfo.Controls.Add(this.lblSenderPhoneNumber);
            this.grpSenderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSenderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSenderInfo.Location = new System.Drawing.Point(0, 0);
            this.grpSenderInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpSenderInfo.Name = "grpSenderInfo";
            this.grpSenderInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpSenderInfo.Size = new System.Drawing.Size(295, 148);
            this.grpSenderInfo.TabIndex = 1;
            this.grpSenderInfo.TabStop = false;
            this.grpSenderInfo.Text = "Thông tin người gửi:";
            // 
            // tbSenderAddress
            // 
            this.tbSenderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderAddress.Enabled = false;
            this.tbSenderAddress.Location = new System.Drawing.Point(86, 114);
            this.tbSenderAddress.Name = "tbSenderAddress";
            this.tbSenderAddress.Size = new System.Drawing.Size(201, 23);
            this.tbSenderAddress.TabIndex = 6;
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.AutoSize = true;
            this.lblSenderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAddress.Location = new System.Drawing.Point(8, 118);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(51, 16);
            this.lblSenderAddress.TabIndex = 5;
            this.lblSenderAddress.Text = "Địa chỉ:";
            // 
            // tbSenderPhoneNumber
            // 
            this.tbSenderPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderPhoneNumber.Location = new System.Drawing.Point(86, 53);
            this.tbSenderPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenderPhoneNumber.MaxLength = 20;
            this.tbSenderPhoneNumber.Name = "tbSenderPhoneNumber";
            this.tbSenderPhoneNumber.Size = new System.Drawing.Size(201, 23);
            this.tbSenderPhoneNumber.TabIndex = 2;
            // 
            // tbSenderIDCardNo
            // 
            this.tbSenderIDCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderIDCardNo.Location = new System.Drawing.Point(86, 84);
            this.tbSenderIDCardNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenderIDCardNo.MaxLength = 9;
            this.tbSenderIDCardNo.Name = "tbSenderIDCardNo";
            this.tbSenderIDCardNo.Size = new System.Drawing.Size(201, 23);
            this.tbSenderIDCardNo.TabIndex = 3;
            // 
            // tbSenderName
            // 
            this.tbSenderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderName.Location = new System.Drawing.Point(86, 22);
            this.tbSenderName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(201, 23);
            this.tbSenderName.TabIndex = 1;
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.Location = new System.Drawing.Point(8, 28);
            this.lblSenderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(50, 16);
            this.lblSenderName.TabIndex = 0;
            this.lblSenderName.Text = "Họ tên:";
            // 
            // lblSenderIDCardNo
            // 
            this.lblSenderIDCardNo.AutoSize = true;
            this.lblSenderIDCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderIDCardNo.Location = new System.Drawing.Point(8, 90);
            this.lblSenderIDCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderIDCardNo.Name = "lblSenderIDCardNo";
            this.lblSenderIDCardNo.Size = new System.Drawing.Size(51, 16);
            this.lblSenderIDCardNo.TabIndex = 0;
            this.lblSenderIDCardNo.Text = "CMND:";
            // 
            // lblSenderPhoneNumber
            // 
            this.lblSenderPhoneNumber.AutoSize = true;
            this.lblSenderPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderPhoneNumber.Location = new System.Drawing.Point(8, 59);
            this.lblSenderPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderPhoneNumber.Name = "lblSenderPhoneNumber";
            this.lblSenderPhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.lblSenderPhoneNumber.TabIndex = 0;
            this.lblSenderPhoneNumber.Text = "Điện thoại:";
            // 
            // grpRecipientInfo
            // 
            this.grpRecipientInfo.Controls.Add(this.tbRecipientAddress);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientAddress);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientPhoneNumber);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientIDCardNo);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientName);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientName);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientIDCardNo);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientPhoneNumber);
            this.grpRecipientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecipientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipientInfo.Location = new System.Drawing.Point(0, 0);
            this.grpRecipientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpRecipientInfo.Name = "grpRecipientInfo";
            this.grpRecipientInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpRecipientInfo.Size = new System.Drawing.Size(295, 148);
            this.grpRecipientInfo.TabIndex = 2;
            this.grpRecipientInfo.TabStop = false;
            this.grpRecipientInfo.Text = "Thông tin người nhận:";
            // 
            // tbRecipientAddress
            // 
            this.tbRecipientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientAddress.Enabled = false;
            this.tbRecipientAddress.Location = new System.Drawing.Point(86, 114);
            this.tbRecipientAddress.Name = "tbRecipientAddress";
            this.tbRecipientAddress.Size = new System.Drawing.Size(201, 23);
            this.tbRecipientAddress.TabIndex = 8;
            // 
            // lblRecipientAddress
            // 
            this.lblRecipientAddress.AutoSize = true;
            this.lblRecipientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientAddress.Location = new System.Drawing.Point(8, 118);
            this.lblRecipientAddress.Name = "lblRecipientAddress";
            this.lblRecipientAddress.Size = new System.Drawing.Size(51, 16);
            this.lblRecipientAddress.TabIndex = 7;
            this.lblRecipientAddress.Text = "Địa chỉ:";
            // 
            // tbRecipientPhoneNumber
            // 
            this.tbRecipientPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientPhoneNumber.Location = new System.Drawing.Point(86, 53);
            this.tbRecipientPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipientPhoneNumber.MaxLength = 20;
            this.tbRecipientPhoneNumber.Name = "tbRecipientPhoneNumber";
            this.tbRecipientPhoneNumber.Size = new System.Drawing.Size(201, 23);
            this.tbRecipientPhoneNumber.TabIndex = 2;
            // 
            // tbRecipientIDCardNo
            // 
            this.tbRecipientIDCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientIDCardNo.Location = new System.Drawing.Point(86, 84);
            this.tbRecipientIDCardNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipientIDCardNo.MaxLength = 9;
            this.tbRecipientIDCardNo.Name = "tbRecipientIDCardNo";
            this.tbRecipientIDCardNo.Size = new System.Drawing.Size(201, 23);
            this.tbRecipientIDCardNo.TabIndex = 3;
            // 
            // tbRecipientName
            // 
            this.tbRecipientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipientName.Location = new System.Drawing.Point(86, 22);
            this.tbRecipientName.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipientName.Name = "tbRecipientName";
            this.tbRecipientName.Size = new System.Drawing.Size(201, 23);
            this.tbRecipientName.TabIndex = 1;
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.AutoSize = true;
            this.lblRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientName.Location = new System.Drawing.Point(8, 28);
            this.lblRecipientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(50, 16);
            this.lblRecipientName.TabIndex = 0;
            this.lblRecipientName.Text = "Họ tên:";
            // 
            // lblRecipientIDCardNo
            // 
            this.lblRecipientIDCardNo.AutoSize = true;
            this.lblRecipientIDCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientIDCardNo.Location = new System.Drawing.Point(8, 90);
            this.lblRecipientIDCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipientIDCardNo.Name = "lblRecipientIDCardNo";
            this.lblRecipientIDCardNo.Size = new System.Drawing.Size(51, 16);
            this.lblRecipientIDCardNo.TabIndex = 0;
            this.lblRecipientIDCardNo.Text = "CMND:";
            // 
            // lblRecipientPhoneNumber
            // 
            this.lblRecipientPhoneNumber.AutoSize = true;
            this.lblRecipientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientPhoneNumber.Location = new System.Drawing.Point(8, 59);
            this.lblRecipientPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipientPhoneNumber.Name = "lblRecipientPhoneNumber";
            this.lblRecipientPhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.lblRecipientPhoneNumber.TabIndex = 0;
            this.lblRecipientPhoneNumber.Text = "Điện thoại:";
            // 
            // IrregularOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 690);
            this.Controls.Add(this.ctnIrregularOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "IrregularOrderView";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hóa đơn lẻ";
            this.ctnIrregularOrder.Panel1.ResumeLayout(false);
            this.ctnIrregularOrder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctnIrregularOrder)).EndInit();
            this.ctnIrregularOrder.ResumeLayout(false);
            this.grpOrdersList.ResumeLayout(false);
            this.grpOrdersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.pnlPaymentStatus.ResumeLayout(false);
            this.pnlPaymentStatus.PerformLayout();
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

        private System.Windows.Forms.SplitContainer ctnIrregularOrder;
        private System.Windows.Forms.GroupBox grpOrdersList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboDeliveryStatusCriteria;
        private System.Windows.Forms.CheckBox chkUseCreatedDateRangeCriteria;
        private System.Windows.Forms.DateTimePicker dtpCreatedDateTo;
        private System.Windows.Forms.Label lblDeliveryStatusCriteria;
        private System.Windows.Forms.DateTimePicker dtpCreatedDateFrom;
        private System.Windows.Forms.TextBox tbRecipientIDCardNoCriteria;
        private System.Windows.Forms.Label lblDateToCriteria;
        private System.Windows.Forms.TextBox tbRecipientNameCriteria;
        private System.Windows.Forms.Label lblCreatedDateCriteria;
        private System.Windows.Forms.Label lblIDCardNoCriteria;
        private System.Windows.Forms.Label lblRecipientNameCriteria;
        private System.Windows.Forms.DataGridView dgvOrdersList;
        private Order.ItemsListUC ucItemsList;
        private System.Windows.Forms.TextBox tbRecipientPhoneCriteria;
        private System.Windows.Forms.Label lblPhoneNumberCriteria;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.RadioButton rbtnPaymentStatus_Paid;
        private System.Windows.Forms.RadioButton rbtnPaymentStatus_Unpaid;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Delivered;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Arrived;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Delivering;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Waiting;
        private System.Windows.Forms.Label lblTotalCostCurrency;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox tbItemsQuantity;
        private System.Windows.Forms.Label lblItemsQuantity;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblDeliveryStatus;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.SplitContainer ctnCustomersInfo;
        private System.Windows.Forms.GroupBox grpSenderInfo;
        private System.Windows.Forms.TextBox tbSenderPhoneNumber;
        private System.Windows.Forms.TextBox tbSenderIDCardNo;
        private System.Windows.Forms.TextBox tbSenderName;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblSenderIDCardNo;
        private System.Windows.Forms.Label lblSenderPhoneNumber;
        private System.Windows.Forms.GroupBox grpRecipientInfo;
        private System.Windows.Forms.TextBox tbRecipientPhoneNumber;
        private System.Windows.Forms.TextBox tbRecipientIDCardNo;
        private System.Windows.Forms.TextBox tbRecipientName;
        private System.Windows.Forms.Label lblRecipientName;
        private System.Windows.Forms.Label lblRecipientIDCardNo;
        private System.Windows.Forms.Label lblRecipientPhoneNumber;
        private System.Windows.Forms.Label lblClosedDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblCreatedDateText;
        private System.Windows.Forms.Label lblClosedDateText;
        private System.Windows.Forms.Label lblCreatedByText;
        private System.Windows.Forms.Label lblOrderIdText;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.RadioButton rbtnDeliveryStatus_Closed;
        private System.Windows.Forms.Panel pnlPaymentStatus;
        private System.Windows.Forms.Panel pnlDeliveryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatusColumn;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.TextBox tbSenderAddress;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.TextBox tbRecipientAddress;
        private System.Windows.Forms.Label lblRecipientAddress;

    }
}