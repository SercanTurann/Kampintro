using System;

namespace ConstructorsN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 şekilde kullanılabilir
            Customer customer1 = new Customer () { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        //Default costructor (eğer bir ctor yok ise arka tarafta default ctor çalışır)

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
