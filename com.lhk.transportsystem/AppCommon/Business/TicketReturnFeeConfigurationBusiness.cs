using System;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class TicketReturnFeeConfigurationBusiness : GenericBusiness<TicketReturnFeeConfiguration>
    {
        public decimal GetReturnFee(Ticket ticket, DateTime returnDate)
        {
            decimal returnfee = 0;
            AppLogger.logInfo(this.ToString(), "Begin getting return fee.");
            try
            {
                DateTime departime = ticket.departure_time;
                var configurations = Repository.EntitiesSet.OrderByDescending(i => i.before_day).ThenByDescending(i => i.before_hour); // Always use generic IEnumerable, IQueryable for optimization. Only cast to List on final result.
                var config = configurations.ToList().FirstOrDefault(i => departime.AddDays(-i.before_day).AddHours(-i.before_hour) > returnDate);

                if (config == null)
                {
                    config = configurations.LastOrDefault();
                }

                returnfee = config.fee_amount > 0 ? config.fee_amount : (ticket.cost * config.fee_percent) / 100;
                AppLogger.logInfo(this.ToString(), "Gets return fee successfully.");
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            AppLogger.logInfo(this.ToString(), "Finish getting return fee.");
            return returnfee;
        }
    }
}