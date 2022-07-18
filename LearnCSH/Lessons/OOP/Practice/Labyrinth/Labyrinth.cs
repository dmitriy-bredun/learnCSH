using System;

namespace Lessons.OOP.Practice.Labyrinth
{
    class Labyrinth
    {
        public int[,] Map;

        public int MouseI;
        public int MouseJ;

        // 1 - Создание и генерация
        public Labyrinth(int height, int width)
        {
            Map = new int[height, width];

            Random rand = new Random();

            MouseI = rand.Next(0, height - 1);
            MouseJ = rand.Next(0, width - 1);
        }


        // 2 - методы перемещения мышки
        public void MouseStepUp()
        {
            if (MouseI != 0)
            {
                MouseI--;
            }
        }

        public void MouseStepDown()
        {
            if (MouseI != Map.GetLength(0) - 1)
            {
                MouseI++;
            }
        }

        public void MouseStepLeft()
        {
            if (MouseJ != 0)
            {
                MouseJ--;
            }
        }

        public void MouseStepRight()
        {
            if (MouseJ != Map.GetLength(1) - 1)
            {
                MouseJ++;
            }
        }


        // 3 - метод отрисовки карты
        public void PrintMap()
        {
            int height = Map.GetLength(0);
            int width = Map.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == MouseI && j == MouseJ)
                    {
                        Console.Write(" M");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }

                Console.WriteLine();
            }
        }

    }
}
