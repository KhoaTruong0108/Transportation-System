using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCommon.Travel.SaleTicket;
using Staff.Business;

namespace Staff.View
{
    public class SaleTicketViewClient : SaleTicketView
    {
        public SaleTicketViewClient()
        {
            _ticketBusiness = new TicketBusinessClient();
        }
    }
}
