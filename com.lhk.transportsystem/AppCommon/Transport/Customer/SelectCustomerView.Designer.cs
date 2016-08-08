namespace AppCommon.Transport.TransportCustomer
{
    partial class SelectCustomerView
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbIDCardNumber = new System.Windows.Forms.TextBox();
            this.lblDCardNumber = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumer = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCustomersList = new System.Windows.Forms.GroupBox();
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCardNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbIDCardNumber);
            this.groupBox1.Controls.Add(this.lblDCardNumber);
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.lblPhoneNumer);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(152, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbIDCardNumber
            // 
            this.tbIDCardNumber.Location = new System.Drawing.Point(82, 75);
            this.tbIDCardNumber.Name = "tbIDCardNumber";
            this.tbIDCardNumber.Size = new System.Drawing.Size(285, 22);
            this.tbIDCardNumber.TabIndex = 3;
            // 
            // lblDCardNumber
            // 
            this.lblDCardNumber.AutoSize = true;
            this.lblDCardNumber.Location = new System.Drawing.Point(6, 78);
            this.lblDCardNumber.Name = "lblDCardNumber";
            this.lblDCardNumber.Size = new System.Drawing.Size(51, 16);
            this.lblDCardNumber.TabIndex = 0;
            this.lblDCardNumber.Text = "CMND:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(82, 47);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(285, 22);
            this.tbPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumer
            // 
            this.lblPhoneNumer.AutoSize = true;
            this.lblPhoneNumer.Location = new System.Drawing.Point(6, 50);
            this.lblPhoneNumer.Name = "lblPhoneNumer";
            this.lblPhoneNumer.Size = new System.Drawing.Size(70, 16);
            this.lblPhoneNumer.TabIndex = 0;
            this.lblPhoneNumer.Text = "Điện thoại:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(82, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(285, 22);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên:";
            // 
            // grpCustomersList
            // 
            this.grpCustomersList.Controls.Add(this.dgvCustomersList);
            this.grpCustomersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCustomersList.Location = new System.Drawing.Point(0, 136);
            this.grpCustomersList.Name = "grpCustomersList";
            this.grpCustomersList.Size = new System.Drawing.Size(379, 205);
            this.grpCustomersList.TabIndex = 1;
            this.grpCustomersList.TabStop = false;
            this.grpCustomersList.Text = "Danh sách:";
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.CompanyColumn,
            this.PhoneNumberColumn,
            this.MobileColumn,
            this.IDCardNumberColumn,
            this.AddressColumn});
            this.dgvCustomersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomersList.Location = new System.Drawing.Point(3, 18);
            this.dgvCustomersList.MultiSelect = false;
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersVisible = false;
            this.dgvCustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersList.Size = new System.Drawing.Size(373, 184);
            this.dgvCustomersList.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(100, 347);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Chọn";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(203, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "name";
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.MinimumWidth = 100;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.DataPropertyName = "company";
            this.CompanyColumn.HeaderText = "Công ty";
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.ReadOnly = true;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.DataPropertyName = "phone";
            this.PhoneNumberColumn.HeaderText = "Điện thoại";
            this.PhoneNumberColumn.MinimumWidth = 50;
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.ReadOnly = true;
            // 
            // MobileColumn
            // 
            this.MobileColumn.DataPropertyName = "mobile";
            this.MobileColumn.HeaderText = "Di động";
            this.MobileColumn.Name = "MobileColumn";
            this.MobileColumn.ReadOnly = true;
            // 
            // IDCardNumberColumn
            // 
            this.IDCardNumberColumn.DataPropertyName = "id_card_number";
            this.IDCardNumberColumn.HeaderText = "CMND";
            this.IDCardNumberColumn.Name = "IDCardNumberColumn";
            this.IDCardNumberColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "address1";
            this.AddressColumn.HeaderText = "Địa chỉ";
            this.AddressColumn.MinimumWidth = 100;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // SelectCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(379, 382);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpCustomersList);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectCustomerView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lựa chọn khách hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCustomersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbIDCardNumber;
        private System.Windows.Forms.Label lblDCardNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumer;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpCustomersList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvCustomersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCardNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
    }
}