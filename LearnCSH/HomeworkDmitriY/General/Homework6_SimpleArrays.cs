using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.General
{
    internal class Homework4_SimpleArrays
    {
        public static void Start()
        {
            CT.PrintL("Создадим новый массив");
            CT.Space();
            CT.Print("Введите размер массива: ");

            int size = ToInt32(ReadLine());
            CT.Space();

            int[] nums = new int[size];

            int usersChoice;

            do
            {
                CT.PrintL("   ///   Выбери Таску   ///   ");
                CT.Space();

                CT.PrintL("         1 - Заполняем массив вручную");
                CT.PrintL("         2 - Заполнить массив случайными числами");
                CT.PrintL("         3 - Выводим массив");
                CT.PrintL("         4 - Изменить какой-нибудь элемент массива");
                CT.PrintL("         5 - Посчитать и вывести количество четных/нечетных значений массива");
                CT.PrintL("         6 - Посчитать среднее арифметическое по значениям массива");
                CT.PrintL("         7 - Найти индексы минимального и максимального значения и напечатать в консоль");
                CT.PrintL("         8 - Обнулить все отрицательные элементы, кратные 2-м сбросив их значения в 0");
                CT.PrintL("         0 - Жмакни что б выйти");
                CT.Space();

                Write("         ");
                usersChoice = ToInt32(ReadLine());
                CT.Space();

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
            CT.PrintL("Введите значения массива: ");

            for (int i = 0; i < kkk.Length; i++)
            {
                CT.Print($"[{i}] = ");
                kkk[i] = ToInt32(ReadLine());
            }

            CT.PrintL("Массив инициализирован..");
            CT.Space2();
        }
        public static void Task2(int[] masiv)
        {
            Random random = new Random();

            int min = CT.Int("Введи минимальное значение");
            int max = CT.Int("Введи максимальное значение");

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                masiv[indx] = random.Next(min, max);
            }
            WriteLine($"Массив рандомизирован :О");
            CT.Space2();
        }
        public static void Task3(int[] masiv)
        {
            WriteLine("Выводим массив: ");

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                WriteLine($"В ячейке с индексом [{indx}] хранится = {masiv[indx]}");
            }
            CT.Space2();
        }
        public static void Task4(int[] masiv)
        {
            Write($"Выбери ячейку для изменения: ");
            int indx = ToInt32(ReadLine());
            CT.Space();

            Write($"Введи значение ячейки: ");
            int change = ToInt32(ReadLine());
            CT.Space();

            masiv[indx] = change;
            WriteLine($"Новые значения в ячейках: [{indx}] = {change}");
            CT.Space2();
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
            CT.Space2();
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
            CT.Space2();
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
            CT.Space2();
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
            CT.Space2();
        }
    }
}