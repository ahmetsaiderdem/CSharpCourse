using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            sqlserver.Add();

            MySqlDatabase mySqlDatabase = new MySqlDatabase();
            mySqlDatabase.Add();

            Console.ReadLine();

        }
    }
    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : DataBase
    {
        public override void Add()
        {

            base.Add();
        }
    }
    class MySqlDatabase : DataBase
    {

    }
}
