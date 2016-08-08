namespace AppCommon.Transport.TransportOrder
{
    partial class CompleteIrregularOrder
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
            this.grpOrdersList = new System.Windows.Forms.GroupBox();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.tbOrderIDCriteria = new System.Windows.Forms.TextBox();
            this.lblOrderIDCriteria = new System.Windows.Forms.Label();
            this.tbOrdersCount = new System.Windows.Forms.TextBox();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalPaymentCurrency = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.CheckboxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrdersList
            // 
            this.grpOrdersList.Controls.Add(this.dgvOrdersList);
            this.grpOrdersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOrdersList.Location = new System.Drawing.Point(0, 81);
            this.grpOrdersList.Name = "grpOrdersList";
            this.grpOrdersList.Size = new System.Drawing.Size(627, 277);
            this.grpOrdersList.TabIndex = 1;
            this.grpOrdersList.TabStop = false;
            this.grpOrdersList.Text = "Danh sách";
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AllowUserToAddRows = false;
            this.dgvOrdersList.AllowUserToDeleteRows = false;
            this.dgvOrdersList.AllowUserToResizeRows = false;
            this.dgvOrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckboxColumn,
            this.IDColumn,
            this.CreatedDateColumn,
            this.RecipientNameColumn,
            this.DeliveryStatusColumn,
            this.TotalCostColumn});
            this.dgvOrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersList.Location = new System.Drawing.Point(3, 18);
            this.dgvOrdersList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.RowHeadersVisible = false;
            this.dgvOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersList.Size = new System.Drawing.Size(621, 256);
            this.dgvOrdersList.TabIndex = 1;
            this.dgvOrdersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersList_CellContentClick);
            this.dgvOrdersList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdersList_CellFormatting);
            this.dgvOrdersList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersList_CellValueChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.cboTour);
            this.grpSearch.Controls.Add(this.lblTour);
            this.grpSearch.Controls.Add(this.tbOrderIDCriteria);
            this.grpSearch.Controls.Add(this.lblOrderIDCriteria);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(627, 81);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(548, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 47);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboTour
            // 
            this.cboTour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(127, 45);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(404, 24);
            this.cboTour.TabIndex = 8;
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(24, 48);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(49, 16);
            this.lblTour.TabIndex = 7;
            this.lblTour.Text = "Tuyến:";
            // 
            // tbOrderIDCriteria
            // 
            this.tbOrderIDCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderIDCriteria.Location = new System.Drawing.Point(127, 17);
            this.tbOrderIDCriteria.Name = "tbOrderIDCriteria";
            this.tbOrderIDCriteria.Size = new System.Drawing.Size(404, 22);
            this.tbOrderIDCriteria.TabIndex = 1;
            // 
            // lblOrderIDCriteria
            // 
            this.lblOrderIDCriteria.AutoSize = true;
            this.lblOrderIDCriteria.Location = new System.Drawing.Point(24, 20);
            this.lblOrderIDCriteria.Name = "lblOrderIDCriteria";
            this.lblOrderIDCriteria.Size = new System.Drawing.Size(82, 16);
            this.lblOrderIDCriteria.TabIndex = 0;
            this.lblOrderIDCriteria.Text = "Mã hóa đơn:";
            // 
            // tbOrdersCount
            // 
            this.tbOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrdersCount.Location = new System.Drawing.Point(150, 378);
            this.tbOrdersCount.Name = "tbOrdersCount";
            this.tbOrdersCount.ReadOnly = true;
            this.tbOrdersCount.Size = new System.Drawing.Size(105, 22);
            this.tbOrdersCount.TabIndex = 3;
            this.tbOrdersCount.Text = "0";
            this.tbOrdersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Location = new System.Drawing.Point(24, 381);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(113, 16);
            this.lblOrdersCount.TabIndex = 2;
            this.lblOrdersCount.Text = "Tổng số hóa đơn:";
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPayment.BackColor = System.Drawing.Color.Red;
            this.tbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPayment.ForeColor = System.Drawing.Color.White;
            this.tbTotalPayment.Location = new System.Drawing.Point(150, 406);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.ReadOnly = true;
            this.tbTotalPayment.Size = new System.Drawing.Size(406, 29);
            this.tbTotalPayment.TabIndex = 5;
            this.tbTotalPayment.Text = "0";
            this.tbTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(24, 409);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(105, 24);
            this.lblTotalPayment.TabIndex = 4;
            this.lblTotalPayment.Text = "Tổng tiền:";
            // 
            // lblTotalPaymentCurrency
            // 
            this.lblTotalPaymentCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPaymentCurrency.AutoSize = true;
            this.lblTotalPaymentCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentCurrency.Location = new System.Drawing.Point(562, 409);
            this.lblTotalPaymentCurrency.Name = "lblTotalPaymentCurrency";
            this.lblTotalPaymentCurrency.Size = new System.Drawing.Size(53, 24);
            this.lblTotalPaymentCurrency.TabIndex = 6;
            this.lblTotalPaymentCurrency.Text = "VNĐ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(386, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(166, 447);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(155, 26);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Kết sổ hóa đơn";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CheckboxColumn
            // 
            this.CheckboxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckboxColumn.FillWeight = 27.41117F;
            this.CheckboxColumn.Frozen = true;
            this.CheckboxColumn.HeaderText = "";
            this.CheckboxColumn.MinimumWidth = 28;
            this.CheckboxColumn.Name = "CheckboxColumn";
            this.CheckboxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckboxColumn.Width = 28;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.FillWeight = 136.2944F;
            this.IDColumn.HeaderText = "Mã hóa đơn";
            this.IDColumn.MinimumWidth = 110;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Width = 110;
            // 
            // CreatedDateColumn
            // 
            this.CreatedDateColumn.DataPropertyName = "created_date";
            this.CreatedDateColumn.FillWeight = 136.2944F;
            this.CreatedDateColumn.HeaderText = "Ngày tạo";
            this.CreatedDateColumn.MinimumWidth = 100;
            this.CreatedDateColumn.Name = "CreatedDateColumn";
            this.CreatedDateColumn.ReadOnly = true;
            // 
            // RecipientNameColumn
            // 
            this.RecipientNameColumn.DataPropertyName = "recipient_name";
            this.RecipientNameColumn.HeaderText = "Người nhận";
            this.RecipientNameColumn.MinimumWidth = 120;
            this.RecipientNameColumn.Name = "RecipientNameColumn";
            this.RecipientNameColumn.ReadOnly = true;
            this.RecipientNameColumn.Width = 120;
            // 
            // DeliveryStatusColumn
            // 
            this.DeliveryStatusColumn.DataPropertyName = "order_status";
            this.DeliveryStatusColumn.HeaderText = "Tình trạng chuyển phát";
            this.DeliveryStatusColumn.MinimumWidth = 170;
            this.DeliveryStatusColumn.Name = "DeliveryStatusColumn";
            this.DeliveryStatusColumn.ReadOnly = true;
            this.DeliveryStatusColumn.Width = 170;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.DataPropertyName = "total_cost";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalCostColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalCostColumn.HeaderText = "Tổng tiền";
            this.TotalCostColumn.MinimumWidth = 120;
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            this.TotalCostColumn.Width = 120;
            // 
            // CompleteIrregularOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(627, 485);
            this.Controls.Add(this.grpOrdersList);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTotalPaymentCurrency);
            this.Controls.Add(this.tbTotalPayment);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.tbOrdersCount);
            this.Controls.Add(this.lblOrdersCount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompleteIrregularOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quyết toán hóa đơn lẻ";
            this.grpOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrdersList;
        private System.Windows.Forms.DataGridView dgvOrdersList;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox tbOrderIDCriteria;
        private System.Windows.Forms.Label lblOrderIDCriteria;
        private System.Windows.Forms.TextBox tbOrdersCount;
        private System.Windows.Forms.Label lblOrdersCount;
        private System.Windows.Forms.TextBox tbTotalPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotalPaymentCurrency;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckboxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;

    }
}