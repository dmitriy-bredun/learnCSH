using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy
{
    internal class Homework5_Cycles
    {
        public static void Start()
        {
            WriteLine("   ///   Выберете Таску   ///   ");
            WriteLine();

            WriteLine("        1 - С помощью цикла вывести в консоль 15 символов: 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0        ");
            WriteLine("        2 - С помощью цикла вывести к консоль 15 символов: 0 0 0 0 5 0 0 0 0 10 0 0 0 0 15        ");
            WriteLine("        3 - С помощью цикла вывести в консоль 15 символов: 0 0 0 0 5 1 0 1 0 10 0 0 0 0 15        ");
            WriteLine("        5 - С помощью цикла вывести в консоль 10 символов [ + + + + + + + + - - ]        ");
            WriteLine("        6 - Посчитать сумму ПОЛОЖИТЕЛЬНЫХ чисел кратных 13-ти ИЛИ 7-ми на промежутке от a до b (эти переменные вводит пользователь. Могут быть случаи, когда a > b и a < b)        ");
            WriteLine("        7 - Посчитать сколько (количество) чисел кратных 5-ти находится на промежутке от a до b (эти переменные вводит пользователь. Могут быть случаи, когда a > b и a < b)        ");
            WriteLine("        8 - Посчитать сколько (количество) отрицательных чисел кратных ОДНОВРЕМЕННО 3-м И 4-м находится на промежутке от а до b (эти переменные вводит пользователь. Могут быть случаи, когда a > b и a < b)        ");

            WriteLine();
            int Choice = ToInt32(ReadLine());
            WriteLine();

            switch (Choice)
            {
                case 1:
                    Task1();
                    break;

                case 2:
                    //Task2();
                    break;

                case 3:
                    //Task3();
                    break;

                case 4:
                    //Task4();
                    break;

                case 5:
                    //Task4();
                    break;

                case 6:
                    //Task4();
                    break;

                case 7:
                    //Task4();
                    break;

                case 8:
                    //Task4();
                    break;

                default:
                    Write("Сделай правильный выбор");
                    break;
            }
        }

        public static void Task1()
        {
            WriteLine("   ///   С помощью цикла вывести в консоль 15 символов: 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0   ///   ");
            WriteLine();


        }
    }
}