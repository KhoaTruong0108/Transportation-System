using System;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class TourBusiness : GenericBusiness<Tour>
    {
        public override string Insert(Tour tour)
        {
            string result = string.Empty;
            try
            {
                var duplicatedConfiguration = Repository.EntitiesSet.FirstOrDefault(t => !tour.id.Equals(t.id) &&
                                                                                    tour.start.Equals(t.start) &&
                                                                                    tour.destination.Equals(t.destination));
                if (duplicatedConfiguration == null)
                {
                    result = base.Insert(tour);
                }
                else
                {
                    result = string.Format("Tuyến từ '{0}' đến '{1}' đã tồn tại. Vui lòng chọn tuyến khác.", tour.start, tour.destination);
                    AppLogger.logInfo(this.ToString(), "Duplicated tours.");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public override string Update(Tour tour)
        {
            string result = string.Empty;
            AppLogger.logInfo(this.ToString(), string.Format("Begin updating tour [{0}].", tour.id));
            try
            {
                var duplicatedConfiguration = Repository.EntitiesSet.FirstOrDefault(t => !tour.id.Equals(t.id) &&
                                                                                    tour.start.Equals(t.start) &&
                                                                                    tour.destination.Equals(t.destination));
                if (duplicatedConfiguration == null)
                {
                    result = base.Update(tour);
                }
                else
                {
                    result = string.Format("Tuyến từ '{0}' đến '{1}' đã tồn tại. Vui lòng chọn tuyến khác.", tour.start, tour.destination);
                    AppLogger.logInfo(this.ToString(), "Duplicated tours.");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }
    }
}
