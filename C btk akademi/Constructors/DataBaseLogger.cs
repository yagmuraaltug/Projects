using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
}

