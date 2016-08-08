using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Data.Objects.DataClasses;
using AppCommon.Util;
using DBManagement;
using Thrift.Server;
using Thrift.Transport;
using Thrift.Protocol;
using Staff;
using System.Windows.Forms;

namespace TransportService
{
    public class ServerConnector
    {
        protected TServer _server = null;
        protected Thread _serverThread = null;
        protected string _serverIP = "127.0.0.1";
        protected int _serverPort = 3030;

        protected TSocket _socket = null;
        protected TBufferedTransport _transport = null;
        protected TProtocol _protocol = null;
        protected TransportServer.Client _targetServer = null;

        public bool IsConnected { get { return _transport.IsOpen; } }

        public delegate void ServerDisconnectCallBack();
        private ServerDisconnectCallBack _disconnectCallBack;

        public ServerDisconnectCallBack DisconnectCallBack
        {
            get { return _disconnectCallBack; }
            set { _disconnectCallBack = value; }
        }


        private static ServerConnector _instance;
        public static ServerConnector GetInstance()
        {
            if (_instance == null || (_instance != null && _instance.IsOutOfDateConfig()))
            {
                _instance = new ServerConnector();
            }
            if (_instance.IsConnected == false)
            {
                _instance.OpenTransaction();
            }

            return _instance;
        }

        protected ServerConnector()
        {
            ConfigUtil.GetServerAddress(out _serverIP, out _serverPort);

            IsRunLocal = _serverIP == null;

            _socket = new TSocket(_serverIP, _serverPort);
            _transport = new TBufferedTransport(_socket);
            _protocol = new TBinaryProtocol(_transport);
            _targetServer = new TransportServer.Client(_protocol);

        }

        public bool IsOutOfDateConfig()
        {
            string ip;
            int port;
            ConfigUtil.GetServerAddress(out ip, out port);

            return ip != _serverIP || port != _serverPort;
        }

        ~ServerConnector()
        {
            CloseTransaction();
        }

        public string OpenTransaction()
        {
            try
            {
                if (_transport == null)
                {
                    return string.Format("Cannot open Transaction to Client - IP: {0} / Port {1}", _serverIP, _serverPort);
                }

                if (_transport.IsOpen == false && _socket.IsOpen == false)
                {
                    _transport.Open();
                }
                return "";
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} Login", exc);

                if (_disconnectCallBack != null)
                {
                    _disconnectCallBack();
                }
                return exc.Message;
            }
        }

        public string CloseTransaction()
        {
            if (_transport != null && _transport.IsOpen)
            {
                _transport.Close();
            }
            return string.Empty;
        }

        public TUser Login(string userName, string password, string senderIP, string senderPort)
        {
            try
            {
                //OpenTransaction();
                TUser tuser = _targetServer.Login(userName, password, senderIP, senderPort);
                //CloseTransaction();

                return tuser;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} Login", exc);
                return new TUser();
            }
        }

        public string LogOut(string userName, string senderIP, string senderPort)
        {
            //OpenTransaction();
            string errorMessage = _targetServer.Logout(userName, senderIP, senderPort);
            //CloseTransaction();

            return errorMessage;
        }

        #region init system

        public TSystemConfig LoadSystemConfigRequest()
        {
            try
            {
                //OpenTransaction();
                TSystemConfig saleTicketDates = _targetServer.LoadSystemConfig();
                //CloseTransaction();

                return saleTicketDates;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadSystemConfigRequest", exc);
                return new TSystemConfig();
            }
        }

        public List<TTicket> LoadTicketRequest()
        {
            try
            {
                //OpenTransaction();
                List<TTicket> saleTicketDates = _targetServer.LoadTickets();
                //CloseTransaction();

                return saleTicketDates;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadTicketRequest", exc);
                return new List<TTicket>();
            }
        }

        public List<TCustomer> LoadCustomerRequest()
        {
            try
            {
                //OpenTransaction();
                List<TCustomer> customers = _targetServer.LoadCustomers();
                //CloseTransaction();

                return customers;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadCustomerRequest", exc);
                return new List<TCustomer>();
            }
        }

        public List<TRegularOrder> LoadRegularOrderRequest()
        {
            try
            {
                //OpenTransaction();
                List<TRegularOrder> torderDatas = _targetServer.LoadRegularOrders();
                //CloseTransaction();

                return torderDatas;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadRegularOrderRequest", exc);
                return new List<TRegularOrder>();
            }
        }

        public List<TIrregularOrder> LoadIrregularOrderRequest()
        {
            try
            {
                //OpenTransaction();
                List<TIrregularOrder> torderDatas = _targetServer.LoadIrregularOrders();
                //CloseTransaction();

                return torderDatas;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadIrregularOrderRequest", exc);
                return new List<TIrregularOrder>();
            }
        }

        public List<TOrderItem> LoadOrderItemRequest()
        {
            try
            {
                //OpenTransaction();
                List<TOrderItem> torderDatas = _targetServer.LoadOrderItems();
                //CloseTransaction();

                return torderDatas;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadOrderItemRequest", exc);
                return new List<TOrderItem>();
            }
        }

        public List<TTicket> SyncTicketRequest()
        {
            try
            {
                //OpenTransaction();
                List<TTicket> saleTicketDates = _targetServer.SyncTickets();
                //CloseTransaction();

                return saleTicketDates;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadTicketRequest", exc);
                return new List<TTicket>();
            }
        }

        public List<TRegularOrder> SyncRegularOrderRequest()
        {
            try
            {
                //OpenTransaction();
                List<TRegularOrder> torderDatas = _targetServer.SyncRegularOrders();
                //CloseTransaction();

                return torderDatas;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadRegularOrderRequest", exc);
                return new List<TRegularOrder>();
            }
        }

        public List<TIrregularOrder> SyncIrregularOrderRequest()
        {
            try
            {
                //OpenTransaction();
                List<TIrregularOrder> torderDatas = _targetServer.SyncIrregularOrders();
                //CloseTransaction();

                return torderDatas;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadIrregularOrderRequest", exc);
                return new List<TIrregularOrder>();
            }
        }

        public List<TOrderItem> SyncOrderItemRequest()
        {
            try
            {
                //OpenTransaction();
                List<TOrderItem> torderDatas = _targetServer.SyncOrderItems();
                //CloseTransaction();

                return torderDatas;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} LoadOrderItemRequest", exc);
                return new List<TOrderItem>();
            }
        }
        #endregion

        #region Ticket
        public string InsertTicketRequest(Ticket ticketInput)
        {
            try
            {
                TTicket tticket = ThriftUtil.ConvertToThriftObject(ticketInput) as TTicket;

                //OpenTransaction();
                string errorMessage = _targetServer.InsertTicket(tticket, SystemParam.CurrentUser.id);
                //CloseTransaction();

                return errorMessage;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} InsertTicketRequest", exc);
                return exc.Message;
            }
        }

        public string UpdateTicketRequest(Ticket ticketInput)
        {
            try
            {
                TTicket tticket = ThriftUtil.ConvertToThriftObject(ticketInput) as TTicket;

                //OpenTransaction();
                string errorMessage = _targetServer.UpdateTicket(tticket, SystemParam.CurrentUser.id);
                //CloseTransaction();

                return errorMessage;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} UpdateTicketRequest", exc);
                return exc.Message;
            }
        }

        public string CancelTicketRequest(Ticket ticketInput)
        {
            try
            {
                TTicket tticket = ThriftUtil.ConvertToThriftObject(ticketInput) as TTicket;

                //OpenTransaction();
                string errorMessage = _targetServer.CancelTicket(tticket, SystemParam.CurrentUser.id);
                //CloseTransaction();

                return errorMessage;
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} CancelTicketRequest", exc);
                return exc.Message;
            }
        }
        #endregion

        #region Order
        public string CreateOrderRequest(EntityObject order, List<OrderItem> orderItems)
        {
            try
            {
                TOrder torder = ThriftUtil.ConvertToTOrder(order);

                List<TOrderItem> torderItems = ThriftUtil.ConvertToTOrderItemList(orderItems);

                //OpenTransaction();
                return _targetServer.CreateOrder(torder, torderItems, SystemParam.CurrentUser.id);
                //CloseTransaction();
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} CreateOrderRequest", exc);
                return exc.Message;
            }
        }

        public string UpdateOrderInfoRequest(EntityObject order, List<OrderItem> orderItems)
        {
            try
            {
                TOrder torder = ThriftUtil.ConvertToTOrder(order);
                List<TOrderItem> torderItems = ThriftUtil.ConvertToTOrderItemList(orderItems);

                //OpenTransaction();
                return _targetServer.UpdateOrder(torder, torderItems, SystemParam.CurrentUser.id);
                //CloseTransaction();
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} UpdateOrderInfoRequest", exc);
                return exc.Message;
            }
        }

        public string UpdateSingleOrderInfoRequest(EntityObject order)
        {
            try
            {
                TOrder torder = ThriftUtil.ConvertToTOrder(order);

                return _targetServer.UpdateSingleOrderInfo(torder, SystemParam.CurrentUser.id);
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} UpdateOrderInfoRequest", exc);
                return exc.Message;
            }
        }

        public string DeleteOrderInfoRequest(EntityObject order)
        {
            try
            {
                TOrder torder = ThriftUtil.ConvertToTOrder(order);

                //OpenTransaction();
                return _targetServer.DeleteOrder(torder, SystemParam.CurrentUser.id);
                //CloseTransaction();
            }
            catch (Exception exc)
            {
                AppLogger.logError("{REQUEST-ERROR} DeleteOrderInfoRequest", exc);
                return exc.Message;
            }
        }
        #endregion

        public bool IsRunLocal { get; set; }
    }
}
