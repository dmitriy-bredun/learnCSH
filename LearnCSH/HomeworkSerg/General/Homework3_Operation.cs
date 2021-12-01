﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSerg.General
{
    class Homework3_Operation
    {
        public static void Start()
        {
            Console.WriteLine("ГЛАВНОЕ МЕНЮ !");
            Console.WriteLine();
            Console.WriteLine("Выбери что хочешь посмотреть и напиши соответствующую цифру:");
            Console.WriteLine();
            Console.WriteLine("1 - Задача 1. Маленький калькуляторчик");
            Console.WriteLine("2 - Задача 2. Нахождение максимального числа");
            Console.WriteLine("3 - Задача 3. Определение принадлежности к диапазону от 1 до 100");
            Console.WriteLine("4 - Задача 4. Определение координатной четверти");
            Console.WriteLine();
            Console.WriteLine("Твой выбор -->"); 
            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

                case "3":
                    Task3();
                    break;

                case "4":
                    Task4();
                    break;

                default:
                    Console.WriteLine("Ты хош посмотреть что то не то шо нуно !");
                    break;
            }
                //if (choice == "1")
                //{
                //    Task1();
                //}
                //else if (choice == "2")
                //{
                //    Task2();
                //}
                //else if (choice == "3")
                //{
                //    Task3();
                //}
                //else if (choice == "4")
                //{
                //    Task4();
                //}
                //else
                //{
                //    Console.WriteLine("Ты хош посмотреть что то не то шо нуно !");
                //}

                //Task1();
                //Task2();
                //Task3();
                //Task4();
        }

        public static void Task1()
        {
            Console.WriteLine("Задача 1. Маленький калькуляторчик");
            Console.WriteLine();
            Console.WriteLine("Введите два дробных (десятичных) числа и сделайте с ними что нибуть ;)");
            Console.WriteLine();
            Console.WriteLine("Введите первое дробное число:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите один из символов (+,-,*,/):");
            string operation = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введите второе дробное число:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double result;

            if (operation == "+")
            {
                result = x + y;
                Console.WriteLine($"= {result}");
            }
            else if (operation == "-")
            {
                result = x - y;
                Console.WriteLine($"= {result}");
            }
            else if (operation == "*")
            {
                result = x * y;
                Console.WriteLine($"= {result}");
            }
            else if (operation == "/")
            {
                result = x / y;
                Console.WriteLine($"= {result}");
            }
            else 
            {
                Console.WriteLine("Вы ввели не верный символ");
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Задача 2. Нахождение максимального числа");
            Console.WriteLine();
            Console.WriteLine("Введите поочередно три целых числа");
            Console.WriteLine();

            Console.WriteLine("Введите первое число:");
            Console.WriteLine();
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите второе число:");
            Console.WriteLine();
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите третье число:");
            Console.WriteLine();
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int over;

            if (number1 > number2)
            {
                over = number1;
            }
            else
            {
                over = number2;
            }
            if (over < number3)
            {
                over = number3;
            }
            Console.WriteLine($"Наибольшее число из введенных:  {over}");
        }
        public static void Task3()
        {
            Console.WriteLine("Задача 3. Определение принадлежности к диапазону от 1 до 100");
            Console.WriteLine();

            Console.WriteLine("Введите целое число от 1 до 100:");
            Console.WriteLine();
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //if (numb > 1)
            //{
            //    Console.WriteLine($"Введенное число {numb} > 1");
            //}
            //else
            //{
            //     Console.WriteLine($"Введенное число {numb} не попадает в заданный диапазон.");
            //}
            //if (numb < 100)
            //{
            //    Console.WriteLine($"Введенное число {numb} < 100");
            //}
            //else
            //{
            //    Console.WriteLine($"Введенное число {numb} не попадает в заданный диапазон.");
            //}
            //__________________________________________________________________________

            //bool esc = (numb > 1 && numb < 100);
            //Console.WriteLine(esc);
            //if (esc == true)
            //{
            //    Console.WriteLine($"Введенное число {numb} попадает в диапазон от 1до 100");
            //}
            //else
            //{
            //    Console.WriteLine($"Введенное число {numb} не попадает в диапазон от 1до 100");
            //}
            //_____________________________________________________________

            if (numb > 1 && numb < 100)
            {
                Console.WriteLine($"Введенное число {numb} попадает в диапазон от 1 до 100");
            }
            else
            {
                Console.WriteLine($"Введенное число {numb} не попадает в диапазон от 1 до 100");
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Задача 4. Определение координатной четверти");
            Console.WriteLine();

            Console.WriteLine("Для определения координатной четверти поочередно введите");
            Console.WriteLine("положительное или отрицательное значение точки по оси Х и Y.");
            Console.WriteLine();

            Console.WriteLine("Координаты по оси Х:");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Координаты по оси Y:");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Точка пренадлежит ПЕРВОЙ координатной четверти.");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Точка пренадлежит ВТОРОЙ координатной четверти.");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Точка пренадлежит ТРЕТЬЕЙ координатной четверти.");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Точка пренадлежит ЧЕТВЕРТОЙ координатной четверти.");
            }
            else
            {
                Console.WriteLine("Координаты не в нашем измерении !");
            }
        }
    }
}

