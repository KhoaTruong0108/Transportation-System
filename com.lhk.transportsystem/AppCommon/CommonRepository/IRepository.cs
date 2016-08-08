using System;
namespace AppCommon.CommonRepository
{
    public interface IRepository<T> where T : System.Data.Objects.DataClasses.EntityObject, new()
    {
        DBManagement.ThanhVanTranSysEntities Context { get; }
        System.Collections.Generic.List<T> EntitiesList { get; }
        System.Data.Objects.ObjectSet<T> EntitiesSet { get; }

        #region Generic Methods
        System.Linq.IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null);
        //System.Linq.IQueryable<T> Search(string filter);
        T Get(Func<T, bool> predicate);
        //System.Collections.Generic.IEnumerable<T> GetAll();
        void Insert(System.Collections.Generic.IEnumerable<T> entities);
        void Insert(T entity);
        void Update(System.Collections.Generic.IEnumerable<T> entities);
        void Update(T entity);
        void InsertOrUpdate(System.Collections.Generic.IEnumerable<T> entities);
        void InsertOrUpdate(T entity);
        void Delete(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void Delete(System.Collections.Generic.IEnumerable<T> entities);
        void Delete(T entity);

        int ExecuteCommand(string command, params System.Data.SqlClient.SqlParameter[] parameters);

        void Refresh(System.Data.Objects.RefreshMode mode);
        #endregion

        #region Transaction
        void Commit();
        void Dispose();
        void Rollback();
        #endregion
    }
}