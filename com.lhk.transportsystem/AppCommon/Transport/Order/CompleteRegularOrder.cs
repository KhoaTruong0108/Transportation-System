using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.TransportOrder
{
    public partial class CompleteRegularOrder : GenericView
    {
        #region Fields & Variables
        private CheckBox _chkOrdersListHeaderSelectAll;
        private RegularOrderBusiness _business;
        private OrderItemBusiness _orderItemBusiness;
        private RevenueBusiness _revenueBusiness;
        private IEnumerable<RegularOrder> _orders;
        private Collection<DataGridViewRow> _checkedRows;
        #endregion

        #region Properties
        private string SelectedOrderID
        {
            get
            {
                return dgvOrdersList.SelectedRows.Count > 0 ? dgvOrdersList.SelectedRows[0].Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }

        private RegularOrder SelectedOrder
        {
            get
            {
                return _orders.FirstOrDefault(o => o.id.Equals(SelectedOrderID));
            }
        }
        #endregion

        #region Constructors
        public CompleteRegularOrder()
        {
            InitializeComponent();

        }

        public CompleteRegularOrder(IEnumerable<RegularOrder> orders)
        {
            InitializeComponent();
            _orders = orders;
            InitializeData();
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            _business = new RegularOrderBusiness(SystemParam.CurrentUser);
            _orderItemBusiness = new OrderItemBusiness();
            _revenueBusiness = new RevenueBusiness(SystemParam.CurrentUser);
            _checkedRows = new Collection<DataGridViewRow>();

            dgvOrdersList.AutoGenerateColumns = false;
            dgvItemsList.AutoGenerateColumns = false;

            chkUseAdjustment.Checked = false;
            tbAdjustmentAmount.Enabled = false;
            tbAdjustmentReason.Enabled = false;

            // Initializes header checkbox
            _chkOrdersListHeaderSelectAll = new CheckBox();
            var orderListFirstColumnHeaderCell = this.dgvOrdersList.Columns[0].HeaderCell;
            _chkOrdersListHeaderSelectAll.BackColor = orderListFirstColumnHeaderCell.Style.BackColor;
            _chkOrdersListHeaderSelectAll.Checked = true;
            _chkOrdersListHeaderSelectAll.Location = new Point(9, 5);
            _chkOrdersListHeaderSelectAll.Size = new Size(16, 16);
            _chkOrdersListHeaderSelectAll.CheckedChanged += new EventHandler(chkOrdersListHeaderSelectAll_CheckedChanged);
            this.dgvOrdersList.Controls.Add(_chkOrdersListHeaderSelectAll);
        }

        private void DataBind()
        {
            dgvOrdersList.DataSource = _orders.ToList();
            chkOrdersListHeaderSelectAll_CheckedChanged(_chkOrdersListHeaderSelectAll, null);
        }

        private void LoadOrderDetails(RegularOrder order)
        {
            try
            {
                lblOrderStatusText.Text = EnumHelper.Parse<Constants.DeliveryStatus>(order.order_status).GetDescription();
                lblPaymentStatusText.Text = EnumHelper.Parse<Constants.PaymentStatus>(order.payment_status).GetDescription();
                tbItemsCount.Text = order.total_quantity.ToString();
                tbOrderCost.Text = CurrencyUtil.ToString(order.total_cost);
                dgvItemsList.DataSource = _orderItemBusiness.GetByOrderId(order.id);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private decimal CalculateBalance()
        {
            decimal balance = 0;
            try
            {
                decimal totalPayment = decimal.Parse(tbTotalPayment.Text);
                decimal realPaidAmount = decimal.Parse(tbRealPaidAmount.Text);
                decimal adjustmentAmount = 0;
                if (chkUseAdjustment.Checked)
                {
                    adjustmentAmount = decimal.Parse(tbAdjustmentAmount.Text);
                }
                balance = realPaidAmount - (totalPayment + adjustmentAmount);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return balance;
        }

        private bool ValidateInput()
        {
            if (_checkedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần quyết toán.", "Không có hóa đơn");
                return false;
            }
            if (chkUseAdjustment.Checked)
            {
                if (CurrencyUtil.ToDecimal(tbAdjustmentAmount.Text) == 0)
                {
                    MessageBox.Show("Tiền điều chỉnh phải khác 0.", "Tiền điều chỉnh không hợp lệ");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(tbAdjustmentReason.Text))
                {
                    MessageBox.Show("Vui lòng ghi rõ lý do sử dụng tiền điều chỉnh.", "Thiếu lý do sử dụng tiền điều chỉnh");
                    return false;
                }
            }
            if (CurrencyUtil.ToDecimal(lblPaymentBalanceText.Text) < 0)
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ. Hãy sử dụng tiền điều chỉnh nếu cần.", "Không thể quyết toán");
                return false;
            }
            return true;
        }
        #endregion

        #region Event Handlers
        private void RegularOrderPaymentView_Load(object sender, EventArgs e)
        {
            try
            {
                DataBind();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void chkOrdersListHeaderSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Checks all rows
                foreach (DataGridViewRow row in dgvOrdersList.Rows)
                {
                    row.Cells[0].Value = ((CheckBox)sender).Checked;
                }
                this.dgvOrdersList.EndEdit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void dgvOrdersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex != -1)
                {
                    // Toggles the check status of checkbox
                    DataGridViewCheckBoxCell currentCell = (DataGridViewCheckBoxCell)dgvOrdersList.CurrentCell;
                    currentCell.Value = (bool)currentCell.EditedFormattedValue;
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void dgvItemsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.Value != null)
                {
                    // Weight column
                    if (e.ColumnIndex == 1)
                    {
                        e.Value = string.Format("{0:N3} kg", e.Value.ToString());
                        e.FormattingApplied = true;
                    }

                    // Value column or Total totalCost column
                    if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
                    {
                        e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                        e.FormattingApplied = true;
                    }
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void dgvOrdersList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal totalPayment = 0;
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex != -1)
                {
                    _checkedRows.Clear();
                    // Loops through every row and calculates the sum of checked rows
                    foreach (DataGridViewRow row in dgvOrdersList.Rows)
                    {
                        if (row.Cells[0].Value != null && (bool)row.Cells[0].Value == true)
                        {
                            decimal cost;
                            if (decimal.TryParse(row.Cells["TotalCostColumn"].Value.ToString(), out cost))
                            {
                                _checkedRows.Add(row);
                                totalPayment += cost;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            tbTotalPayment.Text = CurrencyUtil.ToString(totalPayment);
            lblPaymentBalanceText.Text = CurrencyUtil.ToString(CalculateBalance());
        }

        private void dgvOrdersList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedOrderID))
                {
                    LoadOrderDetails(SelectedOrder);
                    var orderItems = _orderItemBusiness.GetByOrderId(SelectedOrderID);
                    dgvItemsList.DataSource = orderItems;
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void ckbUseAdjustment_CheckedChanged(object sender, EventArgs e)
        {
            tbAdjustmentAmount.Enabled = chkUseAdjustment.Checked;
            tbAdjustmentReason.Enabled = chkUseAdjustment.Checked;
            lblPaymentBalanceText.Text = CurrencyUtil.ToString(CalculateBalance());
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

        private void tbAdjustmentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == '-' && (sender as TextBox).SelectionStart == 0 && !(sender as TextBox).Text.Contains('-')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            int pos = 0;
            decimal value = 0;
            decimal adjustment = 0;
            if (decimal.TryParse(tbRealPaidAmount.Text, out value))
            {
                pos = tbRealPaidAmount.SelectionStart;
                tbRealPaidAmount.Text = value.ToString("N0");
                tbRealPaidAmount.SelectionStart = pos;
            }

            if (chkUseAdjustment.Checked && decimal.TryParse(tbAdjustmentAmount.Text, out adjustment))
            {
                pos = tbAdjustmentAmount.SelectionStart;
                tbAdjustmentAmount.Text = adjustment.ToString("N0");
                tbAdjustmentAmount.SelectionStart = pos;
            }

            lblPaymentBalanceText.Text = CurrencyUtil.ToString(CalculateBalance());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput() &&
                    MessageBox.Show("Quyết toán những hóa đơn đã chọn?", Constants.Messages.CONFIRMATION_CAPTION) == DialogResult.OK)
                {
                    // TO DO: add order info to Revenue
                    var selectedOrders = new Collection<RegularOrder>();
                    decimal totalPayment = 0;

                    Revenue revenue = new Revenue();
                    revenue.id = IDGenerator.RevenueId();
                    revenue.type = Constants.RevenueType.RegularOrder.ToString();
                    revenue.name = Constants.RevenueType.RegularOrder.GetDescription();
                    revenue.description = string.Empty;
                    revenue.created_date = DateTime.Now;
                    revenue.created_by = SystemParam.CurrentUser.id;

                    List<RevenueDetail> revenueDetails = new List<RevenueDetail>();
                    foreach (DataGridViewRow row in _checkedRows)
                    {
                        string id = row.Cells["IDColumn"].Value.ToString();
                        var order = _orders.FirstOrDefault(o => o.id.Equals(id));
                        if (order != null)
                        {
                            order.order_status = Constants.DeliveryStatus.Closed.ToString();
                            selectedOrders.Add(order);

                            RevenueDetail detail = new RevenueDetail();
                            detail.id = IDGenerator.RevenueDetailId();
                            detail.revenue_id = revenue.id;
                            detail.object_id = order.id;
                            detail.title = Constants.RevenueType.RegularOrder.GetDescription();
                            detail.type = Constants.RevenueType.RegularOrder.ToString();
                            detail.amount = order.total_cost;
                            totalPayment += order.total_cost;
                            detail.description = string.Empty;
                            detail.created_date = DateTime.Now;
                            detail.created_by = SystemParam.CurrentUser.id;
                            revenueDetails.Add(detail);
                        }
                    }
                    if (selectedOrders.Count > 0)
                    {
                        string result = _business.Update(selectedOrders);
                        if (string.IsNullOrEmpty(result))
                        {
                            result = _revenueBusiness.Insert(revenue, revenueDetails);
                            if (string.IsNullOrEmpty(result))
                            {
                                MessageBox.Show("Đã quyết toán thành công.");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }
        #endregion
    }
}