using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.MusteriNo = "12345";
            customer1.FirstName = "Yagmur";
            customer1.Surname = "Altug";
            customer1.TcNo = "12345678941";
            customer1.Id = 1;


            CorporateCustomer customer2 = new CorporateCustomer();
            customer1.Id = 2;
            customer2.MusteriNo = "12563";
            customer2.CompanyName = "Rain Consultancy";
            customer2.VergiNo = "1234667889";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
