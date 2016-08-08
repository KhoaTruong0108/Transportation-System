using System;
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
    public partial class GuaranteeFeeView : GenericDialog
    {
        #region Variables
        private GuaranteeFeeConfigurationBusiness _business = null;
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
        public GuaranteeFeeView()
        {
            InitializeComponent();
            InitializeData();
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            _business = new GuaranteeFeeConfigurationBusiness();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            DataBind();
        }

        private void DataBind()
        {
            var configurations = _business.GetAll().ToList();
            dgvItemsList.DataSource = configurations;
            dgvItemsList.ClearSelection();
            ChangeViewStatus(false);
        }

        protected override void ClearAll()
        {
            tbValueFrom.Text = "0";
            tbValueTo.Text = string.Empty;
            tbGuaranteeFee.Text = "0";
        }

        protected override void ChangeViewStatus(bool isEditing)
        {
            base.ChangeViewStatus(isEditing);
            tbValueFrom.Enabled = isEditing;
            tbValueTo.Enabled = isEditing;
            tbGuaranteeFee.Enabled = isEditing;
            dgvItemsList.Enabled = !isEditing;
        }

        private GuaranteeFeeConfiguration GetConfigurationInfo()
        {
            return new GuaranteeFeeConfiguration()
            {
                value_from = decimal.Parse(tbValueFrom.Text),
                value_to = !string.IsNullOrEmpty(tbValueTo.Text) ? decimal.Parse(tbValueTo.Text) : Constants.MAX_MONEY_VALUE,
                guarantee_fee = decimal.Parse(tbGuaranteeFee.Text)
            };
        }

        private void LoadConfigurationInfo(GuaranteeFeeConfiguration configuration)
        {
            if (configuration != null)
            {
                tbValueFrom.Text = configuration.value_from.ToString("N0");
                tbValueTo.Text = configuration.value_to != Constants.MAX_MONEY_VALUE ? configuration.value_to.ToString("N0") : string.Empty;
                tbGuaranteeFee.Text = configuration.guarantee_fee.ToString("N0");
            }
        }

        private bool ValidateInput()
        {
            bool result = true;
            int pos = 0;
            decimal valueFrom = 0;
            decimal valueTo = Constants.MAX_MONEY_VALUE;
            decimal guaranteeFee;

            // Sets text color to normal
            tbValueFrom.ForeColor = Color.Black;
            tbValueTo.ForeColor = Color.Black;
            tbGuaranteeFee.ForeColor = Color.Black;

            // Validates value from
            if (string.IsNullOrWhiteSpace(tbValueFrom.Text))
            {
                tbValueFrom.Text = "0";
            }
            if (decimal.TryParse(tbValueFrom.Text, out valueFrom))
            {
                pos = tbValueFrom.SelectionStart;
                tbValueFrom.Text = valueFrom.ToString("N0");
                tbValueFrom.SelectionStart = pos;
            }
            else
            {
                tbValueFrom.ForeColor = Color.Red;
                result = false;
            }

            // Validates value to
            if (!string.IsNullOrWhiteSpace(tbValueTo.Text))
            {
                if (decimal.TryParse(tbValueTo.Text, out valueTo))
                {
                    pos = tbValueTo.SelectionStart;
                    tbValueTo.Text = valueTo.ToString("N0");
                    tbValueTo.SelectionStart = pos;
                }
                else
                {
                    tbValueTo.ForeColor = Color.Red;
                    result = false;
                }
            }

            // Validates guarantee fee
            if (string.IsNullOrWhiteSpace(tbGuaranteeFee.Text))
            {
                tbGuaranteeFee.Text = "0";
            }
            if (decimal.TryParse(tbGuaranteeFee.Text, out guaranteeFee))
            {
                pos = tbGuaranteeFee.SelectionStart;
                tbGuaranteeFee.Text = guaranteeFee.ToString("N0");
                tbGuaranteeFee.SelectionStart = pos;
            }
            else
            {
                tbGuaranteeFee.ForeColor = Color.Red;
                result = false;
            }

            // Validates valid values condition
            if (valueFrom.CompareTo(valueTo) > 0)
            {
                tbValueFrom.ForeColor = Color.Red;
                tbValueTo.ForeColor = Color.Red;
                result = false;
            }
            return result;
        }
        #endregion

        #region Event Handlers
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc rằng muốn xóa thiết lập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string result = _business.Delete(SelectedItemID);
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

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string result = string.Empty;
                GuaranteeFeeConfiguration configuration = GetConfigurationInfo();
                if (_isUpdating)
                {
                    configuration.id = SelectedItemID;
                    result = _business.Update(configuration);
                }
                else
                {
                    configuration.id = IDGenerator.NewId<GuaranteeFeeConfiguration>(true);
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

        protected void OnKeyPress(object sender, KeyPressEventArgs e)
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

        protected override void OnEnter(object sender, EventArgs e)
        {
            base.OnEnter(sender, e);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void dgvItemsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Value column or Total totalCost column
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
                {
                    if (decimal.Parse(e.Value.ToString()).Equals(Constants.MAX_MONEY_VALUE))
                    {
                        e.Value = "MAX";
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = CurrencyUtil.ToStringWithCurrencySign((decimal)e.Value);
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dgvItemsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItemsList.SelectedRows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                GuaranteeFeeConfiguration configuration = _business.Get(SelectedItemID);
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
