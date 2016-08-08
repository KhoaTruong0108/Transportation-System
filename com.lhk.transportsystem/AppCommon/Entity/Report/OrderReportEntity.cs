using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBManagement;

namespace AppCommon.Entity.Report
{
    public class OrderReportEntity
    {
        public string OrderId { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public string SenderIdNo { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPhone { get; set; }
        public string RecipientIdNo { get; set; }
        public string OrderStaus { get; set; }
        public string TotalCost { get; set; }
        public string TotalValue { get; set; }
        public string TotalQuantity { get; set; }

        public static OrderReportEntity ConvertFromReportEntity(IrregularOrder order)
        {
            return new OrderReportEntity()
            {
                OrderId = order.id,
                OrderStaus = order.order_status,
                RecipientIdNo = order.recipient_id_card_no,
                RecipientName = order.recipient_name,
                RecipientPhone = order.recipient_phone,
                SenderIdNo = order.sender_id_card_no,
                SenderName = order.sender_name,
                SenderPhone = order.sender_phone,
                TotalCost = Util.CurrencyUtil.ToString(order.total_cost),
                TotalQuantity = Util.CurrencyUtil.ToString(order.total_quantity),
                TotalValue = Util.CurrencyUtil.ToString(order.total_value)
            };
        }

        public static OrderReportEntity ConvertFromReportEntity(RegularOrder order, Customer recipient, Customer sender)
        {
            return new OrderReportEntity()
            {
                OrderId = order.id,
                OrderStaus = order.order_status,
                RecipientIdNo = recipient.id_card_number,
                RecipientName = recipient.name,
                RecipientPhone = recipient.phone,
                SenderIdNo = sender.id_card_number,
                SenderName = sender.name,
                SenderPhone = sender.phone,
                TotalCost = Util.CurrencyUtil.ToString(order.total_cost),
                TotalQuantity = Util.CurrencyUtil.ToString(order.total_quantity),
                TotalValue = Util.CurrencyUtil.ToString(order.total_value)
            };
        }
    }
}
