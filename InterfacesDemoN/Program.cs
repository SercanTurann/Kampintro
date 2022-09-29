using System;

namespace InterfacesDemoN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var item in workers)
            {
                item.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var item in eats)
            {
                item.Eat();
            }

        }

        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void Salary();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
