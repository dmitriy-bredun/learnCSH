using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.ConsoleColor;
using static System.Convert;

namespace HomeworkDmitriy.OOP.HWGame
{
    enum Items
    {
        Car,
        Shield,
    }
    class Racing
    {
        public int[,] Map;
        public int AutoY;
        public int AutoX;

        public int Count;
        public int ScoreInfo;
        public int Shield;
        bool isGameFinished;

        Random random = new Random();

        public Racing(int height, int width)
        {
            Map = new int[height, width];
            AutoY = 22;
            AutoX = 6;
            isGameFinished = false;
        }

        public void Left()
        {
            if (AutoX != 1)
            {
                AutoX--;
            }
            Move();
        }

        public void Right()
        {
            if (AutoX != Map.GetLength(1) - 2)
            {
                AutoX++;
            }
            Move();
        }

        public void Move()
        {
            Count++;
            DownItems();
            AddNewItems(Items.Car);
            AddNewItems(Items.Shield);
            CatchShield();
            Crash();
            AddScore();
        }

        public void DownItems()
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
                    else if (Map[i, j] == 2)
                    {
                        if (i != Map.GetLength(0) - 1)
                        {
                            Map[i, j] = 0;
                            Map[i + 1, j] = 2;
                        }
                        else
                        {
                            Map[i, j] = 0;
                        }
                    }
                }
            }
        }

        public void AddNewItems(Items ItemsRace)
        {
            switch (ItemsRace)
            {
                case Items.Car:
                    for (int i = 0; i < random.Next(1, 2); i++)
                    {
                        Map[0, random.Next(1, Map.GetLength(1) - 1)] = 1;
                    }
                    break;

                case Items.Shield:
                    if (Count % 20 == 0)
                    {
                        for (int i = 0; i < random.Next(1, 2); i++)
                        {
                            Map[0, random.Next(1, Map.GetLength(1) - 1)] = 2;
                        }
                    }
                    break;

                default:
                    break;
            }
        }
        
        public void AddScore()
        {
            for (int i = 0; i < Map.GetLength(1); i++)
            {
                if (Map[AutoY, i] == 1)
                {
                    ScoreInfo += 100;
                }
            }
        }

        public void CatchShield()
        {
            if (Map[AutoY, AutoX] == 2 || Map[AutoY + 1, AutoX] == 2)
            {
                Shield += 1;
            }
        }

        public void Crash()
        {
            if (Map[AutoY, AutoX] == 1 || Map[AutoY + 1, AutoX] == 1)
            {
                ScoreInfo -= 1000;
                Shield--;

                if (Shield < 0)
                {
                    isGameFinished = true;
                }
            }
        }

        public bool GameFinished()
        {
            return isGameFinished;
        }

        public void PrintMap()
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (i == AutoY && j == AutoX || i - 1 == AutoY && j == AutoX)
                    {
                        ForegroundColor = DarkCyan;
                        CT.Print(" A");
                        Map[AutoY, AutoX] = 0;
                    }
                    else if (Map[i, j] == 1)
                    {
                        ForegroundColor = Red;
                        CT.Print(" H");
                    }
                    else if (Map[i, j] == 2)
                    {
                        ForegroundColor = Green;
                        CT.Print(" S");
                    }
                    else if (j == 0 || j == 12)
                    {
                        ForegroundColor = White;
                        CT.Print(" |");
                    }
                    else if (j == 4 || j == 8)
                    {
                        ForegroundColor = White;
                        CT.Print(" '");
                    }
                    else
                    {
                        CT.Print("  ");
                    } 
                }
                CT.Space();
            }
            CT.Space2();

            ForegroundColor = White;
            CT.Print($"   (( {Shield} ))");
            CT.Print($"    Score: {ScoreInfo}");
            
        }

        public void LogoFinished()
        {
            CT.Space();
            CT.PrintL("   **************************");
            CT.PrintL("   *                        *");
            CT.PrintL("   *          GAME          *");
            CT.PrintL("   *         FINISH         *");
            CT.PrintL("   *                        *");
            CT.PrintL("   **************************");
            CT.Space();
            CT.PrintL($"          Score: {ScoreInfo}");
        }
    }
}