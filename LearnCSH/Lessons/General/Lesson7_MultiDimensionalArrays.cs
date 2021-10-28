using System;

using static System.Console;

namespace Lessons.General
{
    class Lesson7_MultiDimensionalArrays
    {
        public static void Start()
        {
            int width = 5;  // rows
            int height = 5; // lines

            int[,] multiArray = new int[height, width];

            InitializeWithRandomValues(multiArray);

            ShowArr(multiArray, true);

            /*			КАК ПОЛУЧИТЬ РАЗМЕР
			 * 
			 * GetLength(0) - позволяет получить размер массива по вертикали i (height)      
			 * GetLength(1) - позволяет получить размер массива по горизонтали j (width)
			 */
            int height2 = multiArray.GetLength(0);
            int width2 = multiArray.GetLength(1);


            WriteLine();
        }

        public static void InitializeWithRandomValues(int [,] arr)
        {
            int height = arr.GetLength(0);
            int width = arr.GetLength(1);

            Random rand = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rand.Next(0, 100);
                }
            }
        }

        public static void ShowArr(int[,] arr, bool showDiagonal = false)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write($"arr[{i},{j}] = {arr[i, j]}\t");
                }

                WriteLine();
            }
        }
    }
}
