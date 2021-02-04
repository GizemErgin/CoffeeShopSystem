using CoffeeShopSystem.Abstract;
using CoffeeShopSystem.Entities;
using System;

namespace CoffeeShopSystem.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine(new Exception("Not a valid person"));
            }

        }
    }
}
