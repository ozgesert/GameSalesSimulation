using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstracts
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : " +customer.CustomerName);
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Customer saved : " + customer.CustomerName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated : " + customer.CustomerName);
        }
    }
}
