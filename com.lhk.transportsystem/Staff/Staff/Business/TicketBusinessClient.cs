using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCommon.Business;
using TransportService;
using AppCommon.CommonView;
using AppCommon.Constant;
using DBManagement;

namespace Staff.Business
{
    public class TicketBusinessClient : TicketBusiness, IClientBusiness
    {
        public override string Insert(DBManagement.Ticket entity)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().InsertTicketRequest(entity);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Insert(entity);
        }

        public override string Update(DBManagement.Ticket entity)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().UpdateTicketRequest(entity);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Update(entity);
        }

        public override string Delete(Ticket entity)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().CancelTicketRequest(entity);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Delete(entity);
        }

        public override string Delete(string id)
        {
            Ticket entity = new Ticket();
            entity.id = id;

            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().CancelTicketRequest(entity);

            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Delete(id);
        }

        public override string Cancel(DBManagement.Ticket ticket, decimal returnFee)
        {
            string errorMessage = AutoSync.GetInstance().CheckServerIsFree();
            if (string.IsNullOrEmpty(errorMessage)) errorMessage = ServerConnector.GetInstance().CancelTicketRequest(ticket);
            errorMessage = HandleRequestResult(errorMessage);

            return string.IsNullOrEmpty(errorMessage) == false ? errorMessage : base.Cancel(ticket, returnFee);
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
                mainBusiness.InitTickets();

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
