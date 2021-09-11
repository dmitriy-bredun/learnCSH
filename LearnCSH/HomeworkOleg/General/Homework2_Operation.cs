using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkOleg.General
{
    class Homework2_Operation
    {
        public static void StartHomework2_Operation()
        {
            {
                Console.WriteLine("ДОМАШКА");
                Console.WriteLine("1 - Задача 1");
                Console.WriteLine("2 - Задача 2");
                Console.WriteLine("3 - Задача 3");
                Console.WriteLine("4 - Задача 4");
                Console.WriteLine("5 - Задача 5");
                Console.Write("---> ");
                string usersChoice = Console.ReadLine();

                switch (usersChoice)
                {
                    case "1":
                        Start1();
                        break;
                    case "2":
                        Start2();
                        break;
                    case "3":
                        Start3();
                        break;
                    case "4":
                        Start4();
                        break;
                    case "5":
                        Start5();
                        break;
                    default:
                        Console.WriteLine("СУКА БЛЭАТ ПИСЯТЬ НАУЧ");
                        break;
                }
            }
        }
        public static void Start1()
        {
            Console.WriteLine("Какое число больше?");
            Console.Write("Введите число 1: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string operation = Console.ReadLine();

            if (x == y)
            {
                Console.Write("РАВНЫ");
            }
            else if (x < y)
            {
                Console.Write($"result of {x} < {y} = {y}");
            }
            else
            {
                Console.Write($"result of {x} > {y} = {x}");

            }
        }
        public static void Start2()
        {
            Console.WriteLine("Пренадлежит ли число диапазону от 0 до 100?");
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x > 0 && x < 100)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("GG");
            }
        }
        public static void Start3()
        {
            string cordXStr;
            string cordYStr;

            Console.WriteLine("к какой четверти относяться координаты ");

            Console.Write("введите координату х: ");
            cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            cordYStr = Console.ReadLine();

            int cordX = Convert.ToInt32(cordXStr);
            int cordY = Convert.ToInt32(cordYStr);

            if (cordX > 0 && cordY > 0)
            {
                Console.Write("1");
            }
            else if (cordX < 0 && cordY < 0)
            {
                Console.Write("3");
            }
            else if (cordX < 0 && cordY > 0)
            {
                Console.Write("2");
            }
            else if (cordX > 0 && cordY < 0)
            {
                Console.Write("4");
            }
        }
        public static void Start4()
        {
            Console.WriteLine("Задача 4");
            Console.Write("Число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число: ");
            int e = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.Write($"result of {a} < {b} = {b}");
            }
            else if (a > b)
            {
                Console.Write($"result of {a} > {b} = {a}");
                if (b < c)
                {
                    Console.Write($"result of {b} < {c} = {c}");
                }
                else if (b > c)
                {
                    Console.Write($"result of {b} > {c} = {b}");
                }
                if (c < d)
                {
                    Console.Write($"result of {c} < {d} = {d}");
                }
                else if (c > d)
                {
                    Console.Write($"result of {c} > {d} = {c}");
                }
                if (d < e)
                {
                    Console.Write($"result of {d} < {e} = {e}");
                }
                else if (d > e)
                {
                    Console.Write($"result of {d} > {e} = {d}");
                }
            }
        }
        public static void Start5()
        {
            string cordXStr;
            string cordYStr;

            Console.WriteLine("АРА, АРА, Я АРЁЛ, куда скинуть хавку? ");

            Console.Write("введите координату х: ");
            cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            cordYStr = Console.ReadLine();

            int cordX = Convert.ToInt32(cordXStr);
            int cordY = Convert.ToInt32(cordYStr);

            if (cordX == 5 && cordY == 2 || cordX == 5 && cordY == 1)
            {
                Console.Write("ФАЙЕЕЕЕРРРРР");
            }
            else if (cordX == 2 && cordY == 1 || cordX == 1 && cordY == 2)
            {
                Console.Write("ФАЙЕЕЕЕРРРРР");
            }
            else if (cordX == 1 && cordY == 4 || cordX == 1 && cordY == 5)
            {
                Console.Write("ФАЙЕЕЕЕРРРРР");
            }
            else if (cordX == 5 && cordY == 4 || cordX == 4 && cordY == 4)
            {
                Console.Write("ФАЙЕЕЕЕРРРРР");
            }
            else
            {
                Console.Write("АРАДЖАНАМ КУДА СБРОСИЛ, ЭЭЭЭЭ");
            }

        }
    }
}




