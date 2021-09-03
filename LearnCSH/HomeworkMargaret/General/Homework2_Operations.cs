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
                Console.WriteLine($"Число {x} больше числа {y}");
            }
            else 
            {
                Console.WriteLine($"Число {x} меньше числа {y}");
            }





            
        }
    }
}
