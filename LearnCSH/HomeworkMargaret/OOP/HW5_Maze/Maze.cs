using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using HomeworkMargaret.Tools;

namespace HomeworkMargaret.OOP.HW5_Maze
{
    class Maze
    {
        enum MazeItems
        {
            Block = 1,
            Cheese,
            Lazergun,
        }
        private int[,] map;
        private int mouseI;
        private int mouseJ;
        private int score;
        private bool lazergun;

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
                        map[lineInd, columnInd] = (int)MazeItems.Block;
                    }
                }
            }

            int piecesOfCheese = rand.Next(3, 6);
            for (int i = 1; i <= piecesOfCheese; i++)
            {
                AddMazeItem(MazeItems.Cheese);
            }

            AddMazeItem(MazeItems.Lazergun);
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
        private void AddMazeItem (MazeItems item)
        {
            Random rand = new Random();
            bool check = false;
            while (check != true)
            {
                int i = rand.Next(0, map.GetLength(0) - 1);
                int j = rand.Next(0, map.GetLength(1) - 1);
                if (map[i,j] != ((int)MazeItems.Block)) 
                {
                    map[i, j] = (int)item;
                    check = true;
                }
            }
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
                    else if (map[i, j] == 3)
                    {
                        CT.Print("L", false);
                    }
                    else
                    {
                        CT.Print(" ", false);
                    }
                }
                CT.Print("|", false);
                if (i == map.GetLength(0) / 2)
                {
                    CT.Print($"Total score: {score}", false);
                }
                if (i == map.GetLength(0) / 2 + 1)
                {
                    CT.Print($"Lazergun: {lazergun}", false);
                }
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
                MouseHasLazergun();
            }
        }

        public void MouseDown()
        {
            if (mouseI < map.GetLength(0) - 1 && map[mouseI + 1, mouseJ] != 1)
            {
                mouseI += 1;
                EatCheeseIfExists();
                MouseHasLazergun();
            }
        }

        public void MouseLeft()
        {
            if (mouseJ > 0 && map[mouseI, mouseJ - 1] != 1)
            {
                mouseJ -= 1;
                EatCheeseIfExists();
                MouseHasLazergun();
            }
        }

        public void MouseRight()
        {
            if (mouseJ < map.GetLength(1) - 1 && map[mouseI, mouseJ +1] != 1)
            {
                mouseJ += 1;
                EatCheeseIfExists();
                MouseHasLazergun();
            }
        }

        private void EatCheeseIfExists()
        {
            if (map[mouseI, mouseJ] == 2)
            {
               map[mouseI, mouseJ] = 0;
                score += 10;
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

        public void MouseHasLazergun()
        {
            if (map[mouseI, mouseJ] == (int)MazeItems.Lazergun)
            {
                map[mouseI, mouseJ] = 0;
                lazergun = true;
            }
        }
    }
}
