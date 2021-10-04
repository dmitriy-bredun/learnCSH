using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace HomeworkMargaret.Tools
{
    static class CT
    {
        public static void Print(int value, string msg = "Result", bool isLine = true)
        {
            Write($"{msg} = {value}");
            if (isLine)
            {
                WriteLine();
            }
        }

        public static void Print(double value, string msg = "Result", bool isLine = true)
        {
            Write($"{msg} = {value}");

            if (isLine)
            {
                WriteLine();
            }
        }
        public static void Print(string msg, bool isLine = true)
        {
            Write(msg);

            if (isLine)
            {
                WriteLine();
            }
        }

        public static int EnterInt(string msg)
        {
            Write("Enter " + msg + " please: ");
            return Convert.ToInt32(ReadLine());
        }

        public static double EnterDouble(string msg)
        {
            Write("Enter " + msg + " please: ");
            return Convert.ToInt32(ReadLine());
        }

        public static string EnterString(string msg)
        {
            Write("Enter " + msg + ", please: ");
            return ReadLine();
        }
        public static void ErrorMsg(string msg)
        {
            ForegroundColor = ConsoleColor.Red;

            WriteLine();
            WriteLine("!ERROR: " + msg.ToUpper());
            WriteLine();

            ForegroundColor = ConsoleColor.White;
        }
    }
}