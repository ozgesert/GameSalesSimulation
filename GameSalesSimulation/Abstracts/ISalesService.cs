using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstracts
{
   public interface ISalesService
    {
        void GameSales(Customer customer, Game game);
      
    }
}
