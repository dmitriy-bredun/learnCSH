using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkSerg.ToolsConsole
{
    internal class CT
    {
        public static int Menu(params string[] chapter)
        {
            WriteLine();
            WriteLine("             M_E_N_U    ");
            WriteLine();
            for (int i = 0; i < chapter.Length; i++)
            {
                WriteLine($"  {i + 1} ---- {chapter[i]}");
            }
            WriteLine("  0 ---- EXIT");
            Write("  ---> ");

            return Convert.ToInt32(ReadLine());
        }
    }
}
