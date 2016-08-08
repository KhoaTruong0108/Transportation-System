using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.CommonRepository;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class RevenueBusiness : GenericBusiness<Revenue>
    {
        public RevenueBusiness(User currentUser = null)
            : base(currentUser)
        {
            UseAuditTrail = true;
        }

        public IEnumerable<Revenue> Get(int day, int month, int year)
        {
            IEnumerable<Revenue> revenues = new Collection<Revenue>();
            AppLogger.logInfo(this.ToString(), "Begin getting revenues.");
            try
            {
                AppLogger.logInfo(this.ToString(), string.Format("Day = {0}, Month = {1}, Year = {2}.", day, month, year));
                revenues = Repository.EntitiesSet.Where(r =>
                                                        (r.created_date.Day == day || day == 0) &&
                                                        (r.created_date.Month == month || month == 0) &&
                                                        (r.created_date.Year == year || year == 0));
                AppLogger.logInfo(this.ToString(), string.Format("Found: {0}.", revenues.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            AppLogger.logInfo(this.ToString(), "Finish getting revenues.");
            return revenues;
        }

        public IEnumerable<Revenue> Search(string dayValue, string monthValue, string yearValue)
        {
            IEnumerable<Revenue> revenues = new Collection<Revenue>();
            try
            {
                int day = !string.IsNullOrEmpty(dayValue) ? int.Parse(dayValue) : 0;
                int month = !string.IsNullOrEmpty(monthValue) ? int.Parse(monthValue) : 0;
                int year = !string.IsNullOrEmpty(yearValue) ? int.Parse(yearValue) : 0;

                revenues = Get(day, month, year);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return revenues;
        }

        public string Insert(Revenue revenue, IEnumerable<RevenueDetail> details)
        {
            string result = string.Empty;
            AppLogger.logInfo(this.ToString(), "Begin inserting revenue.");
            try
            {
                Repository.Insert(revenue);
                if (UseAuditTrail)
                {
                    LogAuditTrail(revenue, Constants.INSERT_ACTION);
                }
                GenericRepository<RevenueDetail> revenueDetailRepository = new GenericRepository<RevenueDetail>(Repository.Context);
                revenueDetailRepository.Insert(details);
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs when inserting revenue.", ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            AppLogger.logInfo(this.ToString(), "Finish inserting revenue.");
            return result;
        }
    }
}
