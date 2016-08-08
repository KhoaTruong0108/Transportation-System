using System;
using System.ComponentModel;
using System.Text;

namespace DBManagement.Constant
{
    public class Constants
    {
        public static string FIELD_CONFIGURATION_GET_IP_ADDRESS = "GET_IP_ADDRESS";
        public static string FIELD_CONFIGURATION_DEPARTURE_HOUR = "DEPARTURE_HOUR";
        public static string FIELD_CONFIGURATION_DEPARTURE_MINUTE = "DEPARTURE_MINUTE";
        public static string FIELD_CONFIGURATION_MAINTAINER_EMAIL_ADDRESS_FROM = "MAINTAINER_EMAIL_ADDRESS_FROM";
        public static string FIELD_CONFIGURATION_MAINTAINER_EMAIL_ADDRESS_PASS = "MAINTAINER_EMAIL_ADDRESS_PASS";
        public static string FIELD_CONFIGURATION_MAINTAINER_EMAIL_ADDRESS_TO = "MAINTAINER_EMAIL_ADDRESS_TO";
        public static string FIELD_CONFIGURATION_SEND_MAINTENANCE_MAIL_HOUR = "SEND_MAINTENANCE_MAIL_HOUR";

        public static int DEFAULT_VALUE_DEPARTURE_HOUR = 16;
        public static int DEFAULT_VALUE_DEPARTURE_MINUTE = 0;

        public static string INSERT_ACTION = "INSERT";
        public static string UPDATE_ACTION = "UPDATE";
        public static string INSERT_UPDATE_ACTION = "INSERT OR UPDATE";
        public static string DELETE_ACTION = "DELETE";

        //------------------------------------------------------------//
        // ORDER
        //------------------------------------------------------------//
        public enum DeliveryStatus
        {
            [Description("Đang chờ")]
            Waiting,
            [Description("Đang chuyển")]
            Delivering,
            [Description("Đã tới")]
            Arrived,
            [Description("Đã giao")]
            Delivered,
            [Description("Hoàn thành")]
            Closed
        }

        public enum PaymentStatus
        {
            [Description("Chưa thanh toán")]
            Unpaid,
            [Description("Đã thanh toán")]
            Paid
        }

        //------------------------------------------------------------//
        // TICKET
        //------------------------------------------------------------//
        public enum TicketStatus
        {
            [Description("Đã thanh toán")]
            Paid,
            [Description("Đã hủy")]
            Cancel,
            [Description("Đã quyết toán")]
            Closed
        }

        public enum TicketHistoryAction
        {
            [Description("Tạo mới")]
            Insert,
            [Description("Đã hủy")]
            Delete,
            [Description("Cập nhật")]
            Update
        }

        //------------------------------------------------------------//
        // BUS - SEAT
        //------------------------------------------------------------//
        public static int VALUE_SEAT_NUMBER_MIN = 1;
        public static int VALUE_SEAT_NUMBER_MAX = 15;

        //------------------------------------------------------------//
        // USER
        //------------------------------------------------------------//
        public enum UserRole
        {
            [Description("Chủ doanh nghiệp")]
            Owner,
            [Description("Quản lý")]
            Supervisor,
            [Description("Nhân viên")]
            Staff
        }

        //------------------------------------------------------------//
        // FINANCIAL
        //------------------------------------------------------------//
        public enum RevenueType
        {
            [Description("Bán vé")]
            Ticket,
            [Description("Hóa đơn lẻ")]
            IrregularOrder,
            [Description("Hóa đơn sĩ")]
            RegularOrder,
            [Description("Điều chỉnh")]
            Adjustment,
            [Description("Khác")]
            Other
        }
    }
}
