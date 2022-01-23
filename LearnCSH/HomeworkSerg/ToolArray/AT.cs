using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.Tools
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
        
        public static void FillingManuall(int[] Array)
        {
            for (int indx = 0; indx < Array.Length; indx++)
            {
                Write($"Число для сохранения в ячейку [{indx}]: ");
                Array[indx] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Масив заполнен.");
        }
        public static void FillingRandom(int[] Array, int min, int max)
        {
            Random rand = new Random();
            for (int indx = 0; indx < Array.Length; indx++)
            {
                WriteLine($"Случайное число: {Array[indx] = rand.Next(min, max)}");
            }
            WriteLine("Масив заполнен.");
        }
    }
}
