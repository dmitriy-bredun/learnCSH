using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Convert;

namespace HomeworkDenis.Tools
{
    static class CH
    {
        public static int EnterInt(string txt = null)
        {
            int? a = null;
            Write(txt);
                do
                {
                    try
                    {
                        a = ToInt32(ReadLine());
                    }
                    catch (Exception)
                    {
                         WriteLine();
                         ErrorMsg("Вы ввели неверные данные! Попробуйте снова: ");
                    }
                } while (a == null);
            return (int)a;
        }
        public static string EnterString(string txt = null)
        {
            Write(txt);
            string ourString;
            do
            {
                ourString = ReadLine();
            } while (ourString == null);
            return ourString;
        }

        public static void Print2Space()
        {
            WriteLine();
            WriteLine();
        }

        public static void ErrorMsg(string msg)
        {
            Write("ERROR: " + msg);
        }
    }
}
