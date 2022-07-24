using System;

using static System.Console;
using HomeworkMargaret.Tools;

namespace HomeworkMargaret.OOP.HW5_Maze
{
    class Maze
    {
        private int[,] Map;
        private int PiecesOfCheeseOnTheMap;

        private int MouseI;
        private int MouseJ;
        
        private int Score;
        
        private bool Lazergun;
        private MouseDirections currentDirection;

        public Maze()
        {
            Map = new int[10, 11];
            MouseI = 0;
            MouseJ = 0;

            Random rand = new Random();          
            for (int columnInd = 1; columnInd < Map.GetLength(1) - 1; columnInd+=2) // рух. по колонках
            {
                int countOfPasses = rand.Next(1, 4);
                int[] passIndx = new int[countOfPasses];
                for (int i = 0; i < passIndx.Length; i++)
                {
                    passIndx[i] = rand.Next(0, Map.GetLength(0) - 1);
                }

                for (int lineInd = 0; lineInd < Map.GetLength(0); lineInd++)  // ставить блоки
                {
                    if (IsBlock(lineInd, passIndx))
                    {
                        Map[lineInd, columnInd] = (int)MazeItems.Block;
                    }
                }
            }

            PiecesOfCheeseOnTheMap = rand.Next(3, 6);
            for (int i = 1; i <= PiecesOfCheeseOnTheMap; i++)
            {
                AddMazeItem(MazeItems.Cheese);
            }

            AddMazeItem(MazeItems.Lazergun);
        }
        public void ShowMap()
        {
            CT.Print(" ", false);
            for (int i = 0; i < Map.GetLength(1); i++)
            {
                CT.Print("-", false);
            }
            WriteLine();

            
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                CT.Print("|", false);
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (i == MouseI && j == MouseJ)
                    {
                        CT.Print("M", false);
                    }
                    else if (Map[i, j] == 1)
                    {
                        CT.Print("*", false);
                    }
                    else if (Map[i, j] == 2)
                    {
                        CT.Print("C", false);
                    }
                    else if (Map[i, j] == 3)
                    {
                        CT.Print("L", false);
                    }
                    else
                    {
                        CT.Print(" ", false);
                    }
                }
                CT.Print("|", false);
                if (i == Map.GetLength(0) / 2)
                {
                    CT.Print($"Total score: {Score}", false);
                }
                if (i == Map.GetLength(0) / 2 + 1)
                {
                    CT.Print($"Lazergun: {Lazergun}", false);
                }
                if (i == Map.GetLength(0) / 2 + 2)
                {
                    CT.Print($"Direction: {currentDirection}", false);
                }
                WriteLine();
            }
            
            CT.Print(" ", false);
            for (int i = 0; i < Map.GetLength(1); i++)
            {
                CT.Print("-", false);
            }
            WriteLine();
        }
        public void MouseUp()
        {
            currentDirection = MouseDirections.Up;
            if (MouseI > 0 && Map[MouseI - 1, MouseJ] != 1)
            {
                MouseI -= 1;
                EatCheeseIfExists();
                CatchLazerguIfExist();
            }
        }
        public void MouseDown()
        {
            currentDirection = MouseDirections.Down;
            if (MouseI < Map.GetLength(0) - 1 && Map[MouseI + 1, MouseJ] != 1)
            {
                MouseI += 1;
                EatCheeseIfExists();
                CatchLazerguIfExist();
            }
        }
        public void MouseLeft()
        {
            currentDirection = MouseDirections.Left;
            if (MouseJ > 0 && Map[MouseI, MouseJ - 1] != 1)
            {
                MouseJ -= 1;
                EatCheeseIfExists();
                CatchLazerguIfExist();
            }
        }
        public void MouseRight()
        {
            currentDirection = MouseDirections.Right;
            if (MouseJ < Map.GetLength(1) - 1 && Map[MouseI, MouseJ +1] != 1)
            {
                MouseJ += 1;
                EatCheeseIfExists();
                CatchLazerguIfExist();
            }
        }
        public void TryShot()
        {
            if (Lazergun)
            {
                switch (currentDirection)
                {
                    case MouseDirections.Up:
                       
                        for (int step = 1; step <= 3; step++)
                        {
                            if (MouseI - step >= 0 && Map[MouseI - step, MouseJ] == (int)MazeItems.Block)
                            {
                                Map[MouseI - step, MouseJ] = 0;
                            }
                        }
                        break;

                    case MouseDirections.Down:
                        for (int step = 1; step <= 3; step++)
                        {
                            if (MouseI + step <= Map.GetLength(0) - 1 && Map[MouseI + step, MouseJ] == (int)MazeItems.Block)
                            {
                                Map[MouseI + step, MouseJ] = 0;
                            }
                        }
                        break;

                    case MouseDirections.Left:
                        for (int step = 1; step <= 3; step++)
                        {
                            if (MouseJ - step >= 0 && Map[MouseI, MouseJ - step] == (int)MazeItems.Block)
                            {
                                Map[MouseI, MouseJ - step] = 0;
                            }
                        }
                        break;

                    case MouseDirections.Right:

                        for (int step = 1; step <= 3; step++)
                        {
                            if (MouseJ + step <= Map.GetLength(1) - 1 && Map[MouseI, MouseJ + step] == (int)MazeItems.Block)
                            {
                                Map[MouseI, MouseJ + step] = 0;
                            }
                        }
                        break;
                }
                Lazergun = false;
            }
        }
        public bool CheeseIsEaten()
        {
            if (PiecesOfCheeseOnTheMap == 0)
            {
                return true;
            }

            return false;
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
        private void AddMazeItem(MazeItems item)
        {
            Random rand = new Random();
            bool check = false;
            while (check != true)
            {
                int i = rand.Next(0, Map.GetLength(0) - 1);
                int j = rand.Next(0, Map.GetLength(1) - 1);
                if (Map[i, j] != ((int)MazeItems.Block))
                {
                    Map[i, j] = (int)item;
                    check = true;
                }
            }
        }
        private void EatCheeseIfExists()
        {
            if (Map[MouseI, MouseJ] == 2)
            {
                Map[MouseI, MouseJ] = 0;
                PiecesOfCheeseOnTheMap--;
                Score += 10;
            }
        }
        private void CatchLazerguIfExist()
        {
            if (Map[MouseI, MouseJ] == (int)MazeItems.Lazergun)
            {
                Map[MouseI, MouseJ] = 0;
                Lazergun = true;
            }
        }
    }
}
