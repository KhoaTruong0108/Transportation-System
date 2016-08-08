using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class ExpenseBusiness : GenericBusiness<Expense>
    {
        public ExpenseBusiness(User currentUser = null)
            : base(currentUser)
        {
            UseAuditTrail = true;
        }

        public IEnumerable<Expense> Get(int day, int month, int year)
        {
            IEnumerable<Expense> expenses = new Collection<Expense>();
            AppLogger.logInfo(this.ToString(), "Begin getting expenses.");
            try
            {
                AppLogger.logInfo(this.ToString(), string.Format("Day = {0}, Month = {1}, Year = {2}.", day, month, year));
                expenses = Repository.EntitiesSet.Where(r =>
                                                        (r.created_date.Day == day || day == 0) &&
                                                        (r.created_date.Month == month || month == 0) &&
                                                        (r.created_date.Year == year || year == 0));
                AppLogger.logInfo(this.ToString(), string.Format("Found: {0}.", expenses.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            AppLogger.logInfo(this.ToString(), "Finish getting expenses.");
            return expenses;
        }

        public IEnumerable<Expense> Search(string dayValue, string monthValue, string yearValue)
        {
            IEnumerable<Expense> expenses = new Collection<Expense>();
            try
            {
                int day = !string.IsNullOrEmpty(dayValue) ? int.Parse(dayValue) : 0;
                int month = !string.IsNullOrEmpty(monthValue) ? int.Parse(monthValue) : 0;
                int year = !string.IsNullOrEmpty(yearValue) ? int.Parse(yearValue) : 0;

                expenses = Get(day, month, year);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return expenses;
        }
    }
}
