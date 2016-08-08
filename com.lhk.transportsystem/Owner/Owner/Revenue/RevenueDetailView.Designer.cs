namespace com.lhk.transportsystem.Owner.Financial
{
    partial class RevenueDetailView
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvFinacial = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObjectId = new System.Windows.Forms.TextBox();
            this.lblObjectId = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinacial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 464);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(22, 464);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 464);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(434, 464);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(237, 464);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 464);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFinacial);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 189);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvFinacial
            // 
            this.dgvFinacial.AllowUserToAddRows = false;
            this.dgvFinacial.AllowUserToDeleteRows = false;
            this.dgvFinacial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFinacial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinacial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAmount,
            this.colCreateDate,
            this.colCreateBy,
            this.colType,
            this.colDescription,
            this.colObjectId,
            this.colRevenueId});
            this.dgvFinacial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinacial.Location = new System.Drawing.Point(3, 18);
            this.dgvFinacial.MultiSelect = false;
            this.dgvFinacial.Name = "dgvFinacial";
            this.dgvFinacial.ReadOnly = true;
            this.dgvFinacial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinacial.Size = new System.Drawing.Size(538, 168);
            this.dgvFinacial.TabIndex = 0;
            this.dgvFinacial.SelectionChanged += new System.EventHandler(this.dgvFinacial_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Mã";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 52;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "title";
            this.colName.HeaderText = "Tựa đề";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Visible = false;
            this.colName.Width = 76;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "amount";
            this.colAmount.HeaderText = "Số tiền";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 74;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DataPropertyName = "created_date";
            this.colCreateDate.HeaderText = "Ngày tạo";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            this.colCreateDate.Width = 88;
            // 
            // colCreateBy
            // 
            this.colCreateBy.DataPropertyName = "created_by";
            this.colCreateBy.HeaderText = "Người tạo";
            this.colCreateBy.Name = "colCreateBy";
            this.colCreateBy.ReadOnly = true;
            this.colCreateBy.Visible = false;
            this.colCreateBy.Width = 91;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.HeaderText = "Loại";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 59;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "description";
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Visible = false;
            this.colDescription.Width = 66;
            // 
            // colObjectId
            // 
            this.colObjectId.DataPropertyName = "object_id";
            this.colObjectId.HeaderText = "Mã loại thu";
            this.colObjectId.Name = "colObjectId";
            this.colObjectId.ReadOnly = true;
            this.colObjectId.Width = 97;
            // 
            // colRevenueId
            // 
            this.colRevenueId.DataPropertyName = "revenue_id";
            this.colRevenueId.HeaderText = "Mã thu";
            this.colRevenueId.Name = "colRevenueId";
            this.colRevenueId.ReadOnly = true;
            this.colRevenueId.Visible = false;
            this.colRevenueId.Width = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCreatedBy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbObjectId);
            this.groupBox2.Controls.Add(this.lblObjectId);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.tbId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpCreateDate);
            this.groupBox2.Controls.Add(this.tbRemark);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 226);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(382, 112);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(104, 16);
            this.lbCreatedBy.TabIndex = 17;
            this.lbCreatedBy.Text = "<Created_by>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Người tạo:";
            // 
            // tbObjectId
            // 
            this.tbObjectId.Location = new System.Drawing.Point(95, 79);
            this.tbObjectId.Name = "tbObjectId";
            this.tbObjectId.Size = new System.Drawing.Size(184, 22);
            this.tbObjectId.TabIndex = 13;
            // 
            // lblObjectId
            // 
            this.lblObjectId.AutoSize = true;
            this.lblObjectId.Location = new System.Drawing.Point(13, 82);
            this.lblObjectId.Name = "lblObjectId";
            this.lblObjectId.Size = new System.Drawing.Size(75, 16);
            this.lblObjectId.TabIndex = 12;
            this.lblObjectId.Text = "Mã loại thu:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(95, 49);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(184, 24);
            this.cbType.TabIndex = 11;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(95, 21);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(405, 22);
            this.tbId.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mã thu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày tạo:";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCreateDate.Enabled = false;
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(95, 107);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(184, 22);
            this.dtpCreateDate.TabIndex = 3;
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(95, 173);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(405, 48);
            this.tbRemark.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "VNĐ";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(95, 141);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(338, 26);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại thu:";
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalAmount.BackColor = System.Drawing.Color.SpringGreen;
            this.tbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalAmount.Location = new System.Drawing.Point(157, 198);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.ReadOnly = true;
            this.tbTotalAmount.Size = new System.Drawing.Size(319, 29);
            this.tbTotalAmount.TabIndex = 35;
            this.tbTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "VNĐ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tổng tiền:";
            // 
            // RevenueDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 502);
            this.Controls.Add(this.tbTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "RevenueDetailView";
            this.Text = "Chi tiết khoảng thu";
            this.Load += new System.EventHandler(this.ExpenseDetailView_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbTotalAmount, 0);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinacial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvFinacial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbObjectId;
        private System.Windows.Forms.Label lblObjectId;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueId;
    }
}