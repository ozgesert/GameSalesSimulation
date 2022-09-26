using GameSalesSimulation.Abstracts;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concretes
{
    public class SalesManager : ISalesService
    {
        public void GameSales(Customer customer, Game game)
        {
            Console.WriteLine("The game named " + game.GameName + "was bought by" +customer.CustomerName);
        }
    }
}
