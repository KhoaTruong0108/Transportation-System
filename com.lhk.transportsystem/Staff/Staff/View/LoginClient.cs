using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCommon;
using AppCommon.CommonView;
using TransportService;
using Utility;
using DBManagement;
using System.Windows.Forms;
using System.ComponentModel;
using AppCommon.Constant;
using AppCommon.Util;

namespace Staff.View
{
    public class LoginClient : Login
    {

        public LoginClient(Constants.UserRole currentRole)
            : base(currentRole)
        {
        }

        protected override void Login_Load(object sender, EventArgs e)
        {
            base.Login_Load(sender, e);

            //ClientRepository.GetInstance()._clientIp = IpAddressUtil.GetExternalAddress(ConfigUtil.GetExtenalAdress()).ToString();

            string clientAddress = "127.0.0.1";
            string clientPort = "3030";
            ConfigUtil.GetClientAdderss(out clientAddress, out clientPort);
            ClientRepository.GetInstance()._clientPort = clientPort;
#if DEBUG
            //ClientRepository.GetInstance()._clientIp = "127.0.0.1";
#endif
        }

        protected override User ExcuteLogin(string userName, string password, string role)
        {
            TUser tuser = ServerConnector.GetInstance().Login(userName, password, ClientRepository.GetInstance()._clientIp, ClientRepository.GetInstance()._clientPort);
            if (string.IsNullOrEmpty(tuser.Id) == false)
            {
                return ThriftUtil.ConvertToUser(tuser);
            }
            return null;
        }
    }
}
