namespace AppCommon.Transport.Order
{
    partial class ItemDetailsView
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
            this.components = new System.ComponentModel.Container();
            this.grpItemDetails = new System.Windows.Forms.GroupBox();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblTotalCostCurrency = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbValuePrice = new System.Windows.Forms.TextBox();
            this.lblValuePrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItemDetails
            // 
            this.grpItemDetails.Controls.Add(this.tbTotalCost);
            this.grpItemDetails.Controls.Add(this.cboSize);
            this.grpItemDetails.Controls.Add(this.lblTotalCostCurrency);
            this.grpItemDetails.Controls.Add(this.lblWeightUnit);
            this.grpItemDetails.Controls.Add(this.tbDescription);
            this.grpItemDetails.Controls.Add(this.lblDescription);
            this.grpItemDetails.Controls.Add(this.tbValuePrice);
            this.grpItemDetails.Controls.Add(this.lblValuePrice);
            this.grpItemDetails.Controls.Add(this.btnCancel);
            this.grpItemDetails.Controls.Add(this.btnOK);
            this.grpItemDetails.Controls.Add(this.tbQuantity);
            this.grpItemDetails.Controls.Add(this.lblQuantity);
            this.grpItemDetails.Controls.Add(this.tbWeight);
            this.grpItemDetails.Controls.Add(this.lblTotalCost);
            this.grpItemDetails.Controls.Add(this.lblSize);
            this.grpItemDetails.Controls.Add(this.tbName);
            this.grpItemDetails.Controls.Add(this.lblWeight);
            this.grpItemDetails.Controls.Add(this.lblName);
            this.grpItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpItemDetails.Location = new System.Drawing.Point(0, 0);
            this.grpItemDetails.Name = "grpItemDetails";
            this.grpItemDetails.Size = new System.Drawing.Size(345, 316);
            this.grpItemDetails.TabIndex = 5;
            this.grpItemDetails.TabStop = false;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCost.ForeColor = System.Drawing.Color.Blue;
            this.tbTotalCost.Location = new System.Drawing.Point(111, 244);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(159, 24);
            this.tbTotalCost.TabIndex = 6;
            this.tbTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotalCost.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbTotalCost.Enter += new System.EventHandler(this.OnControlFocus);
            this.tbTotalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalCost_KeyPress);
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(111, 71);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(182, 24);
            this.cboSize.TabIndex = 2;
            this.cboSize.Leave += new System.EventHandler(this.OnControlUnFocus);
            // 
            // lblTotalCostCurrency
            // 
            this.lblTotalCostCurrency.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalCostCurrency.AutoSize = true;
            this.lblTotalCostCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostCurrency.Location = new System.Drawing.Point(276, 246);
            this.lblTotalCostCurrency.Name = "lblTotalCostCurrency";
            this.lblTotalCostCurrency.Size = new System.Drawing.Size(46, 20);
            this.lblTotalCostCurrency.TabIndex = 20;
            this.lblTotalCostCurrency.Text = "VND";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Location = new System.Drawing.Point(299, 46);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(23, 16);
            this.lblWeightUnit.TabIndex = 19;
            this.lblWeightUnit.Text = "kg";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(111, 157);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(211, 77);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbDescription_PreviewKeyDown);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 160);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 16);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Mô tả:";
            // 
            // tbValuePrice
            // 
            this.tbValuePrice.Location = new System.Drawing.Point(111, 129);
            this.tbValuePrice.Name = "tbValuePrice";
            this.tbValuePrice.Size = new System.Drawing.Size(182, 22);
            this.tbValuePrice.TabIndex = 4;
            this.tbValuePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValuePrice.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbValuePrice.Enter += new System.EventHandler(this.OnControlFocus);
            this.tbValuePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValuePrice_KeyPress);
            this.tbValuePrice.Leave += new System.EventHandler(this.OnControlUnFocus);
            // 
            // lblValuePrice
            // 
            this.lblValuePrice.AutoSize = true;
            this.lblValuePrice.Location = new System.Drawing.Point(22, 132);
            this.lblValuePrice.Name = "lblValuePrice";
            this.lblValuePrice.Size = new System.Drawing.Size(49, 16);
            this.lblValuePrice.TabIndex = 15;
            this.lblValuePrice.Text = "Trị giá:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(221, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(25, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Chấp nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(111, 101);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(182, 22);
            this.tbQuantity.TabIndex = 3;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQuantity.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbQuantity.Enter += new System.EventHandler(this.OnControlFocus);
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            this.tbQuantity.Leave += new System.EventHandler(this.OnControlUnFocus);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 104);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Số lượng:";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(111, 43);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(182, 22);
            this.tbWeight.TabIndex = 1;
            this.tbWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWeight.Enter += new System.EventHandler(this.OnControlFocus);
            this.tbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeight_KeyPress);
            this.tbWeight.Leave += new System.EventHandler(this.OnControlUnFocus);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(7, 246);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(98, 20);
            this.lblTotalCost.TabIndex = 4;
            this.lblTotalCost.Text = "Tổng cộng:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(22, 74);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(71, 16);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Kích thước:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 22);
            this.tbName.TabIndex = 0;
            this.tbName.Enter += new System.EventHandler(this.OnControlFocus);
            this.tbName.Leave += new System.EventHandler(this.OnControlUnFocus);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(22, 46);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(83, 16);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Trọng lượng:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Tên:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ItemDetailsView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(345, 316);
            this.Controls.Add(this.grpItemDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemDetailsView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin hàng hóa";
            this.grpItemDetails.ResumeLayout(false);
            this.grpItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItemDetails;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbValuePrice;
        private System.Windows.Forms.Label lblValuePrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblTotalCostCurrency;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbTotalCost;
    }
}