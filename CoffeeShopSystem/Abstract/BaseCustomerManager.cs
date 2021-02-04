using CoffeeShopSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstNAme);
        }

    }
}
