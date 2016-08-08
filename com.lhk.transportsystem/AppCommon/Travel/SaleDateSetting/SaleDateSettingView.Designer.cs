namespace AppCommon.Travel.SaleDateSetting
{
    partial class SaleDateSettingView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.cbSaleYear = new System.Windows.Forms.ComboBox();
            this.cbSaleMonth = new System.Windows.Forms.ComboBox();
            this.cbSaleDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaleDateId = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbBeforeDay = new System.Windows.Forms.TextBox();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketSaleYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketSaleMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketSaleDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeforeDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 329);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(9, 328);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 329);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(383, 328);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 329);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 328);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItemsList);
            this.groupBox1.Location = new System.Drawing.Point(10, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTicketSaleYear,
            this.colTicketSaleMonth,
            this.colTicketSaleDay,
            this.colBeforeDay});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(3, 18);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(476, 159);
            this.dgvItemsList.TabIndex = 0;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.cbSaleYear);
            this.grpDetail.Controls.Add(this.cbSaleMonth);
            this.grpDetail.Controls.Add(this.cbSaleDay);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.tbSaleDateId);
            this.grpDetail.Controls.Add(this.lblCode);
            this.grpDetail.Controls.Add(this.lblName);
            this.grpDetail.Controls.Add(this.tbBeforeDay);
            this.grpDetail.Location = new System.Drawing.Point(9, 3);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetail.Size = new System.Drawing.Size(483, 125);
            this.grpDetail.TabIndex = 10;
            this.grpDetail.TabStop = false;
            // 
            // cbSaleYear
            // 
            this.cbSaleYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaleYear.Enabled = false;
            this.cbSaleYear.FormattingEnabled = true;
            this.cbSaleYear.Location = new System.Drawing.Point(364, 82);
            this.cbSaleYear.Name = "cbSaleYear";
            this.cbSaleYear.Size = new System.Drawing.Size(58, 24);
            this.cbSaleYear.TabIndex = 123;
            // 
            // cbSaleMonth
            // 
            this.cbSaleMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaleMonth.Enabled = false;
            this.cbSaleMonth.FormattingEnabled = true;
            this.cbSaleMonth.Location = new System.Drawing.Point(240, 82);
            this.cbSaleMonth.Name = "cbSaleMonth";
            this.cbSaleMonth.Size = new System.Drawing.Size(58, 24);
            this.cbSaleMonth.TabIndex = 122;
            // 
            // cbSaleDay
            // 
            this.cbSaleDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaleDay.Enabled = false;
            this.cbSaleDay.FormattingEnabled = true;
            this.cbSaleDay.Location = new System.Drawing.Point(87, 82);
            this.cbSaleDay.Name = "cbSaleDay";
            this.cbSaleDay.Size = new System.Drawing.Size(58, 24);
            this.cbSaleDay.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 120;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 118;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "Ngày";
            // 
            // tbSaleDateId
            // 
            this.tbSaleDateId.BackColor = System.Drawing.Color.White;
            this.tbSaleDateId.Enabled = false;
            this.tbSaleDateId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaleDateId.Location = new System.Drawing.Point(87, 20);
            this.tbSaleDateId.Margin = new System.Windows.Forms.Padding(4);
            this.tbSaleDateId.MaxLength = 10;
            this.tbSaleDateId.Name = "tbSaleDateId";
            this.tbSaleDateId.Size = new System.Drawing.Size(388, 23);
            this.tbSaleDateId.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 23);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 16);
            this.lblCode.TabIndex = 112;
            this.lblCode.Text = "Mã số";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 16);
            this.lblName.TabIndex = 113;
            this.lblName.Text = "Bán trước";
            // 
            // tbBeforeDay
            // 
            this.tbBeforeDay.BackColor = System.Drawing.Color.White;
            this.tbBeforeDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeforeDay.Location = new System.Drawing.Point(87, 51);
            this.tbBeforeDay.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeforeDay.MaxLength = 100;
            this.tbBeforeDay.Name = "tbBeforeDay";
            this.tbBeforeDay.Size = new System.Drawing.Size(58, 23);
            this.tbBeforeDay.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Mã";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTicketSaleYear
            // 
            this.colTicketSaleYear.DataPropertyName = "ticket_sale_year";
            this.colTicketSaleYear.HeaderText = "Năm";
            this.colTicketSaleYear.Name = "colTicketSaleYear";
            this.colTicketSaleYear.ReadOnly = true;
            // 
            // colTicketSaleMonth
            // 
            this.colTicketSaleMonth.DataPropertyName = "ticket_sale_month";
            this.colTicketSaleMonth.HeaderText = "Tháng";
            this.colTicketSaleMonth.Name = "colTicketSaleMonth";
            this.colTicketSaleMonth.ReadOnly = true;
            // 
            // colTicketSaleDay
            // 
            this.colTicketSaleDay.DataPropertyName = "ticket_sale_day";
            this.colTicketSaleDay.HeaderText = "Ngày";
            this.colTicketSaleDay.Name = "colTicketSaleDay";
            this.colTicketSaleDay.ReadOnly = true;
            // 
            // colBeforeDay
            // 
            this.colBeforeDay.DataPropertyName = "before_days";
            this.colBeforeDay.HeaderText = "Trước ngày";
            this.colBeforeDay.Name = "colBeforeDay";
            this.colBeforeDay.ReadOnly = true;
            // 
            // SaleDateSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(505, 369);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaleDateSettingView";
            this.Text = "Cài đặt ngày đặt vé";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.grpDetail, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpDetail;
        internal System.Windows.Forms.TextBox tbSaleDateId;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox tbBeforeDay;
        private System.Windows.Forms.ComboBox cbSaleYear;
        private System.Windows.Forms.ComboBox cbSaleMonth;
        private System.Windows.Forms.ComboBox cbSaleDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketSaleYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketSaleMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketSaleDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeforeDay;
    }
}