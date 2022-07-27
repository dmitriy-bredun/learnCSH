using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.General
{
    internal class Homework7_R_Arrays
    {
        public static void Start()
        {
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
                    "Заполнить массив случайными числами",
                    "Выводим массив",
                    "Изменить какой-нибудь элемент массива",
                    "Написать статический метод, который будет считать среднее арифметическое значение, всех элементов массива, которые хранятся в ячейках с четным индексом и возвращать результат. Метод принимает: одномерный массив. Метод возвращает: дробное число",
                    "Написать статический метод, который будет проверять не превышает ли сумма элементов массива, которые хранятся в ячейках с не четным индексом заданный лимит. Метод принимает: одномерный массив и лимит (целое число). Метод возвращает: true / false в зав.от полученного результата",
                    "Написать статический метод, который будет считать сумму всех значений в массиве, которые находятся между минимальным и максимальным элементами Метод принимает: одномерный массив массивМетод возвращает: сумму элементов находящимися между максимальным и минимальным элементами массива (максимальный и минимальный не считаем)",
                    "Написать статический метод, который будет сортировать массив в порядке возрастания. (возвращать метод ничего не должен) Метод принимает: одномерный массивМетод возвращает: void");
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
                        double result = Task4(nums);
                        break;

                    case 5:
                        Write($"Введи лимит: ");
                        int limit = ToInt32(ReadLine());
                        bool Suma = Task5(nums, limit);
                        break;

                    case 6:
                        int sum = Task6(nums);
                        Write($"Сумма равна: {sum}");
                        break;

                    case 7:
                        Task7(nums);
                        Write($"Сортировка завершена");
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
            CT.MasivRandom(masiv);
            CT.Space2();
        }

        public static void Task2(int[] masiv)
        {
            WriteLine("Выводим массив: ");

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                WriteLine($"В ячейке с индексом [{indx}] хранится = {masiv[indx]}");
            }
            CT.Space2();
        }

        public static void Task3(int[] masiv)
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

        public static double Task4(int[] masiv)
        { 
            int suma = 0;
            int counter = 0;
            double result;

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                if (masiv[indx] % 2 == 0 && indx != 0)
                {
                    suma = masiv[indx] + suma;
                    counter++;
                }
            }
            WriteLine($"Среднее арифметическое значение: {result = suma / counter}");
            CT.Space2();
            return result;
        }

        public static bool Task5(int[] masiv, int limit)
        {
            int sum = 0;

            for (int i = 0; i < masiv.Length; i++)
            {
                if (i % 2 != 0 && i != 0)
                {
                    sum = masiv[i] + sum; // sum += array[i];
                }
            }

            if (sum <= limit)
            {
                WriteLine($"Сумма элементов массива не превышает лимит");
                CT.Space2();
                return true;
            }

            WriteLine($"Сумма элементов массива превышает лимит");
            CT.Space2();
            return false;
        }

        public static int Task6(int[] masiv)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            int minIndx = -1;
            int maxIndx = -1;

            int sum = 0;

            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i] > max)
                {
                    max = masiv[i];
                    maxIndx = i;
                }

                if (masiv[i] < min)
                {
                    min = masiv[i];
                    minIndx = i;
                }
            }

            if (minIndx < maxIndx)
            {
                for (int i = minIndx + 1; i < maxIndx; i++)
                {
                    sum += masiv[i];
                }
            }
            else
            {
                for (int i = maxIndx + 1; i < minIndx; i++)
                {
                    sum += masiv[i];
                }
            }
            return sum;
        }

        public static void Task7(int[] masiv)
        {
            bool Sorting = true;

            while (Sorting)
            {
                Sorting = false;

                for (int i = 0; i < masiv.Length - 1; i++)        // -1, чтобы не выйти за границу массива, когда array[i+1];
                {
                    if (masiv[i] > masiv[i + 1])
                    {
                        int box = masiv[i];
                        masiv[i] = masiv[i + 1];
                        masiv[i + 1] = box;

                        Sorting = true;
                    }
                }
            }
        }
    }
}