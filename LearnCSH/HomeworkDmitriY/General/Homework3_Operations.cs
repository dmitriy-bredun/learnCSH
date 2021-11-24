using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDmitriy.General
{
    internal class Homework3_Operations
    {
        public static void Start1()
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Введите первое дробное число: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите нужный символ:");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите второе дробное число: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result;

            if (operation == "+")
            {
                result = x + y;
                Console.WriteLine($"результат: {x} + {y} = {result}");
            }
            else if (operation == "-")
            {
                result = x - y;
                Console.WriteLine($"результат: {x} - {y} = {result}");
            }
            else if (operation == "*")
            {
                result = x * y;
                Console.WriteLine($"результат: {x} * {y} = {result}");
            }
            else if (operation == "/")
            {
                result = x / y;
                Console.WriteLine($"результат: {x} / {y} = {result}");
            }
        }
        public static void Start2()
        {
            Console.WriteLine("Найти максимальное число из трех чисел");
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max;
            
            if (a > b)          //if = если
                max = a;
            else if (b > c)                  //else = ещё
                max = b;
            else           //if = ещё
                max = c;

            Console.WriteLine($"максимальное число: {max}");
        }
    }
}
