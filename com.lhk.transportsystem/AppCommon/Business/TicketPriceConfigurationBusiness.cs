using System;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class TicketPriceConfigurationBusiness : GenericBusiness<TicketPriceConfiguration>
    {
        public TicketPriceConfiguration GetBySeatClass(string seatClass)
        {
            TicketPriceConfiguration configuration = null;
            AppLogger.logInfo(this.ToString(), "Begin getting TicketPriceConfiguration.");
            try
            {
                AppLogger.logInfo(this.ToString(), string.Format("Condition: [seat_class = {0}]", seatClass));
                configuration = Repository.Get(c => c.seat_class.Equals(seatClass));
                if (configuration != null)
                {
                    AppLogger.logInfo(this.ToString(), "TicketPriceConfiguration found.");
                }
                else
                {
                    AppLogger.logInfo(this.ToString(), "TicketPriceConfiguration not found.");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            AppLogger.logInfo(this.ToString(), "Finish getting TicketPriceConfiguration.");
            return configuration;
        }
    }
}
