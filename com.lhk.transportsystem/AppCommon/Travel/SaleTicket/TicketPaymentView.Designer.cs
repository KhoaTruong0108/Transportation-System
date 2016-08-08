namespace AppCommon.Travel.SaleTicket
{
    partial class TicketPaymentView
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSellAndPrintReceipt = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblPaymentChange = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPaymentChange = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPaidAmount = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.grpTicketInfo = new System.Windows.Forms.GroupBox();
            this.lblIDCardNumberText = new System.Windows.Forms.Label();
            this.lblIDCardNumber = new System.Windows.Forms.Label();
            this.lblDepartureDateText = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblPhoneNumberText = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPassengerNameText = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblSeatNameText = new System.Windows.Forms.Label();
            this.lblSeatName = new System.Windows.Forms.Label();
            this.lblBusNameText = new System.Windows.Forms.Label();
            this.lblBusName = new System.Windows.Forms.Label();
            this.grpPayment.SuspendLayout();
            this.grpTicketInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(427, 326);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSellAndPrintReceipt
            // 
            this.btnSellAndPrintReceipt.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSellAndPrintReceipt.Enabled = false;
            this.btnSellAndPrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellAndPrintReceipt.Location = new System.Drawing.Point(183, 326);
            this.btnSellAndPrintReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellAndPrintReceipt.Name = "btnSellAndPrintReceipt";
            this.btnSellAndPrintReceipt.Size = new System.Drawing.Size(196, 38);
            this.btnSellAndPrintReceipt.TabIndex = 2;
            this.btnSellAndPrintReceipt.Text = "Bán vé && in hóa đơn";
            this.btnSellAndPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSell.Enabled = false;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(89, 326);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(88, 38);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Bán vé";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblPaymentChange);
            this.grpPayment.Controls.Add(this.label13);
            this.grpPayment.Controls.Add(this.tbPaymentChange);
            this.grpPayment.Controls.Add(this.lblPaidAmount);
            this.grpPayment.Controls.Add(this.label15);
            this.grpPayment.Controls.Add(this.tbPaidAmount);
            this.grpPayment.Controls.Add(this.lblTotalPayment);
            this.grpPayment.Controls.Add(this.label17);
            this.grpPayment.Controls.Add(this.tbTotalPayment);
            this.grpPayment.Location = new System.Drawing.Point(5, 154);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPayment.Size = new System.Drawing.Size(601, 156);
            this.grpPayment.TabIndex = 0;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Thông tin thanh toán";
            // 
            // lblPaymentChange
            // 
            this.lblPaymentChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentChange.AutoSize = true;
            this.lblPaymentChange.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPaymentChange.Location = new System.Drawing.Point(16, 114);
            this.lblPaymentChange.Name = "lblPaymentChange";
            this.lblPaymentChange.Size = new System.Drawing.Size(98, 22);
            this.lblPaymentChange.TabIndex = 34;
            this.lblPaymentChange.Text = "Tiền thối:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(521, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 22);
            this.label13.TabIndex = 36;
            this.label13.Text = "VNĐ";
            // 
            // tbPaymentChange
            // 
            this.tbPaymentChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPaymentChange.BackColor = System.Drawing.Color.White;
            this.tbPaymentChange.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPaymentChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPaymentChange.Location = new System.Drawing.Point(175, 113);
            this.tbPaymentChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaymentChange.Name = "tbPaymentChange";
            this.tbPaymentChange.ReadOnly = true;
            this.tbPaymentChange.Size = new System.Drawing.Size(340, 29);
            this.tbPaymentChange.TabIndex = 35;
            this.tbPaymentChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPaidAmount.Location = new System.Drawing.Point(16, 78);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(107, 22);
            this.lblPaidAmount.TabIndex = 31;
            this.lblPaidAmount.Text = "Khách trả:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(521, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 22);
            this.label15.TabIndex = 33;
            this.label15.Text = "VNĐ";
            // 
            // tbPaidAmount
            // 
            this.tbPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPaidAmount.BackColor = System.Drawing.Color.Lime;
            this.tbPaidAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPaidAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPaidAmount.Location = new System.Drawing.Point(175, 73);
            this.tbPaidAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPaidAmount.Name = "tbPaidAmount";
            this.tbPaidAmount.Size = new System.Drawing.Size(340, 32);
            this.tbPaidAmount.TabIndex = 0;
            this.tbPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPayment.Location = new System.Drawing.Point(16, 38);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(116, 22);
            this.lblTotalPayment.TabIndex = 28;
            this.lblTotalPayment.Text = "Thành tiền:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(521, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 22);
            this.label17.TabIndex = 30;
            this.label17.Text = "VNĐ";
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPayment.BackColor = System.Drawing.Color.Red;
            this.tbTotalPayment.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTotalPayment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTotalPayment.Location = new System.Drawing.Point(175, 30);
            this.tbTotalPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.ReadOnly = true;
            this.tbTotalPayment.Size = new System.Drawing.Size(340, 35);
            this.tbTotalPayment.TabIndex = 29;
            this.tbTotalPayment.Text = "50,000";
            this.tbTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpTicketInfo
            // 
            this.grpTicketInfo.Controls.Add(this.lblIDCardNumberText);
            this.grpTicketInfo.Controls.Add(this.lblIDCardNumber);
            this.grpTicketInfo.Controls.Add(this.lblDepartureDateText);
            this.grpTicketInfo.Controls.Add(this.lblDepartureDate);
            this.grpTicketInfo.Controls.Add(this.lblPhoneNumberText);
            this.grpTicketInfo.Controls.Add(this.lblPhoneNumber);
            this.grpTicketInfo.Controls.Add(this.lblPassengerNameText);
            this.grpTicketInfo.Controls.Add(this.lblPassengerName);
            this.grpTicketInfo.Controls.Add(this.lblSeatNameText);
            this.grpTicketInfo.Controls.Add(this.lblSeatName);
            this.grpTicketInfo.Controls.Add(this.lblBusNameText);
            this.grpTicketInfo.Controls.Add(this.lblBusName);
            this.grpTicketInfo.Location = new System.Drawing.Point(5, 2);
            this.grpTicketInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTicketInfo.Name = "grpTicketInfo";
            this.grpTicketInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTicketInfo.Size = new System.Drawing.Size(601, 145);
            this.grpTicketInfo.TabIndex = 0;
            this.grpTicketInfo.TabStop = false;
            this.grpTicketInfo.Text = "Thông tin vé";
            // 
            // lblIDCardNumberText
            // 
            this.lblIDCardNumberText.AutoSize = true;
            this.lblIDCardNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCardNumberText.Location = new System.Drawing.Point(374, 84);
            this.lblIDCardNumberText.Name = "lblIDCardNumberText";
            this.lblIDCardNumberText.Size = new System.Drawing.Size(62, 16);
            this.lblIDCardNumberText.TabIndex = 20;
            this.lblIDCardNumberText.Text = "<Id_no>";
            // 
            // lblIDCardNumber
            // 
            this.lblIDCardNumber.AutoSize = true;
            this.lblIDCardNumber.Location = new System.Drawing.Point(317, 84);
            this.lblIDCardNumber.Name = "lblIDCardNumber";
            this.lblIDCardNumber.Size = new System.Drawing.Size(51, 16);
            this.lblIDCardNumber.TabIndex = 19;
            this.lblIDCardNumber.Text = "CMND:";
            // 
            // lblDepartureDateText
            // 
            this.lblDepartureDateText.AutoSize = true;
            this.lblDepartureDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDateText.Location = new System.Drawing.Point(136, 112);
            this.lblDepartureDateText.Name = "lblDepartureDateText";
            this.lblDepartureDateText.Size = new System.Drawing.Size(128, 16);
            this.lblDepartureDateText.TabIndex = 18;
            this.lblDepartureDateText.Text = "<departure_time>";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(24, 112);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(104, 16);
            this.lblDepartureDate.TabIndex = 17;
            this.lblDepartureDate.Text = "Ngày khởi hành:";
            // 
            // lblPhoneNumberText
            // 
            this.lblPhoneNumberText.AutoSize = true;
            this.lblPhoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberText.Location = new System.Drawing.Point(136, 84);
            this.lblPhoneNumberText.Name = "lblPhoneNumberText";
            this.lblPhoneNumberText.Size = new System.Drawing.Size(126, 16);
            this.lblPhoneNumberText.TabIndex = 16;
            this.lblPhoneNumberText.Text = "<phone_number>";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 84);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(89, 16);
            this.lblPhoneNumber.TabIndex = 15;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // lblPassengerNameText
            // 
            this.lblPassengerNameText.AutoSize = true;
            this.lblPassengerNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerNameText.Location = new System.Drawing.Point(136, 57);
            this.lblPassengerNameText.Name = "lblPassengerNameText";
            this.lblPassengerNameText.Size = new System.Drawing.Size(144, 16);
            this.lblPassengerNameText.TabIndex = 14;
            this.lblPassengerNameText.Text = "<passenger_name>";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(24, 57);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(106, 16);
            this.lblPassengerName.TabIndex = 13;
            this.lblPassengerName.Text = "Tên hành khách:";
            // 
            // lblSeatNameText
            // 
            this.lblSeatNameText.AutoSize = true;
            this.lblSeatNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNameText.Location = new System.Drawing.Point(313, 44);
            this.lblSeatNameText.Name = "lblSeatNameText";
            this.lblSeatNameText.Size = new System.Drawing.Size(282, 16);
            this.lblSeatNameText.TabIndex = 12;
            this.lblSeatNameText.Text = "A1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17";
            // 
            // lblSeatName
            // 
            this.lblSeatName.AutoSize = true;
            this.lblSeatName.Location = new System.Drawing.Point(313, 28);
            this.lblSeatName.Name = "lblSeatName";
            this.lblSeatName.Size = new System.Drawing.Size(54, 16);
            this.lblSeatName.TabIndex = 11;
            this.lblSeatName.Text = "Số ghế:";
            // 
            // lblBusNameText
            // 
            this.lblBusNameText.AutoSize = true;
            this.lblBusNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusNameText.Location = new System.Drawing.Point(136, 28);
            this.lblBusNameText.Name = "lblBusNameText";
            this.lblBusNameText.Size = new System.Drawing.Size(95, 16);
            this.lblBusNameText.TabIndex = 10;
            this.lblBusNameText.Text = "<bus_name>";
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Location = new System.Drawing.Point(24, 28);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(45, 16);
            this.lblBusName.TabIndex = 0;
            this.lblBusName.Text = "Số xe:";
            // 
            // TicketPaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(619, 382);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSellAndPrintReceipt);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpTicketInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketPaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé";
            this.Load += new System.EventHandler(this.TicketPaymentView_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpTicketInfo.ResumeLayout(false);
            this.grpTicketInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTicketInfo;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnSellAndPrintReceipt;
        private System.Windows.Forms.Label lblBusName;
        private System.Windows.Forms.Label lblDepartureDateText;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblPhoneNumberText;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPassengerNameText;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.Label lblSeatNameText;
        private System.Windows.Forms.Label lblSeatName;
        private System.Windows.Forms.Label lblBusNameText;
        private System.Windows.Forms.Label lblIDCardNumberText;
        private System.Windows.Forms.Label lblIDCardNumber;
        private System.Windows.Forms.Label lblPaymentChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPaymentChange;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPaidAmount;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTotalPayment;
        private System.Windows.Forms.Button btnCancel;
    }
}