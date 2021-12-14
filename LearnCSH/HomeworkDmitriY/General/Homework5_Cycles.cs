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
            int usersChoice;

            do
            {
                WriteLine("   ///   Выбери Таску   ///   ");
                WriteLine();

                WriteLine("         1 - Выводим в консоль 15 символов: 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0");
                WriteLine("         2 - Выводим в консоль 15 символов: 0 0 0 0 5 0 0 0 0 10 0 0 0 0 15");
                WriteLine("         3 - Выводим в консоль 15 символов: 0 0 0 0 5 1 0 1 0 10 0 0 0 0 15");
                WriteLine("         4 - Выводим в консоль 10 символов: 1 2 3 4 5 10 9 8 7 6");
                WriteLine("         5 - Выводим в консоль 10 символов: [ + + + + + + + + - - ]");
                WriteLine("         6 - Сумма ПОЛОЖИТЕЛЬНЫХ чисел кратных 13-ти ИЛИ 7-ми на промежутке от a до b");
                WriteLine("         7 - Количество чисел кратных 5-ти на промежутке от a до b");
                WriteLine("         8 - Количество отрицательных чисел кратных 3-м И 4-м на промежутке от а до b");
                WriteLine("         0 - Жмакни что б выйти");
                WriteLine();
                Write("         ");

                usersChoice = ToInt32(ReadLine());
                WriteLine();

                switch (usersChoice)
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
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;

                    case 8:
                        Task8();
                        break;

                    case 0:
                        break;

                    default:
                        Write("Ты не то жмакнул :О");
                        break;
                }
            } while (usersChoice != 0);
        }

        public static void Task1()
        {
            int count = 1;

            while (count <= 15)
            {
                if (count % 2 == 0)
                {
                    Write(" 1");
                }
                else
                {
                    Write(" 0");
                }
                count += 1;
            }
            WriteLine();
            WriteLine();
        }
        public static void Task2()
        {
            int count = 1;

            while (count <= 15)
            {
                if (count % 5 == 0)
                {
                    Write($" {count}");
                }
                else
                {
                    Write(" 0");
                }
                count += 1;
            }
            WriteLine();
            WriteLine();
        }
        public static void Task3()
        {
            int count = 1;

            while (count <= 15)
            {
                if (count % 5 == 0)
                {
                    Write($" {count}");
                }
                else if (5 < count && count < 10)
                {
                    if (count % 2 == 0)
                    {
                        Write(" 1");
                    }
                    else
                    {
                        Write(" 0");
                    }
                }
                else
                {
                    Write(" 0");
                }
                count += 1;
            }
            WriteLine();
            WriteLine();
        }
        public static void Task4()
        {
            int count = 1;
            int number = 1;

            while (count <= 10)
            {
                Write($" {number}");
                if (number <= 5)
                {
                    number += 1;
                    if (number == 6)
                    {
                        number = 10;
                    }
                }
                else
                {
                    number -= 1;
                }
                count += 1;
            }
            WriteLine();
            WriteLine();
        }
        public static void Task5()
        {
            int count = 1;
            while (count <= 12)
            {
                if (count == 1)
                {
                    Write(" [");
                }
                if (count >= 2 && count <= 9)
                {
                    Write(" +");
                }
                if (count >= 10 && count <= 11)
                {
                    Write(" -");
                }
                if (count == 12)
                {
                    Write(" ]");
                }
                count += 1;
            }
            WriteLine();
            WriteLine();
        }
        public static void Task6()    // 12, 13, 14, 15,16,17,18,19,20, 21
        {
            Write("Введите первое число: ");
            int aPoint = ToInt32(ReadLine());

            Write("Введите второе число: ");
            int bPoint = ToInt32(ReadLine());

            int result = 0;
            int result7 = 0;
            int result13 = 0;
            WriteLine();

            if (aPoint < bPoint)
            {
                while (aPoint <= bPoint)
                {
                    if (aPoint > 0 && aPoint % 7 == 0)
                    {
                        result7 += aPoint;
                    }
                    else if (aPoint > 0 && aPoint % 13 == 0)
                    {
                        result13 += aPoint;
                    }
                    aPoint++;
                }
            }
            else if (aPoint > bPoint)
            {
                while (aPoint >= bPoint)
                {
                    if (bPoint > 0 && bPoint % 7 == 0)
                    {
                        result7 += bPoint;
                    }
                    else if (bPoint > 0 && bPoint % 13 == 0)
                    {
                        result13 += bPoint;
                    }
                    bPoint++;
                }
            }
            result = result7 + result13;
            WriteLine($"Сумма всех чисел равна: {result}");
            WriteLine($"Из них сумма кратных 7-ми: {result7}");
            WriteLine($"И сумма кратных 13-ти: {result13}");
            WriteLine();
        }
        public static void Task7()
        {
            Write("Введите первое число: ");
            int aPoint = ToInt32(ReadLine());

            Write("Введите второе число: ");
            int bPoint = ToInt32(ReadLine());
            int result = 0;
            WriteLine();

            if (aPoint < bPoint)
            {
                while (aPoint <= bPoint)
                {
                    if (aPoint % 5 == 0)
                    {
                        result++;
                    }
                    aPoint++;
                }
            }
            else if (aPoint > bPoint)
            {
                while (aPoint >= bPoint)
                {
                    if (bPoint % 5 == 0)
                    {
                        result++;
                    }
                    bPoint++;
                }
            }
            WriteLine($"Количество чисел кратных 5-ти: {result}");
            WriteLine();
        }
        public static void Task8()
        {
            Write("Введите первое число: ");
            int aPoint = ToInt32(ReadLine());

            Write("Введите второе число: ");
            int bPoint = ToInt32(ReadLine());
            int result = 0;
            WriteLine();

            if (aPoint < bPoint)
            {
                while (aPoint <= bPoint)
                {
                    if (aPoint < 0 && aPoint % 3 == 0 && aPoint % 4 == 0)
                    {
                        result++;
                    }
                    aPoint++;
                }
            }
            else if (aPoint > bPoint)
            {
                while (aPoint >= bPoint)
                {
                    if (bPoint < 0 && bPoint % 3 == 0 && bPoint % 4 == 0)
                    {
                        result++;
                    }
                    bPoint++;
                }
            }
            WriteLine($"Количество чисел кратных 3-м И 4-м: {result}");
            WriteLine();
        }
    }
}