using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBManagement
{
    public class SqlCommands
    {
        public static string ORDER_DELETE_ORDER_ITEMS_BY_ORDER_ID = "DELETE OrderItem WHERE order_id = @order_id";

        public static string QUERY_DELETE_ALL_CONFIGURATION = "DELETE Configuration";
        public static string QUERY_DELETE_ALL_SALE_TICKET_DATE = "DELETE TicketSaleDate";
        public static string QUERY_DELETE_ALL_TICKET_PRICE = "DELETE TicketPriceConfiguration";
        public static string QUERY_DELETE_ALL_TRANSPORT_PRICE = "DELETE TransportPriceConfiguration";
        public static string QUERY_DELETE_ALL_GUARANTEE_FEE = "DELETE GuaranteeFeeConfiguration";
        public static string QUERY_DELETE_ALL_BUS = "DELETE Bus";
        public static string QUERY_DELETE_ALL_TOUR = "DELETE Tour";
        public static string QUERY_DELETE_ALL_TICKET = "DELETE Ticket";
        public static string QUERY_DELETE_ALL_CUSTOMER = "DELETE Customer";
        public static string QUERY_DELETE_ALL_IRREGULAR_ORDER = "DELETE IrregularOrder";
        public static string QUERY_DELETE_ALL_REGULAR_ORDER = "DELETE RegularOrder";
        public static string QUERY_DELETE_ALL_ORDER_ITEMS = "DELETE OrderItem";
    }
}
