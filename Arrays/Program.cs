﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "ahmet", "zeynep", "erdem" };
            //string[] students = new string[3];
            //students[0] = "ahmet";
            //students[1] = "zeynep";
            //students[2] = "erdem";

            //string[] students2 = new[] { "ahmet", "zeynep", "erdem" };
            

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"istanbul","izmit","balıkkesir"},
                {"ankara","konya","kırıkkale"},
                {"antalya","adana","mersin"},
                {"rize","trabzon","samsun"},
                {"izmir","muğla","manisa" } 
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***********");
            }

            Console.ReadLine();
            


        }
    }
}
