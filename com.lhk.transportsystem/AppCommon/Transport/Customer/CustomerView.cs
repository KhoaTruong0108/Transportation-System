using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Transport.TransportOrder;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.TransportCustomer
{
    public partial class CustomerView : GenericView
    {
        #region Fields & Variables
        private CustomerBusiness _business;
        private RegularOrderBusiness _regularOrderBusiness;
        private List<Customer> _customers;
        private bool _isEditing;
        private bool _isUpdating;
        #endregion

        #region Properties
        private string SearchCriteria
        {
            get
            {
                // Gets search criteria and generates filter query
                Collection<string> criteriaList = new Collection<string>();
                if (!string.IsNullOrWhiteSpace(tbNameCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.name LIKE '%{0}%')", tbNameCriteria.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbCompanyCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.company LIKE '%{0}%')", tbCompanyCriteria.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbPhoneCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.phone LIKE '%{0}%')", tbPhoneCriteria.Text));
                }
                return string.Join(" AND ", criteriaList);
            }
        }

        private string SelectedCustomerID
        {
            get
            {
                return dgvCustomersList.SelectedRows.Count > 0 ? dgvCustomersList.SelectedRows[0].Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }

        private Collection<RegularOrder> _openOrders;
        private Collection<RegularOrder> OpenOrders
        {
            get { return _openOrders; }
            set
            {
                _openOrders = value;
                dgvOpenOrders.DataSource = _openOrders;
                dgvOpenOrders.ClearSelection();
            }
        }

        private Collection<RegularOrder> _closedOrders;
        private Collection<RegularOrder> ClosedOrders
        {
            get { return _closedOrders; }
            set
            {
                _closedOrders = value;
                dgvClosedOrders.DataSource = _closedOrders;
                dgvClosedOrders.ClearSelection();
            }
        }
        #endregion

        #region Constructors
        public CustomerView()
        {
            InitializeComponent();
            InitializeData();

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenericView_FormClosed);
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            _business = new CustomerBusiness(SystemParam.CurrentUser);
            _regularOrderBusiness = new RegularOrderBusiness(SystemParam.CurrentUser);

            dgvCustomersList.AutoGenerateColumns = false;
            dgvOpenOrders.AutoGenerateColumns = false;
            dgvClosedOrders.AutoGenerateColumns = false;

            ChangeControlStatus(false);
            btnCloseOrders.Enabled = false;
        }

        private void DataBind()
        {
            try
            {
                dgvCustomersList.SelectionChanged -= dgvCustomersList_SelectionChanged;
                BindingSource bindingSource = new BindingSource();
                _customers = new List<Customer>(_business.Search(SearchCriteria));
                bindingSource.DataSource = _customers;
                bindingSource.ResetBindings(false);
                this.dgvCustomersList.DataSource = bindingSource;
                this.dgvCustomersList.ClearSelection();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void PopulateCustomerInfo(Customer customer)
        {
            if (customer != null)
            {
                tbCompany.Text = customer.company;
                tbPhone.Text = customer.phone;
                tbAddress1.Text = customer.address1;
                tbAddress2.Text = customer.address2;
                tbName.Text = customer.name;
                tbMobile.Text = customer.mobile;
                tbIDCardNumber.Text = customer.id_card_number;

                btnCloseOrders.Enabled = true;
            }
            else
            {
                tbCompany.Text = string.Empty;
                tbPhone.Text = string.Empty;
                tbAddress1.Text = string.Empty;
                tbAddress2.Text = string.Empty;
                tbName.Text = string.Empty;
                tbMobile.Text = string.Empty;
                tbIDCardNumber.Text = string.Empty;

                btnCloseOrders.Enabled = false;
            }
        }

        private void ClearCustomerInfo()
        {
            PopulateCustomerInfo(null);
        }

        private void ChangeControlStatus(bool isEditing)
        {
            grpSearch.Enabled = !isEditing;
            grpCustomersList.Enabled = !isEditing;

            grpCustomerInfo.Enabled = isEditing;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbCompany.Text) || string.IsNullOrWhiteSpace(tbPhone.Text) ||
                (string.IsNullOrWhiteSpace(tbAddress1.Text) && string.IsNullOrWhiteSpace(tbAddress2.Text)) ||
                string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbMobile.Text) ||
                string.IsNullOrWhiteSpace(tbIDCardNumber.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion

        #region Event Handlers
        private void btnCloseOrders_Click(object sender, EventArgs e)
        {
            var filterredOrders = _openOrders.Where(o => o.order_status.Equals(Constants.DeliveryStatus.Delivered.ToString()));
            using (CompleteRegularOrder regularOrderPaymentView = new CompleteRegularOrder(filterredOrders))
            {
                regularOrderPaymentView.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dgvCustomersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCustomersList.SelectionChanged += new EventHandler(dgvCustomersList_SelectionChanged);
        }

        private void dgvCustomersList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedCustomerID))
                {
                    var customer = _business.Get(SelectedCustomerID);
                    PopulateCustomerInfo(customer);
                    string query = string.Format("it.recipient_id = '{0}'", SelectedCustomerID);
                    List<RegularOrder> orders = _regularOrderBusiness.Search(query).ToList();
                    Collection<RegularOrder> openOrders = new Collection<RegularOrder>();
                    Collection<RegularOrder> closedOrders = new Collection<RegularOrder>();
                    foreach (RegularOrder order in orders)
                    {
                        if (order.order_status.Equals(Constants.DeliveryStatus.Closed.ToString()))
                        {
                            closedOrders.Add(order);
                        }
                        else
                        {
                            openOrders.Add(order);
                        }
                    }
                    tbOrdersCount.Text = openOrders.Count.ToString();
                    tbTotalPayment.Text = CurrencyUtil.ToString(openOrders.Sum(o => o.total_cost));
                    btnCloseOrders.Enabled = openOrders.Count > 0;
                    OpenOrders = openOrders;
                    ClosedOrders = closedOrders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra.", Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppLogger.logError(this.ToString(), ex);
            }
        }

        private void dgvOpenOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // TotalCostColumn
                if (e.ColumnIndex == 2)
                {
                    e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                    e.FormattingApplied = true;
                }

                // DeliveryStatusColumn
                if (e.ColumnIndex == 4)
                {
                    e.Value = EnumHelper.Parse<Constants.DeliveryStatus>(e.Value.ToString()).GetDescription();
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvClosedOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Value column or Total totalCost column
                if (e.ColumnIndex == 2)
                {
                    e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion

        #region Interface Inplementation
        public bool isFocus()
        {
            throw new NotImplementedException();
        }

        public void HandleBarcodeHit(string barcode)
        {
            throw new NotImplementedException();
        }

        public override bool HandleCreateNew()
        {
            _isUpdating = false;
            _isEditing = true;
            ChangeControlStatus(_isEditing);
            ClearCustomerInfo();
            return _isEditing;
        }

        public override void HandleDelete()
        {
            if (string.IsNullOrEmpty(SelectedCustomerID))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
            }
            else if (MessageBox.Show("Xóa thông tin khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string result = _business.Delete(SelectedCustomerID);
                if (string.IsNullOrEmpty(result))
                {
                    DataBind();
                }
                else
                {
                    MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override bool HandleEdit()
        {
            if (string.IsNullOrEmpty(SelectedCustomerID))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
            }
            else
            {
                _isUpdating = true;
                _isEditing = true;
                ChangeControlStatus(_isEditing);
            }
            return _isEditing;
        }

        public void HandlePrint()
        {
            throw new NotImplementedException();
        }

        public override bool HandleSaveTask()
        {
            bool success = false;
            try
            {
                Customer customer = _isUpdating ? _customers.FirstOrDefault(c => c.id.Equals(SelectedCustomerID)) : new Customer();
                if (customer != null && ValidateInput())
                {
                    if (string.IsNullOrEmpty(customer.id))
                    {
                        customer.id = IDGenerator.NewId<Customer>(true);
                    }
                    // Collects customer information
                    customer.company = tbCompany.Text;
                    customer.phone = tbPhone.Text;
                    customer.address1 = tbAddress1.Text;
                    customer.address2 = tbAddress2.Text;
                    customer.name = tbName.Text;
                    customer.mobile = tbMobile.Text;
                    customer.id_card_number = tbIDCardNumber.Text;
                    customer.created_by = SystemParam.CurrentUser.id;
                    customer.created_date = DateTime.Now;

                    string result = _isUpdating ? _business.Update(customer) : _business.Insert(customer);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thông tin khách hàng đã được lưu thành công.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
                        _isEditing = false;
                        ChangeControlStatus(_isEditing);
                        success = true;
                        DataBind();
                        //PopulateCustomerInfo(customer);
                    }
                    else
                    {
                        MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                MessageBox.Show("Có lỗi xảy ra trong khi lưu thông tin khách hàng.", Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }

        public override void HandleCancelTask()
        {
            _isEditing = false;
            ChangeControlStatus(_isEditing);
            if (_isUpdating)
            {
                var customer = _customers.FirstOrDefault(c => c.id.Equals(SelectedCustomerID));
                PopulateCustomerInfo(customer);
            }
        }

        public void HandleSearch()
        {
            throw new NotImplementedException();
        }

        public void HandleExport()
        {
            throw new NotImplementedException();
        }

        public void HandleHelp()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
