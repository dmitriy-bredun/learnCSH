using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.Convert;

namespace HomeworkDmitriy.Tools
{
    public static class CT
    {
        public static void Space()
        {
            WriteLine();
        }
        public static void Space2()
        {
            WriteLine();
            WriteLine();
        }
        public static void Print(string text)
        {
            Write(text);
        }
        public static void PrintL(string text)
        {
            WriteLine(text);
        }
        public static void StrInt(string text, int value)
        {
            WriteLine($"{text} = {value}");
        }
        public static int Int(string text)
        {
            Write($"{text}: ");
            int val = ToInt32(ReadLine());
            return val;
        }
        public static int RandomV()
        {
            Random random = new Random();

            Write($"Введи минимальное значение: ");
            int min = ToInt32(ReadLine());

            Write($"Введи максимальное значение: ");
            int max = ToInt32(ReadLine());

            int val = random.Next(min, max);
            return val;
        }
    }
}
