using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{Name = "Yagmur"},
                new Student{Name = "Unsal" },
                new Person{Name = "Senem"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
