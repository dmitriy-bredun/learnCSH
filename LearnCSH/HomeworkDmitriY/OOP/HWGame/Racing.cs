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
        public int AutoY; // 1 - координаты машинки
        public int AutoX;

        int newAuto;

        public Racing(int height, int width)
        {
            Map = new int[height, width];
            AutoY = 22;
            AutoX = 6;
        }
        public void AutoUp()
        {
            //if (AutoY != 0)
            //{
            //    AutoY--;
            //}
            DownNewAuto();
            AddNewAuto();
        }

        public void AutoDown()
        {
            //if (AutoY != Map.GetLength(0) - 2)
            //{
            //    AutoY++;
            //}
            //DownNewAuto();
            //AddNewAuto();
        }

        public void AutoLeft()
        {
            if (AutoX != 1)
            {
                AutoX--;
            }
            AddNewAuto();
            DownNewAuto();
        }

        public void AutoRight()
        {
            if (AutoX != Map.GetLength(1) - 2)
            {
                AutoX++;
            }
            AddNewAuto();
            DownNewAuto();
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
                    else if (Map[i, j] == 1)
                    {
                        Console.Write(" H"); // - отрисовка вражеских машинок
                    }
                    else if (j == 0)
                    {
                        Console.Write(" |");
                    }
                    else if (j == 4)
                    {
                        Console.Write(" '");
                    }
                    else if (j == 8)
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
        
        public void AddNewAuto()
        {
            Random randomAuto = new Random();
            int newAuto = randomAuto.Next(1, 2);

            for (int i = 0; i < newAuto; i++)
                {
                    Map[0, randomAuto.Next(1, Map.GetLength(1) - 1)] = 1;
                }
        }
        public void DownNewAuto()
        {
            for (int i = Map.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (Map[i, j] == 1)
                    {
                        if (i != Map.GetLength(0) - 1)
                        {
                            Map[i, j] = 0;
                            Map[i + 1, j] = 1;
                        }
                        else
                        {
                            Map[i, j] = 0;
                        }
                    }
                }
            }
        }
        public void ScoreInfo()
        {

        }
    }
}