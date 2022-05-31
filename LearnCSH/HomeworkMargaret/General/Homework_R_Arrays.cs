using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

using HomeworkMargaret.Tools;


namespace HomeworkMargaret.General
{
    class Homework_R_Arrays
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
                    " fill array with random numbers",
                    " show array",
                    " change element in array",
                    " count and show arithmetic mean of even numbers",
                    " check the sum of odd elements",
                    " count sum between max and min elements",
                    " sort array in ascending order");
                CT.Space();

                switch (userChoice)
                {
                    case 1:
                        FillWithRandNumb(array);
                        break;

                    case 2:
                        ShowArray(array);
                        break;

                    case 3:
                        ShowArray(array);
                        CT.Space();
                        int indx = CT.EnterInt($"write the element you want to change: ");
                        int newNumb = CT.EnterInt($"write new number: ");
                        ChangeElement(array, indx, newNumb);
                        CT.Print("Old element has been changed.");
                        break;

                    case 4:
                        ArithmeticMeanOfEvenNumb(array);
                        break;

                    case 5:
                        int limit = CT.EnterInt("enter the limit: ");
                        SumOfOddElements(array, limit);
                        break;

                    case 6:
                        SumBetweenMaxAndMin(array);
                        break;

                    case 7:
                        SortArray(array);
                        CT.Print("The array has been sorted.");
                        break;

                    case 0:
                        CT.Print("Bye, loser!");
                        break;

                    default:
                        CT.ErrorMsg("Don't be such a loser, loser");
                        break;
                }

            } while (userChoice != 0);
        }

        private static void FillWithRandNumb(int[] array)
        {
            AT.RandomArray(array);
        }

        private static void ShowArray(int[] array)
        {
            AT.ShowArray(array);
        }

        private static void ChangeElement(int[] array, int indx, int newNumb)
        {
            array[indx] = newNumb;
            CT.Space();
        }

        private static double ArithmeticMeanOfEvenNumb(int[] array)
        {
            int sum = 0;
            int counter = 0;
            double arithMean;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    sum = array[i] + sum;
                    counter++;
                }
            }
            arithMean = sum / counter;

            CT.Print(arithMean, "arithmetic mean ");
            return arithMean;
        }

        private static bool SumOfOddElements(int[] array, int limit)
        {
            bool limitIsLess = true;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0 && i != 0)
                {
                    sum = array[i] + sum;
                }
            }

            if (limit < sum)
            {
                CT.Print("Sum of odd elements is bigger than limit.");
                limitIsLess = true;
            }
            else if (limit == sum)
            {
                CT.Print("Sum and limit are equal.");
                limitIsLess = true;
            }
            else
            {
                CT.Print("Sum of odd elements is smaller than limit.");
                limitIsLess = false;
            }

            return limitIsLess;
        }

        private static int SumBetweenMaxAndMin(int[] array)
        {
            int min = array[0];
            int max = array[0];

            int minIndx = -1;
            int maxIndx = -1;

            int sum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                    maxIndx = i;
                }

                if(array[i] < min)
                {
                    min = array[i];
                    minIndx = i;
                }
            }

            if (minIndx > maxIndx)
            {
                for(int i = maxIndx + 1; i < minIndx; i++)
                {
                    sum += array[i];
                }
            }
            else
            {
                for(int i = minIndx + 1; i < maxIndx; i++)
                {
                    sum += array[i];
                }
            }
            CT.Print(sum, "The sum is ");
            return sum;
        }

        private static void SortArray(int[] array)
        {
            bool needSorting = true;

            while (needSorting)
            {
                needSorting = false;
                for (int i = 0; i < array.Length - 1; i++)        // -1, чтобы не выйти за границу массива, когда array[i+1];
                {
                    if (array[i] > array[i + 1])
                    {
                        int box = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = box;

                        needSorting = true;
                    }
                }
            }
        }
    }
}
