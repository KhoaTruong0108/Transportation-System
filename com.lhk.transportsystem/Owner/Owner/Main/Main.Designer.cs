﻿namespace Owner.Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.m_tsbAddNew = new Owner.Main.BindableToolStripButton();
            this.m_tsbEdit = new Owner.Main.BindableToolStripButton();
            this.m_tsbDelete = new Owner.Main.BindableToolStripButton();
            this.m_tsbSaveTask = new Owner.Main.BindableToolStripButton();
            this.m_tsbCancelTask = new Owner.Main.BindableToolStripButton();
            this.m_tsbSearch = new Owner.Main.BindableToolStripButton();
            this.m_tsbPrint = new Owner.Main.BindableToolStripButton();
            this.m_tsbExport = new Owner.Main.BindableToolStripButton();
            this.m_tsbLogin = new Owner.Main.BindableToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_tsbHelp = new Owner.Main.BindableToolStripButton();
            this.m_menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsiTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSellTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCompleteTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRegular = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiIrreglar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCompleteIrregularOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFinancial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSetupSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTicketPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTransportPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGuaranteeFee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTicketSection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTicketReturnFee = new System.Windows.Forms.ToolStripMenuItem();
            this.m_sstStatus = new System.Windows.Forms.StatusStrip();
            this.m_tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_tssUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiSaleDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTicketReturnFee = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain.SuspendLayout();
            this.m_menuStrip.SuspendLayout();
            this.m_sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolStripMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tsbAddNew,
            this.m_tsbEdit,
            this.m_tsbDelete,
            this.m_tsbSaveTask,
            this.m_tsbCancelTask,
            this.m_tsbSearch,
            this.m_tsbPrint,
            this.m_tsbExport,
            this.m_tsbLogin,
            this.ToolStripSeparator1,
            this.m_tsbHelp});
            this.ToolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStripMain.Location = new System.Drawing.Point(0, 25);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(1176, 39);
            this.ToolStripMain.TabIndex = 15;
            this.ToolStripMain.Text = "ToolStrip1";
            // 
            // m_tsbAddNew
            // 
            this.m_tsbAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbAddNew.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbAddNew.Image")));
            this.m_tsbAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbAddNew.Name = "m_tsbAddNew";
            this.m_tsbAddNew.Size = new System.Drawing.Size(36, 36);
            this.m_tsbAddNew.Tag = "New";
            this.m_tsbAddNew.Text = "Thêm mới thông tin";
            this.m_tsbAddNew.ToolTipText = "Thêm mới thông tin";
            this.m_tsbAddNew.Click += new System.EventHandler(this.m_tsbAddNew_Click);
            // 
            // m_tsbEdit
            // 
            this.m_tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbEdit.Image")));
            this.m_tsbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbEdit.Name = "m_tsbEdit";
            this.m_tsbEdit.Size = new System.Drawing.Size(36, 36);
            this.m_tsbEdit.Tag = "Edit";
            this.m_tsbEdit.Text = "Sửa thông tin đang chọn";
            this.m_tsbEdit.ToolTipText = "Sửa thông tin đang chọn";
            this.m_tsbEdit.Click += new System.EventHandler(this.m_tsbEdit_Click);
            // 
            // m_tsbDelete
            // 
            this.m_tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbDelete.Image")));
            this.m_tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbDelete.Name = "m_tsbDelete";
            this.m_tsbDelete.Size = new System.Drawing.Size(36, 36);
            this.m_tsbDelete.Tag = "Delete";
            this.m_tsbDelete.Text = "Xóa thông tin đang chọn";
            this.m_tsbDelete.Click += new System.EventHandler(this.m_tsbDelete_Click);
            // 
            // m_tsbSaveTask
            // 
            this.m_tsbSaveTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbSaveTask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbSaveTask.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbSaveTask.Image")));
            this.m_tsbSaveTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbSaveTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbSaveTask.Name = "m_tsbSaveTask";
            this.m_tsbSaveTask.Size = new System.Drawing.Size(36, 36);
            this.m_tsbSaveTask.Tag = "Save";
            this.m_tsbSaveTask.Text = "Lưu thông tin";
            this.m_tsbSaveTask.ToolTipText = "Lưu thông tin";
            this.m_tsbSaveTask.Click += new System.EventHandler(this.m_tsbSave_Click);
            // 
            // m_tsbCancelTask
            // 
            this.m_tsbCancelTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbCancelTask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbCancelTask.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbCancelTask.Image")));
            this.m_tsbCancelTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbCancelTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbCancelTask.Name = "m_tsbCancelTask";
            this.m_tsbCancelTask.Size = new System.Drawing.Size(36, 36);
            this.m_tsbCancelTask.Tag = "Cancel";
            this.m_tsbCancelTask.Text = "Hủy bỏ thao tác";
            this.m_tsbCancelTask.ToolTipText = "Hủy bỏ thao tác";
            this.m_tsbCancelTask.Click += new System.EventHandler(this.m_tsbCancelTask_Click);
            // 
            // m_tsbSearch
            // 
            this.m_tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbSearch.Image")));
            this.m_tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbSearch.Name = "m_tsbSearch";
            this.m_tsbSearch.Size = new System.Drawing.Size(36, 36);
            this.m_tsbSearch.Tag = "AdvanceSearch";
            this.m_tsbSearch.Text = "Tìm kiếm thông tin";
            this.m_tsbSearch.ToolTipText = "Tìm kiếm thông tin";
            this.m_tsbSearch.Click += new System.EventHandler(this.m_tsbSearch_Click);
            // 
            // m_tsbPrint
            // 
            this.m_tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbPrint.Enabled = false;
            this.m_tsbPrint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbPrint.Image")));
            this.m_tsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbPrint.Name = "m_tsbPrint";
            this.m_tsbPrint.Size = new System.Drawing.Size(36, 36);
            this.m_tsbPrint.Tag = "Print";
            this.m_tsbPrint.Text = "In thông tin";
            this.m_tsbPrint.ToolTipText = "In thông tin";
            this.m_tsbPrint.Click += new System.EventHandler(this.m_tsbPrint_Click);
            // 
            // m_tsbExport
            // 
            this.m_tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbExport.Enabled = false;
            this.m_tsbExport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbExport.Image")));
            this.m_tsbExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbExport.Name = "m_tsbExport";
            this.m_tsbExport.Size = new System.Drawing.Size(36, 36);
            this.m_tsbExport.Tag = "Export";
            this.m_tsbExport.Text = "Xuất thông tin";
            this.m_tsbExport.ToolTipText = "Xuất thông tin";
            this.m_tsbExport.Click += new System.EventHandler(this.m_tsbExport_Click);
            // 
            // m_tsbLogin
            // 
            this.m_tsbLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbLogin.Image")));
            this.m_tsbLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbLogin.Name = "m_tsbLogin";
            this.m_tsbLogin.Size = new System.Drawing.Size(36, 36);
            this.m_tsbLogin.Text = "Đăng nhập hệ thống";
            this.m_tsbLogin.ToolTipText = "Đăng nhập hệ thống";
            this.m_tsbLogin.Click += new System.EventHandler(this.m_tsbLogin_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // m_tsbHelp
            // 
            this.m_tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("m_tsbHelp.Image")));
            this.m_tsbHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_tsbHelp.Name = "m_tsbHelp";
            this.m_tsbHelp.Size = new System.Drawing.Size(36, 36);
            this.m_tsbHelp.Tag = "Hellp";
            this.m_tsbHelp.Text = "toolStripButton1";
            // 
            // m_menuStrip
            // 
            this.m_menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiTicket,
            this.tsiTransport,
            this.tsiCustomer,
            this.tsiUser,
            this.tsiFinancial,
            this.tsiSetup});
            this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_menuStrip.Name = "m_menuStrip";
            this.m_menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.m_menuStrip.Size = new System.Drawing.Size(1176, 25);
            this.m_menuStrip.TabIndex = 16;
            this.m_menuStrip.Text = "menuStrip1";
            // 
            // tsiTicket
            // 
            this.tsiTicket.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiSellTicket,
            this.tsiCompleteTicket});
            this.tsiTicket.Name = "tsiTicket";
            this.tsiTicket.Size = new System.Drawing.Size(81, 21);
            this.tsiTicket.Text = "Quản lý vé";
            // 
            // tsiSellTicket
            // 
            this.tsiSellTicket.Name = "tsiSellTicket";
            this.tsiSellTicket.Size = new System.Drawing.Size(130, 22);
            this.tsiSellTicket.Text = "Bán vé";
            this.tsiSellTicket.Click += new System.EventHandler(this.tsiSellTikect_Click);
            // 
            // tsiCompleteTicket
            // 
            this.tsiCompleteTicket.Name = "tsiCompleteTicket";
            this.tsiCompleteTicket.Size = new System.Drawing.Size(130, 22);
            this.tsiCompleteTicket.Text = "Kết sổ vé";
            this.tsiCompleteTicket.Click += new System.EventHandler(this.tsiCompleteTicket_Click);
            // 
            // tsiTransport
            // 
            this.tsiTransport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiRegular,
            this.tsiIrreglar,
            this.tsiCompleteIrregularOrder});
            this.tsiTransport.Name = "tsiTransport";
            this.tsiTransport.Size = new System.Drawing.Size(86, 21);
            this.tsiTransport.Text = "Vận chuyển";
            // 
            // tsiRegular
            // 
            this.tsiRegular.Name = "tsiRegular";
            this.tsiRegular.Size = new System.Drawing.Size(180, 22);
            this.tsiRegular.Text = "Hóa đơn sĩ";
            this.tsiRegular.Click += new System.EventHandler(this.tsiRegluarOrder_Click);
            // 
            // tsiIrreglar
            // 
            this.tsiIrreglar.Name = "tsiIrreglar";
            this.tsiIrreglar.Size = new System.Drawing.Size(180, 22);
            this.tsiIrreglar.Text = "Hóa đơn lẻ";
            this.tsiIrreglar.Click += new System.EventHandler(this.tsiIrregluarOrder_Click);
            // 
            // tsiCompleteIrregularOrder
            // 
            this.tsiCompleteIrregularOrder.Name = "tsiCompleteIrregularOrder";
            this.tsiCompleteIrregularOrder.Size = new System.Drawing.Size(180, 22);
            this.tsiCompleteIrregularOrder.Text = "Kết sổ hóa đơn lẻ";
            this.tsiCompleteIrregularOrder.Click += new System.EventHandler(this.tsiCompleteIrregularOrder_Click);
            // 
            // tsiCustomer
            // 
            this.tsiCustomer.Name = "tsiCustomer";
            this.tsiCustomer.Size = new System.Drawing.Size(88, 21);
            this.tsiCustomer.Text = "Khách hàng";
            this.tsiCustomer.Click += new System.EventHandler(this.tsiCustomer_Click);
            // 
            // tsiUser
            // 
            this.tsiUser.Name = "tsiUser";
            this.tsiUser.Size = new System.Drawing.Size(91, 21);
            this.tsiUser.Text = "Người dùng";
            this.tsiUser.Click += new System.EventHandler(this.tsiUser_Click);
            // 
            // tsiFinancial
            // 
            this.tsiFinancial.Name = "tsiFinancial";
            this.tsiFinancial.Size = new System.Drawing.Size(71, 21);
            this.tsiFinancial.Text = "Tài chính";
            this.tsiFinancial.Click += new System.EventHandler(this.tsiFinancial_Click);
            // 
            // tsiSetup
            // 
            this.tsiSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiSetupSystem,
            this.tsiTicketPrice,
            this.tsiTransportPrice,
            this.tsGuaranteeFee,
            this.tsiSaleDate,
            this.tsTicketReturnFee});
            this.tsiSetup.Name = "tsiSetup";
            this.tsiSetup.Size = new System.Drawing.Size(61, 21);
            this.tsiSetup.Text = "Cài đặt";
            // 
            // tsiSetupSystem
            // 
            this.tsiSetupSystem.Name = "tsiSetupSystem";
            this.tsiSetupSystem.Size = new System.Drawing.Size(163, 22);
            this.tsiSetupSystem.Text = "Hệ thống";
            this.tsiSetupSystem.Click += new System.EventHandler(this.tsiSetupSystem_Click);
            // 
            // tsiTicketPrice
            // 
            this.tsiTicketPrice.Name = "tsiTicketPrice";
            this.tsiTicketPrice.Size = new System.Drawing.Size(163, 22);
            this.tsiTicketPrice.Text = "Giá vé";
            this.tsiTicketPrice.Click += new System.EventHandler(this.tsiTicketPrice_Click);
            // 
            // tsiTransportPrice
            // 
            this.tsiTransportPrice.Name = "tsiTransportPrice";
            this.tsiTransportPrice.Size = new System.Drawing.Size(163, 22);
            this.tsiTransportPrice.Text = "Giá vận chuyển";
            this.tsiTransportPrice.Click += new System.EventHandler(this.tsiTransportPrice_Click);
            // 
            // tsGuaranteeFee
            // 
            this.tsGuaranteeFee.Name = "tsGuaranteeFee";
            this.tsGuaranteeFee.Size = new System.Drawing.Size(163, 22);
            this.tsGuaranteeFee.Text = "Phí đảm bảo";
            this.tsGuaranteeFee.Click += new System.EventHandler(this.tsGuaranteeFee_Click);
            // 
            // tsiTicketSection
            // 
            this.tsiTicketSection.Name = "tsiTicketSection";
            this.tsiTicketSection.Size = new System.Drawing.Size(32, 19);
            // 
            // tsiTicketReturnFee
            // 
            this.tsiTicketReturnFee.Name = "tsiTicketReturnFee";
            this.tsiTicketReturnFee.Size = new System.Drawing.Size(32, 19);
            // 
            // m_sstStatus
            // 
            this.m_sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tssUserName,
            this.m_tssUserRole});
            this.m_sstStatus.Location = new System.Drawing.Point(0, 711);
            this.m_sstStatus.Name = "m_sstStatus";
            this.m_sstStatus.Size = new System.Drawing.Size(1176, 22);
            this.m_sstStatus.TabIndex = 17;
            this.m_sstStatus.Text = "statusStrip1";
            // 
            // m_tssUserName
            // 
            this.m_tssUserName.Name = "m_tssUserName";
            this.m_tssUserName.Size = new System.Drawing.Size(55, 17);
            this.m_tssUserName.Text = "<Name>";
            // 
            // m_tssUserRole
            // 
            this.m_tssUserRole.Name = "m_tssUserRole";
            this.m_tssUserRole.Size = new System.Drawing.Size(46, 17);
            this.m_tssUserRole.Text = "<Role>";
            // 
            // tsiSaleDate
            // 
            this.tsiSaleDate.Name = "tsiSaleDate";
            this.tsiSaleDate.Size = new System.Drawing.Size(163, 22);
            this.tsiSaleDate.Text = "Ngày bán vé";
            this.tsiSaleDate.Click += new System.EventHandler(this.tsiSaleDate_Click);
            // 
            // tsTicketReturnFee
            // 
            this.tsTicketReturnFee.Name = "tsTicketReturnFee";
            this.tsTicketReturnFee.Size = new System.Drawing.Size(163, 22);
            this.tsTicketReturnFee.Text = "Phí hủy vé";
            this.tsTicketReturnFee.Click += new System.EventHandler(this.tsTicketReturnFee_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1176, 733);
            this.Controls.Add(this.m_sstStatus);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.m_menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.m_menuStrip.ResumeLayout(false);
            this.m_menuStrip.PerformLayout();
            this.m_sstStatus.ResumeLayout(false);
            this.m_sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStripMain;
        internal BindableToolStripButton m_tsbAddNew;
        internal BindableToolStripButton m_tsbEdit;
        internal BindableToolStripButton m_tsbSaveTask;
        internal BindableToolStripButton m_tsbCancelTask;
        internal BindableToolStripButton m_tsbDelete;
        internal BindableToolStripButton m_tsbPrint;
        internal BindableToolStripButton m_tsbExport;
        internal BindableToolStripButton m_tsbSearch;
        internal BindableToolStripButton m_tsbLogin;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal BindableToolStripButton m_tsbHelp;
        private System.Windows.Forms.MenuStrip m_menuStrip;
        private System.Windows.Forms.StatusStrip m_sstStatus;
        private System.Windows.Forms.ToolStripStatusLabel m_tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel m_tssUserRole;
        private System.Windows.Forms.ToolStripMenuItem tsiTransport;
        private System.Windows.Forms.ToolStripMenuItem tsiTicketSection;
        private System.Windows.Forms.ToolStripMenuItem tsiRegular;
        private System.Windows.Forms.ToolStripMenuItem tsiIrreglar;
        private System.Windows.Forms.ToolStripMenuItem tsiCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsiUser;
        private System.Windows.Forms.ToolStripMenuItem tsiSetup;
        private System.Windows.Forms.ToolStripMenuItem tsiSetupSystem;
        private System.Windows.Forms.ToolStripMenuItem tsiTicketPrice;
        private System.Windows.Forms.ToolStripMenuItem tsiTransportPrice;
        private System.Windows.Forms.ToolStripMenuItem tsiFinancial;
        private System.Windows.Forms.ToolStripMenuItem tsGuaranteeFee;
        private System.Windows.Forms.ToolStripMenuItem tsiTicketReturnFee;
        private System.Windows.Forms.ToolStripMenuItem tsiTicket;
        private System.Windows.Forms.ToolStripMenuItem tsiSellTicket;
        private System.Windows.Forms.ToolStripMenuItem tsiCompleteTicket;
        private System.Windows.Forms.ToolStripMenuItem tsiCompleteIrregularOrder;
        private System.Windows.Forms.ToolStripMenuItem tsiSaleDate;
        private System.Windows.Forms.ToolStripMenuItem tsTicketReturnFee;
    }
}

