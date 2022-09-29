using System;

namespace InterfacesN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PersonManager manager = new PersonManager();
            manager.Add(new Customer {Id=1,FirstName="Sercan",LastName="Turan",Adress="İstanbul" });
            Student student = new Student() { Id=2,FirstName="ST",LastName="TS",Departmant="Yazılım"};
            manager.Add(student);
            manager.Add(new Worker() { Id=3,FirstName="SS",LastName="TT",Departmant="Yazılım Geliştirici"});

            
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
