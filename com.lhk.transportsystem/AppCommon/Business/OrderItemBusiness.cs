using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class OrderItemBusiness : GenericBusiness<OrderItem>
    {
        public OrderItemBusiness()
            : base()
        { }

        public virtual Collection<OrderItem> GetByOrderId(string orderId)
        {
            Collection<OrderItem> items = new Collection<OrderItem>();
            AppLogger.logInfo(this.ToString(), string.Format("Begin getting order items by order id [{0}].", orderId));
            try
            {
                items = new Collection<OrderItem>(Repository.Find(item => item.order_id.Equals(orderId)).ToList());
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            AppLogger.logInfo(this.ToString(), string.Format("Finish getting order items by order id [{0}]. Items count: {1}.", orderId, items.Count));
            return items;
        }

        public virtual string DeleteByOrderId(string orderId)
        {
            string result = string.Empty;
            AppLogger.logInfo(this.ToString(), string.Format("Begin deleting order items. Order Id: {0}.", orderId));
            if (!string.IsNullOrEmpty(orderId))
            {
                try
                {
                    this.Repository.ExecuteCommand(SqlCommands.ORDER_DELETE_ORDER_ITEMS_BY_ORDER_ID, new SqlParameter("@order_id", orderId));
                    this.Repository.Commit();
                    AppLogger.logInfo(this.ToString(), "Deleted order items successfully.");
                }
                catch (Exception ex)
                {
                    AppLogger.logError(this.ToString(), "Error occurs when deleting order items.", ex);
                    result = Constant.Constants.Messages.ERROR_CAPTION;
                }
            }
            AppLogger.logInfo(this.ToString(), "Finish deleting order items.");
            return result;
        }
    }
}
