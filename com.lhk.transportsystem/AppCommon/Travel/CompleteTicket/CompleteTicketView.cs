using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Travel
{
    public partial class CompleteTicketView : GenericView
    {
        private TicketBusiness _ticketBusiness;
        private RevenueBusiness _revenueBusiness;
        private ExpenseBusiness _expenseBusiness;

        private decimal _totalRevenue;
        private bool _isEnableRegulation;
        private List<Ticket> _tickets;

        public CompleteTicketView()
        {
            InitializeComponent();
            _ticketBusiness = new TicketBusiness(SystemParam.CurrentUser);
            _revenueBusiness = new RevenueBusiness(SystemParam.CurrentUser);
            _expenseBusiness = new ExpenseBusiness(SystemParam.CurrentUser);
        }

        #region Event Handlers

        private void CompleteTicketView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadBusCombobox();
                LoadTourCombobox();
                ClearAll();

                tbRealAmount.KeyPress += base.NumberOnlyTextBox_KeyPress;
                tbExpense.KeyPress += base.NumberOnlyTextBox_KeyPress;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchTicket();
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        private void dgvTicketsList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTicketsList.SelectedRows.Count <= 0) return;

                var selectedItem = dgvTicketsList.SelectedRows[0].DataBoundItem as Ticket;

                lblCustomerNameText.Text = selectedItem.passenger_name;
                lblIDCardNumberText.Text = selectedItem.passenger_id_card_no;
                lblPhoneNumberText.Text = selectedItem.phone;
                lblSeatNuumberText.Text = selectedItem.seat_class + selectedItem.seat_number;
                tbTicketPrice.Text = CurrencyUtil.ToString(selectedItem.cost);
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }


        private void ckbUseAdjustment_CheckedChanged(object sender, EventArgs e)
        {
            _isEnableRegulation = ckbUseAdjustment.Checked;
            this.tbAdjustmentAmount.ReadOnly = _isEnableRegulation == false;
            this.tbAdjustmentReason.ReadOnly = _isEnableRegulation == false;
            this.tbAdjustmentAmount.Enabled = _isEnableRegulation;
            this.tbAdjustmentReason.Enabled = _isEnableRegulation;

            if (_isEnableRegulation)
            {
                this.tbAdjustmentAmount.Focus();
            }
            else
            {
                this.tbAdjustmentAmount.Text = string.Empty;
            }
        }


        private void tbRealAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                base.CurrencyTextBox_TextChanged(sender, e);

                lblPaymentChange.Text = CurrencyUtil.ToString(CaculatePaymentChange());
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }

        }

        private void tbAdjustmentAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                base.CurrencyTextBox_TextChanged(sender, e);

                tbIncludeAdjustment.Text = CurrencyUtil.ToString(CurrencyUtil.ToDecimal(tbTotalPayment.Text) + CurrencyUtil.ToDecimal(tbAdjustmentAmount.Text));

                lblPaymentChange.Text = CurrencyUtil.ToString(CaculatePaymentChange());
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        private void tbAdjustmentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender,e);

            if (e.KeyChar.ToString().Equals("-"))
            {
                e.Handled = false;
            }
        }

        private void tbExpense_TextChanged(object sender, EventArgs e)
        {
            try
            {
                base.CurrencyTextBox_TextChanged(sender, e);

                lblProfit.Text = CurrencyUtil.ToString(CaculateProfit());
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string result = ValidateInput();
                if (string.IsNullOrEmpty(result))
                {
                    string msg = CurrencyUtil.ToDecimal(tbExpense.Text) <= 0
                        ? ""
                        : string.Format("Hiện tại chi phí là {0} VND \r\n", tbExpense.Text);

                    if (MessageBox.Show(msg + "Bạn có muốn kết sổ danh sách vé này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                    {
                        result = CompleteTickets(_tickets);
                    }
                    else
                    {
                        return;
                    }
                }

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Kết sổ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SearchTicket();
                }
                else
                {
                    MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
                MessageBox.Show(Constants.Messages.ERROR_OPERATION_NOT_PERFORMED, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Private Methods
        private string ValidateInput()
        {
            if (_totalRevenue == 0)
            {
                return "Tổng tiền đang bằng 0! Hảy nhấn Tìm trước khi kết sổ!";
            }

            if (CaculatePaymentChange() != 0)
            {
                return "Tổng thu và thực thu vẫn còn chênh lệch!\r\n (sử dụng tiền điều chỉnh để cân bằng.)";
            }

            if (_isEnableRegulation && (string.IsNullOrEmpty(tbAdjustmentAmount.Text) || string.IsNullOrEmpty(tbAdjustmentReason.Text)))
            {
                return "Số tiền điều chỉnh và Lý do không được để trống!";
            }
            return string.Empty;
        }

        private void ClearAll()
        {
            tbAdjustmentAmount.Text = string.Empty;
            tbAdjustmentReason.Text = string.Empty;
            tbExpense.Text = string.Empty;
            tbRealAmount.Text = string.Empty;
            tbTicketPrice.Text = string.Empty;
            tbTotalPayment.Text = string.Empty;
            tbIncludeAdjustment.Text = string.Empty;
            lblCustomerNameText.Text = string.Empty;
            lblIDCardNumberText.Text = string.Empty;
            lblPaymentChange.Text = string.Empty;
            lblPhoneNumberText.Text = string.Empty;
            lblProfit.Text = string.Empty;
            lblSeatNuumberText.Text = string.Empty;
        }

        private void SearchTicket()
        {
            ClearAll();
            string busId = this.cbBus.SelectedValue.ToString();
            string tourId = this.cbTour.SelectedValue.ToString();

            _tickets = _ticketBusiness.GetAll().Where(t => t.bus_id.Equals(busId) &&
                                                            t.tour_id.Equals(tourId) &&
                                                            t.status.Equals(Constants.TicketStatus.Closed.ToString()) == false &&
                                                            t.departure_time.Year == this.dtpDepature.Value.Year &&
                                                            t.departure_time.Month == this.dtpDepature.Value.Month &&
                                                            t.departure_time.Day == this.dtpDepature.Value.Day).OrderBy(i => i.seat_class).ThenBy(i => i.seat_number).ToList();
            dgvTicketsList.DataSource = _tickets;

            _totalRevenue = _tickets.Sum(i => i.cost);
            tbTotalPayment.Text = CurrencyUtil.ToString(_totalRevenue);
            tbIncludeAdjustment.Text = CurrencyUtil.ToString(_totalRevenue);
            tbRealAmount.Text = "0";
            lblPaymentChange.Text = "0";
        }

        private void LoadBusCombobox()
        {
            var buses = (new BusBusiness()).GetAll().ToList();
            cbBus.DataSource = buses;
            cbBus.DisplayMember = "name";
            cbBus.ValueMember = "id";
        }

        private void LoadTourCombobox()
        {
            var tours = (new TourBusiness()).GetAll().ToList();
            var tourTable = new DataTable();
            var columnId = new DataColumn("id");
            var columnName = new DataColumn("name");
            tourTable.Columns.Add(columnId);
            tourTable.Columns.Add(columnName);

            foreach (var tour in tours)
            {
                var row = tourTable.NewRow();
                row[0] = tour.id;
                row[1] = string.Format("{0} -- {1}", tour.start, tour.destination);
                tourTable.Rows.Add(row);
            }

            cbTour.DataSource = tourTable;
            cbTour.DisplayMember = "name";
            cbTour.ValueMember = "id";
        }

        private decimal CaculatePaymentChange()
        {
            decimal adjustment = string.IsNullOrEmpty(tbAdjustmentAmount.Text) ? 0 : CurrencyUtil.ToDecimal(tbAdjustmentAmount.Text);

            return CurrencyUtil.ToDecimal(tbRealAmount.Text) - (CurrencyUtil.ToDecimal(tbTotalPayment.Text) + adjustment);
        }

        private decimal CaculateProfit()
        {
            decimal expense = string.IsNullOrEmpty(tbExpense.Text) ? 0 : CurrencyUtil.ToDecimal(tbExpense.Text);
            decimal adjustment = string.IsNullOrEmpty(tbAdjustmentAmount.Text) ? 0 : CurrencyUtil.ToDecimal(tbAdjustmentAmount.Text);

            return _totalRevenue + adjustment - expense;
        }

        private string CompleteTickets(List<Ticket> tickets)
        {
            string result = string.Empty;
            decimal totalPayment = 0;
            decimal totalExpense = CurrencyUtil.ToDecimal(tbExpense.Text);
            decimal adjustment = CurrencyUtil.ToDecimal(tbAdjustmentAmount.Text);
            string adjustmentReason = tbAdjustmentReason.Text;

            Revenue revenue = new Revenue();
            revenue.id = IDGenerator.RevenueId();
            revenue.type = Constants.RevenueType.Ticket.ToString();
            revenue.name = "Bán vé";
            revenue.description = string.Empty;
            revenue.created_date = DateTime.Now;
            revenue.created_by = SystemParam.CurrentUser.id;
            List<RevenueDetail> revenueDetails = new List<RevenueDetail>();

            foreach (var ticket in tickets)
            {
                ticket.status = Constants.TicketStatus.Closed.ToString();

                // Updates tickets
                result = _ticketBusiness.CompleteTicket(ticket.id);

                RevenueDetail detail = new RevenueDetail();
                detail.id = IDGenerator.RevenueDetailId();
                detail.revenue_id = revenue.id;
                detail.object_id = ticket.id;
                detail.title = "Bán vé";
                detail.type = Constants.RevenueType.Ticket.ToString();
                detail.amount = ticket.cost;
                totalPayment += ticket.cost;
                detail.description = string.Empty;
                detail.created_date = DateTime.Now;
                detail.created_by = SystemParam.CurrentUser.id;
                revenueDetails.Add(detail);
            }
            revenue.amount = totalPayment;

            // Inserts revenue & details
            if (string.IsNullOrEmpty(result))
            {
                result = _revenueBusiness.Insert(revenue, revenueDetails);
            }
            // Inserts expense
            if (string.IsNullOrEmpty(result))
            {
                if (totalExpense != 0)
                {
                    Expense expense = new Expense();
                    expense.id = IDGenerator.RevenueId();
                    expense.type = Constants.RevenueType.Ticket.ToString();
                    expense.name = "Bán vé";
                    expense.amount = totalExpense;
                    expense.description = string.Empty;
                    expense.created_date = DateTime.Now;
                    expense.created_by = SystemParam.CurrentUser.id;
                    result = _expenseBusiness.Insert(expense);
                }
            }
            // Inserts adjustment
            if (string.IsNullOrEmpty(result))
            {
                if (adjustment > 0)
                {
                    Revenue adjustmentRevenue = new Revenue();
                    adjustmentRevenue.id = IDGenerator.RevenueId();
                    adjustmentRevenue.type = Constants.RevenueType.Adjustment.ToString();
                    adjustmentRevenue.name = "Điều chỉnh - Bán vé";
                    adjustmentRevenue.amount = Math.Abs(adjustment);
                    adjustmentRevenue.description = adjustmentReason;
                    adjustmentRevenue.created_date = DateTime.Now;
                    adjustmentRevenue.created_by = SystemParam.CurrentUser.id;
                    result = _revenueBusiness.Insert(adjustmentRevenue);
                }
                else if (adjustment < 0)
                {
                    Expense adjustmentExpense = new Expense();
                    adjustmentExpense.id = IDGenerator.RevenueId();
                    adjustmentExpense.type = Constants.RevenueType.Adjustment.ToString();
                    adjustmentExpense.name = "Điều chỉnh - Bán vé";
                    adjustmentExpense.amount = Math.Abs(adjustment);
                    adjustmentExpense.description = adjustmentReason;
                    adjustmentExpense.created_date = DateTime.Now;
                    adjustmentExpense.created_by = SystemParam.CurrentUser.id;
                    result = _expenseBusiness.Insert(adjustmentExpense);
                }
            }
            return result;
        }
        #endregion
    }
}
