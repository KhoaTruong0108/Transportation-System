using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace com.lhk.transportsystem.Owner.Financial
{
    public partial class RevenueView : GenericDialog
    {
        private bool _isRevenue;
        private RevenueBusiness _revenueBusiness;
        private ExpenseBusiness _expenseBusiness;

        public RevenueView(bool isRevenue)
        {
            InitializeComponent();

            _revenueBusiness = new RevenueBusiness(SystemParam.CurrentUser);
            _expenseBusiness = new ExpenseBusiness(SystemParam.CurrentUser);

            _isRevenue = isRevenue;
        }

        private void RevenueView_Load(object sender, EventArgs e)
        {
            try
            {
                cbYearSearch.Items.Add("");
                for (int i = DateTime.Now.Year - 10; i < DateTime.Now.Year + 5; i++)
                {
                    cbYearSearch.Items.Add(i);
                }
                cbYearSearch.SelectedItem = DateTime.Now.Year;

                cbMonthSearch.Items.Add("");
                for (int i = 1; i <= 12; i++)
                {
                    cbMonthSearch.Items.Add(i);
                }
                cbMonthSearch.SelectedItem = DateTime.Now.Month;

                InitDayCombo(DateTime.Now.Year, DateTime.Now.Month);

                ChangeViewStatus(false);
                rbExpense.Checked = !_isRevenue;
                rbRevenue.Checked = _isRevenue;
            }
            catch (Exception exc)
            {
                AppLogger.logError("RevenueView_Load", exc);
            }
        }

        private void InitDayCombo(int year, int month)
        {
            DateTime tempDate = new DateTime(year,month,1);

            cbDaySearch.Items.Clear();
            cbDaySearch.Items.Add("");
            for (int i = 1; i <= tempDate.AddMonths(1).AddDays(-1).Day; i++)
            {
                cbDaySearch.Items.Add(i);
            }
        }

        private void rbExpense_CheckedChanged(object sender, EventArgs e)
        {
            _isRevenue = false;
        }

        private void rbRevenue_CheckedChanged(object sender, EventArgs e)
        {
            _isRevenue = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                if(_isRevenue)
                {
                    dgvFinacial.DataSource = _revenueBusiness.Search(cbDaySearch.Text, cbMonthSearch.Text, cbYearSearch.Text);
                }
                else
                {
                    dgvFinacial.DataSource = _expenseBusiness.Search(cbDaySearch.Text, cbMonthSearch.Text, cbYearSearch.Text);
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSearch_Click", exc);
            }
        }

        private void dgvFinacial_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFinacial.SelectedRows.Count <= 0) return;

                var selectedItem = dgvFinacial.SelectedRows[0].DataBoundItem;

                tbId.Text = _isRevenue ? ((Revenue)selectedItem).id : ((Expense)selectedItem).id;
                tbName.Text = _isRevenue ? ((Revenue)selectedItem).name : ((Expense)selectedItem).name;
                tbAmount.Text = _isRevenue ? CurrencyUtil.ToString(((Revenue)selectedItem).amount) : CurrencyUtil.ToString(((Expense)selectedItem).amount);
                tbRemark.Text = _isRevenue ? ((Revenue)selectedItem).description : ((Expense)selectedItem).description;
                dtpCreateDate.Value = _isRevenue ? ((Revenue)selectedItem).created_date : ((Expense)selectedItem).created_date;
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvFinacial_SelectionChanged", exc);
            }
        }

        protected string ValidInput()
        {
            StringBuilder errorMessage = new StringBuilder();
            ClearControlError(tbName);
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorMessage.AppendLine("Tên không được để trống!");
                SetControlError(tbName, "");
            }

            ClearControlError(tbAmount);
            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                errorMessage.AppendLine("Số tiền không được để trống!");
                SetControlError(tbAmount, "");
            }

            return errorMessage.ToString();
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
                    if (_isRevenue)
                    {
                        Revenue revenue = IsUpdating ? context.Revenues.SingleOrDefault(i => i.id == tbId.Text.Trim())
                            : new Revenue();

                        revenue.id = IsUpdating ? tbId.Text : IDGenerator.RevenueId();
                        revenue.name = tbName.Text;
                        revenue.amount = CurrencyUtil.ToDecimal(tbAmount.Text);
                        revenue.created_by = _isUpdating ? revenue.created_by : SystemParam.CurrentUser.id;
                        revenue.created_date = _isUpdating ? revenue.created_date : dtpCreateDate.Value;
                        revenue.description = tbRemark.Text;
                        revenue.type = Constants.RevenueType.Other.ToString();

                        AppLogger.logInfo("btnSave_Click", IsUpdating ? "UPDATE" : "INSERT", revenue);

                        if (IsUpdating == false) context.Revenues.AddObject(revenue);
                    }
                    else
                    {
                        Expense expense = IsUpdating ? context.Expenses.SingleOrDefault(i => i.id == tbId.Text.Trim())
                                : new Expense();

                        expense.id = IsUpdating ? tbId.Text : IDGenerator.ExpenseId();
                        expense.name = tbName.Text;
                        expense.amount = CurrencyUtil.ToDecimal(tbAmount.Text);
                        expense.created_by = _isUpdating ? expense.created_by : SystemParam.CurrentUser.id;
                        expense.created_date = _isUpdating ? expense.created_date : dtpCreateDate.Value;
                        expense.description = tbRemark.Text;
                        expense.type = string.Empty;

                        AppLogger.logInfo("btnSave_Click", IsUpdating ? "UPDATE" : "INSERT", expense);
                        
                        if (IsUpdating == false) context.Expenses.AddObject(expense);
                    }

                    context.SaveChanges();

                    ChangeViewStatus(false);
                    btnSearch_Click(sender, e);
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
                    
                    if (_isRevenue)
                    {
                        Revenue revenue = context.Revenues.SingleOrDefault(i => i.id == tbId.Text.Trim());
                        AppLogger.logInfo("btnDelete_Click", "DELETE", revenue);

                        if (revenue == null) return;

                        context.Revenues.DeleteObject(revenue);
                    }
                    else
                    {
                        Expense expense = context.Expenses.SingleOrDefault(i => i.id == tbId.Text.Trim());
                        AppLogger.logInfo("btnDelete_Click", "DELETE", expense);

                        if (expense == null) return;

                        context.Expenses.DeleteObject(expense);
                    }

                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnDelete_Click", exc);
            }
        }

        protected override void ChangeViewStatus(bool isEdit)
        {
            base.ChangeViewStatus(isEdit);

            tbId.ReadOnly = true;
            tbName.ReadOnly = !isEdit;
            tbAmount.ReadOnly = !isEdit;
            tbRemark.ReadOnly = !isEdit;
            dtpCreateDate.Enabled = isEdit;
            dgvFinacial.Enabled = !isEdit;
            gbSearch.Enabled = !isEdit;
        }

        protected override void ClearAll()
        {
            base.ClearAll();

            tbId.Text = string.Empty;
            tbName.Text = string.Empty;
            tbAmount.Text = string.Empty;
            tbRemark.Text = string.Empty;
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            this.CurrencyTextBox_TextChanged(sender, e);
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void cbMonthSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month;
            int year;
            cbDaySearch.Items.Clear();
            if (int.TryParse(cbMonthSearch.Text, out month) && int.TryParse(cbYearSearch.Text, out year))
            {
                InitDayCombo(year, month);
            }
        }
    }
}
