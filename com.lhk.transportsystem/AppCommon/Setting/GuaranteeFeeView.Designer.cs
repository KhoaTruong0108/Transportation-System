namespace AppCommon.Setting
{
    partial class GuaranteeFeeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpDetailedInfo = new System.Windows.Forms.GroupBox();
            this.lblGuaranteeFee = new System.Windows.Forms.Label();
            this.lblValueTo = new System.Windows.Forms.Label();
            this.lblGuaranteeFeeCurrency = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbValueTo = new System.Windows.Forms.TextBox();
            this.tbGuaranteeFee = new System.Windows.Forms.TextBox();
            this.tbValueFrom = new System.Windows.Forms.TextBox();
            this.grpItemsList = new System.Windows.Forms.GroupBox();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuaranteeFeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetailedInfo.SuspendLayout();
            this.grpItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 297);
            // 
            // btnAddnew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 297);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 297);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 297);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 297);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 297);
            // 
            // grpDetailedInfo
            // 
            this.grpDetailedInfo.Controls.Add(this.lblGuaranteeFee);
            this.grpDetailedInfo.Controls.Add(this.lblValueTo);
            this.grpDetailedInfo.Controls.Add(this.lblGuaranteeFeeCurrency);
            this.grpDetailedInfo.Controls.Add(this.lblValue);
            this.grpDetailedInfo.Controls.Add(this.tbValueTo);
            this.grpDetailedInfo.Controls.Add(this.tbGuaranteeFee);
            this.grpDetailedInfo.Controls.Add(this.tbValueFrom);
            this.grpDetailedInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDetailedInfo.Location = new System.Drawing.Point(0, 0);
            this.grpDetailedInfo.Name = "grpDetailedInfo";
            this.grpDetailedInfo.Size = new System.Drawing.Size(484, 83);
            this.grpDetailedInfo.TabIndex = 0;
            this.grpDetailedInfo.TabStop = false;
            // 
            // lblGuaranteeFee
            // 
            this.lblGuaranteeFee.AutoSize = true;
            this.lblGuaranteeFee.Location = new System.Drawing.Point(12, 52);
            this.lblGuaranteeFee.Name = "lblGuaranteeFee";
            this.lblGuaranteeFee.Size = new System.Drawing.Size(87, 16);
            this.lblGuaranteeFee.TabIndex = 1;
            this.lblGuaranteeFee.Text = "Phí đảm bảo:";
            // 
            // lblValueTo
            // 
            this.lblValueTo.AutoSize = true;
            this.lblValueTo.Location = new System.Drawing.Point(251, 24);
            this.lblValueTo.Name = "lblValueTo";
            this.lblValueTo.Size = new System.Drawing.Size(31, 16);
            this.lblValueTo.TabIndex = 1;
            this.lblValueTo.Text = "đến";
            // 
            // lblGuaranteeFeeCurrency
            // 
            this.lblGuaranteeFeeCurrency.AutoSize = true;
            this.lblGuaranteeFeeCurrency.Location = new System.Drawing.Point(434, 52);
            this.lblGuaranteeFeeCurrency.Name = "lblGuaranteeFeeCurrency";
            this.lblGuaranteeFeeCurrency.Size = new System.Drawing.Size(37, 16);
            this.lblGuaranteeFeeCurrency.TabIndex = 1;
            this.lblGuaranteeFeeCurrency.Text = "VND";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 24);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 16);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Giá trị:";
            // 
            // tbValueTo
            // 
            this.tbValueTo.Location = new System.Drawing.Point(288, 21);
            this.tbValueTo.Name = "tbValueTo";
            this.tbValueTo.Size = new System.Drawing.Size(140, 22);
            this.tbValueTo.TabIndex = 1;
            this.tbValueTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValueTo.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbValueTo.Enter += new System.EventHandler(this.OnEnter);
            this.tbValueTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbGuaranteeFee
            // 
            this.tbGuaranteeFee.Location = new System.Drawing.Point(105, 49);
            this.tbGuaranteeFee.Name = "tbGuaranteeFee";
            this.tbGuaranteeFee.Size = new System.Drawing.Size(323, 22);
            this.tbGuaranteeFee.TabIndex = 2;
            this.tbGuaranteeFee.Text = "0";
            this.tbGuaranteeFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGuaranteeFee.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbGuaranteeFee.Enter += new System.EventHandler(this.OnEnter);
            this.tbGuaranteeFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbValueFrom
            // 
            this.tbValueFrom.Location = new System.Drawing.Point(105, 21);
            this.tbValueFrom.Name = "tbValueFrom";
            this.tbValueFrom.Size = new System.Drawing.Size(140, 22);
            this.tbValueFrom.TabIndex = 0;
            this.tbValueFrom.Text = "0";
            this.tbValueFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValueFrom.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbValueFrom.Enter += new System.EventHandler(this.OnEnter);
            this.tbValueFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // grpItemsList
            // 
            this.grpItemsList.Controls.Add(this.dgvItemsList);
            this.grpItemsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpItemsList.Location = new System.Drawing.Point(0, 83);
            this.grpItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Name = "grpItemsList";
            this.grpItemsList.Padding = new System.Windows.Forms.Padding(4);
            this.grpItemsList.Size = new System.Drawing.Size(484, 204);
            this.grpItemsList.TabIndex = 11;
            this.grpItemsList.TabStop = false;
            this.grpItemsList.Text = "Danh sách:";
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.ValueFromColumn,
            this.ValueToColumn,
            this.GuaranteeFeeColumn});
            this.dgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsList.Location = new System.Drawing.Point(4, 19);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(476, 181);
            this.dgvItemsList.TabIndex = 3;
            this.dgvItemsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemsList_CellFormatting);
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
            // ValueFromColumn
            // 
            this.ValueFromColumn.DataPropertyName = "value_from";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValueFromColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValueFromColumn.HeaderText = "Từ";
            this.ValueFromColumn.Name = "ValueFromColumn";
            this.ValueFromColumn.ReadOnly = true;
            // 
            // ValueToColumn
            // 
            this.ValueToColumn.DataPropertyName = "value_to";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValueToColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.ValueToColumn.HeaderText = "Đến";
            this.ValueToColumn.Name = "ValueToColumn";
            this.ValueToColumn.ReadOnly = true;
            // 
            // GuaranteeFeeColumn
            // 
            this.GuaranteeFeeColumn.DataPropertyName = "guarantee_fee";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GuaranteeFeeColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.GuaranteeFeeColumn.HeaderText = "Phí đảm bảo";
            this.GuaranteeFeeColumn.Name = "GuaranteeFeeColumn";
            this.GuaranteeFeeColumn.ReadOnly = true;
            // 
            // GuaranteeFeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 337);
            this.Controls.Add(this.grpItemsList);
            this.Controls.Add(this.grpDetailedInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuaranteeFeeView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập phí đảm bảo";
            this.Controls.SetChildIndex(this.grpDetailedInfo, 0);
            this.Controls.SetChildIndex(this.grpItemsList, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.grpDetailedInfo.ResumeLayout(false);
            this.grpDetailedInfo.PerformLayout();
            this.grpItemsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetailedInfo;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbValueTo;
        private System.Windows.Forms.TextBox tbGuaranteeFee;
        private System.Windows.Forms.TextBox tbValueFrom;
        private System.Windows.Forms.Label lblGuaranteeFee;
        private System.Windows.Forms.Label lblValueTo;
        private System.Windows.Forms.Label lblGuaranteeFeeCurrency;
        private System.Windows.Forms.GroupBox grpItemsList;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuaranteeFeeColumn;
    }
}