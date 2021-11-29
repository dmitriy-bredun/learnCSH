using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.General
{
    internal class Homework2_Convert
    {
        public static void Start()
        {
            // int intVal = 1234;
            // long longVal = (long)intVal;

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            int str1 = Convert.ToInt32(name1);
            int str2 = Convert.ToInt32(name2);
            Console.WriteLine($"name1 = {str1}");
            Console.WriteLine($"name2 = {str2}");
            Console.WriteLine($"name1 + name2");
            Console.WriteLine($"name1 + name2 = {str1 + str2}");
        }
    }
}
