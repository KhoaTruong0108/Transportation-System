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
    public class GuaranteeFeeConfigurationBusiness : GenericBusiness<GuaranteeFeeConfiguration>
    {
        public override IEnumerable<GuaranteeFeeConfiguration> GetAll()
        {
            Collection<GuaranteeFeeConfiguration> configurations = new Collection<GuaranteeFeeConfiguration>();
            AppLogger.logInfo(this.ToString(), "Begin getting guarantee fee configurations.");
            try
            {
                configurations = new Collection<GuaranteeFeeConfiguration>(Repository.EntitiesSet.OrderBy("it.value_from, it.value_to, it.guarantee_fee").ToList());
                AppLogger.logInfo(this.ToString(), string.Format("Get guarantee fee configurations successfully. Found: {0}.", configurations.Count));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs when getting guarantee fee configurations.", ex);
            }
            AppLogger.logInfo(this.ToString(), "Finish getting guarantee fee configurations.");
            return configurations;
        }

        public override string Insert(GuaranteeFeeConfiguration configuration)
        {
            string result = string.Empty;
            //AppLogger.logInfo(this.ToString(), "Begin inserting new guarantee fee configuration into database.");
            try
            {
                var duplicatedConfiguration = Repository.EntitiesSet.FirstOrDefault(config => !configuration.id.Equals(config.id) &&
                                                                                    ((config.value_from <= configuration.value_from && configuration.value_from < config.value_to) ||
                                                                                    (configuration.value_from <= config.value_from && config.value_from < configuration.value_to)));
                if (duplicatedConfiguration == null)
                {
                    base.Insert(configuration);
                    //AppLogger.logInfo(this.ToString(), "Inserted new guarantee fee configuration into database successfully.");
                }
                else
                {
                    string valueTo = configuration.value_to == Constants.MAX_MONEY_VALUE ? "MAX" : CurrencyUtil.ToStringWithCurrencySign(configuration.value_to);
                    result = string.Format("Phạm vi giá trị từ '{0}' đến '{1}' không hợp lệ. Có thể đã bị trùng với thiết lập khác. Vui lòng thử lại.", CurrencyUtil.ToStringWithCurrencySign(configuration.value_from), valueTo);
                    AppLogger.logInfo(this.ToString(), "Invalid value range. Possibly conflicted with another configuration(s).");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            //AppLogger.logInfo(this.ToString(), "Finish getting guarantee fee configuration into databasee.");
            return result;
        }

        public override string Update(GuaranteeFeeConfiguration configuration)
        {
            string result = string.Empty;
            //AppLogger.logInfo(this.ToString(), string.Format("Begin updating guarantee fee configuration [{0}].", configuration.id));
            try
            {
                var duplicatedConfiguration = Repository.EntitiesSet.FirstOrDefault(config => !configuration.id.Equals(config.id) &&
                                                                                    ((config.value_from <= configuration.value_from && configuration.value_from < config.value_to) ||
                                                                                    (configuration.value_from <= config.value_from && config.value_from < configuration.value_to)));
                if (duplicatedConfiguration == null)
                {
                    base.Update(configuration);
                    //AppLogger.logInfo(this.ToString(), "Updated guarantee fee configuration successfully.");
                }
                else
                {
                    string valueTo = configuration.value_to == Constants.MAX_MONEY_VALUE ? "MAX" : CurrencyUtil.ToStringWithCurrencySign(configuration.value_to);
                    result = string.Format("Phạm vi giá trị từ '{0}' đến '{1}' không hợp lệ. Có thể đã bị trùng với thiết lập khác. Vui lòng thử lại.", CurrencyUtil.ToStringWithCurrencySign(configuration.value_from), valueTo);
                    AppLogger.logInfo(this.ToString(), "Invalid value range. Possibly conflicted with another configuration(s).");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            //AppLogger.logInfo(this.ToString(), "Finish updating guarantee fee configuration.");
            return result;
        }
    }
}
