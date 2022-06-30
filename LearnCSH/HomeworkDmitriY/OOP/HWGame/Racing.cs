using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.OOP.HWGame
{
    class Racing
    {
        public int[,] Map;
        public int AutoY;
        public int AutoX;

        // 1 - координаты машинки

        public Racing(int height, int width)
        {
            Map = new int[height, width];
            AutoY = 22;
            AutoX = 6;
        }
        public void AutoUp()
        {
            if (AutoY != 0)
            {
                AutoY--;
            }
        }

        public void AutoDown()
        {
            if (AutoY != Map.GetLength(0) - 2)
            {
                AutoY++;
            }
        }

        public void AutoLeft()
        {
            if (AutoX != 1)
            {
                AutoX--;
            }
        }

        public void AutoRight()
        {
            if (AutoX != Map.GetLength(1) - 2)
            {
                AutoX++;
            }
        }


        // 3 - отрисовываем карту циклом
        public void PrintMap()
        {
            int height = Map.GetLength(0);
            int width = Map.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == AutoY && j == AutoX)
                    {
                        Console.Write(" A");
                    }
                    else if (i - 1 == AutoY && j == AutoX)
                    {
                        Console.Write(" A");
                    }
                    else if(j == 0)
                    {
                        Console.Write(" |");
                    }
                    else if(j == 4)
                    {
                        Console.Write(" '");
                    }
                    else if(j == 8)
                    {
                        Console.Write(" '");
                    }
                    else if(j == 12)
                    {
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}