using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.Constant;
using AppCommon.Entity;
using AppCommon.Transport.TransportCustomer;
using AppCommon.Transport.TransportOrder;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.Order
{
    public partial class CreateOrderView : Form
    {
        #region Fields & Variables
        private Customer _sender;
        private Customer _recipient;

        protected RegularOrderBusiness _regularBusiness;
        protected IrregularOrderBusiness _irregularBusiness;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the sender identifier.
        /// </summary>
        /// <quantity>The sender identifier.</quantity>
        public Customer Sender
        {
            get
            {
                return _sender;
            }
            set
            {
                _sender = value;
                if (value != null)
                {
                    tbSenderName.Text = _sender.name;
                    tbSenderPhoneNumber.Text = _sender.mobile;
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

        /// <summary>
        /// Gets or sets the recipient identifier.
        /// </summary>
        /// <quantity>The recipient identifier.</quantity>
        public Customer Recipient
        {
            get
            {
                return _recipient;
            }
            set
            {
                _recipient = value;
                if (value != null)
                {
                    tbRecipientName.Text = _recipient.name;
                    tbRecipientPhoneNumber.Text = _recipient.mobile;
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
        #endregion

        #region Constructors
        public CreateOrderView()
        {
            InitializeComponent();
            InitializeData();

            _regularBusiness = new RegularOrderBusiness(SystemParam.CurrentUser);
            _irregularBusiness = new IrregularOrderBusiness(SystemParam.CurrentUser);
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            // Binds data source for destination drop-down list
            List<KeyValuePair<string, string>> destinations = new List<KeyValuePair<string,string>>();
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

            // Sets controls' status
            ChangeControlStatusByOrderType(rbtnOrderType_Regular.Checked);
        }

        private void ChangeControlStatusByOrderType(bool isRegular)
        {
            // Clear Sender & Recipient info
            Sender = null;
            Recipient = null;

            // Disable Payment Status
            rbtnPaymentStatus_Unpaid.Checked = true;
            rbtnPaymentStatus_Unpaid.Enabled = !isRegular;
            rbtnPaymentStatus_Paid.Enabled = !isRegular;

            // Disable sender & recipient info
            tbSenderName.Enabled = !isRegular;
            tbSenderPhoneNumber.Enabled = !isRegular;
            tbSenderIDCardNo.Enabled = !isRegular;
            tbSenderAddress.Enabled = !isRegular;
            tbRecipientName.Enabled = !isRegular;
            tbRecipientPhoneNumber.Enabled = !isRegular;
            tbRecipientIDCardNo.Enabled = !isRegular;
            tbRecipientAddress.Enabled = !isRegular;

            // Enable browse buttons
            btnSenderBrowse.Enabled = isRegular;
            btnRecipientBrowse.Enabled = isRegular;
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
        private void CreateOrderView_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                rbtnOrderType_Irregular.Checked = this.Owner.ActiveMdiChild is IrregularOrderView;
            }
        }

        private void OnOrderTypeChanged(object sender, EventArgs e)
        {
            ChangeControlStatusByOrderType(this.rbtnOrderType_Regular.Checked);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (ValidateInput() &&
                MessageBox.Show(Constants.Messages.CREATE_ORDER_CONFIRMATION_MESSAGE, Constants.Messages.CREATE_ORDER_CONFIRMATION_CAPTION, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool success = true;
                string saveResult = string.Empty;
                try
                {
                    // Creates OrderBase instance and gets general info
                    OrderBase order = new OrderBase();
                    order.id = rbtnOrderType_Regular.Checked ? IDGenerator.NewId<RegularOrder>() : IDGenerator.NewId<IrregularOrder>();
                    AppLogger.logDebug(this.ToString(), string.Format("Id: {0}", order.id));
                    order.payment_status = this.rbtnPaymentStatus_Paid.Checked ? Constants.PaymentStatus.Paid.ToString() : Constants.PaymentStatus.Unpaid.ToString();
                    order.order_status = Constants.DeliveryStatus.Waiting.ToString();
                    order.tour_id = cboDestination.SelectedValue.ToString();
                    order.created_date = DateTime.Now;
                    order.created_by = SystemParam.CurrentUser.user_name;
                    int totalQuantity = 0;
                    decimal totalValue = 0;
                    decimal totalCost = 0;
                    foreach (var item in ucItemsList.OrderItems)
                    {
                        item.id = IDGenerator.NewOrderItemId(order.id, ucItemsList.OrderItems.IndexOf(item) + 1);
                        item.order_id = order.id;
                        totalQuantity += item.quantity;
                        totalValue += item.value * item.quantity;
                        totalCost += item.cost;
                    }
                    order.total_quantity = totalQuantity;
                    order.total_value = totalValue;
                    order.total_cost = totalCost;

                    // Convert order info per order type
                    if (rbtnOrderType_Regular.Checked)
                    {
                        RegularOrder regularOrder = order.ToRegular();
                        regularOrder.sender_id = Sender.id;
                        regularOrder.recipient_id = Recipient.id;

                            saveResult = _regularBusiness.Insert(regularOrder, ucItemsList.OrderItems);
                    }
                    else
                    {
                        IrregularOrder irregularOrder = order.ToIrregular();
                        irregularOrder.sender_name = tbSenderName.Text;
                        irregularOrder.sender_phone = tbSenderPhoneNumber.Text;
                        irregularOrder.sender_id_card_no = tbSenderIDCardNo.Text;
                        irregularOrder.sender_address = tbSenderAddress.Text;
                        irregularOrder.recipient_name = tbRecipientName.Text;
                        irregularOrder.recipient_phone = tbRecipientPhoneNumber.Text;
                        irregularOrder.recipient_id_card_no = tbRecipientIDCardNo.Text;
                        irregularOrder.recipient_address = tbRecipientAddress.Text;

                        if (rbtnPaymentStatus_Paid.Checked &&
                            (new IrregularOrderPaymentView(irregularOrder, ucItemsList.OrderItems)).ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        {
                            AppLogger.logDebug(this.ToString(), "Payment process cancelled.");
                            return;
                        }
                        saveResult = _irregularBusiness.Insert(irregularOrder, ucItemsList.OrderItems);
                    }
                }
                catch (Exception ex)
                {
                    AppLogger.logError(this.ToString(), ex.Message, ex);
                    success = false;
                }
                if (success && string.IsNullOrEmpty(saveResult))
                {
                    AppLogger.logInfo(this.ToString(), "Finish inserting new order into database.");
                    MessageBox.Show("Đã tạo thành công đơn hàng mới.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(saveResult))
                    {
                        saveResult = Constants.Messages.CREATE_ORDER_ERROR_MESSAGE;
                    }
                    MessageBox.Show(saveResult, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSenderBrowse_Click(object sender, EventArgs e)
        {
            using (SelectCustomerView selectCustomerView = new SelectCustomerView())
            {
                if (selectCustomerView.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Sender = selectCustomerView.ReturnValue;
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
                }
            }
        }
        #endregion
    }
}
