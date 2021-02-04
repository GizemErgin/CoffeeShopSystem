using CoffeeShopSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}