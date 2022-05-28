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
                    "Заполнить массив случайными числами",
                    "Выводим массив",
                    "Изменить какой-нибудь элемент массива",
                    "Написать статический метод, который будет считать среднее арифметическое значение, всех элементов массива, которые хранятся в ячейках с четным индексом и возвращать результат. Метод принимает: одномерный массив. Метод возвращает: дробное число",
                    "Написать статический метод, который будет проверять не превышает ли сумма элементов массива, которые хранятся в ячейках с не четным индексом заданный лимит. Метод принимает: одномерный массив и лимит(целое число). Метод возвращает: true / false в зав.от полученного результата",
                    "",
                    "",
                    "");
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
                if (masiv[indx] % 2 == 0)
                {
                    suma = masiv[indx] + suma;
                    counter++;
                }
            }
            WriteLine($"Среднее арифметическое значение: {result = suma / counter}");
            CT.Space2();
            return result;
        }

        public static bool Task5(int[] masiv)
        {
            int limit = ToInt32(ReadLine());
            int suma = 0;
            int result;

            for (int indx = 0; indx < masiv.Length; ++indx)
            {
                if (masiv[indx] % 2 != 0)
                {
                    suma = masiv[indx] + suma;

                    if (suma < limit)
                    {
                        return true;
                    }
                }
                return false;
            }
            WriteLine($"");
        }

        public static void Task6(int[] masiv)
        {
           
        }

        public static void Task7(int[] masiv)
        {
            
        }

        public static void Task8(int[] masiv)
        {
            
        }
    }
}