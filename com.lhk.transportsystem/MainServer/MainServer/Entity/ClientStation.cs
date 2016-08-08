using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Transport;
using Thrift.Protocol;
using TransportService;

namespace MainServer
{
    public class ClientStation
    {
        TSocket _socket = null;
        TBufferedTransport _transport = null;
        TProtocol _protocol = null;
        TransportClient.Client _targetClient = null;

        public TransportClient.Client TargetClient
        {
            get { return _targetClient; }
        }

        public ClientStation(string userName, string ipAddress, int port)
        {
            this.UserName = userName;
            this.IPAddress = ipAddress;
            this.Port = port;

            _socket = new TSocket(this.IPAddress, this.Port);
            _transport = new TBufferedTransport(_socket);
            _protocol = new TBinaryProtocol(_transport);
            _targetClient = new TransportClient.Client(_protocol);

        }

        public string OpenTransaction()
        {
            if (_transport == null)
            {
                return string.Format("Cannot open Transaction to Client - IP: {0} / Port {1}",this.IPAddress,this.Port);
            }

            if (_transport.IsOpen == false)
            {
                _transport.Open();
            }
            return "";
        }

        public string CloseTransaction()
        {
            if (_transport != null)
            {
                _transport.Close();
            }
            return string.Empty;
        }

        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
    }
}
