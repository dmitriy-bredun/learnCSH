using System;

using Lessons.General;
using Lessons.Practice;
using Lessons.Test;

namespace Lessons
{
    class Program
    {
        public static ConsoleColor AppForegroundColor { get; private set; }
        public static ConsoleColor AppBackgroundColor { get; private set; }

        private static void GothamConsoleTheme()
        {
            Console.ForegroundColor = AppForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = AppBackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        static void Main(string[] args)  
        {
            GothamConsoleTheme();

            // CurrentLesson.GoGoGo();
            // CurrentLessonMargaret.Start();


            // TestProgram.StartTest();
        }////////////////////////
    }
}
