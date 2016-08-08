using System;

namespace AppCommon.CommonBusiness
{
    public interface IBusiness<T> where T : System.Data.Objects.DataClasses.EntityObject, new()
    {
        AppCommon.CommonRepository.IRepository<T> Repository { get; }

        #region Generic Methods
        System.Collections.Generic.IEnumerable<T> Search(string filter);
        T Get(string id);
        System.Collections.Generic.IEnumerable<T> GetAll();
        string Insert(System.Collections.Generic.IEnumerable<T> entities);
        string Insert(T entity);
        string Update(System.Collections.Generic.IEnumerable<T> entities);
        string Update(T entity);
        string Delete(string id);
        string Delete(T entity);
        #endregion

        #region Transaction
        //void Commit();
        void Dispose();
        //void Rollback();
        #endregion
    }
}