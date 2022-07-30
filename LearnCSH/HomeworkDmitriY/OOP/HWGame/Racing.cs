﻿using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.ConsoleColor;
using static System.Convert;

namespace HomeworkDmitriy.OOP.HWGame
{

    enum RaceItems  
    {
        Car = 1,
        Shield = 2
    }

    class Racing
    {
        public int[,] Map;
        public int AutoY; // 1 - координаты машинки
        public int AutoX;

        public int ScoreInfo;
        public int Shield;

        bool isGameFinished;

        public Racing(int height, int width)
        {
            Map = new int[height, width];
            AutoY = 22;
            AutoX = 6;

            isGameFinished = false;
        }

        public void AutoUp()
        {
            ScoreInfo += 100;
            MoveRaceItemsDown();
            AddNewItemToRace(RaceItems.Car);
            AddNewItemToRace(RaceItems.Shield);
            CatchShield();
            Crash();
        }

        public void AutoLeft()
        {
            if (AutoX != 1)
            {
                AutoX--;
            }
            ScoreInfo += 100;
            MoveRaceItemsDown();
            AddNewItemToRace(RaceItems.Car);
            AddNewItemToRace(RaceItems.Shield);
            CatchShield();
            Crash();
        }

        public void AutoRight()
        {
            if (AutoX != Map.GetLength(1) - 2)
            {
                AutoX++;
            }
            ScoreInfo += 100;
            MoveRaceItemsDown();
            AddNewItemToRace(RaceItems.Car);
            AddNewItemToRace(RaceItems.Shield);
            CatchShield();
            Crash();
        }

        public void AddNewItemToRace(RaceItems raceItem)
        {
            Random random = new Random();
            int countOfNewItems;

            switch (raceItem)
            {
                case RaceItems.Car:
                    countOfNewItems = random.Next(1, 2);
                    for (int i = 0; i < countOfNewItems; i++)
                    {
                        Map[0, random.Next(1, Map.GetLength(1) - 1)] = 1;
                    }
                    break;

                case RaceItems.Shield:
                    countOfNewItems = random.Next(1, 2);
                    if (ScoreInfo % 1200 == 0)
                    {
                        for (int i = 0; i < countOfNewItems; i++)
                        {
                            Map[0, random.Next(1, Map.GetLength(1) - 1)] = 2;
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        public void MoveRaceItemsDown()
        {
            for (int i = Map.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (Map[i, j] != 0)
                    {
                        int raceItem = Map[i, j];

                        if (i != Map.GetLength(0) - 1)
                        {
                            Map[i, j] = 0;
                            Map[i + 1, j] = raceItem;
                        }
                        else
                        {
                            Map[i, j] = 0;
                        }
                    }
                }
            }
        }

        public void Crash()
        {
            if (Map[AutoY, AutoX] == 1)
            {
                Shield--;
                
                if (Shield < 0)
                    isGameFinished = true;
            }
        }
        public void CatchShield()
        {
            if (Map[AutoY, AutoX] == 2)
            {
                Shield += 1;
            }
        }

        public bool GameFinished()
        {
            return isGameFinished;
        }

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
                        ForegroundColor = DarkCyan;
                        Write(" A");
                    }
                    else if (i - 1 == AutoY && j == AutoX)
                    {
                        ForegroundColor = DarkCyan;
                        Write(" A");
                    }
                    else if (Map[i, j] == 1)
                    {
                        ForegroundColor = Red;
                        Write(" H"); // - отрисовка вражеской машиноки
                    }
                    else if (Map[i, j] == 2)
                    {
                        ForegroundColor = Green;
                        Write(" S"); // - отрисовка щита
                    }
                    else if (j == 0)
                    {
                        ForegroundColor = White;
                        Write(" |");
                    }
                    else if (j == 4)
                    {
                        ForegroundColor = White;
                        Write(" '");
                    }
                    else if (j == 8)
                    {
                        ForegroundColor = White;
                        Write(" '");
                    }
                    else if (j == 12)
                    {
                        ForegroundColor = White;
                        Write(" |");
                    }
                    else
                        Write("  ");
                }
                WriteLine();
            }
            WriteLine();
            ForegroundColor = White;
            Write($"    Score: {ScoreInfo}");
            Write($"    Shield: {Shield}");
        }

        public void LogoFinished()
        {
            WriteLine();
            WriteLine("   **************************");
            WriteLine("   *                        *");
            WriteLine("   *         GAME           *");
            WriteLine("   *        FINISH          *");
            WriteLine("   *                        *");
            WriteLine("   **************************");
            WriteLine();
            WriteLine($"          Score: {ScoreInfo}");
        }
    }
}