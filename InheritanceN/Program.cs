using System;

namespace InheritanceN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer();
            Person[] persons = new Person[]
            {
                new Customer(){FirstName="Sercan"},
                new Student(){FirstName="ST"}
            };

      
           
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Perason2
    {

    }
    class Customer : Person
    {
        public string City { get; set; }

    }
    class Student : Person
    {
        public string Departmant { get; set; }

    }

}
