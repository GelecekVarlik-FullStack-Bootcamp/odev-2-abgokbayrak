using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;


namespace Northwind.Bll
{
    public class ShipperManager : GenericManager<Shipper, DtoShipper>, IShipperService
    {
        private readonly IShipperRepository _shipperRepository;

        public ShipperManager(IShipperRepository shipperRepository)
        {
            _shipperRepository = shipperRepository;
        }
    }
}
