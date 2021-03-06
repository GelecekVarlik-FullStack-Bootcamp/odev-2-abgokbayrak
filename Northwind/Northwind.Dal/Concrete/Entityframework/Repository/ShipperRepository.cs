using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class ShipperRepository : GenericRepository<Shipper>, IShipperRepository
    {
        public ShipperRepository(DbContext context) : base(context)
        {
                
        }
    }
}
