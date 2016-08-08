using System;
using System.Globalization;
using System.Linq;
using AppCommon.CommonView;
using DBManagement;
using AppCommon.Util;
using System.Collections.Generic;
using AppCommon.Business;

namespace AppCommon.Travel.SaleTicket
{
    public partial class TicketPaymentView : GenericView
    {
        //public delegate void SellTicketDelegate(Ticket ticket);
        //public SellTicketDelegate SellTicket;

        public List<Ticket> ConfirmTickets
        {
            get;
            set;
        }

        public TicketPaymentView()
        {
            InitializeComponent();
            btnSell.Click += new EventHandler(btnSell_Click);
            btnSellAndPrintReceipt.Click += new EventHandler(btnSellAndPrintReceipt_Click);
            tbPaidAmount.TextChanged += new EventHandler(tbPaidAmount_TextChanged);
            tbPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumberOnlyTextBox_KeyPress);
        }

        private void tbPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPaidAmount.Text))
            {
                tbPaymentChange.Text = CurrencyUtil.ToString((CurrencyUtil.ToDecimal(tbPaidAmount.Text) - CurrencyUtil.ToDecimal(tbTotalPayment.Text)));
                btnSellAndPrintReceipt.Enabled = CurrencyUtil.ToDecimal(tbPaidAmount.Text) >= CurrencyUtil.ToDecimal(tbTotalPayment.Text);
                btnSell.Enabled = CurrencyUtil.ToDecimal(tbPaidAmount.Text) >= CurrencyUtil.ToDecimal(tbTotalPayment.Text);

                CurrencyTextBox_TextChanged(sender, e);
            }
            else
            {
                tbPaymentChange.Text = "0";
            }

        }

        private void btnSellAndPrintReceipt_Click(object sender, EventArgs e)
        {
            //SellTicket(ConfirmTicket);
            //if (CurrencyUtil.ToDecimal(tbPaidAmount.Text) > CurrencyUtil.ToDecimal(tbTotalPayment.Text))
            //{
            //    this.Close();
            //}
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //SellTicket(ConfirmTicket);
            //if (CurrencyUtil.ToDecimal(tbPaidAmount.Text) > CurrencyUtil.ToDecimal(tbTotalPayment.Text))
            //{
            //    this.Close();
            //}
        }

        public void BindData()
        {
            Ticket firstTicket = ConfirmTickets.FirstOrDefault();

            if (firstTicket != null)
            {
                Bus bus = new BusBusiness().Get(firstTicket.bus_id);
                lblBusNameText.Text = bus == null ? string.Empty : bus.id; 
                lblIDCardNumberText.Text = firstTicket.passenger_id_card_no;
                lblPassengerNameText.Text = firstTicket.passenger_name;
                lblPhoneNumberText.Text = firstTicket.phone;
                lblDepartureDateText.Text = String.Format("{0:d/M/yyyy}", firstTicket.departure_time);
            }

            lblSeatNameText.Text = firstTicket.seat_class;
            foreach (var ticket in ConfirmTickets.OrderBy(i => i.seat_number))
            {
                lblSeatNameText.Text += ticket.seat_number + ",";
            }
            lblSeatNameText.Text = lblSeatNameText.Text.Remove(lblSeatNameText.Text.Length - 1);

            tbTotalPayment.Text = CurrencyUtil.ToString(ConfirmTickets.Sum(i=>i.cost));
        }

        private void TicketPaymentView_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
