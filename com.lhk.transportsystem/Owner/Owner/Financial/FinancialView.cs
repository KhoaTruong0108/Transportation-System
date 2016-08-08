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
    public partial class FinancialView : GenericView
    {
        private Color PROFIT_COLOR = Color.SpringGreen;
        private Color PROFIT_LOSS_COLOR = Color.Tomato;

        public FinancialView()
        {
            InitializeComponent();

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenericView_FormClosed);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            RevenueView view = new RevenueView(false);
            view.ShowDialog();
        }

        private void tbnAddRevenue_Click(object sender, EventArgs e)
        {
            RevenueView view = new RevenueView(true);
            view.ShowDialog();
        }

        private void FinancialView_Load(object sender, EventArgs e)
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
            }
            catch (Exception exc)
            {
                AppLogger.logError("FinancialView_Load", exc.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();

                decimal totalExpense = LoadExpenses(cbYearSearch.Text, cbMonthSearch.Text);
                decimal totalRevenue = LoadRevenues(cbYearSearch.Text, cbMonthSearch.Text);

                tbTotalExpense.Text = CurrencyUtil.ToString(totalExpense);
                tbTotalRevenue.Text = CurrencyUtil.ToString(totalRevenue);
                tbTotalProfit.Text = CurrencyUtil.ToString(totalRevenue - totalExpense);
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSearch_Click", exc.ToString());
            }
        }

        private decimal LoadExpenses(string year, string month)
        {
            List<Expense> expenses = new List<Expense>();
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                int tempYear = string.IsNullOrEmpty(year) == false ? int.Parse(year) : 0;
                int tempMonth = string.IsNullOrEmpty(month) == false ? int.Parse(month) : 0;

                expenses = context.Expenses
                            .Where(i => (i.created_date.Year == tempYear || string.IsNullOrEmpty(year)
                                      && i.created_date.Month == tempMonth || string.IsNullOrEmpty(month)))
                            .ToList();
            }

            dgvExpenes.DataSource = expenses;

            return expenses.Sum(i => i.amount);
        }

        private decimal LoadRevenues(string year, string month)
        {
            List<Revenue> revenues = new List<Revenue>();
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                int tempYear = string.IsNullOrEmpty(year) == false ? int.Parse(year) : 0;
                int tempMonth = string.IsNullOrEmpty(month) == false ? int.Parse(month) : 0;

                revenues = context.Revenues
                            .Where(i => i.created_date.Year == tempYear || string.IsNullOrEmpty(year))
                            .Where(i => i.created_date.Month == tempMonth || string.IsNullOrEmpty(month))
                            .ToList();
            }

            dgvRevenue.DataSource = revenues;

            return revenues.Sum(i => i.amount);
        }

        private void dgvExpenes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvExpenes.SelectedRows.Count <= 0) return;

                Expense selectedItem = (Expense)dgvExpenes.SelectedRows[0].DataBoundItem;

                tbNameExpense.Text = selectedItem.name;
                tbAmountExpense.Text = CurrencyUtil.ToString(selectedItem.amount);
                tbRemarkExpense.Text = selectedItem.description;
                lblCreateDateExpenses.Text = selectedItem.created_date.ToString("dd/MM/yyyy hh:mm:ss");
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvExpenes_SelectionChanged", exc.ToString());
            }
        }

        private void dgvRevenue_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRevenue.SelectedRows.Count <= 0) return;

                Revenue selectedItem = (Revenue)dgvRevenue.SelectedRows[0].DataBoundItem;

                tbNameRevenue.Text = selectedItem.name;
                tbAmountRevenue.Text = CurrencyUtil.ToString(selectedItem.amount);
                tbRemarkRevenue.Text = selectedItem.description;
                lblCreateDateRevenue.Text = selectedItem.created_date.ToString("dd/MM/yyyy hh:mm:ss");
                btnRevenueDetail.Enabled = selectedItem.type.Equals(Constants.RevenueType.Other.ToString()) == false;
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvRevenue_SelectionChanged", exc.ToString());
            }
        }

        private void tbTotalProfit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tbTotalProfit.Text)) return;

                tbTotalProfit.BackColor = decimal.Parse(tbTotalProfit.Text) > 0 ? PROFIT_COLOR : PROFIT_LOSS_COLOR;
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvRevenue_SelectionChanged", exc.ToString());
            }
        }

        private void btnExpenseDetail_Click(object sender, EventArgs e)
        {
            if (dgvExpenes.SelectedRows.Count <= 0) return;
            Revenue selectedItem = (Revenue)dgvRevenue.SelectedRows[0].DataBoundItem;

            RevenueDetailView detaiView = new RevenueDetailView(selectedItem.id);
            detaiView.ShowDialog();
        }

        private void ClearAll()
        {
            tbNameExpense.Text = string.Empty;
            tbAmountExpense.Text = string.Empty;
            tbRemarkExpense.Text = string.Empty;
            lblCreateDateExpenses.Text = string.Empty;

            tbNameRevenue.Text = string.Empty;
            tbAmountRevenue.Text = string.Empty;
            tbRemarkRevenue.Text = string.Empty;
            lblCreateDateRevenue.Text = string.Empty;

            tbTotalRevenue.Text = string.Empty;
            tbTotalExpense.Text = string.Empty;
            tbTotalProfit.Text = string.Empty;
        }

    }
}
