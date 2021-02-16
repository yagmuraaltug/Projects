using System;
using System.Collections.Generic;
using System.Text;

namespace C_btk_akademi
{
    interface ICustomerDal
    {
        void Add();
        void UpDate();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");        }

        public void UpDate()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
    

