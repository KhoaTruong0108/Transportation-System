using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using AppCommon.Business;
using DBManagement;
using TransportService;
using AppCommon.Constant;

namespace Staff.Business
{
    public class IrregularOrderBusinessClient : IrregularOrderBusiness, IClientBusiness
    {
        public override string Insert(IrregularOrder order, Collection<OrderItem> orderItems)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().CreateOrderRequest(order, orderItems.ToList());
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Insert(order, orderItems);
        }

        public override string Delete(IrregularOrder entity)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().DeleteOrderInfoRequest(entity);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Delete(entity);
        }

        public override string  Delete(string id)
        {
            IrregularOrder irregularOrder = new IrregularOrder();
            irregularOrder.id = id;

            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().DeleteOrderInfoRequest(irregularOrder);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Delete(id);
        }

        public override string Update(IrregularOrder entity)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().UpdateSingleOrderInfoRequest(entity);
            errorMessage = HandleRequestResult(errorMessage);

            return base.Update(entity);
        }

        public override string Update(IrregularOrder order, Collection<OrderItem> orderItems)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().UpdateOrderInfoRequest(order, orderItems.ToList());
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Update(order, orderItems);
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
                mainBusiness.InitIrregularOrders();
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
