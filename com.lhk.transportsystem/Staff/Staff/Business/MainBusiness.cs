using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using DBManagement;
using TransportService;
using AppCommon.Util;
using AppCommon.Constant;
using Thrift.Protocol;
using AppCommon.CommonRepository;
using System.Threading;
using AppCommon.CommonView;
using System.Windows.Forms;
using System.ComponentModel;
using AppCommon.Business;

namespace Staff
{

    public class MainBusiness
    {
        private WaitingBox _waitingBox;

        #region BackGroundWorker
        public void StartWorker()
        {
            _waitingBox = new WaitingBox();
            _waitingBox.Show();
            Application.DoEvents();
        }

        private void StopWorker()
        {
            _waitingBox.Close();
        }

        #endregion

        #region Init DB
        public string InitData()//(Object callback)
        {
            StringBuilder errorMessage = new StringBuilder();

            //InitDataCallBack cbFunction = callback as InitDataCallBack;

            StartWorker();

            if (ServerConnector.GetInstance().IsConnected == false
                && string.IsNullOrEmpty(ServerConnector.GetInstance().OpenTransaction()) == false)
                return string.Empty;

            errorMessage.Append(InitSystemConfig());
            errorMessage.Append(InitTickets());
            errorMessage.Append(InitCustomers());
            errorMessage.Append(InitIrregularOrders());
            errorMessage.Append(InitRegularOrders());
            errorMessage.Append(InitOrderItems());

            StopWorker();

            return errorMessage.ToString();
            //cbFunction(errorMessage.ToString());
        }

        protected string ClearConfigData()
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_BUS);
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_CONFIGURATION);
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_GUARANTEE_FEE);
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_SALE_TICKET_DATE);
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_TICKET_PRICE);
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_TOUR);
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_TRANSPORT_PRICE);
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("ClearData", exc);
                return exc.Message;
            }
            return errorMessage.ToString();
        }

        public string InitSystemConfig()
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                ClearConfigData();

                TSystemConfig systemConfigs = ServerConnector.GetInstance().LoadSystemConfigRequest();

                //bus
                AppLogger.logInfo("InitSystemConfig", "[Buses]");
                errorMessage.Append(InsertObject<TBus, Bus>(systemConfigs.Buses));
                //Configurations
                AppLogger.logInfo("InitSystemConfig", "[Configurations]");
                errorMessage.Append(InsertObject<TConfiguration, Configuration>(systemConfigs.Configurations));
                //GuaranteeFees
                AppLogger.logInfo("InitSystemConfig", "[GuaranteeFees]");
                errorMessage.Append(InsertObject<TGuaranteeFee, GuaranteeFeeConfiguration>(systemConfigs.GuaranteeFees));
                //SaleTicketDates
                AppLogger.logInfo("InitSystemConfig", "[SaleTicketDates]");
                errorMessage.Append(InsertObject<TSaleTicketDate, TicketSaleDate>(systemConfigs.SaleTicketDates));
                //TicketPrices
                AppLogger.logInfo("InitSystemConfig", "[TicketPrices]");
                errorMessage.Append(InsertObject<TTicketPrice, TicketPriceConfiguration>(systemConfigs.TicketPrices));
                //Tours
                AppLogger.logInfo("InitSystemConfig", "[Tours]");
                errorMessage.Append(InsertObject<TTour, Tour>(systemConfigs.Tours));
                //TransportPrices
                AppLogger.logInfo("InitSystemConfig", "[TransportPrices]");
                errorMessage.Append(InsertObject<TTransportPrice, TransportPriceConfiguration>(systemConfigs.TransportPrices));

            }
            catch (Exception exc)
            {
                AppLogger.logError("InitSystemConfig", exc);
                return exc.Message;
            }
            return errorMessage.ToString();
        }

        public string InitTickets()
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_TICKET);
                }
                List<TTicket> ttickets = ServerConnector.GetInstance().LoadTicketRequest();

                //TTicket
                AppLogger.logInfo("InitTickets", "[ttickets]");
                errorMessage = InsertObject<TTicket, Ticket>(ttickets);
            }
            catch (Exception exc)
            {
                AppLogger.logError("InitTickets", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string InitCustomers()
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_CUSTOMER);
                }
                List<TCustomer> tcustomers = ServerConnector.GetInstance().LoadCustomerRequest();

                //TCustomer
                AppLogger.logInfo("InitCustomers", "[TCustomer]");
                errorMessage = InsertObject<TCustomer, Customer>(tcustomers);
            }
            catch (Exception exc)
            {
                AppLogger.logError("InitCustomers", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string InitIrregularOrders()
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_IRREGULAR_ORDER);
                }

                List<TIrregularOrder> tirregular = ServerConnector.GetInstance().LoadIrregularOrderRequest();

                //TransportPrices
                AppLogger.logInfo("InitIrregularOrders", "[TIrregularOrder]");
                errorMessage = InsertObject<TIrregularOrder, IrregularOrder>(tirregular);
            }
            catch (Exception exc)
            {
                AppLogger.logError("InitIrregularOrders", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string InitRegularOrders()
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_REGULAR_ORDER);
                }

                List<TRegularOrder> tregular = ServerConnector.GetInstance().LoadRegularOrderRequest();

                //TransportPrices
                AppLogger.logInfo("InitRegularOrders", "[TRegularOrder]");
                errorMessage = InsertObject<TRegularOrder, RegularOrder>(tregular);
            }
            catch (Exception exc)
            {
                AppLogger.logError("InitRegularOrders", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string InitOrderItems()
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    context.ExecuteStoreCommand(SqlCommands.QUERY_DELETE_ALL_ORDER_ITEMS);
                }

                List<TOrderItem> torderitem = ServerConnector.GetInstance().LoadOrderItemRequest();

                //TOrderItem
                AppLogger.logInfo("InitOrderItems", "[TOrderItem]");
                errorMessage = InsertObject<TOrderItem, OrderItem>(torderitem);
            }
            catch (Exception exc)
            {
                AppLogger.logError("InitOrderItems", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        protected string InsertObject<T, E>(List<T> TObjectList)
            where T : TBase
            where E : EntityObject
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    var objectSet = context.CreateObjectSet<E>();
                    foreach (var tobj in TObjectList)
                    {
                        objectSet.AddObject((E)ThriftUtil.ConvertToEntityObject(tobj));
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("InsertObject", exc);
                return exc.Message;
            }
            return errorMessage;
        }
        #endregion

        #region Sync Data
        public string SyncCommonData()
        {
            StringBuilder errorMessage = new StringBuilder();

            errorMessage.Append(SyncTickets());
            errorMessage.Append(SyncIrregularOrders());
            errorMessage.Append(SyncRegularOrders());
            errorMessage.Append(SyncOrderItems());

            return errorMessage.ToString();
        }

        public string SyncTickets()
        {
            string errorMessage = string.Empty;
            try
            {
                List<TTicket> ttickets = ServerConnector.GetInstance().SyncTicketRequest();

                //TTicket
                AppLogger.logInfo("SyncTickets", "[ttickets]");
                errorMessage = SyncObject<TTicket, Ticket>(ttickets);
            }
            catch (Exception exc)
            {
                AppLogger.logError("SyncTickets", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string SyncIrregularOrders()
        {
            string errorMessage = string.Empty;
            try
            {
                List<TIrregularOrder> tirregular = ServerConnector.GetInstance().SyncIrregularOrderRequest();

                //TransportPrices
                AppLogger.logInfo("SyncIrregularOrders", "[TIrregularOrder]");
                errorMessage = SyncObject<TIrregularOrder, IrregularOrder>(tirregular);
            }
            catch (Exception exc)
            {
                AppLogger.logError("SyncIrregularOrders", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string SyncRegularOrders()
        {
            string errorMessage = string.Empty;
            try
            {
                List<TRegularOrder> tregular = ServerConnector.GetInstance().SyncRegularOrderRequest();

                //TransportPrices
                AppLogger.logInfo("SyncRegularOrders", "[TRegularOrder]");
                errorMessage = SyncObject<TRegularOrder, RegularOrder>(tregular);
            }
            catch (Exception exc)
            {
                AppLogger.logError("SyncRegularOrders", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        public string SyncOrderItems()
        {
            string errorMessage = string.Empty;
            try
            {
                List<TOrderItem> torderitem = ServerConnector.GetInstance().SyncOrderItemRequest();

                using (OrderItemBusiness business = new OrderItemBusiness())
                {
                    foreach(var item in torderitem)
                    {
                        business.DeleteByOrderId(item.OrderId);
                    }
                }

                //TOrderItem
                AppLogger.logInfo("SyncOrderItems", "[TOrderItem]");
                errorMessage = SyncObject<TOrderItem, OrderItem>(torderitem);
            }
            catch (Exception exc)
            {
                AppLogger.logError("SyncOrderItems", exc);
                return exc.Message;
            }
            return errorMessage;
        }

        protected string SyncObject<T, E>(List<T> TObjectList)
            where T : TBase
            where E : EntityObject
        {
            string errorMessage = string.Empty;
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    var objectSet = context.CreateObjectSet<E>();

                    foreach (var tobj in TObjectList)
                    {

                        E changeObj = (E)ThriftUtil.ConvertToEntityObject(tobj);
                        string id = typeof(E).GetProperty("id").GetValue(changeObj, null).ToString();
                        bool isDeleted = bool.Parse(typeof(T).GetProperty("IsDeleted").GetValue(tobj, null).ToString());

                        E existedEntity = objectSet.ToList().FirstOrDefault(e => typeof(E).GetProperty("id").GetValue(e, null).ToString().Equals(id));
                        if (existedEntity != null)
                        {
                            objectSet.DeleteObject(existedEntity);
                        }

                        if (isDeleted == false)
                        {
                            objectSet.AddObject(changeObj);
                        }

                        context.SaveChanges();
                    }
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("SyncObject", exc);
                return exc.Message;
            }
            return errorMessage;
        }
        #endregion
    }
}
