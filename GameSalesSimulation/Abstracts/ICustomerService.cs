using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstracts
{
    public interface ICustomerService
    {
        void  Save(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
       

    }
}
