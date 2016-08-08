using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportService
{
    public class ClientHandler : TransportClient.Iface
    {


        public bool CheckConnection(string checkCode)
        {
            throw new NotImplementedException();
        }

        public string ReloadSystemSetting(List<TConfiguration> configurations)
        {
            throw new NotImplementedException();
        }

        public string ReloadSaleTicketDate(List<TSaleTicketDate> saleDates)
        {
            throw new NotImplementedException();
        }

        public string ReloadTicketPrice(List<TPriceTicket> priceTickets)
        {
            throw new NotImplementedException();
        }

        public string ReloadTransportPrice(List<TPriceTransport> priceTranportes)
        {
            throw new NotImplementedException();
        }

        public string ReloadTicketLoading(List<TTicket> tickets)
        {
            throw new NotImplementedException();
        }

        public string ReloadCustomerLoading(List<TCustomer> customers)
        {
            throw new NotImplementedException();
        }

        public string ReloadOrderLoading(List<TOrder> ordres, List<TOrderItem> orderItems)
        {
            throw new NotImplementedException();
        }

        public string CreateNewTicket(TTicket ticket)
        {
            throw new NotImplementedException();
        }

        public string CancelTicket(TTicket ticket)
        {
            throw new NotImplementedException();
        }

        public string UpdateTicket(TTicket ticket)
        {
            throw new NotImplementedException();
        }

        public string CreateTransportOrder(TOrder order, List<TOrderItem> orderItems)
        {
            throw new NotImplementedException();
        }

        public string UpdateOrderInfo(TOrder order, List<TOrderItem> orderItems)
        {
            throw new NotImplementedException();
        }

        public string CompleteOrder(TOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
