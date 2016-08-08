namespace AppCommon.Setting
{
    partial class TicketPriceView
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
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeatClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbChair = new System.Windows.Forms.RadioButton();
            this.rbFloor = new System.Windows.Forms.RadioButton();
            this.rbLower = new System.Windows.Forms.RadioButton();
            this.rbUpper = new System.Windows.Forms.RadioButton();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 295);
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(17, 295);
            this.btnAddNew.Size = new System.Drawing.Size(83, 28);
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(106, 295);
            this.btnUpdate.Size = new System.Drawing.Size(83, 28);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(342, 295);
            this.btnClose.Size = new System.Drawing.Size(83, 28);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 295);
            this.btnDelete.Size = new System.Drawing.Size(83, 28);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 295);
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvItemsList);
            this.grpList.Location = new System.Drawing.Point(13, 154);
            this.grpList.Margin = new System.Windows.Forms.Padding(4);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4);
            this.grpList.Size = new System.Drawing.Size(416, 134);
            this.grpList.TabIndex = 10;
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
            this.colSeatClass,
            this.colPrice,
            this.colDescription});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(408, 111);
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
            // colSeatClass
            // 
            this.colSeatClass.DataPropertyName = "seat_class";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSeatClass.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSeatClass.HeaderText = "Loại";
            this.colSeatClass.Name = "colSeatClass";
            this.colSeatClass.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrice.HeaderText = "Giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
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
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.rbChair);
            this.grpDetail.Controls.Add(this.rbFloor);
            this.grpDetail.Controls.Add(this.rbLower);
            this.grpDetail.Controls.Add(this.rbUpper);
            this.grpDetail.Controls.Add(this.lblRemark);
            this.grpDetail.Controls.Add(this.tbRemark);
            this.grpDetail.Controls.Add(this.tbPrice);
            this.grpDetail.Controls.Add(this.lblCode);
            this.grpDetail.Location = new System.Drawing.Point(13, 4);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetail.Size = new System.Drawing.Size(416, 142);
            this.grpDetail.TabIndex = 9;
            this.grpDetail.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "VND";
            // 
            // rbChair
            // 
            this.rbChair.AutoSize = true;
            this.rbChair.Location = new System.Drawing.Point(348, 18);
            this.rbChair.Name = "rbChair";
            this.rbChair.Size = new System.Drawing.Size(51, 20);
            this.rbChair.TabIndex = 120;
            this.rbChair.Text = "Ghế";
            this.rbChair.UseVisualStyleBackColor = true;
            this.rbChair.Visible = false;
            // 
            // rbFloor
            // 
            this.rbFloor.AutoSize = true;
            this.rbFloor.Location = new System.Drawing.Point(274, 18);
            this.rbFloor.Name = "rbFloor";
            this.rbFloor.Size = new System.Drawing.Size(50, 20);
            this.rbFloor.TabIndex = 119;
            this.rbFloor.Text = "Sàn";
            this.rbFloor.UseVisualStyleBackColor = true;
            this.rbFloor.CheckedChanged += new System.EventHandler(this.rbFloor_CheckedChanged);
            // 
            // rbLower
            // 
            this.rbLower.AutoSize = true;
            this.rbLower.Location = new System.Drawing.Point(170, 18);
            this.rbLower.Name = "rbLower";
            this.rbLower.Size = new System.Drawing.Size(87, 20);
            this.rbLower.TabIndex = 118;
            this.rbLower.Text = "Tầng dưới";
            this.rbLower.UseVisualStyleBackColor = true;
            this.rbLower.CheckedChanged += new System.EventHandler(this.rbLower_CheckedChanged);
            // 
            // rbUpper
            // 
            this.rbUpper.AutoSize = true;
            this.rbUpper.Checked = true;
            this.rbUpper.Location = new System.Drawing.Point(63, 18);
            this.rbUpper.Name = "rbUpper";
            this.rbUpper.Size = new System.Drawing.Size(83, 20);
            this.rbUpper.TabIndex = 117;
            this.rbUpper.TabStop = true;
            this.rbUpper.Text = "Tầng trên";
            this.rbUpper.UseVisualStyleBackColor = true;
            this.rbUpper.CheckedChanged += new System.EventHandler(this.rbUpper_CheckedChanged);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(8, 84);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(52, 16);
            this.lblRemark.TabIndex = 115;
            this.lblRemark.Text = "Ghi chú";
            // 
            // tbRemark
            // 
            this.tbRemark.BackColor = System.Drawing.Color.White;
            this.tbRemark.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemark.Location = new System.Drawing.Point(65, 81);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemark.MaxLength = 200;
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(343, 43);
            this.tbRemark.TabIndex = 114;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.White;
            this.tbPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(65, 50);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.MaxLength = 10;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(265, 23);
            this.tbPrice.TabIndex = 0;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(11, 53);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 16);
            this.lblCode.TabIndex = 112;
            this.lblCode.Text = "Giá";
            // 
            // TicketPriceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 339);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpDetail);
            this.Name = "TicketPriceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giá vé";
            this.Load += new System.EventHandler(this.TicketPriceView_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.grpDetail, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
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
        internal System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.RadioButton rbFloor;
        private System.Windows.Forms.RadioButton rbLower;
        private System.Windows.Forms.RadioButton rbUpper;
        private System.Windows.Forms.RadioButton rbChair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeatClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}