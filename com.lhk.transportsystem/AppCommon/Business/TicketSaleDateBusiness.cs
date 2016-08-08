using System.Collections.Generic;
using System.Linq;
using AppCommon.CommonBusiness;
using DBManagement;
using System;
using AppCommon.Util;
using AppCommon.Constant;

namespace AppCommon.Business
{
    public class TicketSaleDateBusiness : GenericBusiness<TicketSaleDate>
    {
        public override IEnumerable<TicketSaleDate> GetAll()
        {
            return base.GetAll().OrderByDescending(t => t.ticket_sale_year)
                                .ThenByDescending(t => t.ticket_sale_month)
                                .ThenByDescending(t => t.ticket_sale_day);
        }


        public string ValidateDateTime(DateTime departureTime)
        {
            string errorMsg = string.Empty;

            List<TicketSaleDate> ticketSaleDates = this.GetAll().ToList();

            if (ticketSaleDates.Count <= 0) return errorMsg;

            int beforedate = -1;
            foreach (TicketSaleDate saleDate in ticketSaleDates)
            {
                try
                {
                    //Year-Month-Day
                    if (departureTime.Year == saleDate.ticket_sale_year
                                       && departureTime.Month == saleDate.ticket_sale_month
                                       && departureTime.Day == saleDate.ticket_sale_day)
                    {
                        var date = new DateTime(saleDate.ticket_sale_year, saleDate.ticket_sale_month,
                                                saleDate.ticket_sale_day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Year-Month
                    else if (departureTime.Year == saleDate.ticket_sale_year
                        && departureTime.Month == saleDate.ticket_sale_month
                        && saleDate.ticket_sale_day == 0)
                    {
                        var date = new DateTime(saleDate.ticket_sale_year, saleDate.ticket_sale_month, departureTime.Day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Year-Day
                    else if (departureTime.Year == saleDate.ticket_sale_year
                             && departureTime.Day == saleDate.ticket_sale_day
                        && saleDate.ticket_sale_month == 0)
                    {
                        var date = new DateTime(saleDate.ticket_sale_year, departureTime.Month,
                                                saleDate.ticket_sale_day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Month-Day
                    else if (departureTime.Month == saleDate.ticket_sale_month
                             && departureTime.Day == saleDate.ticket_sale_day
                        && saleDate.ticket_sale_year == 0)
                    {
                        var date = new DateTime(DateTime.Now.Year, saleDate.ticket_sale_month, saleDate.ticket_sale_day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Year
                    else if (departureTime.Year == saleDate.ticket_sale_year
                        && saleDate.ticket_sale_month == 0
                        && saleDate.ticket_sale_day == 0)
                    {
                        var date = new DateTime(saleDate.ticket_sale_year, departureTime.Month, departureTime.Day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Month
                    else if (departureTime.Month == saleDate.ticket_sale_month
                        && saleDate.ticket_sale_year == 0
                        && saleDate.ticket_sale_day == 0)
                    {
                        var date = new DateTime(DateTime.Now.Year, saleDate.ticket_sale_month, departureTime.Day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Day
                    else if (departureTime.Day == saleDate.ticket_sale_day
                        && saleDate.ticket_sale_year == 0
                        && saleDate.ticket_sale_month == 0)
                    {
                        var date = new DateTime(departureTime.Year, departureTime.Month,
                                                saleDate.ticket_sale_day);
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }
                    //Empty
                    else if (saleDate.ticket_sale_year == 0
                        && saleDate.ticket_sale_month == 0
                        && saleDate.ticket_sale_day == 0)
                    {
                        var date = departureTime;
                        if ((date.AddDays(-saleDate.before_days)).Date <= DateTime.Now.Date)
                        {
                            beforedate = saleDate.before_days;
                        }
                        break;
                    }

                }
                catch (Exception exc)
                {
                    //catch case date is not valid                    
                    AppLogger.logError("ValidateDateTime", "catch case date is not valid", exc);
                }
            }

            errorMsg = beforedate > 0 ? string.Empty : Constants.Messages.MSG_TICKET_BEFORE_DATETIME_ERROR_MSG;

            return errorMsg;
        }


    }
}
