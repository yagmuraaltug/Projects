using System;

namespace C_btk_akademi
{
    class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());


            ICustomerDal[] customerDals = new ICustomerDal[] //Burada baska veri tabani olsayd onun sayisi kadar sayi tanimlayabilirdik , [2] gibi
            {
                new SqlServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }
            Console.ReadLine();
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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

