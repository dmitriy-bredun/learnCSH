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
            mouseI = 1;
            mouseJ = 1;
            Random rand = new Random();
                      
            for (int columnInd = 1; columnInd < map.GetLength(1) - 1; columnInd+=2) // рух. по колонках
            {
                int countOfPasses = rand.Next(1, 4);
                int[] passIndx = new int[countOfPasses];
                for (int i = 0; i < passIndx.Length; i++)
                {
                    passIndx[i] = rand.Next(0, map.GetLength(0) - 1);
                }

                for (int lineInd = 0; lineInd < map.GetLength(0); lineInd++)  // ставить блоки
                {
                    if (IsBlock(lineInd, passIndx))
                    {
                        map[lineInd, columnInd] = 1;
                    }
                }
            }
            int piecesOfCheese = rand.Next(3, 6);
            for (int i = 1; i <= piecesOfCheese; i++)
            {
                int cI = rand.Next(0, map.GetLength(0) - 1);
                int cJ = rand.Next(0, map.GetLength(1) - 1);
                if (cI != 0 && cJ != 0 && map[cI, cJ] != 1)
                {
                    map[cI, cJ] = 2;
                }
            }
        }
        private bool IsBlock(int currentIndx, int[] passIndx)
        {
            for (int i = 0; i < passIndx.Length; i++)
            {
                if (currentIndx == passIndx[i])
                {
                    return false; //не ставить блоки
                }    
            }
            return true;
        }

        public void ShowMap()
        {
            CT.Print(" ", false);
            for (int i = 0; i < map.GetLength(1); i++)
            {
                CT.Print("-", false);
            }
            WriteLine();

            for (int i = 0; i < map.GetLength(0); i++)
            {
                CT.Print("|", false);
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
                    else if (map[i, j] == 2)
                    {
                        CT.Print("C", false);
                    }
                    else
                    {
                        CT.Print(" ", false);
                    }
                }
                CT.Print("|", false);
                WriteLine();
            }

            CT.Print(" ", false);
            for (int i = 0; i < map.GetLength(1); i++)
            {
                CT.Print("-", false);
            }
            WriteLine();
        }

        public void MouseUp()
        {
            if (mouseI > 0 && map[mouseI - 1, mouseJ] != 1)
            {
                mouseI -= 1;
                EatCheeseIfExists();
            }
        }

        public void MouseDown()
        {
            if (mouseI < map.GetLength(0) - 1 && map[mouseI + 1, mouseJ] != 1)
            {
                mouseI += 1;
                EatCheeseIfExists();
            }
        }

        public void MouseLeft()
        {
            if (mouseJ > 0 && map[mouseI, mouseJ - 1] != 1)
            {
                mouseJ -= 1;
                EatCheeseIfExists();
            }
        }

        public void MouseRight()
        {
            if (mouseJ < map.GetLength(1) - 1 && map[mouseI, mouseJ +1] != 1)
            {
                mouseJ += 1;
                EatCheeseIfExists();
            }
        }

        private void EatCheeseIfExists()
        {
            if (map[mouseI, mouseJ] == 2)
            {
                map[mouseI, mouseJ] = 0;
            }
        }

        public bool CheeseIsEaten()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if(map[i, j] == 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
