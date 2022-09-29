using System;

namespace InterfacesNN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface new'lenemez.
            Console.WriteLine("Hello World!");
           // IPersonManager customerManager = new CustomerManager();
           // IPersonManager employeeManager = new EmployeeManager();


            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
        interface IPersonManager
        {
            void Add();
            void Update();

        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri Eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri Güncelendi");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel Eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Personel Güncelendi");
            }
        }

        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer Eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer Güncelendi");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }
        }


    }
}
