using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mysql = new MySql();
            mysql.Add();

            Console.ReadLine();
        }


        class Datebase
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public void Delete()
            {
                Console.WriteLine("Deleted by default");

            }
        }

        class SqlServer : Datebase
        {
            public override void Add()
            {
                Console.WriteLine("Added by Sql Code");
                //base.Add();
            }
        }
        class MySql : Datebase
        {

        }
    }
}
