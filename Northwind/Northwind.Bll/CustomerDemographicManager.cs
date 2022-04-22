using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;


namespace Northwind.Bll
{
    public class CustomerDemographicManager : GenericManager<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        private readonly ICustomerDemographicRepository _customerDemographicRepository;

        public CustomerDemographicManager(ICustomerDemographicRepository customerDemographicRepository)
        {
            _customerDemographicRepository = customerDemographicRepository;
        }
    }
}
