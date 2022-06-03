using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using HomeworkMargaret.Tools;

namespace HomeworkMargaret.OOP.HW5_Maze
{
    class Maze
    {
        public int[,] map;
        public int mouseI;
        public int mouseJ;

        public Maze()
        {
            map = new int[10, 10];
            mouseI = 0;
            mouseJ = 0;
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
            if (mouseI > 0)
            {
                mouseI -= 1;
            }
        }

        public void MouseDown()
        {
            if (mouseI < map.GetLength(0) - 1)
            {
                mouseI += 1;
            }
        }

        public void MouseLeft()
        {
            if (mouseJ > 0)
            {
                mouseJ -= 1;
            }
        }

        public void MouseRight()
        {
            if (mouseJ < map.GetLength(1) - 1)
            {
                mouseJ += 1;
            }
        }
    }
}
