using System;
using System.Collections.ObjectModel;
using System.Data;
using AppCommon.CommonBusiness;
using AppCommon.CommonRepository;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class RegularOrderBusiness : GenericBusiness<RegularOrder>, IOrderBusiness<RegularOrder>
    {
        private GenericRepository<OrderHistory> _orderHistoryRepository;
        private GenericRepository<OrderHistoryDetail> _orderHistoryDetailRepository;

        public RegularOrderBusiness(User currentUser = null)
            : base(currentUser)
        {
            UseAuditTrail = true;
        }

        /// <summary>
        /// Changes the order status.
        /// </summary>
        /// <param name="id">The order id.</param>
        /// <param name="deliveryStatus">The delivery status.</param>
        /// <returns><c>string.Empty</c> if the operation completes successfully; otherwise, the error message.</returns>
        public virtual string ChangeStatus(string id, string deliveryStatus)
        {
            string result = string.Empty;
            AppLogger.logInfo(this.ToString(), string.Format("Begin updating order status. id = {0}, order_status = {1}.", id, deliveryStatus));
            try
            {
                var order = this.Get(id);
                if (order != null)
                {
                    order.order_status = deliveryStatus;
                    Repository.Update(order);
                    if (UseAuditTrail)
                    {
                        LogAuditTrail(order, Constants.UPDATE_ACTION);
                    }
                    Repository.Commit();
                    AppLogger.logInfo(this.ToString(), "Updated order status successfully.");
                }
                else
                {
                    result = string.Format("Đơn hàng '{0}' không tồn tại.", id);
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while updating order status [{0}].", id), ex);
                Repository.Rollback();
                result = Constants.Messages.UPDATE_ORDER_ERROR_MESSAGE;
            }
            AppLogger.logInfo(this.ToString(), "Finish updating order status.");
            return result;
        }

        public virtual string Insert(RegularOrder order, Collection<OrderItem> orderItems)
        {
            string result = string.Empty;
            AppLogger.logInfo(this.ToString(), string.Format("Begin inserting new order into database. Id: {0}.", order.id));
            try
            {
                Repository.Insert(order);
                if (UseAuditTrail)
                {
                    LogAuditTrail(order, Constants.INSERT_ACTION);
                }
                GenericRepository<OrderItem> orderItemRepository = new GenericRepository<OrderItem>(Repository.Context);
                orderItemRepository.Insert(orderItems);
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while inserting order [{0}].", order.id), ex);
                result = Constants.Messages.CREATE_ORDER_ERROR_MESSAGE;
                Repository.Rollback();
            }
            AppLogger.logInfo(this.ToString(), "Finish inserting new order into database.");
            return result;
        }

        public virtual string Update(RegularOrder order, Collection<OrderItem> orderItems)
        {
            string result = string.Empty;
            AppLogger.logInfo(this.ToString(), "Begin updating order.");
            try
            {
                Repository.Update(order);
                if (UseAuditTrail)
                {
                    LogAuditTrail(order, Constants.UPDATE_ACTION);
                }
                GenericRepository<OrderItem> orderItemRepository = new GenericRepository<OrderItem>(Repository.Context);
                // Clears all order items in the order and insert the new order items
                orderItemRepository.Delete(o => o.order_id.Equals(order.id));
                orderItemRepository.Insert(orderItems);
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while updating order [{0}].", order.id), ex);
                Repository.Rollback();
                result = Constants.Messages.CREATE_ORDER_ERROR_MESSAGE;
            }
            AppLogger.logInfo(this.ToString(), "Finish updating order.");
            return result;
        }

        protected override void LogAuditTrail(RegularOrder order, string action)
        {
            if (CurrentUser != null)
            {
                action = action.ToUpperInvariant();
                if (_orderHistoryRepository == null)
                {
                    _orderHistoryRepository = new GenericRepository<OrderHistory>(Repository.Context);
                }
                if (_orderHistoryDetailRepository == null)
                {
                    _orderHistoryDetailRepository = new GenericRepository<OrderHistoryDetail>(Repository.Context);
                }

                // Logs audit trail
                OrderHistory orderHistory = new OrderHistory();
                orderHistory.id = IDGenerator.NewId<OrderHistory>(true);
                orderHistory.order_id = order.id;
                orderHistory.action = action;
                orderHistory.date_time = DateTime.Now;
                orderHistory.user_id = SystemParam.CurrentUser.id;
                _orderHistoryRepository.Insert(orderHistory);

                switch (order.EntityState)
                {
                    case EntityState.Added:
                        {
                            foreach (var property in order.GetType().GetProperties())
                            {
                                OrderHistoryDetail orderHistoryDetail = new OrderHistoryDetail();
                                orderHistoryDetail.id = Guid.NewGuid().ToString();
                                orderHistoryDetail.parent_id = orderHistory.id;
                                orderHistoryDetail.property_name = property.Name;
                                orderHistoryDetail.old_value = string.Empty;
                                orderHistoryDetail.new_value = property.GetValue(order, null) != null ? property.GetValue(order, null).ToString() : null;
                                _orderHistoryDetailRepository.Insert(orderHistoryDetail);
                            }
                        }
                        break;
                    case EntityState.Modified:
                        {
                            var stateEntry = Repository.Context.ObjectStateManager.GetObjectStateEntry(order);
                            foreach (var propertyName in stateEntry.GetModifiedProperties())
                            {
                                OrderHistoryDetail orderHistoryDetail = new OrderHistoryDetail();
                                orderHistoryDetail.id = Guid.NewGuid().ToString();
                                orderHistoryDetail.parent_id = orderHistory.id;
                                orderHistoryDetail.property_name = propertyName;
                                orderHistoryDetail.old_value = stateEntry.OriginalValues[propertyName] != null ? stateEntry.OriginalValues[propertyName].ToString() : null;
                                orderHistoryDetail.new_value = stateEntry.CurrentValues[propertyName] != null ? stateEntry.CurrentValues[propertyName].ToString() : null;
                                _orderHistoryDetailRepository.Insert(orderHistoryDetail);
                            }
                        }
                        break;
                    default: break;
                }
            }
        }
    }
}
