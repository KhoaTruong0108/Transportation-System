using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using AppCommon.Business;
using AppCommon.Constant;
using DBManagement;
using TransportService;

namespace Staff.Business
{
    public class RegularOrderBusinessClient : RegularOrderBusiness, IClientBusiness
    {
        public override string Insert(RegularOrder order, Collection<OrderItem> orderItems)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().CreateOrderRequest(order, orderItems.ToList());
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Insert(order, orderItems);
        }

        public override string Update(RegularOrder order, Collection<OrderItem> orderItems)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().UpdateOrderInfoRequest(order, orderItems.ToList());
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Update(order, orderItems);
        }

        public override string Update(RegularOrder order)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().UpdateSingleOrderInfoRequest(order);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Update(order);
        }

        public override string Delete(RegularOrder entity)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().DeleteOrderInfoRequest(entity);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Delete(entity);
        }

        public override string Delete(string id)
        {
            RegularOrder order = new RegularOrder();
            order.id = id;

            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().DeleteOrderInfoRequest(order);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Delete(id);
        }

        public string HandleRequestResult(string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage) == false)
            {
                errorMessage = SyncData(errorMessage);
            }
            return errorMessage;
        }

        public string SyncData(string errorMessage)
        {
            MainBusiness mainBusiness = new MainBusiness();
            if (errorMessage.Contains(Constants.SERVER_ERROR_CODE_SINGLE_DATA_NOT_SYNC))
            {
                mainBusiness.InitRegularOrders();
                mainBusiness.InitOrderItems();

                errorMessage = errorMessage.Replace(Constants.SERVER_ERROR_CODE_SINGLE_DATA_NOT_SYNC, "");
            }

            if (errorMessage.Contains(Constants.SERVER_ERROR_CODE_CONFIG_DATA_NOT_SYNC))
            {
                mainBusiness.InitSystemConfig();

                errorMessage = errorMessage.Replace(Constants.SERVER_ERROR_CODE_CONFIG_DATA_NOT_SYNC, "");
            }

            return errorMessage;
        }
    }
}
