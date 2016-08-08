using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Setting
{
    public partial class TicketPriceView : GenericDialog
    {
        private string _selectedClass = Constants.SeatClass.B.ToString();
        private string _selectedId = string.Empty;

        public TicketPriceView()
        {
            InitializeComponent();
        }

        #region event
        private void TicketPriceView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTicketPriceConfig();

                ChangeViewStatus(false);
            }
            catch (Exception exc)
            {
                AppLogger.logError("TicketPriceView_Load", exc);
            }
        }

        private void rbUpper_CheckedChanged(object sender, EventArgs e)
        {
            _selectedClass = Constants.SeatClass.B.ToString();
        }

        private void rbLower_CheckedChanged(object sender, EventArgs e)
        {
            _selectedClass = Constants.SeatClass.A.ToString();
        }

        private void rbFloor_CheckedChanged(object sender, EventArgs e)
        {
            _selectedClass = Constants.SeatClass.S.ToString();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            base.CurrencyTextBox_TextChanged(sender, e);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }
        #endregion

        #region override section
        protected override void ClearAll()
        {
            tbPrice.Text = string.Empty;
            tbRemark.Text = string.Empty;
        }

        protected override void ChangeViewStatus(bool isEditing)
        {
            base.ChangeViewStatus(isEditing);

            tbPrice.ReadOnly = !isEditing;
            tbRemark.ReadOnly = !isEditing;

            dgvItemsList.Enabled = !isEditing;
            rbFloor.Enabled = isEditing;
            rbUpper.Enabled = isEditing;
            rbLower.Enabled = isEditing;

            btnDelete.Visible = false;
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

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    TicketPriceConfiguration priceConfig = context.TicketPriceConfigurations.SingleOrDefault(i => i.id == _selectedId && i.seat_class == _selectedClass);
                    IsUpdating = priceConfig != null;

                    if (priceConfig == null) priceConfig = new TicketPriceConfiguration();

                    priceConfig.id = IsUpdating ? _selectedId : IDGenerator.TicketPriceConfigId();
                    priceConfig.price = CurrencyUtil.ToDecimal(tbPrice.Text);
                    priceConfig.seat_class = _selectedClass.ToString();
                    priceConfig.description = tbRemark.Text.Trim();

                    AppLogger.logInfo("btnSave_Click", IsUpdating ? "UPDATE" : "INSERT", priceConfig);

                    if (IsUpdating == false) context.TicketPriceConfigurations.AddObject(priceConfig);

                    context.SaveChanges();

                    ChangeViewStatus(false);

                    LoadTicketPriceConfig();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSave_Click", exc);
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                base.btnDelete_Click(sender, e);

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    TicketPriceConfiguration priceConfig = context.TicketPriceConfigurations.SingleOrDefault(i => i.id == _selectedId && i.seat_class == _selectedClass.ToString());
                    AppLogger.logInfo("btnDelete_Click", "DELETE", priceConfig);

                    if (priceConfig == null) return;

                    context.TicketPriceConfigurations.DeleteObject(priceConfig);

                    LoadTicketPriceConfig();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnDelete_Click", exc);
            }
        }
        #endregion

        protected string ValidInput()
        {
            StringBuilder errorMessage = new StringBuilder();

            ClearControlError(tbPrice);
            if (string.IsNullOrEmpty(tbPrice.Text)
                || CurrencyUtil.ToDecimal(tbPrice.Text) < 0)
            {
                errorMessage.AppendLine("Giá bán không hợp lệ!");
                SetControlError(tbPrice, "");
            }

            return errorMessage.ToString();
        }

        private void LoadTicketPriceConfig()
        {
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                dgvItemsList.DataSource = context.TicketPriceConfigurations.ToList();
            }
        }

        private void dgvItemsList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemsList.SelectedRows.Count <= 0) return;

                TicketPriceConfiguration selectedItem = dgvItemsList.SelectedRows[0].DataBoundItem as TicketPriceConfiguration;

                tbPrice.Text = CurrencyUtil.ToString(selectedItem.price);
                tbRemark.Text = selectedItem.description;
                _selectedId = selectedItem.id;
                _selectedClass = selectedItem.seat_class;

                rbUpper.Checked = selectedItem.seat_class == Constants.SeatClass.B.ToString();
                rbLower.Checked = selectedItem.seat_class == Constants.SeatClass.A.ToString();
                rbFloor.Checked = selectedItem.seat_class == Constants.SeatClass.S.ToString();
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvItemsList_SelectionChanged", exc);
            }
        }

    }
}
