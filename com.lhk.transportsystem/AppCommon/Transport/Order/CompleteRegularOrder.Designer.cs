namespace AppCommon.Transport.TransportOrder
{
    partial class CompleteRegularOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAdjustment = new System.Windows.Forms.GroupBox();
            this.chkUseAdjustment = new System.Windows.Forms.CheckBox();
            this.tbAdjustmentReason = new System.Windows.Forms.TextBox();
            this.lblAdjustmentReason = new System.Windows.Forms.Label();
            this.tbAdjustmentAmount = new System.Windows.Forms.TextBox();
            this.lblAdjustmentAmountCurrency = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblPaymentBalanceText = new System.Windows.Forms.Label();
            this.lblPaymentBalance = new System.Windows.Forms.Label();
            this.lblPaymentBalanceCurrency = new System.Windows.Forms.Label();
            this.lblRealPaidAmount = new System.Windows.Forms.Label();
            this.lblRealPaidAmountCurrency = new System.Windows.Forms.Label();
            this.tbRealPaidAmount = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalPaymentCurrency = new System.Windows.Forms.Label();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblPaymentStatusText = new System.Windows.Forms.Label();
            this.lblOrderStatusText = new System.Windows.Forms.Label();
            this.lblOrderCostCurrency = new System.Windows.Forms.Label();
            this.tbOrderCost = new System.Windows.Forms.TextBox();
            this.lblOrderCost = new System.Windows.Forms.Label();
            this.tbItemsCount = new System.Windows.Forms.TextBox();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.grpItemsList = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrdersList = new System.Windows.Forms.GroupBox();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAdjustment.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            this.grpItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.grpOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAdjustment
            // 
            this.grpAdjustment.Controls.Add(this.chkUseAdjustment);
            this.grpAdjustment.Controls.Add(this.tbAdjustmentReason);
            this.grpAdjustment.Controls.Add(this.lblAdjustmentReason);
            this.grpAdjustment.Controls.Add(this.tbAdjustmentAmount);
            this.grpAdjustment.Controls.Add(this.lblAdjustmentAmountCurrency);
            this.grpAdjustment.Location = new System.Drawing.Point(565, 323);
            this.grpAdjustment.Name = "grpAdjustment";
            this.grpAdjustment.Size = new System.Drawing.Size(277, 158);
            this.grpAdjustment.TabIndex = 29;
            this.grpAdjustment.TabStop = false;
            // 
            // chkUseAdjustment
            // 
            this.chkUseAdjustment.AutoSize = true;
            this.chkUseAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseAdjustment.Location = new System.Drawing.Point(6, 17);
            this.chkUseAdjustment.Name = "chkUseAdjustment";
            this.chkUseAdjustment.Size = new System.Drawing.Size(186, 20);
            this.chkUseAdjustment.TabIndex = 39;
            this.chkUseAdjustment.Text = "Sử dụng tiền điều chỉnh";
            this.chkUseAdjustment.UseVisualStyleBackColor = true;
            this.chkUseAdjustment.CheckedChanged += new System.EventHandler(this.ckbUseAdjustment_CheckedChanged);
            // 
            // tbAdjustmentReason
            // 
            this.tbAdjustmentReason.Enabled = false;
            this.tbAdjustmentReason.Location = new System.Drawing.Point(6, 91);
            this.tbAdjustmentReason.Multiline = true;
            this.tbAdjustmentReason.Name = "tbAdjustmentReason";
            this.tbAdjustmentReason.Size = new System.Drawing.Size(266, 59);
            this.tbAdjustmentReason.TabIndex = 38;
            // 
            // lblAdjustmentReason
            // 
            this.lblAdjustmentReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdjustmentReason.AutoSize = true;
            this.lblAdjustmentReason.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAdjustmentReason.Location = new System.Drawing.Point(5, 74);
            this.lblAdjustmentReason.Name = "lblAdjustmentReason";
            this.lblAdjustmentReason.Size = new System.Drawing.Size(47, 16);
            this.lblAdjustmentReason.TabIndex = 37;
            this.lblAdjustmentReason.Text = "Lý do:";
            // 
            // tbAdjustmentAmount
            // 
            this.tbAdjustmentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdjustmentAmount.BackColor = System.Drawing.Color.White;
            this.tbAdjustmentAmount.Enabled = false;
            this.tbAdjustmentAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbAdjustmentAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAdjustmentAmount.Location = new System.Drawing.Point(5, 45);
            this.tbAdjustmentAmount.Name = "tbAdjustmentAmount";
            this.tbAdjustmentAmount.Size = new System.Drawing.Size(221, 26);
            this.tbAdjustmentAmount.TabIndex = 35;
            this.tbAdjustmentAmount.Text = "0";
            this.tbAdjustmentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAdjustmentAmount.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbAdjustmentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdjustmentAmount_KeyPress);
            // 
            // lblAdjustmentAmountCurrency
            // 
            this.lblAdjustmentAmountCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdjustmentAmountCurrency.AutoSize = true;
            this.lblAdjustmentAmountCurrency.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAdjustmentAmountCurrency.Location = new System.Drawing.Point(227, 48);
            this.lblAdjustmentAmountCurrency.Name = "lblAdjustmentAmountCurrency";
            this.lblAdjustmentAmountCurrency.Size = new System.Drawing.Size(44, 19);
            this.lblAdjustmentAmountCurrency.TabIndex = 36;
            this.lblAdjustmentAmountCurrency.Text = "VNĐ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(474, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 37);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(247, 487);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(159, 37);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "Quyết toán";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblPaymentBalanceText);
            this.grpPayment.Controls.Add(this.lblPaymentBalance);
            this.grpPayment.Controls.Add(this.lblPaymentBalanceCurrency);
            this.grpPayment.Controls.Add(this.lblRealPaidAmount);
            this.grpPayment.Controls.Add(this.lblRealPaidAmountCurrency);
            this.grpPayment.Controls.Add(this.tbRealPaidAmount);
            this.grpPayment.Controls.Add(this.lblTotalPayment);
            this.grpPayment.Controls.Add(this.lblTotalPaymentCurrency);
            this.grpPayment.Controls.Add(this.tbTotalPayment);
            this.grpPayment.Location = new System.Drawing.Point(12, 323);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(547, 158);
            this.grpPayment.TabIndex = 26;
            this.grpPayment.TabStop = false;
            // 
            // lblPaymentBalanceText
            // 
            this.lblPaymentBalanceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentBalanceText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPaymentBalanceText.ForeColor = System.Drawing.Color.Blue;
            this.lblPaymentBalanceText.Location = new System.Drawing.Point(141, 114);
            this.lblPaymentBalanceText.Name = "lblPaymentBalanceText";
            this.lblPaymentBalanceText.Size = new System.Drawing.Size(344, 22);
            this.lblPaymentBalanceText.TabIndex = 40;
            this.lblPaymentBalanceText.Text = "<Payment_Balance>";
            this.lblPaymentBalanceText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentBalance
            // 
            this.lblPaymentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentBalance.AutoSize = true;
            this.lblPaymentBalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPaymentBalance.Location = new System.Drawing.Point(6, 114);
            this.lblPaymentBalance.Name = "lblPaymentBalance";
            this.lblPaymentBalance.Size = new System.Drawing.Size(73, 22);
            this.lblPaymentBalance.TabIndex = 37;
            this.lblPaymentBalance.Text = "Số dư:";
            // 
            // lblPaymentBalanceCurrency
            // 
            this.lblPaymentBalanceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentBalanceCurrency.AutoSize = true;
            this.lblPaymentBalanceCurrency.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPaymentBalanceCurrency.Location = new System.Drawing.Point(491, 114);
            this.lblPaymentBalanceCurrency.Name = "lblPaymentBalanceCurrency";
            this.lblPaymentBalanceCurrency.Size = new System.Drawing.Size(50, 22);
            this.lblPaymentBalanceCurrency.TabIndex = 39;
            this.lblPaymentBalanceCurrency.Text = "VNĐ";
            // 
            // lblRealPaidAmount
            // 
            this.lblRealPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRealPaidAmount.AutoSize = true;
            this.lblRealPaidAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRealPaidAmount.Location = new System.Drawing.Point(6, 76);
            this.lblRealPaidAmount.Name = "lblRealPaidAmount";
            this.lblRealPaidAmount.Size = new System.Drawing.Size(109, 22);
            this.lblRealPaidAmount.TabIndex = 31;
            this.lblRealPaidAmount.Text = "Thực Thu:";
            // 
            // lblRealPaidAmountCurrency
            // 
            this.lblRealPaidAmountCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRealPaidAmountCurrency.AutoSize = true;
            this.lblRealPaidAmountCurrency.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRealPaidAmountCurrency.Location = new System.Drawing.Point(491, 76);
            this.lblRealPaidAmountCurrency.Name = "lblRealPaidAmountCurrency";
            this.lblRealPaidAmountCurrency.Size = new System.Drawing.Size(50, 22);
            this.lblRealPaidAmountCurrency.TabIndex = 33;
            this.lblRealPaidAmountCurrency.Text = "VNĐ";
            // 
            // tbRealPaidAmount
            // 
            this.tbRealPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRealPaidAmount.BackColor = System.Drawing.Color.Lime;
            this.tbRealPaidAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbRealPaidAmount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbRealPaidAmount.Location = new System.Drawing.Point(141, 72);
            this.tbRealPaidAmount.Name = "tbRealPaidAmount";
            this.tbRealPaidAmount.Size = new System.Drawing.Size(344, 32);
            this.tbRealPaidAmount.TabIndex = 32;
            this.tbRealPaidAmount.Text = "0";
            this.tbRealPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRealPaidAmount.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbRealPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRealAmount_KeyPress);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPayment.Location = new System.Drawing.Point(6, 38);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(112, 22);
            this.lblTotalPayment.TabIndex = 28;
            this.lblTotalPayment.Text = "Tổng Tiền:";
            // 
            // lblTotalPaymentCurrency
            // 
            this.lblTotalPaymentCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaymentCurrency.AutoSize = true;
            this.lblTotalPaymentCurrency.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPaymentCurrency.Location = new System.Drawing.Point(491, 38);
            this.lblTotalPaymentCurrency.Name = "lblTotalPaymentCurrency";
            this.lblTotalPaymentCurrency.Size = new System.Drawing.Size(50, 22);
            this.lblTotalPaymentCurrency.TabIndex = 30;
            this.lblTotalPaymentCurrency.Text = "VNĐ";
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPayment.BackColor = System.Drawing.Color.Red;
            this.tbTotalPayment.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTotalPayment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbTotalPayment.Location = new System.Drawing.Point(141, 30);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.ReadOnly = true;
            this.tbTotalPayment.Size = new System.Drawing.Size(344, 35);
            this.tbTotalPayment.TabIndex = 29;
            this.tbTotalPayment.Text = "0";
            this.tbTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.lblPaymentStatusText);
            this.grpOrderDetails.Controls.Add(this.lblOrderStatusText);
            this.grpOrderDetails.Controls.Add(this.lblOrderCostCurrency);
            this.grpOrderDetails.Controls.Add(this.tbOrderCost);
            this.grpOrderDetails.Controls.Add(this.lblOrderCost);
            this.grpOrderDetails.Controls.Add(this.tbItemsCount);
            this.grpOrderDetails.Controls.Add(this.lblItemsCount);
            this.grpOrderDetails.Controls.Add(this.lblPaymentStatus);
            this.grpOrderDetails.Controls.Add(this.lblOrderStatus);
            this.grpOrderDetails.Location = new System.Drawing.Point(394, 13);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(448, 149);
            this.grpOrderDetails.TabIndex = 25;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Chi tiết hóa đơn";
            // 
            // lblPaymentStatusText
            // 
            this.lblPaymentStatusText.AutoSize = true;
            this.lblPaymentStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatusText.Location = new System.Drawing.Point(146, 53);
            this.lblPaymentStatusText.Name = "lblPaymentStatusText";
            this.lblPaymentStatusText.Size = new System.Drawing.Size(132, 16);
            this.lblPaymentStatusText.TabIndex = 10;
            this.lblPaymentStatusText.Text = "<payment_status>";
            // 
            // lblOrderStatusText
            // 
            this.lblOrderStatusText.AutoSize = true;
            this.lblOrderStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusText.Location = new System.Drawing.Point(146, 26);
            this.lblOrderStatusText.Name = "lblOrderStatusText";
            this.lblOrderStatusText.Size = new System.Drawing.Size(110, 16);
            this.lblOrderStatusText.TabIndex = 9;
            this.lblOrderStatusText.Text = "<order_status>";
            // 
            // lblOrderCostCurrency
            // 
            this.lblOrderCostCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderCostCurrency.AutoSize = true;
            this.lblOrderCostCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCostCurrency.Location = new System.Drawing.Point(403, 116);
            this.lblOrderCostCurrency.Name = "lblOrderCostCurrency";
            this.lblOrderCostCurrency.Size = new System.Drawing.Size(39, 16);
            this.lblOrderCostCurrency.TabIndex = 8;
            this.lblOrderCostCurrency.Text = "VNĐ";
            // 
            // tbOrderCost
            // 
            this.tbOrderCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderCost.Enabled = false;
            this.tbOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderCost.Location = new System.Drawing.Point(149, 113);
            this.tbOrderCost.Name = "tbOrderCost";
            this.tbOrderCost.ReadOnly = true;
            this.tbOrderCost.Size = new System.Drawing.Size(248, 22);
            this.tbOrderCost.TabIndex = 7;
            // 
            // lblOrderCost
            // 
            this.lblOrderCost.AutoSize = true;
            this.lblOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCost.Location = new System.Drawing.Point(6, 116);
            this.lblOrderCost.Name = "lblOrderCost";
            this.lblOrderCost.Size = new System.Drawing.Size(137, 16);
            this.lblOrderCost.TabIndex = 6;
            this.lblOrderCost.Text = "Tổng tiền hóa đơn:";
            // 
            // tbItemsCount
            // 
            this.tbItemsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemsCount.Enabled = false;
            this.tbItemsCount.Location = new System.Drawing.Point(149, 80);
            this.tbItemsCount.Name = "tbItemsCount";
            this.tbItemsCount.ReadOnly = true;
            this.tbItemsCount.Size = new System.Drawing.Size(248, 22);
            this.tbItemsCount.TabIndex = 3;
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCount.Location = new System.Drawing.Point(6, 83);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(97, 16);
            this.lblItemsCount.TabIndex = 2;
            this.lblItemsCount.Text = "Số lượng hàng:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(6, 53);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(78, 16);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "Thanh toán:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(6, 26);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(71, 16);
            this.lblOrderStatus.TabIndex = 0;
            this.lblOrderStatus.Text = "Trạng thái:";
            // 
            // grpItemsList
            // 
            this.grpItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpItemsList.Controls.Add(this.dgvItemsList);
            this.grpItemsList.Location = new System.Drawing.Point(394, 169);
            this.grpItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Name = "grpItemsList";
            this.grpItemsList.Padding = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Size = new System.Drawing.Size(448, 147);
            this.grpItemsList.TabIndex = 20;
            this.grpItemsList.TabStop = false;
            this.grpItemsList.Text = "Hàng hóa";
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.WeightColumn,
            this.SizeColumn,
            this.QuantityColumn,
            this.ValueColumn,
            this.CostColumn});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(440, 124);
            this.dgvItemsList.TabIndex = 2;
            this.dgvItemsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemsList_CellFormatting);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "name";
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 57;
            // 
            // WeightColumn
            // 
            this.WeightColumn.DataPropertyName = "weight";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.WeightColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.WeightColumn.HeaderText = "Trọng lượng";
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.ReadOnly = true;
            this.WeightColumn.Width = 96;
            // 
            // SizeColumn
            // 
            this.SizeColumn.DataPropertyName = "size";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SizeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SizeColumn.HeaderText = "Kích thước";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            this.SizeColumn.Width = 86;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuantityColumn.HeaderText = "Số lượng";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 79;
            // 
            // ValueColumn
            // 
            this.ValueColumn.DataPropertyName = "value";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValueColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValueColumn.HeaderText = "Trị giá";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            this.ValueColumn.Width = 66;
            // 
            // CostColumn
            // 
            this.CostColumn.DataPropertyName = "cost";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CostColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.CostColumn.HeaderText = "Tổng";
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.ReadOnly = true;
            this.CostColumn.Width = 65;
            // 
            // grpOrdersList
            // 
            this.grpOrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrdersList.Controls.Add(this.dgvOrdersList);
            this.grpOrdersList.Location = new System.Drawing.Point(13, 13);
            this.grpOrdersList.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrdersList.Name = "grpOrdersList";
            this.grpOrdersList.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrdersList.Size = new System.Drawing.Size(374, 303);
            this.grpOrdersList.TabIndex = 19;
            this.grpOrdersList.TabStop = false;
            this.grpOrdersList.Text = "Hóa đơn";
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AllowUserToAddRows = false;
            this.dgvOrdersList.AllowUserToDeleteRows = false;
            this.dgvOrdersList.AllowUserToResizeRows = false;
            this.dgvOrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.IDColumn,
            this.CreatedDateColumn,
            this.TotalCostColumn});
            this.dgvOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersList.Location = new System.Drawing.Point(4, 19);
            this.dgvOrdersList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdersList.MultiSelect = false;
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.RowHeadersVisible = false;
            this.dgvOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersList.Size = new System.Drawing.Size(366, 280);
            this.dgvOrdersList.TabIndex = 1;
            this.dgvOrdersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersList_CellContentClick);
            this.dgvOrdersList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersList_CellValueChanged);
            this.dgvOrdersList.SelectionChanged += new System.EventHandler(this.dgvOrdersList_SelectionChanged);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.MinimumWidth = 28;
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBoxColumn.Width = 28;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "Mã hóa đơn";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // CreatedDateColumn
            // 
            this.CreatedDateColumn.DataPropertyName = "created_date";
            dataGridViewCellStyle6.Format = "dd\\/MM\\/yyyy";
            this.CreatedDateColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.CreatedDateColumn.HeaderText = "Ngày lập";
            this.CreatedDateColumn.Name = "CreatedDateColumn";
            this.CreatedDateColumn.ReadOnly = true;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.DataPropertyName = "total_cost";
            this.TotalCostColumn.HeaderText = "Tổng tiền";
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            this.TotalCostColumn.Visible = false;
            // 
            // CompleteRegularOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(854, 536);
            this.Controls.Add(this.grpAdjustment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.grpItemsList);
            this.Controls.Add(this.grpOrdersList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompleteRegularOrder";
            this.Text = "Quyết toán hóa đơn sĩ";
            this.Load += new System.EventHandler(this.RegularOrderPaymentView_Load);
            this.grpAdjustment.ResumeLayout(false);
            this.grpAdjustment.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.grpItemsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.grpOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrdersList;
        private System.Windows.Forms.DataGridView dgvOrdersList;
        private System.Windows.Forms.GroupBox grpItemsList;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Label lblOrderCostCurrency;
        private System.Windows.Forms.TextBox tbOrderCost;
        private System.Windows.Forms.Label lblOrderCost;
        private System.Windows.Forms.TextBox tbItemsCount;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblPaymentStatusText;
        private System.Windows.Forms.Label lblOrderStatusText;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblAdjustmentAmountCurrency;
        private System.Windows.Forms.TextBox tbAdjustmentAmount;
        private System.Windows.Forms.Label lblRealPaidAmount;
        private System.Windows.Forms.Label lblRealPaidAmountCurrency;
        private System.Windows.Forms.TextBox tbRealPaidAmount;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotalPaymentCurrency;
        private System.Windows.Forms.TextBox tbTotalPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPaymentBalanceText;
        private System.Windows.Forms.Label lblPaymentBalance;
        private System.Windows.Forms.Label lblPaymentBalanceCurrency;
        private System.Windows.Forms.GroupBox grpAdjustment;
        private System.Windows.Forms.CheckBox chkUseAdjustment;
        private System.Windows.Forms.TextBox tbAdjustmentReason;
        private System.Windows.Forms.Label lblAdjustmentReason;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
    }
}