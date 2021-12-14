using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.General
{
    internal class Homework3_Operations
    {
        public static void Start()
        {
            WriteLine("   ///   Выберете Таску   ///   ");
            WriteLine();

            WriteLine("         1 - Калькулятор");
            WriteLine("         2 - Найти максимальное число");
            WriteLine("         3 - Определение принадлежности к диапазону");
            WriteLine("         4 - К какой координатной четверти принадлежит точка");

            WriteLine();
            int Choice = ToInt32(ReadLine());
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
                    Write("Ты не то жмакнул :О");
                    break;
            }
        }

        public static void Task1()
        {
            Write("Введите первое дробное число: ");
            double x = ToDouble(ReadLine());

            Write("Введите нужный символ:");
            string operation = ReadLine();

            Write("Введите второе дробное число: ");
            double y = ToDouble(ReadLine());

            double result;

            if (operation == "+")
            {
                result = x + y;
                WriteLine($"результат: {x} + {y} = {result}");
            }
            else if (operation == "-")
            {
                result = x - y;
                WriteLine($"результат: {x} - {y} = {result}");
            }
            else if (operation == "*")
            {
                result = x * y;
                WriteLine($"результат: {x} * {y} = {result}");
            }
            else if (operation == "/")
            {
                result = x / y;
                WriteLine($"результат: {x} / {y} = {result}");
            }
        }
        public static void Task2()
        {
            Write("Введите первое число: ");
            int a = ToInt32(ReadLine());

            Write("Введите второе число: ");
            int b = ToInt32(ReadLine());

            Write("Введите третье число: ");
            int c = ToInt32(ReadLine());

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
            Write($"Максимальное число: {max}");
        }
        public static void Task3()
        {
            Write("Введите целое число от 1 до 1000: ");
            WriteLine();

            int znachenie = ToInt32(ReadLine());
            WriteLine();

            if (znachenie > 1 && znachenie < 1000)
            {
                WriteLine($"Число {znachenie} в диапазоне от 1 до 1000");
            }
            else
            {
                WriteLine($"Число {znachenie} в диапазоне от 1 до 1000");
            }
        }
        public static void Task4()
        {
            Write("Введите число 1: ");
            string XSrt = ReadLine();

            Write("Введите число 2: ");
            string YStr = ReadLine();

            int X = ToInt32(XSrt);
            int Y = ToInt32(YStr);

            if (X > 0 && Y > 0)
            {
                WriteLine("Точка пренадлежит к I координатной четверти");
            }
            else if (X > 0 && Y < 0)
            {
                WriteLine("Точка пренадлежит к IV координатной четверти");
            }
            else if (X < 0 && Y < 0)
            {
                WriteLine("Точка пренадлежит к III координатной четверти");
            }
            else
            {
                WriteLine("Точка пренадлежит к II координатной четверти");
            }
        }
    }
}
