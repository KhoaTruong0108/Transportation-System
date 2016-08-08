using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using DBManagement;
using TransportService;
using AppCommon.Constant;
using AppCommon.Util;
using System.Data.SqlClient;
using System.Net;
using AppCommon.Business;
using System.Threading;
using System.Net.Sockets;

namespace MainServer
{
    public partial class ServerBusiness
    {

        #region Constructor
        protected static ServerBusiness _instance;
        public static ServerBusiness GetInstance()
        {
            if (_instance == null)
                _instance = new ServerBusiness();
            return _instance;
        }

        public MainServer serverView { get; set; }
        #endregion

        protected ServerBusiness()
        {

        }

        #region Init DB request
        public TUser Login(string userName, string password, string senderIP, string senderPort)
        {
            try
            {
                ServerLogger.logInfo("Login", string.Format("User login [{0}] - [{1}] - [{2}] - [{3}]", userName, password, senderIP, senderPort), serverView);
                using (UserBusiness business = new UserBusiness())
                {
                    //bool loginSuccess = business.Users.Any(u => u.user_name == userName && u.password == password && u.active_status && !u.deleted);
                    User user = business.ValidateUser(userName, password, Constants.UserRole.Staff.ToString());

                    if (user == null)
                    {
                        string failMessage = "Login Fail";
                        //if (user == null) failMessage = "Không tồn tại người dùng: " + userName;
                        //else if (user.password != password) failMessage = "Nhập sai mật khẩu";
                        //else if (user.active_status == false) failMessage = "Người dùng này đã bị khóa.";

                        ServerLogger.logInfo("Login", string.Format("login result: {0}", failMessage), serverView);
                        return new TUser();
                    }

                    AddClientStation(userName, senderIP, int.Parse(senderPort));

                    return ThriftUtil.ConvertToTUser(user);
                }

            }
            catch (Exception exc)
            {
                ServerLogger.logError("[Login]", exc);
                return new TUser();
            }
        }

        public string Logout(string userName, string senderIP, string senderPort)
        {
            try
            {
                ServerLogger.logInfo("Login", string.Format("User Logout [userName: {0}] - [Port: {1}]", userName, senderPort), serverView);

                ClientStation client = _clientList.FirstOrDefault(c => c.UserName == userName && c.IPAddress == senderIP && c.Port == int.Parse(senderPort));
                if (client != null)
                {
                    _clientList.Remove(client);
                    return "";
                }
                return "Người dùng này chưa được Đăng Nhập";
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[Logout]", exc);
                return exc.Message;
            }
        }

        /// <remarks>must get config follow each role</remarks>
        public TSystemConfig LoadSystemConfig()
        {
            try
            {
                TSystemConfig systemConfig = new TSystemConfig();

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    systemConfig.Configurations = context.Configurations.ToList().Select(i => ThriftUtil.ConvertToTConfiguration(i)).ToList();
                    systemConfig.SaleTicketDates = context.TicketSaleDates.ToList().Select(i => ThriftUtil.ConvertToTSaleTicketDate(i)).ToList();
                    systemConfig.TicketPrices = context.TicketPriceConfigurations.ToList().Select(i => ThriftUtil.ConvertToTTicketPrice(i)).ToList();
                    systemConfig.TransportPrices = context.TransportPriceConfigurations.ToList().Select(i => ThriftUtil.ConvertToTTransportPrice(i)).ToList();
                    systemConfig.GuaranteeFees = context.GuaranteeFeeConfigurations.ToList().Select(i => ThriftUtil.ConvertToTGuaranteeFee(i)).ToList();
                    systemConfig.Buses = context.Buses.ToList().Select(i => ThriftUtil.ConvertToTBus(i)).ToList();
                    systemConfig.Tours = context.Tours.ToList().Select(i => ThriftUtil.ConvertToTTour(i)).ToList();
                }

                return systemConfig;
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadSystemConfig]", exc);
                return new TSystemConfig();
            }
        }

        public List<TTicket> LoadTicket()
        {
            try
            {
                using (TicketBusiness business = new TicketBusiness())
                {
                    return business.GetAll().ToList()
                        .Where(i => i.departure_time >= DateTime.Now)
                        .Select(i => ThriftUtil.ConvertToTTicket(i)).ToList();
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadTicket]", exc);
                return new List<TTicket>();
            }
        }

        public List<TCustomer> LoadCustomer()
        {
            try
            {
                using (CustomerBusiness business = new CustomerBusiness())
                {
                    return business.GetAll().ToList().Select(i => ThriftUtil.ConvertToTCustomer(i)).ToList();
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadCustomer]", exc);
                return new List<TCustomer>();
            }
        }

        public List<TRegularOrder> LoadRegularOrder()
        {
            try
            {
                using (RegularOrderBusiness business = new RegularOrderBusiness())
                {
                    return business.GetAll().ToList().Select(i => ThriftUtil.ConvertToThriftObject(i) as TRegularOrder).ToList();
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadRegularOrder]", exc);
                return new List<TRegularOrder>();
            }
        }

        public List<TIrregularOrder> LoadIrregularOrder()
        {
            try
            {
                using (IrregularOrderBusiness business = new IrregularOrderBusiness())
                {
                    return business.GetAll().ToList().Select(i => ThriftUtil.ConvertToThriftObject(i) as TIrregularOrder).ToList();
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadIrregularOrder]", exc);
                return new List<TIrregularOrder>();
            }
        }

        public List<TOrderItem> LoadOrderItem()
        {
            try
            {
                using (OrderItemBusiness business = new OrderItemBusiness())
                {
                    return business.GetAll().ToList().Select(i => ThriftUtil.ConvertToThriftObject(i) as TOrderItem).ToList();
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadOrderItem]", exc);
                return new List<TOrderItem>();
            }

        }
        #endregion

        #region Sync Data
        public List<TTicket> SyncTicket()
        {
            try
            {
                IEnumerable<TicketHistory> changedTicketId;
                
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                using (TicketBusiness business = new TicketBusiness())
                {
                    changedTicketId = context.TicketHistories
                        .Where(i => i.changed_date.Year == DateTime.Now.Year && i.changed_date.Month == DateTime.Now.Month && i.changed_date.Day == DateTime.Now.Day)
                        .OrderBy(i => i.ticket_id).ThenBy(i => i.changed_date);

                    //insert/update records
                    var tickets = (from t in business.GetAll()
                                   join th in changedTicketId on t.id equals th.ticket_id
                                   where t.departure_time >= DateTime.Now
                                   select ThriftUtil.ConvertToTTicket(t, th.action == Constants.DELETE_ACTION)).ToList();

                    //deleted records
                    tickets.AddRange((from th in changedTicketId
                                      where th.action == Constants.DELETE_ACTION
                                      select new TTicket
                                      {
                                          TicketId = th.ticket_id,
                                          BusId = string.Empty,
                                          CusIdNo = string.Empty,
                                          CusName = string.Empty,
                                          CusPhone = string.Empty,
                                          DepartTime = DateTime.Now.ToString(),
                                          IsDeleted = true,
                                          SeatNo = 0,
                                          SeatType = string.Empty,
                                          Status = string.Empty,
                                          TicketPrice = 0,
                                          TourId = string.Empty,
                                          UserId = string.Empty
                                      }));

                    return tickets;
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadTicket]", exc);
                return new List<TTicket>();
            }
        }

        public List<TRegularOrder> SyncRegularOrder()
        {
            try
            {
                IEnumerable<OrderHistory> changedOrderIds;

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                using (RegularOrderBusiness business = new RegularOrderBusiness())
                {
                    //insert/update records
                    changedOrderIds = context.OrderHistories
                        .Where(i => i.date_time.Year == DateTime.Now.Year && i.date_time.Month == DateTime.Now.Month && i.date_time.Day == DateTime.Now.Day)
                        .OrderBy(i => i.order_id).ThenBy(i => i.date_time);

                    var orders = (from io in business.GetAll()
                                  join co in changedOrderIds on io.id equals co.order_id
                                  select ThriftUtil.ConvertToTRegularOrder(io, co.action == Constants.DELETE_ACTION)).ToList();

                    //deleted records
                    orders.AddRange((from o in changedOrderIds
                                     where o.action == Constants.DELETE_ACTION
                                     select new TRegularOrder()
                                     {
                                         OrderId = o.order_id,
                                         IsDeleted = true,
                                         CloseDate = DateTime.Now.ToString(),
                                         CreateBy = string.Empty,
                                         CreateDate = DateTime.Now.ToString(),
                                         Destination = string.Empty,
                                         OrderStaus = string.Empty,
                                         PaymentStatus = string.Empty,
                                         RecipientId = string.Empty,
                                         SenderId = string.Empty,
                                         TotalCost = 0,
                                         TotalQuantity = 0,
                                         TotalValue = 0,
                                     }));

                    return orders;
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadRegularOrder]", exc);
                return new List<TRegularOrder>();
            }
        }

        public List<TIrregularOrder> SyncIrregularOrder()
        {
            try
            {
                IEnumerable<OrderHistory> changedOrderIds;

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                using (IrregularOrderBusiness business = new IrregularOrderBusiness())
                {
                    //insert/update records
                    changedOrderIds = context.OrderHistories
                        .Where(i => i.date_time.Year == DateTime.Now.Year && i.date_time.Month == DateTime.Now.Month && i.date_time.Day == DateTime.Now.Day)
                        .OrderBy(i => i.order_id).ThenBy(i => i.date_time);

                    var orders = (from io in business.GetAll()
                                  join co in changedOrderIds on io.id equals co.order_id
                                  select ThriftUtil.ConvertToTIrregularOrder(io, co.action == Constants.DELETE_ACTION)).ToList();

                    //deleted records
                    orders.AddRange((from o in changedOrderIds
                                     where o.action == Constants.DELETE_ACTION
                                     select new TIrregularOrder()
                                     {
                                         OrderId = o.order_id,
                                         IsDeleted = true,
                                         CloseDate = DateTime.Now.ToString(),
                                         CreateBy = string.Empty,
                                         CreateDate = DateTime.Now.ToString(),
                                         Destination = string.Empty,
                                         OrderStaus = string.Empty,
                                         PaymentStatus = string.Empty,
                                         RecipientIdNo = string.Empty,
                                         RecipientName = string.Empty,
                                         RecipientPhone = string.Empty,
                                         SenderIdNo = string.Empty,
                                         SenderName = string.Empty,
                                         SenderPhone = string.Empty,
                                         UserReponsitory = string.Empty,
                                         TotalCost = 0,
                                         TotalQuantity = 0,
                                         TotalValue = 0,
                                     }));

                    return orders;
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[LoadIrregularOrder]", exc);
                return new List<TIrregularOrder>();
            }
        }

        public List<TOrderItem> SyncOrderItem()
        {
            try
            {
                IEnumerable<OrderHistory> changedOrderIds;

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                using (OrderItemBusiness business = new OrderItemBusiness())
                {
                    changedOrderIds = context.OrderHistories
                        .Where(i => i.date_time.Year == DateTime.Now.Year && i.date_time.Month == DateTime.Now.Month && i.date_time.Day == DateTime.Now.Day)
                        .OrderBy(i => i.order_id).ThenBy(i => i.date_time);

                    var orderItems = (from oi in business.GetAll()
                                      join co in changedOrderIds on oi.order_id equals co.order_id
                                      select ThriftUtil.ConvertToTOrderItem(oi, co.action == Constants.DELETE_ACTION)).ToList();

                    return orderItems;
                }
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[SyncOrderItem]", exc);
                return new List<TOrderItem>();
            }

        }
        #endregion

        #region Change data request
        protected string CheckTicketInfo(Ticket ticket)
        {
            StringBuilder errorMessage = new StringBuilder();

            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                if (context.Buses.Any(i => i.id == ticket.bus_id) == false)
                {
                    errorMessage.AppendLine(string.Format("Số xe không hợp lệ, mã xe:{0}", ticket.bus_id)).AppendLine("\r\n");
                }
                if ((ticket.seat_number <= Constants.VALUE_SEAT_NUMBER_MAX
                        && ticket.seat_number >= Constants.VALUE_SEAT_NUMBER_MIN)
                    && (ticket.seat_class == Constants.SeatClass.A.ToString()
                        || ticket.seat_class == Constants.SeatClass.B.ToString()
                        || ticket.seat_class == Constants.SeatClass.S.ToString()) == false)
                {
                    errorMessage.AppendLine(string.Format("Số ghế không hợp lệ, số ghế:{0} - loại:{1}", ticket.seat_number, ticket.seat_class)).AppendLine("\r\n");
                }
                if (ticket.departure_time < DateTime.Now)
                {
                    errorMessage.AppendLine(string.Format("Ngày đi không được nhỏ hơn ngày hiện tại, Ngày đi:{0}", ticket.departure_time)).AppendLine("\r\n");
                }
                if (context.Buses.Any(i => i.id == ticket.bus_id) == false)
                {
                    errorMessage.AppendLine(string.Format("Số xe không tồn tại, mã xe:{0}", ticket.bus_id));
                }

                TicketPriceConfigurationBusiness priceBusiness = new TicketPriceConfigurationBusiness();
                var priceConfig = priceBusiness.GetBySeatClass(ticket.seat_class);
                if (priceConfig.price != ticket.cost)
                {
                    errorMessage.AppendLine(string.Format("{0}Giá vé không phù hợp. Xin thử lại!", Constants.SERVER_ERROR_CODE_CONFIG_DATA_NOT_SYNC));
                }
            }

            return errorMessage.ToString();
        }

        public string InsertTicket(TTicket ticket, string userId)
        {
            try
            {
                //------------------------------------------------------------//
                // check a valid of Ticket
                //------------------------------------------------------------//
                TicketSaleDateBusiness saleDatebusines = new TicketSaleDateBusiness();
                Ticket newTicket = ThriftUtil.ConvertToEntityObject(ticket) as Ticket;

                string errorMessage = CheckTicketInfo(newTicket);
                errorMessage += saleDatebusines.ValidateDateTime(newTicket.departure_time);

                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    return errorMessage;
                }

                TicketBusiness business = new TicketBusiness();
                string resultMsg = business.Insert(newTicket);

                ////notify to the others client station
                //ticket.TicketId = ticketId;
                //BroadcastToClient(ClientAction.SellTicket,ticket);

                return resultMsg;
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[InsertTicket]", exc);
                return exc.Message;
            }
        }

        public string CancelTicket(TTicket tticket, string userId)
        {
            try
            {
                using(TicketReturnFeeConfigurationBusiness _ticketReturnFeeBusiness = new TicketReturnFeeConfigurationBusiness())
                using (TicketBusiness business = new TicketBusiness())
                {
                    Ticket cancelTicket = business.Get(tticket.TicketId);

                    if (cancelTicket == null)
                    {
                        return string.Format("{0} Vé không tồn tại, không thể hủy vé, Mã:{0}", Constants.SERVER_ERROR_CODE_SINGLE_DATA_NOT_SYNC, tticket.TicketId);
                    }

                    string result = string.Empty;
                    decimal returnFee = _ticketReturnFeeBusiness.GetReturnFee(cancelTicket, DateTime.Now);
                    if (returnFee > 0)
                    {
                        result = business.Cancel(cancelTicket, returnFee);
                    }
                    else
                    {
                        result = business.Delete(cancelTicket.id);
                    }
                    return result;
                }

                //notify to the others client station
                //BroadcastToClient(ClientAction.CancelTicket,tticket);

            }
            catch (Exception exc)
            {
                ServerLogger.logError("[CancelTicket]", exc);
                return exc.Message;
            }
        }

        public string UpdateTicket(TTicket tticket, string userId)
        {
            try
            {
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    DateTime departTime = DateTime.Parse(tticket.DepartTime);
                    var existedTicket = context.Tickets.FirstOrDefault(t => t.bus_id == tticket.BusId
                                                        && t.departure_time == departTime
                                                        && t.seat_number == tticket.SeatNo
                                                        && t.seat_class == tticket.SeatType
                                                        && t.tour_id == tticket.TourId);

                    if (existedTicket == null || (existedTicket != null && existedTicket.status == Constants.TicketStatus.Cancel.ToString()))
                    {
                        return Constants.SERVER_ERROR_CODE_SINGLE_DATA_NOT_SYNC + " Vé đã bị xóa!";
                    }
                }

                if (CheckUserPermission(userId, tticket.UserId) == false)
                {
                    return Constants.Messages.MSG_TICKET_INSUFFICIENT_PERMISSION;
                }

                TicketBusiness business = new TicketBusiness();
                Ticket ticket = ThriftUtil.ConvertToEntityObject(tticket) as Ticket;
                string resultMsg = business.Update(ticket);

                //notify to the others client station
                //BroadcastToClient(ClientAction.UpdateTicket,ticket);

                return resultMsg;
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[UpdateTicket]", exc);
                return exc.Message;
            }
        }

        protected bool CheckUserPermission(string excuteUserId, string objectUserId)
        {
            using (UserBusiness userBusiness = new UserBusiness())
            {
                var user = userBusiness.Repository.EntitiesSet.SingleOrDefault(i => i.id == excuteUserId);

                if (excuteUserId == objectUserId)
                {
                    return true;
                }
                else if (user != null && (user.role == Constants.UserRole.Owner.ToString() || user.role == Constants.UserRole.Supervisor.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        protected string CheckOrder(TOrder torder, bool isUpdated = false)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (isUpdated)
            {
                EntityObject existOrder = null;
                if (torder.Type == Constants.VALUE_ORDER_TYPE_IRREGULAR)
                {
                    existOrder = new IrregularOrderBusiness().Get(torder.OrderId);
                }
                else
                {
                    existOrder = new RegularOrderBusiness().Get(torder.OrderId);
                }

                if (existOrder == null)
                {
                    errorMessage.AppendLine(string.Format("{0}Hóa đơn vận chuyển không tồn tại", Constants.SERVER_ERROR_CODE_SINGLE_DATA_NOT_SYNC));
                }
            }

            return errorMessage.ToString();
        }

        public string CheckOrderItems(List<OrderItem> orderItems)
        {
            StringBuilder errorMessage = new StringBuilder();
            foreach (var item in orderItems)
            {
                if (orderItems.Count == 0)
                {
                    errorMessage.AppendLine("Không có thông tin hàng hóa");
                }


                //Check transport price
                GuaranteeFeeConfigurationBusiness guaranteeBusiness = new GuaranteeFeeConfigurationBusiness();
                var guaranteeConfig = guaranteeBusiness.GetAll().FirstOrDefault(e => item.value >= e.value_from && item.value < e.value_to);
                TransportPriceConfigurationBusiness priceBusiness = new TransportPriceConfigurationBusiness();
                var transportPriceConfig = priceBusiness.GetAll().FirstOrDefault(e => e.size.Equals(item.size) && item.weight >= e.weight_from && item.weight < e.weight_to);

                decimal guaranteeFee = guaranteeConfig != null ? guaranteeConfig.guarantee_fee : 0;
                decimal transportPrice = transportPriceConfig != null ? transportPriceConfig.transport_price : 0;
                decimal totalPrice = transportPrice * item.quantity;

                if (transportPriceConfig != null && item.cost != guaranteeFee + totalPrice)
                {
                    errorMessage.AppendLine(string.Format("{0} Giá hàng hóa không phù hợp với quy định. Tên hàng: {1}",Constants.SERVER_ERROR_CODE_CONFIG_DATA_NOT_SYNC,item.name));
                }

            }

            return errorMessage.ToString();
        }

        public string CreateOrder(TOrder torder, List<TOrderItem> torderItems, string userId)
        {
            try
            {
                //Check Order
                string errorMessage = CheckOrder(torder);

                //check OrderItem
                List<OrderItem> orderItems = ThriftUtil.ConvertToOrderItemList(torderItems);
                errorMessage += CheckOrderItems(orderItems);

                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    return errorMessage;
                }

                string orderId = string.Empty;
                //Insert Order
                if (torder.Type == Constants.VALUE_ORDER_TYPE_REGULAR)
                {
                    using (RegularOrderBusiness business = new RegularOrderBusiness())
                    {
                        business.Insert(ThriftUtil.ConvertToRegualrOrder(torder));
                    }
                }
                else
                {
                    using (IrregularOrderBusiness business = new IrregularOrderBusiness())
                    {
                        business.Insert(ThriftUtil.ConvertToIrregularOrder(torder));
                    }
                }

                using (OrderItemBusiness business = new OrderItemBusiness())
                {
                    business.Insert(orderItems);
                }

                //notify to the others client station
                //torder.OrderId = orderId;
                //BroadcastToClient(ClientAction.CreateOrder,order,orderItems);

                return "";
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[CreateOrder]", exc);
                return exc.Message;
            }
        }

        public string UpdateOrderInfo(TOrder torder, List<TOrderItem> orderItems, string userId)
        {
            try
            {
                //Check Order
                string errorMessage = CheckOrder(torder, true);

                //check OrderItem
                errorMessage += orderItems.Count == 0 ? "Không có thông tin hàng hóa" : "";

                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    return errorMessage;
                }

                if (torder.Type == Constants.VALUE_ORDER_TYPE_REGULAR)
                {
                    using (RegularOrderBusiness business = new RegularOrderBusiness())
                    {
                        business.Update(ThriftUtil.ConvertToEntityObject(torder) as RegularOrder);
                    }
                }
                else
                {
                    using (IrregularOrderBusiness business = new IrregularOrderBusiness())
                    {
                        business.Update(ThriftUtil.ConvertToEntityObject(torder) as IrregularOrder);
                    }
                }

                using (OrderItemBusiness business = new OrderItemBusiness())
                {
                    business.DeleteByOrderId(torder.OrderId);

                    business.Insert(ThriftUtil.ConvertToOrderItemList(orderItems).Cast<OrderItem>());
                }

                //notify to the others client station
                //BroadcastToClient(ClientAction.UpdateOrder,order,orderItems);

                return "";
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[UpdateOrderInfo]", exc);
                return exc.Message;
            }
        }

        public string UpdateSingleOrderInfo(TOrder torder, string userId)
        {
            try
            {
                //Check Order
                string errorMessage = CheckOrder(torder, true);

                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    return errorMessage;
                }

                if (torder.Type == Constants.VALUE_ORDER_TYPE_REGULAR)
                {
                    using (RegularOrderBusiness business = new RegularOrderBusiness())
                    {
                        business.Update(ThriftUtil.ConvertToEntityObject(torder) as RegularOrder);
                    }
                }
                else
                {
                    using (IrregularOrderBusiness business = new IrregularOrderBusiness())
                    {
                        business.Update(ThriftUtil.ConvertToEntityObject(torder) as IrregularOrder);
                    }
                }

                //notify to the others client station
                //BroadcastToClient(ClientAction.UpdateOrder,order,orderItems);

                return "";
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[UpdateSingleOrderInfo]", exc);
                return exc.Message;
            }
        }

        /// <summary>
        /// CompleteOrder (just using for Irregular Order)
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public string DeleteOrder(TOrder order, string userId)
        {
            try
            {
                // Check Order
                string errorMessage = CheckOrder(order, true);

                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    return errorMessage;
                }

                // Delete
                if (order.Type == Constants.VALUE_ORDER_TYPE_REGULAR)
                {
                    RegularOrderBusiness business = new RegularOrderBusiness();
                    business.Delete(order.OrderId);
                }
                else
                {
                    IrregularOrderBusiness business = new IrregularOrderBusiness();
                    business.Delete(order.OrderId);
                }

                OrderItemBusiness itemBusiness = new OrderItemBusiness();
                itemBusiness.DeleteByOrderId(order.OrderId);

                ////notify to the others client station
                ////BroadcastToClient(ClientAction.CompleteOrder,order);

                return "";
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[DeleteOrder]", exc);
                return exc.Message;
            }
        }
        #endregion

        #region Util method
        public string GetInternalIp()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        public string GetExtenalIp()
        {
            IPAddress address = null;

            string extenalIP = ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_GET_IP_ADDRESS);

            if (string.IsNullOrEmpty(extenalIP)) return string.Empty;

            address = Utility.IpAddressUtil.GetExternalAddress(extenalIP);
            if (address == null)
            {
                return string.Empty;
            }
            else
            {
                return address.ToString();
            }
        }
        #endregion
    }
}
