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
            Write($"  {msg} = {value}");
            if (isLine)
            {
                WriteLine();
            }
        }

        public static void Print(double value, string msg = "Result", bool isLine = true)
        {
            Write($"  {msg} = {value}");

            if (isLine)
            {
                WriteLine();
            }
        }
        public static void Print(string msg, bool isLine = true)
        {
            Write("  " + msg);

            if (isLine)
            {
                WriteLine();
            }
        }
        public static void Space()
        {
            WriteLine();
            WriteLine();
        }

        public static int EnterInt(string msg)
        {
            Write("  " + msg);
            return Convert.ToInt32(ReadLine());
        }

        public static double EnterDouble(string msg)
        {
            Write("  " + msg);
            return Convert.ToDouble(ReadLine());
        }
        
        public static string EnterString(string msg)
        {
            Write("  " + msg);
            return ReadLine();
        }
        public static void ErrorMsg(string msg)
        {
            ForegroundColor = ConsoleColor.Red;

            WriteLine();
            WriteLine("!ERROR: " + msg.ToUpper());
            WriteLine();

            ForegroundColor = ProgramMargaret.AppForegroundColor;
        }
        public static int Menu(params string[] msg)
        {
            WriteLine();
            WriteLine("\t ---MENU---");
            for (int i = 0; i < msg.Length; i++)
            {
                WriteLine($"  {i + 1} ---- {msg[i]}");
            }
            WriteLine("  0 ---- EXIT");
            Write("  ---> ");

            return Convert.ToInt32(ReadLine());
        }

        public static int EnumMenu(Type enumType)
        {
            WriteLine();
            string[] items = Enum.GetNames(enumType);

            for (int i = 0; i < items.Length; i++)
            {
                WriteLine($"  {i} ---- {items[i]}");
            }
            Write("  ---> ");
            return Convert.ToInt32(ReadLine());
        }
    }
}