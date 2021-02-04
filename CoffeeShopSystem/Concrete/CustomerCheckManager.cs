using CoffeeShopSystem.Abstract;
using CoffeeShopSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSystem.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
