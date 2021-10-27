using System;
using System.Diagnostics;

using static System.Console;

namespace Lessons.Test
{
    class TestProgram
    {
        private delegate int[] TestMethod(int[] inputArray);

        internal static void StartTest()
        {
            // ПОДГОТОВКА ТЕСТОВЫХ ДАННЫХ
            //
            int arrSize = 100000;
            int[] testData = new int[arrSize];

            int minRangeValue = 0;
            int maxRangeValue = 100;
            Initialize(minRangeValue, maxRangeValue, testData, true);
          

            WriteLine("Run Test 1: ArrayToolDmitriy");
            int[] result1 = RunTestMethod(testData, ArrayToolDmitriy.Most_Frequently_Used_Numbers);

            WriteLine();

            WriteLine("Run Test 2: ArrayToolDenis");
            int[] result2 = RunTestMethod(testData, ArrayToolDenis.FindTheThreeMostRepeatingNumbers);

            WriteLine();
        }


        private static int[] RunTestMethod(int[] inputArray, TestMethod method)
        {
            Stopwatch stopWatch = new Stopwatch();
            
            stopWatch.Start();
            var result = method(inputArray);
            stopWatch.Stop();
            
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds); // накапливается погрешность -> TotalMilliseconds

            Console.WriteLine($"RunTime of {method.Method.Name} method = " + elapsedTime);

            return result;
        }

        private static void Initialize
        (
            int min, 
            int max, 
            int[] data, 
            bool needSort = false, 
            bool needShow = false
        )
        {
            Random rand = new Random(DateTime.Now.Second);

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(min, max);
            }

            if (needSort)
            {
                WriteLine("ARRAY SORTING...");

                ArrayToolDenis.Quicksort(data, 0, data.Length - 1);

                WriteLine("ARRAY SORTING IS DONE!");
            }

            if (needShow)
            {
                foreach (var item in data)
                {
                    Write($"{item}  ");
                }

                WriteLine();
                WriteLine();
            }
        }
    }
}