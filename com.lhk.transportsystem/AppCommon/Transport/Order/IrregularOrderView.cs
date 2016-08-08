using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Transport.Order;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.TransportOrder
{
    public partial class IrregularOrderView : GenericView, IView
    {
        #region Fields & Variables
        private bool _isEditing = false;
        private IrregularOrder _selectedOrder;

        protected IrregularOrderBusiness _business = null;
        #endregion

        #region Properties
        private string SearchCriteria
        {
            get
            {
                // Gets search criteria and generates filter query
                Collection<string> criteriaList = new Collection<string>();
                if (!string.IsNullOrWhiteSpace(tbRecipientNameCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.recipient_name LIKE '%{0}%')", tbRecipientNameCriteria.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbRecipientIDCardNoCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.recipient_id_card_no LIKE '%{0}%')", tbRecipientIDCardNoCriteria.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbRecipientPhoneCriteria.Text))
                {
                    criteriaList.Add(string.Format(@"(it.recipient_phone LIKE '%{0}%')", tbRecipientPhoneCriteria.Text));
                }
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

        private IrregularOrder SelectedOrder
        {
            get
            {
                if (!string.IsNullOrEmpty(SelectedOrderID))
                {
                    _selectedOrder = _business.Get(SelectedOrderID);
                }
                else
                {
                    _selectedOrder = null;
                }
                return _selectedOrder;
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

        private Constants.PaymentStatus CurrentPaymentStatus
        {
            get
            {
                Constants.PaymentStatus paymentStatus = Constants.PaymentStatus.Unpaid;
                if (rbtnPaymentStatus_Unpaid.Checked)
                {
                    paymentStatus = Constants.PaymentStatus.Unpaid;
                }
                if (rbtnPaymentStatus_Paid.Checked)
                {
                    paymentStatus = Constants.PaymentStatus.Paid;
                }
                return paymentStatus;
            }
            set
            {
                Constants.PaymentStatus paymentStatus = value;
                switch (paymentStatus)
                {
                    case Constants.PaymentStatus.Unpaid:
                        rbtnPaymentStatus_Unpaid.Checked = true;
                        break;
                    case Constants.PaymentStatus.Paid:
                        rbtnPaymentStatus_Paid.Checked = true;
                        break;
                    default: break;
                }
            }
        }
        #endregion

        #region Constructors
        public IrregularOrderView()
        {
            InitializeComponent();
            InitializeData();

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenericView_FormClosed);
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            // Initializes object instance
            _business = new IrregularOrderBusiness(SystemParam.CurrentUser);

            // Disables created date range criteria
            dtpCreatedDateFrom.Enabled = false;
            dtpCreatedDateTo.Enabled = false;

            // Binds data source for delivery status drop-down list
            var deliveryStatusesList = typeof(Constants.DeliveryStatus).ToList<string>();
            deliveryStatusesList.Insert(0, new KeyValuePair<string, string>("--", "Tất cả"));
            this.cboDeliveryStatusCriteria.DisplayMember = "Value";
            this.cboDeliveryStatusCriteria.ValueMember = "Key";
            this.cboDeliveryStatusCriteria.DataSource = deliveryStatusesList;

            // Binds data source for tour drop-down list
            List<KeyValuePair<string, string>> toursList = new List<KeyValuePair<string, string>>();
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

            // Sets display text for Delivery Status radio buttons
            rbtnDeliveryStatus_Waiting.Text = Constants.DeliveryStatus.Waiting.GetDescription();
            rbtnDeliveryStatus_Delivering.Text = Constants.DeliveryStatus.Delivering.GetDescription();
            rbtnDeliveryStatus_Arrived.Text = Constants.DeliveryStatus.Arrived.GetDescription();
            rbtnDeliveryStatus_Delivered.Text = Constants.DeliveryStatus.Delivered.GetDescription();
            rbtnDeliveryStatus_Closed.Text = Constants.DeliveryStatus.Closed.GetDescription();

            // Sets display text for Payment Status radio buttons
            rbtnPaymentStatus_Unpaid.Text = Constants.PaymentStatus.Unpaid.GetDescription();
            rbtnPaymentStatus_Paid.Text = Constants.PaymentStatus.Paid.GetDescription();

            // Disables order details
            ClearOrderDetails();
            ChangeOrderDetailsEditingStatus(false);
        }

        private void DataBind()
        {
            try
            {
                dgvOrdersList.SelectionChanged -= dgvOrdersList_SelectionChanged;
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = _business.Search(SearchCriteria).ToList();
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

        private void PopulateOrderDetails(IrregularOrder order)
        {
            if (order != null)
            {
                tbSenderName.Text = order.sender_name;
                tbSenderPhoneNumber.Text = order.sender_phone;
                tbSenderIDCardNo.Text = order.sender_id_card_no;
                tbSenderAddress.Text = order.sender_address;
                tbRecipientName.Text = order.recipient_name;
                tbRecipientPhoneNumber.Text = order.recipient_phone;
                tbRecipientIDCardNo.Text = order.recipient_id_card_no;
                tbRecipientAddress.Text = order.recipient_address;

                lblOrderIdText.Text = order.id;
                lblCreatedDateText.Text = order.created_date.ToString("dd-MM-yyyy hh:mm:ss");
                lblCreatedByText.Text = order.created_by;
                lblClosedDateText.Text = order.closed_date.HasValue ? order.closed_date.Value.ToString("dd-MM-yyyy hh:mm:ss") : string.Empty;
                cboTour.SelectedValue = order.tour_id;
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
                    CurrentPaymentStatus = paymentStatus;
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
            grpOrdersList.Enabled = !isEditing;

            btnChangeStatus.Enabled = !(string.IsNullOrEmpty(SelectedOrderID) || isEditing || rbtnDeliveryStatus_Delivered.Checked || rbtnDeliveryStatus_Closed.Checked);
            isEditing &= !rbtnDeliveryStatus_Closed.Checked;
            tbSenderName.Enabled = isEditing;
            tbSenderPhoneNumber.Enabled = isEditing;
            tbSenderIDCardNo.Enabled = isEditing;
            tbSenderAddress.Enabled = isEditing;
            tbRecipientName.Enabled = isEditing;
            tbRecipientPhoneNumber.Enabled = isEditing;
            tbRecipientIDCardNo.Enabled = isEditing;
            tbRecipientAddress.Enabled = isEditing;

            cboTour.Enabled = isEditing;
            pnlDeliveryStatus.Enabled = isEditing;
            pnlPaymentStatus.Enabled = isEditing && rbtnPaymentStatus_Unpaid.Checked;
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

            lblOrderIdText.Text = string.Empty;
            lblCreatedDateText.Text = string.Empty;
            lblCreatedByText.Text = string.Empty;
            lblClosedDateText.Text = string.Empty;
            cboTour.SelectedIndex = -1;
            rbtnDeliveryStatus_Waiting.Checked = true;
            rbtnPaymentStatus_Unpaid.Checked = true;
            btnChangeStatus.Enabled = false;
            tbItemsQuantity.Text = string.Empty;
            tbTotalCost.Text = string.Empty;

            this.ucItemsList.OrderID = string.Empty;
            this.ucItemsList.OrderItems = new Collection<OrderItem>();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbSenderName.Text) ||
                (string.IsNullOrWhiteSpace(tbSenderIDCardNo.Text) && string.IsNullOrWhiteSpace(tbSenderPhoneNumber.Text)) ||
                string.IsNullOrWhiteSpace(tbRecipientName.Text) ||
                (string.IsNullOrWhiteSpace(tbRecipientIDCardNo.Text) && string.IsNullOrWhiteSpace(tbRecipientPhoneNumber.Text)))
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

        private void dgvOrdersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Delivery status column
            if (e.ColumnIndex == 2)
            {
                e.Value = EnumHelper.GetDescription((Constants.DeliveryStatus)(System.Enum.Parse(typeof(Constants.DeliveryStatus), e.Value.ToString())));
            }

            // Payment status column
            if (e.ColumnIndex == 3)
            {
                e.Value = EnumHelper.GetDescription((Constants.PaymentStatus)(System.Enum.Parse(typeof(Constants.PaymentStatus), e.Value.ToString())));
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
                            if (_selectedOrder.payment_status.Equals(Constants.PaymentStatus.Unpaid.ToString()))
                            {
                                if ((new IrregularOrderPaymentView(_selectedOrder, ucItemsList.OrderItems)).ShowDialog() == DialogResult.OK)
                                {
                                    _selectedOrder.payment_status = Constants.PaymentStatus.Paid.ToString();
                                }
                                else
                                {
                                    return;
                                }
                            }
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

        private void ucItemsList_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
            else if(SelectedOrder.order_status.Equals(Constants.DeliveryStatus.Closed.ToString()))
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
                IrregularOrder order = SelectedOrder;
                if (order != null && ValidateInput())
                {
                    Constants.PaymentStatus currentPaymentStatus = EnumHelper.Parse<Constants.PaymentStatus>(order.payment_status);
                    // Collects order information
                    Collection<OrderItem> orderItems = new Collection<OrderItem>();
                    order.sender_name = tbSenderName.Text;
                    order.sender_phone = tbSenderPhoneNumber.Text;
                    order.sender_id_card_no = tbSenderIDCardNo.Text;
                    order.sender_address = tbSenderAddress.Text;
                    order.recipient_name = tbRecipientName.Text;
                    order.recipient_phone = tbRecipientPhoneNumber.Text;
                    order.recipient_id_card_no = tbRecipientIDCardNo.Text;
                    order.recipient_address = tbRecipientAddress.Text;
                    order.tour_id = cboTour.SelectedValue.ToString();
                    order.order_status = CurrentDeliveryStatus.ToString();
                    order.payment_status = CurrentPaymentStatus.ToString();
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

                    if (currentPaymentStatus == Constants.PaymentStatus.Unpaid &&
                        rbtnPaymentStatus_Paid.Checked &&
                        (new IrregularOrderPaymentView(order, orderItems)).ShowDialog() != DialogResult.OK)
                    {
                        return false;
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
