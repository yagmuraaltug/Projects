using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class EmployerManager
    {
        private ILogger _logger;
        public EmployerManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
}
 