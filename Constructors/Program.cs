using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(23);

            customerManager.List();
            Product product = new Product { Id = 1, Name = "ahmet" };
            Product product2 = new Product(2, "computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());

            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();


            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface Ilogger
    {
        void Log();
    }
    class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");
        }
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }
    class EmployeeManager
    {
        private Ilogger _logger;
        public EmployeeManager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("added");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity) ;
        }
    }
    class PersonManager : BaseClass
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
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {

        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done");
                
        }
    }



}

