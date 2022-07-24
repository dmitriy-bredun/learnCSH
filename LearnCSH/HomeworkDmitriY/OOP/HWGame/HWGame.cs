using System;
using System.Collections.Generic;
using System.Text;

using HomeworkDmitriy.Tools;
using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.OOP.HWGame
{
    class HWGame
    {
        public static void StartGame()
        {
            Console.Clear();
            
            ConsoleKeyInfo infoKey;

            Racing game = new Racing(24, 13);

            do
            {
                game.PrintMap();

                infoKey = Console.ReadKey();
                switch (infoKey.Key)
                {
                    case ConsoleKey.W:
                        game.AutoUp();
                        break;

                    case ConsoleKey.S:
                        game.AutoDown();
                        break;

                    case ConsoleKey.A:
                        game.AutoLeft();
                        break;

                    case ConsoleKey.D:
                        game.AutoRight();
                        break;

                    default:
                        break;
                }

                Console.Clear();
            } while (infoKey.Key != ConsoleKey.Q);
        }
    }
}