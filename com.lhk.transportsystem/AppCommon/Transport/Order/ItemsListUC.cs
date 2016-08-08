using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

/// <summary>
/// The Order namespace.
/// </summary>
namespace AppCommon.Transport.Order
{
    /// <summary>
    /// Class ItemsListUC.
    /// </summary>
    public partial class ItemsListUC : UserControl
    {
        #region Variables
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        public string OrderID { get; set; }

        /// <summary>
        /// Gets the selected item identifier.
        /// </summary>
        /// <value>The selected item identifier.</value>
        private string SelectedItemID
        {
            get
            {
                return dgvItemsList.SelectedRows.Count > 0 ? dgvItemsList.SelectedRows[0].Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        /// <value>The order items.</value>
        public Collection<OrderItem> OrderItems
        {
            get { return _orderItems; }
            set
            {
                _orderItems = value;
                BindDataSource();
            }
        }
        private Collection<OrderItem> _orderItems = new Collection<OrderItem>();

        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsListUC" /> class.
        /// </summary>
        public ItemsListUC()
        {
            InitializeComponent();
            OrderID = string.Empty;
            this.dgvItemsList.AutoGenerateColumns = false;
            this.OrderItems = new Collection<OrderItem>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsListUC"/> class.
        /// </summary>
        /// <param name="orderItems">The order items.</param>
        public ItemsListUC(string orderId, Collection<OrderItem> orderItems)
        {
            InitializeComponent();
            OrderID = orderId;
            this.dgvItemsList.AutoGenerateColumns = false;
            this.OrderItems = orderItems;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Binds the data source.
        /// </summary>
        private void BindDataSource()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = OrderItems;
            dgvItemsList.DataSource = bindingSource;
            bindingSource.ResetBindings(false);
            //dgvItemsList.Refresh();
        }
        #endregion

        #region Event Handlers
        private void ItemsListUC_Load(object sender, EventArgs e)
        {
            dgvItemsList.ClearSelection();
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (ItemDetailsView frmItemDetailsView = new ItemDetailsView(this))
            {
                DialogResult result = frmItemDetailsView.ShowDialog();
                if (result == DialogResult.OK)
                {
                    BindDataSource();
                    this.ParentForm.ValidateChildren();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = OrderItems.Where(o => o.id.Equals(this.SelectedItemID)).FirstOrDefault();
            if (orderItem != null)
            {
                using (ItemDetailsView frmItemDetailsView = new ItemDetailsView(this, orderItem))
                {
                    DialogResult result = frmItemDetailsView.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        BindDataSource();
                        this.ParentForm.ValidateChildren();
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Constants.Messages.ITEM_DELETE_CONFIRMATION_MESSAGE, Constants.Messages.ITEM_DELETE_CONFIRMATION_CAPTION, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var itemToDelete = OrderItems.First(item => item.id.Equals(SelectedItemID));
                OrderItems.Remove(itemToDelete);
                BindDataSource();
                this.ParentForm.ValidateChildren();
            }
        }

        private void dgvItemsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Weight column
                if (e.ColumnIndex == 2)
                {
                    e.Value = string.Format("{0:N3} kg", e.Value.ToString());
                    e.FormattingApplied = true;
                }

                // Value column or Total totalCost column
                if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvItemsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItemsList.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
            }
        }
        #endregion
    }
}
