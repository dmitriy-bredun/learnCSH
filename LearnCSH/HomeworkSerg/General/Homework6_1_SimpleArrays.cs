using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.General
{
    internal class Homework6_1_SimpleArrays
    {
        public static void Start()
        {
            WriteLine();
            Write(" Imagine a ghost (in numbers=)):  ");
            int size = Convert.ToInt32(ReadLine());
            WriteLine();
            
            int[] ghost = new int[size];
            //arrey[0] = 100;
            //Show(arrey);

            //int[] arrey2 = new int[count];
            //arrey2[4] = 500;
            //Show(arrey2);

            int userChoice = 0;

            do
            {
                WriteLine("     1)  Task 1 - Manual input");
                WriteLine("     2)  Task 2 - Random input");
                WriteLine("     3)  Task 3 - Show ghost");
                WriteLine("     4)  Task 4 - Change ghost");
                WriteLine("     5)  Task 5 - Count the ghost who ==/2 and !=/2");
                WriteLine("     6)  Task 6 - Ghost [+++++]/n");
                WriteLine("     7)  Task 7 - Ghost сount min / max");
                WriteLine("     8)  Task 8 - Ghost < 0 and /2 == 0 !");
                WriteLine("     9)  Task 9* - Посчитать сумму элементов и их количество между ");
                WriteLine("                  минимальным и максимальными элементами в массиве");
                WriteLine("     10) Task 10* - Посчитать сумму элементов до минимального числа в ");
                WriteLine("                   массиве и количество элементов после максимального числа в массиве");
                WriteLine("     11) Task 11* - Дан массив из 15 элементов. Найти топ-3 повторяющихся элементов, ");
                WriteLine("                   в порядке убывания в массиве: 1, 2, 3, 4, 4, 4, 4, 5 5, 6, 7, 7, 7, 7, 7, 7, 7");
                WriteLine();
                Write("     Your choice  --->   ");
                userChoice = Convert.ToInt32(ReadLine());
                WriteLine();

                switch (userChoice)
                {
                    case 1:
                        Task1(ghost);
                        break;

                    case 2:
                        Task2(ghost);
                        break;

                    case 3:
                        Task3(ghost);
                        break;

                    case 4:
                        Task4(ghost);
                        break;

                    case 5:
                        Task5(ghost);
                        break;

                    case 6:
                        Task6(ghost);
                        break;

                    case 7:
                        Task7(ghost);
                        break;

                    case 8:
                        Task8(ghost);
                        break;

                    case 0:
                        break;

                    default:
                        WriteLine("    You missed. Try again ;)");
                        break;
                }
                WriteLine();
            } while (userChoice != 0);
        }
        public static void Task1(int[] ghost1)
        {
            WriteLine("Manual input.");
            WriteLine();

            Write("First number:  ");
            int Luci = Convert.ToInt32(ReadLine());

            for (int a = 0; a < ghost1.Length; a++)
            {
                Write($"Число для сохранения в ячейку [{a}]: {Luci}");
                //ghost1[a] = Convert.ToInt32(ReadLine());
                ghost1[a] = Luci++;
                WriteLine();
            }
            WriteLine();
        }
        
        public static void Task2(int[] ghost2)
        {
            WriteLine("Random input");
            WriteLine();

            Random rnd = new Random();

            Write("Input minimum number: ");
            int minVal = Convert.ToInt32(ReadLine());

            Write("Input maximum number: ");
            int maxVal = Convert.ToInt32(ReadLine());

            for (int b = 0; b < ghost2.Length; b++)
            {
                ghost2[b] = rnd.Next(minVal, maxVal);
                WriteLine($"Ghost random = {ghost2[b]}");
            }
        }
        public static void Task3(int[] ghost3)
        {
            WriteLine("Show ghost");
            WriteLine();

            for (int c = 0; c < ghost3.Length; c++)
            {
                WriteLine($"Ghost in numbers[{c}] = {ghost3[c]}  ");
            }
            WriteLine();
        }
        public static void Task4(int[] ghost4)
        {
            WriteLine("Try to change the ghost =)");
            WriteLine();

            Write("Input the box you wanna change:  ");
            int box = Convert.ToInt32(ReadLine());
            WriteLine();

            Write("Input new number:    ");
            int change = Convert.ToInt32(ReadLine());
            WriteLine();

            ghost4[box] = change;

            WriteLine($"New numb [{box}] = {change}");
            WriteLine();
        }
        public static void Task5(int[] ghost5)
        {
            WriteLine("Count the ghost who ==/2 and !=/2");
            WriteLine();

            int count1 = 0;
            int count2 = 0;

            for (int d = 0; d < ghost5.Length; d++)
            {
                if (ghost5[d] % 2 == 0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            Write($"Ghost /2 = {count1}");
            WriteLine();
            Write($"Ghost !/2 = {count2}");
            WriteLine();
        }
        public static void Task6(int[] ghost6)
        {
            WriteLine("Ghost [+++++]/n");
            WriteLine();

            double sum = 0;

            for (int e = 0; e < ghost6.Length; e++)
            {
                sum += ghost6[e];
            }
            Write($"Fat Ghost  = {sum}");
            WriteLine();

            double midl = sum / ghost6.Length;

            Write($"Midl Ghost  = {midl}");
            WriteLine();
        }
        public static void Task7(int[] ghost7)
        {
            WriteLine("Ghost сount min / max");
            WriteLine();

            int minVal = 0;
            int maxVal = 0;

            int min = ghost7[0];
            int max = ghost7[0];

            for (int f = 0; f < ghost7.Length; f++)
            {
                if(ghost7[f] < min)
                {
                    min = ghost7[f];
                    minVal = f;
                }

                if(ghost7[f] > max)
                {
                    max = ghost7[f];
                    maxVal = f;
                }
            }

            WriteLine($"Ghost min = {minVal}");
            WriteLine($"Ghost max = {maxVal}");
        }
        public static void Task8(int[] ghost8)
        {
            WriteLine("Ghost < 0 and /2 == 0 !");
            WriteLine();

            for (int g =0; g < ghost8.Length; g++)
            {
                WriteLine($"    Ghost original -->        {ghost8[g]}");
                WriteLine();

                if (ghost8[g] % 2 == 0 && ghost8[g] < 0)
                {
                    ghost8[g] = 0;
                }

                WriteLine($"    Ghost < 0 and /2 == 0 --> {ghost8[g]}");
                WriteLine();
            }
        }
    }
}
