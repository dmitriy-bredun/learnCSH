using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace HomeworkDmitriy.General
{
    internal class Homework3_Operations
    {
        public static void Start()
        {
            WriteLine("   ///   Выберете Таску   ///   ");
            WriteLine();

            WriteLine("        1 - Калькулятор        ");
            WriteLine("        2 - Найти максимальное число        ");
            WriteLine("        3 - Определение принадлежности к диапазону        ");
            WriteLine("        4 - К какой координатной четверти принадлежит точка        ");

            WriteLine();
            int Choice = Convert.ToInt32(ReadLine());
            WriteLine();

            switch (Choice)
            {
                case 1:
                    Task1();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                case 4:
                    Task4();
                    break;

                default:
                    Write("Сделай правильный выбор");
                    break;
            }
        }

        public static void Task1()
        {
            WriteLine("   ///   Калькулятор   ///   ");
            WriteLine();

            Write("Введите первое дробное число: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Write("Введите нужный символ:");
            string operation = Console.ReadLine();

            Write("Введите второе дробное число: ");
            double y = Convert.ToDouble(ReadLine());

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
        public static void Task2()
        {
            Console.WriteLine("   ///   Найти максимальное число из трех чисел   ///   ");
            Console.WriteLine();

            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max;
            
            if (a > b)
            {
                max = a;
            }
            else if (b > c)
            {
                max = b;
            }
            else
            {
                max=c;
            }
            Console.Write($"Максимальное число: {max}");
        }
        public static void Task3()
        {
            Console.WriteLine("   ///   Определение принадлежности к диапазону от 1 до 100.   ///   ");
            Console.WriteLine();

            Console.Write("Введите целое число от 1 до 1000: ");
            Console.WriteLine();

            int znachenie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (znachenie > 1 && znachenie < 1000)
            {
                Console.WriteLine($"Число {znachenie} в диапазоне от 1 до 1000");
            }
            else
            {
                Console.WriteLine($"Число {znachenie} в диапазоне от 1 до 1000");
            }
        }
        public static void Task4()
        {
            Console.WriteLine("   ///   К какой координатной четверти принадлежит точка?   ///   ");
            Console.WriteLine();
            Console.Write("Введите число 1: ");
            string XSrt = Console.ReadLine();

            Console.Write("Введите число 2: ");
            string YStr = Console.ReadLine();

            int X = Convert.ToInt32(XSrt);
            int Y = Convert.ToInt32(YStr);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Точка пренадлежит к I координатной четверти");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Точка пренадлежит к IV координатной четверти");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Точка пренадлежит к III координатной четверти");
            }
            else
            {
                Console.WriteLine("Точка пренадлежит к II координатной четверти");
            }
        }
    }
}
