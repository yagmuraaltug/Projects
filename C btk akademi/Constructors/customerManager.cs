using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class CustomerManager
    {
        private int _count= 15;
        public CustomerManager(int count)
        {
            _count = count;

        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("{0} items Listed", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
