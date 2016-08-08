using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBManagement;

namespace AppCommon.Entity
{
    public class OrderItemReportEntity
    {
        public string ItemId { get; set; }
        public string OrderId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public string Size { get; set; }
        public double Weight { get; set; }
        public decimal Cost { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPhone { get; set; }
        public string RecipientIdNo { get; set; }

        public static OrderItemReportEntity ConvertFromReportEntity(OrderItem item, IrregularOrder order)
        {
            var reportEntity = ConvertFromReportEntity(item);
            reportEntity.RecipientIdNo = order.recipient_id_card_no;
            reportEntity.RecipientName = order.recipient_name;
            reportEntity.RecipientPhone = order.recipient_phone;

            return reportEntity;
        }

        public static OrderItemReportEntity ConvertFromReportEntity(OrderItem item, RegularOrder order, RegularCustomer recipent)
        {
            var reportEntity = ConvertFromReportEntity(item);
            reportEntity.RecipientIdNo = recipent.id_card_number;
            reportEntity.RecipientName = recipent.name;
            reportEntity.RecipientPhone = recipent.phone_number;

            return reportEntity;
        }

        protected static OrderItemReportEntity ConvertFromReportEntity(OrderItem item)
        {
            return new OrderItemReportEntity()
            {
                Cost = item.cost,
                ItemId = item.id,
                Name = item.name,
                Quantity = item.quantity,
                Size = item.size,
                Value= item.value,
                Weight= item.weight
            };
        }
    }
}
