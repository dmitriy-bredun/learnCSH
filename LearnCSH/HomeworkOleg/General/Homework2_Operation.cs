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
            int max;
            
                if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }

            if (max < d)
            {
                max = d;
            }

            if (max < e)
            {
                max = e;
            }

            Console.WriteLine($"максимальное число: {max}");
        }
        public static void Start5()
        {
            string sizeXStr;
            string sizeYStr;
            string cordXStr;
            string cordYStr;

            Console.WriteLine("Введите границы карты...");
            Console.Write("введите размер х: ");
            sizeXStr = Console.ReadLine();

            Console.Write("введите размер у: ");
            sizeYStr = Console.ReadLine();

            Console.WriteLine("Введите координаты сброса: ");
            Console.Write("введите координату х: ");
            cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            cordYStr = Console.ReadLine();

            int cordX = Convert.ToInt32(cordXStr);
            int cordY = Convert.ToInt32(cordYStr);

            int sizeX = Convert.ToInt32(sizeXStr);
            int sizeY = Convert.ToInt32(sizeYStr);


            if (cordX + 1 <= sizeX)

            {
                Console.Write("СбросЭ");
            }
            if (cordY + 1 <= sizeY)
            {
                Console.Write("ФАЙЕЕЕЕРРР");
            }
            if (cordX - 1 > 0)
            {
                Console.Write("ФАЙЕЕЕЕРРРРР");
            }
            if (cordY - 1 > 0)
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




