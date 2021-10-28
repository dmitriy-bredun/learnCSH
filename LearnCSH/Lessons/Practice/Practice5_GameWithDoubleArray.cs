using System;

using static System.Console;

namespace Lessons.Practice
{
    class Practice5_GameWithDoubleArray
    {
        public static void Start()
        {
            int height = 5;
            int width = 10;
            int[,] map = new int[height, width];
            
            CreatePersonOnMap(map, out int personHCoord, out int personWCoord);
            ConsoleKeyInfo keyInfo;
            ShowMap(map);

            do
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (personHCoord != 0)
                        {
                            personHCoord = personHCoord - 1;
                        }
                        
                        ChangePersonPosition(map, personHCoord, personWCoord);
                        break;

                    case ConsoleKey.DownArrow:
                        if (personHCoord != map.GetLength(0) - 1)
                        {
                            personHCoord = personHCoord + 1;
                        }
                        
                        ChangePersonPosition(map, personHCoord, personWCoord);
                        break;

                    case ConsoleKey.LeftArrow:
                        if (personWCoord != 0)
                        {
                            personWCoord = personWCoord - 1;
                        }
                        
                        ChangePersonPosition(map, personHCoord, personWCoord);
                        break;

                    case ConsoleKey.RightArrow:
                        if (personWCoord != map.GetLength(1) - 1)
                        {
                            personWCoord = personWCoord + 1;
                        }
                        
                        ChangePersonPosition(map, personHCoord, personWCoord);
                        break;

                    default:
                        break;
                }

                Console.Clear();
                ShowMap(map);

            } while (keyInfo.Key != ConsoleKey.Escape);
        }


        private static void CreatePersonOnMap(int[,] map, out int personHCoord, out int personWCoord)
        {
            int height = map.GetLength(0);
            int width = map.GetLength(1);

            Random rand = new Random();

            personHCoord = rand.Next(0, height);
            personWCoord = rand.Next(0, width);

            map[personHCoord, personWCoord] = 1;
        }
        
        private static void ChangePersonPosition(int [,] map, int newPersonHCoord, int newPersonWCoord)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = 0;
                }
            }

            map[newPersonHCoord, newPersonWCoord] = 1;
        }

        private static void ShowMap(int[,] arr, bool showDiagonal = false)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Write("|");
                    }

                    Write($" {arr[i, j]} |");
                }

                WriteLine();
            }
        }
    }
}
