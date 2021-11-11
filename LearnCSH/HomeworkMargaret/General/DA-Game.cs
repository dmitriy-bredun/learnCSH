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
            char[,] map = new char[10, 10];
            MapPreparation(map);
            ShowMap(map);

            bool mouseCatchCheese = false;
            do
            {                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                             
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveUp(map);
                        break;

                    case ConsoleKey.DownArrow:
                        MoveDown(map);
                        break;

                    case ConsoleKey.LeftArrow:
                        MoveLeft(map);
                        break;

                    case ConsoleKey.RightArrow:
                        MoveRight(map);
                        break;

                    default:
                        break;
                }

                mouseCatchCheese = true;

            } while (mouseCatchCheese != true);
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


            Random rnd = new Random();
            int сVerticalCoord = rand.Next(1, horizontalSize - 2);
            int сHorizontalCood = rand.Next(1, verticalSize - 2);
            map[сVerticalCoord, сHorizontalCood] = 'С';

            //for (int i = 0; i < map.GetLength(0); i++)
            //{
            //    for (int j = 0; j < map.GetLength(1); j++)
            //    {
            //        if (map[i, j] == 'M')
            //        {
            //            Console.ForegroundColor = ConsoleColor.White;
            //            CT.Print($"{map[i, j]} ", false);
            //            Console.ForegroundColor = ProgramMargaret.AppForegroundColor;
            //        }
            //        else if (map[i, j] == 'C')
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //            CT.Print($"{map[i, j]} ", false);
            //            Console.ForegroundColor = ProgramMargaret.AppForegroundColor;
            //        }
            //    }
            //}
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
        
        public static void MoveUp(char[,] map)
        {
            // 1. найти текущие координаты мыши
            // 2. проверить, можно ли сделать шаг вверх
            // 3. сделать шаг 

            int mouseH = -1;
            int mouseW = -1;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 'M')
                    {
                        mouseH = i;
                        mouseW = j;
                    }                    
                }                
            }
            
            if (map[mouseH - 1, mouseW] != '*')
            {
                map[mouseH - 1, mouseW] = 'M';
                map[mouseH, mouseW] = ' ';
            }
        }

        public static void MoveDown(char[,] map)
        {  
            int mouseH = -1;
            int mouseW = -1;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 'M')
                    {
                        mouseH = i;
                        mouseW = j;
                    }
                }
            }
                        
            if (map[mouseH, mouseW] != map[mouseH + 1, mouseW])
            {
                map[mouseH + 1, mouseW] = 'M';
                map[mouseH, mouseW] = ' ';
            }
        }

        public static void MoveLeft(char[,] map)
        {  
            int mouseH = -1;
            int mouseW = -1;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 'M')
                    {
                        mouseH = i;
                        mouseW = j;
                    }
                }
            }

            bool mouseCanMove = false;
            if (map[mouseH, mouseW] != map[mouseH, mouseW - 1])
            {
                mouseCanMove = true;
            }
        }

        public static void MoveRight(char[,] map)
        {
            int mouseH = -1;
            int mouseW = -1;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 'M')
                    {
                        mouseH = i;
                        mouseW = j;
                    }
                }
            }

            bool mouseCanMove = false;
            if (map[mouseH, mouseW + 1] != '*')
            {
                mouseCanMove = true;
            }
        }
    }
}
