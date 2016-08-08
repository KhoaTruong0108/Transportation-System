using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.TransportOrder
{
    public partial class CompleteIrregularOrder : Form
    {
        #region Fields & Variables
        private CheckBox _chkOrdersListHeaderSelectAll;
        private IrregularOrderBusiness _business;
        private RevenueBusiness _revenueBusiness;
        private Collection<IrregularOrder> _orders;
        private Collection<DataGridViewRow> _checkedRows;
        #endregion

        #region Properties
        private string SearchCriteria
        {
            get
            {
                // Gets search criteria and generates filter query
                Collection<string> criteriaList = new Collection<string>();
                criteriaList.Add(string.Format("it.order_status = '{0}'", Constants.DeliveryStatus.Delivered.ToString()));
                criteriaList.Add(string.Format("it.payment_status = '{0}'", Constants.PaymentStatus.Paid.ToString()));

                if (!string.IsNullOrWhiteSpace(tbOrderIDCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.id LIKE '%{0}%')", tbOrderIDCriteria.Text));
                }
                if (cboTour.SelectedIndex != 0)
                {
                    criteriaList.Add(string.Format(@"(it.destination = '{0}')", cboTour.SelectedValue.ToString()));
                }
                return string.Join(" AND ", criteriaList);
            }
        }
        #endregion

        #region Constructors
        public CompleteIrregularOrder()
        {
            InitializeComponent();
            InitializeData();
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            try
            {
                AppLogger.logInfo(this.ToString(), "Begin initializing data.");
                _business = new IrregularOrderBusiness(SystemParam.CurrentUser);
                _revenueBusiness = new RevenueBusiness(SystemParam.CurrentUser);
                _checkedRows = new Collection<DataGridViewRow>();

                // Binds data source for tour drop-down list
                List<KeyValuePair<string, string>> toursList = new List<KeyValuePair<string, string>>();
                toursList.Add(new KeyValuePair<string, string>("--", "Tất cả"));
                foreach (var tour in (new TourBusiness()).GetAll())
                {
                    string displayText = string.Format("{0} - {1}", tour.start, tour.destination);
                    if (!toursList.Exists(e => e.Key.Equals(tour.destination)))
                    {
                        toursList.Add(new KeyValuePair<string, string>(tour.id, displayText));
                    }
                }
                cboTour.ValueMember = "Key";
                cboTour.DisplayMember = "Value";
                cboTour.DataSource = toursList;

                // Initializes checkbox header
                _chkOrdersListHeaderSelectAll = new CheckBox();
                var orderListFirstColumnHeaderCell = this.dgvOrdersList.Columns[0].HeaderCell;
                _chkOrdersListHeaderSelectAll.BackColor = orderListFirstColumnHeaderCell.Style.BackColor;
                _chkOrdersListHeaderSelectAll.Checked = true;
                //chkOrdersListHeaderSelectAll.Location = new Point((orderListFirstColumnHeaderCell.Size.Width - chkOrdersListHeaderSelectAll.Size.Width), (orderListFirstColumnHeaderCell.Size.Height - chkOrdersListHeaderSelectAll.Size.Height));
                _chkOrdersListHeaderSelectAll.Location = new Point(9, 5);
                _chkOrdersListHeaderSelectAll.Size = new Size(16, 16);//new Size(orderListFirstColumnHeaderCell.Size.Width, orderListFirstColumnHeaderCell.Size.Height);
                _chkOrdersListHeaderSelectAll.CheckedChanged += new EventHandler(chkOrdersListHeaderSelectAll_CheckedChanged);
                this.dgvOrdersList.Controls.Add(_chkOrdersListHeaderSelectAll);
                AppLogger.logInfo(this.ToString(), "Finish initializing data.");
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void DataBind()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                _orders = new Collection<IrregularOrder>(_business.Search(SearchCriteria).ToList());
                bindingSource.DataSource = _orders;
                bindingSource.ResetBindings(false);
                this.dgvOrdersList.AutoGenerateColumns = false;
                this.dgvOrdersList.DataSource = bindingSource;
                this.dgvOrdersList.ClearSelection();
                chkOrdersListHeaderSelectAll_CheckedChanged(_chkOrdersListHeaderSelectAll, null);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs while binding source to orders list data grid view.", ex);
            }
        }

        private bool ValidateInput()
        {
            if (_checkedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần quyết toán.", "Không có hóa đơn");
                return false;
            }
            return true;
        }
        #endregion

        #region Event Handlers
        private void btnSearch_Click(object sender, EventArgs e)
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

        private void dgvOrdersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // CreatedDateColumn
            if (e.ColumnIndex == 2)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }

            // DeliveryStatusColumn
            if (e.ColumnIndex == 4)
            {
                e.Value = EnumHelper.GetDescription((Constants.DeliveryStatus)(System.Enum.Parse(typeof(Constants.DeliveryStatus), e.Value.ToString())));
            }

            // TotalCostColumn
            if (e.ColumnIndex == 5)
            {
                e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                e.FormattingApplied = true;
            }
        }

        private void dgvOrdersList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int count = 0;
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
                            count++;
                            decimal cost;
                            if (decimal.TryParse(row.Cells["TotalCostColumn"].Value.ToString(), out cost))
                            {
                                _checkedRows.Add(row);
                                totalPayment += cost;
                            }
                        }
                    }
                    //_chkOrdersListHeaderSelectAll.Checked = _orders.Count.Equals(count);
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            tbOrdersCount.Text = count.ToString();
            tbTotalPayment.Text = CurrencyUtil.ToStringWithCurrencySign(totalPayment);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput() &&
                    MessageBox.Show("Quyết toán những hóa đơn đã chọn?", Constants.Messages.CONFIRMATION_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    // TO DO: add order info to Revenue
                    var selectedOrders = new Collection<IrregularOrder>();
                    decimal totalPayment = 0;

                    Revenue revenue = new Revenue();
                    revenue.id = IDGenerator.RevenueId();
                    revenue.type = Constants.RevenueType.IrregularOrder.ToString();
                    revenue.name = Constants.RevenueType.IrregularOrder.GetDescription();
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
                            detail.title = Constants.RevenueType.IrregularOrder.GetDescription();
                            detail.type = Constants.RevenueType.IrregularOrder.ToString();
                            detail.amount = order.total_cost;
                            totalPayment += order.total_cost;
                            detail.description = string.Empty;
                            detail.created_date = DateTime.Now;
                            detail.created_by = SystemParam.CurrentUser.id;
                            revenueDetails.Add(detail);
                        }
                    }
                    revenue.amount = totalPayment;
                    if (selectedOrders.Count > 0)
                    {
                        string result = _business.Update(selectedOrders);
                        if (string.IsNullOrEmpty(result))
                        {
                            result = _revenueBusiness.Insert(revenue, revenueDetails);
                            if (string.IsNullOrEmpty(result))
                            {
                                MessageBox.Show("Quyết toán đơn hàng thành công.");
                                DataBind();
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