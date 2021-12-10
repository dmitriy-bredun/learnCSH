using System;

using HomeworkDmitriy.General;
using static System.Console;
using static System.Convert;
using static System.ConsoleColor;

namespace HomeworkDmitriy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = Green;

            WriteLine("   ///   Выберете Homework   ///   ");
            WriteLine();

            WriteLine("        0 - Тесты        ");
            WriteLine("        1 - Переменные        ");
            WriteLine("        2 - Конверт        ");
            WriteLine("        3 - Операции        ");
            WriteLine("        4 - Выброска пацанов        ");
            WriteLine("        5 - Циклы        ");
            WriteLine();

            int Choice = ToInt32(ReadLine());
            WriteLine();

            switch (Choice)
            {
                case 0:
                    WriteLine("Запущен Homework_0");
                    WriteLine();
                    WriteLine();
                    Homework0_Test.Task0();
                    break;

                case 1:
                    Write("Запущен Homework1_Variables");
                    WriteLine();
                    WriteLine();
                    Homework1_Variables.Start();
                    break;

                case 2:
                    Write("Запущен Homework2_Convert");
                    WriteLine();
                    WriteLine();
                    Homework2_Convert.Start();
                    break;

                case 3:
                    Write("Запущен Homework3_Operations");
                    WriteLine();
                    WriteLine();
                    Homework3_Operations.Start();
                    break;

                case 4:
                    Write("Запущен Homework4_VDV");
                    WriteLine();
                    WriteLine();
                    Homework4_VDV.Start();
                    break;

                case 5:
                    Write("Запущен Homework5_Cycles");
                    WriteLine();
                    WriteLine();
                    Homework5_Cycles.Start();
                    break;

                default:
                    Write("Выберете нужный Homework");
                    WriteLine();
                    WriteLine();
                    break;
            }
        }
    }
}
