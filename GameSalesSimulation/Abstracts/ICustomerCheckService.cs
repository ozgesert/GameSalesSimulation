using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstracts
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer );
    }
}
