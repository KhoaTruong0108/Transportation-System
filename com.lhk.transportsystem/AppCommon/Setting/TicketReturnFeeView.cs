using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBManagement;
using AppCommon.CommonView;
using AppCommon.Util;
using AppCommon.Business;

namespace AppCommon.Setting
{
    public partial class TicketReturnFeeView : GenericDialog
    {
        public TicketReturnFeeView()
        {
            InitializeComponent();
        }

        #region Event

        private void rbPercent_CheckedChanged(object sender, EventArgs e)
        {
            tbAmount.ReadOnly = true;
            tbAmount.Text = string.Empty;

            tbPercent.ReadOnly = false;
            tbPercent.Focus();
        }

        private void rbAmount_CheckedChanged(object sender, EventArgs e)
        {
            tbAmount.ReadOnly = false;
            tbAmount.Focus();

            tbPercent.ReadOnly = true;
            tbPercent.Text = string.Empty;
        }

        private void TicketReturnFeeConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                ChangeViewStatus(false);

                LoadTicketReturnFee();
            }
            catch (Exception exc)
            {
                AppLogger.logError("TicketReturnFeeConfiguration_Load", exc);
            }
        }

        protected override void btnAddNew_Click(object sender, EventArgs e)
        {
            base.btnAddNew_Click(sender, e);

            rbAmount.Checked = true;
            tbAmount.ReadOnly = false;
            tbPercent.ReadOnly = true;
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc rằng muốn xóa thiết lập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (TicketReturnFeeConfigurationBusiness business = new TicketReturnFeeConfigurationBusiness())
                    {
                        business.Delete(tbId.Text);
                    }

                    LoadTicketReturnFee();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnDelete_Click", exc);
            }
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = ValidInput();
                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                base.btnSave_Click(sender, e);

                using (TicketReturnFeeConfigurationBusiness business = new TicketReturnFeeConfigurationBusiness())
                {
                    TicketReturnFeeConfiguration config = _isUpdating == false 
                        ? new TicketReturnFeeConfiguration()
                        : business.Get(tbId.Text);

                    if (config == null) return;

                    config.id = _isUpdating == false ? IDGenerator.TicketReturnFeeConfigId() : tbId.Text;
                    config.before_day = int.Parse(tbBeforeDate.Text);
                    config.before_hour = string.IsNullOrEmpty(tbBeforeHour.Text) ? 0 : int.Parse(tbBeforeHour.Text);
                    config.fee_amount = rbAmount.Checked ? CurrencyUtil.ToDecimal(tbAmount.Text) : 0;
                    config.fee_percent = rbPercent.Checked ? int.Parse(tbPercent.Text) : 0;

                    business.Insert(config);

                    LoadTicketReturnFee();

                    ChangeViewStatus(false);
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSave_Click", exc);
            }
        }


        private void dgvItemsList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemsList.SelectedRows.Count <= 0) return;

                TicketReturnFeeConfiguration selectedItem = dgvItemsList.SelectedRows[0].DataBoundItem as TicketReturnFeeConfiguration;

                rbAmount.Checked = selectedItem.fee_amount > 0;
                rbPercent.Checked = selectedItem.fee_percent > 0;

                tbId.Text = selectedItem.id;
                tbBeforeDate.Text = selectedItem.before_day.ToString();
                tbBeforeHour.Text = selectedItem.before_hour.ToString();
                tbAmount.Text = CurrencyUtil.ToString(selectedItem.fee_amount);
                tbPercent.Text = selectedItem.fee_percent.ToString();
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvItemsList_SelectionChanged", exc);
            }
        }

        private void tbPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            base.CurrencyTextBox_TextChanged(sender, e);
        }

        private void tbBeforeDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void tbBeforeHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }
        #endregion

        #region Method
        protected string ValidInput()
        {
            StringBuilder errorMessage = new StringBuilder();
            int intTemp = 0;
            decimal decimalTemp = 0;

            ClearControlError(tbBeforeDate);
            if (string.IsNullOrEmpty(tbBeforeDate.Text)
                || int.TryParse(tbBeforeDate.Text, out intTemp) == false
                || intTemp < 0)
            {
                errorMessage.AppendLine("Trước ngày không hợp lệ!");
                SetControlError(tbBeforeDate, "");
            }

            ClearControlError(tbBeforeHour);
            if (int.TryParse(tbBeforeHour.Text, out intTemp) && intTemp < 0)
            {
                errorMessage.AppendLine("Giờ không hợp lệ!");
                SetControlError(tbBeforeHour, "");
            }

            ClearControlError(tbAmount);
            if ((string.IsNullOrEmpty(tbAmount.Text) && rbAmount.Checked)
                || decimal.TryParse(tbAmount.Text, out decimalTemp) == false
                || decimalTemp < 0)
            {
                errorMessage.AppendLine("Số tiền không hợp lệ!");
                SetControlError(tbAmount, "");
            }

            decimalTemp = 0;
            ClearControlError(tbPercent);
            if ((string.IsNullOrEmpty(tbPercent.Text) && rbPercent.Checked)
                || decimal.TryParse(tbAmount.Text, out decimalTemp) == false
                || decimalTemp < 0)
            {
                errorMessage.AppendLine("Phần trăm không hợp lệ!");
                SetControlError(tbPercent, "");
            }

            return errorMessage.ToString();
        }

        protected void LoadTicketReturnFee()
        {
            using (TicketReturnFeeConfigurationBusiness business = new TicketReturnFeeConfigurationBusiness())
            {
                dgvItemsList.DataSource = business.GetAll();//.OrderByDescending(i => i.before_day).ThenByDescending(i => i.before_hour);
            }
        }

        protected override void ClearAll()
        {
            base.ClearAll();
            tbAmount.Text = string.Empty;
            tbBeforeDate.Text = string.Empty;
            tbBeforeHour.Text = string.Empty;
            tbId.Text = string.Empty;
            tbPercent.Text = string.Empty;
        }

        protected override void ChangeViewStatus(bool isEditing)
        {
            base.ChangeViewStatus(isEditing);

            tbAmount.Enabled = isEditing;
            tbBeforeDate.Enabled = isEditing;
            tbBeforeHour.Enabled = isEditing;
            tbPercent.Enabled = isEditing;

            rbAmount.Enabled = isEditing;
            rbPercent.Enabled = isEditing;

            dgvItemsList.Enabled = !isEditing;
        }
        #endregion

    }
}
