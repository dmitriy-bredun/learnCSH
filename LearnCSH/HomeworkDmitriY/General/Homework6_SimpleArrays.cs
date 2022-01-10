using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.General
{
    internal class Homework4_SimpleArrays
    {
        public static void Start()
        {
            WriteLine("Создадим новый массив");
            WriteLine();
            Write("Введите размер массива: ");

            int size = ToInt32(ReadLine());
            WriteLine();

            int[] nums = new int[size];

            int usersChoice;

            do
            {
                WriteLine("   ///   Выбери Таску   ///   ");
                WriteLine();

                WriteLine("         1 - Заполняем массив вручную");
                WriteLine("         2 - Заполнить массив случайными числами");
                WriteLine("         3 - Выводим массив");
                WriteLine("         4 - Изменить какой-нибудь элемент массива");
                WriteLine("         5 - Посчитать и вывести количество четных/нечетных значений массива");
                WriteLine("         6 - Посчитать среднее арифметическое по значениям массива");
                WriteLine("         7 - Найти индексы минимального и максимального значения и напечатать в консоль");
                WriteLine("         8 - Обнулить все отрицательные элементы, кратные 2-м сбросив их значения в 0");
                WriteLine("         0 - Жмакни что б выйти");
                WriteLine();
                Write("         ");

                usersChoice = ToInt32(ReadLine());
                WriteLine();

                switch (usersChoice)
                {
                    case 1:
                        Task1(nums);
                        break;

                    case 2:
                        Task2(nums);
                        break;

                    case 3:
                        Task3(nums);
                        break;

                    case 4:
                        Task4(nums);
                        break;

                    case 5:
                        Task5(nums);
                        break;

                    case 6:
                        Task6(nums);
                        break;

                    case 7:
                        Task7(nums);
                        break;

                    case 8:
                        Task8(nums);
                        break;

                    case 0:
                        break;

                    default:
                        Write("Ты не то жмакнул :О");
                        break;
                }
            } while (usersChoice != 0);
        }

        public static void Task1(int[] kkk)
        {
            WriteLine("Введите значения массива: ");

            for (int i = 0; i < kkk.Length; i++)
            {
                Write($"[{i}] = ");
                kkk[i] = ToInt32(ReadLine());
            }

            WriteLine("Массив инициализирован..");
            WriteLine();
            WriteLine();
        }
        public static void Task2(int[] masiv)
        {
            Random random = new Random();

            Write($"Введи минимальное значение: ");
            int min = ToInt32(ReadLine());

            Write($"Введи максимальное значение: ");
            int max = ToInt32(ReadLine());

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                masiv[indx] = random.Next(min, max);
            }
            WriteLine($"Массив рандомизирован :О");
            WriteLine();
            WriteLine();
        }
        public static void Task3(int[] masiv)
        {
            WriteLine("Выводим массив: ");

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                WriteLine($"В ячейке с индексом [{indx}] хранится = {masiv[indx]}");
            }
            WriteLine();
            WriteLine();
        }
        public static void Task4(int[] masiv)
        {
            Write($"Выбери ячейку для изменения: ");
            int indx = ToInt32(ReadLine());
            WriteLine();

            Write($"Введи значение ячейки: ");
            int change = ToInt32(ReadLine());
            WriteLine();

            masiv[indx] = change;
            WriteLine($"Новые значения в ячейках: [{indx}] = {change}");

            WriteLine();
            WriteLine();
        }
        public static void Task5(int[] masiv)
        {
            int nums1 = 0;
            int nums2 = 0;

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                if (masiv[indx] % 2 == 0)
                {
                    nums1++;
                }
                else
                {
                    nums2++;
                }
            }

            WriteLine($"Количество значений кратных 2-м: {nums1}");
            WriteLine($"Количество не кратных значений: {nums2}");
            WriteLine();
            WriteLine();
        }
        public static void Task6(int[] masiv)
        {
            float result = 0;

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                result += masiv[indx];
            }
            WriteLine($"Сумма всех чисел равна: {result}");
            WriteLine($"Среднее арифметическое: {result / masiv.Length}");
            WriteLine();
            WriteLine();
        }
        public static void Task7(int[] masiv)
        {
            int min = masiv[0];
            int max = masiv[0];
            int minIndx = 0;
            int maxIndx = 0;

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                if (masiv[indx] < min)
                {
                    min = masiv[indx];
                    minIndx = indx;
                }
                if (masiv[indx] > max)
                {
                    max = masiv[indx];
                    maxIndx = indx;
                }
            }
            WriteLine($": {minIndx}");
            WriteLine($": {maxIndx}");
            WriteLine();
            WriteLine();
        }
        public static void Task8(int[] masiv)
        {
            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                if (masiv[indx] < 0 && masiv[indx] % 2 == 0)
                {
                    masiv[indx] = 0;
                }
            }
            WriteLine($"Все отрицательные элементы обнулены :О");
            WriteLine();
            WriteLine();
        }
    }
}