using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMargaret.General
{
    class Homework2_Operations
    {
        public static void Start()
        {
            Console.WriteLine("TAST #1");
            
            Console.Write("Введите число №1: ");
            string val1 = Console.ReadLine();

            Console.Write("Введите число №2: ");
            string val2 = Console.ReadLine();

            int x = Convert.ToInt32(val1);
            int y = Convert.ToInt32(val2);

            if (x == y)
            {
                Console.WriteLine($"Число {x} равно числу {y}");
            }
            else if (x > y)
            {
                Console.WriteLine($"Число {x} больше");
            }
            else 
            {
                Console.WriteLine($"Число {y} больше");
            }



            Console.WriteLine("TASK 2");

            Console.Write("Введите целое число: ");
            string val = Console.ReadLine();

            int number = Convert.ToInt32(val);

            if (number > 0 && number < 100)
            {
                Console.WriteLine("Число находится в диапазоне от 0 до 100");
            }
            else
            {
                Console.WriteLine("Число не находится в диапазоне от 0 до 100");
            }
        }
    }
}
