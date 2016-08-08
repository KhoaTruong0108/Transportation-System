using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportService
{
    public class ServiceHandler : TransportServer.Iface
    {
        #region delegate section
        public delegate TUser LoginDelegate(string userName, string password, string senderIP, string senderPort);
        public LoginDelegate _login;

        public delegate string LogoutDelegate(string userName, string senderIP, string senderPort);
        public LogoutDelegate _logout;

        public delegate TSystemConfig LoadSystemConfigDelegate();
        public LoadSystemConfigDelegate _loadSystemConfig;

        public delegate List<TTicket> LoadTicketsDelegate();
        public LoadTicketsDelegate _loadTickets;

        public delegate List<TCustomer> LoadCustomersDelegate();
        public LoadCustomersDelegate _loadCustomers;

        public delegate List<TRegularOrder> LoadRegularOrderDelegate();
        public LoadRegularOrderDelegate _loadRegularOrders;

        public delegate List<TIrregularOrder> LoadIrregularOrdersDelegate();
        public LoadIrregularOrdersDelegate _loadIrregularOrders;

        public delegate List<TOrderItem> LoadOrderItemsDelegate();
        public LoadOrderItemsDelegate _loadOrderItems;

        public delegate string InsertTicketDelegate(TTicket ticket, string userId);
        public InsertTicketDelegate _insertTicket;

        public delegate string CancelTicketDelegate(TTicket tiket, string userId);
        public CancelTicketDelegate _cancelTicket;

        public delegate string UpdateTicketDelegate(TTicket ticket, string userId);
        public UpdateTicketDelegate _updateTicket;

        public delegate string CreateOrderDelegate(TOrder order, List<TOrderItem> orderItem, string userId);
        public CreateOrderDelegate _createOrder;

        public delegate string UpdateOrderInfoDelegate(TOrder order, List<TOrderItem> orderItem, string userId);
        public UpdateOrderInfoDelegate _updateOrderInfo;

        public delegate string UpdateSingleOrderInfoDelegate(TOrder order, string userId);
        public UpdateSingleOrderInfoDelegate _updateSingleOrderInfo;

        public delegate string DeleteOrderDelegate(TOrder order, string userId);
        public DeleteOrderDelegate _deleteOrder;

        public delegate List<TTicket> SyncTicketsDelegate();
        public SyncTicketsDelegate _syncTickets;

        public delegate List<TRegularOrder> SyncRegularOrderDelegate();
        public SyncRegularOrderDelegate _syncRegularOrders;

        public delegate List<TIrregularOrder> SyncIrregularOrdersDelegate();
        public SyncIrregularOrdersDelegate _syncIrregularOrders;

        public delegate List<TOrderItem> SyncOrderItemsDelegate();
        public SyncOrderItemsDelegate _syncOrderItems;

        #endregion

        #region implement section
        public TUser Login(string userName, string password, string senderIP, string senderPort)
        {
            return _login(userName,password, senderIP, senderPort);
        }

        public string Logout(string userName, string senderIP, string senderPort)
        {
            return _logout(userName, senderIP, senderPort);
        }

        public TSystemConfig LoadSystemConfig()
        {
            return _loadSystemConfig();
        }

        public List<TTicket> LoadTickets()
        {
            return _loadTickets();
        }

        public List<TCustomer> LoadCustomers()
        {
            return _loadCustomers();
        }

        public List<TIrregularOrder> LoadIrregularOrders()
        {
            return _loadIrregularOrders();
        }

        public List<TRegularOrder> LoadRegularOrders()
        {
            return _loadRegularOrders();
        }

        public List<TOrderItem> LoadOrderItems()
        {
            return _loadOrderItems();
        }

        public string InsertTicket(TTicket ticket, string userId)
        {
            return _insertTicket(ticket, userId);
        }

        public string CancelTicket(TTicket tiket, string userId)
        {
            return _cancelTicket(tiket, userId);
        }

        public string UpdateTicket(TTicket ticket, string userId)
        {
            return _updateTicket(ticket, userId);
        }

        public string CreateOrder(TOrder order, List<TOrderItem> orderItem, string userId)
        {
            return _createOrder(order, orderItem, userId);
        }

        public string UpdateOrder(TOrder order, List<TOrderItem> orderItem, string userId)
        {
            return _updateOrderInfo(order, orderItem, userId);
        }

        public string UpdateSingleOrderInfo(TOrder order, string userId)
        {
            return _updateSingleOrderInfo(order, userId);
        }

        public string DeleteOrder(TOrder order, string userId)
        {
            return _deleteOrder(order, userId);
        }

        public List<TTicket> SyncTickets()
        {
            return _syncTickets();
        }

        public List<TIrregularOrder> SyncIrregularOrders()
        {
            return _syncIrregularOrders();
        }

        public List<TRegularOrder> SyncRegularOrders()
        {
            return _syncRegularOrders();
        }

        public List<TOrderItem> SyncOrderItems()
        {
            return _syncOrderItems();
        }
        #endregion
    }
}
