using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase 
                                              where TDto : IDtoBase
    {
        IResponse<List<TDto>> GetAll();

        IResponse<List<TDto>> GetAll(Expression<Func<TDto, bool>> predicate);

        IResponse<TDto> Find(int id);

        IResponse<TDto> Add(TDto item, bool saveChanges = true);

        Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);

        IResponse<TDto> Update(TDto item, bool saveChanges = true);

        bool Delete(int id);

        bool Delete(T item);
        IResponse<bool> DeleteById(int id, bool saveChanges = true);
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);

        IQueryable<TDto> GetQueryable();
    }
}
