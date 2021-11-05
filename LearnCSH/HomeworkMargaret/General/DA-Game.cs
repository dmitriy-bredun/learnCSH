using System;
using System.Collections.Generic;
using System.Text;

using HomeworkMargaret.Tools;

namespace HomeworkMargaret.General
{
    class DA_Game
    {
        public static void Start()
        {
            char[,] map = new char[6, 6];
            MapPreparation(map);
            ShowMap(map);
        }

        public static void MapPreparation(char[,] map)
        {

            int horizontalSize = map.GetLength(1);
            int verticalSize = map.GetLength(0);
            for (int lineIndx = 0; lineIndx < map.GetLength(0); lineIndx++)
            {
                for(int rowIndx = 0; rowIndx < map.GetLength(1); rowIndx++)
                {
                    if ((lineIndx == 0 || lineIndx == horizontalSize - 1) || (rowIndx == 0 || rowIndx == verticalSize - 1))
                    {
                        map[lineIndx, rowIndx] = '*';
                    }
                    else
                    {
                        map[lineIndx, rowIndx] = ' ';
                    }
                }
            }

            Random rand = new Random();
            int mVerticalCoord = rand.Next(1, horizontalSize - 2);
            int mHorizontalCood = rand.Next(1, verticalSize - 2);
            map[mVerticalCoord, mHorizontalCood] = 'M';
        }

        public static void ShowMap(char[,] array)
        { 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    CT.Print($"{array[i, j]} ", false);
                }
                CT.Print("");
            }
        }
        
    }
}
