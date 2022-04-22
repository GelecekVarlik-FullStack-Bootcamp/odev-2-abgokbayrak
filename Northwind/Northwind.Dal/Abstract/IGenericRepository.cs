using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IGenericRepository<T> where T : IEntityBase
    {
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> predicate);

        T Find(int id);

        T Add(T item);

        Task<T> AddAsync(T item);

        T Update(T item);

        bool Delete(int id);

        bool Delete(T item);

        IQueryable<T> GetQueryable();
    }
}
