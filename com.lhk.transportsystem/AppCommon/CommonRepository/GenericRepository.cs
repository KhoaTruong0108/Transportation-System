using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.CommonRepository
{
    public class GenericRepository<T> : IDisposable, IRepository<T> where T : EntityObject, new()
    {
        private ThanhVanTranSysEntities _context;
        public ThanhVanTranSysEntities Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new ThanhVanTranSysEntities();
                }
                return _context;
            }
        }

        private ObjectSet<T> _entitiesSet;
        public ObjectSet<T> EntitiesSet
        {
            get
            {
                if (_entitiesSet == null)
                {
                    _entitiesSet = Context.CreateObjectSet<T>();
                }
                return _entitiesSet;
            }
        }

        private List<T> _entitiesList;
        public List<T> EntitiesList
        {
            get
            {
                _entitiesList = EntitiesSet.ToList();
                return _entitiesList;
            }
        }

        public GenericRepository()
            : base()
        {
            AppLogger.logDebug(this.ToString(), string.Format("Initializes {0}.", this.GetType().ToString()));
        }

        public GenericRepository(ThanhVanTranSysEntities context)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Initializes {0} with context.", this.GetType().ToString()));
            _context = context;
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = null;
            AppLogger.logDebug(this.ToString(), string.Format("Begin finding entities of {0}.", typeof(T)));
            AppLogger.logDebug(this.ToString(), string.Format("Expression: '{0}'.", predicate != null ? predicate.Body.ToString() : string.Empty));
            try
            {
                query = EntitiesSet;
                if (predicate != null)
                {
                    query = query.Where(predicate);
                }
                AppLogger.logDebug(this.ToString(), string.Format("Found: {0}.", query.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish finding entities of {0}.", typeof(T)));
            return query;
        }

        public virtual T Get(Func<T, bool> predicate)
        {
            T entity = null;
            AppLogger.logDebug(this.ToString(), string.Format("Begin getting entity of {0}.", typeof(T)));
            try
            {
                if (predicate != null)
                {
                    entity = EntitiesSet.FirstOrDefault(predicate);
                    if (entity != null)
                    {
                        AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} found.", typeof(T)));
                        AppLogger.logDebug(this.ToString(), "GET", entity);
                        EntitiesSet.Detach(entity);
                    }
                    else
                    {
                        AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} not found.", typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish getting entity of {0}.", typeof(T)));
            return entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            IEnumerable<T> entities = null;
            AppLogger.logDebug(this.ToString(), string.Format("Begin getting all entities of {0}.", typeof(T)));
            try
            {
                entities = EntitiesSet;
                AppLogger.logDebug(this.ToString(), string.Format("Found: {0}.", entities.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish getting all entities of {0}.", typeof(T)));
            return entities;
        }

        public virtual IQueryable<T> Search(string filter)
        {
            ObjectQuery<T> query = null;
            AppLogger.logDebug(this.ToString(), string.Format("Begin searching for entities of {0}.", typeof(T)));
            AppLogger.logDebug(this.ToString(), string.Format("Filter: \"{0}\".", filter));
            try
            {
                query = EntitiesSet;
                if (!string.IsNullOrEmpty(filter))
                {
                    query = query.Where(filter);
                }
                AppLogger.logDebug(this.ToString(), string.Format("Found: {0}.", query.Count()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish searching for entities of {0}.", typeof(T)));
            return query;
        }

        public virtual void Insert(T entity)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin inserting entity of {0}.", typeof(T)));
            try
            {
                AppLogger.logDebug(this.ToString(), "INSERT", entity);
                EntitiesSet.AddObject(entity);
                AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} inserted successfully.", typeof(T)));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while inserting entity of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish inserting entity of {0}.", typeof(T)));
        }

        public virtual void Insert(IEnumerable<T> entities)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin inserting entities of {0}. Count: {1}.", typeof(T), entities.Count()));
            try
            {
                foreach (T entity in entities)
                {
                    AppLogger.logDebug(this.ToString(), "INSERT", entity);
                    EntitiesSet.AddObject(entity);
                }
                AppLogger.logDebug(this.ToString(), string.Format("Entities of {0} inserted successfully.", typeof(T)));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while inserting entities of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish inserting entities of {0}.", typeof(T)));
        }

        public virtual void Update(T entity)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin updating entity of {0}.", typeof(T)));
            try
            {
                AppLogger.logDebug(this.ToString(), "UPDATE", entity);
                if (entity.EntityState == EntityState.Detached)
                {
                    var id = entity.GetType().GetProperty("id").GetValue(entity, null).ToString();
                    var attachedEntity = EntitiesSet.AsEnumerable().FirstOrDefault(e => e.EntityKey.EntityKeyValues[0].Value.Equals(id));
                    if (attachedEntity != null)
                    {
                        // HACK: Do the trick to detach the existed entity and attach the new entity, then apply the original values
                        // from the old entity to the new entity. This will set the new entity's state to "Modified" and the
                        // ObjectStateManager will track only different values.
                        EntitiesSet.Detach(attachedEntity);
                        EntitiesSet.Attach(entity);
                        var entry = Context.ObjectStateManager.GetObjectStateEntry(entity);
                        entry.ApplyOriginalValues(attachedEntity);
                    }
                }
                AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} updated successfully.", typeof(T)));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while updating entity of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish updating entity of {0}.", typeof(T)));
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin updating entities of {0}. Count: {1}.", typeof(T), entities.Count()));
            try
            {
                foreach (T entity in entities)
                {
                    AppLogger.logDebug(this.ToString(), "UPDATE", entity);
                    if (entity.EntityState == EntityState.Detached)
                    {
                        var id = entity.GetType().GetProperty("id").GetValue(entity, null).ToString();
                        var attachedEntity = EntitiesSet.AsEnumerable().FirstOrDefault(e => e.EntityKey.EntityKeyValues[0].Value.Equals(id));
                        if (attachedEntity != null)
                        {
                            EntitiesSet.Detach(attachedEntity);
                            EntitiesSet.Attach(entity);
                            var entry = Context.ObjectStateManager.GetObjectStateEntry(entity);
                            entry.ApplyOriginalValues(attachedEntity);
                        }
                    }
                }
                AppLogger.logDebug(this.ToString(), string.Format("Entities of {0} updated successfully.", typeof(T)));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while updating entities of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish updating entities of {0}.", typeof(T)));
        }

        public virtual void InsertOrUpdate(T entity)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin inserting or updating entity of {0}.", typeof(T)));
            try
            {
                AppLogger.logDebug(this.ToString(), "INSERT OR UPDATE", entity);
                string id = entity.GetType().GetProperty("id").GetValue(entity, null).ToString();
                var attachedEntity = EntitiesSet.AsEnumerable().FirstOrDefault(e => e.EntityKey.EntityKeyValues[0].Value.Equals(id));
                if (attachedEntity != null)
                {
                    EntitiesSet.Detach(attachedEntity);
                    EntitiesSet.Attach(entity);
                    var entry = Context.ObjectStateManager.GetObjectStateEntry(entity);
                    entry.ApplyOriginalValues(attachedEntity);
                }
                else
                {
                    EntitiesSet.AddObject(entity);
                }
                AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} inserted or updated successfully.", typeof(T)));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while inserting or updating entity of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish inserting or updating entity of {0}.", typeof(T)));
        }

        public virtual void InsertOrUpdate(IEnumerable<T> entities)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin inserting or updating entities of {0}. Count: {1}.", typeof(T), entities.Count()));
            try
            {
                foreach (T entity in entities)
                {
                    AppLogger.logDebug(this.ToString(), "INSERT OR UPDATE", entity);
                    string id = entity.GetType().GetProperty("id").GetValue(entity, null).ToString();
                    var attachedEntity = EntitiesSet.AsEnumerable().FirstOrDefault(e => e.EntityKey.EntityKeyValues[0].Value.Equals(id));
                    if (attachedEntity != null)
                    {
                        EntitiesSet.Detach(attachedEntity);
                        EntitiesSet.Attach(entity);
                        var entry = Context.ObjectStateManager.GetObjectStateEntry(entity);
                        entry.ApplyOriginalValues(attachedEntity);
                    }
                    else
                    {
                        EntitiesSet.AddObject(entity);
                    }
                }
                AppLogger.logDebug(this.ToString(), string.Format("Entities of {0} inserted or updated successfully.", typeof(T)));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while inserting or updating entities of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish inserting or updating entities of {0}.", typeof(T)));
        }

        public virtual void Delete(T entity)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin deleting entity of {0}.", typeof(T)));
            try
            {
                if (entity != null)
                {
                    AppLogger.logDebug(this.ToString(), "DELETE", entity);
                    EntitiesSet.Attach(entity);
                    Context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Deleted);
                    AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} deleted successfully.", typeof(T)));
                }
                else
                {
                    AppLogger.logDebug(this.ToString(), string.Format("Entity of {0} not found.", typeof(T)));
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while deleting entity of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish deleting entity of {0}.", typeof(T)));
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin deleting entities of {0}. Count: {1}.", typeof(T), entities.Count()));
            try
            {
                foreach (T entity in entities)
                {
                    AppLogger.logDebug(this.ToString(), "DELETE", entity);
                    EntitiesSet.Attach(entity);
                    Context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Deleted);
                }
                AppLogger.logDebug(this.ToString(), string.Format("Entities of {0} deleted successfully.", entities.GetType()));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while deleting entities of {0}.", typeof(T)), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish deleting entities of {0}.", typeof(T)));
        }

        public virtual void Delete(Expression<Func<T, bool>> predicate)
        {
            AppLogger.logDebug(this.ToString(), string.Format("Begin deleting entities of {0}.", typeof(T)));
            AppLogger.logDebug(this.ToString(), string.Format("Expression: '{0}'.", predicate.Body.ToString()));
            try
            {
                if (predicate != null)
                {
                    IEnumerable<T> entities = EntitiesSet.Where(predicate);
                    AppLogger.logDebug(this.ToString(), string.Format("Count: {0}", entities.Count()));
                    foreach(T entity in entities)
                    {
                        AppLogger.logDebug(this.ToString(), "DELETE", entity);
                        Context.DeleteObject(entity);
                    }
                    AppLogger.logDebug(this.ToString(), string.Format("Deleted entities of {0} successfully.", typeof(T)));
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), string.Format("Error occurs while deleting entities of {0}. Predicate: '{1}'.", typeof(T), predicate.Body.ToString()), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish deleting entities of {0}.", typeof(T)));
        }

        public virtual int ExecuteCommand(string command, params System.Data.SqlClient.SqlParameter[] parameters)
        {
            int affectedRowCount = 0;
            AppLogger.logDebug(this.ToString(), string.Format("Begin executing command: {0}.", command));
            var paramsList = new List<string>();
            string paramInfo = string.Empty;
            foreach (var param in parameters)
            {
                paramsList.Add(string.Format("{0} = {1}", param.ParameterName, param.Value));
            }
            paramInfo = string.Format("Params: {{0}}", string.Join(", ", paramsList));
            AppLogger.logDebug(this.ToString(), paramInfo);
            try
            {
                affectedRowCount = Context.ExecuteStoreCommand(command, parameters);
                AppLogger.logDebug(this.ToString(), string.Format("Command executed successfully. Number of rows affected: {0}.", affectedRowCount));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                throw;
            }
            AppLogger.logDebug(this.ToString(), string.Format("Finish executing command.", command));
            return affectedRowCount;
        }

        public virtual void Refresh(RefreshMode mode)
        {
            Context.Refresh(mode, EntitiesSet);
        }

        public virtual void Commit()
        {
            //Context.AcceptAllChanges();
            Context.SaveChanges();
            AppLogger.logInfo(this.ToString(), "Committed.");
        }

        public virtual void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                AppLogger.logInfo(this.ToString(), "Context disposed.");
            }
        }

        public virtual void Rollback()
        {
            //foreach (var entity in Context.CreateObjectSet<T>())
            foreach (var entry in Context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted))
            {
                if (entry.Entity != null)
                {
                    switch (((T)entry.Entity).EntityState)
                    {
                        // Deletes added entities
                        case EntityState.Added:
                            Context.DeleteObject(entry.Entity);
                            //Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Detached);
                            break;
                        // Refresh modified entities
                        case EntityState.Modified:
                            Context.Refresh(RefreshMode.StoreWins, entry.Entity);
                            //Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Unchanged);
                            break;
                        // Restores deleted entities
                        case EntityState.Deleted:
                            Context.Refresh(RefreshMode.StoreWins, entry.Entity);
                            //Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Unchanged);
                            break;
                        default: break;
                    }
                }
            }
            //Context.AcceptAllChanges();
            AppLogger.logInfo(this.ToString(), "Rolled back.");
        }
    }
}