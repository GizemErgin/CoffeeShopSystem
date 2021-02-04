using CoffeeShopSystem.Abstract;
using CoffeeShopSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopSystem.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstNAme { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
