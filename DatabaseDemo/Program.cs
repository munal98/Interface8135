using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            OracleDatabase sql = new OracleDatabase()
            {
                company = "Microsoft",
                Name = "SQL Server"
            };
            sql.List();
            sql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public string Name { get; set; }
        public string company; // eğer bir alan public değilse başına _konur.



        public void Add()
        {
            Console.WriteLine("Added by " + Name);
        }

        public void Update()
        {
            Console.WriteLine("Updated by " + Name);
        }

        public void Delete()
        {
            Console.WriteLine("Deleteced by " + Name);
        }
        public void List()
        {
            Console.WriteLine("Listed by " + Name);
        }
    }
    class SqlDatabase : Database
    {
        
    }

    class OracleDatabase : Database
    {

    }
}

