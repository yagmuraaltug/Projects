using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
                
        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
}
