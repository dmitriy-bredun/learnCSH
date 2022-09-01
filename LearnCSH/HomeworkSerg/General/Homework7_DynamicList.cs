using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using HomeworkSerg.Tools;

namespace HomeworkSerg.General
{
    internal class Homework7_DynamicList
    {
        public static List<int> Unknown = new List<int>();
        public static void Start()
        {
            int userChoise = 0;
            do
            {
                userChoise = CT.Menu(
                    "Добавить числа вручную;",
                    "Добавить случайные числа;",
                    "Вывести значения списка в консоль;",
                    "Проверить, есть ли в списке какое то конкретное число;",
                    "Посчитать и вывести количество четных и кратных числу 3 значений списка;",
                    "Посчитать среднее арифметическое по значениям списка.");
                switch (userChoise)
                {
                    case 1:
                        FillingManuall();
                        break;
                    case 2:
                        FillingRandom();
                        break;
                    case 3:
                        ShouList();
                        break;
                    case 4:
                        bool result = Check();
                        if (result)
                        {
                            WriteLine($"Есть совпадение: {result}");
                        }
                        else
                        {
                            WriteLine($"Нет совпадение: {result}");
                        }
                        break;
                    case 5:
                        Number2and3();
                        break;
                    case 6:
                        Middle();
                        break;
                }
            } while (true);

        }
        public static void FillingManuall()
        {
            //Unknown.Clear();
            WriteLine();
            WriteLine("Сколько чисел Вы хотите ввести ?");
            WriteLine();
            int amount = Convert.ToInt32(ReadLine());
            WriteLine();
            //foreach (int a in Unknown)
            //{
            //    Write($"Число для сохранения в ячейку [{i++}]: ");
            //    int numb = Convert.ToInt32(ReadLine());
            //    Unknown.Add(numb);
            //    WriteLine("Записано.");
            //    WriteLine();
            //}
            for (int i = 0; i < amount; i++)
            {
                Write($"Число которое сохраняется в ячейку: ");
                int numb = Convert.ToInt32(ReadLine());
                Unknown.Add(numb);
                WriteLine("Записано.");
                WriteLine();
            }
            WriteLine("Список заполнен.");
        }
        public static void FillingRandom()
        {
            //Unknown.Clear();
            WriteLine();
            WriteLine("Сколько чисел Вы хотите ввести ?");
            WriteLine();
            int amount = Convert.ToInt32(ReadLine());
            WriteLine();
            WriteLine("Введите минимальное число:");
            WriteLine();
            int min = Convert.ToInt32(ReadLine());
            WriteLine();
            WriteLine("Введите максимальное число:");
            WriteLine();
            int max = Convert.ToInt32(ReadLine());
            WriteLine();
            Random rand = new Random();
            for (int i = 0; i < amount; i++)
            {
                //array[indx] = rand.Next(min, max);
                //Unknown.Add.rand.Next(min, max);
                int randIndex = rand.Next(min, max);
                Unknown.Add(randIndex);
                WriteLine($"Cлучайное число: {randIndex}");
            }
            WriteLine("Список заполнен.");
        }
        public static void ShouList()
        {
            int i = 0;
            //for (int i = 0; i < Unknown.Count; i++)
            //{
            //    WriteLine();
            //    WriteLine($"В ячейке: {i}, число: {Unknown[i]}");
            //    WriteLine();
            //}
            foreach (int numb in Unknown)
            {
                WriteLine();
                WriteLine($"В ячейке число: {numb}");
                WriteLine();
            }
        }
        public static bool Check()
        {
            WriteLine();
            WriteLine("Какое число проверяем ?");
            WriteLine();
            int numb = Convert.ToInt32(ReadLine());
            WriteLine();
            return Unknown.Contains(numb);

            //foreach (int value in Unknown)
            //{
            //    if (numb == value)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            //for (int i = 0; i < Unknown.Count; i++)
            //{
            //    if(numb == Unknown[i])
            //    {
            //        //WriteLine($"Результат: {x}");
            //        //WriteLine($"Есть совпадение с ячейкой {i} в которой число: {Unknown[i]}");
            //    }
            //    else
            //    {
            //        //WriteLine($"Результат: {x}");
            //        //WriteLine("Совпадений нет.");
            //    }
            //    Unknown.Contains(numb);
            //}
            //if (numb == Unknown[i])
            //{
            //    x = true;
            //    //WriteLine($"Есть совпадение с ячейкой {i} в которой число: {Unknown[i]}");
            //}
            //else
            //{
            //    x = false;
            //    //WriteLine("Совпадений нет.");
            //}
        }
        public static void Number2and3()
        {
            int count1 = 0;
            int count2 = 0;
            foreach (int numb in Unknown)
            {
                if (numb % 2 == 0)
                {
                    count1++;
                }
                if (numb % 3 == 0)
                {
                    count2++;
                }
            }
            WriteLine();
            Write($"Число / 2 = {count1}");
            WriteLine();
            Write($"Число / 3 = {count2}");
            WriteLine();
        }
        public static void Middle()
        {
            double sum = 0;
            foreach (int numb in Unknown)
            {
                sum += numb;
            }
            double midl = sum / Unknown.Count;
            Write($"Cреднее арифметическое  = {midl}");
            WriteLine();
        }
    }
}


