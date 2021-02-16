using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(1995, 07, 31), FirstName = "Yagmur", LastName = "Altug", NationalityId = "136524856332"
            });
        }
    }
}
