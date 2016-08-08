using System;
using System.Collections.Generic;
using Thrift.Protocol;

namespace AppCommon.CommonBusiness
{
    public class RemoteBusiness<TProtocol, T> : IDisposable, IBusiness<T> where TProtocol : TBase where T: System.Data.Objects.DataClasses.EntityObject, new()
    {
        public void Dispose()
        {
        }

        public CommonRepository.IRepository<T> Repository
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<T> Search(string filter)
        {
            throw new NotImplementedException();
        }

        public T Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public string Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public string Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public string Update(T entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(string id)
        {
            throw new NotImplementedException();
        }

        public string Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
