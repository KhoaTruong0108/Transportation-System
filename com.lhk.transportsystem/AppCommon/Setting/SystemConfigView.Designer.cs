namespace AppCommon.Setting
{
    partial class SystemConfigView
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
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(124, 478);
            this.btnCancel.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(230, 478);
            this.btnAddNew.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 478);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(354, 478);
            this.btnClose.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(123, 478);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 478);
            this.btnSave.TabIndex = 2;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvItemsList);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpList.Location = new System.Drawing.Point(0, 170);
            this.grpList.Margin = new System.Windows.Forms.Padding(4);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4);
            this.grpList.Size = new System.Drawing.Size(467, 300);
            this.grpList.TabIndex = 2;
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
            this.colName,
            this.colValue,
            this.colDescription});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(459, 277);
            this.dgvItemsList.TabIndex = 4;
            this.dgvItemsList.SelectionChanged += new System.EventHandler(this.dgvItemsList_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Tên";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "value";
            this.colValue.HeaderText = "Giá trị";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "description";
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Visible = false;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.tbID);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.lblRemark);
            this.grpDetail.Controls.Add(this.tbRemark);
            this.grpDetail.Controls.Add(this.tbName);
            this.grpDetail.Controls.Add(this.lblCode);
            this.grpDetail.Controls.Add(this.lblName);
            this.grpDetail.Controls.Add(this.tbValue);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDetail.Location = new System.Drawing.Point(0, 0);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetail.Size = new System.Drawing.Size(467, 170);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.White;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(65, 20);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.MaxLength = 10;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(389, 23);
            this.tbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số:";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(8, 116);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(55, 16);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "Ghi chú:";
            // 
            // tbRemark
            // 
            this.tbRemark.BackColor = System.Drawing.Color.White;
            this.tbRemark.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemark.Location = new System.Drawing.Point(65, 113);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemark.MaxLength = 200;
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(389, 43);
            this.tbRemark.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(65, 51);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.MaxLength = 10;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(389, 23);
            this.tbName.TabIndex = 2;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 54);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Tên:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 85);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Giá trị:";
            // 
            // tbValue
            // 
            this.tbValue.BackColor = System.Drawing.Color.White;
            this.tbValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.Location = new System.Drawing.Point(65, 82);
            this.tbValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbValue.MaxLength = 100;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(389, 23);
            this.tbValue.TabIndex = 3;
            // 
            // SystemConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 518);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpDetail);
            this.Name = "SystemConfigView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.Load += new System.EventHandler(this.SystemConfigView_Load);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
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
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblRemark;
        internal System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox tbValue;
        internal System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCode;
        internal System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}