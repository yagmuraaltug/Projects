using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product
            {
                Id = 1,
                Name = "Table"
            };
            Product product1 = new Product(2, "Chair");
            Console.WriteLine(product.Name);
            Console.WriteLine(product1.Name);

            EmployerManager employeeManager = new EmployerManager(new DataBaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager manager = new Manager(); //class static olmadigi icin new ile cagirdik.
            manager.DoSomething2();  
            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log();
    }
}
