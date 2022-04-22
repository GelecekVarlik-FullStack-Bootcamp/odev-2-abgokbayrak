using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;


namespace Northwind.Bll
{
    public class EmployeeTerritoryManager : GenericManager<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService
    {
        private readonly IEmployeeTerritoryRepository _employeeTerritoryRepository;

        public EmployeeTerritoryManager(IEmployeeTerritoryRepository employeeTerritoryRepository)
        {
            _employeeTerritoryRepository = employeeTerritoryRepository;
        }
    }
}
