using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repository
{
    public interface IRepository<T> where T : class, new()
    {
        int Insert(T t);
        int Update(T t);
        int Delete(T t);
        int SaveChanges();
    }
}
