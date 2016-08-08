using System.Collections.ObjectModel;
using System.Windows.Forms;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.TransportOrder
{
    public partial class IrregularOrderPaymentView : Form
    {
        #region Constructors
        public IrregularOrderPaymentView()
        {
            InitializeComponent();
            lblOrderIDText.Text = string.Empty;
            lblOrderStatusText.Text = string.Empty;
            grpOrderDetails.Enabled = false;
            grpItemsList.Enabled = false;
            grpPayment.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        public IrregularOrderPaymentView(IrregularOrder order, Collection<OrderItem> items)
        {
            InitializeComponent();
            //Loads order info
            LoadOrderInfo(order, items);
        }
        #endregion

        #region Private Methods
        private void LoadOrderInfo(IrregularOrder order, Collection<OrderItem> items)
        {
            lblOrderIDText.Text = order.id;
            lblOrderStatusText.Text = EnumHelper.Parse<Constants.DeliveryStatus>(order.order_status).GetDescription();
            tbTotalItemsQuantity.Text = order.total_quantity.ToString();
            tbTotalCost.Text = CurrencyUtil.ToString(order.total_cost);
            dgvItemsList.AutoGenerateColumns = false;
            dgvItemsList.DataSource = items;
            tbTotalPayment.Text = CurrencyUtil.ToString(order.total_cost);
        }

        private decimal CalculateBalance(decimal totalPayment, decimal paidAmount)
        {
            return paidAmount - totalPayment;
        }

        private bool ValidateInput()
        {
            bool valid = true;
            if (CurrencyUtil.ToDecimal(tbPaymentBalance.Text) < 0)
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ.", "Không thể quyết toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }
            return valid;
        }
        #endregion

        #region Event Handlers
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (ValidateInput() &&
                MessageBox.Show("Chấp nhận thanh toán hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //TO DO: Add business to print the order receipt.

                // The order's status will be updated after this dialog closed with DialogResult as OK
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void dgvItemsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Weight column
                if (e.ColumnIndex == 1)
                {
                    e.Value = string.Format("{0:N3} kg", e.Value.ToString());
                    e.FormattingApplied = true;
                }

                // Value column or Total cost column
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void tbRealAmount_TextChanged(object sender, System.EventArgs e)
        {
            int pos = 0;
            decimal value;
            if (decimal.TryParse(tbRealPaidAmount.Text, out value))
            {
                pos = tbRealPaidAmount.SelectionStart;
                tbRealPaidAmount.Text = value.ToString("N0");
                tbRealPaidAmount.SelectionStart = pos;

                tbPaymentBalance.Text = CalculateBalance(decimal.Parse(tbTotalPayment.Text), value).ToString("N0");
            }
            else
            {
                tbPaymentBalance.Text = string.Empty;
            }
        }

        private void tbRealAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
