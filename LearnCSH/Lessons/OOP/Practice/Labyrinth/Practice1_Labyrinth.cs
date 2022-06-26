using System;

namespace Lessons.OOP.Practice.Labyrinth
{
    class Practice1_Labyrinth
    {
        public static void StartGame()
        {

            ConsoleKeyInfo key;

            Labyrinth game = new Labyrinth(10, 10);

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
