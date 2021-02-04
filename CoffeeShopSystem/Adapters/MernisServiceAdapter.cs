using CoffeeShopSystem.Abstract;
using CoffeeShopSystem.Entities;
using MernisServiceAdaptor;
using System;
using System.Threading.Tasks;

namespace CoffeeShopSystem.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result= client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstNAme.ToUpper(), customer.LastName.ToUpper(),
               customer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
