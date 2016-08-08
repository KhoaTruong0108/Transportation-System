using AppCommon.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Transport.Order
{
    public partial class ItemDetailsView : Form
    {
        #region Variables
        private bool _isUpdating = false;
        private OrderItemBusiness _business = null;
        private TransportPriceConfigurationBusiness _transportPriceBusiness = null;
        private GuaranteeFeeConfigurationBusiness _guaranteeFeeBusiness = null;
        private ItemsListUC _parent = null;

        private Collection<TransportPriceConfiguration> _transportPriceConfigurations = null;
        private Collection<GuaranteeFeeConfiguration> _guaranteeFeeConfigurations = null;
        #endregion

        #region Properties
        private OrderItem _orderItem = null;
        private OrderItem OrderItem
        {
            get
            {
                try
                {
                    this._orderItem.name = tbName.Text;
                    this._orderItem.weight = double.Parse(tbWeight.Text);
                    this._orderItem.size = cboSize.Text;
                    this._orderItem.quantity = int.Parse(tbQuantity.Text);
                    this._orderItem.value = decimal.Parse(tbValuePrice.Text, System.Globalization.NumberStyles.Currency);
                    this._orderItem.description = tbDescription.Text;
                    this._orderItem.order_item_number = string.Empty;
                    this._orderItem.cost = CurrencyUtil.ToDecimal(tbTotalCost.Text); //CalculateTotalCost(_orderItem.weight, _orderItem.size, _orderItem.value, _orderItem.quantity);
                }
                catch (Exception ex)
                {
                    AppLogger.logError(this.ToString(), "Error occurs when returning _orderItem", ex);
                }
                return _orderItem;
            }
            set
            {
                _orderItem = value;
                this.tbName.Text = _orderItem.name ?? string.Empty;
                this.tbWeight.Text = _orderItem.weight != 0 ? _orderItem.weight.ToString() : "1";
                this.tbValuePrice.Text = _orderItem.value.ToString();
                this.tbQuantity.Text = _orderItem.quantity > 0 ? _orderItem.quantity.ToString() : "1";
                this.tbDescription.Text = _orderItem.description ?? string.Empty;
                if (!string.IsNullOrEmpty(_orderItem.size))
                {
                    this.cboSize.SelectedItem = _orderItem.size;
                }
                this.tbTotalCost.Text = _orderItem.cost.ToString("N0");
            }
        }
        #endregion

        #region Constructors
        public ItemDetailsView(ItemsListUC parent)
        {
            InitializeComponent();
            InitializeData();
            this._parent = parent;
            this.OrderItem = new OrderItem();
        }

        public ItemDetailsView(ItemsListUC parent, OrderItem orderItem)
        {
            InitializeComponent();
            InitializeData();
            this._parent = parent;
            this.OrderItem = OrderItem.CreateOrderItem(
                                                    orderItem.id,
                                                    orderItem.order_id,
                                                    orderItem.name,
                                                    orderItem.quantity,
                                                    orderItem.value,
                                                    orderItem.size,
                                                    orderItem.weight,
                                                    orderItem.cost,
                                                    orderItem.description,
                                                    orderItem.order_item_number);
            _isUpdating = true;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            _business = new OrderItemBusiness();
            _transportPriceBusiness = new TransportPriceConfigurationBusiness();
            _guaranteeFeeBusiness = new GuaranteeFeeConfigurationBusiness();

            _transportPriceConfigurations = new Collection<TransportPriceConfiguration>(_transportPriceBusiness.GetAll().ToList());
            if (_transportPriceConfigurations.Count == 0)
            {
                tbWeight.Enabled = false;
                cboSize.Enabled = false;
            }
            _guaranteeFeeConfigurations = new Collection<GuaranteeFeeConfiguration>(_guaranteeFeeBusiness.GetAll().ToList());
            if (_guaranteeFeeConfigurations.Count == 0)
            {
                tbValuePrice.Enabled = false;
            }

            List<string> sizes = new List<string>();
            sizes.Add("XS");
            sizes.Add("S");
            sizes.Add("M");
            sizes.Add("L");
            sizes.Add("XL");
            this.cboSize.DataSource = sizes;
        }

        private decimal CalculateTotalCost(double weight, string size, decimal value, int quantity)
        {
            decimal totalCost = 0;
            try
            {
                decimal transportPrice = 0;
                decimal guaranteeFee = 0;

                TransportPriceConfiguration transportPriceConfig = _transportPriceConfigurations.FirstOrDefault(e =>
                                                                                                                e.size.Equals(size) &&
                                                                                                                weight >= e.weight_from &&
                                                                                                                weight < e.weight_to);
                if (transportPriceConfig != null)
                {
                    transportPrice = transportPriceConfig.transport_price;
                    tbTotalCost.Enabled = false;

                    // Only load GuaranteeFeeConfiguration if TransportPriceConfiguration is available
                    GuaranteeFeeConfiguration guaranteeFeeConfig = _guaranteeFeeConfigurations.FirstOrDefault(e =>
                                                                                                              value >= e.value_from &&
                                                                                                              value < e.value_to);
                    if (guaranteeFeeConfig != null)
                    {
                        guaranteeFee = guaranteeFeeConfig.guarantee_fee;
                    }

                }
                else
                {
                    tbTotalCost.Enabled = true;
                }

                totalCost = transportPrice * quantity + guaranteeFee;
            }
            catch (FormatException)
            {
                // Ignore FormatException
                AppLogger.logDebug(this.ToString(), "The FormatException was thrown but intentionally ignored.");
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occur when calculating total cost.", ex);
            }
            return totalCost;
        }

        private bool ValidateRequiredFields()
        {
            bool result = true;
            ClearControlError(tbName);
            ClearControlError(lblWeightUnit);
            ClearControlError(tbQuantity);
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                result = false;
                SetControlError(tbName, "Tên không được trống");
            }
            if (double.Parse(tbWeight.Text) == 0)
            {
                result = false;
                SetControlError(lblWeightUnit, "Khối lượng phải lớn hơn 0");
            }
            if (int.Parse(tbQuantity.Text) == 0)
            {
                result = false;
                SetControlError(tbQuantity, "Số lượng phải lớn hơn 0");
            }
            return result;
        }

        private bool ValidateInput()
        {
            bool result = true;
            double weight = 1;
            int quantity = 1;
            decimal value = 0;
            decimal totalCost = 0;
            int startPos = 0;
            ClearControlError(lblWeightUnit);
            ClearControlError(tbQuantity);
            ClearControlError(tbValuePrice);
            ClearControlError(lblTotalCostCurrency);

            // Validates weight
            if (string.IsNullOrWhiteSpace(tbWeight.Text))
            {
                tbWeight.Text = "1";
            }
            if (double.TryParse(tbWeight.Text, out weight))
            {
                startPos = tbWeight.SelectionStart;
                tbWeight.Text = weight.ToString();
                tbWeight.SelectionStart = startPos;
            }
            else
            {
                SetControlError(lblWeightUnit, "Giá trị không hợp lệ");
                result = false;
            }

            // Validates quantity
            if (string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                tbQuantity.Text = "1";
            }
            if (int.TryParse(tbQuantity.Text, out quantity))
            {
                startPos = tbQuantity.SelectionStart;
                tbQuantity.Text = quantity.ToString();
                tbQuantity.SelectionStart = startPos;
            }
            else
            {
                SetControlError(tbQuantity, "Giá trị không hợp lệ");
                result = false;
            }

            // Validates value
            if (string.IsNullOrWhiteSpace(tbValuePrice.Text))
            {
                tbValuePrice.Text = "0";
            }
            if (decimal.TryParse(tbValuePrice.Text, out value))
            {
                startPos = tbValuePrice.SelectionStart;
                tbValuePrice.Text = value.ToString("N0");
                tbValuePrice.SelectionStart = startPos;
            }
            else
            {
                SetControlError(tbValuePrice, "Giá trị không hợp lệ");
                result = false;
            }

            // Validates total cost
            if (string.IsNullOrWhiteSpace(tbTotalCost.Text))
            {
                tbTotalCost.Text = "0";
            }
            if (tbTotalCost.Enabled)
            {
                if (decimal.TryParse(tbTotalCost.Text, out totalCost))
                {
                    startPos = tbTotalCost.SelectionStart;
                    tbTotalCost.Text = totalCost.ToString("N0");
                    tbTotalCost.SelectionStart = startPos;
                }
                else
                {
                    SetControlError(lblTotalCostCurrency, "Giá trị không hợp lệ");
                    result = false;
                }
            }
            return result;
        }

        private bool ValidateCost()
        {
            bool result = true;
            // Reset style & error mark
            ClearControlError(lblTotalCostCurrency);
            tbTotalCost.ForeColor = System.Drawing.Color.Blue;
            if (OrderItem.cost <= 0)
            {
                SetControlError(lblTotalCostCurrency, "Tổng giá trị phải lớn hơn 0");
                tbTotalCost.ForeColor = System.Drawing.Color.Red;
                result = false;
            }
            return result;
        }

        private void SetControlError(Control control, string error)
        {
            this.errorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
            this.errorProvider.SetIconPadding(control, 2);
            this.errorProvider.SetError(control, error);
        }

        private void ClearControlError(Control control)
        {
            this.errorProvider.SetError(control, string.Empty);
        }
        #endregion

        #region Event Handlers
        private void OnControlFocus(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void OnControlUnFocus(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                ValidateInput();
                decimal totalCost = CalculateTotalCost(OrderItem.weight, OrderItem.size, OrderItem.value, OrderItem.quantity);
                if (!this.tbTotalCost.Enabled)
                {
                    this.tbTotalCost.Text = CurrencyUtil.ToString(totalCost);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateRequiredFields() && ValidateInput() && ValidateCost())
            {
                if (_isUpdating)
                {
                    OrderItem orderItem = this._parent.OrderItems.FirstOrDefault(item => item.id.Equals(OrderItem.id));
                    if (orderItem != null)
                    {
                        orderItem.order_id = OrderItem.order_id;
                        orderItem.name = OrderItem.name;
                        orderItem.quantity = OrderItem.quantity;
                        orderItem.value = OrderItem.value;
                        orderItem.size = OrderItem.size;
                        orderItem.weight = OrderItem.weight;
                        orderItem.cost = OrderItem.cost;
                        orderItem.description = OrderItem.description;
                    }
                }
                else
                {
                    OrderItem.id = Guid.NewGuid().ToString();//IDGenerator.OrderItemId(this._parent.OrderID, this._parent.OrderItems.Count + 1);
                    OrderItem.order_id = this._parent.OrderID;
                    this._parent.OrderItems.Add(OrderItem);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void tbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbValuePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbTotalCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbDescription_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = e.KeyCode.Equals(Keys.Enter);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Enabled)
            {
                ValidateInput();
            }
        }
        #endregion
    }
}
