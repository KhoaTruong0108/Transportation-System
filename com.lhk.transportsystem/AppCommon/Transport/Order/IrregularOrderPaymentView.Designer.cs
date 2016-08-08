namespace AppCommon.Transport.TransportOrder
{
    partial class IrregularOrderPaymentView
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.tbPaymentBalance = new System.Windows.Forms.TextBox();
            this.lblPaymentChange = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRealPaidAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRealPaidAmount = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblOrderStatusText = new System.Windows.Forms.Label();
            this.lblOrderIDText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbTotalItemsQuantity = new System.Windows.Forms.TextBox();
            this.lblItemsAmount = new System.Windows.Forms.Label();
            this.grpItemsList = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPayment.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            this.grpItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(271, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 37);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(69, 487);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(159, 37);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "Thanh toán";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.tbPaymentBalance);
            this.grpPayment.Controls.Add(this.lblPaymentChange);
            this.grpPayment.Controls.Add(this.label13);
            this.grpPayment.Controls.Add(this.lblRealPaidAmount);
            this.grpPayment.Controls.Add(this.label9);
            this.grpPayment.Controls.Add(this.tbRealPaidAmount);
            this.grpPayment.Controls.Add(this.lblTotalPayment);
            this.grpPayment.Controls.Add(this.label11);
            this.grpPayment.Controls.Add(this.tbTotalPayment);
            this.grpPayment.Location = new System.Drawing.Point(0, 310);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(472, 158);
            this.grpPayment.TabIndex = 33;
            this.grpPayment.TabStop = false;
            // 
            // tbPaymentBalance
            // 
            this.tbPaymentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPaymentBalance.BackColor = System.Drawing.Color.White;
            this.tbPaymentBalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPaymentBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPaymentBalance.Location = new System.Drawing.Point(147, 111);
            this.tbPaymentBalance.Name = "tbPaymentBalance";
            this.tbPaymentBalance.ReadOnly = true;
            this.tbPaymentBalance.Size = new System.Drawing.Size(263, 29);
            this.tbPaymentBalance.TabIndex = 40;
            this.tbPaymentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaymentChange
            // 
            this.lblPaymentChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentChange.AutoSize = true;
            this.lblPaymentChange.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPaymentChange.Location = new System.Drawing.Point(6, 114);
            this.lblPaymentChange.Name = "lblPaymentChange";
            this.lblPaymentChange.Size = new System.Drawing.Size(73, 22);
            this.lblPaymentChange.TabIndex = 37;
            this.lblPaymentChange.Text = "Số dư:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(416, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 22);
            this.label13.TabIndex = 39;
            this.label13.Text = "VNĐ";
            // 
            // lblRealPaidAmount
            // 
            this.lblRealPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRealPaidAmount.AutoSize = true;
            this.lblRealPaidAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRealPaidAmount.Location = new System.Drawing.Point(6, 76);
            this.lblRealPaidAmount.Name = "lblRealPaidAmount";
            this.lblRealPaidAmount.Size = new System.Drawing.Size(109, 22);
            this.lblRealPaidAmount.TabIndex = 31;
            this.lblRealPaidAmount.Text = "Thực Thu:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(416, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "VNĐ";
            // 
            // tbRealPaidAmount
            // 
            this.tbRealPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRealPaidAmount.BackColor = System.Drawing.Color.Lime;
            this.tbRealPaidAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbRealPaidAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRealPaidAmount.Location = new System.Drawing.Point(147, 72);
            this.tbRealPaidAmount.Name = "tbRealPaidAmount";
            this.tbRealPaidAmount.Size = new System.Drawing.Size(263, 32);
            this.tbRealPaidAmount.TabIndex = 32;
            this.tbRealPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRealPaidAmount.TextChanged += new System.EventHandler(this.tbRealAmount_TextChanged);
            this.tbRealPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRealAmount_KeyPress);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPayment.Location = new System.Drawing.Point(6, 38);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(112, 22);
            this.lblTotalPayment.TabIndex = 28;
            this.lblTotalPayment.Text = "Tổng Tiền:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(416, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "VNĐ";
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPayment.BackColor = System.Drawing.Color.Red;
            this.tbTotalPayment.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTotalPayment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTotalPayment.Location = new System.Drawing.Point(147, 30);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.ReadOnly = true;
            this.tbTotalPayment.Size = new System.Drawing.Size(263, 35);
            this.tbTotalPayment.TabIndex = 29;
            this.tbTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(7, 53);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(71, 16);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "Trạng thái:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(7, 26);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(82, 16);
            this.lblOrderStatus.TabIndex = 0;
            this.lblOrderStatus.Text = "Mã hóa đơn:";
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.lblOrderStatusText);
            this.grpOrderDetails.Controls.Add(this.lblOrderIDText);
            this.grpOrderDetails.Controls.Add(this.label8);
            this.grpOrderDetails.Controls.Add(this.tbTotalCost);
            this.grpOrderDetails.Controls.Add(this.lblTotalPrice);
            this.grpOrderDetails.Controls.Add(this.tbTotalItemsQuantity);
            this.grpOrderDetails.Controls.Add(this.lblItemsAmount);
            this.grpOrderDetails.Controls.Add(this.lblPaymentStatus);
            this.grpOrderDetails.Controls.Add(this.lblOrderStatus);
            this.grpOrderDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(472, 149);
            this.grpOrderDetails.TabIndex = 32;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Chi tiết hóa đơn";
            // 
            // lblOrderStatusText
            // 
            this.lblOrderStatusText.AutoSize = true;
            this.lblOrderStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusText.Location = new System.Drawing.Point(146, 53);
            this.lblOrderStatusText.Name = "lblOrderStatusText";
            this.lblOrderStatusText.Size = new System.Drawing.Size(110, 16);
            this.lblOrderStatusText.TabIndex = 10;
            this.lblOrderStatusText.Text = "<order_status>";
            // 
            // lblOrderIDText
            // 
            this.lblOrderIDText.AutoSize = true;
            this.lblOrderIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDText.Location = new System.Drawing.Point(146, 26);
            this.lblOrderIDText.Name = "lblOrderIDText";
            this.lblOrderIDText.Size = new System.Drawing.Size(82, 16);
            this.lblOrderIDText.TabIndex = 9;
            this.lblOrderIDText.Text = "<order_id>";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "VNĐ";
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalCost.Enabled = false;
            this.tbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCost.Location = new System.Drawing.Point(149, 113);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(272, 22);
            this.tbTotalCost.TabIndex = 7;
            this.tbTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(7, 116);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(137, 16);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "Tổng tiền hóa đơn:";
            // 
            // tbTotalItemsQuantity
            // 
            this.tbTotalItemsQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalItemsQuantity.Enabled = false;
            this.tbTotalItemsQuantity.Location = new System.Drawing.Point(149, 80);
            this.tbTotalItemsQuantity.Name = "tbTotalItemsQuantity";
            this.tbTotalItemsQuantity.ReadOnly = true;
            this.tbTotalItemsQuantity.Size = new System.Drawing.Size(272, 22);
            this.tbTotalItemsQuantity.TabIndex = 3;
            this.tbTotalItemsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemsAmount
            // 
            this.lblItemsAmount.AutoSize = true;
            this.lblItemsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsAmount.Location = new System.Drawing.Point(7, 83);
            this.lblItemsAmount.Name = "lblItemsAmount";
            this.lblItemsAmount.Size = new System.Drawing.Size(97, 16);
            this.lblItemsAmount.TabIndex = 2;
            this.lblItemsAmount.Text = "Số lượng hàng:";
            // 
            // grpItemsList
            // 
            this.grpItemsList.Controls.Add(this.dgvItemsList);
            this.grpItemsList.Location = new System.Drawing.Point(0, 156);
            this.grpItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Name = "grpItemsList";
            this.grpItemsList.Padding = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Size = new System.Drawing.Size(472, 147);
            this.grpItemsList.TabIndex = 31;
            this.grpItemsList.TabStop = false;
            this.grpItemsList.Text = "Hàng hóa";
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.WeightColumn,
            this.SizeColumn,
            this.QuantityColumn,
            this.ValueColumn,
            this.TotalCostColumn});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(464, 124);
            this.dgvItemsList.TabIndex = 1;
            this.dgvItemsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemsList_CellFormatting);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "name";
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // WeightColumn
            // 
            this.WeightColumn.DataPropertyName = "weight";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = null;
            this.WeightColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.WeightColumn.HeaderText = "Trọng lượng";
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.ReadOnly = true;
            // 
            // SizeColumn
            // 
            this.SizeColumn.DataPropertyName = "size";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SizeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SizeColumn.HeaderText = "Kích thước";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuantityColumn.HeaderText = "Số lượng";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            this.ValueColumn.DataPropertyName = "value";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = null;
            this.ValueColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValueColumn.HeaderText = "Trị giá";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.DataPropertyName = "cost";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalCostColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalCostColumn.HeaderText = "Tổng";
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            // 
            // IrregularOrderPaymentView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(472, 536);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.grpItemsList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IrregularOrderPaymentView";
            this.ShowIcon = false;
            this.Text = "Thanh toán hóa đơn";
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.grpItemsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblPaymentChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRealPaidAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRealPaidAmount;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTotalPayment;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Label lblOrderStatusText;
        private System.Windows.Forms.Label lblOrderIDText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tbTotalItemsQuantity;
        private System.Windows.Forms.Label lblItemsAmount;
        private System.Windows.Forms.GroupBox grpItemsList;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.TextBox tbPaymentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;



    }
}