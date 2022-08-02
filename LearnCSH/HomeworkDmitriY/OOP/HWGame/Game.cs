using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.OOP.HWGame
{
    class Game
    {
        public static void StartGame()
        {
            ConsoleKeyInfo infoKey;
            bool isGameFinished;
            Racing game = new Racing(24, 13);
            
            Clear();
            do
            {
                game.PrintMap();

                infoKey = ReadKey();
                switch (infoKey.Key)
                {
                    case ConsoleKey.W:
                        game.Move();
                        break;

                    case ConsoleKey.A:
                        game.Left();
                        break;

                    case ConsoleKey.D:
                        game.Right();
                        break;

                    default:
                        break;
                }
                Clear();
                isGameFinished = game.GameFinished();
                if (isGameFinished)
                {
                    game.LogoFinished();
                }

            } while (infoKey.Key != ConsoleKey.Q && isGameFinished != true);
        }
    }
}