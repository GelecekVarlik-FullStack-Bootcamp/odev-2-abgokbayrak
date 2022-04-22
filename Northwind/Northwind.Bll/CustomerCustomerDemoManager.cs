using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;


namespace Northwind.Bll
{
    public class CustomerCustomerDemoManager : GenericManager<CustomerCustomerDemo, DtoCustomerCustomerDemo>, ICustomerCustomerDemoService
    {
        private readonly ICustomerCustomerDemoRepository _customerCustomerDemoRepository;

        public CustomerCustomerDemoManager(ICustomerCustomerDemoRepository customerCustomerDemoRepository)
        {
            _customerCustomerDemoRepository = customerCustomerDemoRepository;
        }
    }
}
