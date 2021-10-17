using static System.Console;
using System;


namespace HomeworkOleg.General
{
    class Homework3_Cycles
    {
        public static void Start()
        {
            {
                WriteLine("ДОМАШКА");
                WriteLine("1 - Задача 1 ");
                WriteLine("2 - Задача 2 - ");
                WriteLine("3 - Задача 3 - ");
                WriteLine("4 - Задача 4 - ");
                WriteLine("5 - Задача 5 - ");
                WriteLine("6 - Задача 6 - ");
                WriteLine("7 - Задача 7 - ");
                WriteLine("8 - Задача 8 - ");
                WriteLine("Exit ");
                Write("---> ");
                string usersChoice = ReadLine();

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
                    case "6":
                        //Task6();
                        break;
                    case "7":
                        //Task7();
                        break;
                    case "8":
                        //Task8();
                        break;
                    case "0":
                        // Exit;
                        break;
                    default:
                        WriteLine("/////////////////");
                        break;
                }
            }
        }
        public static void Task1()
        {
            int counter = 1;

            while (counter < 14)
            {
                if (counter % 2 == 0)
                {
                    Write("0 ");
                }
                else
                {
                    Write("1 ");
                }
                counter += 1;
            }
        }
        public static void Task2()
        {
            int counter = 1;

            while (counter < 14)
            {
                if (counter % 3 == 0)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                counter += 1;
            }
        }
        public static void Task3()
        {
            int counter = 1;

            while (counter < 14)
            {
                if (counter % 2 == 0 && counter < 7)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                counter += 1;
            }
        }
        public static void Task4()
        {
            int counter = 1;
            while (counter < 14)
            {
                if (counter % 2 == 0 && counter > 6)
                {
                    Write("1 ");
                }
                else
                {
                    Write("0 ");
                }
                counter += 1;
            }
        }
        public static void Task5()
        {
            WriteLine("Nomer 1: ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("Nomer 2: ");
            int b = Convert.ToInt32(ReadLine());

            int result = 0;

            while (a <= b || a >= b)
            {
                if (a % 5 == 0)
                {
                    result = result - 1;
                }
                else
                {
                    WriteLine("Noooob");
                }
                a++;

            }
            WriteLine($"result = {result}");
        }
    }
}

