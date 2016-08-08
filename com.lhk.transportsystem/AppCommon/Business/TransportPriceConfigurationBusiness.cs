using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class TransportPriceConfigurationBusiness : GenericBusiness<TransportPriceConfiguration>
    {
        public override IEnumerable<TransportPriceConfiguration> GetAll()
        {
            var configurations = new Collection<TransportPriceConfiguration>();
            AppLogger.logInfo(this.ToString(), "Begin getting transport price configurations.");
            try
            {
                configurations = new Collection<TransportPriceConfiguration>(Repository.EntitiesSet.OrderBy("it.size, it.weight_from ASC").ToList());
                AppLogger.logInfo(this.ToString(), string.Format("Get transport price configurations successfully. Found {0}.", configurations.Count));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs when getting transport price configurations.", ex);
            }
            AppLogger.logInfo(this.ToString(), "Finish getting transport price configurations.");
            return configurations;
        }

        public override string Insert(TransportPriceConfiguration configuration)
        {
            string result = string.Empty;
            //AppLogger.logInfo(this.ToString(), "Begin inserting new transport price configuration into database.");
            try
            {
                var duplicatedConfiguration = Repository.EntitiesSet.FirstOrDefault(config => !configuration.id.Equals(config.id) && configuration.size.Equals(config.size) &&
                                                                                    ((config.weight_from <= configuration.weight_from && configuration.weight_from < config.weight_to) ||
                                                                                    (configuration.weight_from <= config.weight_from && config.weight_from < configuration.weight_to)));
                if (duplicatedConfiguration == null)
                {
                    base.Insert(configuration);
                    //AppLogger.logInfo(this.ToString(), "Inserted new transport price configuration into database successfully.");
                }
                else
                {
                    string weightTo = configuration.weight_to == Constants.MAX_WEIGHT_VALUE ? "MAX" : string.Format("{0} kg", configuration.weight_to);
                    result = string.Format("Phạm vi khối lượng từ '{0} kg' đến '{1}' không hợp lệ. Có thể đã bị trùng với thiết lập khác. Vui lòng thử lại.", configuration.weight_from, weightTo);
                    AppLogger.logInfo(this.ToString(), "Invalid weight range. Possibly conflicted with another configuration(s).");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            //AppLogger.logInfo(this.ToString(), "Finish getting transport price configuration into database.");
            return result;
        }

        public override string Update(TransportPriceConfiguration configuration)
        {
            string result = string.Empty;
            //AppLogger.logInfo(this.ToString(), string.Format("Begin updating transport price configuration [{0}].", configuration.id));
            try
            {
                var duplicatedConfiguration = Repository.EntitiesSet.FirstOrDefault(config => !configuration.id.Equals(config.id) && configuration.size.Equals(config.size) &&
                                                                                    ((config.weight_from <= configuration.weight_from && configuration.weight_from < config.weight_to) ||
                                                                                    (configuration.weight_from <= config.weight_from && config.weight_from < configuration.weight_to)));
                if (duplicatedConfiguration == null)
                {
                    base.Update(configuration);
                    //AppLogger.logInfo(this.ToString(), "Updated transport price configuration successfully.");
                }
                else
                {
                    string weightTo = configuration.weight_to == Constants.MAX_WEIGHT_VALUE ? "MAX" : string.Format("{0} kg", configuration.weight_to);
                    result = string.Format("Phạm vi khối lượng từ '{0} kg' đến '{1}' không hợp lệ. Có thể đã bị trùng với thiết lập khác. Vui lòng thử lại.", configuration.weight_from, weightTo);
                    AppLogger.logInfo(this.ToString(), "Invalid weight range. Possibly conflicted with another configuration(s).");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            //AppLogger.logInfo(this.ToString(), "Finish updating transport price configuration.");
            return result;
        }
    }
}
