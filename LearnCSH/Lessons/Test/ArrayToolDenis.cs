using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Test
{
    class ArrayToolDenis
    {
        public static int[] FindTheThreeMostRepeatingNumbers(int[] arr)
        {
            int counter = 0;
            var topRepsList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    counter++;
                    continue;
                }
                if (arr[i] == arr[i - 1])
                {
                    counter++;
                    if (i == arr.Length - 1)
                    {
                        topRepsList.Add(counter);
                    }
                }
                else
                {
                    topRepsList.Add(counter);
                    counter = 0;
                    counter++;
                    if (i == arr.Length - 1)
                    {
                        topRepsList.Add(counter);
                    }
                }
            }

            var topReps = new int[topRepsList.Count];
            for (int i = 0; i < topReps.Length; i++)
            {
                topReps[i] = topRepsList[i];
            }
            Quicksort(topReps, 0, topReps.Length - 1);

            counter = 0;
            var topMostDuplicateValues = new Dictionary<int, int>();
            for (int i = topReps.Length - 1; i > -1; i--)
            {
                for (int j = arr.Length - 1; j >= -1; j--)
                {
                    if (j == arr.Length - 1)
                    {
                        counter++;
                    }
                    else
                    {
                        if (j != -1)
                        {
                            if (arr[j] == arr[j + 1])
                            {
                                counter++;
                            }
                            else
                            {
                                if (counter == topReps[i] && !topMostDuplicateValues.ContainsValue(arr[j + 1]))
                                {
                                    topMostDuplicateValues.Add(i + 1, arr[j + 1]);
                                    break;
                                }
                                else
                                {
                                    counter = 1;
                                }
                            }
                        }
                        else
                        {
                            if (counter == topReps[i] && !topMostDuplicateValues.ContainsValue(arr[j + 1]))
                            {
                                topMostDuplicateValues.Add(i + 1, arr[j + 1]);
                                break;
                            }
                        }

                    }
                }
                counter = 0;
            }

            int[] topNumbers = new int[3];

            counter = 0;
            foreach (var value in topMostDuplicateValues.Values)
            {
                topNumbers[counter] = value;
                counter++;

                if (counter == 3)
                {
                    break;
                }
            }
            return topNumbers; //topNumbers --- topMostDuplicateValues.Values;
        }

        public  static void SortTheArray(int[] arr)
        {
            bool sortingIsNeeded = true;
            while (sortingIsNeeded)
            {
                sortingIsNeeded = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        sortingIsNeeded = true;
                    }
                }
            }
        }

        public static void Quicksort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(arr, start, end);
            Quicksort(arr, start, pivot - 1);
            Quicksort(arr, pivot + 1, end);
        }
        private static int Partition(int[] targetArr, int start, int end)
        {
            int position = start;
            int value = targetArr[end];
            for (int i = start; i < end; i++)
            {
                if (targetArr[i] <= value)
                {
                    int temp = targetArr[i];
                    targetArr[i] = targetArr[position];
                    targetArr[position] = temp;
                    position++;
                }
            }
            targetArr[end] = targetArr[position];
            targetArr[position] = value;
            return position;
        }
    }
}
