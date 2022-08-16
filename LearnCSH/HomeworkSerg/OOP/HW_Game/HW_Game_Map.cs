using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.OOP.HW1_Game
{
    class Playing_field
    {
        public int[,] Map;

        public int SnakeX;
        public int SnakeY;

        public int mouseX1;
        public int mouseY1;

        public int mouseX2;
        public int mouseY2;

        public int Eat;
        public int Snake;

        public Playing_field(int width, int height)
        {
            Map = new int[width, height];

            Random rand = new Random();

            SnakeX = rand.Next(1, width - 1); 
            SnakeY = rand.Next(1, height - 1);

            Random rand1 = new Random();

            mouseX1 = rand1.Next(1, width - 1);
            mouseY1 = rand1.Next(1, height - 1);

            Random rand2 = new Random();

            mouseX2 = rand2.Next(1, width - 1);
            mouseY2 = rand2.Next(1, height - 1);
        }
        public void PrintMap()
        {
            int width = Map.GetLength(1); // Шо це таке ?
            int height = Map.GetLength(0); // Шо це таке ?

            Write("   ");
            for (int i = 0; i < width+2; i++)
            {
                Write("- ");
            }

            WriteLine();
            for (int y = 0; y < height; y++)
            {
                Write("   |");
                for (int x = 0; x < width; x++)
                {
                    if (y == SnakeY && x == SnakeX)
                    {
                        Write(" S");

                        for (int i = 0; i < Snake; i++)
                        {
                            Write("S");
                        }
                        
                    }
                    else if(y == mouseY1 && x == mouseX1)
                    {
                        Write(" M");
                    }
                    else if(y == mouseY2 && x == mouseX2)
                    {
                        Write(" M");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                Write(" |");
                WriteLine();
            }
            Write("   ");
            for (int i = 0; i < width + 2; i++)
            {
                Write("- ");
            }
            WriteLine();
            WriteLine($"   Кол-во. сожраных мыш: {Eat}");
        }
        public void SnakeStepRight()
        {
            if (SnakeX != Map.GetLength(1) - 1) // Шо це таке ?
            {
                SnakeX++;
            }
            EatsMouse();
        }

        public void SnakeStepLeft()
        {
            if (SnakeX != 0)
            {
                SnakeX--;
            }
            EatsMouse();
        }

        public void SnakeStepUp()
        {
            if (SnakeY != 0)
            {
                SnakeY--;
            }
            EatsMouse();
        }

        public void SnakeStepDown()
        {
            if (SnakeY != Map.GetLength(0) - 1) // Шо це таке ?
            {
                SnakeY++;
            }
            EatsMouse();
        }
        public void EatsMouse()
        {
            Random R = new Random();
            if (SnakeX == mouseX1 && SnakeY == mouseY1)
            {
                mouseX1 = R.Next(0, Map.GetLength(1) - 1);
                mouseY1 = R.Next(0, Map.GetLength(0) - 1);
                Eat++; Snake++;
            }
            if (SnakeX == mouseX2 && SnakeY == mouseY2)
            {
                mouseX2 = R.Next(0, Map.GetLength(1) - 1);
                mouseY2 = R.Next(0, Map.GetLength(0) - 1);
                Eat++; Snake++;
            }
        }
    }
}

