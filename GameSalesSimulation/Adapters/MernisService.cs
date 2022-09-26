using GameSalesSimulation.Abstracts;
using GameSalesSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameSalesSimulation
{
    public class MernisService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalityId), customer.CustomerName.ToUpper(), customer.CustomerLastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
