using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Thrift.Server;
using Thrift.Transport;
using TransportService;
using Thrift.Protocol;
using DBManagement;
using AppCommon.Util;
using AppCommon.Constant;
using System.Data.SqlClient;
using System.Data.Objects.DataClasses;

namespace MainServer
{
    public partial class MainServer : Form
    {
        private TServer _server = null;
        private Thread _serverThread = null;
        private string _serverIP = "127.0.0.1";
        private int _serverPort = 3030;

        private ServerBusiness _business = ServerBusiness.GetInstance();

        public MainServer()
        {
            InitializeComponent();

            _business.serverView = this;
        }

        ~MainServer()
        {
            _server.Stop();
            _server = null;
        }

        #region Event Section
        private void MainServer_Load(object sender, EventArgs e)
        {
            string ip = _business.GetInternalIp();
#if DEBUG
            //ip = "127.0.0.1";
#endif
            if (ip != null)
            {
                
                lblExtenalIP.Text = _business.GetExtenalIp().ToString();
                _serverIP = ip;
                lblPort.Text = _serverPort.ToString();
            }
            else
            {
                lblExtenalIP.Text = "Fail";
                lblPort.Text = "Fail";
            }

            StartServer();

            AutoSendMail.GetInstance().Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void niServerNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void niServerNotify_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainServer_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();

            btnStart.Visible = false;
            btnStop.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();

            btnStart.Visible = true;
            btnStop.Visible = false;
        }

        private void MainServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();

            //AutoSendMail.GetInstance().SendMail();
        }

        private delegate void AddOutputAction(string message);
        public void OutputAction(string message)
        {
            if (tbLogScreen.InvokeRequired)
            {
                AddOutputAction callback = new AddOutputAction(OutputAction);
                tbLogScreen.Invoke(callback, new object[] { message });
            }
            else
            {
                tbLogScreen.AppendText(message + "\r\n");
            }
        }

        #endregion

        #region Server Method
        private void InitTransportService()
        {
            ServiceHandler _serviceHandler = new ServiceHandler();
            _serviceHandler._login = _business.Login;
            _serviceHandler._logout = _business.Logout;
            _serviceHandler._loadCustomers = _business.LoadCustomer;
            _serviceHandler._loadOrderItems = _business.LoadOrderItem;
            _serviceHandler._loadRegularOrders = _business.LoadRegularOrder;
            _serviceHandler._loadIrregularOrders = _business.LoadIrregularOrder;
            _serviceHandler._loadSystemConfig = _business.LoadSystemConfig;
            _serviceHandler._loadTickets = _business.LoadTicket;
            _serviceHandler._createOrder = _business.CreateOrder;
            _serviceHandler._deleteOrder = _business.DeleteOrder;
            _serviceHandler._updateOrderInfo = _business.UpdateOrderInfo;
            _serviceHandler._updateSingleOrderInfo = _business.UpdateSingleOrderInfo;
            _serviceHandler._updateTicket = _business.UpdateTicket;
            _serviceHandler._insertTicket = _business.InsertTicket;
            _serviceHandler._cancelTicket = _business.CancelTicket;
            _serviceHandler._syncIrregularOrders = _business.SyncIrregularOrder;
            _serviceHandler._syncOrderItems = _business.SyncOrderItem;
            _serviceHandler._syncRegularOrders = _business.SyncRegularOrder;
            _serviceHandler._syncTickets = _business.SyncTicket;

            TransportServer.Processor serverProcessor = new TransportServer.Processor(_serviceHandler);
            IPAddress ip = IPAddress.Parse(_serverIP);
            TcpListener listener = new TcpListener(ip, _serverPort);

            TServerTransport transport = new TServerSocket(listener);
            _server = new TThreadPoolServer(serverProcessor, transport);

            _server.Serve();

        }

        private void StartServer()
        {
            try
            {
                string startMessage = string.Format("server start with IP: {0} - Port: {1}", _serverIP, _serverPort);

                ServerLogger.logInfo("StartServer",startMessage);
                btnStart.Visible = false;
                btnStop.Visible = true;

                _serverThread = new Thread(new ThreadStart(InitTransportService));
                _serverThread.Start();

                OutputAction(startMessage);
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[StopServer]",exc);
            }
        }

        private void StopServer()
        {
            try
            {
                string stopMessage = "Server is Stoped";

                if (_server != null)
                    _server.Stop();
                if (_serverThread != null)
                    _serverThread.Abort();
                OutputAction(stopMessage);
            }
            catch (Exception exc)
            {
                ServerLogger.logError("[StopServer]",exc);
            }
        }
        #endregion


    }


}
