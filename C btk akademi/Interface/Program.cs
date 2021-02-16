using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            personManager.Add(new Customer { Id = 1, FirstName = "Yagmur", LastName = "Altug", Address = "Ankara" });

            Student student = new Student
            {
                Id = 2,
                FirstName = "Unsal",
                LastName = "Altug",
                Department = "Engineer"
            };
            personManager.Add(student);

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
