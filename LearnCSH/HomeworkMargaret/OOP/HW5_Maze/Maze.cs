using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using HomeworkMargaret.Tools;

namespace HomeworkMargaret.OOP.HW5_Maze
{
    class Maze
    {
        private int[,] map;
        private int mouseI;
        private int mouseJ;

        public Maze()
        {
            map = new int[10, 10];
            mouseI = 0;
            mouseJ = 0;
            Random rand = new Random();
            int countOfBlocks = rand.Next(10, 20);
            for (int i = 1; i <= countOfBlocks; i++)
            {
                int rI = rand.Next(0, map.GetLength(0) - 1);
                int rJ = rand.Next(0, map.GetLength(1) - 1);
                map[rI, rJ] = 1;
            }
        }

        public void ShowMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (i == mouseI && j == mouseJ)
                    {
                        CT.Print("M", false);
                    }
                    else if (map[i, j] == 1)
                    {
                        CT.Print("*", false);
                    }
                    else
                    {
                        CT.Print("-", false);
                    }
                }
                WriteLine();
            }
        }

        public void MouseUp()
        {
            if (mouseI > 0 && map[mouseI - 1, mouseJ] != 1)
            {
                mouseI -= 1;
            }
        }

        public void MouseDown()
        {
            if (mouseI < map.GetLength(0) - 1 && map[mouseI + 1, mouseJ] != 1)
            {
                mouseI += 1;
            }
        }

        public void MouseLeft()
        {
            if (mouseJ > 0 && map[mouseI, mouseJ - 1] != 1)
            {
                mouseJ -= 1;
            }
        }

        public void MouseRight()
        {
            if (mouseJ < map.GetLength(1) - 1 && map[mouseI, mouseJ +1] != 1)
            {
                mouseJ += 1;
            }
        }
    }
}
