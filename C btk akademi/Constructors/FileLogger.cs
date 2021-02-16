using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}
