using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBManagement;

namespace Staff
{
    public class ClientRepository
    {
        public string _clientIp { get; set; }
        public string _clientPort { get; set; }

        public List<Configuration> _configurationData { get; set; }
        public List<Customer> _customerData { get; set; }
        public List<TicketPriceConfiguration> _priceTicketData { get; set; }
        public List<TransportPriceConfiguration> _priceTransportData { get; set; }
        public List<TicketSaleDate> _saleTicketDateData { get; set; }
        public List<Ticket> _ticketData { get; set; }
        public Dictionary<RegularOrder, List<OrderItem>> _regularOrderData { get; set; }
        public Dictionary<IrregularOrder, List<OrderItem>> _irregularOrderData { get; set; }
            
        private static ClientRepository _instance;
        public static ClientRepository GetInstance()
        {
            if (_instance == null)
                _instance = new ClientRepository();
            return _instance;
        }

        protected ClientRepository()
        {
            _configurationData = new List<Configuration>();
            _customerData = new List<Customer>();
            _saleTicketDateData = new List<TicketSaleDate>();
            _priceTicketData = new List<TicketPriceConfiguration>();
            _priceTransportData = new List<TransportPriceConfiguration>();
            _ticketData = new List<Ticket>();
            _regularOrderData = new Dictionary<RegularOrder, List<OrderItem>>();
            _irregularOrderData = new Dictionary<IrregularOrder, List<OrderItem>>();
        }
    }
}
