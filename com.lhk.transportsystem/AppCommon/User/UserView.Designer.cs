namespace AppCommon.UserManagement
{
    partial class UserView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpUsersList = new System.Windows.Forms.GroupBox();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedByColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUsersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.grpUserInfo.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(205, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpUsersList
            // 
            this.grpUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUsersList.Controls.Add(this.dgvUsersList);
            this.grpUsersList.Location = new System.Drawing.Point(0, 291);
            this.grpUsersList.Margin = new System.Windows.Forms.Padding(4);
            this.grpUsersList.Name = "grpUsersList";
            this.grpUsersList.Padding = new System.Windows.Forms.Padding(4);
            this.grpUsersList.Size = new System.Drawing.Size(484, 204);
            this.grpUsersList.TabIndex = 1;
            this.grpUsersList.TabStop = false;
            this.grpUsersList.Text = "Danh sách người dùng:";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.UserNameColumn,
            this.RoleColumn,
            this.CreatedDateColumn,
            this.CreatedByColumn,
            this.StaffIDColumn,
            this.ActiveStatusColumn});
            this.dgvUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersList.Location = new System.Drawing.Point(4, 19);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersList.Size = new System.Drawing.Size(476, 181);
            this.dgvUsersList.TabIndex = 12;
            this.dgvUsersList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsersList_CellFormatting);
            this.dgvUsersList.SelectionChanged += new System.EventHandler(this.dgvUsersList_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.DataPropertyName = "user_name";
            this.UserNameColumn.HeaderText = "Tên người dùng";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.ReadOnly = true;
            this.UserNameColumn.Width = 88;
            // 
            // RoleColumn
            // 
            this.RoleColumn.DataPropertyName = "role";
            this.RoleColumn.HeaderText = "Vai trò";
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            this.RoleColumn.Width = 66;
            // 
            // CreatedDateColumn
            // 
            this.CreatedDateColumn.DataPropertyName = "created_date";
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.CreatedDateColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.CreatedDateColumn.HeaderText = "Ngày tạo";
            this.CreatedDateColumn.Name = "CreatedDateColumn";
            this.CreatedDateColumn.ReadOnly = true;
            this.CreatedDateColumn.Width = 81;
            // 
            // CreatedByColumn
            // 
            this.CreatedByColumn.DataPropertyName = "created_by";
            this.CreatedByColumn.HeaderText = "Người tạo";
            this.CreatedByColumn.Name = "CreatedByColumn";
            this.CreatedByColumn.ReadOnly = true;
            this.CreatedByColumn.Width = 84;
            // 
            // StaffIDColumn
            // 
            this.StaffIDColumn.DataPropertyName = "staff_id";
            this.StaffIDColumn.HeaderText = "Mã nhân viên";
            this.StaffIDColumn.Name = "StaffIDColumn";
            this.StaffIDColumn.ReadOnly = true;
            this.StaffIDColumn.Width = 80;
            // 
            // ActiveStatusColumn
            // 
            this.ActiveStatusColumn.DataPropertyName = "active_status";
            this.ActiveStatusColumn.HeaderText = "Trạng thái";
            this.ActiveStatusColumn.Name = "ActiveStatusColumn";
            this.ActiveStatusColumn.ReadOnly = true;
            this.ActiveStatusColumn.Width = 86;
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.grpPassword);
            this.grpUserInfo.Controls.Add(this.label6);
            this.grpUserInfo.Controls.Add(this.chkActive);
            this.grpUserInfo.Controls.Add(this.btnRefresh);
            this.grpUserInfo.Controls.Add(this.btnDelete);
            this.grpUserInfo.Controls.Add(this.btnUpdate);
            this.grpUserInfo.Controls.Add(this.btnAdd);
            this.grpUserInfo.Controls.Add(this.cboRole);
            this.grpUserInfo.Controls.Add(this.label4);
            this.grpUserInfo.Controls.Add(this.tbStaffID);
            this.grpUserInfo.Controls.Add(this.label5);
            this.grpUserInfo.Controls.Add(this.tbUserName);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUserInfo.Location = new System.Drawing.Point(0, 0);
            this.grpUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpUserInfo.Size = new System.Drawing.Size(484, 283);
            this.grpUserInfo.TabIndex = 0;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "Thông tin người dùng:";
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.tbCurrentPassword);
            this.grpPassword.Controls.Add(this.lblCurrentPassword);
            this.grpPassword.Controls.Add(this.tbNewPassword);
            this.grpPassword.Controls.Add(this.lblNewPassword);
            this.grpPassword.Controls.Add(this.lblConfirmPassword);
            this.grpPassword.Controls.Add(this.tbConfirmPassword);
            this.grpPassword.Location = new System.Drawing.Point(0, 134);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(484, 112);
            this.grpPassword.TabIndex = 5;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Mật khẩu:";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(141, 21);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(331, 22);
            this.tbCurrentPassword.TabIndex = 1;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            this.tbCurrentPassword.Enter += new System.EventHandler(this.OnEnter);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(12, 24);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(110, 16);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Mật khẩu hiện tại:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(141, 49);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(331, 22);
            this.tbNewPassword.TabIndex = 2;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.Enter += new System.EventHandler(this.OnEnter);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 52);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(90, 16);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Mật khẩu mới:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 80);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(123, 16);
            this.lblConfirmPassword.TabIndex = 0;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(141, 77);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(331, 22);
            this.tbConfirmPassword.TabIndex = 3;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.Enter += new System.EventHandler(this.OnEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng thái:";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(141, 108);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(90, 20);
            this.chkActive.TabIndex = 4;
            this.chkActive.Text = "Hoạt động";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::AppCommon.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(448, 252);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(202, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(107, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(141, 50);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(166, 24);
            this.cboRole.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vai trò:";
            // 
            // tbStaffID
            // 
            this.tbStaffID.Location = new System.Drawing.Point(141, 80);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(331, 22);
            this.tbStaffID.TabIndex = 3;
            this.tbStaffID.Enter += new System.EventHandler(this.OnEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(141, 22);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(331, 22);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Enter += new System.EventHandler(this.OnEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng:";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(484, 538);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpUsersList);
            this.Controls.Add(this.grpUserInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng";
            this.grpUsersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.GroupBox grpUsersList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveStatusColumn;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Button btnRefresh;
    }
}