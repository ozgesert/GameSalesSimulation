using GameSalesSimulation.Abstracts;
using GameSalesSimulation.Concretes;
using GameSalesSimulation.Entities;
using System;

namespace GameSalesSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager1 = new CustomerManager(new MernisService() );
            baseCustomerManager1.Save(new Customer
            {
                DateOfBirth = new DateTime(1996, 3, 14),
                CustomerName = "Özge",
                CustomerLastName = "Sert",
                NationalityId = "71698093216"

            });

        }
    }
}
