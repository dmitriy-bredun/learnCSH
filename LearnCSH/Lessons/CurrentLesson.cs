using System;
using System.Threading;
using Lessons.Tools;

using static System.Console;
using static System.Convert;

namespace Lessons
{
    class CurrentLesson
    {
        public static void GoGoGo()
        {
            //RefExample();
            //OutExample();

            //OPTIONAL PARAMETERS
            int result1 = Calculation(5, 5);     // result = 10
            int result2 = Calculation(5, 5, 3, true);  // result = 13

            //Params example
            int bigSum1 = CalculateSumm(5, 3, 77, 2, 10, 1, 2, 34, 5, 6, 4, 3, 56, 6, 4, 3, 5, 6);

            int[] someValues = new int[10];
            someValues[1] = 123;
            someValues[3] = 124;
            someValues[5] = 125;
            int bigSum2 = CalculateSumm(someValues);

            string[] messages = new string[2];
            messages[0] = "Hello buddy";
            messages[1] = "How are you?";
            PrintMessages(messages);

            PrintMessages("Hello buddy 2", "How are you? 2", "123123", "34534");
        }

        // =================== R E F    E X A M P L E =====================
        public static void RefExample()
        {
            // ref example
            double[] chisla = new double[100];

            int x = 7;
            int y = 13;
            int k = 1;

            for (int indx = 0; indx < chisla.Length; indx++)
            {
                if (indx < 25)
                {
                    chisla[indx] = MathBomb1(x, y, ref k);
                }
                else if (indx > 25 && indx <= 50)
                {
                    chisla[indx] = MathBomb2(x, y, ref k);
                }
                else
                {
                    chisla[indx] = MathBomb3(x, y, ref k);
                }
            }

            // тупо вывод на экv cvран 
            ShowArray(chisla);
        }
        public static double MathBomb1(int x, int y, ref int k)
        {
            int val = (x + y * k) / k;

            k += 1;
            if (k >= 10)
            {
                k = 1;
            }

            return val;
        }
        public static double MathBomb2(int x, int y, ref int k)
        {
            int val = (x + y * 2 * k) / k;

            k += 2;
            if (k >= 10)
            {
                k = 1;
            }

            return val;
        }
        public static double MathBomb3(int x, int y, ref int k)
        {
            int val = (x + y * 3 * k) / k;

            k += 3;
            if (k >= 10)
            {
                k = 1;
            }

            return val;
        }


        // =================== O U T    E X A M P L E =====================
        public static void OutExample()
        {
            double a = 5;
            double b = 0;

            bool isOperationDone = Divide(a, b, out double result);
            if (isOperationDone == true)
            {
                WriteLine($"Операция деления выполнена успешно. Результат: {result}");
            }
            else
            {
                WriteLine($"Операция деления невозможна. Вы пытаетесь поделить на 0. Результат: {result}");
            }
        }
        public static bool Divide(double a, double b, out double result)
        {
            result = 0;
            if (b == 0)
            {
                return false;
            }

            result = a / b;
            return true;
        }

        // =================== OPTIONAL PARAMETERS =====================
        public static void ShowArray(double[] array, bool inColumn = true)
        {
            for (int indx = 0; indx < array.Length; indx++)
            {
                Write($"arr[{indx}] = {array[indx]} \t");

                if (inColumn == true)
                {
                    WriteLine();
                }
            }
        }
        public static int Calculation(int x, int y, int z = 0, bool printNeed = false)
        {
            int result = x + y + z;

            if (printNeed)
            {
                WriteLine(result);
            }

            return result;
        }


        // =================== PARAMS ==================================
        public static int CalculateSumm(params int[] chisla)
        {
            int summ = 0;
            for (int indx = 0; indx < chisla.Length; indx++)
            {
                summ += chisla[indx];
            }

            return summ;
        }
        public static void PrintMessages(params string[] messages)
        {
            for (int indx = 0; indx < messages.Length; indx++)
            {
                WriteLine($"Message {indx} text: {messages[indx]}");
            }
        }
    }
}