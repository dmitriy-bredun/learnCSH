using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkOleg.General
{
    class Homework2_Operation
    {
        public static void Start()
        {
            {
                Console.WriteLine("ДОМАШКА");
                Console.WriteLine("1 - Задача 1 - Найти большее из 2-х чисел");
                Console.WriteLine("2 - Задача 2 - Принадлежит ли число диапазону от 0 до 100");
                Console.WriteLine("3 - Задача 3 - Определить в какой четверти точка");
                Console.WriteLine("4 - Задача 4 - Найти максимум из 5-ти чисел");
                Console.WriteLine("5 - Задача 5 - Сброс вдвшникам еды");
                Console.Write("---> ");
                string usersChoice = Console.ReadLine();

                switch (usersChoice)
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
                    case "5":
                        Task5();
                        break;
                    default:
                        Console.WriteLine("СУКА БЛЭАТ ПИСЯТЬ НАУЧ");
                        break;
                }
            }
        }
        public static void Task1()
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
        public static void Task2()
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
        public static void Task3()
        {
            Console.WriteLine("к какой четверти относяться координаты ");

            Console.Write("введите координату х: ");
            string cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            string cordYStr = Console.ReadLine();

            int cordX = Convert.ToInt32(cordXStr);
            int cordY = Convert.ToInt32(cordYStr);

            if (cordX > 0 && cordY > 0)
            {
                Console.WriteLine("Точка в 1-й четверти");
            }
            else if (cordX < 0 && cordY < 0)
            {
                Console.WriteLine("Точка в 3-й четверти");
            }
            else if (cordX < 0 && cordY > 0)
            {
                Console.WriteLine("Точка в 2-й четверти");
            }
            else if (cordX > 0 && cordY < 0)
            {
                Console.WriteLine("Точка в 4-й четверти");
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Задача 4");
            Console.Write("Число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 4: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 5: ");
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

            Console.WriteLine($"Максимальное число: {max}");
        }
        public static void Task5()
        {
            Console.WriteLine("Введите границы карты...");
            Console.Write("введите размер х: ");
            string sizeXStr = Console.ReadLine();

            Console.Write("введите размер у: ");
            string sizeYStr = Console.ReadLine();

            Console.WriteLine("Введите координаты сброса: ");
            Console.Write("введите координату х: ");
            string cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            string cordYStr = Console.ReadLine();

            int coordX = Convert.ToInt32(cordXStr);
            int coordY = Convert.ToInt32(cordYStr);

            int sizeX = Convert.ToInt32(sizeXStr);
            int sizeY = Convert.ToInt32(sizeYStr);

            if (coordX + 1 <= sizeX)
            {
                Console.WriteLine($"По координате {coordX + 1}, {coordY} сбросить можно!");
            }
            if (coordY + 1 <= sizeY)
            {
                Console.WriteLine($"По координате {coordX}, {coordY + 1} сбросить можно!");
            }
            if (coordX - 1 > 0)
            {
                Console.WriteLine($"По координате {coordX - 1}, {coordY} сбросить можно!");
            }
            if (coordY - 1 > 0)
            {
                Console.WriteLine($"По координате {coordX}, {coordY - 1} сбросить можно!");
            }
        }
    }
}