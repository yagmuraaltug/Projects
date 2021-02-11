using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi1 = 29;
            var sayi2 = 5;
            var sayi3 = 55;

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("en buyuk sayi sayi 1'dir");
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("en buyuk sayi sayi 2'dir");
            }
            else
            {
                Console.WriteLine("en buyuk sayi sayi 3'dur");
            }

        }
    }
}
