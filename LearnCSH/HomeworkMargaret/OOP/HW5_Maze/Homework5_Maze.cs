using System;
using System.Collections.Generic;
using System.Text;
using HomeworkMargaret.Tools;

namespace HomeworkMargaret.OOP.HW5_Maze
{
    class Homework5_Maze
    {
        public static void Start()
        {
            Maze maze = new Maze();
            bool youWin;
            do
            {
                maze.ShowMap();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        maze.MouseUp();
                        break;

                    case ConsoleKey.DownArrow:
                        maze.MouseDown();
                        break;

                    case ConsoleKey.LeftArrow:
                        maze.MouseLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        maze.MouseRight();
                        break;

                    default:
                        break;
                }
                Console.Clear();
                youWin = maze.CheeseIsEaten();
            } while (!youWin);
            YouWin();
        }
        private static void YouWin()
        {
            CT.Print("**************************");
            CT.Print("*        CONGRATS!       *");
            CT.Print("*                        *");
            CT.Print("*         YOU            *");
            CT.Print("*         WIN            *");
            CT.Print("**************************");
        }
    }
}
