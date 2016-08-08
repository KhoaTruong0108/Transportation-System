﻿//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : TransportSystem
//  @ File Name : Contansts.cs
//  @ Date : 12/17/2013
//  @ Author : khoatd
//
//

namespace AppCommon.Constant
{
    public class Constants : DBManagement.Constant.Constants
    {
        public static string VALUE_ORDER_TYPE_IRREGULAR = "IRREGULAR";
        public static string VALUE_ORDER_TYPE_REGULAR = "REGULAR";
        public const decimal MAX_MONEY_VALUE = (decimal)1e+12 - 1; // 999,999,999,999
        public const double MAX_WEIGHT_VALUE = 1.79e+308;

        public static double AUTOLOAD_TIMER_INTERVAL = 30000;
        public static double AUTOSENDMAIL_TIMER_INTERVAL = 3600000;

        public static string PRINT_BUS_TICKETS = "AppCommon.Report.BusTickets.rdlc";
        public static string PRINT_TICKET_RECIEPT = "AppCommon.Report.TicketReciept.rdlc";

        public enum Layer
        {
            Floor = 0,
            Lower = 1,
            Upper = 2
        }

        public enum SeatClass
        {
            S,
            A,
            B
        }

        /// <summary> Using for Config data: Ticket price, order price, ... </summary>
        public static string SERVER_ERROR_CODE_CONFIG_DATA_NOT_SYNC = "ERROR_SYNC_001";
        /// <summary> Using for single table. Ex: ticket, regular order, OrderItem,... </summary>
        public static string SERVER_ERROR_CODE_SINGLE_DATA_NOT_SYNC = "ERROR_SYNC_002";

        public static class Messages
        {
            #region COMMON

            public const string CONFIRMATION_CAPTION = "Xác nhận";
            public const string CONFIRMATION_ACTION_CONFIRM = "Chấp nhận?";
            public const string ERROR_CAPTION = "Lỗi";
            public const string ERROR_OPERATION_NOT_PERFORMED = "Có lỗi xảy ra. Không thể thực hiện yêu cầu.";
            public const string INFO_CAPTION = "Thông báo";
            public const string WARNING_CAPTION = "Cảnh báo";

            #endregion

            #region LOGIN FORM

            public const string BLANK_USERNAME_ALERT = "Tên người dùng không được trống.";
            public const string BLANK_PASSWORD_ALERT = "Mật khẩu không được trống.";
            public const string INVALID_USERNAME_OR_PASSWORD = "* Tên Người Dùng hoặc Mật Khẩu không chính xác.";
            public const string INVALID_USER_ROLE = "Hệ thống không được thiết lập đúng với quyền người dùng.";

            #endregion

            #region ITEMS LIST

            public const string ITEM_DELETE_CONFIRMATION_CAPTION = "Xác nhận";
            public const string ITEM_DELETE_CONFIRMATION_MESSAGE = "Bạn có chắc chắn muốn xóa món hàng này?";

            #endregion

            #region ORDER

            public const string CREATE_ORDER_CONFIRMATION_CAPTION = "Xác nhận hóa đơn";
            public const string CREATE_ORDER_CONFIRMATION_MESSAGE = "Bạn có chắc rằng muốn lập hóa đơn mới?";

            public const string CREATE_ORDER_ERROR_MESSAGE =
                "Có lỗi xảy ra trong khi tạo đơn hàng. Không thể tạo đơn hàng.";

            public const string UPDATE_ORDER_ERROR_MESSAGE =
                "Có lỗi xảy ra trong khi cập nhật đơn hàng. Không thể cập nhật đơn hàng.";

            public const string DELETE_ORDER_ERROR_MESSAGE =
                "Có lỗi xảy ra trong khi hủy đơn hàng. Không thể hủy đơn hàng.";

            #endregion

            #region TICKET
            public const string MSG_TICKET_INSUFFICIENT_PERMISSION = "Không có quyền xử lý vé này!";
            public const string MSG_TICKET_BEFORE_DATETIME_ERROR_MSG = "Ngày bán vé không hợp lệ. Hãy chọn ngày nhỏ hơn!";
            public const string MSG_TICKET_DATETIME_SMALLER_CURRENTDATE = "Ngày đặt vé không nhỏ hơn ngày hiện tại";
            public const string MSG_TICKET_NAME_ERROR_MSG = "Họ Tên không được rỗng.";
            public const string MSG_TICKET_ID_PHONE_ERROR_MSG = "Phải nhập chứng minh nhân dân hoặc số điện thoại.";
            public const string MSG_TICKET_PHONE_NUMBER_RANGE_ERROR_MSG = "Số điện thoại không hơn 11 số";
            public const string MSG_TICKET_SELECT_SEAT_REQUIRE = "Chọn 1 hoặc nhiều ghế trước khi tạo vé";
            public const string MSG_TICKET_TICKET_EXIST_ERROR_MSG = "Vé đã tồn tại. Vui lòng nhấn cập nhật để thay đổi thông tin.";
            public const string MSG_TICKET_INFO_TICKET_PRICE_CONFIG_NOT_FOUND_FOR_SEAT_CLASS = "Không có thiết lập giá vé cho hạng ghế này.";
            public const string MSG_TICKET_SEAT_NOT_AVAILABLE = "Ghế đã được mua hoặc chuyến xe này đã hoàn thành. Vui lòng chọn ghế khác.";

            public const string MSG_TICKET_TICKET_NOT_EXIST_MSG = "Vé chưa tồn tại. Vui lòng thêm mới vé này.";
            public const string MSG_TICKET_DELETE_TICKET_NOT_EXIST_MSG = "Vé chưa tồn tại nên không thể hủy.";
            public const string MSG_TICKET_DELETE_TICKET_CONFIRM_MSG = "Bạn có chắc muốn hủy vé này?";
            public const string MSG_TICKET_INSERT_TICKET_EXCEPTION_MSG = "Error occurs when Create New Ticket.";
            public const string MSG_TICKET_UPDATE_TICKET_EXCEPTION_MSG = "Error occurs when Update Ticket.";
            public const string MSG_TICKET_DELETE_TICKET_EXCEPTION_MSG = "Error occurs when Delete Ticket.";
            public const string MSG_TICKET_PRINT_TICKET_EXCEPTION_MSG = "Error occurs when Print Ticket.";

            public const string MSG_TICKET_INSERT_TICKET_FAIL_MSG = "Thêm vé không thành công.";
            public const string MSG_TICKET_INSERT_TICKET_SUCCESS_MSG = "Thêm vé thành công.";
            public const string MSG_TICKET_UPDATE_TICKET_FAIL_MSG = "Cập nhật vé không thành công.";
            public const string MSG_TICKET_UPDATE_TICKET_SUCCESS_MSG = "Cập nhật vé thành công.";
            public const string MSG_TICKET_DELETE_TICKET_SUCCESS_MSG = "Hủy vé thành công.";
            public const string MSG_TICKET_DELETE_TICKET_FAIL_MSG = "Hủy vé không thành công.";
            public const string MSG_TICKET_PRINT_TICKET_FAIL_MSG = "In vé không thành công.";
            public const string MSG_TICKET_RETURN_TICKET_FEE_MSG = "(Sẽ mất {0}VND phí hủy vé.)";
            #endregion
        }
    }
}
