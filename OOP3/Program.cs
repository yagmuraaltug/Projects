using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
           
            ICreditManager vehicleLoanManager = new VehicleLoanManager();

            ICreditManager mortgageLoanManager = new MortgageLoanManager();



            LoanApplication application = new LoanApplication();
            application.Application(vehicleLoanManager, new DataBaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager> { mortgageLoanManager, vehicleLoanManager };
            
                //application.CreditInformation(credits);
            

        }
    }
}
