using System;
using static System.Console;

namespace HomeworkOleg.Practice
{
    class Practice1_Cycles
    {
        public static void Start()
        {
            int userChoice;

            do
            {
                Menu();
                userChoice = Convert.ToInt32(ReadLine());

                switch (userChoice)
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

                    case 0:
                        WriteLine("Асталависта, бро )");
                        break;

                    default:
                        WriteLine("Не корректный ввод");
                        break;
                }

                WriteLine();
                WriteLine();
            } while (userChoice != 0);
        }
        private static void Task1()
        {
            Write("Введите число 1: ");
            int a = Convert.ToInt32(ReadLine());

            Write("Введите число 2: ");
            int b = Convert.ToInt32(ReadLine());

            int counter = 0;

            while (a <= b)
            {
                if (a > 0)
                {
                    counter++;
                }
                a++;
            }

            WriteLine($"Количество положительных чисел = {counter}");
        }
        private static void Task2()
        {
            Write("Введите число 1: ");
            int a = Convert.ToInt32(ReadLine());

            Write("Введите число 2: ");
            int b = Convert.ToInt32(ReadLine());

            int counter = 0;

            while (a <= b)
            {
                if (a % 3 == 0 && a != 0)
                {
                    counter++;
                }
                a++;
            }

            WriteLine($"Количество чисел кратных 3м = {counter}");
        }

        private static void Task3()
        {
            Write("Введите число 1: ");
            int a = Convert.ToInt32(ReadLine());

            Write("Введите число 2: ");
            int b = Convert.ToInt32(ReadLine());

            int sum = 0;

            while (a <= b)
            {
                if (a % 5 == 0 && a != 0)
                {
                    sum = sum + a;
                }
                a++;
            }
            WriteLine($"Сумма чисел кратных 5ти равна {sum}");
        }

        public static void Menu()
        {
            WriteLine("MENU: ");
            WriteLine("1 - Посчитать количество положительных чисел ");
            WriteLine("2 - Посчитать количество чисел кратных 3м ");
            WriteLine("3 - Посчитать сумму элементов кратных 5ти ");
            WriteLine("0 - Выход");
            Write("---> ");
        }
    }
}