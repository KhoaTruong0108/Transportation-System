using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCommon.CommonView;
using AppCommon.Util;
using DBManagement;
using DBManagement.Constant;

namespace com.lhk.transportsystem.Owner.Financial
{
    public partial class RevenueDetailView : GenericDialog
    {
        private string _revenueId;

        public RevenueDetailView(string expenseId)
        {
            InitializeComponent();

            _revenueId = expenseId;
        }

        private void ExpenseDetailView_Load(object sender, EventArgs e)
        {
            ClearAll();

            cbType.Items.Clear();
            var revenueTypes = typeof(Constants.RevenueType).ToList<string>();
            cbType.DisplayMember = "Value";
            cbType.ValueMember = "Key";
            cbType.DataSource = revenueTypes;

            LoadExpenseDetail();
        }

        private void LoadExpenseDetail()
        {
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                var RevenueDetails = context.RevenueDetails.Where(i => i.revenue_id == _revenueId).ToList();
                dgvFinacial.DataSource = RevenueDetails;

                tbTotalAmount.Text = CurrencyUtil.ToString(RevenueDetails.Sum(i => i.amount));
            }
        }

        protected override void ChangeViewStatus(bool isEdit)
        {
            base.ChangeViewStatus(isEdit);

            tbId.ReadOnly = true;
            tbObjectId.ReadOnly = true;
            tbAmount.ReadOnly = !isEdit;
            tbRemark.ReadOnly = !isEdit;
            dtpCreateDate.Enabled = isEdit;
        }

        protected override void ClearAll()
        {
            base.ClearAll();

            tbId.Text = string.Empty;
            tbObjectId.Text = string.Empty;
            tbAmount.Text = string.Empty;
            tbRemark.Text = string.Empty;
            lbCreatedBy.Text = string.Empty;
        }

        private void dgvFinacial_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFinacial.SelectedRows.Count <= 0) return;

                var selectedItem = dgvFinacial.SelectedRows[0].DataBoundItem;

                tbId.Text = ((RevenueDetail)selectedItem).id;
                tbObjectId.Text = ((RevenueDetail)selectedItem).object_id;
                tbAmount.Text = CurrencyUtil.ToString(((RevenueDetail)selectedItem).amount);
                tbRemark.Text = ((RevenueDetail)selectedItem).description;
                dtpCreateDate.Value = ((RevenueDetail)selectedItem).created_date;
                lbCreatedBy.Text = ((RevenueDetail)selectedItem).created_by;
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvFinacial_SelectionChanged", exc);
            }
        }

        protected string ValidInput()
        {
            StringBuilder errorMessage = new StringBuilder();
            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                errorMessage.AppendLine("Số tiền không được để trống!");
                SetControlError(tbAmount, "");
            }

            return errorMessage.ToString();
        }

        protected override void btnAddNew_Click(object sender, EventArgs e)
        {
            base.btnAddNew_Click(sender, e);

            cbType.SelectedItem = Constants.RevenueType.Other;
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

                if (MessageBox.Show("Thay đổi thông tin chi tiết của Doanh thu có thể làm thay đổi tổng doanh thu.\r\n Bạn có chắc chắn muốn thay đổi không?"
                    , "Chú ý"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning
                    , MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

                base.btnSave_Click(sender, e);

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {

                    RevenueDetail expenseDetail = _isUpdating ? context.RevenueDetails.SingleOrDefault(i => i.id == tbId.Text.Trim())
                            : new RevenueDetail();

                    expenseDetail.id = IsUpdating ? tbId.Text : IDGenerator.ExpenseId();
                    expenseDetail.object_id = tbObjectId.Text;
                    expenseDetail.revenue_id = _revenueId;
                    expenseDetail.amount = CurrencyUtil.ToDecimal(tbAmount.Text);
                    expenseDetail.created_by = _isUpdating ? expenseDetail.created_by : SystemParam.CurrentUser.id;
                    expenseDetail.created_date = _isUpdating ? expenseDetail.created_date : dtpCreateDate.Value;
                    expenseDetail.description = tbRemark.Text;
                    expenseDetail.type = cbType.SelectedValue.ToString();
                    expenseDetail.title = string.Empty;

                    AppLogger.logInfo("btnSave_Click", IsUpdating ? "UPDATE" : "INSERT", expenseDetail);

                    if (IsUpdating == false) context.RevenueDetails.AddObject(expenseDetail);

                    context.SaveChanges();

                    ChangeViewStatus(false);
                }

                UpdateExpenseAmount();

                LoadExpenseDetail();
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
                    RevenueDetail revenueDetail = context.RevenueDetails.SingleOrDefault(i => i.id == tbId.Text.Trim());
                    AppLogger.logInfo("btnSave_Click", "DELETE", revenueDetail);

                    if (revenueDetail != null) return;

                    context.RevenueDetails.DeleteObject(revenueDetail);
                }

                LoadExpenseDetail();
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnDelete_Click", exc);
            }
        }

        protected void UpdateExpenseAmount()
        {
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                Revenue revenue = context.Revenues.SingleOrDefault(i => i.id == _revenueId);

                if (revenue == null) throw new Exception("Revenue is not exist: Id = " + _revenueId);

                revenue.amount = context.RevenueDetails.Where(i => i.revenue_id == revenue.id).Sum(i => i.amount);

                context.SaveChanges();
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            this.CurrencyTextBox_TextChanged(sender, e);
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.NumberOnlyTextBox_KeyPress(sender, e);
        }

    }
}
