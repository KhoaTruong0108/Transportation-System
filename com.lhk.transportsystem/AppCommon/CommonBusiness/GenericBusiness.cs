using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using AppCommon.CommonRepository;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.CommonBusiness
{
    public abstract class GenericBusiness<T> : IDisposable, IBusiness<T> where T : EntityObject, new()
    {
        #region Variables
        private GenericRepository<AuditTrail> _auditTrailRepository;
        private GenericRepository<AuditTrailDetail> _auditTrailDetailRepository;
        #endregion

        #region Properties
        private bool _useAuditTrail = false;
        /// <summary>
        /// Gets or sets a value indicating whether the action will be logged into audit trail or not.
        /// </summary>
        /// <value>
        ///   <c>true</c> if use audit trail; otherwise, <c>false</c>.
        /// </value>
        public bool UseAuditTrail
        {
            get { return _useAuditTrail; }
            set { _useAuditTrail = value; }
        }

        private User _currentUser = null;
        /// <summary>
        /// Gets or sets the current user.
        /// </summary>
        /// <value>
        /// The current user.
        /// </value>
        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        private IRepository<T> _repository;
        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <value>
        /// The repository.
        /// </value>
        public IRepository<T> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new GenericRepository<T>();
                }
                return _repository;
            }
        }
        #endregion

        #region Constructors
        public GenericBusiness(User currentUser = null)
        {
            CurrentUser = currentUser;
        }
        #endregion

        #region Public Generic Methods
        /// <summary>
        /// Gets the specified entity.
        /// </summary>
        /// <param name="id">The entity id.</param>
        /// <returns></returns>
        public virtual T Get(string id)
        {
            T entity = null;
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    AppLogger.logInfo(this.ToString(), string.Format("Gets entity of {0}. Id: '{1}'.", typeof(T), id));
                    Repository.Refresh(RefreshMode.StoreWins);
                    entity = Repository.Get(e => typeof(T).GetProperty("id").GetValue(e, null).ToString().Equals(id));
                    if (entity != null)
                    {
                        AppLogger.logInfo(this.ToString(), string.Format("Entity of {0} found.", typeof(T)));
                    }
                    else
                    {
                        AppLogger.logInfo(this.ToString(), string.Format("Entity of {0} not found.", typeof(T)));
                    }
                }
                else
                {
                    AppLogger.logInfo(this.ToString(), "Id is empty.");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            IEnumerable<T> entities = null;
            AppLogger.logInfo(this.ToString(), string.Format("Begin getting all entities of {0}.", typeof(T)));
            try
            {
                Repository.Refresh(RefreshMode.StoreWins);
                entities = Repository.EntitiesSet;
                AppLogger.logInfo(this.ToString(), string.Format("Found: {0}.", entities.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                //throw;
            }
            AppLogger.logInfo(this.ToString(), string.Format("Finish getting all entities of {0}.", typeof(T)));
            return entities;
        }

        public virtual IEnumerable<T> Search(string filter)
        {
            ObjectQuery<T> query = null;
            AppLogger.logInfo(this.ToString(), string.Format("Begin searching for entities of {0}.", typeof(T)));
            AppLogger.logInfo(this.ToString(), string.Format("Filter: \"{0}\".", filter));
            try
            {
                Repository.Refresh(RefreshMode.StoreWins);
                query = Repository.EntitiesSet;
                if (!string.IsNullOrEmpty(filter))
                {
                    query = query.Where(filter);
                }
                AppLogger.logInfo(this.ToString(), string.Format("Found: {0}.", query.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                //throw;
            }
            AppLogger.logInfo(this.ToString(), string.Format("Finish searching for entities of {0}.", typeof(T)));
            return query;
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual string Insert(T entity)
        {
            string result = string.Empty;
            try
            {
                Repository.Insert(entity);
                if (UseAuditTrail)
                {
                    LogAuditTrail(entity, Constants.INSERT_ACTION);
                }
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Inserts the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        public virtual string Insert(IEnumerable<T> entities)
        {
            string result = string.Empty;
            try
            {
                Repository.Insert(entities);
                if (UseAuditTrail)
                {
                    foreach (var entity in entities)
                    {
                        LogAuditTrail(entity, Constants.INSERT_ACTION);
                    }
                }
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual string Update(T entity)
        {
            string result = string.Empty;
            try
            {
                Repository.Update(entity);
                if (UseAuditTrail)
                {
                    LogAuditTrail(entity, Constants.UPDATE_ACTION);
                }
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        public virtual string Update(IEnumerable<T> entities)
        {
            string result = string.Empty;
            try
            {
                Repository.Update(entities);
                if (UseAuditTrail)
                {
                    foreach (var entity in entities)
                    {
                        LogAuditTrail(entity, Constants.UPDATE_ACTION);
                    }
                }
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Inserts or updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual string InsertOrUpdate(T entity)
        {
            string result = string.Empty;
            try
            {
                Repository.InsertOrUpdate(entity);
                if (UseAuditTrail)
                {
                    LogAuditTrail(entity, Constants.INSERT_UPDATE_ACTION);
                }
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Inserts or updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        public virtual string InsertOrUpdate(IEnumerable<T> entities)
        {
            string result = string.Empty;
            try
            {
                Repository.InsertOrUpdate(entities);
                if (UseAuditTrail)
                {
                    foreach (var entity in entities)
                    {
                        LogAuditTrail(entity, Constants.INSERT_UPDATE_ACTION);
                    }
                }
                Repository.Commit();
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="id">The entity id.</param>
        /// <returns></returns>
        public virtual string Delete(string id)
        {
            string result = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    AppLogger.logInfo(this.ToString(), string.Format("Deletes entity of {0}. Id: '{1}'.", typeof(T), id));
                    T entity = Repository.Get(e => typeof(T).GetProperty("id").GetValue(e, null).ToString().Equals(id));
                    if (entity != null)
                    {
                        Repository.Delete(entity);
                        if (UseAuditTrail)
                        {
                            LogAuditTrail(entity, Constants.DELETE_ACTION);
                        }
                        Repository.Commit();
                    }
                }
                else
                {
                    AppLogger.logInfo(this.ToString(), "Id is empty.");
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual string Delete(T entity)
        {
            string result = string.Empty;
            try
            {
                if (entity != null)
                {
                    Repository.Delete(entity);
                    if (UseAuditTrail)
                    {
                        LogAuditTrail(entity, Constants.DELETE_ACTION);
                    }
                    Repository.Commit();
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public virtual void Dispose()
        {
            Repository.Dispose();
        }
        #endregion

        #region Protected Methods
        protected virtual void LogAuditTrail(T entity, string action)
        {
            if (CurrentUser != null)
            {
                action = action.ToUpperInvariant();
                if (_auditTrailRepository == null)
                {
                    _auditTrailRepository = new GenericRepository<AuditTrail>(Repository.Context);
                }
                if (_auditTrailDetailRepository == null)
                {
                    _auditTrailDetailRepository = new GenericRepository<AuditTrailDetail>(Repository.Context);
                }

                try
                {
                    // Logs audit trail
                    AuditTrail auditTrail = new AuditTrail();
                    auditTrail.id = Guid.NewGuid().ToString();
                    auditTrail.object_id = entity.GetType().GetProperty("id").GetValue(entity, null).ToString();
                    auditTrail.object_type = entity.GetType().ToString();
                    auditTrail.action = action;
                    auditTrail.date_time = DateTime.Now;
                    auditTrail.user_id = CurrentUser.id;
                    _auditTrailRepository.Insert(auditTrail);

                    switch (entity.EntityState)
                    {
                        case EntityState.Added:
                            {
                                foreach (var property in entity.GetType().GetProperties())
                                {
                                    AuditTrailDetail auditTrailDetail = new AuditTrailDetail();
                                    auditTrailDetail.id = Guid.NewGuid().ToString();
                                    auditTrailDetail.parent_id = auditTrail.id;
                                    auditTrailDetail.property_name = property.Name;
                                    auditTrailDetail.old_value = string.Empty;
                                    auditTrailDetail.new_value = property.GetValue(entity, null) != null ? property.GetValue(entity, null).ToString() : null;
                                    _auditTrailDetailRepository.Insert(auditTrailDetail);
                                }
                            }
                            break;
                        case EntityState.Modified:
                            {
                                var stateEntry = Repository.Context.ObjectStateManager.GetObjectStateEntry(entity);
                                foreach (var propertyName in stateEntry.GetModifiedProperties())
                                {
                                    AuditTrailDetail auditTrailDetail = new AuditTrailDetail();
                                    auditTrailDetail.id = Guid.NewGuid().ToString();
                                    auditTrailDetail.parent_id = auditTrail.id;
                                    auditTrailDetail.property_name = propertyName;
                                    auditTrailDetail.old_value = stateEntry.OriginalValues[propertyName] != null ? stateEntry.OriginalValues[propertyName].ToString() : null;
                                    auditTrailDetail.new_value = stateEntry.CurrentValues[propertyName] != null ? stateEntry.CurrentValues[propertyName].ToString() : null;
                                    _auditTrailDetailRepository.Insert(auditTrailDetail);
                                }
                            }
                            break;
                        default: break;
                    }
                }
                catch (Exception ex)
                {
                    AppLogger.logError(this.ToString(), ex);
                    throw;
                }
            }
        }
        #endregion
    }
}