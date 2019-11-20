using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            string sentences = "My name is ahmet erdem";

            var result = sentences.Length;
            var result2 = sentences.Clone();
            sentences= "My name is zeynep erdem";

            bool result3 = sentences.EndsWith("ğ");
            bool result4 = sentences.StartsWith("My name");

            var result5 = sentences.IndexOf("name");
            var result6 = sentences.IndexOf(" ");
            var result7 = sentences.LastIndexOf(" ");
            var result8 = sentences.Insert(0,"HELLO, ");
            var result9 = sentences.Substring(3,4);
            var result10 = sentences.ToLower();
            var result11 = sentences.ToUpper();
            var result12 = sentences.Replace(" ","-");
            var result13 = sentences.Remove(2);


            Console.WriteLine(result13);   
            Console.ReadLine();
        }

        private static void NewMethod()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "istanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
