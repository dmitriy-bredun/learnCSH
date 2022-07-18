using System;
using static System.Console;

using Lessons.Tools;

namespace Lessons.General.Practice
{
    class Practice4_SimpleArrays
    {
        public static int Menu()
        {
            WriteLine();
            WriteLine("       М Е Н Ю ");
            WriteLine("1 - Заполнить массив вручную");
            WriteLine("2 - Заполнить массив случайными числами");
            WriteLine("3 - Заменить значение в выбранной ячейке массива");
            WriteLine("4 - Обнулить значение в выбранной ячейке массива");
            WriteLine("5 - Посчитать кол-во отрицательных значений в массиве");
            WriteLine("6 - Отсортировать массив в порядке возрастания");
            WriteLine("7 - Вывести массив в консоль");
            WriteLine("0 - Выход");
            Write("---> ");

            int userChoice = Convert.ToInt32(ReadLine());
            
            WriteLine();
            
            return userChoice;
        }

        public static void Start()
        {
            Write("Введите размер массива: ");
            int size = Convert.ToInt32(ReadLine());
            int[] array = new int[size];

            int choice;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        ManualEntering(array);
                        break;

                    case 3:
                        UpdateArrayValue(array);
                        break;

                    case 4:
                        ResetArrayValue(array);
                        break;

                    case 5:
                        CountNegativeElements(array);
                        break;

                    case 6:
                        SortArray(array);
                        break;

                    case 7:
                        ShowArray(array);
                        break;

                    case 0:
                        WriteLine("Госпаде, нахрена столько много-то...");
                        break;

                    default:
                        CT.ErrorMsg("Некорректный ввод..");
                        break;
                }
            } while (choice != 0);
        }

        public static void ManualEntering(int[] values)
        {
            WriteLine("Введите значения массива: ");
            for (int indx = 0; indx < values.Length; indx++)
            {
                Write($"[{indx}] = ");
                values[indx] = Convert.ToInt32(ReadLine());
            }

            WriteLine("Массив инициализирован..");
            WriteLine();
        }
        public static void UpdateArrayValue(int[] values)
        {
            ShowArray(values);

            Write("Введите номер индекса элемента, который хотите заменить: ");
            int indx = Convert.ToInt32(ReadLine());

            Write("Введите новое значение, которое хотите записать в массив: ");
            int newValue = Convert.ToInt32(ReadLine());

            values[indx] = newValue;

            WriteLine("Значение успешно обновлено");
        }
        public static void ResetArrayValue(int[] values)
        {
            ShowArray(values);

            Write("Введите номер индекса элемента, который хотите обнулить: ");
            int indx = Convert.ToInt32(ReadLine());

            values[indx] = 0;

            WriteLine("Элемент успешно сброшен");
        }
        public static void SortArray(int[] values)
        {
            bool flag = true;

            while (flag) {
                
                flag = false;

                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        int box = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = box;
                        flag = true;
                    }
                }
            }

            WriteLine("Массив отсортирован!");
        }
        public static void CountNegativeElements(int[] values)
        {
            int count = 0;
            for (int indx = 0; indx < values.Length; indx++)
            {
                if (values[indx] < 0)
                {
                    count++;
                }
            }
            WriteLine($"Количество отрицательных чисел = {count}");
        }
        public static void ShowArray(int[] values)
        {
            WriteLine("Вывод массива");
            for (int indx = 0; indx < values.Length; indx++)
            {
                Write($"[{indx}] = {values[indx]}  ");
                
            }

            WriteLine();
            WriteLine();

        }
    }
}
