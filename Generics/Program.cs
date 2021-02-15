using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            myList<string> sehirler2= new myList<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Ankara");
        }
    }
}
