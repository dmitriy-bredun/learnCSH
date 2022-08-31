using System;
using System.Collections.Generic;
using System.Text;
using HomeworkDmitriy.Tools;
using static System.Console;
using static System.ConsoleColor;
using static System.Convert;

namespace HomeworkDmitriy.General
{
    internal class Homework8_DynamicList
    {
        public static void Start()
        {
            List<int> KKK = new List<int>();

            int usersChoice;
            do
            {
                usersChoice = CT.Menu(
                    "Добавить числа вручную",
                    "Добавить случайные числа",
                    "Вывести значения списка в консоль",
                    "Проверить, есть ли в списке какое то конкретное число",
                    "Посчитать и вывести количество четных и кратных числу 3 значений списка",
                    "Посчитать среднее арифметическое по значениям списка");
                CT.Space2();
                switch (usersChoice)
                {
                    case 1: Task1(KKK); break;
                    case 2: Task2(KKK); break;
                    case 3: Task3(KKK); break;
                    case 4: 
                        bool result = Task4(KKK);

                        if (result)
                            WriteLine("Совпадение найдено");
                        else
                            WriteLine("Совпадение отсудствует");
                        break;
                    case 5: Task5(KKK); break;
                    case 6: Task6(KKK); break;
                    case 0: break;
                    default:
                        Write("Ты не то жмакнул :О");
                        break;
                }
            } while (usersChoice != 0);
        }

        public static void Task1(List<int> KKK)
        {
            Write("Сколько ячеек заполняем: ");
            int size = ToInt32(ReadLine());
            int[] nums = new int[size];

            WriteLine("Добавляем новые значения: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Write($"[{i}] = ");
                nums[i] = ToInt32(ReadLine());
            }
            KKK.AddRange(nums);
            WriteLine();
            WriteLine("Заполнение листа завершено!");
        }

        public static void Task2(List<int> KKK)
        {
            Random random = new Random();

            Write("Сколько чисел нужно добавить: ");
            int count = ToInt32(ReadLine());

            Write("Введи минимальное значение: ");
            int min = ToInt32(ReadLine());

            Write("Введи максимальное значение: ");
            int max = ToInt32(ReadLine());

            for (int indx = 0; indx < count; ++indx)
                KKK.Add(random.Next(min, max));
            WriteLine($"Рандом выполнен :О");
        }

        public static void Task3(List<int> KKK)
        {
            WriteLine("Выводим лист: ");
            for (int indx = 0; indx < KKK.Count; ++indx)
                WriteLine($"В ячейке с индексом [{indx}] хранится = {KKK[indx]}");
        }

        public static bool Task4(List<int> KKK)
        {
            WriteLine("Какое число нужно проверить: ");
            int enterInt = 0;
            enterInt = ToInt32(ReadLine());
            foreach (int i in KKK)
            {
                if (i == enterInt)
                    return true;
            }
            return false;
        }

        public static void Task5(List<int> KKK)
        {
            int nums1 = 0;
            int nums2 = 0;
            for (int indx = 0; indx < KKK.Count; ++indx)
            {
                if (KKK[indx] % 2 == 0)
                    nums1++;

                else if (KKK[indx] % 3 == 0)
                    nums2++;
            }
            WriteLine($"Количество чётных чисел: {nums1}");
            WriteLine($"Количество значений кратных 3-м: {nums2}");
            CT.Space2();
        }

        public static void Task6(List<int> KKK)
        {
            float result = 0;
            for (int indx = 0; indx < KKK.Count; ++indx)
                result += KKK[indx];
            WriteLine($"Среднее арифметическое: {result / KKK.Count}");
        }
    }
}
