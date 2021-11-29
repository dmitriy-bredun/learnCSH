using System;
using static System.Console;

namespace Lessons.Tools
{
    static class CT
    {
        public static int EnterInt(string txt)
        {
            if (!string.IsNullOrEmpty(txt))
            {
                Write(txt);
            }
            var input = ReadLine();
            return string.IsNullOrEmpty(input) ? -1 : Convert.ToInt32(input);
        }

        public static string EnterString(string txt)
        {
            if (!string.IsNullOrEmpty(txt))
            {
                Write(txt);
            }

            return ReadLine();
        }

        public static void PrintSpace2()
        {
            WriteLine();
            WriteLine();
        }

        public static void ErrorMsg(string msg)
        {
            ForegroundColor = ConsoleColor.Red;

            WriteLine();
            WriteLine("ERROR: " + msg.ToUpper());
            WriteLine();

            ForegroundColor = Program.AppForegroundColor;
        }
    }
}
