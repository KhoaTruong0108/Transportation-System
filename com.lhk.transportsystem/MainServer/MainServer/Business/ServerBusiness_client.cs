using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Transport;
using Thrift.Protocol;
using TransportService;

namespace MainServer
{
    public partial class ServerBusiness
    {
        private string CLIENT_ERROR_FORMAT = "[CLIENT-ERROR]: {0}";
        private string CLIENT_RESULT_FORMAT = "[RESULT]: {0}";

        protected enum ClientAction
        {
            CheckConnection,
            ReloadSystemSetting,
            ReloadSaleTicketDate,
            ReloadTicketPrice,
            ReloadTransportPrice,
            ReloadTicketLoading,
            ReloadCustomerLoading,
            ReloadOrderLoading,
            SellTicket,
            CancelTicket,
            UpdateTicket,
            CreateOrder,
            UpdateOrder,
            CompleteOrder
        }

        protected List<ClientStation> _clientList = new List<ClientStation>();

        protected bool AddClientStation(string userName, string senderIP, int senderPort)
        {
            try
            {
                if (_clientList.Count(c => c.UserName == userName) > 0)
                {
                    // duplicate logging in of one user
                }
                else
                {
                    ClientStation client = _clientList.SingleOrDefault(c => c.UserName == userName);

                    if (client != null && (client.IPAddress != senderIP || client.Port != senderPort))
                    {
                        client.IPAddress = senderIP;
                        client.Port = senderPort;
                    }
                    else
                    {
                        _clientList.Add(new ClientStation(userName, senderIP, senderPort));
                    }
                }
                return true;
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[AddClientStation]", exc);
                return false;
            }
        }

        #region Broadcast section
        protected void BroadcastToClient(ClientAction action, params object[] args)
        {
            for (int index = 0; index < _clientList.Count; index++)
            {
                try
                {
                    var client = _clientList[index];

                    string errorMessage = client.OpenTransaction();

                    if (string.IsNullOrEmpty(errorMessage) == false)
                    {
                        ServerLogger.logError("[BroadcastToClient]", string.Format(CLIENT_ERROR_FORMAT, errorMessage));
                        continue;
                    }

                    string result = SendNotifyToClient(client, action, args);
                    ServerLogger.logInfo("[BroadcastToClient]", string.Format(CLIENT_RESULT_FORMAT, result));

                    client.CloseTransaction();
                }
                catch (Exception exc)
                {
                    ServerLogger.logError("[BroadcastToClient]", exc);
                }
            }
        }

        protected string SendNotifyToClient(ClientStation client, ClientAction action, params object[] args)
        {
            string result = "";

            switch (action)
            {
                case ClientAction.CancelTicket:
                    result = client.TargetClient.CancelTicket(args[0] as TTicket);
                    break;
                case ClientAction.CheckConnection:
                    result = client.TargetClient.CheckConnection(args[0] as string) ? "SUCCESS" : "FAIL";
                    break;
                case ClientAction.CompleteOrder:
                    result = client.TargetClient.CompleteOrder(args[0] as TOrder);
                    break;
                case ClientAction.CreateOrder:
                    result = client.TargetClient.CreateTransportOrder(args[0] as TOrder, args[1] as List<TOrderItem>);
                    break;
                case ClientAction.ReloadCustomerLoading:
                    result = client.TargetClient.ReloadCustomerLoading(args[0] as List<TCustomer>);
                    break;
                case ClientAction.ReloadOrderLoading:
                    result = client.TargetClient.ReloadOrderLoading(args[0] as List<TOrder>, args[1] as List<TOrderItem>);
                    break;
                case ClientAction.ReloadSaleTicketDate:
                    result = client.TargetClient.ReloadSaleTicketDate(args[0] as List<TSaleTicketDate>);
                    break;
                case ClientAction.ReloadSystemSetting:
                    result = client.TargetClient.ReloadSystemSetting(args[0] as List<TConfiguration>);
                    break;
                case ClientAction.ReloadTicketLoading:
                    result = client.TargetClient.ReloadTicketLoading(args[0] as List<TTicket>);
                    break;
                case ClientAction.ReloadTicketPrice:
                    result = client.TargetClient.ReloadTicketPrice(args[0] as List<TTicketPrice>);
                    break;
                case ClientAction.ReloadTransportPrice:
                    result = client.TargetClient.ReloadTransportPrice(args[0] as List<TTransportPrice>);
                    break;
                case ClientAction.SellTicket:
                    result = client.TargetClient.CreateNewTicket(args[0] as TTicket);
                    break;
                case ClientAction.UpdateOrder:
                    result = client.TargetClient.UpdateOrderInfo(args[0] as TOrder, args[1] as List<TOrderItem>);
                    break;
                case ClientAction.UpdateTicket:
                    result = client.TargetClient.UpdateTicket(args[0] as TTicket);
                    break;
            }

            return result;
        }
        #endregion
    }
}
