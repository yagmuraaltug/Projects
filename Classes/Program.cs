using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Name = "Yagmur";
            customer.Id = 1;

            Customer customer2 = new Customer
            {
                Id = 2, City = "Antalya", Name = "Unsal"
            };

            Console.WriteLine("Ilk musteri : " + customer.Name);

        }
    }
}
