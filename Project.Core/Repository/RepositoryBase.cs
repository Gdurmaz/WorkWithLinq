using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace Project.Core.Repository
{
    public class RepositoryBase<T> : Singleton.SingletonBase, IRepository<T> where T : class, new()
    {
        private DbSet<T> _table = null;
        protected RepositoryBase()
        {
            _table = _connDb.Set<T>();
        }
        public int Delete(T t)
        {
            Helper.TryCatchAction.TryCatch(() => {
                if (t!=null)
                {
                    _table.Remove(t);
                }
            });
            return SaveChanges();
        }
        public int Insert(T t)
        {
            Helper.TryCatchAction.TryCatch(() => {
                if (t != null)
                {
                    _table.Add(t);
                }
            });
            return SaveChanges();
        }
        public int SaveChanges()
        {
            return _connDb.SaveChanges();
        }
        public int Update(T t)
        {
            Helper.TryCatchAction.TryCatch(() => {
                if (t != null)
                {
                }
            });
            return SaveChanges();
        }
    }
}
