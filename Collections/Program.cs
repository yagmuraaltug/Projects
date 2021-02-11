using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { 
            "Yagmur", "Unsal", "Ilgin"
            };


            List<string> names2 = new List<string> { "Yagmur", "Unsal", "Senem" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Kamil");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]);


        }
    }
}
