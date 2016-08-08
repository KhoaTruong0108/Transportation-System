using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBManagement;

namespace AppCommon.Util
{
    public class ConfigurationUtil
    {
        public static string GetConfig(string configId)
        {
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                var config = context.Configurations.SingleOrDefault(i => i.id == configId);
                return config == null ? "" : config.value;
            }
        }
    }
}
