using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.Tools
{
    class AT
    {
        public static int CreateArray(int size)
        {
            int[] array = new int[size];
            return array[size];
        }
         
        public static int CreateArray(int height, int width)
        {
            int[,] array = new int[height, width];
            return array[height, width];
        }

        public static void ManualArray(int [] array)
        {
            Print("Enter array values: ");
            for (int indx = 0; indx < array.Length; indx++)
            {
                array[indx] = EnterInt($"Enter values [{indx}]: ");
            }
            Print("Array is initialized.");
        }

        public static void ManualArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = CT.EnterInt($"Enter values [{i}, {j}]: ");
                }
            }
            Print("Array is initialized.");
        }

        public static void RandomArray(int[] array)
        {
            Random rnd = new Random();
            int min = EnterInt("Write MIN value: ");
            int max = EnterInt("Write MAX value: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            Print("Array is initialized.");
        }

        public static void RandomArray(int[,] array)
        {
            Random rnd = new Random();
            int min = EnterInt("write MIN value: ");
            int max = EnterInt("write MAX value: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(min, max);
                }
            }
            Print("Array is initialized.");
        }

        public static void ShowArray(int [] array)
        {
            Print("Showing array");
            for (int indx = 0; indx < array.Length; indx++)
            {
                Print($"[{indx}] = {array[indx]}  ", false);
            }
        }

        public static void ShowArray(int[,]array)
        {
            Print("Showing array");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Print($"[{i},{j}] = {array[i, j]}   ", false);
                }
                Print("");
            }
        }
    }
}
