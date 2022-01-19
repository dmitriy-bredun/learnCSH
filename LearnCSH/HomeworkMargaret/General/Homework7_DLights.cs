using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static HomeworkMargaret.Tools.CT;


namespace HomeworkMargaret.General
{
    class Lights
    {
        int lightHeight;
        int lightWidth;
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

        public static void CountDarkSpots(char[,] array)
        {
            int[,] nArray = new int[Height, Width];
            int[,] powerLight = new int[Height, Width];
            int box = 0;
            int movedI = 0;
            int movedJ = 0;

            //for (int i = 0; i < nArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < nArray.GetLength(1); j++)
            //    {
            //        if (array[i, j] == 'L')
            //        {
            //            nArray[i, j] = LightPower;
            //        }
            //    }
            //}

            //for (int i = 0; i < nArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < nArray.GetLength(1); j++)
            //    {
            //        if (nArray[i, j] > 0)
            //        {
            //            box = nArray[i, j];
            //            movedI = i;
            //            movedJ = j;

            //            while (box > 0 && movedI > 0 && movedJ > 0)
            //            {
            //                powerLight[movedI, movedJ]--;
            //                box--;

            //                nArray[movedI, movedJ] = box;
            //            }

            //            movedI = i;
            //            movedJ = j;
            //            box = nArray[movedI, movedJ];

            //            while (box > 0 && movedI < nArray.Length && movedJ < nArray.Length)
            //            {
            //                powerLight[movedI, movedJ]++;
            //                box--;

            //                nArray[movedI, movedJ] = box;
            //            }

            //            powerLight[i, j] = powerLight[i, j] + LightPower;
            //            if (powerLight[i, j] >= nArray.Length)
            //            {
            //                break;
            //            }
            //        }
            //    }

                for (int indx = 0; indx < nArray.GetLength(0); indx++) //покажет массив чисел
                {
                    for (int j = 0; j < nArray.GetLength(1); j++)
                    {
                        Print($"{nArray[movedI, movedJ]}", false);
                    }
                    Space();
                }
            }


        }
    }
}