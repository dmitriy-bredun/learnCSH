using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW1_Classes
{
    class Playing_field
    {
        public int[,] Map;

        public int SnakeX;
        public int SnakeY;

        public Playing_field(int width, int height)
        {
            Map = new int[width, height];

            Random rand = new Random();

            SnakeX = rand.Next(1, width - 1); 
            SnakeY = rand.Next(1, height - 1); 
        }
        public void PrintMap()
        {
            int width = Map.GetLength(1); // Шо це таке ?
            int height = Map.GetLength(0); // Шо це таке ?

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == SnakeY && x == SnakeX)
                    {
                        Write(" S");
                    }
                    else
                    {
                        Write(" *");
                    }
                }
                WriteLine();
            }
        }
        public void SnakeStepRight()
        {
            if (SnakeX != Map.GetLength(1) - 1) // Шо це таке ?
            {
                SnakeX++;
            }
        }

        public void SnakeStepLeft()
        {
            if (SnakeX != 0)
            {
                SnakeX--;
            }
        }

        public void SnakeStepUp()
        {
            if (SnakeY != 0)
            {
                SnakeY--;
            }
        }

        public void SnakeStepDown()
        {
            if (SnakeY != Map.GetLength(0) - 1) // Шо це таке ?
            {
                SnakeY++;
            }
        }
    }
}

