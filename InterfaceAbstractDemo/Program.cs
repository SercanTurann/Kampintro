using InterfaceAbstractDemo.Abstracrt;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 1), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "2322323212" });

        }
    }
}
