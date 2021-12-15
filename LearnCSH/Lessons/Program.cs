using System;

using Lessons.General;
using Lessons.General.ClassesRelationship;
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
            // CurrentLessonMargaret.StartMargaretPractice();

            // Раскомментируйте тот урок, который хотите повторить и перебилдите проект...
            // Lesson1_Variables.Start();
            // Lesson2_1TypeConversion.Start();
            // Lesson2_2Operations.Start();
            // Lesson2_3ConditionalConstructions.Start();
            // Lesson3_SwitchAndTernaryOperation.Start();
            // Lesson4_Cycles.Start();
            // Lesson5_StaticMethods.Start();
            // Lesson6_SingleArray.Start();
            // Lesson7_MultiDimensionalArrays.Start();

            // Practice1_Opearations.Start();
            // Practice2_Cycles.Start();
            // Practice2_DoubleCycles.Start();
            // Practice3_Tasks.Start();
            // Practice4_SimpleArrays.Start();
            // Practice5_VDV.Start();

            Practice6_ClassesRelationship.Start();

            // TestProgram.StartTest();
        }
    }
}
