using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer 
            { Id = 1, Name = "Yagmur", SurName = "Altug", City = "Ankara" };

            Customer customer2 = new Customer(2,"Unsal","Altug","Antalya");

            Console.WriteLine(customer2.Name);
        }

    }
}
