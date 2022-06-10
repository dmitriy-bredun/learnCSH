using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using HomeworkSerg.Tools;

namespace HomeworkSerg.General
{
    internal class Homework_R_Arrays
    {
        public static void Start()
        {
            WriteLine();
            Write(" Укажите размер масива:");
            int size = Convert.ToInt32(ReadLine());
            WriteLine();

            int[] array = new int[size];

            int userChoice = 0;
            do
            {
                WriteLine("     1)  Заполнить массив случайными числами");
                WriteLine("     2)  Вывести значения массива в консоль");
                WriteLine("     3)  Изменить какой-нибудь элемент массива");
                WriteLine("     4)  Написать статический метод, который будет считатьсреднее арифм");
                WriteLine("     5)  Написать статический метод, который будет проверять");
                WriteLine("     6)  Написать статический метод, который будет считать сумму");
                WriteLine("     7)  Написать статический метод, который будет сортировать массив");
                WriteLine();
                WriteLine("     Your choice  --->   ");
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        WriteLine("     1)  Заполняем массив случайными числами");
                        WriteLine();
                        WriteLine("     Минимальное значение:");
                        int volmin = Convert.ToInt32(ReadLine());
                        WriteLine("     Максимальное значение:");
                        int volmax = Convert.ToInt32(ReadLine());
                        AT.FillingRandom(array, volmin, volmax);
                        WriteLine();
                        break;

                    case 2:
                        WriteLine("     2)  Выводим значения массива в консоль");
                        WriteLine();
                        AT.ShowArray(array);
                        WriteLine();
                        break;
                    
                    case 3:
                        WriteLine("     3)  Изменить какой-нибудь элемент массива");
                        WriteLine();

                        Write("     Введите номер ячейки которую хотите изменить:  ");
                        int box = Convert.ToInt32(ReadLine());
                        WriteLine();

                        Write("     Новое значение в ячейке:    ");
                        int change = Convert.ToInt32(ReadLine());
                        WriteLine();

                        array[box] = change;

                        WriteLine($"    Ячейка [{box}] изменена на: {change}");
                        WriteLine();
                        break;

                    case 4:
                        WriteLine("     4)  Написать статический метод, который будет считать среднее значение масива");
                        WriteLine();
                        double mean = MEAN(array);
                        WriteLine($"    Cреднее арифметическое значение масива = {mean}");
                        WriteLine();
                        break;
                    
                    case 5:
                        WriteLine("     5)  Написать статический метод, который будет проверять");
                        WriteLine();

                        Write("     Введите лимит:    ");
                        int limit = Convert.ToInt32(ReadLine());
                        WriteLine();

                        bool result =  LIMIT(array, limit);

                        if(result)
                        {
                            WriteLine("     Сумма значений не привышает лимит");
                        }
                        else 
                        {
                            WriteLine("     Сумма значений привышает лимит");
                        }
                        WriteLine();
                        break;

                    case 6:
                        WriteLine("     6)  Написать статический метод, который будет считать сумму");
                        WriteLine();
                        int sum = SUM(array);
                        Write($"     Сумма всех значений в массиве, которые находятся между минимальным и максимальным элементами = {sum}");
                        WriteLine();
                        break;

                    case 7:
                        WriteLine("     7)  Написать статический метод, который будет сортировать массив");
                        WriteLine();
                        BUBBLE(array);
                        Write("     Cортировка массива в порядке возрастания пузырьковым методом произошла! Поверьте на слово и живете с этим!");
                        break;

                    default:
                        WriteLine("    Неверный ввод");
                        break;
                }
                WriteLine();
            } while (userChoice != 0);
        }
        public static double MEAN(int[]array)
        {
            int sum = 0;
            int count = 0;
            double mean = 0;

            for (int a = 0; a < array.Length; a++)
            {
                if (a % 2 == 0 && a != 0)
                {
                    sum = sum + array[a];
                    count++;
                }
                mean = sum / count;           
            }
            return mean;
        }
        public static bool LIMIT(int[]array, int limit)
        {
            int sum = 0;
            bool result = true;

            for (int b = 0; b < array.Length; b++)
            {
                if (b % 2 != 0 && b != 0)
                {
                    sum = sum + array[b];
                }
                
            }
            if (sum <= limit)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static int SUM(int[] array)
        {
            int min = array[0];
            int max = array[0];

            int minIndx = -1;
            int maxIndx = -1;

            int sum = 0;

            for (int c = 1; c < array.Length; c++)
            {
                if (array[c] > max)
                {
                    max = array[c];
                    maxIndx = c;
                }

                if (array[c] < min)
                {
                    min = array[c];
                    minIndx = c;
                }
            }
            // С первой чвстью мы разобрались как работает, а вот со второй нет
            if (minIndx > maxIndx)
            {
                for (int i = maxIndx + 1; i < minIndx; i++)
                {
                    sum += array[i];
                }
            }
            else
            {
                for (int i = minIndx + 1; i < maxIndx; i++)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static void BUBBLE(int[] array)
        {
            bool Sorting = true;
            
            while (Sorting)
            {
                Sorting = false;

                for (int d = 0; d < array.Length - 1; d++)
                {
                    if (array[d] > array[d+1])
                    {
                        int box = array[d];
                        array[d] = array[d + 1];
                        array[d + 1] = box;

                        Sorting = true;
                    }
                }
            }
        }
    }
}
