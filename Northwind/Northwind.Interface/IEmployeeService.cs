using Northwind.Entity.Dto;
using Northwind.Entity.Models;

namespace Northwind.Interface
{
    public interface IEmployeeService : IGenericService<Employee, DtoEmployee>
    {
    }
}
