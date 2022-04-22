using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;


namespace Northwind.Bll
{
    public class RegionManager : GenericManager<Region, DtoRegion>, IRegionService
    {
        private readonly IRegionRepository _regionRepository;

        public RegionManager(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }
    }
}
