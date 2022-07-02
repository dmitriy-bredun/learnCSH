using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW1_Classes
{
    class HW_Game_Snake
    {
        public static void StartGameSnake()
        {
            ConsoleKeyInfo key; // Шо це таке ?

            Playing_field game = new Playing_field(10, 10);

            do
            {
                game.PrintMap();

                key = ReadKey();         // Шо це таке ?
                switch (key.Key)         // Шо це таке ?
                {
                    case ConsoleKey.UpArrow: // Шо це таке ?
                        game.SnakeStepUp();
                        break;

                    case ConsoleKey.DownArrow: // Шо це таке ?
                        game.SnakeStepDown();
                        break;

                    case ConsoleKey.LeftArrow: // Шо це таке ?
                        game.SnakeStepLeft();
                        break;

                    case ConsoleKey.RightArrow: // Шо це таке ?
                        game.SnakeStepRight();
                        break;

                    default:
                        break;
                }
                Clear(); // Шо це таке ?
            } while (key.Key != ConsoleKey.Q); // Шо це таке ?
        }
    }
}
