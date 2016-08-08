namespace AppCommon.Travel.SaleTicket
{
    partial class SaleTicketView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleTicketView));
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.dtDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBusName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchSeat = new System.Windows.Forms.Button();
            this.gbSeatType = new System.Windows.Forms.GroupBox();
            this.rbtnFloorSeat = new System.Windows.Forms.RadioButton();
            this.rbtnUpperSeat = new System.Windows.Forms.RadioButton();
            this.rbtnLowerSeat = new System.Windows.Forms.RadioButton();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPickupLocation = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassengerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSeatMap = new System.Windows.Forms.GroupBox();
            this.ucSeatMap = new AppCommon.Travel.SaleTicket.SeatMap();
            this.gbTicketInfo = new System.Windows.Forms.GroupBox();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSeatNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbSearchInfo.SuspendLayout();
            this.gbSeatType.SuspendLayout();
            this.gbCustomerInfo.SuspendLayout();
            this.grpSeatMap.SuspendLayout();
            this.gbTicketInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchInfo.Controls.Add(this.cboTour);
            this.gbSearchInfo.Controls.Add(this.dtDepartureTime);
            this.gbSearchInfo.Controls.Add(this.label7);
            this.gbSearchInfo.Controls.Add(this.label6);
            this.gbSearchInfo.Controls.Add(this.cboBusName);
            this.gbSearchInfo.Controls.Add(this.label4);
            this.gbSearchInfo.Location = new System.Drawing.Point(280, 12);
            this.gbSearchInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSearchInfo.Size = new System.Drawing.Size(348, 151);
            this.gbSearchInfo.TabIndex = 1;
            this.gbSearchInfo.TabStop = false;
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(130, 107);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(201, 25);
            this.cboTour.TabIndex = 15;
            // 
            // dtDepartureTime
            // 
            this.dtDepartureTime.CustomFormat = "dd/MM/yyyy";
            this.dtDepartureTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDepartureTime.Location = new System.Drawing.Point(130, 63);
            this.dtDepartureTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDepartureTime.Name = "dtDepartureTime";
            this.dtDepartureTime.Size = new System.Drawing.Size(201, 26);
            this.dtDepartureTime.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tuyến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày đi:";
            // 
            // cboBusName
            // 
            this.cboBusName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusName.FormattingEnabled = true;
            this.cboBusName.Location = new System.Drawing.Point(128, 21);
            this.cboBusName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboBusName.Name = "cboBusName";
            this.cboBusName.Size = new System.Drawing.Size(203, 26);
            this.cboBusName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Xe:";
            // 
            // btnSearchSeat
            // 
            this.btnSearchSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSeat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSeat.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSeat.Image")));
            this.btnSearchSeat.Location = new System.Drawing.Point(633, 128);
            this.btnSearchSeat.Name = "btnSearchSeat";
            this.btnSearchSeat.Size = new System.Drawing.Size(146, 35);
            this.btnSearchSeat.TabIndex = 3;
            this.btnSearchSeat.Text = "Tìm";
            this.btnSearchSeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchSeat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchSeat.UseVisualStyleBackColor = true;
            // 
            // gbSeatType
            // 
            this.gbSeatType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSeatType.Controls.Add(this.rbtnFloorSeat);
            this.gbSeatType.Controls.Add(this.rbtnUpperSeat);
            this.gbSeatType.Controls.Add(this.rbtnLowerSeat);
            this.gbSeatType.Location = new System.Drawing.Point(632, 12);
            this.gbSeatType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSeatType.Name = "gbSeatType";
            this.gbSeatType.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSeatType.Size = new System.Drawing.Size(147, 110);
            this.gbSeatType.TabIndex = 2;
            this.gbSeatType.TabStop = false;
            this.gbSeatType.Text = "Loại ghế:";
            // 
            // rbtnFloorSeat
            // 
            this.rbtnFloorSeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnFloorSeat.AutoSize = true;
            this.rbtnFloorSeat.Location = new System.Drawing.Point(23, 79);
            this.rbtnFloorSeat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbtnFloorSeat.Name = "rbtnFloorSeat";
            this.rbtnFloorSeat.Size = new System.Drawing.Size(52, 21);
            this.rbtnFloorSeat.TabIndex = 3;
            this.rbtnFloorSeat.Text = "Sàn";
            this.rbtnFloorSeat.UseVisualStyleBackColor = true;
            // 
            // rbtnUpperSeat
            // 
            this.rbtnUpperSeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnUpperSeat.AutoSize = true;
            this.rbtnUpperSeat.Checked = true;
            this.rbtnUpperSeat.Location = new System.Drawing.Point(23, 23);
            this.rbtnUpperSeat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbtnUpperSeat.Name = "rbtnUpperSeat";
            this.rbtnUpperSeat.Size = new System.Drawing.Size(88, 21);
            this.rbtnUpperSeat.TabIndex = 1;
            this.rbtnUpperSeat.TabStop = true;
            this.rbtnUpperSeat.Text = "Tầng trên";
            this.rbtnUpperSeat.UseVisualStyleBackColor = true;
            // 
            // rbtnLowerSeat
            // 
            this.rbtnLowerSeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnLowerSeat.AutoSize = true;
            this.rbtnLowerSeat.Location = new System.Drawing.Point(23, 51);
            this.rbtnLowerSeat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbtnLowerSeat.Name = "rbtnLowerSeat";
            this.rbtnLowerSeat.Size = new System.Drawing.Size(94, 21);
            this.rbtnLowerSeat.TabIndex = 2;
            this.rbtnLowerSeat.Text = "Tầng dưới";
            this.rbtnLowerSeat.UseVisualStyleBackColor = true;
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomerInfo.Controls.Add(this.label10);
            this.gbCustomerInfo.Controls.Add(this.tbPickupLocation);
            this.gbCustomerInfo.Controls.Add(this.tbPhoneNumber);
            this.gbCustomerInfo.Controls.Add(this.label3);
            this.gbCustomerInfo.Controls.Add(this.tbIDCardNumber);
            this.gbCustomerInfo.Controls.Add(this.label2);
            this.gbCustomerInfo.Controls.Add(this.tbPassengerName);
            this.gbCustomerInfo.Controls.Add(this.label1);
            this.gbCustomerInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerInfo.Location = new System.Drawing.Point(280, 347);
            this.gbCustomerInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbCustomerInfo.Size = new System.Drawing.Size(499, 185);
            this.gbCustomerInfo.TabIndex = 5;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Thông tin hành khách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nơi đón:";
            // 
            // tbPickupLocation
            // 
            this.tbPickupLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPickupLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPickupLocation.Location = new System.Drawing.Point(103, 144);
            this.tbPickupLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPickupLocation.MaxLength = 250;
            this.tbPickupLocation.Name = "tbPickupLocation";
            this.tbPickupLocation.Size = new System.Drawing.Size(389, 26);
            this.tbPickupLocation.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(103, 70);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPhoneNumber.MaxLength = 11;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(389, 26);
            this.tbPhoneNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điện thoại:";
            // 
            // tbIDCardNumber
            // 
            this.tbIDCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIDCardNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDCardNumber.Location = new System.Drawing.Point(103, 107);
            this.tbIDCardNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIDCardNumber.MaxLength = 9;
            this.tbIDCardNumber.Name = "tbIDCardNumber";
            this.tbIDCardNumber.Size = new System.Drawing.Size(389, 26);
            this.tbIDCardNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "CMND:";
            // 
            // tbPassengerName
            // 
            this.tbPassengerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassengerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassengerName.Location = new System.Drawing.Point(103, 33);
            this.tbPassengerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPassengerName.Name = "tbPassengerName";
            this.tbPassengerName.Size = new System.Drawing.Size(389, 26);
            this.tbPassengerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // grpSeatMap
            // 
            this.grpSeatMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSeatMap.Controls.Add(this.ucSeatMap);
            this.grpSeatMap.Location = new System.Drawing.Point(14, 12);
            this.grpSeatMap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpSeatMap.Name = "grpSeatMap";
            this.grpSeatMap.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpSeatMap.Size = new System.Drawing.Size(261, 520);
            this.grpSeatMap.TabIndex = 0;
            this.grpSeatMap.TabStop = false;
            this.grpSeatMap.Text = "Sơ đồ chỗ:";
            // 
            // ucSeatMap
            // 
            this.ucSeatMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSeatMap.Location = new System.Drawing.Point(2, 21);
            this.ucSeatMap.Margin = new System.Windows.Forms.Padding(4);
            this.ucSeatMap.Name = "ucSeatMap";
            this.ucSeatMap.Size = new System.Drawing.Size(257, 496);
            this.ucSeatMap.TabIndex = 0;
            // 
            // gbTicketInfo
            // 
            this.gbTicketInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTicketInfo.Controls.Add(this.lblCreateBy);
            this.gbTicketInfo.Controls.Add(this.label12);
            this.gbTicketInfo.Controls.Add(this.label11);
            this.gbTicketInfo.Controls.Add(this.lblPrice);
            this.gbTicketInfo.Controls.Add(this.label8);
            this.gbTicketInfo.Controls.Add(this.lblSeatNo);
            this.gbTicketInfo.Controls.Add(this.label5);
            this.gbTicketInfo.Controls.Add(this.lblTicketId);
            this.gbTicketInfo.Controls.Add(this.label9);
            this.gbTicketInfo.Location = new System.Drawing.Point(280, 169);
            this.gbTicketInfo.Name = "gbTicketInfo";
            this.gbTicketInfo.Size = new System.Drawing.Size(499, 172);
            this.gbTicketInfo.TabIndex = 4;
            this.gbTicketInfo.TabStop = false;
            this.gbTicketInfo.Text = "Thông tin vé";
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBy.Location = new System.Drawing.Point(127, 96);
            this.lblCreateBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(100, 18);
            this.lblCreateBy.TabIndex = 26;
            this.lblCreateBy.Text = "<Create_By>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Người tạo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(338, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "VNĐ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(130, 129);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(169, 22);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "<Total_payment>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Giá vé:";
            // 
            // lblSeatNo
            // 
            this.lblSeatNo.AutoSize = true;
            this.lblSeatNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNo.Location = new System.Drawing.Point(127, 63);
            this.lblSeatNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeatNo.Name = "lblSeatNo";
            this.lblSeatNo.Size = new System.Drawing.Size(84, 18);
            this.lblSeatNo.TabIndex = 21;
            this.lblSeatNo.Text = "<Seat_no>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số ghế:";
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketId.Location = new System.Drawing.Point(127, 30);
            this.lblTicketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(93, 18);
            this.lblTicketId.TabIndex = 19;
            this.lblTicketId.Text = "<Ticket_ID>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã vé:";
            // 
            // SaleTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(793, 544);
            this.Controls.Add(this.gbTicketInfo);
            this.Controls.Add(this.gbSearchInfo);
            this.Controls.Add(this.btnSearchSeat);
            this.Controls.Add(this.gbSeatType);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.grpSeatMap);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBox = false;
            this.Name = "SaleTicketView";
            this.ShowIcon = false;
            this.Text = "Bán vé";
            this.Load += new System.EventHandler(this.SaleTicketView_Load);
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.gbSeatType.ResumeLayout(false);
            this.gbSeatType.PerformLayout();
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.grpSeatMap.ResumeLayout(false);
            this.gbTicketInfo.ResumeLayout(false);
            this.gbTicketInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeatMap;
        private System.Windows.Forms.GroupBox gbSeatType;
        private System.Windows.Forms.RadioButton rbtnFloorSeat;
        private System.Windows.Forms.RadioButton rbtnUpperSeat;
        private System.Windows.Forms.RadioButton rbtnLowerSeat;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassengerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSearchInfo;
        private System.Windows.Forms.DateTimePicker dtDepartureTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchSeat;
        private SeatMap ucSeatMap;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbTicketInfo;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSeatNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPickupLocation;
    }
}