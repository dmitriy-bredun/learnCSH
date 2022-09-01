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
                    case 1: AddingNumbers(KKK); break;
                    case 2: AddRandomNumbers(KKK); break;
                    case 3: DisplayListValues(KKK); break;
                    case 4: 
                        bool result = Checknumber(KKK);

                        if (result)
                            WriteLine("Совпадение найдено");
                        else
                            WriteLine("Совпадение отсудствует");
                        break;
                    case 5: EvenValues(KKK); break;
                    case 6: AverageValue(KKK); break;
                    case 0: break;
                    default:
                        Write("Ты не то жмакнул :О");
                        break;
                }
            } while (usersChoice != 0);
        }

        public static void AddingNumbers(List<int> KKK)
        {
            Write("Сколько ячеек заполняем: ");
            int size = ToInt32(ReadLine());

            WriteLine("Добавляем новые значения: ");
            
            for (int i = 0; i < size; i++)
            {
                Write($"[{i}] = ");
                int numb = ToInt32(ReadLine());
                KKK.Add(numb);
            }
            WriteLine();
            WriteLine("Заполнение листа завершено!");
        }

        public static void AddRandomNumbers(List<int> KKK)
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

        public static void DisplayListValues(List<int> KKK)
        {
            WriteLine("Выводим лист: ");
            for (int indx = 0; indx < KKK.Count; ++indx)
                WriteLine($"В ячейке с индексом [{indx}] хранится = {KKK[indx]}");
        }

        public static bool Checknumber(List<int> KKK)
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

        public static void EvenValues(List<int> KKK)
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

        public static void AverageValue(List<int> KKK)
        {
            float result = 0;
            for (int indx = 0; indx < KKK.Count; ++indx)
                result += KKK[indx];
            WriteLine($"Среднее арифметическое: {result / KKK.Count}");
        }
    }
}
