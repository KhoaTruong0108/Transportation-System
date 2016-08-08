using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using Thrift.Protocol;
using TransportService;
using DBManagement;
using AppCommon;
using AppCommon.Constant;

namespace TransportService
{
    public class ThriftUtil
    {

        #region Convert to Thrift object
        public static TBase ConvertToThriftObject(EntityObject input)
        {
            if (input.GetType() == typeof(Configuration))
            {
                return ConvertToTConfiguration(input as Configuration);
            }
            else if (input.GetType() == typeof(Customer))
            {
                return ConvertToTCustomer(input as Customer);
            }
            else if (input.GetType() == typeof(RegularOrder))
            {
                return ConvertToTRegularOrder(input as RegularOrder);
            }
            else if (input.GetType() == typeof(IrregularOrder))
            {
                return ConvertToTIrregularOrder(input as IrregularOrder);
            }
            else if (input.GetType() == typeof(OrderItem))
            {
                return ConvertToTOrderItem(input as OrderItem);
            }
            else if (input.GetType() == typeof(TicketPriceConfiguration))
            {
                return ConvertToTTicketPrice(input as TicketPriceConfiguration);
            }
            else if (input.GetType() == typeof(TransportPriceConfiguration))
            {
                return ConvertToTTransportPrice(input as TransportPriceConfiguration);
            }
            else if (input.GetType() == typeof(TicketSaleDate))
            {
                return ConvertToTSaleTicketDate(input as TicketSaleDate);
            }
            else if (input.GetType() == typeof(Ticket))
            {
                return ConvertToTTicket(input as Ticket);
            }
            else if (input.GetType() == typeof(GuaranteeFeeConfiguration))
            {
                return ConvertToTGuaranteeFee(input as GuaranteeFeeConfiguration);
            }
            else if (input.GetType() == typeof(Bus))
            {
                return ConvertToTBus(input as Bus);
            }
            else if (input.GetType() == typeof(Tour))
            {
                return ConvertToTTour(input as Tour);
            }
            else if (input.GetType() == typeof(User))
            {
                return ConvertToTUser(input as User);
            }

            return null;
        }

        public static TOrder ConvertToTOrder(RegularOrder order)
        {
            TOrder torder = new TOrder();
            torder.OrderId = order.id;
            torder.CloseDate = order.closed_date.ToString();
            torder.CreateBy = order.created_by;
            torder.CreateDate = order.created_date.ToString();
            torder.OrderStaus = order.order_status;
            torder.PaymentStatus = order.payment_status;
            torder.RecipientId = order.recipient_id;
            torder.SenderId = order.sender_id;
            torder.TotalCost = double.Parse(order.total_cost.ToString());
            torder.TotalQuantity = order.total_quantity;
            torder.TotalValue = double.Parse(order.total_value.ToString());
            torder.Destination = order.tour_id;
            torder.Type = Constants.VALUE_ORDER_TYPE_REGULAR;

            return torder;
        }

        public static TOrder ConvertToTOrder(EntityObject order)
        {
            if (order.GetType() == typeof(RegularOrder))
            {
                return ConvertToTOrder(order as RegularOrder);
            }
            else if (order.GetType() == typeof(IrregularOrder))
            {
                return ConvertToTOrder(order as IrregularOrder);
            }
            return null;
        }

        public static TOrder ConvertToTOrder(IrregularOrder order)
        {
            TOrder torder = new TOrder();
            torder.OrderId = order.id;
            torder.CloseDate = order.closed_date.ToString();
            torder.CreateBy = order.created_by;
            torder.CreateDate = order.created_date.ToString();
            torder.OrderStaus = order.order_status;
            torder.PaymentStatus = order.payment_status;
            torder.RecipientIdNo = order.recipient_id_card_no;
            torder.RecipientName = order.recipient_name;
            torder.RecipientPhone = order.recipient_phone;
            torder.SenderIdNo = order.sender_id_card_no;
            torder.SenderName = order.sender_name;
            torder.SenderPhone = order.sender_phone;
            torder.TotalCost = double.Parse(order.total_cost.ToString());
            torder.TotalQuantity = order.total_quantity;
            torder.TotalValue = double.Parse(order.total_value.ToString());
            torder.Destination = order.tour_id;
            torder.Type = Constants.VALUE_ORDER_TYPE_IRREGULAR;

            return torder;
        }

        public static TRegularOrder ConvertToTRegularOrder(RegularOrder order, bool isDeleted)
        {
            TRegularOrder regular = ConvertToTRegularOrder(order);
            regular.IsDeleted = isDeleted;
            return regular;
        }
        public static TRegularOrder ConvertToTRegularOrder(RegularOrder order)
        {
            TRegularOrder torder = new TRegularOrder();
            torder.OrderId = order.id;
            torder.CloseDate = order.closed_date.ToString();
            torder.CreateBy = order.created_by;
            torder.CreateDate = order.created_date.ToString();
            torder.OrderStaus = order.order_status;
            torder.PaymentStatus = order.payment_status;
            torder.RecipientId = order.recipient_id;
            torder.SenderId = order.sender_id;
            torder.TotalCost = double.Parse(order.total_cost.ToString());
            torder.TotalQuantity = order.total_quantity;
            torder.TotalValue = double.Parse(order.total_value.ToString());
            torder.Destination = order.tour_id;

            return torder;
        }

        public static TIrregularOrder ConvertToTIrregularOrder(IrregularOrder order, bool isDeleted)
        {
            TIrregularOrder tirregular = ConvertToTIrregularOrder(order);
            tirregular.IsDeleted = isDeleted;
            return tirregular;
        }
        public static TIrregularOrder ConvertToTIrregularOrder(IrregularOrder order)
        {
            TIrregularOrder torder = new TIrregularOrder();
            torder.OrderId = order.id;
            torder.CloseDate = order.closed_date.ToString();
            torder.CreateBy = order.created_by;
            torder.CreateDate = order.created_date.ToString();
            torder.OrderStaus = order.order_status;
            torder.PaymentStatus = order.payment_status;
            torder.RecipientIdNo = order.recipient_id_card_no;
            torder.RecipientName = order.recipient_name;
            torder.RecipientPhone = order.recipient_phone;
            torder.SenderIdNo = order.sender_id_card_no;
            torder.SenderName = order.sender_name;
            torder.SenderPhone = order.sender_phone;
            torder.TotalCost = double.Parse(order.total_cost.ToString());
            torder.TotalQuantity = order.total_quantity;
            torder.TotalValue = double.Parse(order.total_value.ToString());
            torder.Destination = order.tour_id;

            return torder;
        }

        public static TOrderItem ConvertToTOrderItem(OrderItem item, bool isDeleted)
        {
            TOrderItem orderItem = ConvertToTOrderItem(item);
            orderItem.IsDeleted = isDeleted;
            return orderItem;
        }
        public static TOrderItem ConvertToTOrderItem(OrderItem item)
        {
            TOrderItem titem = new TOrderItem();
            titem.ItemId = item.id;
            titem.Cost = double.Parse(item.cost.ToString());
            titem.Description = item.description;
            titem.Name = item.name;
            titem.OrderId = item.order_id;
            titem.OrderItemNumber = item.order_item_number;
            titem.Quantity = item.quantity;
            titem.Size = item.size;
            titem.Value = double.Parse(item.value.ToString());
            titem.Weight = double.Parse(item.weight.ToString());

            return titem;
        }

        public static List<TOrderItem> ConvertToTOrderItemList(List<OrderItem> orderItems)
        {
            List<TOrderItem> torderItems = new List<TOrderItem>();
            foreach (OrderItem item in orderItems)
            {
                torderItems.Add(ConvertToTOrderItem(item));
            }
            return torderItems;
        }

        public static TTicket ConvertToTTicket(Ticket ticket, bool isDeleted)
        {
            var tticket = ConvertToTTicket(ticket);
            tticket.IsDeleted = isDeleted;
            return tticket;
        }
        public static TTicket ConvertToTTicket(Ticket ticket)
        {
            TTicket tticket = new TTicket();
            tticket.TicketId = ticket.id;
            tticket.BusId = ticket.bus_id;
            tticket.CusIdNo = ticket.passenger_id_card_no;
            tticket.CusName = ticket.passenger_name;
            tticket.CusPhone = ticket.phone;
            tticket.DepartTime = ticket.departure_time.ToString();
            tticket.SeatNo = ticket.seat_number;
            tticket.SeatType = ticket.seat_class;
            tticket.TicketPrice = double.Parse(ticket.cost.ToString());
            tticket.TourId = ticket.tour_id;
            tticket.UserId = ticket.user_id;
            tticket.Status = ticket.status;
            tticket.PickupLocation = ticket.pickup_location;

            return tticket;
        }

        public static TConfiguration ConvertToTConfiguration(Configuration config)
        {
            TConfiguration tconfig = new TConfiguration();
            tconfig.Id = config.id;
            tconfig.Description = config.description;
            tconfig.Name = config.name;
            tconfig.Value = config.value;

            return tconfig;
        }

        public static TCustomer ConvertToTCustomer(Customer customer)
        {
            TCustomer tcustomer = new TCustomer();
            tcustomer.CustomerId = customer.id;
            tcustomer.Address1 = customer.address1;
            tcustomer.Address2 = customer.address2;
            tcustomer.CompanyName = customer.company;
            tcustomer.CreatedBy = customer.created_by;
            tcustomer.CreatedDate = customer.created_date.ToString();
            tcustomer.IdCardNumber = customer.id_card_number;
            tcustomer.Mobile = customer.mobile;
            tcustomer.Name = customer.name;
            tcustomer.Phone = customer.phone;

            return tcustomer;
        }

        public static TTicketPrice ConvertToTTicketPrice(TicketPriceConfiguration price)
        {
            TTicketPrice tprice = new TTicketPrice();
            tprice.PriceId = price.id;
            tprice.Description = price.description;
            tprice.Price = double.Parse(price.price.ToString());
            tprice.SeatType = price.seat_class;

            return tprice;
        }

        public static TTransportPrice ConvertToTTransportPrice(TransportPriceConfiguration price)
        {
            TTransportPrice tprice = new TTransportPrice();
            tprice.PriceId = price.id;
            tprice.Size = price.size;
            tprice.WeightFrom = double.Parse(price.weight_from.ToString());
            tprice.WeightTo = double.Parse(price.weight_to.ToString());
            tprice.TransportPrice = double.Parse(price.transport_price.ToString());

            return tprice;
        }

        public static TSaleTicketDate ConvertToTSaleTicketDate(TicketSaleDate saleDate)
        {
            TSaleTicketDate tsaleDate = new TSaleTicketDate();
            tsaleDate.SaleId = saleDate.id;
            tsaleDate.BeforDay = saleDate.before_days;
            tsaleDate.SaleDay = saleDate.ticket_sale_day;
            tsaleDate.SaleMonth = saleDate.ticket_sale_month;
            tsaleDate.SaleYear = saleDate.ticket_sale_year;

            return tsaleDate;
        }

        public static TGuaranteeFee ConvertToTGuaranteeFee(GuaranteeFeeConfiguration fee)
        {
            TGuaranteeFee tprice = new TGuaranteeFee();
            tprice.Id = fee.id;
            tprice.Fee = double.Parse(fee.guarantee_fee.ToString());
            tprice.ValueFrom = double.Parse(fee.value_from.ToString());
            tprice.ValueTo = double.Parse(fee.value_to.ToString());

            return tprice;
        }

        public static TBus ConvertToTBus(Bus bus)
        {
            TBus tbus = new TBus();
            tbus.Id = bus.id;
            tbus.Name = bus.name;
            tbus.BedCount = int.Parse(bus.bed_count.ToString());
            tbus.SeatCount = int.Parse(bus.seat_count.ToString());
            tbus.SubBedCount = int.Parse(bus.sub_bed_count.ToString());
            tbus.SubSeatCount = int.Parse(bus.sub_seat_count.ToString());

            return tbus;
        }

        public static TTour ConvertToTTour(Tour tour)
        {
            TTour ttour = new TTour();
            ttour.Id = tour.id;
            ttour.Destination = tour.destination;
            ttour.Start = tour.start;
            ttour.TravelTime = int.Parse(tour.travel_time.ToString());

            return ttour;
        }

        public static TUser ConvertToTUser(User user)
        {
            TUser tuser = new TUser();
            tuser.Id = user.id;
            tuser.ActiveStatus = user.active_status;
            tuser.Deleted = user.deleted;
            tuser.Role = user.role;
            tuser.StaffId = user.staff_id;
            tuser.UserName = user.user_name;

            return tuser;
        }
        #endregion

        #region Convert to Entity object
        public static EntityObject ConvertToEntityObject(TBase input)
        {
            if (input.GetType() == typeof(TConfiguration))
            {
                return ConvertToConfiguration(input as TConfiguration);
            }
            else if (input.GetType() == typeof(TCustomer))
            {
                return ConvertToCustomer(input as TCustomer);
            }
            else if (input.GetType() == typeof(TOrder))
            {
                if ((input as TOrder).Type == Constants.VALUE_ORDER_TYPE_REGULAR)
                {
                    return ConvertToRegualrOrder(input as TOrder);
                }
                else
                {
                    return ConvertToIrregularOrder(input as TOrder);
                }
            }
            else if (input.GetType() == typeof(TRegularOrder))
            {
                return ConvertToRegualrOrder(input as TRegularOrder);
            }
            else if (input.GetType() == typeof(TIrregularOrder))
            {
                return ConvertToIrregularOrder(input as TIrregularOrder);
            }
            else if (input.GetType() == typeof(TOrderItem))
            {
                return ConvertToOrderItem(input as TOrderItem);
            }
            else if (input.GetType() == typeof(TTicketPrice))
            {
                return ConvertToPriceTicket(input as TTicketPrice);
            }
            else if (input.GetType() == typeof(TTransportPrice))
            {
                return ConvertToPriceTransport(input as TTransportPrice);
            }
            else if (input.GetType() == typeof(TSaleTicketDate))
            {
                return ConvertToSaleTicketDate(input as TSaleTicketDate);
            }
            else if (input.GetType() == typeof(TTicket))
            {
                return ConvertToTicket(input as TTicket);
            }
            else if (input.GetType() == typeof(TGuaranteeFee))
            {
                return ConvertToGuaranteeFee(input as TGuaranteeFee);
            }
            else if (input.GetType() == typeof(TBus))
            {
                return ConvertToBus(input as TBus);
            }
            else if (input.GetType() == typeof(TTour))
            {
                return ConvertToTour(input as TTour);
            }
            else if (input.GetType() == typeof(TUser))
            {
                return ConvertToUser(input as TUser);
            }

            return null;
        }

        public static RegularOrder ConvertToRegualrOrder(TOrder order)
        {
            RegularOrder regularOrder = new RegularOrder();

            DateTime tempDate;

            regularOrder.id = order.OrderId;
            regularOrder.created_by = order.CreateBy;
            regularOrder.closed_date = DateTime.TryParse(order.CloseDate, out tempDate) ? tempDate : (DateTime?)null;
            regularOrder.created_date = DateTime.Parse(order.CreateDate);
            regularOrder.order_status = order.OrderStaus;
            regularOrder.payment_status = order.PaymentStatus;
            regularOrder.recipient_id = order.RecipientId;
            regularOrder.sender_id = order.SenderId;
            regularOrder.tour_id = order.Destination;
            regularOrder.total_cost = decimal.Parse(order.TotalCost.ToString());
            regularOrder.total_quantity = order.TotalQuantity;
            regularOrder.total_value = decimal.Parse(order.TotalValue.ToString());

            return regularOrder;
        }

        public static IrregularOrder ConvertToIrregularOrder(TOrder order)
        {
            IrregularOrder irregularOrder = new IrregularOrder();

            DateTime tempDate;

            irregularOrder.id = order.OrderId;
            irregularOrder.created_by = order.CreateBy;
            irregularOrder.closed_date = DateTime.TryParse(order.CloseDate, out tempDate) ? tempDate : (DateTime?)null;
            irregularOrder.created_date = DateTime.Parse(order.CreateDate);
            irregularOrder.order_status = order.OrderStaus;
            irregularOrder.payment_status = order.PaymentStatus;
            irregularOrder.recipient_id_card_no = order.RecipientIdNo;
            irregularOrder.recipient_name = order.RecipientName;
            irregularOrder.recipient_phone = order.RecipientPhone;
            irregularOrder.recipient_address = string.Empty;
            irregularOrder.sender_id_card_no = order.SenderIdNo;
            irregularOrder.sender_name = order.SenderName;
            irregularOrder.sender_phone = order.SenderPhone;
            irregularOrder.sender_address = string.Empty;
            irregularOrder.total_cost = decimal.Parse(order.TotalCost.ToString()); ;
            irregularOrder.total_quantity = order.TotalQuantity;
            irregularOrder.total_value = decimal.Parse(order.TotalValue.ToString());
            irregularOrder.confirmation_user_id = string.Empty;
            irregularOrder.tour_id = order.Destination;

            return irregularOrder;
        }

        public static RegularOrder ConvertToRegualrOrder(TRegularOrder order)
        {
            RegularOrder regularOrder = new RegularOrder();

            DateTime tempDate;

            regularOrder.id = order.OrderId;
            regularOrder.created_by = order.CreateBy;
            regularOrder.closed_date = DateTime.TryParse(order.CloseDate, out tempDate) ? tempDate : (DateTime?)null;
            regularOrder.created_date = DateTime.Parse(order.CreateDate);
            regularOrder.order_status = order.OrderStaus;
            regularOrder.payment_status = order.PaymentStatus;
            regularOrder.recipient_id = order.RecipientId;
            regularOrder.sender_id = order.SenderId;
            regularOrder.total_cost = decimal.Parse(order.TotalCost.ToString());
            regularOrder.total_quantity = order.TotalQuantity;
            regularOrder.total_value = decimal.Parse(order.TotalValue.ToString());
            regularOrder.tour_id = order.Destination;

            return regularOrder;
        }

        public static IrregularOrder ConvertToIrregularOrder(TIrregularOrder order)
        {
            IrregularOrder irregularOrder = new IrregularOrder();

            DateTime tempDate;

            irregularOrder.id = order.OrderId;
            irregularOrder.created_by = order.CreateBy;
            irregularOrder.closed_date = DateTime.TryParse(order.CloseDate, out tempDate) ? tempDate : (DateTime?)null;
            irregularOrder.created_date = DateTime.Parse(order.CreateDate);
            irregularOrder.order_status = order.OrderStaus;
            irregularOrder.payment_status = order.PaymentStatus;
            irregularOrder.recipient_id_card_no = order.RecipientIdNo;
            irregularOrder.recipient_name = order.RecipientName;
            irregularOrder.recipient_phone = order.RecipientPhone;
            irregularOrder.recipient_address = string.Empty;
            irregularOrder.sender_id_card_no = order.SenderIdNo;
            irregularOrder.sender_name = order.SenderName;
            irregularOrder.sender_phone = order.SenderPhone;
            irregularOrder.sender_address = string.Empty;
            irregularOrder.total_cost = decimal.Parse(order.TotalCost.ToString()); ;
            irregularOrder.total_quantity = order.TotalQuantity;
            irregularOrder.total_value = decimal.Parse(order.TotalValue.ToString());
            irregularOrder.tour_id = order.Destination;
            irregularOrder.confirmation_user_id = string.Empty;

            return irregularOrder;
        }

        public static OrderItem ConvertToOrderItem(TOrderItem item)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.id = item.ItemId;
            orderItem.order_id = item.OrderId;
            orderItem.cost = decimal.Parse(item.Cost.ToString());
            orderItem.description = item.Description;
            orderItem.name = item.Name;
            orderItem.order_item_number = item.OrderItemNumber;
            orderItem.quantity = item.Quantity;
            orderItem.size = item.Size;
            orderItem.value = decimal.Parse(item.Value.ToString());
            orderItem.weight = item.Weight;

            return orderItem;
        }

        public static List<OrderItem> ConvertToOrderItemList(List<TOrderItem> torderItems)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (TOrderItem item in torderItems)
            {
                orderItems.Add(ConvertToOrderItem(item));
            }
            return orderItems;
        }

        public static Ticket ConvertToTicket(TTicket ticket)
        {
            Ticket newTicket = new Ticket();
            newTicket.id = ticket.TicketId;
            newTicket.bus_id = ticket.BusId;
            newTicket.tour_id = ticket.TourId;
            newTicket.user_id = ticket.UserId;
            newTicket.cost = decimal.Parse(ticket.TicketPrice.ToString());
            newTicket.departure_time = DateTime.Parse(ticket.DepartTime);
            newTicket.passenger_id_card_no = ticket.CusIdNo;
            newTicket.passenger_name = ticket.CusName;
            newTicket.phone = ticket.CusPhone;
            newTicket.seat_class = ticket.SeatType;
            newTicket.seat_number = ticket.SeatNo;
            newTicket.status = ticket.Status;
            newTicket.created_date = DateTime.Now;
            newTicket.pickup_location = ticket.PickupLocation;

            return newTicket;
        }

        public static Configuration ConvertToConfiguration(TConfiguration tconfig)
        {
            Configuration config = new Configuration();
            config.id = tconfig.Id;
            config.description = tconfig.Description;
            config.name = tconfig.Name;
            config.value = tconfig.Value;

            return config;
        }

        public static Customer ConvertToCustomer(TCustomer tcustomer)
        {
            Customer customer = new Customer();
            customer.id = tcustomer.CustomerId;
            customer.address1 = tcustomer.Address1;
            customer.address2 = tcustomer.Address2;
            customer.company = tcustomer.CompanyName;
            customer.created_by = tcustomer.CreatedBy;
            customer.created_date = DateTime.Parse(tcustomer.CreatedDate.ToString());
            customer.id_card_number = tcustomer.IdCardNumber;
            customer.mobile = tcustomer.Mobile;
            customer.name = tcustomer.Name;
            customer.phone = tcustomer.Phone;

            return customer;
        }

        public static TicketPriceConfiguration ConvertToPriceTicket(TTicketPrice tprice)
        {
            TicketPriceConfiguration price = new TicketPriceConfiguration();
            price.id = tprice.PriceId;
            price.description = tprice.Description;
            price.price = decimal.Parse(tprice.Price.ToString());
            price.seat_class = tprice.SeatType;

            return price;
        }

        public static TransportPriceConfiguration ConvertToPriceTransport(TTransportPrice tprice)
        {
            TransportPriceConfiguration price = new TransportPriceConfiguration();
            price.id = tprice.PriceId;
            price.size = tprice.Size;
            price.weight_from = tprice.WeightFrom;
            price.weight_to = tprice.WeightTo;
            price.transport_price = decimal.Parse(tprice.TransportPrice.ToString());

            return price;
        }

        public static TicketSaleDate ConvertToSaleTicketDate(TSaleTicketDate tsaleDate)
        {
            TicketSaleDate saleDate = new TicketSaleDate();
            saleDate.id = tsaleDate.SaleId;
            saleDate.before_days = tsaleDate.BeforDay;
            saleDate.ticket_sale_day = tsaleDate.SaleDay;
            saleDate.ticket_sale_month = tsaleDate.SaleMonth;
            saleDate.ticket_sale_year = tsaleDate.SaleYear;

            return saleDate;
        }

        public static GuaranteeFeeConfiguration ConvertToGuaranteeFee(TGuaranteeFee tfee)
        {
            GuaranteeFeeConfiguration price = new GuaranteeFeeConfiguration();
            price.id = tfee.Id;
            price.guarantee_fee = decimal.Parse(tfee.Fee.ToString());
            price.value_from = decimal.Parse(tfee.ValueFrom.ToString());
            price.value_to = decimal.Parse(tfee.ValueTo.ToString());

            return price;
        }

        public static Bus ConvertToBus(TBus tbus)
        {
            Bus bus = new Bus();
            bus.id = tbus.Id;
            bus.bed_count = tbus.BedCount;
            bus.name = tbus.Name;
            bus.seat_count = int.Parse(tbus.SeatCount.ToString());
            bus.sub_bed_count = tbus.SubBedCount;
            bus.sub_seat_count = tbus.SubSeatCount;

            return bus;
        }

        public static Tour ConvertToTour(TTour ttour)
        {
            Tour tour = new Tour();
            tour.id = ttour.Id;
            tour.destination = ttour.Destination;
            tour.start = ttour.Start;
            tour.travel_time = int.Parse(ttour.TravelTime.ToString());

            return tour;
        }

        public static User ConvertToUser(TUser tuser)
        {
            User user = new User();
            user.id = tuser.Id;
            user.active_status = tuser.ActiveStatus;
            user.deleted = tuser.Deleted;
            user.role = tuser.Role;
            user.staff_id = tuser.StaffId;
            user.user_name = tuser.UserName;

            return user;
        }
        #endregion

        //public static List<T> ConvertToThriftObjectList<E, T>(List<E> input)
        //    where E : EntityObject
        //    where T : TBase
        //{
        //    List<T> tobjectList = new List<T>();
        //    foreach (var obj in input)
        //    {
        //        tobjectList.Add((T)ConvertToThriftObject(obj));
        //    }

        //    return tobjectList;
        //}

        //public static List<E> ConvertToEntityObjectList<E, T>(List<T> input)
        //    where E : EntityObject
        //    where T : TBase
        //{
        //    List<E> eobjectList = new List<E>();
        //    foreach (var obj in input)
        //    {
        //        eobjectList.Add((E)ConvertToEntityObject(obj));
        //    }

        //    return eobjectList;
        //}
    }
}
