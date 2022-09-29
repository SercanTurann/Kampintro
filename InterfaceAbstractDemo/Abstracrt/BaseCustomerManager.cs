using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstracrt
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
