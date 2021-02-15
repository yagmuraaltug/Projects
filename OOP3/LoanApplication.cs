using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class LoanApplication
    {
        public void Application(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void CreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }

}
