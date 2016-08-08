namespace com.lhk.transportsystem.Owner.Financial
{
    partial class FinancialView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbYearSearch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMonthSearch = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbTotalExpense = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCreateDateExpenses = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRemarkExpense = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAmountExpense = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNameExpense = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExpenes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalRevenue = new System.Windows.Forms.TextBox();
            this.btnAddRevenue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRevenueDetail = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.lblCreateDateRevenue = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRemarkRevenue = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbAmountRevenue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbNameRevenue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.colRevenueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueDesription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueCreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbTotalProfit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenes)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbYearSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbMonthSearch);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(560, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Năm";
            // 
            // cbYearSearch
            // 
            this.cbYearSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbYearSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearSearch.FormattingEnabled = true;
            this.cbYearSearch.Location = new System.Drawing.Point(420, 21);
            this.cbYearSearch.Name = "cbYearSearch";
            this.cbYearSearch.Size = new System.Drawing.Size(96, 24);
            this.cbYearSearch.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tháng";
            // 
            // cbMonthSearch
            // 
            this.cbMonthSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMonthSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthSearch.FormattingEnabled = true;
            this.cbMonthSearch.Location = new System.Drawing.Point(234, 21);
            this.cbMonthSearch.Name = "cbMonthSearch";
            this.cbMonthSearch.Size = new System.Drawing.Size(92, 24);
            this.cbMonthSearch.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(2, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbTotalExpense);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddExpense);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbTotalRevenue);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddRevenue);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(778, 378);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 2;
            // 
            // tbTotalExpense
            // 
            this.tbTotalExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalExpense.BackColor = System.Drawing.Color.Tomato;
            this.tbTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalExpense.Location = new System.Drawing.Point(106, 171);
            this.tbTotalExpense.Name = "tbTotalExpense";
            this.tbTotalExpense.ReadOnly = true;
            this.tbTotalExpense.Size = new System.Drawing.Size(253, 26);
            this.tbTotalExpense.TabIndex = 30;
            this.tbTotalExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExpense.Image")));
            this.btnAddExpense.Location = new System.Drawing.Point(377, 7);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(27, 28);
            this.btnAddExpense.TabIndex = 29;
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblCreateDateExpenses);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbRemarkExpense);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbAmountExpense);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tbNameExpense);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(5, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 170);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết";
            // 
            // lblCreateDateExpenses
            // 
            this.lblCreateDateExpenses.AutoSize = true;
            this.lblCreateDateExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDateExpenses.Location = new System.Drawing.Point(112, 58);
            this.lblCreateDateExpenses.Name = "lblCreateDateExpenses";
            this.lblCreateDateExpenses.Size = new System.Drawing.Size(109, 16);
            this.lblCreateDateExpenses.TabIndex = 19;
            this.lblCreateDateExpenses.Text = "<Create_date>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ngày tạo:";
            // 
            // tbRemarkExpense
            // 
            this.tbRemarkExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRemarkExpense.Location = new System.Drawing.Point(109, 118);
            this.tbRemarkExpense.Multiline = true;
            this.tbRemarkExpense.Name = "tbRemarkExpense";
            this.tbRemarkExpense.ReadOnly = true;
            this.tbRemarkExpense.Size = new System.Drawing.Size(282, 46);
            this.tbRemarkExpense.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Mô tả:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(348, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "VNĐ";
            // 
            // tbAmountExpense
            // 
            this.tbAmountExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmountExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountExpense.Location = new System.Drawing.Point(109, 88);
            this.tbAmountExpense.Name = "tbAmountExpense";
            this.tbAmountExpense.ReadOnly = true;
            this.tbAmountExpense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmountExpense.Size = new System.Drawing.Size(233, 22);
            this.tbAmountExpense.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Số tiền:";
            // 
            // tbNameExpense
            // 
            this.tbNameExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameExpense.Location = new System.Drawing.Point(109, 24);
            this.tbNameExpense.Name = "tbNameExpense";
            this.tbNameExpense.ReadOnly = true;
            this.tbNameExpense.Size = new System.Drawing.Size(285, 22);
            this.tbNameExpense.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Tên chi phí:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "VNĐ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvExpenes);
            this.groupBox2.Location = new System.Drawing.Point(5, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvExpenes
            // 
            this.dgvExpenes.AllowUserToAddRows = false;
            this.dgvExpenes.AllowUserToDeleteRows = false;
            this.dgvExpenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colExpenseType,
            this.colName,
            this.colAmount,
            this.colDescription,
            this.colCreateBy,
            this.colCreateDate});
            this.dgvExpenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenes.Location = new System.Drawing.Point(3, 18);
            this.dgvExpenes.MultiSelect = false;
            this.dgvExpenes.Name = "dgvExpenes";
            this.dgvExpenes.ReadOnly = true;
            this.dgvExpenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenes.Size = new System.Drawing.Size(396, 106);
            this.dgvExpenes.TabIndex = 0;
            this.dgvExpenes.SelectionChanged += new System.EventHandler(this.dgvExpenes_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Mã";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colExpenseType
            // 
            this.colExpenseType.DataPropertyName = "type";
            this.colExpenseType.HeaderText = "Loại";
            this.colExpenseType.Name = "colExpenseType";
            this.colExpenseType.ReadOnly = true;
            this.colExpenseType.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Tên";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "amount";
            this.colAmount.HeaderText = "Số tiền";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "description";
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Visible = false;
            // 
            // colCreateBy
            // 
            this.colCreateBy.DataPropertyName = "created_by";
            this.colCreateBy.HeaderText = "Tạo bởi";
            this.colCreateBy.Name = "colCreateBy";
            this.colCreateBy.ReadOnly = true;
            this.colCreateBy.Visible = false;
            // 
            // colCreateDate
            // 
            this.colCreateDate.DataPropertyName = "created_date";
            this.colCreateDate.HeaderText = "Ngày tạo";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.ReadOnly = true;
            this.colCreateDate.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng chi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi";
            // 
            // tbTotalRevenue
            // 
            this.tbTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalRevenue.BackColor = System.Drawing.Color.SpringGreen;
            this.tbTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalRevenue.Location = new System.Drawing.Point(83, 170);
            this.tbTotalRevenue.Name = "tbTotalRevenue";
            this.tbTotalRevenue.ReadOnly = true;
            this.tbTotalRevenue.Size = new System.Drawing.Size(213, 26);
            this.tbTotalRevenue.TabIndex = 31;
            this.tbTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddRevenue
            // 
            this.btnAddRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRevenue.Image")));
            this.btnAddRevenue.Location = new System.Drawing.Point(327, 10);
            this.btnAddRevenue.Name = "btnAddRevenue";
            this.btnAddRevenue.Size = new System.Drawing.Size(27, 28);
            this.btnAddRevenue.TabIndex = 28;
            this.btnAddRevenue.UseVisualStyleBackColor = true;
            this.btnAddRevenue.Click += new System.EventHandler(this.tbnAddRevenue_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "VNĐ";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnRevenueDetail);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.lblCreateDateRevenue);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.tbRemarkRevenue);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.tbAmountRevenue);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.tbNameRevenue);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(6, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 170);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết";
            // 
            // btnRevenueDetail
            // 
            this.btnRevenueDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevenueDetail.Enabled = false;
            this.btnRevenueDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenueDetail.Image")));
            this.btnRevenueDetail.Location = new System.Drawing.Point(308, 55);
            this.btnRevenueDetail.Name = "btnRevenueDetail";
            this.btnRevenueDetail.Size = new System.Drawing.Size(27, 23);
            this.btnRevenueDetail.TabIndex = 30;
            this.btnRevenueDetail.UseVisualStyleBackColor = true;
            this.btnRevenueDetail.Click += new System.EventHandler(this.btnExpenseDetail_Click);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(296, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 16);
            this.label25.TabIndex = 21;
            this.label25.Text = "VNĐ";
            // 
            // lblCreateDateRevenue
            // 
            this.lblCreateDateRevenue.AutoSize = true;
            this.lblCreateDateRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDateRevenue.Location = new System.Drawing.Point(103, 58);
            this.lblCreateDateRevenue.Name = "lblCreateDateRevenue";
            this.lblCreateDateRevenue.Size = new System.Drawing.Size(109, 16);
            this.lblCreateDateRevenue.TabIndex = 20;
            this.lblCreateDateRevenue.Text = "<Create_date>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Ngày tạo:";
            // 
            // tbRemarkRevenue
            // 
            this.tbRemarkRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRemarkRevenue.Location = new System.Drawing.Point(106, 118);
            this.tbRemarkRevenue.Multiline = true;
            this.tbRemarkRevenue.Name = "tbRemarkRevenue";
            this.tbRemarkRevenue.ReadOnly = true;
            this.tbRemarkRevenue.Size = new System.Drawing.Size(236, 46);
            this.tbRemarkRevenue.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "Mô tả:";
            // 
            // tbAmountRevenue
            // 
            this.tbAmountRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmountRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountRevenue.Location = new System.Drawing.Point(106, 88);
            this.tbAmountRevenue.Name = "tbAmountRevenue";
            this.tbAmountRevenue.ReadOnly = true;
            this.tbAmountRevenue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmountRevenue.Size = new System.Drawing.Size(184, 22);
            this.tbAmountRevenue.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 16);
            this.label20.TabIndex = 10;
            this.label20.Text = "Số tiền:";
            // 
            // tbNameRevenue
            // 
            this.tbNameRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameRevenue.Location = new System.Drawing.Point(106, 24);
            this.tbNameRevenue.Name = "tbNameRevenue";
            this.tbNameRevenue.ReadOnly = true;
            this.tbNameRevenue.Size = new System.Drawing.Size(236, 22);
            this.tbNameRevenue.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "Tên thu nhập:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng thu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvRevenue);
            this.groupBox3.Location = new System.Drawing.Point(3, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 124);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AllowUserToAddRows = false;
            this.dgvRevenue.AllowUserToDeleteRows = false;
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRevenueId,
            this.colRevenueType,
            this.colRevenueName,
            this.colRevenueAmount,
            this.colRevenueDesription,
            this.colRevenueCreateDate,
            this.colRevenueCreateBy});
            this.dgvRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenue.Location = new System.Drawing.Point(3, 18);
            this.dgvRevenue.MultiSelect = false;
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenue.Size = new System.Drawing.Size(348, 103);
            this.dgvRevenue.TabIndex = 1;
            this.dgvRevenue.SelectionChanged += new System.EventHandler(this.dgvRevenue_SelectionChanged);
            // 
            // colRevenueId
            // 
            this.colRevenueId.DataPropertyName = "id";
            this.colRevenueId.HeaderText = "Mã";
            this.colRevenueId.Name = "colRevenueId";
            this.colRevenueId.ReadOnly = true;
            this.colRevenueId.Visible = false;
            // 
            // colRevenueType
            // 
            this.colRevenueType.DataPropertyName = "type";
            this.colRevenueType.HeaderText = "Loại";
            this.colRevenueType.Name = "colRevenueType";
            this.colRevenueType.ReadOnly = true;
            this.colRevenueType.Visible = false;
            // 
            // colRevenueName
            // 
            this.colRevenueName.DataPropertyName = "name";
            this.colRevenueName.HeaderText = "Tên";
            this.colRevenueName.Name = "colRevenueName";
            this.colRevenueName.ReadOnly = true;
            // 
            // colRevenueAmount
            // 
            this.colRevenueAmount.DataPropertyName = "amount";
            this.colRevenueAmount.HeaderText = "Số tiền";
            this.colRevenueAmount.Name = "colRevenueAmount";
            this.colRevenueAmount.ReadOnly = true;
            // 
            // colRevenueDesription
            // 
            this.colRevenueDesription.DataPropertyName = "description";
            this.colRevenueDesription.HeaderText = "Mô tả";
            this.colRevenueDesription.Name = "colRevenueDesription";
            this.colRevenueDesription.ReadOnly = true;
            this.colRevenueDesription.Visible = false;
            // 
            // colRevenueCreateDate
            // 
            this.colRevenueCreateDate.DataPropertyName = "created_date";
            this.colRevenueCreateDate.HeaderText = "Ngày tạo";
            this.colRevenueCreateDate.Name = "colRevenueCreateDate";
            this.colRevenueCreateDate.ReadOnly = true;
            this.colRevenueCreateDate.Visible = false;
            // 
            // colRevenueCreateBy
            // 
            this.colRevenueCreateBy.DataPropertyName = "created_by";
            this.colRevenueCreateBy.HeaderText = "Người tạo";
            this.colRevenueCreateBy.Name = "colRevenueCreateBy";
            this.colRevenueCreateBy.ReadOnly = true;
            this.colRevenueCreateBy.Visible = false;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(69, 464);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 24);
            this.label23.TabIndex = 4;
            this.label23.Text = "Lợi nhuận:";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(572, 464);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 24);
            this.label24.TabIndex = 6;
            this.label24.Text = "VNĐ";
            // 
            // tbTotalProfit
            // 
            this.tbTotalProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalProfit.BackColor = System.Drawing.Color.SpringGreen;
            this.tbTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalProfit.Location = new System.Drawing.Point(270, 460);
            this.tbTotalProfit.Name = "tbTotalProfit";
            this.tbTotalProfit.ReadOnly = true;
            this.tbTotalProfit.Size = new System.Drawing.Size(293, 31);
            this.tbTotalProfit.TabIndex = 12;
            this.tbTotalProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotalProfit.TextChanged += new System.EventHandler(this.tbTotalProfit_TextChanged);
            // 
            // FinancialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.tbTotalProfit);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "FinancialView";
            this.Text = "FinancialView";
            this.Load += new System.EventHandler(this.FinancialView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenes)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbYearSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMonthSearch;
        private System.Windows.Forms.DataGridView dgvExpenes;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Label lblCreateDateExpenses;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRemarkExpense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbAmountExpense;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbNameExpense;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRemarkRevenue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbAmountRevenue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbNameRevenue;
        private System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Button btnAddRevenue;
        private System.Windows.Forms.Label lblCreateDateRevenue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbTotalProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseCreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseCreateDate;
        private System.Windows.Forms.TextBox tbTotalExpense;
        private System.Windows.Forms.TextBox tbTotalRevenue;
        internal System.Windows.Forms.Button btnRevenueDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueDesription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueCreateBy;
    }
}