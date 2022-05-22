using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static HomeworkMargaret.Tools.CT;

namespace HomeworkMargaret.General
{
    class Homework6_Lights
    {
        private static int lightVolume;
        public static void Start()
        {
            char[] array = new char[15];
            for(int indx = 0; indx < array.Length; indx++)
            {
                array[indx] = 'x';
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
                Space();

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

        public static void ShowHallway(char[] array)
        {
            Print("Showing hallway");
            for (int indx = 0; indx < array.Length; indx++)
            {
               Print($"{array[indx]}", false);
            }
        }

        public static void AddACandle(char[] array)
        {
            int candleIndx = EnterInt("Write where you wanna add a candle: ");
            array[candleIndx] = 'L';
        }

        public static void RemoveTheCandle(char[] array)
        {
            Print("All the lights are off. Enjoy the darkness.");
            for (int indx = 0; indx < array.Length; indx++)
            {
                if(array[indx] == 'L')
                {
                    array[indx] = 'x';
                }
                else
                {
                    array[indx] = 'x';
                }
            }
        }

        public static void SetTheLight(char[] array)
        {
            int input = EnterInt("Choose the power of your candle (max - 5): ");
            if (input <= 0)
            {
                Print("The power of your candle cannot be less than 1.");
                return;
            }

            lightVolume = input;
        }
        public static void CountDarkSpots(char[] array)
        {
            int[] numbArray = new int[15];
            int box = 0;
            int movedIndx = 0;
            for (int indx = 0; indx < numbArray.Length; indx++)
            {
                if (array[indx] == 'L')
                {
                    numbArray[indx] = lightVolume;
                }
            }

            for(int indx = 0; indx < numbArray.Length; indx++)
            {
                if (numbArray[indx] > 0)
                {
                    box = numbArray[indx];
                    movedIndx = indx;

                    while (box > 0 && movedIndx > 0)
                    {
                        movedIndx--;
                        box--;

                        numbArray[movedIndx] = box;
                    }

                    movedIndx = indx;
                    box = numbArray[indx];

                    while (box > 0 && movedIndx < numbArray.Length)
                    {
                        movedIndx++;
                        box--;

                        numbArray[movedIndx] = box;
                    }

                    indx = indx + lightVolume;
                    if (indx >= numbArray.Length)
                    {
                        break;
                    }
                }
            }

            int counter = 0;
            for (int i = 0; i < numbArray.Length; i++)
            {
                if (numbArray[i] == 0)
                {
                   counter++;
                }
            }
            Print($"Amount of dark spots is {counter}.");
        }
    }   
}
