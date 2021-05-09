using CoffeeShopSystem.Abstract;
using CoffeeShopSystem.Adapters;
using CoffeeShopSystem.Concrete;
using CoffeeShopSystem.Entities;
using System;

namespace CoffeeShopSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { Id = 1, FirstNAme = "Gizem", LastName = "Egin", DateOfBirth = new DateTime(1993, 8, 9), NationalityId = "" });


        }
    }
}
