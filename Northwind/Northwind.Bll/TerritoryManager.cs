using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;


namespace Northwind.Bll
{
    public class TerritoryManager : GenericManager<Territory, DtoTerritory>, ITerritoryService
    {
        private readonly ITerritoryRepository _territoryRepository;

        public TerritoryManager(ITerritoryRepository territoryRepository)
        {
            _territoryRepository = territoryRepository;
        }
    }
}
