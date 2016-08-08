namespace AppCommon.Setting
{
    partial class TransportPriceView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpItemsList = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetailedInfo = new System.Windows.Forms.GroupBox();
            this.lblTransportPriceCurrency = new System.Windows.Forms.Label();
            this.tbTransportPrice = new System.Windows.Forms.TextBox();
            this.lblTransportPrice = new System.Windows.Forms.Label();
            this.lblWeightTo = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.tbWeightTo = new System.Windows.Forms.TextBox();
            this.tbWeightFrom = new System.Windows.Forms.TextBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.grpItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.grpDetailedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 325);
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 102;
            // 
            // btnAddnew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 325);
            this.btnAddNew.Size = new System.Drawing.Size(100, 28);
            this.btnAddNew.TabIndex = 101;
            this.btnAddNew.Text = "Thêm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(118, 325);
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 102;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(392, 325);
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 104;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 325);
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 103;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 325);
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 101;
            // 
            // grpItemsList
            // 
            this.grpItemsList.Controls.Add(this.dgvItemsList);
            this.grpItemsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpItemsList.Location = new System.Drawing.Point(0, 113);
            this.grpItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Name = "grpItemsList";
            this.grpItemsList.Padding = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Size = new System.Drawing.Size(504, 204);
            this.grpItemsList.TabIndex = 10;
            this.grpItemsList.TabStop = false;
            this.grpItemsList.Text = "Danh sách:";
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.SizeColumn,
            this.WeightFromColumn,
            this.WeightToColumn,
            this.TransportPriceColumn});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(496, 181);
            this.dgvItemsList.TabIndex = 4;
            this.dgvItemsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListDetails_CellFormatting);
            this.dgvItemsList.SelectionChanged += new System.EventHandler(this.dgvListDetails_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // SizeColumn
            // 
            this.SizeColumn.DataPropertyName = "size";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SizeColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.SizeColumn.HeaderText = "Kích cỡ";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // WeightFromColumn
            // 
            this.WeightFromColumn.DataPropertyName = "weight_from";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.WeightFromColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.WeightFromColumn.HeaderText = "Từ";
            this.WeightFromColumn.Name = "WeightFromColumn";
            this.WeightFromColumn.ReadOnly = true;
            // 
            // WeightToColumn
            // 
            this.WeightToColumn.DataPropertyName = "weight_to";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.WeightToColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.WeightToColumn.HeaderText = "Đến";
            this.WeightToColumn.Name = "WeightToColumn";
            this.WeightToColumn.ReadOnly = true;
            // 
            // TransportPriceColumn
            // 
            this.TransportPriceColumn.DataPropertyName = "transport_price";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TransportPriceColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.TransportPriceColumn.HeaderText = "Giá vận chuyển";
            this.TransportPriceColumn.Name = "TransportPriceColumn";
            this.TransportPriceColumn.ReadOnly = true;
            // 
            // grpDetailedInfo
            // 
            this.grpDetailedInfo.Controls.Add(this.lblTransportPriceCurrency);
            this.grpDetailedInfo.Controls.Add(this.tbTransportPrice);
            this.grpDetailedInfo.Controls.Add(this.lblTransportPrice);
            this.grpDetailedInfo.Controls.Add(this.lblWeightTo);
            this.grpDetailedInfo.Controls.Add(this.lblWeightUnit);
            this.grpDetailedInfo.Controls.Add(this.tbWeightTo);
            this.grpDetailedInfo.Controls.Add(this.tbWeightFrom);
            this.grpDetailedInfo.Controls.Add(this.cboSize);
            this.grpDetailedInfo.Controls.Add(this.lblSize);
            this.grpDetailedInfo.Controls.Add(this.lblWeight);
            this.grpDetailedInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDetailedInfo.Location = new System.Drawing.Point(0, 0);
            this.grpDetailedInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetailedInfo.Name = "grpDetailedInfo";
            this.grpDetailedInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetailedInfo.Size = new System.Drawing.Size(504, 113);
            this.grpDetailedInfo.TabIndex = 9;
            this.grpDetailedInfo.TabStop = false;
            // 
            // lblTransportPriceCurrency
            // 
            this.lblTransportPriceCurrency.AutoSize = true;
            this.lblTransportPriceCurrency.Location = new System.Drawing.Point(449, 81);
            this.lblTransportPriceCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransportPriceCurrency.Name = "lblTransportPriceCurrency";
            this.lblTransportPriceCurrency.Size = new System.Drawing.Size(37, 16);
            this.lblTransportPriceCurrency.TabIndex = 123;
            this.lblTransportPriceCurrency.Text = "VND";
            // 
            // tbTransportPrice
            // 
            this.tbTransportPrice.Location = new System.Drawing.Point(117, 78);
            this.tbTransportPrice.Name = "tbTransportPrice";
            this.tbTransportPrice.Size = new System.Drawing.Size(325, 22);
            this.tbTransportPrice.TabIndex = 3;
            this.tbTransportPrice.Text = "0";
            this.tbTransportPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTransportPrice.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbTransportPrice.Enter += new System.EventHandler(this.OnEnter);
            this.tbTransportPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTransportPrice_KeyPress);
            // 
            // lblTransportPrice
            // 
            this.lblTransportPrice.AutoSize = true;
            this.lblTransportPrice.Location = new System.Drawing.Point(8, 81);
            this.lblTransportPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransportPrice.Name = "lblTransportPrice";
            this.lblTransportPrice.Size = new System.Drawing.Size(103, 16);
            this.lblTransportPrice.TabIndex = 121;
            this.lblTransportPrice.Text = "Giá vận chuyển:";
            // 
            // lblWeightTo
            // 
            this.lblWeightTo.AutoSize = true;
            this.lblWeightTo.Location = new System.Drawing.Point(264, 53);
            this.lblWeightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeightTo.Name = "lblWeightTo";
            this.lblWeightTo.Size = new System.Drawing.Size(31, 16);
            this.lblWeightTo.TabIndex = 119;
            this.lblWeightTo.Text = "đến";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Location = new System.Drawing.Point(449, 53);
            this.lblWeightUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(24, 16);
            this.lblWeightUnit.TabIndex = 119;
            this.lblWeightUnit.Text = "Kg";
            // 
            // tbWeightTo
            // 
            this.tbWeightTo.Location = new System.Drawing.Point(302, 50);
            this.tbWeightTo.Name = "tbWeightTo";
            this.tbWeightTo.Size = new System.Drawing.Size(140, 22);
            this.tbWeightTo.TabIndex = 2;
            this.tbWeightTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWeightTo.Enter += new System.EventHandler(this.OnEnter);
            this.tbWeightTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnWeightTextBoxesKeyPress);
            this.tbWeightTo.Leave += new System.EventHandler(this.OnLeave);
            // 
            // tbWeightFrom
            // 
            this.tbWeightFrom.Location = new System.Drawing.Point(117, 50);
            this.tbWeightFrom.Name = "tbWeightFrom";
            this.tbWeightFrom.Size = new System.Drawing.Size(140, 22);
            this.tbWeightFrom.TabIndex = 1;
            this.tbWeightFrom.Text = "0";
            this.tbWeightFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWeightFrom.Enter += new System.EventHandler(this.OnEnter);
            this.tbWeightFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnWeightTextBoxesKeyPress);
            this.tbWeightFrom.Leave += new System.EventHandler(this.OnLeave);
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(117, 20);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(369, 24);
            this.cboSize.TabIndex = 0;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(8, 23);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(54, 16);
            this.lblSize.TabIndex = 112;
            this.lblSize.Text = "Kích cỡ:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(8, 53);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(83, 16);
            this.lblWeight.TabIndex = 113;
            this.lblWeight.Text = "Trọng lượng:";
            // 
            // TransportPriceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 365);
            this.Controls.Add(this.grpItemsList);
            this.Controls.Add(this.grpDetailedInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransportPriceView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập giá vận chuyển";
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.grpDetailedInfo, 0);
            this.Controls.SetChildIndex(this.grpItemsList, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.grpItemsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.grpDetailedInfo.ResumeLayout(false);
            this.grpDetailedInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetailedInfo;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.TextBox tbWeightFrom;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.GroupBox grpItemsList;
        private System.Windows.Forms.Label lblTransportPriceCurrency;
        private System.Windows.Forms.TextBox tbTransportPrice;
        private System.Windows.Forms.Label lblTransportPrice;
        private System.Windows.Forms.Label lblWeightTo;
        private System.Windows.Forms.TextBox tbWeightTo;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportPriceColumn;
    }
}