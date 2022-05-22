using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static HomeworkMargaret.Tools.CT;


namespace HomeworkMargaret.General
{
    class Light
    {
        public int lightH;
        public int lightW;

        public Light(int lightH, int lightW)
        {
            this.lightH = lightH;
            this.lightW = lightW;
        }
    }


    class Homework7_DLights
    {
        private static int LightPower;
        private static int Height;
        private static int Width;
        public static void Start()
        {
            Height = EnterInt("Write the size of your hallway: ");
            Width = Height;
            char[,] array = new char[Height, Width];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 'x';
                }
            }

            int userChoice;
            do
            {
                Space();
                userChoice = Menu(
                    " show hallway ",
                    " add a candle",
                    " remove the candle",
                    " set the light",
                    " count all dark spots");

                switch (userChoice)
                {
                    case 1:
                        ShowHallway(array);
                        break;

                    case 2:
                        AddACandle(array);
                        break;

                    case 3:
                        RemoveTheCandle(array);
                        break;

                    case 4:
                        SetTheLight(array);
                        break;

                    case 5:
                        CountDarkSpots(array);
                        break;

                    case 0:
                        WriteLine("you can't hide in the dark");
                        break;

                    default:
                        ErrorMsg("Light at the end of the hallway means you're dead. Sorry not sorry");
                        break;
                }
            } while (userChoice != 0);
        }

        public static void ShowHallway(char[,] array)
        {
            Print("Enjoy your deadly hallway");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Print($"{array[i, j]}", false);
                }
                Space();
            }
        }

        public static void AddACandle(char[,] array)
        {
            int candleI = EnterInt($"Write the first coordinate of your candle (from 0 to {array.GetLength(0)}): ");
            int candleJ = EnterInt($"Write the second coordinate of your candle (from 0 to {array.GetLength(1)}): ");
            array[candleI, candleJ] = 'L';
        }

        public static void RemoveTheCandle(char[,] array)
        {
            Print("Turn off the lights!");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 'x';
                }
            }
        }

        public static void SetTheLight(char[,] array)
        {
            int power = EnterInt("Choose the power of your candle (MAX  --> 5): ");
            if (power <= 0)
            {
                Print("The power of your candle cannot be less than 1.");
                return;
            }

            LightPower = power;
        }

        public static void CountDarkSpots(char[,] charArray)
        {

            int[,] numberArray = new int[Height, Width];
            int countPointsOfLight = 0;
            int someIndx = 0;

            for (int i = 0; i < Height; i++) // Просто считает количество источников света
            {
                for (int j = 0; j < Width; j++)
                {
                    if (charArray[i, j] == 'L')
                    {
                        countPointsOfLight++;
                    }
                }
            }

            Light[] lightPoints = new Light[countPointsOfLight];
            for(int i = 0; i < Height; i++) // формируем цифровой массив + делаем запись в массив точек
            {
                for(int j = 0; j < Width; j++)
                {
                    if(charArray[i, j] == 'L')
                    {
                        numberArray[i, j] = LightPower;

                        Light lightPoint = new Light(i, j);
                        lightPoints[someIndx] = lightPoint;
                        someIndx++;
                    }
                }
            }

            foreach()

            for (int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    if (someIndx > 0)
                    {
                        someIndx--;
                    }

                }
            }

            for (int ind = 0; ind < Height; ind++) // покажет массив чисел
            {
                 for (int j = 0; j < Width; j++)
                 {
                     Print($"{numberArray[ind, j]}", false);
                 }
                 Space();
            }
        }
    }
}