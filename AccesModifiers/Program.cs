using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        int Id;
        public void Save()
        {

        }
    }
    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();
            //customer.
        }
    }
    public class Course
    {
        public String Name { get; set; }
    }
}
