using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Convert;

namespace HomeworkDenis.General
{
    class Homework4_SimpleArrays
    {
        public static void Start()
        {
            //..Too easy ;) But! ^-^ :
            Task6();
        }
        private static void Task6()
        {
            var arr = new int[15];
            //InitializeTheArray(ref arr);
            FillTheArrayWithRandomNumbers(ref arr);
            ShowTheArray(arr);
            SortTheArray(arr);
            ShowTheArray(arr);
            FindTheThreeMostRepeatingNumbers(arr);
        }
        private static void InitializeTheArray(ref int[] arr)
        {
            bool checkerForRightValue = false;
            ref bool checker = ref checkerForRightValue;
            WriteLine("Please, enter the values of array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    checker = false;
                    Write($"{i + 1}) ");
                    try
                    {
                        arr[i] = ToInt32(ReadLine());
                        checker = true;
                    }
                    catch (Exception)
                    {
                        WriteLine("Please, enter the value!");
                    }
                } while (checker == false);
            }
        }
        private static void FillTheArrayWithRandomNumbers(ref int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
        }
        private static void ShowTheArray(int[] arr)
        {
            WriteLine("ARRAY: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"{i + 1}) {arr[i]}\n");
            }
            WriteLine("THE END");
        }
        private static void SortTheArray(int[] arr)
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
        private static void FindTheThreeMostRepeatingNumbers(int[] arr)
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
            SortTheArray(topReps);

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
                        if(j != -1)
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

            var topOfValues = topMostDuplicateValues.Values;
            WriteLine("\n\n--------------------------------TOP--------------------------------");
            counter = 1;
            foreach (var value in topOfValues)
            {
                WriteLine($"{counter} -- {value}");
                counter++;
            }
        }
    }
}