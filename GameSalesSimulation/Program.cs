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
            BaseCustomerManager baseCustomerManager1 = new CustomerManager(new MernisService());
            baseCustomerManager1.Save(new Customer
            {
                DateOfBirth = new DateTime(1996, 3, 14),
                CustomerName = "Özge",
                CustomerLastName = "Sert",
                NationalityId = "71674093216"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.NewCampaignAdd(new Campaign
            {
                CampaignId = 1,
                CampaignName = "% 30 İNDİRİM",
                CampaignDuration = new DateTime(2022, 9, 5)


            });

            ISalesService salesManager = new SalesManager();
            salesManager.GameSales(

                new Game { GameName = "League Of Legends", CategoryOfGame = "strategy", Price = 95 },
                new Customer
                {
                    Id = 1,
                    CustomerName = "Özge",
                    CustomerLastName = "Sert",
                    DateOfBirth = new DateTime(1996,3,14),
                    NationalityId = "71674093216"
                });
            Console.ReadLine();

        }
    }
}
