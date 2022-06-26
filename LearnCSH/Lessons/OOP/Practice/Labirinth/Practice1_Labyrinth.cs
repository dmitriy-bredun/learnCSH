using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.OOP.Practice.Labirinth
{
    class Practice1_Labyrinth
    {
        public static void StartGame()
        {

            ConsoleKeyInfo key;

            Labirinth game = new Labirinth(10, 10);

            do
            {
                game.PrintMap();

                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        game.MouseStepUp();
                        break;


                    case ConsoleKey.DownArrow:
                        game.MouseStepDown();
                        break;


                    case ConsoleKey.LeftArrow:
                        game.MouseStepLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        game.MouseStepRight();
                        break;

                    default:
                        break;
                }


                Console.Clear();
            } while (key.Key != ConsoleKey.Q);
        }
    }
}
