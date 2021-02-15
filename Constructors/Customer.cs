using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        public Customer(int id, string name, string surname, string city)
        {
            Console.WriteLine("Yapici Blok Calisti.");
            Name = name;
            Id = id;
            SurName = surname;
            City = city;
                }
        public Customer()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }

    }
}
