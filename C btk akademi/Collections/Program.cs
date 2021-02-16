using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections 
{
    class Program
    {

        static void Main(string[] args)
        {
            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Antalya");

            //cities.Add("Istanbul");
            //cities.Add(1);
            //cities.Add("A");                  ARRAYLIST
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            List<string> cities = new List<string>(); //string tanimladigimiz icin sadece stringler ile calisabiliriz.
            cities.Add("Ankara");
            cities.Add("Antalya");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Yagmur" },
            new Customer { Id = 2, FirstName = "Unsal" }
        };
            var customer6 = new Customer
            {
                Id = 6,
                FirstName = "Canan"
            };
            customers.Add(customer6);
       
            //METOTLAR
            var count = customers.Count;
            Console.WriteLine("Eleman sayisi" +  count);
            customers.AddRange(new Customer[2]{
                new Customer{Id = 3, FirstName = "Asli" },
                new Customer{Id= 4, FirstName="Ali"}
            }); //array bazli lista verilir.

            // customers.Clear(); Butun elemanlari siler.
            Console.WriteLine(customers.Contains(customer6)); //Aradigimiz deger var mi diye arama yapar.

            var index = customers.IndexOf(customer6); //: customer2 kacinci sirada?
            Console.WriteLine(index);

            Console.WriteLine(customers.LastIndexOf(customer6)); // sondan ariyor

            customers.Insert(4, customer6); //Kacinci siraya neyi eklemek istiyorsun.

            customers.Remove(customer6);
            customers.RemoveAll(c => c.FirstName == "Canan"); //cananlarin hepsini sildik.
            



            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Yagmur" });
            //customers.Add(new Customer { Id = 2, FirstName = "Unsal" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id +  customer.FirstName);
            }


        }
    }


}
