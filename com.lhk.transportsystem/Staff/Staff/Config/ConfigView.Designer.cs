namespace Staff
{
    partial class ConfigView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigView));
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvConfig);
            this.grpList.Location = new System.Drawing.Point(13, 101);
            this.grpList.Margin = new System.Windows.Forms.Padding(4);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4);
            this.grpList.Size = new System.Drawing.Size(441, 200);
            this.grpList.TabIndex = 10;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách";
            // 
            // dgvConfig
            // 
            this.dgvConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfig.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colValue});
            this.dgvConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfig.Location = new System.Drawing.Point(4, 19);
            this.dgvConfig.MultiSelect = false;
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfig.Size = new System.Drawing.Size(433, 177);
            this.dgvConfig.TabIndex = 0;
            this.dgvConfig.SelectionChanged += new System.EventHandler(this.dgvConfig_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Mã";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên";
            this.colName.Name = "colName";
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "Value";
            this.colValue.HeaderText = "Giá trị";
            this.colValue.Name = "colValue";
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.tbName);
            this.grpDetail.Controls.Add(this.lblCode);
            this.grpDetail.Controls.Add(this.lblName);
            this.grpDetail.Controls.Add(this.tbValue);
            this.grpDetail.Location = new System.Drawing.Point(13, 4);
            this.grpDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetail.Size = new System.Drawing.Size(441, 89);
            this.grpDetail.TabIndex = 9;
            this.grpDetail.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(65, 23);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.MaxLength = 10;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(368, 23);
            this.tbName.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 23);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 16);
            this.lblCode.TabIndex = 112;
            this.lblCode.Text = "Tên";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 113;
            this.lblName.Text = "Giá trị";
            // 
            // tbValue
            // 
            this.tbValue.BackColor = System.Drawing.Color.White;
            this.tbValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.Location = new System.Drawing.Point(65, 51);
            this.tbValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbValue.MaxLength = 100;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(368, 23);
            this.tbValue.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(132, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 28);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(25, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 28);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(345, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 28);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Đón&g";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(25, 308);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.Load += new System.EventHandler(this.SystemConfigView_Load);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}