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
            //CT.CreateArray(nums);
            CT.PrintL("--Создаём новый массив--");
            CT.Space();

            CT.Print("Введите размер массива: ");
            int size = ToInt32(ReadLine());
            CT.PrintL("Массив инициализирован..");
            CT.Space();

            int[] nums = new int[size];

            int usersChoice;

            do
            {
                usersChoice = CT.Menu(
                    "Заполняем массив вручную",
                    "Заполнить массив случайными числами",
                    "Выводим массив",
                    "Изменить какой-нибудь элемент массива",
                    "Посчитать и вывести количество четных/нечетных значений массива",
                    "Посчитать среднее арифметическое по значениям массива",
                    "Найти индексы минимального и максимального значения и напечатать в консоль",
                    "Обнулить все отрицательные элементы, кратные 2-м сбросив их значения в 0");
                CT.Space2();
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

        public static void Task1(int[] masiv)
        {
            CT.MasivManual(masiv);
            CT.Space2();
        }

        public static void Task2(int[] masiv)
        {
            CT.MasivRandom(masiv);
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