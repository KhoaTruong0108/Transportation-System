using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCommon.Util;

namespace MainServer
{
    public class ServerLogger : AppLogger
    {
        public static void logInfo(string className, string msg, MainServer serverView)
        {
            logInfo(className, msg);
            serverView.OutputAction(msg);
        }
    }
}
