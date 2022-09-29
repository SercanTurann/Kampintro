using System;

namespace ClassesN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Sercan";
            customer.LastName = "Turan";
            customer.City = "İstanbul";

            Console.WriteLine(customer.FirstName);
        }
    }
}
