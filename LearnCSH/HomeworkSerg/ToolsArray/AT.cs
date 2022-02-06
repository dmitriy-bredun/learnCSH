using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.ToolsArray
{
    internal class AT
    {
        public static int[] CreateSimplArray(int size)
        {
            if (size <= 0)
            {
                WriteLine("Масив с таким размером создать невозможно.");
                return null;
            }
            int[] newArray = new int[size];
            return newArray;
        }
        
        public static void FillingManuall(int[] array)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                Write($"Число для сохранения в ячейку [{indx}]: ");
                array[indx] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Масив заполнен.");
        }
        public static void FillingRandom(int[] array, int min, int max)
        {
            Random rand = new Random();
            for (int indx = 0; indx < array.Length; indx++)
            {
                array[indx] = rand.Next(min, max);

                WriteLine($"In box: {indx}, random number: {array[indx]}");
            }
            WriteLine("Array done.");
        }
        public static void ShowArray(int[] array)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                WriteLine($"{array[indx]}");
            }
        }
    }
}
