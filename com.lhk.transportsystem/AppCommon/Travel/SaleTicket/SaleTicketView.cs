using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;
using System.Data.Objects.DataClasses;

namespace AppCommon.Travel.SaleTicket
{
    public partial class SaleTicketView : GenericView
    {
        #region Variables

        protected TicketBusiness _ticketBusiness;
        protected TicketPriceConfigurationBusiness _ticketPriceConfigurationBusiness;
        protected TicketReturnFeeConfigurationBusiness _ticketReturnFeeConfigurationBusiness;
        protected TicketSaleDateBusiness _ticketSaleDateBusiness;
        protected TourBusiness _tourBusiness;
        protected BusBusiness _busBusiness;
        //protected Ticket _currentTicket;

        protected string _busId;
        protected string _tourId;
        protected DateTime _departureTime = DateTime.Now;
        protected Constants.SeatClass _seatClass;
        protected int _seatNumber;
        protected List<int> _selectedSeatNumbers;
        protected bool _isEmptySeat;

        protected bool _isUpdating = false;
        protected bool _isEditStatus = false;

        protected string _ticketUserId;
        #endregion

        #region Constructor

        public SaleTicketView()
        {
            InitializeComponent();

            _ticketBusiness = new TicketBusiness(SystemParam.CurrentUser);
            _ticketPriceConfigurationBusiness = new TicketPriceConfigurationBusiness();
            _ticketReturnFeeConfigurationBusiness = new TicketReturnFeeConfigurationBusiness();
            _ticketSaleDateBusiness = new TicketSaleDateBusiness();
            _tourBusiness = new TourBusiness();
            _busBusiness = new BusBusiness();
            _selectedSeatNumbers = new List<int>();

            btnSearchSeat.Click += new EventHandler(btnSearchSeat_Click);
            ucSeatMap.LoadSeatInfo = new SeatMap.LoadSeatInfoDelegate(onSeatMapClick);

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenericView_FormClosed);
        }

        private void SaleTicketView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadBusCombobox();
                LoadTourCombobox();

                ClearTicketInfo();
                ChangeStatusControl(false);
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        #endregion

        #region Event handler

        private void btnSearchSeat_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMsg = ValidateBeforeSearch();
                if (string.IsNullOrEmpty(errorMsg))
                {
                    LoadSeatMapData();
                }
                else
                {
                    ShowErrorMessageBox(errorMsg);
                    dtDepartureTime.Value = _departureTime;
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSearchSeat_Click", exc);
            }
        }

        #endregion

        #region Methods

        #region Override Methods

        public override bool HandleCreateNew()
        {
            bool isSuccess = false;
            try
            {
                //if (_isEmptySeat)
                {
                    ChangeStatusControl(true);
                    ClearTicketInfo();
                    tbPassengerName.Focus();
                    _isUpdating = false;
                    isSuccess = true;
                }
                //else
                //{
                //    ShowErrorMessageBox(Constants.Messages.MSG_TICKET_TICKET_EXIST_ERROR_MSG);
                //}
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), Constants.Messages.MSG_TICKET_INSERT_TICKET_EXCEPTION_MSG, ex);
                ShowErrorMessageBox(Constants.Messages.MSG_TICKET_INSERT_TICKET_FAIL_MSG);
            }
            return isSuccess;
        }

        public override bool HandleEdit()
        {
            bool isSuccess = false;
            try
            {
                if (_isEmptySeat == false)
                {
                    if (CheckPermission())
                    {
                        ChangeStatusControl(true);
                        _isUpdating = true;
                        isSuccess = true;
                    }
                    else
                    {
                        ShowErrorMessageBox(Constants.Messages.MSG_TICKET_INSUFFICIENT_PERMISSION);
                    }
                }
                else
                {
                    ShowErrorMessageBox(Constants.Messages.MSG_TICKET_TICKET_NOT_EXIST_MSG);
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), Constants.Messages.MSG_TICKET_INSERT_TICKET_EXCEPTION_MSG, ex);
                ShowErrorMessageBox(Constants.Messages.MSG_TICKET_INSERT_TICKET_FAIL_MSG);
            }
            return isSuccess;
        }

        public override bool HandleSaveTask()
        {
            bool isSuccess = false;
            try
            {
                string errorMsg = string.Empty;
                errorMsg = ValidateData();
                var confirmView = new TicketPaymentView();
                var tickets = new List<Ticket>();

                if (string.IsNullOrEmpty(errorMsg))
                {
                    if (_isUpdating == false)
                    {
                        foreach (var seatNo in _selectedSeatNumbers)
                        {
                            tickets.Add(CreateUpdateTicket(seatNo: seatNo));
                        }

                        if (tickets.Count > 1)
                        {
                            int index = 1;
                            tickets.ForEach(x =>
                            {
                                x.id += index.ToString("D2");
                                index++;
                            });
                        }

                        confirmView.ConfirmTickets = tickets;
                        //confirmView.SellTicket = new TicketPaymentView.SellTicketDelegate(SellTicket);
                        confirmView.ShowDialog();
                        if (confirmView.DialogResult == System.Windows.Forms.DialogResult.OK
                            || confirmView.DialogResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            foreach (var ticket in tickets)
                            {
                                errorMsg = _ticketBusiness.Insert(ticket);
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        var ticket = CreateUpdateTicket(_ticketBusiness.Get(lblTicketId.Text));
                        errorMsg = _ticketBusiness.Update(ticket);
                    }
                }

                // print receipt
                if (string.IsNullOrEmpty(errorMsg) && confirmView.DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    var tour = _tourBusiness.Get(_tourId);
                    var bus = _busBusiness.Get(_busId);

                    Exporter<EntityObject> exporter = new Exporter<EntityObject>(Constants.PRINT_TICKET_RECIEPT, tickets, new List<EntityObject>() { tour }, new List<EntityObject>() { bus });
                    exporter.Run();
                }

                // output result
                if (string.IsNullOrEmpty(errorMsg))
                {
                    ShowInformationMessage(_isUpdating ? Constants.Messages.MSG_TICKET_UPDATE_TICKET_SUCCESS_MSG : Constants.Messages.MSG_TICKET_INSERT_TICKET_SUCCESS_MSG);
                    isSuccess = true;

                    LoadSeatMapData();
                    ChangeStatusControl(false);
                }
                else
                {
                    ShowErrorMessageBox(errorMsg);
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), Constants.Messages.MSG_TICKET_UPDATE_TICKET_EXCEPTION_MSG, ex);
                ShowErrorMessageBox(Constants.Messages.MSG_TICKET_UPDATE_TICKET_FAIL_MSG);
            }

            return isSuccess;
        }

        public override void HandleCancelTask()
        {
            ChangeStatusControl(false);

            ClearTicketInfo();
        }

        public override void HandleDelete()
        {
            try
            {
                if (CheckPermission())
                {
                    var ticket = _ticketBusiness.Get(lblTicketId.Text);
                    if (ticket == null)
                    {
                        ShowErrorMessageBox(Constants.Messages.MSG_TICKET_DELETE_TICKET_NOT_EXIST_MSG);
                        return;
                    }

                    decimal returnFee = _ticketReturnFeeConfigurationBusiness.GetReturnFee(ticket, DateTime.Now);

                    StringBuilder message = new StringBuilder();
                    message.Append(Constants.Messages.MSG_TICKET_DELETE_TICKET_CONFIRM_MSG);
                    if (returnFee > 0)
                    {
                        message.AppendLine("\r\n").AppendLine(string.Format(Constants.Messages.MSG_TICKET_RETURN_TICKET_FEE_MSG, CurrencyUtil.ToString(returnFee)));
                    }

                    if (MessageBox.Show(message.ToString(), Constants.Messages.INFO_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string result = string.Empty;
                        if (returnFee > 0)
                        {
                            result = _ticketBusiness.Cancel(ticket, returnFee);
                        }
                        else
                        {
                            result = _ticketBusiness.Delete(ticket);
                        }

                        if (string.IsNullOrEmpty(result))
                        {
                            ShowInformationMessage(Constants.Messages.MSG_TICKET_DELETE_TICKET_SUCCESS_MSG);
                        }
                        else
                        {
                            ShowErrorMessageBox(result);
                        }
                        LoadSeatMapData();
                    }
                }
                else
                {
                    ShowErrorMessageBox(Constants.Messages.MSG_TICKET_INSUFFICIENT_PERMISSION);
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), Constants.Messages.MSG_TICKET_DELETE_TICKET_EXCEPTION_MSG, ex);
                ShowErrorMessageBox(Constants.Messages.MSG_TICKET_DELETE_TICKET_FAIL_MSG);
            }
        }

        public override void HandlePrint()
        {
            try
            {
                var tour = _tourBusiness.Get(_tourId);
                var bus = _busBusiness.Get(_busId);
                var tickets = _ticketBusiness.GetAll(_busId, _tourId, Constants.TicketStatus.Paid, _departureTime);

                Exporter<EntityObject> exporter = new Exporter<EntityObject>(Constants.PRINT_BUS_TICKETS, tickets, new List<EntityObject>() { tour }, new List<EntityObject>() { bus });
                exporter.Run();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), Constants.Messages.MSG_TICKET_PRINT_TICKET_EXCEPTION_MSG, ex);
                ShowErrorMessageBox(Constants.Messages.MSG_TICKET_PRINT_TICKET_FAIL_MSG);
            }
        }
        #endregion

        #region Private Methods

        public void onSeatMapClick(string seatNumber, Constants.SeatClass seatClass, Ticket ticket)
        {
            if (_isEditStatus)
            {
                if (ticket == null)
                {
                    ChooseSeat(int.Parse(seatNumber));
                }
            }
            else
            {
                LoadCustomer(seatNumber, seatClass, ticket);
            }
        }

        public void ChooseSeat(int seatNumber)
        {
            ucSeatMap.SetEmpty(seatNumber);
            if (_selectedSeatNumbers.Remove(seatNumber) == false)
            {
                _selectedSeatNumbers.Add(seatNumber);
                ucSeatMap.SetSelected(seatNumber);
            }

            lblSeatNo.Text = _seatClass.ToString();
            foreach (int seatNo in _selectedSeatNumbers.OrderBy(i => i))
            {
                lblSeatNo.Text += seatNo.ToString() + ",";
            }

            lblSeatNo.Text = lblSeatNo.Text.Remove(lblSeatNo.Text.Length - 1);
        }

        public void LoadCustomer(string seatNumber, Constants.SeatClass seatClass, Ticket ticket)
        {
            ClearTicketInfo();
            lblPrice.Text = CurrencyUtil.ToString(GetPriceBySeatClass(_seatClass.ToString()));

            if (ticket != null)
            {
                SetValueToTicketControl(ticket);
                _isEmptySeat = false;
                _ticketUserId = ticket.user_id;
            }
            else
            {
                lblSeatNo.Text = seatClass + seatNumber;
                _isEmptySeat = true;
                _seatNumber = int.Parse(seatNumber);
                _ticketUserId = null;
            }
        }

        private void LoadSeatMapData()
        {
            ClearTicketInfo();

            _seatClass =
                rbtnUpperSeat.Checked ? Constants.SeatClass.B :
                rbtnLowerSeat.Checked ? Constants.SeatClass.A : Constants.SeatClass.S;
            _busId = cboBusName.SelectedValue.ToString();
            _tourId = cboTour.SelectedValue.ToString();
            _departureTime = dtDepartureTime.Value;

            ucSeatMap.InitSeatMap(_seatClass);
            var reservedTickets = new TicketBusiness().GetAll(_busId, _tourId, _seatClass.ToString(), _departureTime).ToList();
            ucSeatMap.LoadTicket(reservedTickets);

            lblPrice.Text = CurrencyUtil.ToString(GetPriceBySeatClass(_seatClass.ToString()));
            _isEmptySeat = false;
        }

        private void LoadBusCombobox()
        {
            var buses = _busBusiness.GetAll().ToList();
            cboBusName.DataSource = buses;
            cboBusName.DisplayMember = "name";
            cboBusName.ValueMember = "id";
        }

        private void LoadTourCombobox()
        {
            var tours = _tourBusiness.GetAll();
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

            cboTour.DataSource = tourTable;
            cboTour.DisplayMember = "name";
            cboTour.ValueMember = "id";
        }

        private Ticket CreateUpdateTicket(Ticket ticket = null, int seatNo = 0)
        {
            if (ticket == null)
            {
                ticket = new Ticket();
                ticket.id = IDGenerator.TicketId();
                ticket.bus_id = _busId;
                ticket.tour_id = _tourId;
                ticket.user_id = SystemParam.CurrentUser.id;
                ticket.cost = GetPriceBySeatClass(_seatClass.ToString());
                ticket.created_date = DateTime.Now;
                ticket.seat_class = _seatClass.ToString();
                ticket.seat_number = seatNo != 0 ? seatNo : _seatNumber;
                ticket.status = Constants.TicketStatus.Paid.ToString();

                ticket.departure_time = _ticketBusiness.GetDepartureDateTime(_departureTime);
            }
            ticket.passenger_id_card_no = tbIDCardNumber.Text.Trim();
            ticket.pickup_location = tbPickupLocation.Text.Trim();
            ticket.passenger_name = tbPassengerName.Text.Trim();
            ticket.phone = tbPhoneNumber.Text.Trim();

            return ticket;
        }

        private string ValidateData()
        {
            var errorMsg = string.Empty;
            if (string.IsNullOrEmpty(tbPassengerName.Text))
            {
                errorMsg = Constants.Messages.MSG_TICKET_NAME_ERROR_MSG;
            }
            else if (string.IsNullOrEmpty(tbIDCardNumber.Text) && string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                errorMsg = Constants.Messages.MSG_TICKET_ID_PHONE_ERROR_MSG;
            }
            else if (!string.IsNullOrEmpty(tbPhoneNumber.Text) && tbPhoneNumber.Text.Length > 20)
            {
                errorMsg = Constants.Messages.MSG_TICKET_PHONE_NUMBER_RANGE_ERROR_MSG;
            }

            if (_isUpdating == false && _selectedSeatNumbers.Count <= 0)
            {
                errorMsg = Constants.Messages.MSG_TICKET_SELECT_SEAT_REQUIRE;
            }
            return errorMsg;
        }

        private void SetValueToTicketControl(Ticket ticket)
        {
            lblTicketId.Text = ticket.id;
            tbPassengerName.Text = ticket.passenger_name.Trim();
            tbIDCardNumber.Text = ticket.passenger_id_card_no.Trim();
            tbPickupLocation.Text = ticket.pickup_location.Trim();
            tbPhoneNumber.Text = ticket.phone;
            lblSeatNo.Text = ticket.seat_class + ticket.seat_number.ToString(CultureInfo.InvariantCulture);
            lblPrice.Text = CurrencyUtil.ToString(GetPriceBySeatClass(_seatClass.ToString()));
            lblCreateBy.Text = ticket.user_id;
        }

        private decimal GetPriceBySeatClass(string seatClass)
        {
            var ticketPriceConfig = _ticketPriceConfigurationBusiness.GetBySeatClass(seatClass);
            if (ticketPriceConfig == null)
            {
                ShowErrorMessageBox(Constants.Messages.MSG_TICKET_INFO_TICKET_PRICE_CONFIG_NOT_FOUND_FOR_SEAT_CLASS);
                return 0;
            }
            return ticketPriceConfig.price;
        }

        private string ValidateBeforeSearch()
        {
            string errorMessage = string.Empty;
            DateTime departTime = _ticketBusiness.GetDepartureDateTime(dtDepartureTime.Value.Date);

            if (departTime < DateTime.Now)
            {
                errorMessage = Constants.Messages.MSG_TICKET_DATETIME_SMALLER_CURRENTDATE;
            }
            else
            {
                errorMessage = _ticketSaleDateBusiness.ValidateDateTime(dtDepartureTime.Value);
            }
            return errorMessage;
        }

        private void ClearTicketInfo()
        {
            tbIDCardNumber.Text = string.Empty;
            tbPassengerName.Text = string.Empty;
            tbPickupLocation.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            lblSeatNo.Text = string.Empty;
            lblTicketId.Text = string.Empty;
            lblCreateBy.Text = string.Empty;
            lblPrice.Text = string.Empty;

            _selectedSeatNumbers.ForEach(i => ucSeatMap.SetEmpty(i));

            _selectedSeatNumbers.Clear();
        }

        private void ChangeStatusControl(bool isEditing)
        {
            gbSeatType.Enabled = !isEditing;
            gbSearchInfo.Enabled = !isEditing;
            btnSearchSeat.Enabled = !isEditing;
            gbCustomerInfo.Enabled = isEditing;
            //ucSeatMap.Enabled = !isEditing;

            _isEditStatus = isEditing;
        }

        private void ShowInformationMessage(string msg)
        {
            MessageBox.Show(msg, Constants.Messages.INFO_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CheckPermission()
        {
            if (SystemParam.CurrentUser.id.Equals(_ticketUserId)
                || SystemParam.CurrentUser.role.Equals(Constants.UserRole.Supervisor.ToString())
                || SystemParam.CurrentUser.role.Equals(Constants.UserRole.Owner.ToString()))
            {
                return true;
            }
            return false;
        }
        #endregion

        #endregion
    }
}