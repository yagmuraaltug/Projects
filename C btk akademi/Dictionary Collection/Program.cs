using System;
using System.Collections.Generic;

namespace Dictionary_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("glass")); //false dondu.
        }
    }
}
