using System;

using HomeworkMargaret.General;

namespace HomeworkMargaret
{
    class ProgramMargaret
    {
        public static ConsoleColor AppForegroundColor;
        public static ConsoleColor AppBackgroundColor;

        public static void PrepareConsole()
        {
            AppBackgroundColor = ConsoleColor.Black;
            AppForegroundColor = ConsoleColor.DarkCyan;

            Console.BackgroundColor = AppBackgroundColor;
            Console.ForegroundColor = AppForegroundColor;

            Console.Clear();
        }

        static void Main(string[] args)
        {
            PrepareConsole();

            // Homework1_Variables.Start();
            // Homework2_Operations.Start();
            // Homework3_Cycles.Start();
            // Homework3_PartTwo.Start();
            // Homework3_PartThree.Start();
            // Homework4_SimpleArrays.Start();
            // Homework5_DoubleArrays.Start();
            DA_Game.Start();
        }
    }
}