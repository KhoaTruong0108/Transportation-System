using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Setting
{
    public partial class TransportPriceView : GenericDialog
    {
        #region Variables
        private TransportPriceConfigurationBusiness _business = null;
        #endregion

        #region Properties
        private string SelectedItemID
        {
            get
            {
                return dgvItemsList.SelectedRows.Count > 0 ? dgvItemsList.SelectedRows[0].Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }
        #endregion

        #region Constructors
        public TransportPriceView()
        {
            InitializeComponent();
            InitializeData();
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            _business = new TransportPriceConfigurationBusiness();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            List<string> sizes = new List<string>();
            sizes.Add("XS");
            sizes.Add("S");
            sizes.Add("M");
            sizes.Add("L");
            sizes.Add("XL");
            this.cboSize.DataSource = sizes;

            DataBind();
            dgvItemsList.ClearSelection();
            ChangeViewStatus(false);
        }

        private void DataBind()
        {
            var configurations = _business.GetAll().ToList();
            dgvItemsList.DataSource = configurations;
        }

        protected override void ClearAll()
        {
            cboSize.SelectedIndex = 0;
            tbWeightFrom.Text = "0";
            tbWeightTo.Text = string.Empty;
            tbTransportPrice.Text = "0";
        }

        protected override void ChangeViewStatus(bool isEditing)
        {
            base.ChangeViewStatus(isEditing);
            cboSize.Enabled = isEditing;
            tbWeightFrom.Enabled = isEditing;
            tbWeightTo.Enabled = isEditing;
            tbTransportPrice.Enabled = isEditing;
            dgvItemsList.Enabled = !isEditing;
        }

        private TransportPriceConfiguration GetConfigurationInfo()
        {
            return new TransportPriceConfiguration()
            {
                size = cboSize.SelectedItem.ToString(),
                weight_from = double.Parse(tbWeightFrom.Text),
                weight_to = !string.IsNullOrEmpty(tbWeightTo.Text) ? double.Parse(tbWeightTo.Text) : Constants.MAX_WEIGHT_VALUE,
                transport_price = decimal.Parse(tbTransportPrice.Text)
            };
        }

        private void LoadConfigurationInfo(TransportPriceConfiguration configuration)
        {
            if (configuration != null)
            {
                cboSize.SelectedItem = configuration.size;
                tbWeightFrom.Text = configuration.weight_from.ToString();
                tbWeightTo.Text = configuration.weight_to != Constants.MAX_WEIGHT_VALUE ? configuration.weight_to.ToString() : string.Empty;
                tbTransportPrice.Text = configuration.transport_price.ToString("N0");
            }
        }

        private bool ValidateInput()
        {
            bool result = true;
            int pos = 0;
            double weightFrom = 0;
            double weightTo = Constants.MAX_WEIGHT_VALUE;
            decimal transportPrice;

            // Sets text color to normal
            tbWeightFrom.ForeColor = Color.Black;
            tbWeightTo.ForeColor = Color.Black;
            tbTransportPrice.ForeColor = Color.Black;

            // Validates weight from
            if (string.IsNullOrWhiteSpace(tbWeightFrom.Text))
            {
                tbWeightFrom.Text = "0";
            }
            if (double.TryParse(tbWeightFrom.Text, out weightFrom))
            {
                pos = tbWeightFrom.SelectionStart;
                tbWeightFrom.Text = weightFrom.ToString();
                tbWeightFrom.SelectionStart = pos;
            }
            else
            {
                tbWeightFrom.ForeColor = Color.Red;
                result = false;
            }

            // Validates weight to
            if (!string.IsNullOrWhiteSpace(tbWeightTo.Text))
            {
                if (double.TryParse(tbWeightTo.Text, out weightTo))
                {
                    pos = tbWeightTo.SelectionStart;
                    tbWeightTo.Text = weightTo.ToString();
                    tbWeightTo.SelectionStart = pos;
                }
                else
                {
                    tbWeightTo.ForeColor = Color.Red;
                    result = false;
                }
            }

            // Validates transport price
            if (string.IsNullOrWhiteSpace(tbTransportPrice.Text))
            {
                tbTransportPrice.Text = "0";
            }
            if (decimal.TryParse(tbTransportPrice.Text, out transportPrice))
            {
                pos = tbTransportPrice.SelectionStart;
                tbTransportPrice.Text = transportPrice.ToString("N0");
                tbTransportPrice.SelectionStart = pos;
            }
            else
            {
                tbTransportPrice.ForeColor = Color.Red;
                result = false;
            }

            // Validates valid weights condition
            if (weightFrom.CompareTo(weightTo) > 0)
            {
                tbWeightFrom.ForeColor = Color.Red;
                tbWeightTo.ForeColor = Color.Red;
                result = false;
            }
            return result;
        }
        #endregion

        #region Event Handlers
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            //base.btnDelete_Click(sender, e);
            if (MessageBox.Show("Bạn có chắc rằng muốn xóa thiết lập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string result = _business.Delete(SelectedItemID);
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataBind();
            }
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            //base.btnSave_Click(sender, e);
            if (ValidateInput())
            {
                string result = string.Empty;
                TransportPriceConfiguration configuration = GetConfigurationInfo();
                if (_isUpdating)
                {
                    configuration.id = SelectedItemID;
                    result = _business.Update(configuration);
                }
                else
                {
                    configuration.id = IDGenerator.NewId<TransportPriceConfiguration>(true);
                    result = _business.Insert(configuration);
                }
                if (string.IsNullOrEmpty(result))
                {
                    ChangeViewStatus(false);
                    DataBind();
                }
                else
                {
                    MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
            LoadConfigurationInfo(_business.Get(SelectedItemID));
        }

        private void OnWeightTextBoxesKeyPress(object sender, KeyPressEventArgs e)
        {
            base.FloatNumberTextBox_KeyPress(sender, e);
        }

        private void tbTransportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        protected override void OnEnter(object sender, EventArgs e)
        {
            base.OnEnter(sender, e);
        }

        private void OnLeave(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void dgvListDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Weight column
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
                {
                    if (double.Parse(e.Value.ToString()).Equals(Constants.MAX_WEIGHT_VALUE))
                    {
                        e.Value = "MAX";
                    }
                    else
                    {
                        e.Value = string.Format("{0:N3} kg", e.Value.ToString());
                    }
                    e.FormattingApplied = true;
                }

                // Value column or Total totalCost column
                if (e.ColumnIndex == 4)
                {
                    e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvListDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItemsList.SelectedRows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                TransportPriceConfiguration configuration = _business.Get(SelectedItemID);
                LoadConfigurationInfo(configuration);
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        #endregion
    }
}
