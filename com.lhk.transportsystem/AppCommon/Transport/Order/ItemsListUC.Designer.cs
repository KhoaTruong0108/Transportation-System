namespace AppCommon.Transport.Order
{
    partial class ItemsListUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpItemsList = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItemsList
            // 
            this.grpItemsList.Controls.Add(this.btnRemove);
            this.grpItemsList.Controls.Add(this.btnEdit);
            this.grpItemsList.Controls.Add(this.btnAdd);
            this.grpItemsList.Controls.Add(this.dgvItemsList);
            this.grpItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItemsList.Location = new System.Drawing.Point(0, 0);
            this.grpItemsList.Name = "grpItemsList";
            this.grpItemsList.Size = new System.Drawing.Size(550, 280);
            this.grpItemsList.TabIndex = 0;
            this.grpItemsList.TabStop = false;
            this.grpItemsList.Text = "Danh sách hàng hóa:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackgroundImage = global::AppCommon.Properties.Resources.delete;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(516, 89);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundImage = global::AppCommon.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(516, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = global::AppCommon.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(516, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.AllowUserToResizeRows = false;
            this.dgvItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.WeightColumn,
            this.SizeColumn,
            this.QuantityColumn,
            this.ValuePriceColumn,
            this.TotalCostColumn});
            this.dgvItemsList.Location = new System.Drawing.Point(6, 21);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            this.dgvItemsList.RowHeadersVisible = false;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(504, 253);
            this.dgvItemsList.TabIndex = 0;
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
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // WeightColumn
            // 
            this.WeightColumn.DataPropertyName = "weight";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.WeightColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.WeightColumn.HeaderText = "Trọng lượng";
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.ReadOnly = true;
            // 
            // SizeColumn
            // 
            this.SizeColumn.DataPropertyName = "size";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SizeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SizeColumn.HeaderText = "Kích thước";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.QuantityColumn.HeaderText = "Số lượng";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // ValuePriceColumn
            // 
            this.ValuePriceColumn.DataPropertyName = "value";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValuePriceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValuePriceColumn.HeaderText = "Trị giá";
            this.ValuePriceColumn.Name = "ValuePriceColumn";
            this.ValuePriceColumn.ReadOnly = true;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.DataPropertyName = "cost";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = null;
            this.TotalCostColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalCostColumn.HeaderText = "Tổng";
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            // 
            // ItemsListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpItemsList);
            this.Name = "ItemsListUC";
            this.Size = new System.Drawing.Size(550, 280);
            this.Load += new System.EventHandler(this.ItemsListUC_Load);
            this.grpItemsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItemsList;
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValuePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
    }
}
