namespace AppCommon.Setting
{
    partial class TicketReturnFeeView
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
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBeforeHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbBeforeDate = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeforeDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeforeHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 366);
            this.btnCancel.Size = new System.Drawing.Size(86, 28);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(8, 366);
            this.btnAddNew.Size = new System.Drawing.Size(86, 28);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 366);
            this.btnUpdate.Size = new System.Drawing.Size(86, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(318, 366);
            this.btnClose.Size = new System.Drawing.Size(86, 28);
            this.btnClose.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 366);
            this.btnDelete.Size = new System.Drawing.Size(86, 28);
            this.btnDelete.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 366);
            this.btnSave.Size = new System.Drawing.Size(86, 28);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvItemsList);
            this.grpList.Location = new System.Drawing.Point(8, 173);
            this.grpList.Margin = new System.Windows.Forms.Padding(4);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4);
            this.grpList.Size = new System.Drawing.Size(401, 185);
            this.grpList.TabIndex = 1;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách";
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.colBeforeDay,
            this.colBeforeHour,
            this.colFeePercent,
            this.colAmount});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(393, 162);
            this.dgvItemsList.TabIndex = 0;
            this.dgvItemsList.SelectionChanged += new System.EventHandler(this.dgvItemsList_SelectionChanged);
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.label7);
            this.grpDetail.Controls.Add(this.tbBeforeHour);
            this.grpDetail.Controls.Add(this.label6);
            this.grpDetail.Controls.Add(this.label5);
            this.grpDetail.Controls.Add(this.rbAmount);
            this.grpDetail.Controls.Add(this.rbPercent);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.tbAmount);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.tbPercent);
            this.grpDetail.Controls.Add(this.tbId);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.lblRemark);
            this.grpDetail.Controls.Add(this.tbBeforeDate);
            this.grpDetail.Controls.Add(this.lblCode);
            this.grpDetail.Location = new System.Drawing.Point(8, 4);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetail.Size = new System.Drawing.Size(401, 169);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 134;
            this.label7.Text = "Giờ";
            // 
            // tbBeforeHour
            // 
            this.tbBeforeHour.BackColor = System.Drawing.Color.White;
            this.tbBeforeHour.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeforeHour.Location = new System.Drawing.Point(245, 46);
            this.tbBeforeHour.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeforeHour.MaxLength = 10;
            this.tbBeforeHour.Name = "tbBeforeHour";
            this.tbBeforeHour.Size = new System.Drawing.Size(80, 23);
            this.tbBeforeHour.TabIndex = 2;
            this.tbBeforeHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBeforeHour_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "Số tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 131;
            this.label5.Text = "Tỉ lệ:";
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Checked = true;
            this.rbAmount.Location = new System.Drawing.Point(98, 76);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(58, 17);
            this.rbAmount.TabIndex = 3;
            this.rbAmount.TabStop = true;
            this.rbAmount.Text = "Số tiền";
            this.rbAmount.UseVisualStyleBackColor = true;
            this.rbAmount.CheckedChanged += new System.EventHandler(this.rbAmount_CheckedChanged);
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Location = new System.Drawing.Point(184, 76);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(45, 17);
            this.rbPercent.TabIndex = 2;
            this.rbPercent.Text = "Tỉ lệ";
            this.rbPercent.UseVisualStyleBackColor = true;
            this.rbPercent.CheckedChanged += new System.EventHandler(this.rbPercent_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 128;
            this.label4.Text = "VND";
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.White;
            this.tbAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(92, 107);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbAmount.MaxLength = 10;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(233, 23);
            this.tbAmount.TabIndex = 3;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 125;
            this.label3.Text = "%";
            // 
            // tbPercent
            // 
            this.tbPercent.BackColor = System.Drawing.Color.White;
            this.tbPercent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPercent.Location = new System.Drawing.Point(92, 138);
            this.tbPercent.Margin = new System.Windows.Forms.Padding(4);
            this.tbPercent.MaxLength = 10;
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(233, 23);
            this.tbPercent.TabIndex = 4;
            this.tbPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPercent_KeyPress);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.White;
            this.tbId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(98, 15);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.MaxLength = 10;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(277, 23);
            this.tbId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "Mã số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "Ngày";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(17, 80);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(59, 16);
            this.lblRemark.TabIndex = 115;
            this.lblRemark.Text = "Phí theo:";
            // 
            // tbBeforeDate
            // 
            this.tbBeforeDate.BackColor = System.Drawing.Color.White;
            this.tbBeforeDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeforeDate.Location = new System.Drawing.Point(98, 46);
            this.tbBeforeDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeforeDate.MaxLength = 10;
            this.tbBeforeDate.Name = "tbBeforeDate";
            this.tbBeforeDate.Size = new System.Drawing.Size(80, 23);
            this.tbBeforeDate.TabIndex = 1;
            this.tbBeforeDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBeforeDate_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(15, 49);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(61, 16);
            this.lblCode.TabIndex = 112;
            this.lblCode.Text = "Trả trước";
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // colBeforeDay
            // 
            this.colBeforeDay.DataPropertyName = "before_day";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colBeforeDay.DefaultCellStyle = dataGridViewCellStyle1;
            this.colBeforeDay.HeaderText = "Ngày";
            this.colBeforeDay.Name = "colBeforeDay";
            this.colBeforeDay.ReadOnly = true;
            // 
            // colBeforeHour
            // 
            this.colBeforeHour.DataPropertyName = "before_hour";
            this.colBeforeHour.HeaderText = "Giờ";
            this.colBeforeHour.Name = "colBeforeHour";
            this.colBeforeHour.ReadOnly = true;
            // 
            // colFeePercent
            // 
            this.colFeePercent.DataPropertyName = "fee_percent";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colFeePercent.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFeePercent.HeaderText = "Phần trăm";
            this.colFeePercent.Name = "colFeePercent";
            this.colFeePercent.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "fee_amount";
            this.colAmount.HeaderText = "Số tiền";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // TicketReturnFeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 406);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpDetail);
            this.Name = "TicketReturnFeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phí trả vé";
            this.Load += new System.EventHandler(this.TicketReturnFeeConfiguration_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.grpDetail, 0);
            this.Controls.SetChildIndex(this.grpList, 0);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox tbPercent;
        internal System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemark;
        internal System.Windows.Forms.TextBox tbBeforeDate;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox tbBeforeHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeforeDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeforeHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}