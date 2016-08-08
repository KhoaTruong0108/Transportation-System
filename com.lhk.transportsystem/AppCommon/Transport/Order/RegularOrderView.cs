using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Transport.Order;
using AppCommon.Transport.TransportCustomer;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.TransportOrder
{
    public partial class RegularOrderView : GenericView
    {
        #region Fields & Variables
        private bool _isEditing = false;
        private RegularOrder _selectedOrder;
        private Customer _sender;
        private Customer _recipient;

        protected RegularOrderBusiness _business = null;
        protected CustomerBusiness _customerBusiness = null;
        #endregion

        #region Properties
        private string CustomerSearchCriteria
        {
            get
            {
                // Gets search criteria and generates filter query
                Collection<string> criteriaList = new Collection<string>();
                if (!string.IsNullOrWhiteSpace(tbRecipientNameCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.name LIKE '%{0}%')", tbRecipientNameCriteria.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbRecipientPhoneNumberCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.phone LIKE '%{0}%')", tbRecipientPhoneNumberCriteria.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbRecipientMobileNumberCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.mobile LIKE '%{0}%')", tbRecipientMobileNumberCriteria.Text));
                }
                return string.Join(" AND ", criteriaList);
            }
        }

        private string OrderSearchCriteria
        {
            get
            {
                // Gets search criteria and generates filter query
                Collection<string> criteriaList = new Collection<string>();
                if (chkUseCreatedDateRangeCriteria.Checked)
                {
                    criteriaList.Add(string.Format(@"(it.created_date >= DATETIME '{0:yyyy-MM-dd} 00:00:00' AND it.created_date < DATETIME '{1:yyyy-MM-dd} 00:00:00')", dtpCreatedDateFrom.Value, dtpCreatedDateTo.Value.AddDays(1)));
                }
                if (cboDeliveryStatusCriteria.SelectedIndex != 0)
                {
                    criteriaList.Add(string.Format(@"(it.order_status = '{0}')", cboDeliveryStatusCriteria.SelectedValue.ToString()));
                }
                return string.Join(" AND ", criteriaList);
            }
        }

        private string SelectedOrderID
        {
            get
            {
                return this.dgvOrdersList.SelectedRows.Count > 0 ? dgvOrdersList.SelectedRows[0].Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }

        private RegularOrder SelectedOrder
        {
            get
            {
                _selectedOrder = null;
                if (!string.IsNullOrEmpty(SelectedOrderID))
                {
                    _selectedOrder = _business.Get(SelectedOrderID);
                }
                return _selectedOrder;
            }
        }

        private Customer Sender
        {
            get
            {
                return _sender;
            }
            set
            {
                _sender = value;
                if (_sender != null)
                {
                    tbSenderName.Text = _sender.name;
                    tbSenderPhoneNumber.Text = _sender.phone;
                    tbSenderIDCardNo.Text = _sender.id_card_number;
                    tbSenderAddress.Text = _sender.address1;
                }
                else
                {
                    tbSenderName.Text = string.Empty;
                    tbSenderPhoneNumber.Text = string.Empty;
                    tbSenderIDCardNo.Text = string.Empty;
                    tbSenderAddress.Text = string.Empty;
                }
            }
        }

        private Customer Recipient
        {
            get
            {
                return _recipient;
            }
            set
            {
                _recipient = value;
                if (_recipient != null)
                {
                    tbRecipientName.Text = _recipient.name;
                    tbRecipientPhoneNumber.Text = _recipient.phone;
                    tbRecipientIDCardNo.Text = _recipient.id_card_number;
                    tbRecipientAddress.Text = _recipient.address1;
                }
                else
                {
                    tbRecipientName.Text = string.Empty;
                    tbRecipientPhoneNumber.Text = string.Empty;
                    tbRecipientIDCardNo.Text = string.Empty;
                    tbRecipientAddress.Text = string.Empty;
                }
            }
        }

        private Constants.DeliveryStatus CurrentDeliveryStatus
        {
            get
            {
                Constants.DeliveryStatus deliveryStatus = Constants.DeliveryStatus.Waiting;
                if (rbtnDeliveryStatus_Waiting.Checked)
                {
                    deliveryStatus = Constants.DeliveryStatus.Waiting;
                }
                if (rbtnDeliveryStatus_Delivering.Checked)
                {
                    deliveryStatus = Constants.DeliveryStatus.Delivering;
                }
                if (rbtnDeliveryStatus_Arrived.Checked)
                {
                    deliveryStatus = Constants.DeliveryStatus.Arrived;
                }
                if (rbtnDeliveryStatus_Delivered.Checked)
                {
                    deliveryStatus = Constants.DeliveryStatus.Delivered;
                }
                if (rbtnDeliveryStatus_Closed.Checked)
                {
                    deliveryStatus = Constants.DeliveryStatus.Closed;
                }
                return deliveryStatus;
            }
            set
            {
                Constants.DeliveryStatus deliveryStatus = value;
                switch (deliveryStatus)
                {
                    case Constants.DeliveryStatus.Waiting:
                        rbtnDeliveryStatus_Waiting.Checked = true;
                        break;
                    case Constants.DeliveryStatus.Delivering:
                        rbtnDeliveryStatus_Delivering.Checked = true;
                        break;
                    case Constants.DeliveryStatus.Arrived:
                        rbtnDeliveryStatus_Arrived.Checked = true;
                        break;
                    case Constants.DeliveryStatus.Delivered:
                        rbtnDeliveryStatus_Delivered.Checked = true;
                        break;
                    case Constants.DeliveryStatus.Closed:
                        rbtnDeliveryStatus_Closed.Checked = true;
                        break;
                    default: break;
                }
            }
        }
        #endregion

        #region Constructors
        public RegularOrderView()
        {
            InitializeComponent();
            InistializeData();

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenericView_FormClosed);

        }
        #endregion

        #region Private Methods
        private void InistializeData()
        {
            // Initializes object instance
            _business = new RegularOrderBusiness(SystemParam.CurrentUser);
            _customerBusiness = new CustomerBusiness();

            // Disables created date range criteria
            dtpCreatedDateFrom.Enabled = false;
            dtpCreatedDateTo.Enabled = false;

            dgvOrdersList.AutoGenerateColumns = false;

            // Binds data source for delivery status drop-down list
            var deliveryStatusesList = typeof(Constants.DeliveryStatus).ToList<string>();
            deliveryStatusesList.Insert(0, new KeyValuePair<string, string>("--", "Tất cả"));
            this.cboDeliveryStatusCriteria.DisplayMember = "Value";
            this.cboDeliveryStatusCriteria.ValueMember = "Key";
            this.cboDeliveryStatusCriteria.DataSource = deliveryStatusesList;

            // Binds data source for destination drop-down list
            List<KeyValuePair<string, string>> destinations = new List<KeyValuePair<string, string>>();
            foreach (var tour in (new TourBusiness()).GetAll())
            {
                string displayText = string.Format("{0} - {1}", tour.start, tour.destination);
                if (!destinations.Exists(e => e.Key.Equals(tour.destination)))
                {
                    destinations.Add(new KeyValuePair<string, string>(tour.id, displayText));
                }
            }
            cboDestination.ValueMember = "Key";
            cboDestination.DisplayMember = "Value";
            cboDestination.DataSource = destinations;

            // Sets display text for Delivery Status radio buttons
            rbtnDeliveryStatus_Waiting.Text = Constants.DeliveryStatus.Waiting.GetDescription();
            rbtnDeliveryStatus_Delivering.Text = Constants.DeliveryStatus.Delivering.GetDescription();
            rbtnDeliveryStatus_Arrived.Text = Constants.DeliveryStatus.Arrived.GetDescription();
            rbtnDeliveryStatus_Delivered.Text = Constants.DeliveryStatus.Delivered.GetDescription();
            rbtnDeliveryStatus_Closed.Text = Constants.DeliveryStatus.Closed.GetDescription();

            // Disables order details
            ClearOrderDetails();
            ChangeOrderDetailsEditingStatus(false);
        }

        private void DataBind()
        {
            try
            {
                dgvOrdersList.SelectionChanged -= dgvOrdersList_SelectionChanged;
                var searchCriteria = string.Empty;
                var criteriaList = new Collection<string>();
                if (!string.IsNullOrEmpty(OrderSearchCriteria))
                {
                    criteriaList.Add(OrderSearchCriteria);
                }
                if (!string.IsNullOrEmpty(CustomerSearchCriteria))
                {
                    var commaSeparatedCustomerIDs = string.Empty;
                    var customerIDs = new Collection<string>();
                    var customerSearchResults = _customerBusiness.Search(CustomerSearchCriteria).ToList();
                    if (customerSearchResults.Count > 0)
                    {
                        foreach (var customer in customerSearchResults)
                        {
                            customerIDs.Add(string.Format("'{0}'", customer.id));
                        }
                        commaSeparatedCustomerIDs = string.Join(",", customerIDs);
                        criteriaList.Add(string.Format("it.recipient_id IN {{{0}}}", commaSeparatedCustomerIDs));
                    }
                    else
                    {
                        criteriaList.Add("it.recipient_id = ''");
                    }
                }
                searchCriteria = string.Join(" AND ", criteriaList);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = _business.Search(searchCriteria).ToList();
                bindingSource.ResetBindings(false);
                this.dgvOrdersList.AutoGenerateColumns = false;
                this.dgvOrdersList.DataSource = bindingSource;
                this.dgvOrdersList.ClearSelection();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs while binding source to orders list data grid view.", ex);
            }
        }

        private void PopulateOrderDetails(RegularOrder order)
        {
            if (order != null)
            {
                Sender = _customerBusiness.Get(order.sender_id);
                Recipient = _customerBusiness.Get(order.recipient_id);

                if (Sender == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin người gửi.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Recipient == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin người nhận.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cboDestination.SelectedValue = order.tour_id;
                Constants.DeliveryStatus deliveryStatus;
                bool parseResult = Enum.TryParse<Constants.DeliveryStatus>(order.order_status, out deliveryStatus);
                if (parseResult)
                {
                    CurrentDeliveryStatus = deliveryStatus;
                }
                Constants.PaymentStatus paymentStatus;
                parseResult = Enum.TryParse<Constants.PaymentStatus>(order.payment_status, out paymentStatus);
                if (parseResult)
                {
                    lblPaymentStatusText.Text = paymentStatus.GetDescription();
                }
                Collection<OrderItem> items = (new OrderItemBusiness()).GetByOrderId(order.id);
                tbItemsQuantity.Text = items.Sum(item => item.quantity).ToString();
                decimal totalCost = items.Sum(item => item.cost);
                tbTotalCost.Text = totalCost.ToString("N0");
                this.ucItemsList.OrderID = order.id;
                this.ucItemsList.OrderItems = items;
            }
        }

        private void ChangeOrderDetailsEditingStatus(bool isEditing)
        {
            grpSearchCriteria.Enabled = !isEditing;
            grpOrdersList.Enabled = !isEditing;

            btnChangeStatus.Enabled = !(string.IsNullOrEmpty(SelectedOrderID) || isEditing || rbtnDeliveryStatus_Delivered.Checked || rbtnDeliveryStatus_Closed.Checked);
            isEditing &= !rbtnDeliveryStatus_Closed.Checked;
            btnSenderBrowse.Enabled = isEditing;
            btnRecipientBrowse.Enabled = isEditing;

            cboDestination.Enabled = isEditing;
            pnlDeliveryStatus.Enabled = isEditing;
            ucItemsList.Enabled = isEditing && rbtnDeliveryStatus_Waiting.Checked;
        }

        private void ClearOrderDetails()
        {
            tbSenderName.Text = string.Empty;
            tbSenderPhoneNumber.Text = string.Empty;
            tbSenderIDCardNo.Text = string.Empty;
            tbSenderAddress.Text = string.Empty;
            tbRecipientName.Text = string.Empty;
            tbRecipientPhoneNumber.Text = string.Empty;
            tbRecipientIDCardNo.Text = string.Empty;
            tbRecipientAddress.Text = string.Empty;

            cboDestination.SelectedIndex = -1;
            btnChangeStatus.Enabled = false;
            rbtnDeliveryStatus_Waiting.Checked = true;
            lblPaymentStatusText.Text = string.Empty;
            tbItemsQuantity.Text = string.Empty;
            tbTotalCost.Text = string.Empty;

            this.ucItemsList.OrderID = string.Empty;
            this.ucItemsList.OrderItems = new Collection<OrderItem>();
        }

        private bool ValidateInput()
        {
            if (Sender == null || Recipient == null)
            {
                MessageBox.Show("Thông tin người gửi và người nhận không được trống.\n\n(Số điện thoại và CMND không đồng thời bắt buộc nhưng phải có một trong hai)", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ucItemsList.OrderItems.Count == 0)
            {
                MessageBox.Show("Đơn hàng phải có ít nhất một món hàng.", "Không có hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion

        #region Event Handlers
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataBind();
            ClearOrderDetails();
        }

        private void chkUseCreatedDateRangeCriteria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseCreatedDateRangeCriteria.Checked)
            {
                dtpCreatedDateFrom.Enabled = true;
                dtpCreatedDateTo.Enabled = true;
            }
            else
            {
                dtpCreatedDateFrom.Enabled = false;
                dtpCreatedDateTo.Enabled = false;
            }
        }

        private void btnSenderBrowse_Click(object sender, EventArgs e)
        {
            using (SelectCustomerView selectCustomerView = new SelectCustomerView())
            {
                if (selectCustomerView.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Sender = selectCustomerView.ReturnValue;
                    tbSenderName.Text = Sender.name;
                    tbSenderPhoneNumber.Text = Sender.phone;
                    tbSenderIDCardNo.Text = Sender.id_card_number;
                    tbSenderAddress.Text = Sender.address1;
                }
            }
        }

        private void btnRecipientBrowse_Click(object sender, EventArgs e)
        {
            using (SelectCustomerView selectCustomerView = new SelectCustomerView())
            {
                if (selectCustomerView.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Recipient = selectCustomerView.ReturnValue;
                    tbSenderName.Text = Recipient.name;
                    tbSenderPhoneNumber.Text = Recipient.phone;
                    tbSenderIDCardNo.Text = Recipient.id_card_number;
                    tbSenderAddress.Text = Recipient.address1;
                }
            }
        }

        private void dgvOrdersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Created date column
                if (e.ColumnIndex == 1)
                {
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                }

                // Delivery status column
                if (e.ColumnIndex == 2)
                {
                    e.Value = EnumHelper.Parse<Constants.DeliveryStatus>(e.Value.ToString()).GetDescription();
                }

                // Payment status column
                if (e.ColumnIndex == 3)
                {
                    e.Value = EnumHelper.Parse<Constants.PaymentStatus>(e.Value.ToString()).GetDescription();
                }
            }
        }

        private void dgvOrdersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvOrdersList.SelectionChanged += new EventHandler(dgvOrdersList_SelectionChanged);
        }

        private void dgvOrdersList_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Checks if data grid view is focused and form is in editing mode.
            if (dgvOrdersList.Focused && _isEditing)
            {
                DialogResult result = MessageBox.Show("Đơn hàng đang mở. Chọn Yes để lưu đơn hàng và tiếp tục. Chọn No để hủy đơn hàng và tiếp tục. Hoặc chọn Cancel để tiếp tục chỉnh sửa đơn hàng.", "Lưu thay đổi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        HandleSaveTask();
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        HandleCancelTask();
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void dgvOrdersList_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                PopulateOrderDetails(SelectedOrder);
                ChangeOrderDetailsEditingStatus(false);
            }
            else
            {
                ClearOrderDetails();
            }
        }

        private void rbtnDeliveryStatus_Waiting_CheckedChanged(object sender, EventArgs e)
        {
            ucItemsList.Enabled = rbtnDeliveryStatus_Waiting.Checked;
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedOrderID))
            {
                Constants.DeliveryStatus newDeliveryStatus = new Constants.DeliveryStatus();
                Constants.DeliveryStatus oldDeliveryStatus = EnumHelper.Parse<Constants.DeliveryStatus>(_selectedOrder.order_status);
                if (oldDeliveryStatus != Constants.DeliveryStatus.Delivered)
                {
                    switch (oldDeliveryStatus)
                    {
                        case Constants.DeliveryStatus.Waiting:
                            newDeliveryStatus = Constants.DeliveryStatus.Delivering;
                            break;
                        case Constants.DeliveryStatus.Delivering:
                            newDeliveryStatus = Constants.DeliveryStatus.Arrived;
                            break;
                        case Constants.DeliveryStatus.Arrived:
                            newDeliveryStatus = Constants.DeliveryStatus.Delivered;
                            break;
                        default: break;
                    }
                    _selectedOrder.order_status = newDeliveryStatus.ToString();
                    string result = _business.Update(_selectedOrder);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Đơn hàng đã cập nhật thành công.");
                        DataBind();
                    }
                    else
                    {
                        MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ucItemsList_Validating(object sender, CancelEventArgs e)
        {
            int itemsCount = ucItemsList.OrderItems.Sum(item => item.quantity);
            decimal totalCost = ucItemsList.OrderItems.Sum(item => item.cost);
            tbItemsQuantity.Text = itemsCount.ToString();
            tbTotalCost.Text = totalCost.ToString("N0");
        }
        #endregion

        #region Interface Implementation
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
            using (CreateOrderView frmCreateOrderView = InitCreateOrderView())
            {
                if (frmCreateOrderView.ShowDialog(this) == DialogResult.OK)
                {
                    DataBind();
                }
            }
            return false;
        }

        protected virtual CreateOrderView InitCreateOrderView()
        {
            return new CreateOrderView();
        }

        public override void HandleDelete()
        {
            if (SelectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng.");
            }
            else if (MessageBox.Show("Xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string result = _business.Delete(SelectedOrderID);
                if (string.IsNullOrEmpty(result))
                {
                    result = (new OrderItemBusiness()).DeleteByOrderId(SelectedOrderID);
                    if (string.IsNullOrEmpty(result))
                    {
                        DataBind();
                        ClearOrderDetails();
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

        public override bool HandleEdit()
        {
            if (SelectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng.");
            }
            else if (SelectedOrder.order_status.Equals(Constants.DeliveryStatus.Closed.ToString()))
            {
                MessageBox.Show("Đơn hàng đã hoàn thành, không thể thay đổi thông tin.");
            }
            else
            {
                ChangeOrderDetailsEditingStatus(true);
                _isEditing = true;
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
                RegularOrder order = SelectedOrder;
                if (order != null && ValidateInput())
                {
                    // Collects order information
                    Collection<OrderItem> orderItems = new Collection<OrderItem>();
                    order.sender_id = Sender.id;
                    order.recipient_id = Recipient.id;
                    order.tour_id = cboDestination.SelectedValue.ToString();
                    order.order_status = CurrentDeliveryStatus.ToString();
                    int totalQuantity = 0;
                    decimal totalValue = 0;
                    decimal totalCost = 0;
                    foreach (var item in ucItemsList.OrderItems)
                    {
                        OrderItem newOrderItem = new OrderItem()
                        {
                            id = IDGenerator.NewOrderItemId(order.id, orderItems.Count + 1),
                            order_id = order.id,
                            name = item.name,
                            weight = item.weight,
                            size = item.size,
                            quantity = item.quantity,
                            value = item.value,
                            description = item.description,
                            cost = item.cost,
                            order_item_number = item.order_item_number
                        };
                        orderItems.Add(newOrderItem);
                        totalQuantity += item.quantity;
                        totalValue += item.value * item.quantity;
                        totalCost += item.cost;
                    }
                    order.total_quantity = totalQuantity;
                    order.total_value = totalValue;
                    order.total_cost = decimal.Parse(tbTotalCost.Text);
                    if (rbtnDeliveryStatus_Closed.Checked)
                    {
                        order.closed_date = DateTime.Now;
                    }

                    string result = _business.Update(order, orderItems);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Đơn hàng đã cập nhật thành công.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
                        ChangeOrderDetailsEditingStatus(false);
                        _isEditing = false;
                        success = true;
                        DataBind();
                        PopulateOrderDetails(order);
                    }
                    else
                    {
                        MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs when saving order changes.", ex);
                MessageBox.Show("Có lỗi xảy ra trong khi cập nhập đơn hàng.", Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }

        public override void HandleCancelTask()
        {
            ChangeOrderDetailsEditingStatus(false);
            PopulateOrderDetails(SelectedOrder);
            _isEditing = false;
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
