using System;

using HomeworkDmitriy.General;
using HomeworkDmitriy.OOP.HW1_Classes;
using static System.Console;
using static System.Convert;
using static System.ConsoleColor;
using HomeworkDmitriy.OOP.HWGame;

namespace HomeworkDmitriy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = Green;

            WriteLine("   ///   Выбери Homework   ///   ");
            WriteLine();

            WriteLine("         0 - Тесты");
            WriteLine("         1 - Переменные");
            WriteLine("         2 - Конверт");
            WriteLine("         3 - Операции");
            WriteLine("         4 - Выброска пацанов");
            WriteLine("         5 - Циклы");
            WriteLine("         6 - Массивы");
            WriteLine("         7 - Массивы (повторение)");
            WriteLine("         8 - Классы, выбор процессора");
            WriteLine("         9 - Игра ''Смертельные гонки''");
            WriteLine();
            Write("         ");

            int Choice = ToInt32(ReadLine());
            WriteLine();

            switch (Choice)
            {
                case 0:
                    Homework0_Test.Task0();
                    break;

                case 1:
                    Homework1_Variables.Start();
                    break;

                case 2:
                    Homework2_Convert.Start();
                    break;

                case 3:
                    Homework3_Operations.Start();
                    break;

                case 4:
                    Homework4_VDV.Start();
                    break;

                case 5:
                    Homework5_Cycles.Start();
                    break;

                case 6:
                    Homework4_SimpleArrays.Start();
                    break;
                case 7:
                    Homework7_R_Arrays.Start();
                    break;
                case 8:
                    HW1_Class1.Start();
                    break;
                case 9:
                    Game.StartGame();
                    break;

                default:
                    Write("Ты не то жмакнул :О");
                    WriteLine();
                    WriteLine();
                    break;
            }
        }
    }
}
