using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.General
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
            WriteLine("        4 - С помощью цикла вывести в консоль 10 символов: 1 2 3 4 5 10 9 8 7 6        ");
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
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                case 4:
                    Task4();
                    break;

                case 5:
                    Task5();
                    break;

                case 6:
                    //Task6();
                    break;

                case 7:
                    //Task7();
                    break;

                case 8:
                    //Task8();
                    break;

                default:
                    Write("Сделай правильный выбор");
                    break;
            }
        }

        public static void Task1()
        {
            WriteLine("Выводим в консоль 15 символов: 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0");
            WriteLine();

            int count1 = 1;
            while (count1 <= 15)
            {
                if (count1 % 2 == 0)
                {
                    Write("  1");
                }
                else if (count1 % 1 == 0)
                {
                    Write("  0");
                }
                count1 += 1;
            }
        }
        public static void Task2()
        {
            WriteLine("Выводим в консоль 15 символов: 0 0 0 0 5 0 0 0 0 10 0 0 0 0 15");
            WriteLine();

            int countTask2 = 1;
            int kratnoe5Task2 = 5;

            while (countTask2 <= 15)
            {
                if (countTask2 % 5 == 0)
                {
                    Write($"  {kratnoe5Task2}");
                    kratnoe5Task2 += 5;
                }
                else
                {
                    Write("  0");
                }
                countTask2 += 1;
            }
        }
        public static void Task3()
        {
            WriteLine("Выводим в консоль 15 символов: 0 0 0 0 5 1 0 1 0 10 0 0 0 0 15");
            WriteLine();

            int countTask3 = 1;

            while (countTask3 <= 15)
            {
                if (countTask3 % 5 == 0)
                {
                    Write($"  {countTask3}");
                }
                else if (5 < countTask3 && countTask3 < 10)
                {
                    if (countTask3 % 2 == 0)
                    {
                        Write("  1");
                    }
                    else
                    {
                        Write("  0");
                    }
                }
                else
                { 
                    Write("  0");
                }
                countTask3 += 1;
            }
        }
        public static void Task4()
        {
            WriteLine("Выводим в консоль 10 символов: 1 2 3 4 5 10 9 8 7 6");
            WriteLine();

            int countTask4 = 1;
            
            while (countTask4 <= 5)
            {
                Write($"  {countTask4}");
                countTask4 += 1;
            }
            int countTask44 = 10;

            while (6 <= countTask44)
            {
                Write($"  {countTask44}");
                countTask44 -= 1;
            }
        }
        public static void Task5()
        {
            WriteLine("Выводим в консоль 10 символов: [ + + + + + + + + - - ]");
            WriteLine();

            int countTask5 = 1;

            while(countTask5 <= 10)
            {
                if (countTask5 == 1)
                {
                    Write("  [  +");
                }
                if (countTask5 >= 2 && countTask5 <= 8)
                {
                    Write("  +");
                }
                if (countTask5 == 9)
                {
                    Write("  -");
                }
                if (countTask5 == 10)
                {
                    Write("  -  ]");
                }
                countTask5 += 1;
            }
        }
    }
}