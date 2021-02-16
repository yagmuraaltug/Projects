using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    static class Teacher //static nesne yaptik, new islemi yapilamaz. Static nesneler ortak nesnelerdir.
    {
        public static int Number { get; set; } //static yaptik.
    }
    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

}
