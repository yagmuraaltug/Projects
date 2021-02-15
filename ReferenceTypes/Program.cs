using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "Unsal";

            person2 = person1;
            person1.Name = "Yagmur";
            Console.WriteLine(person2.Name);


            Customer customer = new Customer();
            customer.Name = "Fatih";
            customer.CreditCardNumber = "52145632563";

            Employer employer = new Employer();
            employer.Name = "Veli";

            Person person3 = customer;
            customer.Name = "Asli";
            

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employer);
        }
    }
}
