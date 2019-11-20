using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("ankara");
            cities.Add("İSTANBUL");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
