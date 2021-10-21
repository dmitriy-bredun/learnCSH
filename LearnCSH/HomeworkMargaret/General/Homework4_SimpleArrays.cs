using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

using HomeworkMargaret.Tools;


namespace HomeworkMargaret.General
{
    class Homework4_SimpleArrays
    {
        public static void Start()
        {
            CT.Print("Enter array size: ", false);
            int size = Convert.ToInt32(ReadLine());
            int[] array = new int[size];

            int userChoice;
            do
            {
                CT.Space();
                userChoice = CT.Menu(
                    " manual array",
                    " random numbers array",
                    " show array",
                    " change an element in array",
                    " count and show amount of even and odd numbers",
                    " count average of array",
                    " index min and max element",
                    " reset all negatives",
                    " sum of elements between min and max elements");
                CT.Space();

                switch (userChoice)
                {
                    case 1:
                        ManualArray(array);
                        break;

                    case 2:
                        RandomNumbers(array);
                        break;

                    case 3:
                        ShowArray(array);
                        break;

                    case 4:
                        ChangeElement(array);
                        break;

                    case 5:
                        CountEvenOdd(array);
                        break;

                    case 6:
                        CountAverage(array);
                        break;

                    case 7:
                        IndexMinMax(array);
                        break;

                    case 8:
                        ResetNegatives(array);
                        break;

                    case 9:
                        SumElements(array);
                        break;

                    case 0:
                        WriteLine("next time you'll die");
                        break;

                    default:
                        CT.ErrorMsg("Red Hood wishes you die");
                        break;
                }
            } while (userChoice != 0);
        }
        public static void ManualArray(int[] values)
        {
            CT.Print("Enter array values: ");
            for (int indx = 0; indx < values.Length; indx++)
            {
                values[indx] = CT.EnterInt($"Enter values [{indx}]: ");
            }
            CT.Print("Array is initialized. Good service!");
        }

        public static void RandomNumbers(int[] values)
        {
            Random rnd = new Random();
            int minVal = CT.EnterInt("write minimal value: ");
            int maxVal = CT.EnterInt("write maximum value: ");

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rnd.Next(minVal, maxVal);
            }
        }

        public static void ShowArray(int[] values)
        {
            CT.Print("Showing array");
            for (int indx = 0; indx < values.Length; indx++)
            {
                CT.Print($"[{indx}] = {values[indx]}  ", false);
            }
        }
        public static void ChangeElement(int[] values)
        {
            ShowArray(values);
            CT.Space();

            int indx = CT.EnterInt($"Write the element you wanna change: ");
            int newVal = CT.EnterInt($"write new value: ");

            values[indx] = newVal;

            CT.Print("The value has been changes. Old value has been sent to Arkham.");
        }

        public static void CountEvenOdd(int[] values)
        {
            int countEven = 0;
            int countOdd = 0;
            for (int indx = 0; indx < values.Length; indx++)
            {
                if (values[indx] == 0)
                {
                    continue;
                }

                if (values[indx] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            CT.Print(countEven, "Quantity of even numbers");
            CT.Print(countOdd, "Quantity of odd numbers");
        }

        public static void CountAverage(int[] values)
        {
            int sum = 0;
            double reslut;

            for (int indx = 0; indx < values.Length; indx++)
            {
                sum = values[indx] + sum;
            }
            reslut = sum / values.Length;

            CT.Print(reslut, "Average slut");
        }

        public static void IndexMinMax(int[] values)
        {
            int min = values[0];
            int max = values[0];

            int minIndx = -1;
            int maxIndx = -1;

            for (int indx = 0; indx < values.Length; indx++)
            {
                if (min > values[indx])
                {
                    min = values[indx];
                    minIndx = indx;
                }

                if (max < values[indx])
                {
                    max = values[indx];
                    maxIndx = indx;
                }
            }

            CT.Print(minIndx, "Minimal index ");
            CT.Print(maxIndx, "Maximal index ");
        }

        public static void ResetNegatives(int[] values)
        {
            for (int indx = 0; indx < values.Length; indx++)
            {

                if (values[indx] < 0)
                {
                    values[indx] = 0;
                }
            }
            CT.Print("All negatives have been sent to Blackgate.");
        }

        public static void SumElements(int[] values)
        {
            int min = values[0];
            int max = values[0];

            int minIndx = -1;
            int maxIndx = -1;
            int sum = 0;

            for (int indx = 0; indx < values.Length; indx++)          // сначала находим минимальный и максимальный элементы
            {
                if (min > values[indx])
                {
                    min = values[indx];
                    minIndx = indx;
                }

                if (max < values[indx])
                {
                    max = values[indx];
                    maxIndx = indx;
                }
            }

            if (minIndx < maxIndx)                                      // в случае, если min значение раньше max, 
            {                                                           // то считаем в порядке от min до max
               for (int indx = minIndx + 1; indx < maxIndx; indx++)
               {
                    sum = sum + values[indx];
               }
            }

            if (maxIndx < minIndx)                                       // если max значение раньше min, то считаем от max до min 
            {
                for (int indx = maxIndx + 1; indx < minIndx; indx++)
                {
                    sum = sum + values[indx];
                }
            }

            CT.Print(sum, "Sum of elemets");
        }
    }
}