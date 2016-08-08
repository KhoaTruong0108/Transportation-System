namespace AppCommon.Transport.Order
{
    public partial class CreateOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderView));
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblSenderIDCardNo = new System.Windows.Forms.Label();
            this.lblSenderPhoneNumber = new System.Windows.Forms.Label();
            this.grpSenderInfo = new System.Windows.Forms.GroupBox();
            this.btnSenderBrowse = new System.Windows.Forms.Button();
            this.tbSenderPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSenderIDCardNo = new System.Windows.Forms.TextBox();
            this.tbSenderAddress = new System.Windows.Forms.TextBox();
            this.tbSenderName = new System.Windows.Forms.TextBox();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpRecipientInfo = new System.Windows.Forms.GroupBox();
            this.btnRecipientBrowse = new System.Windows.Forms.Button();
            this.tbRecipientPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbRecipientIDCardNo = new System.Windows.Forms.TextBox();
            this.tbRecipientAddress = new System.Windows.Forms.TextBox();
            this.tbRecipientName = new System.Windows.Forms.TextBox();
            this.lblRecipientAddress = new System.Windows.Forms.Label();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.lblRecipientIDCardNo = new System.Windows.Forms.Label();
            this.lblRecipientPhoneNumber = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnPaymentStatus_Unpaid = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentStatus_Paid = new System.Windows.Forms.RadioButton();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.rbtnOrderType_Irregular = new System.Windows.Forms.RadioButton();
            this.rbtnOrderType_Regular = new System.Windows.Forms.RadioButton();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.ucItemsList = new AppCommon.Transport.Order.ItemsListUC();
            this.grpSenderInfo.SuspendLayout();
            this.grpRecipientInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.Location = new System.Drawing.Point(6, 29);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(50, 16);
            this.lblSenderName.TabIndex = 0;
            this.lblSenderName.Text = "Họ tên:";
            // 
            // lblSenderIDCardNo
            // 
            this.lblSenderIDCardNo.AutoSize = true;
            this.lblSenderIDCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderIDCardNo.Location = new System.Drawing.Point(6, 87);
            this.lblSenderIDCardNo.Name = "lblSenderIDCardNo";
            this.lblSenderIDCardNo.Size = new System.Drawing.Size(51, 16);
            this.lblSenderIDCardNo.TabIndex = 0;
            this.lblSenderIDCardNo.Text = "CMND:";
            // 
            // lblSenderPhoneNumber
            // 
            this.lblSenderPhoneNumber.AutoSize = true;
            this.lblSenderPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderPhoneNumber.Location = new System.Drawing.Point(6, 58);
            this.lblSenderPhoneNumber.Name = "lblSenderPhoneNumber";
            this.lblSenderPhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.lblSenderPhoneNumber.TabIndex = 0;
            this.lblSenderPhoneNumber.Text = "Điện thoại:";
            // 
            // grpSenderInfo
            // 
            this.grpSenderInfo.Controls.Add(this.btnSenderBrowse);
            this.grpSenderInfo.Controls.Add(this.tbSenderPhoneNumber);
            this.grpSenderInfo.Controls.Add(this.tbSenderIDCardNo);
            this.grpSenderInfo.Controls.Add(this.tbSenderAddress);
            this.grpSenderInfo.Controls.Add(this.tbSenderName);
            this.grpSenderInfo.Controls.Add(this.lblSenderAddress);
            this.grpSenderInfo.Controls.Add(this.lblSenderName);
            this.grpSenderInfo.Controls.Add(this.lblSenderIDCardNo);
            this.grpSenderInfo.Controls.Add(this.lblSenderPhoneNumber);
            this.grpSenderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSenderInfo.Location = new System.Drawing.Point(12, 130);
            this.grpSenderInfo.Name = "grpSenderInfo";
            this.grpSenderInfo.Size = new System.Drawing.Size(425, 142);
            this.grpSenderInfo.TabIndex = 1;
            this.grpSenderInfo.TabStop = false;
            this.grpSenderInfo.Text = "Thông tin người gửi:";
            // 
            // btnSenderBrowse
            // 
            this.btnSenderBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenderBrowse.Location = new System.Drawing.Point(343, 46);
            this.btnSenderBrowse.Name = "btnSenderBrowse";
            this.btnSenderBrowse.Size = new System.Drawing.Size(75, 41);
            this.btnSenderBrowse.TabIndex = 9;
            this.btnSenderBrowse.Text = "Chọn";
            this.btnSenderBrowse.UseVisualStyleBackColor = true;
            this.btnSenderBrowse.Click += new System.EventHandler(this.btnSenderBrowse_Click);
            // 
            // tbSenderPhoneNumber
            // 
            this.tbSenderPhoneNumber.Location = new System.Drawing.Point(82, 54);
            this.tbSenderPhoneNumber.MaxLength = 20;
            this.tbSenderPhoneNumber.Name = "tbSenderPhoneNumber";
            this.tbSenderPhoneNumber.Size = new System.Drawing.Size(255, 23);
            this.tbSenderPhoneNumber.TabIndex = 2;
            // 
            // tbSenderIDCardNo
            // 
            this.tbSenderIDCardNo.Location = new System.Drawing.Point(82, 83);
            this.tbSenderIDCardNo.MaxLength = 9;
            this.tbSenderIDCardNo.Name = "tbSenderIDCardNo";
            this.tbSenderIDCardNo.Size = new System.Drawing.Size(255, 23);
            this.tbSenderIDCardNo.TabIndex = 3;
            // 
            // tbSenderAddress
            // 
            this.tbSenderAddress.Location = new System.Drawing.Point(82, 112);
            this.tbSenderAddress.Name = "tbSenderAddress";
            this.tbSenderAddress.Size = new System.Drawing.Size(336, 23);
            this.tbSenderAddress.TabIndex = 4;
            // 
            // tbSenderName
            // 
            this.tbSenderName.Location = new System.Drawing.Point(82, 25);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(255, 23);
            this.tbSenderName.TabIndex = 1;
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.AutoSize = true;
            this.lblSenderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAddress.Location = new System.Drawing.Point(6, 116);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(51, 16);
            this.lblSenderAddress.TabIndex = 0;
            this.lblSenderAddress.Text = "Địa chỉ:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(512, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpRecipientInfo
            // 
            this.grpRecipientInfo.Controls.Add(this.btnRecipientBrowse);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientPhoneNumber);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientIDCardNo);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientAddress);
            this.grpRecipientInfo.Controls.Add(this.tbRecipientName);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientAddress);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientName);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientIDCardNo);
            this.grpRecipientInfo.Controls.Add(this.lblRecipientPhoneNumber);
            this.grpRecipientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecipientInfo.Location = new System.Drawing.Point(12, 278);
            this.grpRecipientInfo.Name = "grpRecipientInfo";
            this.grpRecipientInfo.Size = new System.Drawing.Size(425, 142);
            this.grpRecipientInfo.TabIndex = 6;
            this.grpRecipientInfo.TabStop = false;
            this.grpRecipientInfo.Text = "Thông tin người nhận:";
            // 
            // btnRecipientBrowse
            // 
            this.btnRecipientBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipientBrowse.Location = new System.Drawing.Point(343, 46);
            this.btnRecipientBrowse.Name = "btnRecipientBrowse";
            this.btnRecipientBrowse.Size = new System.Drawing.Size(75, 41);
            this.btnRecipientBrowse.TabIndex = 9;
            this.btnRecipientBrowse.Text = "Chọn";
            this.btnRecipientBrowse.UseVisualStyleBackColor = true;
            this.btnRecipientBrowse.Click += new System.EventHandler(this.btnRecipientBrowse_Click);
            // 
            // tbRecipientPhoneNumber
            // 
            this.tbRecipientPhoneNumber.Location = new System.Drawing.Point(82, 54);
            this.tbRecipientPhoneNumber.MaxLength = 20;
            this.tbRecipientPhoneNumber.Name = "tbRecipientPhoneNumber";
            this.tbRecipientPhoneNumber.Size = new System.Drawing.Size(255, 23);
            this.tbRecipientPhoneNumber.TabIndex = 6;
            // 
            // tbRecipientIDCardNo
            // 
            this.tbRecipientIDCardNo.Location = new System.Drawing.Point(82, 83);
            this.tbRecipientIDCardNo.MaxLength = 9;
            this.tbRecipientIDCardNo.Name = "tbRecipientIDCardNo";
            this.tbRecipientIDCardNo.Size = new System.Drawing.Size(255, 23);
            this.tbRecipientIDCardNo.TabIndex = 7;
            // 
            // tbRecipientAddress
            // 
            this.tbRecipientAddress.Location = new System.Drawing.Point(82, 112);
            this.tbRecipientAddress.Name = "tbRecipientAddress";
            this.tbRecipientAddress.Size = new System.Drawing.Size(336, 23);
            this.tbRecipientAddress.TabIndex = 8;
            // 
            // tbRecipientName
            // 
            this.tbRecipientName.Location = new System.Drawing.Point(82, 25);
            this.tbRecipientName.Name = "tbRecipientName";
            this.tbRecipientName.Size = new System.Drawing.Size(255, 23);
            this.tbRecipientName.TabIndex = 5;
            // 
            // lblRecipientAddress
            // 
            this.lblRecipientAddress.AutoSize = true;
            this.lblRecipientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientAddress.Location = new System.Drawing.Point(6, 116);
            this.lblRecipientAddress.Name = "lblRecipientAddress";
            this.lblRecipientAddress.Size = new System.Drawing.Size(51, 16);
            this.lblRecipientAddress.TabIndex = 0;
            this.lblRecipientAddress.Text = "Địa chỉ:";
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.AutoSize = true;
            this.lblRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientName.Location = new System.Drawing.Point(6, 29);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(50, 16);
            this.lblRecipientName.TabIndex = 0;
            this.lblRecipientName.Text = "Họ tên:";
            // 
            // lblRecipientIDCardNo
            // 
            this.lblRecipientIDCardNo.AutoSize = true;
            this.lblRecipientIDCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientIDCardNo.Location = new System.Drawing.Point(6, 87);
            this.lblRecipientIDCardNo.Name = "lblRecipientIDCardNo";
            this.lblRecipientIDCardNo.Size = new System.Drawing.Size(51, 16);
            this.lblRecipientIDCardNo.TabIndex = 0;
            this.lblRecipientIDCardNo.Text = "CMND:";
            // 
            // lblRecipientPhoneNumber
            // 
            this.lblRecipientPhoneNumber.AutoSize = true;
            this.lblRecipientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientPhoneNumber.Location = new System.Drawing.Point(6, 58);
            this.lblRecipientPhoneNumber.Name = "lblRecipientPhoneNumber";
            this.lblRecipientPhoneNumber.Size = new System.Drawing.Size(70, 16);
            this.lblRecipientPhoneNumber.TabIndex = 0;
            this.lblRecipientPhoneNumber.Text = "Điện thoại:";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.panel1);
            this.grpOrderInfo.Controls.Add(this.pnlOrderType);
            this.grpOrderInfo.Controls.Add(this.cboDestination);
            this.grpOrderInfo.Controls.Add(this.lblDestination);
            this.grpOrderInfo.Controls.Add(this.label1);
            this.grpOrderInfo.Controls.Add(this.lblOrderType);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(12, 12);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(425, 112);
            this.grpOrderInfo.TabIndex = 0;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Thông tin hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnPaymentStatus_Unpaid);
            this.panel1.Controls.Add(this.rbtnPaymentStatus_Paid);
            this.panel1.Location = new System.Drawing.Point(145, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 24);
            this.panel1.TabIndex = 17;
            // 
            // rbtnPaymentStatus_Unpaid
            // 
            this.rbtnPaymentStatus_Unpaid.AutoSize = true;
            this.rbtnPaymentStatus_Unpaid.Checked = true;
            this.rbtnPaymentStatus_Unpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaymentStatus_Unpaid.Location = new System.Drawing.Point(3, 2);
            this.rbtnPaymentStatus_Unpaid.Name = "rbtnPaymentStatus_Unpaid";
            this.rbtnPaymentStatus_Unpaid.Size = new System.Drawing.Size(121, 20);
            this.rbtnPaymentStatus_Unpaid.TabIndex = 12;
            this.rbtnPaymentStatus_Unpaid.TabStop = true;
            this.rbtnPaymentStatus_Unpaid.Text = "Chưa thanh toán";
            this.rbtnPaymentStatus_Unpaid.UseVisualStyleBackColor = true;
            // 
            // rbtnPaymentStatus_Paid
            // 
            this.rbtnPaymentStatus_Paid.AutoSize = true;
            this.rbtnPaymentStatus_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaymentStatus_Paid.Location = new System.Drawing.Point(142, 2);
            this.rbtnPaymentStatus_Paid.Name = "rbtnPaymentStatus_Paid";
            this.rbtnPaymentStatus_Paid.Size = new System.Drawing.Size(107, 20);
            this.rbtnPaymentStatus_Paid.TabIndex = 11;
            this.rbtnPaymentStatus_Paid.Text = "Đã thanh toán";
            this.rbtnPaymentStatus_Paid.UseVisualStyleBackColor = true;
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.Controls.Add(this.rbtnOrderType_Irregular);
            this.pnlOrderType.Controls.Add(this.rbtnOrderType_Regular);
            this.pnlOrderType.Location = new System.Drawing.Point(145, 21);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(273, 24);
            this.pnlOrderType.TabIndex = 16;
            // 
            // rbtnOrderType_Irregular
            // 
            this.rbtnOrderType_Irregular.AutoSize = true;
            this.rbtnOrderType_Irregular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOrderType_Irregular.Location = new System.Drawing.Point(142, 2);
            this.rbtnOrderType_Irregular.Name = "rbtnOrderType_Irregular";
            this.rbtnOrderType_Irregular.Size = new System.Drawing.Size(92, 20);
            this.rbtnOrderType_Irregular.TabIndex = 1;
            this.rbtnOrderType_Irregular.Text = "Hóa đơn lẻ";
            this.rbtnOrderType_Irregular.UseVisualStyleBackColor = true;
            this.rbtnOrderType_Irregular.CheckedChanged += new System.EventHandler(this.OnOrderTypeChanged);
            // 
            // rbtnOrderType_Regular
            // 
            this.rbtnOrderType_Regular.AutoSize = true;
            this.rbtnOrderType_Regular.Checked = true;
            this.rbtnOrderType_Regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOrderType_Regular.Location = new System.Drawing.Point(3, 2);
            this.rbtnOrderType_Regular.Name = "rbtnOrderType_Regular";
            this.rbtnOrderType_Regular.Size = new System.Drawing.Size(91, 20);
            this.rbtnOrderType_Regular.TabIndex = 2;
            this.rbtnOrderType_Regular.TabStop = true;
            this.rbtnOrderType_Regular.Text = "Hóa đơn sỉ";
            this.rbtnOrderType_Regular.UseVisualStyleBackColor = true;
            this.rbtnOrderType_Regular.CheckedChanged += new System.EventHandler(this.OnOrderTypeChanged);
            // 
            // cboDestination
            // 
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(145, 81);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(210, 24);
            this.cboDestination.TabIndex = 15;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(6, 84);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(58, 16);
            this.lblDestination.TabIndex = 14;
            this.lblDestination.Text = "Nơi đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tình trạng thanh toán:";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(6, 25);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(37, 16);
            this.lblOrderType.TabIndex = 10;
            this.lblOrderType.Text = "Loại:";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(333, 426);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(108, 28);
            this.btnCreateOrder.TabIndex = 13;
            this.btnCreateOrder.Text = "Tạo hóa đơn";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // ucItemsList
            // 
            this.ucItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucItemsList.Location = new System.Drawing.Point(443, 12);
            this.ucItemsList.Name = "ucItemsList";
            this.ucItemsList.OrderID = "";
            this.ucItemsList.OrderItems = ((System.Collections.ObjectModel.Collection<DBManagement.OrderItem>)(resources.GetObject("ucItemsList.OrderItems")));
            this.ucItemsList.Size = new System.Drawing.Size(469, 408);
            this.ucItemsList.TabIndex = 12;
            // 
            // CreateOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(924, 466);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.ucItemsList);
            this.Controls.Add(this.grpRecipientInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.grpSenderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateOrderView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn mới";
            this.Load += new System.EventHandler(this.CreateOrderView_Load);
            this.grpSenderInfo.ResumeLayout(false);
            this.grpSenderInfo.PerformLayout();
            this.grpRecipientInfo.ResumeLayout(false);
            this.grpRecipientInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblSenderIDCardNo;
        private System.Windows.Forms.Label lblSenderPhoneNumber;
        private System.Windows.Forms.GroupBox grpSenderInfo;
        private System.Windows.Forms.Button btnSenderBrowse;
        private System.Windows.Forms.TextBox tbSenderPhoneNumber;
        private System.Windows.Forms.TextBox tbSenderIDCardNo;
        private System.Windows.Forms.TextBox tbSenderAddress;
        private System.Windows.Forms.TextBox tbSenderName;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpRecipientInfo;
        private System.Windows.Forms.Button btnRecipientBrowse;
        private System.Windows.Forms.TextBox tbRecipientPhoneNumber;
        private System.Windows.Forms.TextBox tbRecipientIDCardNo;
        private System.Windows.Forms.TextBox tbRecipientAddress;
        private System.Windows.Forms.TextBox tbRecipientName;
        private System.Windows.Forms.Label lblRecipientAddress;
        private System.Windows.Forms.Label lblRecipientName;
        private System.Windows.Forms.Label lblRecipientIDCardNo;
        private System.Windows.Forms.Label lblRecipientPhoneNumber;
        private ItemsListUC ucItemsList;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.RadioButton rbtnPaymentStatus_Paid;
        private System.Windows.Forms.RadioButton rbtnPaymentStatus_Unpaid;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.RadioButton rbtnOrderType_Irregular;
        private System.Windows.Forms.RadioButton rbtnOrderType_Regular;
    }
}